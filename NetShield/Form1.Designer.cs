namespace NetShield
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
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.debugInstructionsLabel = new System.Windows.Forms.Label();
            this.startLogger = new System.Windows.Forms.Button();
            this.helloWorldLabel = new System.Windows.Forms.Label();
            this.stopLogger = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(127, 228);
            this.linkLabel1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(0, 13);
            this.linkLabel1.TabIndex = 0;
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // debugInstructionsLabel
            // 
            this.debugInstructionsLabel.AutoSize = true;
            this.debugInstructionsLabel.Location = new System.Drawing.Point(97, 70);
            this.debugInstructionsLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.debugInstructionsLabel.Name = "debugInstructionsLabel";
            this.debugInstructionsLabel.Size = new System.Drawing.Size(0, 13);
            this.debugInstructionsLabel.TabIndex = 1;
            // 
            // startLogger
            // 
            this.startLogger.Location = new System.Drawing.Point(65, 85);
            this.startLogger.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.startLogger.Name = "startLogger";
            this.startLogger.Size = new System.Drawing.Size(97, 28);
            this.startLogger.TabIndex = 2;
            this.startLogger.Text = "Start logger";
            this.startLogger.UseVisualStyleBackColor = true;
            this.startLogger.Click += new System.EventHandler(this.startLogger_Click);
            // 
            // helloWorldLabel
            // 
            this.helloWorldLabel.AutoSize = true;
            this.helloWorldLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.helloWorldLabel.Location = new System.Drawing.Point(202, 19);
            this.helloWorldLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.helloWorldLabel.Name = "helloWorldLabel";
            this.helloWorldLabel.Size = new System.Drawing.Size(0, 26);
            this.helloWorldLabel.TabIndex = 3;
            // 
            // stopLogger
            // 
            this.stopLogger.Location = new System.Drawing.Point(245, 85);
            this.stopLogger.Margin = new System.Windows.Forms.Padding(2);
            this.stopLogger.Name = "stopLogger";
            this.stopLogger.Size = new System.Drawing.Size(97, 28);
            this.stopLogger.TabIndex = 4;
            this.stopLogger.Text = "Stop logger";
            this.stopLogger.UseVisualStyleBackColor = true;
            this.stopLogger.Click += new System.EventHandler(this.stopLogger_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(533, 292);
            this.Controls.Add(this.stopLogger);
            this.Controls.Add(this.helloWorldLabel);
            this.Controls.Add(this.startLogger);
            this.Controls.Add(this.debugInstructionsLabel);
            this.Controls.Add(this.linkLabel1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Label debugInstructionsLabel;
        private System.Windows.Forms.Button startLogger;
        private System.Windows.Forms.Label helloWorldLabel;
        private System.Windows.Forms.Button stopLogger;
    }
}

