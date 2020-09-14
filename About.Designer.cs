namespace BookManage
{
    partial class About
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(About));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tbManual = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tbFeedback = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.lbFB = new System.Windows.Forms.Label();
            this.btSub = new System.Windows.Forms.Button();
            this.lbAbout = new System.Windows.Forms.Label();
            this.lbSlink = new System.Windows.Forms.LinkLabel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(292, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "BookManage";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(292, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "版本：V1.0.0.1";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(292, 106);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(127, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "Copyright @2020";
            // 
            // tbManual
            // 
            this.tbManual.Location = new System.Drawing.Point(295, 188);
            this.tbManual.Multiline = true;
            this.tbManual.Name = "tbManual";
            this.tbManual.Size = new System.Drawing.Size(493, 250);
            this.tbManual.TabIndex = 3;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::BookManage.Properties.Resources.PicAbo;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(274, 426);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // tbFeedback
            // 
            this.tbFeedback.Location = new System.Drawing.Point(467, 44);
            this.tbFeedback.MaxLength = 100;
            this.tbFeedback.Multiline = true;
            this.tbFeedback.Name = "tbFeedback";
            this.tbFeedback.Size = new System.Drawing.Size(321, 92);
            this.tbFeedback.TabIndex = 5;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // lbFB
            // 
            this.lbFB.AutoSize = true;
            this.lbFB.Location = new System.Drawing.Point(464, 26);
            this.lbFB.Name = "lbFB";
            this.lbFB.Size = new System.Drawing.Size(242, 15);
            this.lbFB.TabIndex = 7;
            this.lbFB.Text = "您可以在此发送反馈(100字符内)：";
            // 
            // btSub
            // 
            this.btSub.Location = new System.Drawing.Point(700, 142);
            this.btSub.Name = "btSub";
            this.btSub.Size = new System.Drawing.Size(88, 30);
            this.btSub.TabIndex = 8;
            this.btSub.Text = "提交";
            this.btSub.UseVisualStyleBackColor = true;
            this.btSub.Click += new System.EventHandler(this.btSub_Click);
            // 
            // lbAbout
            // 
            this.lbAbout.AutoSize = true;
            this.lbAbout.Location = new System.Drawing.Point(292, 170);
            this.lbAbout.Name = "lbAbout";
            this.lbAbout.Size = new System.Drawing.Size(52, 15);
            this.lbAbout.TabIndex = 9;
            this.lbAbout.Text = "相关：";
            // 
            // lbSlink
            // 
            this.lbSlink.AutoSize = true;
            this.lbSlink.Location = new System.Drawing.Point(464, 150);
            this.lbSlink.Name = "lbSlink";
            this.lbSlink.Size = new System.Drawing.Size(143, 15);
            this.lbSlink.TabIndex = 10;
            this.lbSlink.TabStop = true;
            this.lbSlink.Text = "带伙的反馈(均匿名)";
            this.lbSlink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lbSlink_LinkClicked);
            // 
            // About
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lbSlink);
            this.Controls.Add(this.lbAbout);
            this.Controls.Add(this.btSub);
            this.Controls.Add(this.lbFB);
            this.Controls.Add(this.tbFeedback);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.tbManual);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "About";
            this.Text = "关于";
            this.Load += new System.EventHandler(this.About_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbManual;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox tbFeedback;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Label lbFB;
        private System.Windows.Forms.Button btSub;
        private System.Windows.Forms.Label lbAbout;
        private System.Windows.Forms.LinkLabel lbSlink;
    }
}