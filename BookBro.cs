using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using Renci.SshNet.Messages;

namespace BookManage
{
    public partial class BookBro : Form
    {
        private DataSet dataSet;
        private DataTable dt_Issue;
        private int numSelected = -2;//-2为未登陆状态
        private int total = 0;
        private bool manualCheck = false;
        private bool bookID = false;//屏蔽关闭
        private bool bookName = false;
        private bool date = false;
        public BookBro()
        {
            InitializeComponent();
        }
        /// <summary>
        /// 相关模式初始化
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BookBro_Load(object sender, EventArgs e)
        {
            //设置窗体大小不能改变
            MaximizeBox = false;
            MinimizeBox = false;
            FormBorderStyle = FormBorderStyle.FixedDialog;

            //各列的标题取消排序的功能
            foreach (DataGridViewColumn column in dvgBro.Columns)
            {
                column.SortMode = DataGridViewColumnSortMode.NotSortable;
            }
            this.dvgBro.AutoGenerateColumns = false;//没对上名字的信息就不需要额外添加
            this.dvgBro.RowsDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;//文字居中
            this.dvgBro.DefaultCellStyle.WrapMode = DataGridViewTriState.True;//自动换行
            this.dvgBro.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;//自动调整每行的高度
            textPW.PasswordChar = '*';//设置密码字符
            textBookID.ReadOnly = true;
            textBookName.ReadOnly = true;
            cbDate.Enabled = false;
            checkAllBook.Enabled = false;
            checkAll.Enabled = false;
        }


        /// <summary>
        /// 刷新显示借阅清单
        /// </summary>
        private void BroListRefresh()
        {
            string data_in;
            //连接到该用户的借阅信息表
            data_in = $"select *from issueinfo where " +
                $"IssBookID='{textBroID.Text}'";
            dataSet = DataAccess.GetDataSetBySql(data_in);//建立虚拟数据库存储相关数据
            dt_Issue = dataSet.Tables[0];//获取虚拟表

            //每次刷新时都会把上次查询的信息清理掉(包括所有书和借阅日期，combobox的书名文本，对应的作者和借阅日期文本)
            textBookID.Clear();
            textBookName.Clear();
            textAuthor.Clear();
            this.cbDate.Items.Clear();
            cbDate.Text = null;

            //把获取的虚拟表对应的书名和借阅信息自动填充到各自的combobox中
            for (int i = 0; i < dt_Issue.Rows.Count; i++)
            {
                if (!cbDate.Items.Contains(dt_Issue.Rows[i]["IssDateTime"].ToString()))
                {
                    this.cbDate.Items.Add(dt_Issue.Rows[i]["IssDateTime"].ToString());
                }
            }
            if (dt_Issue.Rows.Count > 0)//如果虚拟表不空，则可以显示选项
            {
                checkAllBook.Visible = true;
            }
            else
            {
                checkAllBook.Visible = false;
            }

            //绑定数据到框中，把所有借阅信息都显示出来
            this.dvgBro.DataSource = dt_Issue;
            //取消选中(0,0)的单元格
            this.dvgBro.Rows[0].Cells[0].Selected = false;
            total = dt_Issue.Rows.Count;

            //所有借阅信息的行头都标志'□'，逾期则显示已逾期
            DateTime dateTime = DateTime.Now;
            for (int i = 0; i < dvgBro.Rows.Count - 1; i++)
            {
                if (DateTime.Compare(dateTime, (DateTime)dvgBro.Rows[i].Cells["ReturnDate"].Value) > 0)
                {
                    dvgBro.Rows[i].HeaderCell.Value = "已逾期";
                }
                else
                {
                    dvgBro.Rows[i].HeaderCell.Value = "□";
                }
            }

            //判断数据表格是否为空
            if (dvgBro.Rows.Count > 1)
            {
                numSelected = 0;//未勾选要还的书
            }
            else
            {
                numSelected = -1;//借阅清单为空
            }
            checkAll.Checked = false;

            //默认选所有书
            if (dt_Issue.Rows.Count > 0)
            {
                checkAllBook.Checked = true;
            }
        }
        /// <summary>
        /// 查询按钮触发，检验借阅者证号密码，刷新显示其借阅清单
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BroSearch_Click(object sender, EventArgs e)
        {
            //如果借阅证号和密码均为空，提前返回
            if (textBroID.Text.Length == 0 || textPW.Text.Length == 0)
            {
                MessageBox.Show("借阅证号和密码都不能为空！");
                return;
            }

            //检查证号和密码的是否存在以及匹配
            string data_in = $"select *from userinfo where " +//连接指向
                $"UBookID='{textBroID.Text}' and " +
                $"UPwdype='{textPW.Text}'";
            if (!DataAccess.TableExistOrNot(data_in))//检查是否存在这个用户
            {
                MessageBox.Show("借阅证号和证号密码不匹配（请重新核对）  X﹏X");
                return;//匹配立即返回
            }
            else
            {
                textBroID.ReadOnly = true;//匹配正确锁定账号密码，不允许频繁更改
                textBroID.ShortcutsEnabled = false;
                textPW.ReadOnly = true;
                textPW.ShortcutsEnabled = false;

                textBookID.ReadOnly = false;//账号密码配对成功后显示
                textBookName.ReadOnly = false;
                cbDate.Enabled = true;
                checkAllBook.Enabled = true;
                checkAll.Enabled = true;
            }

            //存在此用户，刷新界面获取信息
            this.BroListRefresh();
        }


        /// <summary>
        /// DGV上的手动选择操作
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dvgBro_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //如果选中的不是选择范围就立即返回
            if (e.ColumnIndex != -1) return;
            if (e.RowIndex < 0 || e.RowIndex > dvgBro.Rows.Count - 2) return;

            //方框与勾 点击互换
            manualCheck = true;//开启手动选择模式
            if (dvgBro.Rows[e.RowIndex].HeaderCell.Value.ToString() == "□")
            {
                numSelected++;
                dvgBro.Rows[e.RowIndex].HeaderCell.Value = "√";
            }
            else if (dvgBro.Rows[e.RowIndex].HeaderCell.Value.ToString() == "√")
            {
                numSelected--;
                dvgBro.Rows[e.RowIndex].HeaderCell.Value = "□";
                if (checkAll.Checked == true) checkAll.Checked = false;//在全选的基础上手动取消，全选关闭
            }
            if (numSelected == dvgBro.Rows.Count - 2) checkAll.Checked = true;//手动选择全部，全选开启
            manualCheck = false;//关闭手动选择模式
        }
        /// <summary>
        /// 全选框，在非手动的情况下将所有能操作的字段选上/取消
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void checkAll_CheckedChanged(object sender, EventArgs e)
        {
            if (manualCheck) return;//要求当前状态不是手动选择状态才能自动操作

            if (checkAll.Checked)
            {
                numSelected = 0;
                foreach (DataGridViewRow row in dvgBro.Rows)
                {
                    if (row.IsNewRow) break;//是新行就结束
                    if (row.HeaderCell.ToString() != "已逾期")
                    {
                        row.HeaderCell.Value = "√";
                        numSelected++;
                    }
                }
                if (numSelected == 0)
                {
                    checkAll.Checked = false;
                    MessageBox.Show("清单为空！");
                }
            }
            else
            {
                numSelected = 0;
                foreach (DataGridViewRow row in dvgBro.Rows)
                {
                    if (row.IsNewRow) break;//是新行就结束
                    if (row.HeaderCell.Value.ToString() == "√")
                    {
                        row.HeaderCell.Value = "□";
                    }
                }
            }
        }


        /// <summary>
        /// 勾选显示借阅清单上的所有书籍
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void checkAllBook_CheckedChanged(object sender, EventArgs e)
        {
            if (checkAllBook.Checked == true)
            {
                //屏蔽开启
                bookID = true;
                bookName = true;
                date = true;

                textBookID.Clear();
                textBookName.Clear();
                textAuthor.Clear();
                cbDate.Text = null;

                //屏蔽关闭
                bookID = false;
                bookName = false;
                date = false;

                foreach (DataGridViewRow row in dvgBro.Rows)
                {
                    if (!row.IsNewRow)
                    {
                        row.Visible = true;
                    }
                }
            }
        }
        /// <summary>
        /// 显示/隐藏部分行
        /// </summary>
        /// <param name="table"></param>
        /// <param name="boxtext"></param>
        private void SelectedShield(string table, string boxtext)
        {
            try
            {
                //取消当前活跃行，避免隐藏失败
                if (dvgBro.CurrentCell != null) dvgBro.CurrentCell = null;
                //详细信息框显示复选框中选定的文本相关的行，其他隐藏
                for (int i = 0; i < dvgBro.Rows.Count - 1; i++)
                {
                    //cell中的索引器是设计名
                    if (dvgBro.Rows[i].Cells[table].Value.ToString() == boxtext)
                    {
                        dvgBro.Rows[i].Visible = true;
                    }
                    else
                    {
                        dvgBro.Rows[i].Visible = false;
                    }
                }
            }
            catch (Exception)
            {
                throw;
            }

        }
        /// <summary>
        /// 书名手动输入带来的访问码、作者、借阅日期、DGV显示上的变化
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void textBookName_TextChanged(object sender, EventArgs e)
        {
            if (textBookName.Text == null || bookName == true) return;
            checkAllBook.Checked = false;

            try
            {
                //屏蔽其他事件的响应
                bookID = true;
                date = true;

                bool first = false;
                string tempBookID = null;
                string tempDate = null;
                foreach (DataRow row in dt_Issue.Rows)
                {
                    if (row["BookName"].ToString() == textBookName.Text)
                    {
                        if (!first)
                        {
                            textAuthor.Text = row["BookAuthor"].ToString();
                            tempBookID = row["BookID"].ToString();
                            tempDate = row["IssDateTime"].ToString();
                            first = true;
                        }
                        else
                        {
                            tempBookID = null;
                            tempDate = null;
                            break;
                        }
                    }
                }
                if (tempBookID != null)
                {
                    textBookID.Text = tempBookID;
                }
                else
                {
                    textBookID.Clear();
                }
                cbDate.Text = tempDate;

                //恢复其他事件的响应
                bookID = false;
                date = false;

                SelectedShield("BroBook", textBookName.Text);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        /// <summary>
        /// 借阅日期上的变动
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cbDate_SelectedIndexChanged(object sender, EventArgs e)
        {
            //因为书名事件中会将该文本清空，SelectedIndex变为-1，触发该事件，要及时结束该事件
            if (cbDate.SelectedIndex == -1 || date == true) return;
            checkAllBook.Checked = false;

            //屏蔽开启
            bookName = true;
            bookID = true;

            textBookID.Clear();
            textBookName.Clear();
            textAuthor.Clear();

            //屏蔽关闭
            bookName = false;
            bookID = false;

            SelectedShield("BroDate", cbDate.Text);
        }
        /// <summary>
        /// 图书访问码的变化
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void textBookID_TextChanged(object sender, EventArgs e)
        {
            if (textBookID.Text == null || bookID == true) return;
            checkAllBook.Checked = false;

            //屏蔽开启
            bookName = true;
            date = true;

            for (int i = 0; i < dt_Issue.Rows.Count; i++)
            {
                if (dt_Issue.Rows[i]["BookID"].ToString().Trim() == textBookID.Text)
                {
                    textBookName.Text = dt_Issue.Rows[i]["BookName"].ToString();
                    textAuthor.Text = dt_Issue.Rows[i]["BookAuthor"].ToString();
                    cbDate.Text = dt_Issue.Rows[i]["IssDateTime"].ToString();
                    break;
                }
            }

            //屏蔽关闭
            bookName = false;
            date = false;

            SelectedShield("BroBookID", textBookID.Text);
        }


        /// <summary>
        /// 检查勾选状态
        /// </summary>
        /// <returns></returns>
        private bool ChecknumSelected()
        {
            if (numSelected == -2)
            {
                MessageBox.Show("请先填写好您的个人借阅证号以及密码并点击查询  X﹏X");
                return false;
            }
            else if (numSelected == -1)
            {
                MessageBox.Show("您没有可还/续借的书（借阅清单为空）  (°ー°〃)");
                return false;
            }
            else if (numSelected == 0)
            {
                MessageBox.Show("请选择你要还/续借的书（详细信息框内勾选）  >_<");
                return false;
            }
            return true;
        }
        /// <summary>
        /// 还书，根据被选中书的数量和标记来做出反应
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btReturn_Click(object sender, EventArgs e)
        {
            if (!ChecknumSelected()) return;

            if (MessageBox.Show($"确定要还这{numSelected}本书吗？", "还书确认", MessageBoxButtons.YesNo) == DialogResult.No)
            {
                return;
            }
            else
            {
                string rid;
                string id;
                int surplus;
                string data_del = "delete from issueinfo where IssID=";
                string data_upd_p1 = "update bookinfo set BookSp='";
                string data_upd_p2 = "' where BookID=";
                string data_upd;
                DataTable dataTable;
                foreach (DataGridViewRow row in dvgBro.Rows)
                {
                    if (row.IsNewRow) break;//是新行就结束
                    if (row.HeaderCell.Value.ToString() == "√")
                    {
                        id = row.Cells["BroBookID"].Value.ToString();
                        dataTable = DataAccess.GetDataByTNameAndID("bookinfo", id);
                        surplus = Convert.ToInt32(dataTable.Rows[0]["BookSp"])+1;//剩余量增加
                        
                        data_upd = data_upd_p1 +
                            surplus +
                            data_upd_p2 +
                            row.Cells["BroBookID"].Value;
                        DataAccess.UADDataTable(data_upd);//更新书库中同名书的数量

                        rid = row.Cells["RID"].Value.ToString();//获取相应书本的issid
                        DataAccess.UADDataTable(data_del + rid);//删除issueinfo表中对应的内容

                    }
                }
                DataAccess.UADDataTable($"update userinfo set UBor='{total-numSelected}' where UBookID={textBroID.Text}");

                //删除完后刷新当前界面
                this.BroListRefresh();
                MessageBox.Show("还书成功！  ↖(^ω^)↗");
            }
        }
        /// <summary>
        /// 续借，根据被选中数的数量和标记来做出反应
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnRenew_Click(object sender, EventArgs e)
        {
            if (!ChecknumSelected()) return;

            if (MessageBox.Show($"确定要续借这{numSelected}本书吗？", "还书确认", MessageBoxButtons.YesNo) == DialogResult.No)
            {
                return;
            }
            else
            {
                int numRenew = 0;
                int numAll = 0;
                string data_in_p1 = "update issueinfo set IssDTLimite='";
                string data_in_p2 = "',RenewTimes=1 where IssID=";
                string data_in;

                DateTime newLimite;
                foreach (DataGridViewRow row in dvgBro.Rows)
                {
                    if (row.IsNewRow) break;//是新行就结束
                    if (row.HeaderCell.Value.ToString() == "√")
                    {
                        numAll++;
                        if (row.Cells["BroRenew"].Value.ToString() == "1")
                        {
                            numRenew++;
                            continue;
                        }
                        try
                        {
                            DateTime.TryParse(row.Cells["ReturnDate"].Value.ToString(), out newLimite);
                        }
                        catch (Exception ex)
                        {
                            throw new Exception(ex.Message);
                        }
                        newLimite = newLimite.AddDays(30);
                        data_in = data_in_p1 +
                            newLimite.Date.ToString() +
                            data_in_p2 +
                            row.Cells["RID"].Value.ToString();
                        DataAccess.UADDataTable(data_in);//更改issueinfo表中对应的内容
                    }
                }

                //删除完后刷新当前界面
                this.BroListRefresh();
                if (numRenew == 0)
                {
                    MessageBox.Show("续借成功！  ↖(^ω^)↗");
                }
                else if (numRenew != numAll)
                {
                    MessageBox.Show($"续借成功！(有{numRenew}本书已续借一次，不能再续借)");
                }
                else
                {
                    MessageBox.Show($"续借失败！（您所选的书本均已续借一次，不能再续借）  -_-");
                }
            }
        }


        /// <summary>
        /// 关闭界面
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {

        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        private void textName_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
