namespace IntSys04_NLP
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
            this.btnStart = new System.Windows.Forms.Button();
            this.tboxOutputPath = new System.Windows.Forms.TextBox();
            this.tboxProbPath = new System.Windows.Forms.TextBox();
            this.tboxEncodedPath = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnOutputPath = new System.Windows.Forms.Button();
            this.btnProbPath = new System.Windows.Forms.Button();
            this.btnEncodedPath = new System.Windows.Forms.Button();
            this.lblStatus = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(531, 139);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(75, 23);
            this.btnStart.TabIndex = 0;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // tboxOutputPath
            // 
            this.tboxOutputPath.Location = new System.Drawing.Point(151, 101);
            this.tboxOutputPath.Name = "tboxOutputPath";
            this.tboxOutputPath.Size = new System.Drawing.Size(404, 20);
            this.tboxOutputPath.TabIndex = 18;
            // 
            // tboxProbPath
            // 
            this.tboxProbPath.Location = new System.Drawing.Point(151, 61);
            this.tboxProbPath.Name = "tboxProbPath";
            this.tboxProbPath.Size = new System.Drawing.Size(404, 20);
            this.tboxProbPath.TabIndex = 17;
            // 
            // tboxEncodedPath
            // 
            this.tboxEncodedPath.Location = new System.Drawing.Point(151, 21);
            this.tboxEncodedPath.Name = "tboxEncodedPath";
            this.tboxEncodedPath.Size = new System.Drawing.Size(404, 20);
            this.tboxEncodedPath.TabIndex = 16;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 104);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 13);
            this.label3.TabIndex = 15;
            this.label3.Text = "Output location:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 13);
            this.label2.TabIndex = 14;
            this.label2.Text = "Probabilities file";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "Encoded file";
            // 
            // btnOutputPath
            // 
            this.btnOutputPath.Location = new System.Drawing.Point(577, 99);
            this.btnOutputPath.Name = "btnOutputPath";
            this.btnOutputPath.Size = new System.Drawing.Size(29, 23);
            this.btnOutputPath.TabIndex = 12;
            this.btnOutputPath.Text = "...";
            this.btnOutputPath.UseVisualStyleBackColor = true;
            this.btnOutputPath.Click += new System.EventHandler(this.btnOutputPath_Click);
            // 
            // btnProbPath
            // 
            this.btnProbPath.Location = new System.Drawing.Point(577, 59);
            this.btnProbPath.Name = "btnProbPath";
            this.btnProbPath.Size = new System.Drawing.Size(29, 23);
            this.btnProbPath.TabIndex = 11;
            this.btnProbPath.Text = "...";
            this.btnProbPath.UseVisualStyleBackColor = true;
            this.btnProbPath.Click += new System.EventHandler(this.btnProbPath_Click);
            // 
            // btnEncodedPath
            // 
            this.btnEncodedPath.Location = new System.Drawing.Point(577, 19);
            this.btnEncodedPath.Name = "btnEncodedPath";
            this.btnEncodedPath.Size = new System.Drawing.Size(29, 23);
            this.btnEncodedPath.TabIndex = 10;
            this.btnEncodedPath.Text = "...";
            this.btnEncodedPath.UseVisualStyleBackColor = true;
            this.btnEncodedPath.Click += new System.EventHandler(this.btnEncodedPath_Click);
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Location = new System.Drawing.Point(21, 149);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(0, 13);
            this.lblStatus.TabIndex = 19;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(626, 174);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.tboxOutputPath);
            this.Controls.Add(this.tboxProbPath);
            this.Controls.Add(this.tboxEncodedPath);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnOutputPath);
            this.Controls.Add(this.btnProbPath);
            this.Controls.Add(this.btnEncodedPath);
            this.Controls.Add(this.btnStart);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.TextBox tboxOutputPath;
        private System.Windows.Forms.TextBox tboxProbPath;
        private System.Windows.Forms.TextBox tboxEncodedPath;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnOutputPath;
        private System.Windows.Forms.Button btnProbPath;
        private System.Windows.Forms.Button btnEncodedPath;
        private System.Windows.Forms.Label lblStatus;
    }
}

