namespace TomcatControlApp
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btnStartTomcat = new System.Windows.Forms.Button();
            this.btnStopTomcat = new System.Windows.Forms.Button();
            this.TomcatPath = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSavePath = new System.Windows.Forms.Button();
            this.lblStatus = new System.Windows.Forms.Label();
            this.picStatusIndicator = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picStatusIndicator)).BeginInit();
            this.SuspendLayout();
            // 
            // btnStartTomcat
            // 
            this.btnStartTomcat.BackColor = System.Drawing.Color.Black;
            this.btnStartTomcat.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnStartTomcat.ForeColor = System.Drawing.Color.White;
            this.btnStartTomcat.Location = new System.Drawing.Point(426, 46);
            this.btnStartTomcat.Name = "btnStartTomcat";
            this.btnStartTomcat.Size = new System.Drawing.Size(75, 26);
            this.btnStartTomcat.TabIndex = 2;
            this.btnStartTomcat.Text = "Start";
            this.btnStartTomcat.UseVisualStyleBackColor = false;
            this.btnStartTomcat.Click += new System.EventHandler(this.btnStartTomcat_Click);
            // 
            // btnStopTomcat
            // 
            this.btnStopTomcat.BackColor = System.Drawing.Color.Black;
            this.btnStopTomcat.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnStopTomcat.ForeColor = System.Drawing.Color.White;
            this.btnStopTomcat.Location = new System.Drawing.Point(524, 46);
            this.btnStopTomcat.Name = "btnStopTomcat";
            this.btnStopTomcat.Size = new System.Drawing.Size(75, 26);
            this.btnStopTomcat.TabIndex = 3;
            this.btnStopTomcat.Text = "Stop";
            this.btnStopTomcat.UseVisualStyleBackColor = false;
            this.btnStopTomcat.Click += new System.EventHandler(this.btnStopTomcat_Click);
            // 
            // TomcatPath
            // 
            this.TomcatPath.BackColor = System.Drawing.Color.Black;
            this.TomcatPath.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TomcatPath.ForeColor = System.Drawing.Color.White;
            this.TomcatPath.Location = new System.Drawing.Point(108, 13);
            this.TomcatPath.Name = "TomcatPath";
            this.TomcatPath.Size = new System.Drawing.Size(393, 15);
            this.TomcatPath.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(10, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "Tomcat Path:";
            // 
            // btnSavePath
            // 
            this.btnSavePath.BackColor = System.Drawing.Color.Black;
            this.btnSavePath.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnSavePath.ForeColor = System.Drawing.Color.White;
            this.btnSavePath.Location = new System.Drawing.Point(524, 8);
            this.btnSavePath.Name = "btnSavePath";
            this.btnSavePath.Size = new System.Drawing.Size(75, 23);
            this.btnSavePath.TabIndex = 1;
            this.btnSavePath.Text = "Save";
            this.btnSavePath.UseVisualStyleBackColor = false;
            this.btnSavePath.Click += new System.EventHandler(this.btnSavePath_Click);
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.BackColor = System.Drawing.Color.Transparent;
            this.lblStatus.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.lblStatus.Location = new System.Drawing.Point(39, 51);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(14, 16);
            this.lblStatus.TabIndex = 5;
            this.lblStatus.Text = ">";
            // 
            // picStatusIndicator
            // 
            this.picStatusIndicator.Location = new System.Drawing.Point(18, 53);
            this.picStatusIndicator.Name = "picStatusIndicator";
            this.picStatusIndicator.Size = new System.Drawing.Size(12, 11);
            this.picStatusIndicator.TabIndex = 6;
            this.picStatusIndicator.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(615, 82);
            this.Controls.Add(this.picStatusIndicator);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.btnSavePath);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TomcatPath);
            this.Controls.Add(this.btnStopTomcat);
            this.Controls.Add(this.btnStartTomcat);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Tomcat Control";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picStatusIndicator)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnStartTomcat;
        private System.Windows.Forms.Button btnStopTomcat;
        private System.Windows.Forms.TextBox TomcatPath;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSavePath;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.PictureBox picStatusIndicator;
    }
}

