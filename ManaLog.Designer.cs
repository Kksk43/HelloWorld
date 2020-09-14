namespace BookManage
{
    partial class ManaLog
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ManaLog));
            this.lbAccount = new System.Windows.Forms.Label();
            this.lbPW = new System.Windows.Forms.Label();
            this.btCancel = new System.Windows.Forms.Button();
            this.btLogin = new System.Windows.Forms.Button();
            this.tbAccount = new System.Windows.Forms.TextBox();
            this.tbPW = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lbAccount
            // 
            this.lbAccount.AutoSize = true;
            this.lbAccount.Location = new System.Drawing.Point(57, 47);
            this.lbAccount.Name = "lbAccount";
            this.lbAccount.Size = new System.Drawing.Size(52, 15);
            this.lbAccount.TabIndex = 0;
            this.lbAccount.Text = "帐号：";
            // 
            // lbPW
            // 
            this.lbPW.AutoSize = true;
            this.lbPW.Location = new System.Drawing.Point(57, 110);
            this.lbPW.Name = "lbPW";
            this.lbPW.Size = new System.Drawing.Size(52, 15);
            this.lbPW.TabIndex = 1;
            this.lbPW.Text = "密码：";
            // 
            // btCancel
            // 
            this.btCancel.Location = new System.Drawing.Point(201, 182);
            this.btCancel.Name = "btCancel";
            this.btCancel.Size = new System.Drawing.Size(120, 40);
            this.btCancel.TabIndex = 2;
            this.btCancel.Text = "退出登录";
            this.btCancel.UseVisualStyleBackColor = true;
            this.btCancel.Click += new System.EventHandler(this.btCancel_Click);
            // 
            // btLogin
            // 
            this.btLogin.Location = new System.Drawing.Point(39, 182);
            this.btLogin.Name = "btLogin";
            this.btLogin.Size = new System.Drawing.Size(120, 40);
            this.btLogin.TabIndex = 3;
            this.btLogin.Text = "登录";
            this.btLogin.UseVisualStyleBackColor = true;
            this.btLogin.Click += new System.EventHandler(this.btLogin_Click);
            // 
            // tbAccount
            // 
            this.tbAccount.Location = new System.Drawing.Point(115, 44);
            this.tbAccount.Name = "tbAccount";
            this.tbAccount.Size = new System.Drawing.Size(176, 25);
            this.tbAccount.TabIndex = 4;
            // 
            // tbPW
            // 
            this.tbPW.Location = new System.Drawing.Point(115, 107);
            this.tbPW.Name = "tbPW";
            this.tbPW.Size = new System.Drawing.Size(176, 25);
            this.tbPW.TabIndex = 5;
            // 
            // ManaLog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(358, 262);
            this.Controls.Add(this.tbPW);
            this.Controls.Add(this.tbAccount);
            this.Controls.Add(this.btLogin);
            this.Controls.Add(this.btCancel);
            this.Controls.Add(this.lbPW);
            this.Controls.Add(this.lbAccount);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ManaLog";
            this.Text = "管理员登录";
            this.Load += new System.EventHandler(this.ManaLog_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbAccount;
        private System.Windows.Forms.Label lbPW;
        private System.Windows.Forms.Button btCancel;
        private System.Windows.Forms.Button btLogin;
        private System.Windows.Forms.TextBox tbAccount;
        private System.Windows.Forms.TextBox tbPW;
    }
}