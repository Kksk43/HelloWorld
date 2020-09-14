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
    public partial class Form_Main : Form
    {
        static public DialogResult result;
        private bool mana = true;
        public Form_Main()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;

            pictureBox1.Dock = DockStyle.Fill; //填充整个Form大小dao
            pictureBox1.BackColor = Color.Transparent; //设置dao背景色透明
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage; //设置图片大小可随窗体大小拉容伸或收缩 
        }
        public bool CheckChildfrm(string childfrmname)
        {
            foreach (var childFrm in this.MdiChildren)
            {
                if(childFrm.Name == childfrmname)
                {
                    if (childFrm.WindowState == FormWindowState.Minimized)
                        childFrm.WindowState = FormWindowState.Maximized;
                    childFrm.Activate();
                    return true;
                }
            }
            return false;
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            this.BookWarehouse.Enabled = false;//非管理员权限不可触发事件(包括入库和两个更新)
            this.BookUpdate.Enabled = false;
            this.BookUpdate2.Enabled = false;
        }

        private void toolStripComboBox1_Click(object sender, EventArgs e)
        {

        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void toolStripTextBox1_Click(object sender, EventArgs e)
        {

        }

        private void Login_Click(object sender, EventArgs e)//菜单-用户管理-登录
        {
            if (CheckChildfrm("ManaLog") == true) return;
            ManaLog user = new ManaLog(mana);
            result = user.ShowDialog();
            if (result == DialogResult.Yes)
            {
                this.BookWarehouse.Enabled = true;
                this.BookUpdate.Enabled = true;
                this.BookUpdate2.Enabled = true;
                mana = false;
            }
            else if(result == DialogResult.No)
            {
                this.BookWarehouse.Enabled = false;
                this.BookUpdate.Enabled = false;
                this.BookUpdate2.Enabled = false;
                mana = true;
            }
        }

        private void UserManage_Click(object sender, EventArgs e)
        {
            
            
        }

        private void Login_Click_1(object sender, EventArgs e)//工具-登录
        {
            if (CheckChildfrm("ManaLog") == true) return;
            ManaLog user = new ManaLog(mana);
            result = user.ShowDialog();
            if (result == DialogResult.Yes)
            {
                this.BookWarehouse.Enabled = true;
                this.BookUpdate.Enabled = true;
                this.BookUpdate2.Enabled = true;
                mana = false;
            }
            else if (result == DialogResult.No)
            {
                this.BookWarehouse.Enabled = false;
                this.BookUpdate.Enabled = false;
                this.BookUpdate2.Enabled = false;
                mana = true;
            }
        }

        private void BookWarehouse_Click(object sender, EventArgs e)//菜单-图书管理-图书入库
        {
            if (CheckChildfrm("BookAdd") == true) return;
            BookAdd bookadd = new BookAdd();
            //bookadd.MdiParent = this;
            bookadd.Show();
        }

        private void BookManage_Click(object sender, EventArgs e)
        {

        }

        private void BookUpdate_Click(object sender, EventArgs e)//菜单-图书管理-图书更新
        {
            if (CheckChildfrm("BookUpdata") == true) return;
            BookUpdata bookUpdata = new BookUpdata();
            //bookUpdata.MdiParent = this;
            bookUpdata.Show();
        }

        private void BookUpdate2_Click(object sender, EventArgs e)//工具-图书更新
        {
            if (CheckChildfrm("BookUpdata") == true) return;
            BookUpdata bookUpdata = new BookUpdata();
            //bookUpdata.MdiParent = this;
            bookUpdata.Show();
        }

        private void BookBorrow1_Click(object sender, EventArgs e)
        {
            if (CheckChildfrm("BookBro") == true)
                return;
            BookBro bookBro = new BookBro();
            bookBro.MdiParent = this;
            bookBro.Show();
        }

        private void BookBorrow2_Click(object sender, EventArgs e)//工具-图书归还
        {
            if (CheckChildfrm("BookBro") == true) return;
            BookBro bookBro = new BookBro();
            //bookBro.MdiParent = this;
            bookBro.Show();
        }

        private void menuBookBro_Click(object sender, EventArgs e)//菜单-图书借阅
        {
            if (CheckChildfrm("BookBorrow") == true) return;
            BookBorrow bookBorrow = new BookBorrow();
            //bookBorrow.MdiParent = this;
            bookBorrow.Show();
        }

        private void toolBookBro_Click(object sender, EventArgs e)//工具-图书借阅
        {
            if (CheckChildfrm("BookBorrow") == true) return;
            BookBorrow bookBorrow = new BookBorrow();
            //bookBorrow.MdiParent = this;
            bookBorrow.Show();
        }

        private void Exit1_Click(object sender, EventArgs e)//菜单-管理员登录-退出
        {
            Application.Exit();
        }

        private void Exit2_Click(object sender, EventArgs e)//菜单-退出
        {
            Application.Exit();
        }

        private void Exit3_Click(object sender, EventArgs e)//工具-退出
        {
            Application.Exit();
        }

        private void About_Click(object sender, EventArgs e)//关于
        {
            About about = new About();
            about.ShowDialog();
        }

        private void BookRetrieval_Click(object sender, EventArgs e)
        {
            if (CheckChildfrm("BookSearch") == true)
                return;
            BookSearch bookSearch = new BookSearch();
            bookSearch.ShowDialog();
        }

        private void BookQuery_Click(object sender, EventArgs e)
        {
            if (CheckChildfrm("BookSearch") == true)
                return;
            BookSearch bookSearch = new BookSearch();
            bookSearch.ShowDialog();
        }
    }
}
