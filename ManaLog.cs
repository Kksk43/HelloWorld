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
    public partial class ManaLog : Form
    {
        private bool hide;
        public ManaLog()
        {
            InitializeComponent();
        }
        /// <summary>
        /// 重载构造器，传入登录状态
        /// </summary>
        /// <param name="h"></param>
        public ManaLog(bool h)
        {
            InitializeComponent();
            this.hide = h;
        }


        /// <summary>
        /// 根据登录状态设置控件的初始状态
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ManaLog_Load(object sender, EventArgs e)
        {
            //设置窗体大小不能改变
            MaximizeBox = false;
            MinimizeBox = false;
            FormBorderStyle = FormBorderStyle.FixedDialog;

            tbPW.PasswordChar = '*';//设置密码字符

            tbAccount.Enabled = hide;
            tbPW.Enabled = hide;
            btLogin.Enabled = hide;
            btCancel.Enabled = !hide;
        }


        /// <summary>
        /// 匹配帐号和密码，检测是否是管理员类型
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
                $"UPwdype='{tbPW.Text}' and " +
                $"UState=1";
            if (!DataAccess.TableExistOrNot(data_in))//检查是否存在这个用户
            {
                MessageBox.Show("帐号密码不匹配  X﹏X");
                return;//匹配立即返回
            }

            MessageBox.Show("登录成功！");
            this.DialogResult = DialogResult.Yes;
        }


        /// <summary>
        /// 退出登录
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btCancel_Click(object sender, EventArgs e)
        {
            MessageBox.Show("已退出登录！");
            this.DialogResult = DialogResult.No;
        }
    }
}
