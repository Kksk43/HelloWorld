namespace BookManage
{
    partial class BookBorrow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BookBorrow));
            this.gpReaderLog = new System.Windows.Forms.GroupBox();
            this.btLogin = new System.Windows.Forms.Button();
            this.btSelected = new System.Windows.Forms.Button();
            this.tbBookID = new System.Windows.Forms.TextBox();
            this.tbPW = new System.Windows.Forms.TextBox();
            this.labelBookID = new System.Windows.Forms.Label();
            this.labelPW = new System.Windows.Forms.Label();
            this.tbAccount = new System.Windows.Forms.TextBox();
            this.labelAccout = new System.Windows.Forms.Label();
            this.gpBookIndex = new System.Windows.Forms.GroupBox();
            this.dvgBookSel = new System.Windows.Forms.DataGridView();
            this.BroBookID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BroBookTy = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BroBookName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BroBookAuthor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NumSurplus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.checkAll = new System.Windows.Forms.CheckBox();
            this.btBorrow = new System.Windows.Forms.Button();
            this.gpReaderLog.SuspendLayout();
            this.gpBookIndex.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dvgBookSel)).BeginInit();
            this.SuspendLayout();
            // 
            // gpReaderLog
            // 
            this.gpReaderLog.Controls.Add(this.btLogin);
            this.gpReaderLog.Controls.Add(this.btSelected);
            this.gpReaderLog.Controls.Add(this.tbBookID);
            this.gpReaderLog.Controls.Add(this.tbPW);
            this.gpReaderLog.Controls.Add(this.labelBookID);
            this.gpReaderLog.Controls.Add(this.labelPW);
            this.gpReaderLog.Controls.Add(this.tbAccount);
            this.gpReaderLog.Controls.Add(this.labelAccout);
            this.gpReaderLog.Location = new System.Drawing.Point(20, 12);
            this.gpReaderLog.Name = "gpReaderLog";
            this.gpReaderLog.Size = new System.Drawing.Size(1009, 87);
            this.gpReaderLog.TabIndex = 0;
            this.gpReaderLog.TabStop = false;
            this.gpReaderLog.Text = "读者查询";
            // 
            // btLogin
            // 
            this.btLogin.Location = new System.Drawing.Point(494, 28);
            this.btLogin.Name = "btLogin";
            this.btLogin.Size = new System.Drawing.Size(100, 35);
            this.btLogin.TabIndex = 7;
            this.btLogin.Text = "登录";
            this.btLogin.UseVisualStyleBackColor = true;
            this.btLogin.Click += new System.EventHandler(this.btLogin_Click);
            // 
            // btSelected
            // 
            this.btSelected.Location = new System.Drawing.Point(903, 28);
            this.btSelected.Name = "btSelected";
            this.btSelected.Size = new System.Drawing.Size(100, 35);
            this.btSelected.TabIndex = 6;
            this.btSelected.Text = "选择";
            this.btSelected.UseVisualStyleBackColor = true;
            this.btSelected.Click += new System.EventHandler(this.btSelected_Click);
            // 
            // tbBookID
            // 
            this.tbBookID.Location = new System.Drawing.Point(747, 35);
            this.tbBookID.Name = "tbBookID";
            this.tbBookID.Size = new System.Drawing.Size(150, 25);
            this.tbBookID.TabIndex = 5;
            this.tbBookID.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbBookID_KeyPress);
            // 
            // tbPW
            // 
            this.tbPW.Location = new System.Drawing.Point(338, 35);
            this.tbPW.Name = "tbPW";
            this.tbPW.Size = new System.Drawing.Size(150, 25);
            this.tbPW.TabIndex = 4;
            // 
            // labelBookID
            // 
            this.labelBookID.AutoSize = true;
            this.labelBookID.Location = new System.Drawing.Point(644, 38);
            this.labelBookID.Name = "labelBookID";
            this.labelBookID.Size = new System.Drawing.Size(97, 15);
            this.labelBookID.TabIndex = 3;
            this.labelBookID.Text = "图书访问码：";
            // 
            // labelPW
            // 
            this.labelPW.AutoSize = true;
            this.labelPW.Location = new System.Drawing.Point(250, 38);
            this.labelPW.Name = "labelPW";
            this.labelPW.Size = new System.Drawing.Size(82, 15);
            this.labelPW.TabIndex = 2;
            this.labelPW.Text = "证件密码：";
            // 
            // tbAccount
            // 
            this.tbAccount.Location = new System.Drawing.Point(94, 35);
            this.tbAccount.Name = "tbAccount";
            this.tbAccount.Size = new System.Drawing.Size(150, 25);
            this.tbAccount.TabIndex = 1;
            // 
            // labelAccout
            // 
            this.labelAccout.AutoSize = true;
            this.labelAccout.Location = new System.Drawing.Point(6, 38);
            this.labelAccout.Name = "labelAccout";
            this.labelAccout.Size = new System.Drawing.Size(82, 15);
            this.labelAccout.TabIndex = 0;
            this.labelAccout.Text = "借阅证号：";
            // 
            // gpBookIndex
            // 
            this.gpBookIndex.Controls.Add(this.dvgBookSel);
            this.gpBookIndex.Location = new System.Drawing.Point(23, 105);
            this.gpBookIndex.Name = "gpBookIndex";
            this.gpBookIndex.Size = new System.Drawing.Size(1005, 426);
            this.gpBookIndex.TabIndex = 1;
            this.gpBookIndex.TabStop = false;
            this.gpBookIndex.Text = "借阅图书选择";
            // 
            // dvgBookSel
            // 
            this.dvgBookSel.AllowUserToOrderColumns = true;
            this.dvgBookSel.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dvgBookSel.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dvgBookSel.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.BroBookID,
            this.BroBookTy,
            this.BroBookName,
            this.BroBookAuthor,
            this.NumSurplus});
            this.dvgBookSel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dvgBookSel.Location = new System.Drawing.Point(3, 21);
            this.dvgBookSel.Name = "dvgBookSel";
            this.dvgBookSel.RowHeadersWidth = 51;
            this.dvgBookSel.RowTemplate.Height = 27;
            this.dvgBookSel.Size = new System.Drawing.Size(999, 402);
            this.dvgBookSel.TabIndex = 0;
            this.dvgBookSel.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dvgBookSel_CellContentClick);
            // 
            // BroBookID
            // 
            this.BroBookID.DataPropertyName = "BookID";
            this.BroBookID.HeaderText = "图书编码";
            this.BroBookID.MinimumWidth = 6;
            this.BroBookID.Name = "BroBookID";
            this.BroBookID.ReadOnly = true;
            // 
            // BroBookTy
            // 
            this.BroBookTy.DataPropertyName = "BookType";
            this.BroBookTy.HeaderText = "图书类型";
            this.BroBookTy.MinimumWidth = 6;
            this.BroBookTy.Name = "BroBookTy";
            this.BroBookTy.ReadOnly = true;
            // 
            // BroBookName
            // 
            this.BroBookName.DataPropertyName = "BookName";
            this.BroBookName.HeaderText = "书名";
            this.BroBookName.MinimumWidth = 6;
            this.BroBookName.Name = "BroBookName";
            this.BroBookName.ReadOnly = true;
            // 
            // BroBookAuthor
            // 
            this.BroBookAuthor.DataPropertyName = "BookAuthor";
            this.BroBookAuthor.HeaderText = "图书作者";
            this.BroBookAuthor.MinimumWidth = 6;
            this.BroBookAuthor.Name = "BroBookAuthor";
            this.BroBookAuthor.ReadOnly = true;
            // 
            // NumSurplus
            // 
            this.NumSurplus.DataPropertyName = "BookSp";
            this.NumSurplus.HeaderText = "剩余量";
            this.NumSurplus.MinimumWidth = 6;
            this.NumSurplus.Name = "NumSurplus";
            this.NumSurplus.ReadOnly = true;
            // 
            // checkAll
            // 
            this.checkAll.AutoSize = true;
            this.checkAll.Location = new System.Drawing.Point(29, 537);
            this.checkAll.Name = "checkAll";
            this.checkAll.Size = new System.Drawing.Size(59, 19);
            this.checkAll.TabIndex = 2;
            this.checkAll.Text = "全选";
            this.checkAll.UseVisualStyleBackColor = true;
            this.checkAll.CheckedChanged += new System.EventHandler(this.checkAll_CheckedChanged);
            // 
            // btBorrow
            // 
            this.btBorrow.Location = new System.Drawing.Point(939, 537);
            this.btBorrow.Name = "btBorrow";
            this.btBorrow.Size = new System.Drawing.Size(86, 31);
            this.btBorrow.TabIndex = 4;
            this.btBorrow.Text = "借书";
            this.btBorrow.UseVisualStyleBackColor = true;
            this.btBorrow.Click += new System.EventHandler(this.btBorrow_Click);
            // 
            // BookBorrow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1056, 580);
            this.Controls.Add(this.btBorrow);
            this.Controls.Add(this.checkAll);
            this.Controls.Add(this.gpBookIndex);
            this.Controls.Add(this.gpReaderLog);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "BookBorrow";
            this.Text = "图书借阅";
            this.Load += new System.EventHandler(this.BookBorrow_Load);
            this.gpReaderLog.ResumeLayout(false);
            this.gpReaderLog.PerformLayout();
            this.gpBookIndex.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dvgBookSel)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gpReaderLog;
        private System.Windows.Forms.Label labelAccout;
        private System.Windows.Forms.TextBox tbBookID;
        private System.Windows.Forms.TextBox tbPW;
        private System.Windows.Forms.Label labelBookID;
        private System.Windows.Forms.Label labelPW;
        private System.Windows.Forms.TextBox tbAccount;
        private System.Windows.Forms.GroupBox gpBookIndex;
        private System.Windows.Forms.Button btSelected;
        private System.Windows.Forms.DataGridView dvgBookSel;
        private System.Windows.Forms.Button btLogin;
        private System.Windows.Forms.CheckBox checkAll;
        private System.Windows.Forms.Button btBorrow;
        private System.Windows.Forms.DataGridViewTextBoxColumn BroBookID;
        private System.Windows.Forms.DataGridViewTextBoxColumn BroBookTy;
        private System.Windows.Forms.DataGridViewTextBoxColumn BroBookName;
        private System.Windows.Forms.DataGridViewTextBoxColumn BroBookAuthor;
        private System.Windows.Forms.DataGridViewTextBoxColumn NumSurplus;
    }
}