using System;
using System.Windows.Forms;

namespace BookManage
{
    public partial class BookAdd : Form
    {
        public BookAdd()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 界面初始化
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BookAdd_Load(object sender, EventArgs e)
        {
            //设置窗体大小不能改变
            MaximizeBox = false;
            MinimizeBox = false;
            FormBorderStyle = FormBorderStyle.FixedDialog;

            //各列的标题取消排序的功能
            foreach (DataGridViewColumn column in dvgBookShow.Columns)
            {
                column.SortMode = DataGridViewColumnSortMode.NotSortable;
            }
            this.dvgBookShow.AutoGenerateColumns = false;//没对上名字的信息就不需要额外添加
            this.dvgBookShow.RowsDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;//文字居中
            this.dvgBookShow.DefaultCellStyle.WrapMode = DataGridViewTriState.True;//自动换行
            this.dvgBookShow.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;//自动调整每行的高度
        }

        /// <summary>
        /// “插入”按钮
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btInsert_Click(object sender, EventArgs e)
        {
            if(tbBookType.Text == null||
                tbBookName.Text == null||
                tbBookAuthor.Text == null||
                tbBookPrice.Text == null||
                tbBookContent.Text == null||
                tbBookIssueID.Text == null||
                tbBookNum.Text == null)
            {
                MessageBox.Show("除了书本封面外，其它信息为必填项！");
                return;
            }

            string data_insert = "insert into bookinfo(BookName,BookType,BookAuthor,BookPrice,BookContent,BookIssue,BookSp)values(";
            string data_add;

            data_add = data_insert + "'" +
                tbBookName.Text + "','" +
                tbBookType.Text + "','" +
                tbBookAuthor.Text + "','" +
                tbBookPrice.Text + "','" +
                tbBookContent.Text + "','" +
                tbBookIssueID.Text + "','" +
                tbBookNum.Text+"')";

            //添加进数据库的bookinfo表中
            if (DataAccess.UADDataTable(data_add))
            {
                MessageBox.Show("添加成功！");
            }
            else
            {
                MessageBox.Show("添加失败！");
            }

            //把入库的书的状况显示到表中
            dvgBookShow.Rows.Add(tbBookType.Text,
                tbBookName.Text,
                tbBookAuthor.Text,
                tbBookPrice.Text,
                null,
                tbBookContent.Text,
                tbBookIssueID.Text,
                tbBookNum.Text);

            //清除所有TextBox控件中的内容
            tbBookName.Clear();
            tbBookType.Clear();
            tbBookAuthor.Clear();
            tbBookPrice.Clear();
            tbBookContent.Clear();
            tbBookIssueID.Clear();
            tbBookPic.Clear();
            tbBookNum.Clear();
        }

        /// <summary>
        /// “退出”按钮
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btBack_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
