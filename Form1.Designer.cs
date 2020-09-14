namespace BookManage
{
    partial class Form_Main
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Main));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.UserManage = new System.Windows.Forms.ToolStripMenuItem();
            this.ManagerLogin = new System.Windows.Forms.ToolStripMenuItem();
            this.Exit1 = new System.Windows.Forms.ToolStripMenuItem();
            this.BookManage = new System.Windows.Forms.ToolStripMenuItem();
            this.BookWarehouse = new System.Windows.Forms.ToolStripMenuItem();
            this.BookUpdate = new System.Windows.Forms.ToolStripMenuItem();
            this.BookRetrieval = new System.Windows.Forms.ToolStripMenuItem();
            this.BookBorrow = new System.Windows.Forms.ToolStripMenuItem();
            this.BookBorrow1 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuBookBro = new System.Windows.Forms.ToolStripMenuItem();
            this.About = new System.Windows.Forms.ToolStripMenuItem();
            this.Exit2 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.Login = new System.Windows.Forms.ToolStripButton();
            this.BookQuery = new System.Windows.Forms.ToolStripButton();
            this.BookUpdate2 = new System.Windows.Forms.ToolStripButton();
            this.BookBorrow2 = new System.Windows.Forms.ToolStripButton();
            this.toolBookBro = new System.Windows.Forms.ToolStripButton();
            this.Exit3 = new System.Windows.Forms.ToolStripButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.menuStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.UserManage,
            this.BookManage,
            this.BookBorrow,
            this.About,
            this.Exit2});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // UserManage
            // 
            this.UserManage.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ManagerLogin,
            this.Exit1});
            this.UserManage.Name = "UserManage";
            this.UserManage.Size = new System.Drawing.Size(83, 24);
            this.UserManage.Text = "用户管理";
            this.UserManage.Click += new System.EventHandler(this.UserManage_Click);
            // 
            // ManagerLogin
            // 
            this.ManagerLogin.Name = "ManagerLogin";
            this.ManagerLogin.Size = new System.Drawing.Size(167, 26);
            this.ManagerLogin.Text = "管理员登录";
            this.ManagerLogin.Click += new System.EventHandler(this.Login_Click);
            // 
            // Exit1
            // 
            this.Exit1.Name = "Exit1";
            this.Exit1.Size = new System.Drawing.Size(167, 26);
            this.Exit1.Text = "退出";
            this.Exit1.Click += new System.EventHandler(this.Exit1_Click);
            // 
            // BookManage
            // 
            this.BookManage.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.BookWarehouse,
            this.BookUpdate,
            this.BookRetrieval});
            this.BookManage.Name = "BookManage";
            this.BookManage.Size = new System.Drawing.Size(83, 24);
            this.BookManage.Text = "图书管理";
            this.BookManage.Click += new System.EventHandler(this.BookManage_Click);
            // 
            // BookWarehouse
            // 
            this.BookWarehouse.Name = "BookWarehouse";
            this.BookWarehouse.Size = new System.Drawing.Size(152, 26);
            this.BookWarehouse.Text = "图书入库";
            this.BookWarehouse.Click += new System.EventHandler(this.BookWarehouse_Click);
            // 
            // BookUpdate
            // 
            this.BookUpdate.Name = "BookUpdate";
            this.BookUpdate.Size = new System.Drawing.Size(152, 26);
            this.BookUpdate.Text = "图书更新";
            this.BookUpdate.Click += new System.EventHandler(this.BookUpdate_Click);
            // 
            // BookRetrieval
            // 
            this.BookRetrieval.Name = "BookRetrieval";
            this.BookRetrieval.Size = new System.Drawing.Size(152, 26);
            this.BookRetrieval.Text = "图书检索";
            this.BookRetrieval.Click += new System.EventHandler(this.BookRetrieval_Click);
            // 
            // BookBorrow
            // 
            this.BookBorrow.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.BookBorrow1,
            this.menuBookBro});
            this.BookBorrow.Name = "BookBorrow";
            this.BookBorrow.Size = new System.Drawing.Size(83, 24);
            this.BookBorrow.Text = "图书借还";
            // 
            // BookBorrow1
            // 
            this.BookBorrow1.Name = "BookBorrow1";
            this.BookBorrow1.Size = new System.Drawing.Size(152, 26);
            this.BookBorrow1.Text = "图书归还";
            this.BookBorrow1.Click += new System.EventHandler(this.BookBorrow1_Click);
            // 
            // menuBookBro
            // 
            this.menuBookBro.Name = "menuBookBro";
            this.menuBookBro.Size = new System.Drawing.Size(152, 26);
            this.menuBookBro.Text = "图书借阅";
            this.menuBookBro.Click += new System.EventHandler(this.menuBookBro_Click);
            // 
            // About
            // 
            this.About.Name = "About";
            this.About.Size = new System.Drawing.Size(53, 24);
            this.About.Text = "关于";
            this.About.Click += new System.EventHandler(this.About_Click);
            // 
            // Exit2
            // 
            this.Exit2.Name = "Exit2";
            this.Exit2.Size = new System.Drawing.Size(53, 24);
            this.Exit2.Text = "退出";
            this.Exit2.Click += new System.EventHandler(this.Exit2_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Login,
            this.BookQuery,
            this.BookUpdate2,
            this.BookBorrow2,
            this.toolBookBro,
            this.Exit3});
            this.toolStrip1.Location = new System.Drawing.Point(0, 28);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(800, 27);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // Login
            // 
            this.Login.Image = ((System.Drawing.Image)(resources.GetObject("Login.Image")));
            this.Login.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Login.Name = "Login";
            this.Login.Size = new System.Drawing.Size(63, 24);
            this.Login.Text = "登录";
            this.Login.Click += new System.EventHandler(this.Login_Click_1);
            // 
            // BookQuery
            // 
            this.BookQuery.Image = ((System.Drawing.Image)(resources.GetObject("BookQuery.Image")));
            this.BookQuery.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.BookQuery.Name = "BookQuery";
            this.BookQuery.Size = new System.Drawing.Size(93, 24);
            this.BookQuery.Text = "图书查询";
            this.BookQuery.Click += new System.EventHandler(this.BookQuery_Click);
            // 
            // BookUpdate2
            // 
            this.BookUpdate2.Image = ((System.Drawing.Image)(resources.GetObject("BookUpdate2.Image")));
            this.BookUpdate2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.BookUpdate2.Name = "BookUpdate2";
            this.BookUpdate2.Size = new System.Drawing.Size(93, 24);
            this.BookUpdate2.Text = "图书更新";
            this.BookUpdate2.Click += new System.EventHandler(this.BookUpdate2_Click);
            // 
            // BookBorrow2
            // 
            this.BookBorrow2.Image = ((System.Drawing.Image)(resources.GetObject("BookBorrow2.Image")));
            this.BookBorrow2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.BookBorrow2.Name = "BookBorrow2";
            this.BookBorrow2.Size = new System.Drawing.Size(93, 24);
            this.BookBorrow2.Text = "图书归还";
            this.BookBorrow2.Click += new System.EventHandler(this.BookBorrow2_Click);
            // 
            // toolBookBro
            // 
            this.toolBookBro.Image = ((System.Drawing.Image)(resources.GetObject("toolBookBro.Image")));
            this.toolBookBro.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolBookBro.Name = "toolBookBro";
            this.toolBookBro.Size = new System.Drawing.Size(93, 24);
            this.toolBookBro.Text = "图书借阅";
            this.toolBookBro.Click += new System.EventHandler(this.toolBookBro_Click);
            // 
            // Exit3
            // 
            this.Exit3.Image = ((System.Drawing.Image)(resources.GetObject("Exit3.Image")));
            this.Exit3.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Exit3.Name = "Exit3";
            this.Exit3.Size = new System.Drawing.Size(63, 24);
            this.Exit3.Text = "退出";
            this.Exit3.Click += new System.EventHandler(this.Exit3_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.Control;
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = global::BookManage.Properties.Resources.PicInit;
            this.pictureBox1.Location = new System.Drawing.Point(0, 55);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(800, 395);
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // Form_Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form_Main";
            this.Text = "图书管理系统";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem UserManage;
        private System.Windows.Forms.ToolStripMenuItem BookManage;
        private System.Windows.Forms.ToolStripMenuItem BookBorrow;
        private System.Windows.Forms.ToolStripMenuItem About;
        private System.Windows.Forms.ToolStripMenuItem Exit2;
        private System.Windows.Forms.ToolStripMenuItem ManagerLogin;
        private System.Windows.Forms.ToolStripMenuItem Exit1;
        private System.Windows.Forms.ToolStripMenuItem BookWarehouse;
        private System.Windows.Forms.ToolStripMenuItem BookUpdate;
        private System.Windows.Forms.ToolStripMenuItem BookRetrieval;
        private System.Windows.Forms.ToolStripMenuItem BookBorrow1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton Login;
        private System.Windows.Forms.ToolStripButton BookQuery;
        private System.Windows.Forms.ToolStripButton BookUpdate2;
        private System.Windows.Forms.ToolStripButton BookBorrow2;
        private System.Windows.Forms.ToolStripButton Exit3;
        private System.Windows.Forms.ToolStripMenuItem menuBookBro;
        private System.Windows.Forms.ToolStripButton toolBookBro;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

