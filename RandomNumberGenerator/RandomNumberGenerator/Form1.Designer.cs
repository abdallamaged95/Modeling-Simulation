namespace RandomNumberGenerator
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.Multiplier = new System.Windows.Forms.TextBox();
            this.Seed = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Increment = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Modulus = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.Iterations = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.PeriodValue = new System.Windows.Forms.Label();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.U = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Multiplier";
            // 
            // Multiplier
            // 
            this.Multiplier.Location = new System.Drawing.Point(98, 40);
            this.Multiplier.Name = "Multiplier";
            this.Multiplier.Size = new System.Drawing.Size(100, 20);
            this.Multiplier.TabIndex = 1;
            // 
            // Seed
            // 
            this.Seed.Location = new System.Drawing.Point(98, 90);
            this.Seed.Name = "Seed";
            this.Seed.Size = new System.Drawing.Size(100, 20);
            this.Seed.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(33, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Seed (X0)";
            // 
            // Increment
            // 
            this.Increment.Location = new System.Drawing.Point(98, 135);
            this.Increment.Name = "Increment";
            this.Increment.Size = new System.Drawing.Size(100, 20);
            this.Increment.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(33, 135);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Increment";
            // 
            // Modulus
            // 
            this.Modulus.Location = new System.Drawing.Point(98, 182);
            this.Modulus.Name = "Modulus";
            this.Modulus.Size = new System.Drawing.Size(100, 20);
            this.Modulus.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(33, 182);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Modulus";
            // 
            // Iterations
            // 
            this.Iterations.Location = new System.Drawing.Point(98, 221);
            this.Iterations.Name = "Iterations";
            this.Iterations.Size = new System.Drawing.Size(100, 20);
            this.Iterations.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(33, 221);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Iterations";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(189, 275);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 10;
            this.button1.Text = "Generate";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column2,
            this.Column1,
            this.U});
            this.dataGridView1.Location = new System.Drawing.Point(232, 40);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(240, 201);
            this.dataGridView1.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(33, 314);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(76, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Period Length:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(103, 314);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(0, 13);
            this.label7.TabIndex = 13;
            // 
            // PeriodValue
            // 
            this.PeriodValue.AutoSize = true;
            this.PeriodValue.Location = new System.Drawing.Point(112, 314);
            this.PeriodValue.Name = "PeriodValue";
            this.PeriodValue.Size = new System.Drawing.Size(0, 13);
            this.PeriodValue.TabIndex = 14;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Idx";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 60;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Z";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 60;
            // 
            // U
            // 
            this.U.HeaderText = "U";
            this.U.Name = "U";
            this.U.ReadOnly = true;
            this.U.Width = 60;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 361);
            this.Controls.Add(this.PeriodValue);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Iterations);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.Modulus);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Increment);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Seed);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Multiplier);
            this.Controls.Add(this.label1);
            this.MaximumSize = new System.Drawing.Size(500, 400);
            this.MinimumSize = new System.Drawing.Size(500, 400);
            this.Name = "Form1";
            this.Text = "RandomNumberGenerator";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Multiplier;
        private System.Windows.Forms.TextBox Seed;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Increment;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox Modulus;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox Iterations;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label PeriodValue;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn U;
    }
}

