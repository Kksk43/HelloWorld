namespace BookManage
{
    partial class BookBro
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BookBro));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBookName = new System.Windows.Forms.TextBox();
            this.checkAllBook = new System.Windows.Forms.CheckBox();
            this.cbDate = new System.Windows.Forms.ComboBox();
            this.textAuthor = new System.Windows.Forms.TextBox();
            this.textBookID = new System.Windows.Forms.TextBox();
            this.textPW = new System.Windows.Forms.TextBox();
            this.textBroID = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dvgBro = new System.Windows.Forms.DataGridView();
            this.BroID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BroName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BroBookID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BroBook = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BroDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ReturnDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BroRenew = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnClose = new System.Windows.Forms.Button();
            this.BroSearch = new System.Windows.Forms.Button();
            this.btReturn = new System.Windows.Forms.Button();
            this.btnRenew = new System.Windows.Forms.Button();
            this.checkAll = new System.Windows.Forms.CheckBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dvgBro)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBookName);
            this.groupBox1.Controls.Add(this.checkAllBook);
            this.groupBox1.Controls.Add(this.cbDate);
            this.groupBox1.Controls.Add(this.textAuthor);
            this.groupBox1.Controls.Add(this.textBookID);
            this.groupBox1.Controls.Add(this.textPW);
            this.groupBox1.Controls.Add(this.textBroID);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(26, 28);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(290, 416);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "借阅信息查询";
            // 
            // textBookName
            // 
            this.textBookName.Location = new System.Drawing.Point(94, 213);
            this.textBookName.Name = "textBookName";
            this.textBookName.Size = new System.Drawing.Size(178, 25);
            this.textBookName.TabIndex = 13;
            this.textBookName.TextChanged += new System.EventHandler(this.textBookName_TextChanged);
            // 
            // checkAllBook
            // 
            this.checkAllBook.AutoSize = true;
            this.checkAllBook.Location = new System.Drawing.Point(210, 249);
            this.checkAllBook.Name = "checkAllBook";
            this.checkAllBook.Size = new System.Drawing.Size(74, 19);
            this.checkAllBook.TabIndex = 12;
            this.checkAllBook.Text = "所有书";
            this.checkAllBook.UseVisualStyleBackColor = true;
            this.checkAllBook.CheckedChanged += new System.EventHandler(this.checkAllBook_CheckedChanged);
            // 
            // cbDate
            // 
            this.cbDate.FormattingEnabled = true;
            this.cbDate.Location = new System.Drawing.Point(94, 346);
            this.cbDate.Name = "cbDate";
            this.cbDate.Size = new System.Drawing.Size(178, 23);
            this.cbDate.TabIndex = 11;
            this.cbDate.SelectedIndexChanged += new System.EventHandler(this.cbDate_SelectedIndexChanged);
            // 
            // textAuthor
            // 
            this.textAuthor.Location = new System.Drawing.Point(94, 278);
            this.textAuthor.Name = "textAuthor";
            this.textAuthor.ReadOnly = true;
            this.textAuthor.Size = new System.Drawing.Size(178, 25);
            this.textAuthor.TabIndex = 9;
            // 
            // textBookID
            // 
            this.textBookID.Location = new System.Drawing.Point(94, 158);
            this.textBookID.Name = "textBookID";
            this.textBookID.Size = new System.Drawing.Size(178, 25);
            this.textBookID.TabIndex = 8;
            this.textBookID.TextChanged += new System.EventHandler(this.textBookID_TextChanged);
            // 
            // textPW
            // 
            this.textPW.Location = new System.Drawing.Point(94, 102);
            this.textPW.Name = "textPW";
            this.textPW.Size = new System.Drawing.Size(178, 25);
            this.textPW.TabIndex = 7;
            this.textPW.TextChanged += new System.EventHandler(this.textName_TextChanged);
            // 
            // textBroID
            // 
            this.textBroID.Location = new System.Drawing.Point(94, 39);
            this.textBroID.Name = "textBroID";
            this.textBroID.Size = new System.Drawing.Size(178, 25);
            this.textBroID.TabIndex = 6;
            this.textBroID.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 349);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(67, 15);
            this.label6.TabIndex = 5;
            this.label6.Text = "借阅日期";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 281);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 15);
            this.label5.TabIndex = 4;
            this.label5.Text = "作者：";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 223);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 15);
            this.label4.TabIndex = 3;
            this.label4.Text = "书名：";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 161);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "图书访问码：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 105);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "证件密码：";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "借阅证号：";
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dvgBro);
            this.groupBox2.Location = new System.Drawing.Point(350, 28);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(773, 415);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "借阅详细信息";
            // 
            // dvgBro
            // 
            this.dvgBro.AllowUserToOrderColumns = true;
            this.dvgBro.BackgroundColor = System.Drawing.SystemColors.ActiveBorder;
            this.dvgBro.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dvgBro.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.BroID,
            this.BroName,
            this.BroBookID,
            this.BroBook,
            this.BroDate,
            this.ReturnDate,
            this.BroRenew,
            this.RID});
            this.dvgBro.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dvgBro.Location = new System.Drawing.Point(3, 21);
            this.dvgBro.Name = "dvgBro";
            this.dvgBro.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dvgBro.RowTemplate.Height = 27;
            this.dvgBro.Size = new System.Drawing.Size(767, 391);
            this.dvgBro.TabIndex = 0;
            this.dvgBro.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dvgBro_CellContentClick);
            // 
            // BroID
            // 
            this.BroID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.BroID.DataPropertyName = "IssBookID";
            this.BroID.HeaderText = "借阅证号";
            this.BroID.MinimumWidth = 6;
            this.BroID.Name = "BroID";
            this.BroID.ReadOnly = true;
            this.BroID.Width = 119;
            // 
            // BroName
            // 
            this.BroName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.BroName.DataPropertyName = "UName";
            this.BroName.HeaderText = "借阅者";
            this.BroName.MinimumWidth = 6;
            this.BroName.Name = "BroName";
            this.BroName.ReadOnly = true;
            this.BroName.Width = 118;
            // 
            // BroBookID
            // 
            this.BroBookID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.BroBookID.DataPropertyName = "BookID";
            this.BroBookID.HeaderText = "图书编号";
            this.BroBookID.MinimumWidth = 6;
            this.BroBookID.Name = "BroBookID";
            this.BroBookID.ReadOnly = true;
            this.BroBookID.Width = 119;
            // 
            // BroBook
            // 
            this.BroBook.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.BroBook.DataPropertyName = "BookName";
            this.BroBook.HeaderText = "借阅图书";
            this.BroBook.MinimumWidth = 6;
            this.BroBook.Name = "BroBook";
            this.BroBook.ReadOnly = true;
            this.BroBook.Width = 119;
            // 
            // BroDate
            // 
            this.BroDate.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.BroDate.DataPropertyName = "IssDateTime";
            this.BroDate.HeaderText = "借阅日期";
            this.BroDate.MinimumWidth = 6;
            this.BroDate.Name = "BroDate";
            this.BroDate.ReadOnly = true;
            this.BroDate.Width = 119;
            // 
            // ReturnDate
            // 
            this.ReturnDate.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.ReturnDate.DataPropertyName = "IssDTLimite";
            this.ReturnDate.HeaderText = "还书截止日期";
            this.ReturnDate.MinimumWidth = 6;
            this.ReturnDate.Name = "ReturnDate";
            this.ReturnDate.ReadOnly = true;
            this.ReturnDate.Width = 119;
            // 
            // BroRenew
            // 
            this.BroRenew.DataPropertyName = "RenewTimes";
            this.BroRenew.HeaderText = "已续借次数";
            this.BroRenew.MinimumWidth = 6;
            this.BroRenew.Name = "BroRenew";
            this.BroRenew.ReadOnly = true;
            this.BroRenew.Width = 125;
            // 
            // RID
            // 
            this.RID.DataPropertyName = "IssID";
            this.RID.HeaderText = "借阅编号";
            this.RID.MinimumWidth = 6;
            this.RID.Name = "RID";
            this.RID.ReadOnly = true;
            this.RID.Visible = false;
            this.RID.Width = 125;
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(1010, 449);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(110, 38);
            this.btnClose.TabIndex = 3;
            this.btnClose.Text = "退出";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // BroSearch
            // 
            this.BroSearch.Location = new System.Drawing.Point(206, 449);
            this.BroSearch.Name = "BroSearch";
            this.BroSearch.Size = new System.Drawing.Size(110, 38);
            this.BroSearch.TabIndex = 4;
            this.BroSearch.Text = "查询";
            this.BroSearch.UseVisualStyleBackColor = true;
            this.BroSearch.Click += new System.EventHandler(this.BroSearch_Click);
            // 
            // btReturn
            // 
            this.btReturn.Location = new System.Drawing.Point(778, 449);
            this.btReturn.Name = "btReturn";
            this.btReturn.Size = new System.Drawing.Size(110, 38);
            this.btReturn.TabIndex = 5;
            this.btReturn.Text = "还书";
            this.btReturn.UseVisualStyleBackColor = true;
            this.btReturn.Click += new System.EventHandler(this.btReturn_Click);
            // 
            // btnRenew
            // 
            this.btnRenew.Location = new System.Drawing.Point(894, 449);
            this.btnRenew.Name = "btnRenew";
            this.btnRenew.Size = new System.Drawing.Size(110, 38);
            this.btnRenew.TabIndex = 6;
            this.btnRenew.Text = "续借";
            this.btnRenew.UseVisualStyleBackColor = true;
            this.btnRenew.Click += new System.EventHandler(this.btnRenew_Click);
            // 
            // checkAll
            // 
            this.checkAll.AutoSize = true;
            this.checkAll.Location = new System.Drawing.Point(353, 460);
            this.checkAll.Name = "checkAll";
            this.checkAll.Size = new System.Drawing.Size(59, 19);
            this.checkAll.TabIndex = 7;
            this.checkAll.Text = "全选";
            this.checkAll.UseVisualStyleBackColor = true;
            this.checkAll.CheckedChanged += new System.EventHandler(this.checkAll_CheckedChanged);
            // 
            // BookBro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1164, 548);
            this.Controls.Add(this.checkAll);
            this.Controls.Add(this.btnRenew);
            this.Controls.Add(this.btReturn);
            this.Controls.Add(this.BroSearch);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "BookBro";
            this.Text = "图书归还/续借";
            this.Load += new System.EventHandler(this.BookBro_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dvgBro)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox cbDate;
        private System.Windows.Forms.TextBox textAuthor;
        private System.Windows.Forms.TextBox textBookID;
        private System.Windows.Forms.TextBox textPW;
        private System.Windows.Forms.TextBox textBroID;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dvgBro;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button BroSearch;
        private System.Windows.Forms.Button btReturn;
        private System.Windows.Forms.Button btnRenew;
        private System.Windows.Forms.CheckBox checkAll;
        private System.Windows.Forms.CheckBox checkAllBook;
        private System.Windows.Forms.TextBox textBookName;
        private System.Windows.Forms.DataGridViewTextBoxColumn BroID;
        private System.Windows.Forms.DataGridViewTextBoxColumn BroName;
        private System.Windows.Forms.DataGridViewTextBoxColumn BroBookID;
        private System.Windows.Forms.DataGridViewTextBoxColumn BroBook;
        private System.Windows.Forms.DataGridViewTextBoxColumn BroDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn ReturnDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn BroRenew;
        private System.Windows.Forms.DataGridViewTextBoxColumn RID;
    }
}