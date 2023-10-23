namespace MultiQueueSimulation
{
    partial class ServersForm
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
            this.nextBtn = new System.Windows.Forms.Button();
            this.prevBtn = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.serverID = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // nextBtn
            // 
            this.nextBtn.Location = new System.Drawing.Point(416, 323);
            this.nextBtn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.nextBtn.MaximumSize = new System.Drawing.Size(88, 32);
            this.nextBtn.MinimumSize = new System.Drawing.Size(88, 32);
            this.nextBtn.Name = "nextBtn";
            this.nextBtn.Size = new System.Drawing.Size(88, 32);
            this.nextBtn.TabIndex = 0;
            this.nextBtn.Text = "Next Server";
            this.nextBtn.UseVisualStyleBackColor = true;
            this.nextBtn.Click += new System.EventHandler(this.nextBtn_Click);
            // 
            // prevBtn
            // 
            this.prevBtn.Location = new System.Drawing.Point(119, 323);
            this.prevBtn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.prevBtn.MaximumSize = new System.Drawing.Size(88, 32);
            this.prevBtn.MinimumSize = new System.Drawing.Size(88, 32);
            this.prevBtn.Name = "prevBtn";
            this.prevBtn.Size = new System.Drawing.Size(88, 32);
            this.prevBtn.TabIndex = 1;
            this.prevBtn.Text = "Prev Server";
            this.prevBtn.UseVisualStyleBackColor = true;
            this.prevBtn.Click += new System.EventHandler(this.prevBtn_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Top;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(602, 310);
            this.dataGridView1.TabIndex = 2;
            // 
            // serverID
            // 
            this.serverID.Location = new System.Drawing.Point(270, 328);
            this.serverID.Name = "serverID";
            this.serverID.Size = new System.Drawing.Size(74, 22);
            this.serverID.TabIndex = 0;
            this.serverID.Text = "label1";
            this.serverID.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ServersForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(602, 372);
            this.Controls.Add(this.serverID);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.prevBtn);
            this.Controls.Add(this.nextBtn);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MaximumSize = new System.Drawing.Size(618, 411);
            this.MinimumSize = new System.Drawing.Size(618, 411);
            this.Name = "ServersForm";
            this.Text = "ServersForm";
            this.Load += new System.EventHandler(this.ServersForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button nextBtn;
        private System.Windows.Forms.Button prevBtn;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label serverID;
    }
}