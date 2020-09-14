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

namespace BookManage
{
    public partial class BookBorrow : Form
    {
        private int numSelected = -2;
        private int maxSelected;
        private int total;
        private string userName;
        private bool manualCheck = false;
        public BookBorrow()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 相关模式初始化
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BookBorrow_Load(object sender, EventArgs e)
        {
            //设置窗体大小不能改变
            MaximizeBox = false;
            MinimizeBox = false;
            FormBorderStyle = FormBorderStyle.FixedDialog;

            //各列的标题取消排序的功能
            foreach (DataGridViewColumn column in dvgBookSel.Columns)
            {
                column.SortMode = DataGridViewColumnSortMode.NotSortable;
            }
            this.dvgBookSel.AutoGenerateColumns = false;//没对上名字的信息就不需要额外添加
            this.dvgBookSel.RowsDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;//文字居中
            this.dvgBookSel.DefaultCellStyle.WrapMode = DataGridViewTriState.True;//自动换行
            this.dvgBookSel.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;//自动调整每行的高度
            tbPW.PasswordChar = '*';//设置密码字符
            tbBookID.Enabled = false;
            btSelected.Enabled = false;
            checkAll.Enabled = false;
        }


        /// <summary>
        /// 指定书本编码只能为数字或字母
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tbBookID_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(e.KeyChar == '\b' ||
                e.KeyChar >= '0' && e.KeyChar <= '9' ||
                e.KeyChar >= 'A' && e.KeyChar <= 'Z' ||
                e.KeyChar >= 'a' && e.KeyChar <= 'z'))
            {
                e.Handled = true;
            }
        }
        /// <summary>
        /// 登录检测
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btLogin_Click(object sender, EventArgs e)
        {
            //如果借阅证号和密码均为空，提前返回
            if (tbAccount.Text.Length == 0 || tbPW.Text.Length == 0)
            {
                MessageBox.Show("借阅证号和密码都不能为空！");
                return;
            }

            //检查证号和密码的是否存在以及匹配
            string data_in = $"select *from userinfo where " +//连接指向
                $"UBookID='{tbAccount.Text}' and " +
                $"UPwdype='{tbPW.Text}'";
            if (!DataAccess.TableExistOrNot(data_in))//检查是否存在这个用户
            {
                MessageBox.Show("借阅证号和证号密码不匹配（请重新核对）  X﹏X");
                return;//匹配立即返回
            }
            tbAccount.Enabled = false;//账号密码匹配后禁止修改
            tbPW.Enabled = false;
            btLogin.Enabled = false;

            tbBookID.Enabled = true;//开启搜索对应ID的书
            btSelected.Enabled = true;

            DataTable dt = DataAccess.GetDataByTNameAndID("userinfo",tbAccount.Text);
            numSelected = -1;//选择状态（登录但未输入书本ID）
            maxSelected = 10-Convert.ToInt32(dt.Rows[0]["UBor"]);//最多能勾选借阅的书的数量
            userName = dt.Rows[0]["UName"].ToString();//用户名字
        }


        /// <summary>
        /// 通过选择按钮添加借阅书籍
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btSelected_Click(object sender, EventArgs e)
        {
            if(numSelected == maxSelected||maxSelected == 0)
            {
                MessageBox.Show("已达最大借阅量(加上已借的总共10本)");
                return;
            }
            string data_in = $"select *from bookinfo where " +//连接指向
                $"BookID='{tbBookID.Text}'";
            if (!DataAccess.TableExistOrNot(data_in))
            {
                MessageBox.Show("不存在此访问码！");
                return;
            }
            if (total == maxSelected)
            {
                checkAll.Enabled = false;
            }
            DataTable dt = DataAccess.GetDataByTNameAndID("bookinfo",tbBookID.Text);
            dvgBookSel.Rows.Add();
            dvgBookSel.Rows[dvgBookSel.NewRowIndex - 1].Cells[0].Value = dt.Rows[0]["BookID"];
            dvgBookSel.Rows[dvgBookSel.NewRowIndex - 1].Cells[1].Value = dt.Rows[0]["BookType"];
            dvgBookSel.Rows[dvgBookSel.NewRowIndex - 1].Cells[2].Value = dt.Rows[0]["BookName"];
            dvgBookSel.Rows[dvgBookSel.NewRowIndex - 1].Cells[3].Value = dt.Rows[0]["BookAuthor"];
            dvgBookSel.Rows[dvgBookSel.NewRowIndex - 1].Cells[4].Value = dt.Rows[0]["BookSp"];

            if (dt.Rows[0]["BookSp"].ToString() == "0")//检查库存，标记行头
            {
                dvgBookSel.Rows[dvgBookSel.NewRowIndex-1].HeaderCell.Value = "已借完";
            }
            else
            {
                if (numSelected == -1)//如果检索的书可借阅则numSelected正常化
                {
                    numSelected = 0;
                    checkAll.Enabled = true;

                    manualCheck = true;
                    checkAll.Checked = true;
                    manualCheck = false;
                }
                dvgBookSel.Rows[dvgBookSel.NewRowIndex-1].HeaderCell.Value = "√";
                numSelected++;
                total++;
            }
        }


        /// <summary>
        /// DVG上的手动选择操作
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dvgBookSel_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //如果选中的不是选择范围就立即返回
            if (e.ColumnIndex != -1) return;
            if (e.RowIndex < 0 || e.RowIndex > dvgBookSel.Rows.Count - 2) return;
            
            //方框与勾 点击互换
            manualCheck = true;//开启手动选择模式
            if (dvgBookSel.Rows[e.RowIndex].HeaderCell.Value.ToString() == "□")
            {
                if (numSelected == maxSelected || maxSelected == 0)
                {
                    MessageBox.Show("已达最大借阅量(加上已借的总共10本)");
                    return;
                }
                numSelected++;
                dvgBookSel.Rows[e.RowIndex].HeaderCell.Value = "√";
            }
            else if (dvgBookSel.Rows[e.RowIndex].HeaderCell.Value.ToString() == "√")
            {
                numSelected--;
                dvgBookSel.Rows[e.RowIndex].HeaderCell.Value = "□";
                if (checkAll.Checked == true)//在全选的基础上手动取消，全选关闭
                {
                    checkAll.Checked = false;
                }
            }
            if (numSelected == dvgBookSel.Rows.Count - 1) checkAll.Checked = true;//手动选择全部，全选开启
            manualCheck = false;//关闭手动选择模式
        }
        /// <summary>
        /// 全选
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void checkAll_CheckedChanged(object sender, EventArgs e)
        {
            if (checkAll.Checked == true&&manualCheck == false)
            {
                numSelected = 0;
                foreach (DataGridViewRow row in dvgBookSel.Rows)
                {
                    if (row.IsNewRow) break;
                    if (row.HeaderCell.Value.ToString() != "已逾期")
                    {
                        row.HeaderCell.Value = "√";
                        numSelected++;
                    }
                }
            }
        }


        /// <summary>
        /// 借阅所选书籍
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btBorrow_Click(object sender, EventArgs e)
        {
            List<string> sp = new List<string>();
            if (numSelected == -2)
            {
                MessageBox.Show("请先填写好您的个人借阅证号以及密码并点击登录  X﹏X");
                return;
            }
            else if (numSelected == -1)
            {
                MessageBox.Show("请输入您要借阅的书的编码  >_<");
                return;
            }
            else if (numSelected == 0)
            {
                MessageBox.Show("请选择你要借阅的书（行头框内勾选）  >_<");
                return;
            }

            if (MessageBox.Show($"确定要借这{numSelected}本书吗？", "借书确认", MessageBoxButtons.YesNo) == DialogResult.No)
            {
                return;
            }
            else
            {
                int surplus;
                DateTime dtN = DateTime.Now.Date;
                DateTime dtL = dtN.AddDays(30);
                string id;
                string data_insert = "insert into issueinfo(BookID,IssBookID,IssDateTime,BookName,UName,BookAuthor,IssDTLimite,RenewTimes)values(";
                string data_add;
                string data_upd_p1 = "update bookinfo set BookSp='";
                string data_upd_p2 = "' where BookID=";
                string data_upd;
                DataTable dt;

                foreach (DataGridViewRow row in dvgBookSel.Rows)
                {
                    if (row.IsNewRow) break;//是新行就结束
                    if (row.HeaderCell.Value.ToString() == "√")
                    {
                        id = row.Cells["BroBookID"].Value.ToString();//获取相应书本的id
                        dt = DataAccess.GetDataByTNameAndID("bookinfo", id);//根据id搜索相应行
                        surplus = Convert.ToInt32(dt.Rows[0]["BookSp"]) - 1;//剩余量减少

                        if (surplus < 0)//如果剩余量不够，跳过此书的借阅
                        {
                            if (!sp.Contains(row.Cells["BroBookName"].Value.ToString()))
                            {
                                sp.Add(row.Cells["BroBookName"].Value.ToString());
                                row.HeaderCell.Value = "□";
                                numSelected--;
                            }
                            continue;
                        }

                        data_upd = data_upd_p1 +
                            surplus +
                            data_upd_p2 +
                            row.Cells["BroBookID"].Value;
                        DataAccess.UADDataTable(data_upd);//更新书库中同名书的数量

                        data_add = data_insert+
                            id+",'" +
                            tbAccount.Text+"','"+
                            dtN + "','" +
                            row.Cells["BroBookName"].Value + "','" +
                            userName + "','" +
                            row.Cells["BroBookAuthor"].Value + "','" +
                            dtL + "','0')";
                        DataAccess.UADDataTable(data_add);//借阅清单增加
                    }
                }
                DataAccess.UADDataTable($"update userinfo set UBor='{10 - maxSelected + numSelected}' where UBookID={tbAccount.Text}");//读者信息更新
            }

            dvgBookSel.Rows.Clear();
            maxSelected = maxSelected - numSelected;
            numSelected = -1;
            total = 0;
            checkAll.Checked = false;
            if (sp.Count > 0)
            {
                string tempMes = null;
                foreach (var item in sp)
                {
                    tempMes += "《"+item+"》 ";
                }
                MessageBox.Show($"部分图书借阅成功（以下图书已借完：{tempMes}）");
            }
            else
            {
                MessageBox.Show("借阅成功  ↖(^ω^)↗");
            }
        }
    }
}
