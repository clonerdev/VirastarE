﻿namespace Balloon.NET
{
    partial class CPPPunctuation
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
            this.lblMessage = new System.Windows.Forms.Label();
            this.lblIgnorePuctuation = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblMessage
            // 
            this.lblMessage.AutoSize = true;
            this.lblMessage.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lblMessage.Location = new System.Drawing.Point(255, 9);
            this.lblMessage.Name = "lblMessage";
            this.lblMessage.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblMessage.Size = new System.Drawing.Size(16, 13);
            this.lblMessage.TabIndex = 0;
            this.lblMessage.Text = "   ";
            // 
            // lblIgnorePuctuation
            // 
            this.lblIgnorePuctuation.AutoSize = true;
            this.lblIgnorePuctuation.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lblIgnorePuctuation.Location = new System.Drawing.Point(187, 57);
            this.lblIgnorePuctuation.Name = "lblIgnorePuctuation";
            this.lblIgnorePuctuation.Size = new System.Drawing.Size(84, 13);
            this.lblIgnorePuctuation.TabIndex = 1;
            this.lblIgnorePuctuation.Text = "نادیده گرفته شود";
            this.lblIgnorePuctuation.Click += new System.EventHandler(this.lblIgnorePuctuation_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(131, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(145, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "_______________________";
            // 
            // CPPPunctuation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(283, 78);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblIgnorePuctuation);
            this.Controls.Add(this.lblMessage);
            this.Name = "CPPPunctuation";
            this.Text = "CPPPunctuation";
            this.Deactivate += new System.EventHandler(this.CPPPunctuation_Deactivate);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblMessage;
        private System.Windows.Forms.Label lblIgnorePuctuation;
        private System.Windows.Forms.Label label1;
    }
}