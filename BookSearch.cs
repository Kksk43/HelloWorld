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
    public partial class BookSearch : Form
    {
        public BookSearch()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string cbo1 = this.comboBox1.Text;
            string cbo2 = this.comboBox2.Text;
            string booktype = this.comboTypes.Text;
            string bookname = this.textName.Text;
            string bookcontent = this.textContent.Text;

            string data_in = $"select *from bookinfo where " +
                $"BookType='{booktype}' {cbo1} " +
                $"BookName like '%{bookname}%' {cbo2} " +
                $"BookContent like '%{bookcontent}%'";

            //string data_in = "bookinfo";
            //DataTable dataTable = DataAccess.GetDataByTableName(data_in);
            //不可用GetDataByTableName这个方法，因为此方法的路径和查询方式已固定

            DataSet ds = DataAccess.GetDataSetBySql(data_in);
            DataTable dataTable = ds.Tables[0];//访问虚拟数据库dataTable的第一个表

            this.dvgBookSearch.DataSource = dataTable;
            //在BookSearch界面中设置好Columns集合的各个数据名称使得与虚拟数据库中表的列名相对应相匹配,否则表没有数据
            //数据都在后面自动生成的列里面，它们的列名字跟数据库中的是一样的

            //this.dvgBookSearch[0, 0].Value = "a";
            //除了绑定数据集来显示在表上的方法外，还可以手动显示(非绑定模式)，不过效率可能比较低
        }

        private void BookSearch_Load(object sender, EventArgs e)//图书搜索界面初始化
        {
            //设置窗体大小不能改变
            MaximizeBox = false;
            MinimizeBox = false;
            FormBorderStyle = FormBorderStyle.FixedDialog;

            //图书列表组合框初始化
            string data_in = "select distinct BookType from bookinfo";
            DataSet dataSet = DataAccess.GetDataSetBySql(data_in);
            DataTable dataTable = dataSet.Tables[0];
            for (int i = 0; i < dataTable.Rows.Count; i++)
            {
                this.comboTypes.Items.Add(dataTable.Rows[i][0].ToString().Trim());
            }
            this.comboBox1.Items.Add("or");
            this.comboBox1.Items.Add("and");
            this.comboBox1.SelectedIndex = 0;

            this.comboBox2.Items.Add("or");
            this.comboBox2.Items.Add("and");
            this.comboBox2.SelectedIndex = 0;

            this.comboTypes.SelectedIndex = 0;

            for (int i = 0; i < dvgBookSearch.Columns.Count; i++)
            {
                dvgBookSearch.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            }
            this.dvgBookSearch.AutoGenerateColumns = false;
            this.dvgBookSearch.RowsDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            this.dvgBookSearch.DefaultCellStyle.WrapMode = DataGridViewTriState.True;//自动换行
            this.dvgBookSearch.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;//自动调整每行的高度
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
