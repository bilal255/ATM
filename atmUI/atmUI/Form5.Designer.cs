﻿namespace atmUI
{
    partial class Form5
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form5));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.yesButton = new System.Windows.Forms.Button();
            this.noButton = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.MinPicBox = new System.Windows.Forms.PictureBox();
            this.ClosePicBox = new System.Windows.Forms.PictureBox();
            this.MaxPicBox = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MinPicBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ClosePicBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MaxPicBox)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(81, 124);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(213, 38);
            this.label1.TabIndex = 0;
            this.label1.Text = "Your transaction has been \r\ncompleted successfully.";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(81, 343);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(336, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Would you like to make another transaction?";
            // 
            // yesButton
            // 
            this.yesButton.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.yesButton.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.yesButton.Location = new System.Drawing.Point(565, 301);
            this.yesButton.Name = "yesButton";
            this.yesButton.Size = new System.Drawing.Size(132, 30);
            this.yesButton.TabIndex = 2;
            this.yesButton.Text = "Yes";
            this.yesButton.UseVisualStyleBackColor = false;
            this.yesButton.Click += new System.EventHandler(this.yesButton_Click);
            this.yesButton.MouseLeave += new System.EventHandler(this.yesButton_MouseLeave);
            this.yesButton.MouseHover += new System.EventHandler(this.yesButton_MouseHover);
            // 
            // noButton
            // 
            this.noButton.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.noButton.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.noButton.Location = new System.Drawing.Point(565, 378);
            this.noButton.Name = "noButton";
            this.noButton.Size = new System.Drawing.Size(132, 30);
            this.noButton.TabIndex = 2;
            this.noButton.Text = "No";
            this.noButton.UseVisualStyleBackColor = false;
            this.noButton.MouseLeave += new System.EventHandler(this.noButton_MouseLeave);
            this.noButton.MouseHover += new System.EventHandler(this.noButton_MouseHover);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(60)))), ((int)(((byte)(55)))));
            this.panel1.Controls.Add(this.MinPicBox);
            this.panel1.Controls.Add(this.ClosePicBox);
            this.panel1.Controls.Add(this.MaxPicBox);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 36);
            this.panel1.TabIndex = 8;
            // 
            // MinPicBox
            // 
            this.MinPicBox.Image = ((System.Drawing.Image)(resources.GetObject("MinPicBox.Image")));
            this.MinPicBox.Location = new System.Drawing.Point(680, 0);
            this.MinPicBox.Name = "MinPicBox";
            this.MinPicBox.Size = new System.Drawing.Size(36, 36);
            this.MinPicBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.MinPicBox.TabIndex = 6;
            this.MinPicBox.TabStop = false;
            this.MinPicBox.Click += new System.EventHandler(this.MinPicBox_Click);
            this.MinPicBox.MouseLeave += new System.EventHandler(this.MinPicBox_MouseLeave);
            this.MinPicBox.MouseHover += new System.EventHandler(this.MinPicBox_MouseHover);
            // 
            // ClosePicBox
            // 
            this.ClosePicBox.BackColor = System.Drawing.Color.Transparent;
            this.ClosePicBox.Image = ((System.Drawing.Image)(resources.GetObject("ClosePicBox.Image")));
            this.ClosePicBox.Location = new System.Drawing.Point(764, 0);
            this.ClosePicBox.Name = "ClosePicBox";
            this.ClosePicBox.Size = new System.Drawing.Size(36, 36);
            this.ClosePicBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.ClosePicBox.TabIndex = 6;
            this.ClosePicBox.TabStop = false;
            this.ClosePicBox.Click += new System.EventHandler(this.ClosePicBox_Click);
            this.ClosePicBox.MouseLeave += new System.EventHandler(this.ClosePicBox_MouseLeave);
            this.ClosePicBox.MouseHover += new System.EventHandler(this.ClosePicBox_MouseHover);
            // 
            // MaxPicBox
            // 
            this.MaxPicBox.Image = ((System.Drawing.Image)(resources.GetObject("MaxPicBox.Image")));
            this.MaxPicBox.Location = new System.Drawing.Point(722, 0);
            this.MaxPicBox.Name = "MaxPicBox";
            this.MaxPicBox.Size = new System.Drawing.Size(36, 36);
            this.MaxPicBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.MaxPicBox.TabIndex = 6;
            this.MaxPicBox.TabStop = false;
            this.MaxPicBox.Click += new System.EventHandler(this.MaxPicBox_Click);
            this.MaxPicBox.MouseLeave += new System.EventHandler(this.MaxPicBox_MouseLeave);
            this.MaxPicBox.MouseHover += new System.EventHandler(this.MaxPicBox_MouseHover);
            // 
            // Form5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.DarkSlateGray;
            this.ClientSize = new System.Drawing.Size(800, 600);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.noButton);
            this.Controls.Add(this.yesButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.MinimumSize = new System.Drawing.Size(800, 600);
            this.Name = "Form5";
            this.Text = "Form5";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form5_FormClosed);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.MinPicBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ClosePicBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MaxPicBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button yesButton;
        private System.Windows.Forms.Button noButton;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox MinPicBox;
        private System.Windows.Forms.PictureBox ClosePicBox;
        private System.Windows.Forms.PictureBox MaxPicBox;
    }
}