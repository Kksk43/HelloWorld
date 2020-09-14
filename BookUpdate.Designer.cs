namespace BookManage
{
    partial class BookUpdata
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BookUpdata));
            this.gbDetail = new System.Windows.Forms.GroupBox();
            this.dvgUpdate = new System.Windows.Forms.DataGridView();
            this.UBookID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UBookName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UBookType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UBookAuthor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UBookPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UBookPic = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UBookContent = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UBookIssue = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UBookNum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gbUpdate = new System.Windows.Forms.GroupBox();
            this.tbBookNum = new System.Windows.Forms.TextBox();
            this.lbNum = new System.Windows.Forms.Label();
            this.btDel = new System.Windows.Forms.Button();
            this.btUpdate = new System.Windows.Forms.Button();
            this.btSelected = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tbBookIssueID = new System.Windows.Forms.TextBox();
            this.tbBookContent = new System.Windows.Forms.TextBox();
            this.tbBookPic = new System.Windows.Forms.TextBox();
            this.tbBookPrice = new System.Windows.Forms.TextBox();
            this.tbBookAuthor = new System.Windows.Forms.TextBox();
            this.tbBookName = new System.Windows.Forms.TextBox();
            this.tbBookType = new System.Windows.Forms.TextBox();
            this.tbBookID = new System.Windows.Forms.TextBox();
            this.gbDetail.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dvgUpdate)).BeginInit();
            this.gbUpdate.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbDetail
            // 
            this.gbDetail.Controls.Add(this.dvgUpdate);
            this.gbDetail.Location = new System.Drawing.Point(12, 12);
            this.gbDetail.Name = "gbDetail";
            this.gbDetail.Size = new System.Drawing.Size(566, 514);
            this.gbDetail.TabIndex = 0;
            this.gbDetail.TabStop = false;
            this.gbDetail.Text = "图书详细信息";
            // 
            // dvgUpdate
            // 
            this.dvgUpdate.AllowUserToOrderColumns = true;
            this.dvgUpdate.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dvgUpdate.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.UBookID,
            this.UBookName,
            this.UBookType,
            this.UBookAuthor,
            this.UBookPrice,
            this.UBookPic,
            this.UBookContent,
            this.UBookIssue,
            this.UBookNum});
            this.dvgUpdate.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dvgUpdate.Location = new System.Drawing.Point(3, 21);
            this.dvgUpdate.Name = "dvgUpdate";
            this.dvgUpdate.RowHeadersWidth = 51;
            this.dvgUpdate.RowTemplate.Height = 27;
            this.dvgUpdate.Size = new System.Drawing.Size(560, 490);
            this.dvgUpdate.TabIndex = 0;
            this.dvgUpdate.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dvgUpdate_CellContentClick);
            // 
            // UBookID
            // 
            this.UBookID.HeaderText = "图书编码";
            this.UBookID.MinimumWidth = 6;
            this.UBookID.Name = "UBookID";
            this.UBookID.ReadOnly = true;
            this.UBookID.Width = 125;
            // 
            // UBookName
            // 
            this.UBookName.HeaderText = "图书名字";
            this.UBookName.MinimumWidth = 6;
            this.UBookName.Name = "UBookName";
            this.UBookName.ReadOnly = true;
            this.UBookName.Width = 125;
            // 
            // UBookType
            // 
            this.UBookType.HeaderText = "图书类别";
            this.UBookType.MinimumWidth = 6;
            this.UBookType.Name = "UBookType";
            this.UBookType.ReadOnly = true;
            this.UBookType.Width = 125;
            // 
            // UBookAuthor
            // 
            this.UBookAuthor.HeaderText = "图书作者";
            this.UBookAuthor.MinimumWidth = 6;
            this.UBookAuthor.Name = "UBookAuthor";
            this.UBookAuthor.ReadOnly = true;
            this.UBookAuthor.Width = 125;
            // 
            // UBookPrice
            // 
            this.UBookPrice.HeaderText = "图书价格";
            this.UBookPrice.MinimumWidth = 6;
            this.UBookPrice.Name = "UBookPrice";
            this.UBookPrice.ReadOnly = true;
            this.UBookPrice.Width = 125;
            // 
            // UBookPic
            // 
            this.UBookPic.HeaderText = "图书封面";
            this.UBookPic.MinimumWidth = 6;
            this.UBookPic.Name = "UBookPic";
            this.UBookPic.ReadOnly = true;
            this.UBookPic.Width = 125;
            // 
            // UBookContent
            // 
            this.UBookContent.HeaderText = "图书内容";
            this.UBookContent.MinimumWidth = 6;
            this.UBookContent.Name = "UBookContent";
            this.UBookContent.ReadOnly = true;
            this.UBookContent.Width = 125;
            // 
            // UBookIssue
            // 
            this.UBookIssue.HeaderText = "图书访问码";
            this.UBookIssue.MinimumWidth = 6;
            this.UBookIssue.Name = "UBookIssue";
            this.UBookIssue.ReadOnly = true;
            this.UBookIssue.Width = 125;
            // 
            // UBookNum
            // 
            this.UBookNum.HeaderText = "图书数目";
            this.UBookNum.MinimumWidth = 6;
            this.UBookNum.Name = "UBookNum";
            this.UBookNum.ReadOnly = true;
            this.UBookNum.Width = 125;
            // 
            // gbUpdate
            // 
            this.gbUpdate.Controls.Add(this.tbBookNum);
            this.gbUpdate.Controls.Add(this.lbNum);
            this.gbUpdate.Controls.Add(this.btDel);
            this.gbUpdate.Controls.Add(this.btUpdate);
            this.gbUpdate.Controls.Add(this.btSelected);
            this.gbUpdate.Controls.Add(this.label8);
            this.gbUpdate.Controls.Add(this.label7);
            this.gbUpdate.Controls.Add(this.label6);
            this.gbUpdate.Controls.Add(this.label5);
            this.gbUpdate.Controls.Add(this.label4);
            this.gbUpdate.Controls.Add(this.label3);
            this.gbUpdate.Controls.Add(this.label2);
            this.gbUpdate.Controls.Add(this.label1);
            this.gbUpdate.Controls.Add(this.tbBookIssueID);
            this.gbUpdate.Controls.Add(this.tbBookContent);
            this.gbUpdate.Controls.Add(this.tbBookPic);
            this.gbUpdate.Controls.Add(this.tbBookPrice);
            this.gbUpdate.Controls.Add(this.tbBookAuthor);
            this.gbUpdate.Controls.Add(this.tbBookName);
            this.gbUpdate.Controls.Add(this.tbBookType);
            this.gbUpdate.Controls.Add(this.tbBookID);
            this.gbUpdate.Location = new System.Drawing.Point(584, 33);
            this.gbUpdate.Name = "gbUpdate";
            this.gbUpdate.Size = new System.Drawing.Size(433, 446);
            this.gbUpdate.TabIndex = 1;
            this.gbUpdate.TabStop = false;
            this.gbUpdate.Text = "更新图书信息";
            // 
            // tbBookNum
            // 
            this.tbBookNum.Location = new System.Drawing.Point(312, 276);
            this.tbBookNum.Name = "tbBookNum";
            this.tbBookNum.Size = new System.Drawing.Size(115, 25);
            this.tbBookNum.TabIndex = 20;
            // 
            // lbNum
            // 
            this.lbNum.AutoSize = true;
            this.lbNum.Location = new System.Drawing.Point(224, 279);
            this.lbNum.Name = "lbNum";
            this.lbNum.Size = new System.Drawing.Size(82, 15);
            this.lbNum.TabIndex = 19;
            this.lbNum.Text = "图书数量：";
            // 
            // btDel
            // 
            this.btDel.Location = new System.Drawing.Point(312, 388);
            this.btDel.Name = "btDel";
            this.btDel.Size = new System.Drawing.Size(100, 40);
            this.btDel.TabIndex = 18;
            this.btDel.Text = "删除";
            this.btDel.UseVisualStyleBackColor = true;
            this.btDel.Click += new System.EventHandler(this.btDel_Click);
            // 
            // btUpdate
            // 
            this.btUpdate.Location = new System.Drawing.Point(165, 388);
            this.btUpdate.Name = "btUpdate";
            this.btUpdate.Size = new System.Drawing.Size(100, 40);
            this.btUpdate.TabIndex = 17;
            this.btUpdate.Text = "更新";
            this.btUpdate.UseVisualStyleBackColor = true;
            this.btUpdate.Click += new System.EventHandler(this.btUpdate_Click);
            // 
            // btSelected
            // 
            this.btSelected.Location = new System.Drawing.Point(18, 388);
            this.btSelected.Name = "btSelected";
            this.btSelected.Size = new System.Drawing.Size(100, 40);
            this.btSelected.TabIndex = 16;
            this.btSelected.Text = "选择";
            this.btSelected.UseVisualStyleBackColor = true;
            this.btSelected.Click += new System.EventHandler(this.btSelected_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 338);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(97, 15);
            this.label8.TabIndex = 15;
            this.label8.Text = "图书访问码：";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(224, 206);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(82, 15);
            this.label7.TabIndex = 14;
            this.label7.Text = "图书内容：";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(224, 126);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(82, 15);
            this.label6.TabIndex = 13;
            this.label6.Text = "图书封面：";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(224, 41);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(82, 15);
            this.label5.TabIndex = 12;
            this.label5.Text = "图书价格：";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 279);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 15);
            this.label4.TabIndex = 11;
            this.label4.Text = "图书作者：";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 206);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 15);
            this.label3.TabIndex = 10;
            this.label3.Text = "图书名字：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 126);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 15);
            this.label2.TabIndex = 9;
            this.label2.Text = "图书类型：";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 15);
            this.label1.TabIndex = 8;
            this.label1.Text = "图书编码：";
            // 
            // tbBookIssueID
            // 
            this.tbBookIssueID.Location = new System.Drawing.Point(109, 335);
            this.tbBookIssueID.Name = "tbBookIssueID";
            this.tbBookIssueID.Size = new System.Drawing.Size(115, 25);
            this.tbBookIssueID.TabIndex = 7;
            // 
            // tbBookContent
            // 
            this.tbBookContent.Location = new System.Drawing.Point(312, 203);
            this.tbBookContent.Name = "tbBookContent";
            this.tbBookContent.Size = new System.Drawing.Size(115, 25);
            this.tbBookContent.TabIndex = 6;
            // 
            // tbBookPic
            // 
            this.tbBookPic.Location = new System.Drawing.Point(312, 116);
            this.tbBookPic.Name = "tbBookPic";
            this.tbBookPic.Size = new System.Drawing.Size(115, 25);
            this.tbBookPic.TabIndex = 5;
            // 
            // tbBookPrice
            // 
            this.tbBookPrice.Location = new System.Drawing.Point(312, 38);
            this.tbBookPrice.Name = "tbBookPrice";
            this.tbBookPrice.Size = new System.Drawing.Size(115, 25);
            this.tbBookPrice.TabIndex = 4;
            // 
            // tbBookAuthor
            // 
            this.tbBookAuthor.Location = new System.Drawing.Point(94, 276);
            this.tbBookAuthor.Name = "tbBookAuthor";
            this.tbBookAuthor.Size = new System.Drawing.Size(115, 25);
            this.tbBookAuthor.TabIndex = 3;
            // 
            // tbBookName
            // 
            this.tbBookName.Location = new System.Drawing.Point(94, 203);
            this.tbBookName.Name = "tbBookName";
            this.tbBookName.Size = new System.Drawing.Size(115, 25);
            this.tbBookName.TabIndex = 2;
            // 
            // tbBookType
            // 
            this.tbBookType.Location = new System.Drawing.Point(94, 123);
            this.tbBookType.Name = "tbBookType";
            this.tbBookType.Size = new System.Drawing.Size(115, 25);
            this.tbBookType.TabIndex = 1;
            // 
            // tbBookID
            // 
            this.tbBookID.Location = new System.Drawing.Point(94, 38);
            this.tbBookID.Name = "tbBookID";
            this.tbBookID.Size = new System.Drawing.Size(115, 25);
            this.tbBookID.TabIndex = 0;
            // 
            // BookUpdata
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1029, 538);
            this.Controls.Add(this.gbUpdate);
            this.Controls.Add(this.gbDetail);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "BookUpdata";
            this.Text = "图书更新";
            this.Load += new System.EventHandler(this.BookUpdata_Load);
            this.gbDetail.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dvgUpdate)).EndInit();
            this.gbUpdate.ResumeLayout(false);
            this.gbUpdate.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbDetail;
        private System.Windows.Forms.DataGridView dvgUpdate;
        private System.Windows.Forms.GroupBox gbUpdate;
        private System.Windows.Forms.Button btDel;
        private System.Windows.Forms.Button btUpdate;
        private System.Windows.Forms.Button btSelected;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbBookIssueID;
        private System.Windows.Forms.TextBox tbBookContent;
        private System.Windows.Forms.TextBox tbBookPic;
        private System.Windows.Forms.TextBox tbBookPrice;
        private System.Windows.Forms.TextBox tbBookAuthor;
        private System.Windows.Forms.TextBox tbBookName;
        private System.Windows.Forms.TextBox tbBookType;
        private System.Windows.Forms.TextBox tbBookID;
        private System.Windows.Forms.DataGridViewTextBoxColumn UBookID;
        private System.Windows.Forms.DataGridViewTextBoxColumn UBookName;
        private System.Windows.Forms.DataGridViewTextBoxColumn UBookType;
        private System.Windows.Forms.DataGridViewTextBoxColumn UBookAuthor;
        private System.Windows.Forms.DataGridViewTextBoxColumn UBookPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn UBookPic;
        private System.Windows.Forms.DataGridViewTextBoxColumn UBookContent;
        private System.Windows.Forms.DataGridViewTextBoxColumn UBookIssue;
        private System.Windows.Forms.DataGridViewTextBoxColumn UBookNum;
        private System.Windows.Forms.TextBox tbBookNum;
        private System.Windows.Forms.Label lbNum;
    }
}