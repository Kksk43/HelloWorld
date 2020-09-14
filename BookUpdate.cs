using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BookManage
{
    public partial class BookUpdata : Form
    {
        private int selected = -1;//-1为未选定状态
        public BookUpdata()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 初始化窗体及相关设置
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BookUpdata_Load(object sender, EventArgs e)
        {
            //设置窗体大小不能改变
            MaximizeBox = false;
            MinimizeBox = false;
            FormBorderStyle = FormBorderStyle.FixedDialog;

            //各列的标题取消排序的功能
            foreach (DataGridViewColumn column in dvgUpdate.Columns)
            {
                column.SortMode = DataGridViewColumnSortMode.NotSortable;
            }
            this.dvgUpdate.AutoGenerateColumns = false;//没对上名字的信息就不需要额外添加
            this.dvgUpdate.RowsDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;//文字居中
            this.dvgUpdate.DefaultCellStyle.WrapMode = DataGridViewTriState.True;//自动换行
            this.dvgUpdate.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;//自动调整每行的高度
        }


        /// <summary>
        /// 根据选定的行来刷新textbox的内容
        /// </summary>
        /// <param name="row"></param>
        private void TextBoxsShow(DataGridViewRow row)
        {
            tbBookID.Text = row.Cells[0].Value.ToString();
            tbBookName.Text = row.Cells[1].Value.ToString();
            tbBookType.Text = row.Cells[2].Value.ToString();
            tbBookAuthor.Text = row.Cells[3].Value.ToString();
            tbBookPrice.Text = row.Cells[4].Value.ToString();
            tbBookPic.Text = row.Cells[5].Value.ToString();
            tbBookContent.Text = row.Cells[6].Value.ToString();
            tbBookIssueID.Text = row.Cells[7].Value.ToString();
            tbBookNum.Text = row.Cells[8].Value.ToString();
        }
        /// <summary>
        /// 通过图书编码来添加要修改更新的书籍
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btSelected_Click(object sender, EventArgs e)
        {
            string data_in = $"select *from bookinfo where " +//连接指向
                $"BookID='{tbBookID.Text}'";
            if (!DataAccess.TableExistOrNot(data_in))
            {
                MessageBox.Show("不存在此访问码！");
                return;
            }

            foreach (DataGridViewRow row in dvgUpdate.Rows)
            {
                if (row.IsNewRow) break;
                if (row.Cells[0].Value.ToString() == tbBookID.Text)
                {
                    MessageBox.Show("此书籍已在‘图书详细信息’框内，在对应位置勾选即可");
                    dvgUpdate.Rows[dvgUpdate.CurrentCell.RowIndex].Selected = false;
                    row.Selected = true;
                    return;
                }
            }

            DataTable dataTable = DataAccess.GetDataByTNameAndID("bookinfo", tbBookID.Text);
            dvgUpdate.Rows.Add(dataTable.Rows[0][0],
                dataTable.Rows[0][1],
                dataTable.Rows[0][2],
                dataTable.Rows[0][3],
                dataTable.Rows[0][4],
                dataTable.Rows[0][5],
                dataTable.Rows[0][6],
                dataTable.Rows[0][7],
                dataTable.Rows[0][8]);

            if (selected == -1)//第一次添加，选定行为0
            {
                selected = 0;
            }
            else//除第一次添加外，其它时候取消
            {
                dvgUpdate.Rows[selected].HeaderCell.Value = "□";
                selected = dvgUpdate.NewRowIndex - 1;
            }
            dvgUpdate.Rows[selected].HeaderCell.Value = "√";//添加的新行为选定状态

            TextBoxsShow(dvgUpdate.Rows[selected]);
        }
        /// <summary>
        /// 改变选择状态和行
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dvgUpdate_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //如果选中的不是选择范围就立即返回
            if (e.ColumnIndex != -1) return;
            if (e.RowIndex < 0 || e.RowIndex > dvgUpdate.Rows.Count - 2) return;

            //方框与勾 点击互换
            if (dvgUpdate.Rows[e.RowIndex].HeaderCell.Value.ToString() == "□")
            {
                dvgUpdate.Rows[selected].HeaderCell.Value = "□";
                dvgUpdate.Rows[e.RowIndex].HeaderCell.Value = "√";
                selected = e.RowIndex;
                TextBoxsShow(dvgUpdate.Rows[selected]);
            }
        }


        /// <summary>
        /// 刷新DGV对应行的内容
        /// </summary>
        /// <param name="row"></param>
        private void dvgRowRefresh(DataGridViewRow row)
        {
            row.Cells[1].Value = tbBookName.Text;
            row.Cells[2].Value = tbBookType.Text;
            row.Cells[3].Value = tbBookAuthor.Text;
            row.Cells[4].Value = tbBookPrice.Text;
            row.Cells[5].Value = tbBookPic.Text;
            row.Cells[6].Value = tbBookContent.Text;
            row.Cells[7].Value = tbBookIssueID.Text;
            row.Cells[8].Value = tbBookNum.Text;
        }
        /// <summary>
        /// “更新”按钮
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btUpdate_Click(object sender, EventArgs e)
        {
            if (tbBookID.Text == "" ||
                tbBookType.Text == "" ||
                tbBookName.Text == "" ||
                tbBookAuthor.Text == "" ||
                tbBookPrice.Text == "" ||
                tbBookContent.Text == "" ||
                tbBookIssueID.Text == "" ||
                tbBookNum.Text == "")
            {
                MessageBox.Show("除了书本封面外，其它信息为必填项！");
                return;
            }

            if(selected == -1)
            {
                MessageBox.Show("尚未选定要更新的书本！(先选择，再在详细信息框内勾选)");
                return;
            }

            DataAccess.UADDataTable($"update bookinfo set " +
                $"BookName='{tbBookName.Text}'," +
                $"BookType='{tbBookType.Text}'," +
                $"BookAuthor='{tbBookAuthor.Text}'," +
                $"BookPrice='{tbBookPrice.Text}'," +
                $"BookPic='{tbBookPic.Text}'," +
                $"BookContent='{tbBookContent.Text}'," +
                $"BookIssue='{tbBookIssueID.Text}'," +
                $"BookSp='{tbBookNum.Text}' where BookID={tbBookID.Text}");

            MessageBox.Show("更新成功！");
            dvgRowRefresh(dvgUpdate.Rows[selected]);
        }

        /// <summary>
        /// “删除”按钮
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btDel_Click(object sender, EventArgs e)
        {
            if (tbBookID.Text == "")
            {
                MessageBox.Show("书籍编号不能为空！");
                return;
            }
            if(selected == -1)
            {
                MessageBox.Show("尚未选定要删除的书本！(先选择，再在详细信息框内勾选)");
                return;
            }
            if (MessageBox.Show($"确定要删除这本书吗？", "删除确认", MessageBoxButtons.YesNo) == DialogResult.No)
            {
                return;
            }
            else
            {
                DataAccess.UADDataTable($"delete from issueinfo where BookID={tbBookID.Text}");
            }

            MessageBox.Show("删除成功！");
            //刷新DGV和textbox
            dvgUpdate.Rows.RemoveAt(selected);
            TextBoxsShow(dvgUpdate.Rows[dvgUpdate.NewRowIndex]);
            selected = -1;
        }
    }
}
