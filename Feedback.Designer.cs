namespace BookManage
{
    partial class Feedback
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dvgFeedback = new System.Windows.Forms.DataGridView();
            this.DFloor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DFeedback = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DFabulous = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DStamp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dvgFeedback)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dvgFeedback);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(776, 426);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "沙雕网友的反馈";
            // 
            // dvgFeedback
            // 
            this.dvgFeedback.AllowUserToOrderColumns = true;
            this.dvgFeedback.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dvgFeedback.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dvgFeedback.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.DFloor,
            this.DFeedback,
            this.DFabulous,
            this.DStamp});
            this.dvgFeedback.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dvgFeedback.Location = new System.Drawing.Point(3, 21);
            this.dvgFeedback.Name = "dvgFeedback";
            this.dvgFeedback.RowHeadersWidth = 51;
            this.dvgFeedback.RowTemplate.Height = 27;
            this.dvgFeedback.Size = new System.Drawing.Size(770, 402);
            this.dvgFeedback.TabIndex = 0;
            this.dvgFeedback.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // DFloor
            // 
            this.DFloor.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.DFloor.DataPropertyName = "Floor";
            this.DFloor.HeaderText = "楼层";
            this.DFloor.MinimumWidth = 6;
            this.DFloor.Name = "DFloor";
            this.DFloor.ReadOnly = true;
            this.DFloor.Width = 66;
            // 
            // DFeedback
            // 
            this.DFeedback.DataPropertyName = "Proposal";
            this.DFeedback.HeaderText = "反馈内容";
            this.DFeedback.MinimumWidth = 6;
            this.DFeedback.Name = "DFeedback";
            this.DFeedback.ReadOnly = true;
            // 
            // DFabulous
            // 
            this.DFabulous.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.DFabulous.DataPropertyName = "Fabulous";
            this.DFabulous.HeaderText = "赞";
            this.DFabulous.MinimumWidth = 6;
            this.DFabulous.Name = "DFabulous";
            this.DFabulous.ReadOnly = true;
            this.DFabulous.Width = 51;
            // 
            // DStamp
            // 
            this.DStamp.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.DStamp.DataPropertyName = "Stamp";
            this.DStamp.HeaderText = "踩";
            this.DStamp.MinimumWidth = 6;
            this.DStamp.Name = "DStamp";
            this.DStamp.ReadOnly = true;
            this.DStamp.Width = 51;
            // 
            // Feedback
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox1);
            this.Name = "Feedback";
            this.Text = "带伙的反馈";
            this.Load += new System.EventHandler(this.Feedback_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dvgFeedback)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.DataGridView dvgFeedback;
        private System.Windows.Forms.DataGridViewTextBoxColumn DFloor;
        private System.Windows.Forms.DataGridViewTextBoxColumn DFeedback;
        private System.Windows.Forms.DataGridViewTextBoxColumn DFabulous;
        private System.Windows.Forms.DataGridViewTextBoxColumn DStamp;
    }
}