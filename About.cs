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
    public partial class About : Form
    {
        public About()
        {
            InitializeComponent();
        }

        private void About_Load(object sender, EventArgs e)
        {
            pictureBox1.BackColor = Color.Transparent; //设置dao背景色透明

            //设置窗体大小不能改变
            MaximizeBox = false;
            MinimizeBox = false;
            FormBorderStyle = FormBorderStyle.FixedDialog;

            tbManual.Enabled = false;
            tbManual.Text = "本图书管理系统仅供学习参考，图片均来源于网上(侵删)。" +
                Environment.NewLine+ "其中大致的设计参考https://www.bilibili.com/video/BV1Wt411X75y?p=5" +
                Environment.NewLine+"极低技术力开发，不爽可狂喷↓" +
                Environment.NewLine+ "若有意见和建议欢迎提出，qq:1277889600 井底呱" +
                Environment.NewLine + "（主界面的背景是广东工业大学正门照。）" +
                Environment.NewLine+ "（关于界面的图片来源：PID=38536745 UID=2557806 作者：へんき）";
        }

        private void btSub_Click(object sender, EventArgs e)
        {
            if(tbFeedback.Text.Length == 0)
            {
                MessageBox.Show("提议文本不能为空！");
                return;
            }

            DataAccess.UADDataTable("insert into feedback(Proposal)values('" + tbFeedback.Text + "')");

            tbFeedback.Clear();
            MessageBox.Show("感谢您的反馈 ヾ(≧∇≦*)ゝ");
        }

        private void lbSlink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Feedback feedback = new Feedback();
            feedback.Show();
        }
    }
}
