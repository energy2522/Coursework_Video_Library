﻿namespace Video_Library
{
    partial class Thriller
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
            this.SuspendLayout();
            // 
            // Thriller
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1384, 561);
            this.Name = "Thriller";
            this.Text = "Триллеры";
            this.Load += new System.EventHandler(this.Thriller_Load);
            this.Controls.SetChildIndex(this.Sign_in_button, 0);
            this.Controls.SetChildIndex(this.Registration, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
    }
}