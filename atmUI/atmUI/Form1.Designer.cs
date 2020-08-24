﻿namespace atmUI
{
    partial class LoginForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.loginButton = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.MaxPicBox = new System.Windows.Forms.PictureBox();
            this.MinPicBox = new System.Windows.Forms.PictureBox();
            this.ClosePicBox = new System.Windows.Forms.PictureBox();
            this.ResetPicBox = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MaxPicBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MinPicBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ClosePicBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ResetPicBox)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(55, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(193, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Welcome to ATM system";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(55, 136);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(201, 21);
            this.label2.TabIndex = 1;
            this.label2.Text = "Please enter your login id";
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.textBox1.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(207, 210);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(250, 26);
            this.textBox1.TabIndex = 2;
            // 
            // loginButton
            // 
            this.loginButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.loginButton.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.loginButton.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginButton.Location = new System.Drawing.Point(278, 259);
            this.loginButton.Name = "loginButton";
            this.loginButton.Size = new System.Drawing.Size(111, 35);
            this.loginButton.TabIndex = 3;
            this.loginButton.Text = "Login";
            this.loginButton.UseVisualStyleBackColor = false;
            this.loginButton.Click += new System.EventHandler(this.loginButton_Click);
            this.loginButton.MouseLeave += new System.EventHandler(this.loginButton_MouseLeave);
            this.loginButton.MouseHover += new System.EventHandler(this.loginButton_MouseHover);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(60)))), ((int)(((byte)(55)))));
            this.panel1.Controls.Add(this.MaxPicBox);
            this.panel1.Controls.Add(this.MinPicBox);
            this.panel1.Controls.Add(this.ClosePicBox);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 36);
            this.panel1.TabIndex = 5;
            // 
            // MaxPicBox
            // 
            this.MaxPicBox.Image = global::atmUI.Properties.Resources.icons8_maximize_button_20;
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
            // ResetPicBox
            // 
            this.ResetPicBox.BackColor = System.Drawing.Color.Transparent;
            this.ResetPicBox.Image = global::atmUI.Properties.Resources.icons8_maximize_button_20;
            this.ResetPicBox.Location = new System.Drawing.Point(701, 73);
            this.ResetPicBox.Name = "ResetPicBox";
            this.ResetPicBox.Size = new System.Drawing.Size(36, 36);
            this.ResetPicBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.ResetPicBox.TabIndex = 6;
            this.ResetPicBox.TabStop = false;
            this.ResetPicBox.Click += new System.EventHandler(this.ResetPicBox_Click);
            // 
            // LoginForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.DarkSlateGray;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ResetPicBox);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.loginButton);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "LoginForm";
            this.Text = "Form1";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.LoginForm_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.MaxPicBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MinPicBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ClosePicBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ResetPicBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button loginButton;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox ClosePicBox;
        private System.Windows.Forms.PictureBox MaxPicBox;
        private System.Windows.Forms.PictureBox MinPicBox;
        private System.Windows.Forms.PictureBox ResetPicBox;
    }
}

