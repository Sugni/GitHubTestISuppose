﻿namespace GitHubTestISuppose
{
    partial class TestingGitHub
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
            this.butnClickMe = new System.Windows.Forms.Button();
            this.butnThatIsBetter = new System.Windows.Forms.Button();
            this.butnTheCoolest = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // butnClickMe
            // 
            this.butnClickMe.Location = new System.Drawing.Point(12, 12);
            this.butnClickMe.Name = "butnClickMe";
            this.butnClickMe.Size = new System.Drawing.Size(82, 65);
            this.butnClickMe.TabIndex = 0;
            this.butnClickMe.Text = "Click Me";
            this.butnClickMe.UseVisualStyleBackColor = true;
            this.butnClickMe.Click += new System.EventHandler(this.butnClickMe_Click);
            // 
            // butnThatIsBetter
            // 
            this.butnThatIsBetter.Location = new System.Drawing.Point(100, 12);
            this.butnThatIsBetter.Name = "butnThatIsBetter";
            this.butnThatIsBetter.Size = new System.Drawing.Size(206, 124);
            this.butnThatIsBetter.TabIndex = 1;
            this.butnThatIsBetter.Text = "The Cooler Button";
            this.butnThatIsBetter.UseVisualStyleBackColor = true;
            this.butnThatIsBetter.Click += new System.EventHandler(this.butnThatIsBetter_Click);
            // 
            // butnTheCoolest
            // 
            this.butnTheCoolest.Location = new System.Drawing.Point(312, 12);
            this.butnTheCoolest.Name = "butnTheCoolest";
            this.butnTheCoolest.Size = new System.Drawing.Size(406, 258);
            this.butnTheCoolest.TabIndex = 2;
            this.butnTheCoolest.Text = "The Coolest Button";
            this.butnTheCoolest.UseVisualStyleBackColor = true;
            this.butnTheCoolest.Click += new System.EventHandler(this.butnTheCoolest_Click);
            // 
            // TestingGitHub
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.butnTheCoolest);
            this.Controls.Add(this.butnThatIsBetter);
            this.Controls.Add(this.butnClickMe);
            this.Name = "TestingGitHub";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button butnClickMe;
        private System.Windows.Forms.Button butnThatIsBetter;
        private System.Windows.Forms.Button butnTheCoolest;
    }
}

