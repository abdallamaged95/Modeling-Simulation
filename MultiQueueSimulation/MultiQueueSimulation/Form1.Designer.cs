namespace MultiQueueSimulation
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
            this.browseButton = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.serverNum = new System.Windows.Forms.Label();
            this.stoppingNumber = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.stoppingCriteria = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.selectionMethod = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.interArrivalBtn = new System.Windows.Forms.Button();
            this.serversDistributionBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // browseButton
            // 
            this.browseButton.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.browseButton.Location = new System.Drawing.Point(0, 301);
            this.browseButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.browseButton.MaximumSize = new System.Drawing.Size(0, 41);
            this.browseButton.MinimumSize = new System.Drawing.Size(0, 41);
            this.browseButton.Name = "browseButton";
            this.browseButton.Size = new System.Drawing.Size(550, 41);
            this.browseButton.TabIndex = 0;
            this.browseButton.Text = "Browse";
            this.browseButton.UseVisualStyleBackColor = true;
            this.browseButton.Click += new System.EventHandler(this.browseButton_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(10, 11);
            this.label12.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(97, 13);
            this.label12.TabIndex = 1;
            this.label12.Text = "Number Of Servers";
            // 
            // serverNum
            // 
            this.serverNum.AutoSize = true;
            this.serverNum.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.serverNum.Location = new System.Drawing.Point(106, 11);
            this.serverNum.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.serverNum.MinimumSize = new System.Drawing.Size(38, 2);
            this.serverNum.Name = "serverNum";
            this.serverNum.Size = new System.Drawing.Size(38, 15);
            this.serverNum.TabIndex = 2;
            // 
            // stoppingNumber
            // 
            this.stoppingNumber.AutoSize = true;
            this.stoppingNumber.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.stoppingNumber.Location = new System.Drawing.Point(106, 39);
            this.stoppingNumber.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.stoppingNumber.MinimumSize = new System.Drawing.Size(38, 2);
            this.stoppingNumber.Name = "stoppingNumber";
            this.stoppingNumber.Size = new System.Drawing.Size(38, 15);
            this.stoppingNumber.TabIndex = 4;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(10, 39);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(89, 13);
            this.label11.TabIndex = 3;
            this.label11.Text = "Stopping Number";
            // 
            // stoppingCriteria
            // 
            this.stoppingCriteria.AutoSize = true;
            this.stoppingCriteria.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.stoppingCriteria.Location = new System.Drawing.Point(106, 67);
            this.stoppingCriteria.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.stoppingCriteria.MinimumSize = new System.Drawing.Size(38, 2);
            this.stoppingCriteria.Name = "stoppingCriteria";
            this.stoppingCriteria.Size = new System.Drawing.Size(38, 15);
            this.stoppingCriteria.TabIndex = 6;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(10, 67);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(84, 13);
            this.label10.TabIndex = 5;
            this.label10.Text = "Stopping Criteria";
            // 
            // selectionMethod
            // 
            this.selectionMethod.AutoSize = true;
            this.selectionMethod.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.selectionMethod.Location = new System.Drawing.Point(106, 99);
            this.selectionMethod.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.selectionMethod.MinimumSize = new System.Drawing.Size(38, 2);
            this.selectionMethod.Name = "selectionMethod";
            this.selectionMethod.Size = new System.Drawing.Size(38, 15);
            this.selectionMethod.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 99);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Selection Method";
            // 
            // interArrivalBtn
            // 
            this.interArrivalBtn.Location = new System.Drawing.Point(295, 11);
            this.interArrivalBtn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.interArrivalBtn.Name = "interArrivalBtn";
            this.interArrivalBtn.Size = new System.Drawing.Size(144, 41);
            this.interArrivalBtn.TabIndex = 9;
            this.interArrivalBtn.Text = "InterArrival Distribution";
            this.interArrivalBtn.UseVisualStyleBackColor = true;
            this.interArrivalBtn.Click += new System.EventHandler(this.interArrivalBtn_Click);
            // 
            // serversDistributionBtn
            // 
            this.serversDistributionBtn.Location = new System.Drawing.Point(295, 62);
            this.serversDistributionBtn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.serversDistributionBtn.Name = "serversDistributionBtn";
            this.serversDistributionBtn.Size = new System.Drawing.Size(144, 50);
            this.serversDistributionBtn.TabIndex = 10;
            this.serversDistributionBtn.Text = "ServiceDistribution Servers";
            this.serversDistributionBtn.UseVisualStyleBackColor = true;
            this.serversDistributionBtn.Click += new System.EventHandler(this.serversDistributionBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(550, 342);
            this.Controls.Add(this.serversDistributionBtn);
            this.Controls.Add(this.interArrivalBtn);
            this.Controls.Add(this.selectionMethod);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.stoppingCriteria);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.stoppingNumber);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.serverNum);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.browseButton);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MaximumSize = new System.Drawing.Size(566, 381);
            this.MinimumSize = new System.Drawing.Size(566, 381);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button browseButton;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label serverNum;
        private System.Windows.Forms.Label stoppingNumber;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label stoppingCriteria;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label selectionMethod;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button interArrivalBtn;
        private System.Windows.Forms.Button serversDistributionBtn;
    }
}