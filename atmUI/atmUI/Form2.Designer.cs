namespace atmUI
{
    partial class PinForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PinForm));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.submitButton = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.MinPicBox = new System.Windows.Forms.PictureBox();
            this.ClosePicBox = new System.Windows.Forms.PictureBox();
            this.MaxPicBox = new System.Windows.Forms.PictureBox();
            this.BackPicBox = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MinPicBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ClosePicBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MaxPicBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BackPicBox)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(102, 92);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(173, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Please enter your PIN:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(97, 115);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(262, 21);
            this.label2.TabIndex = 1;
            this.label2.Text = "(Personal Identification Number)";
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.textBox1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(296, 177);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(113, 27);
            this.textBox1.TabIndex = 2;
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // submitButton
            // 
            this.submitButton.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.submitButton.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.submitButton.Location = new System.Drawing.Point(321, 227);
            this.submitButton.Name = "submitButton";
            this.submitButton.Size = new System.Drawing.Size(73, 32);
            this.submitButton.TabIndex = 4;
            this.submitButton.Text = "Submit";
            this.submitButton.UseVisualStyleBackColor = false;
            this.submitButton.Click += new System.EventHandler(this.button1_Click);
            this.submitButton.MouseLeave += new System.EventHandler(this.submitButton_MouseLeave);
            this.submitButton.MouseHover += new System.EventHandler(this.submitButton_MouseHover);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(60)))), ((int)(((byte)(55)))));
            this.panel1.Controls.Add(this.BackPicBox);
            this.panel1.Controls.Add(this.MinPicBox);
            this.panel1.Controls.Add(this.ClosePicBox);
            this.panel1.Controls.Add(this.MaxPicBox);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 36);
            this.panel1.TabIndex = 6;
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
            // BackPicBox
            // 
            this.BackPicBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(60)))), ((int)(((byte)(55)))));
            this.BackPicBox.Image = ((System.Drawing.Image)(resources.GetObject("BackPicBox.Image")));
            this.BackPicBox.Location = new System.Drawing.Point(0, 0);
            this.BackPicBox.Name = "BackPicBox";
            this.BackPicBox.Size = new System.Drawing.Size(36, 36);
            this.BackPicBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.BackPicBox.TabIndex = 7;
            this.BackPicBox.TabStop = false;
            this.BackPicBox.Click += new System.EventHandler(this.BackPicBox_Click);
            this.BackPicBox.MouseLeave += new System.EventHandler(this.BackPicBox_MouseLeave);
            this.BackPicBox.MouseHover += new System.EventHandler(this.BackPicBox_MouseHover);
            // 
            // PinForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateGray;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.submitButton);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "PinForm";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.PinForm_FormClosed);
            this.Load += new System.EventHandler(this.PinForm_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.MinPicBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ClosePicBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MaxPicBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BackPicBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button submitButton;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox MinPicBox;
        private System.Windows.Forms.PictureBox ClosePicBox;
        private System.Windows.Forms.PictureBox MaxPicBox;
        private System.Windows.Forms.PictureBox BackPicBox;
    }
}