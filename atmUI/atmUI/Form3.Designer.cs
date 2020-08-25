namespace atmUI
{
    partial class AccForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AccForm));
            this.label1 = new System.Windows.Forms.Label();
            this.currButton = new System.Windows.Forms.Button();
            this.savButton = new System.Windows.Forms.Button();
            this.defButton = new System.Windows.Forms.Button();
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
            this.label1.Location = new System.Drawing.Point(65, 91);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(250, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Please select an account type:";
            // 
            // currButton
            // 
            this.currButton.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.currButton.Location = new System.Drawing.Point(510, 186);
            this.currButton.Name = "currButton";
            this.currButton.Size = new System.Drawing.Size(172, 38);
            this.currButton.TabIndex = 1;
            this.currButton.Text = "Current";
            this.currButton.UseVisualStyleBackColor = false;
            this.currButton.Click += new System.EventHandler(this.button1_Click);
            this.currButton.MouseLeave += new System.EventHandler(this.currButton_MouseLeave);
            this.currButton.MouseHover += new System.EventHandler(this.currButton_MouseHover);
            // 
            // savButton
            // 
            this.savButton.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.savButton.Location = new System.Drawing.Point(510, 252);
            this.savButton.Name = "savButton";
            this.savButton.Size = new System.Drawing.Size(172, 38);
            this.savButton.TabIndex = 1;
            this.savButton.Text = "Savings";
            this.savButton.UseVisualStyleBackColor = false;
            this.savButton.MouseLeave += new System.EventHandler(this.savButton_MouseLeave);
            this.savButton.MouseHover += new System.EventHandler(this.savButton_MouseHover);
            // 
            // defButton
            // 
            this.defButton.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.defButton.Location = new System.Drawing.Point(510, 319);
            this.defButton.Name = "defButton";
            this.defButton.Size = new System.Drawing.Size(172, 38);
            this.defButton.TabIndex = 1;
            this.defButton.Text = "Default";
            this.defButton.UseVisualStyleBackColor = false;
            this.defButton.MouseLeave += new System.EventHandler(this.defButton_MouseLeave);
            this.defButton.MouseHover += new System.EventHandler(this.defButton_MouseHover);
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
            this.panel1.TabIndex = 7;
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
            this.BackPicBox.TabIndex = 8;
            this.BackPicBox.TabStop = false;
            this.BackPicBox.Click += new System.EventHandler(this.BackPicBox_Click);
            this.BackPicBox.MouseLeave += new System.EventHandler(this.BackPicBox_MouseLeave);
            this.BackPicBox.MouseHover += new System.EventHandler(this.BackPicBox_MouseHover);
            // 
            // AccForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateGray;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.defButton);
            this.Controls.Add(this.savButton);
            this.Controls.Add(this.currButton);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "AccForm";
            this.Text = "Form3";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.AccForm_FormClosed);
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
        private System.Windows.Forms.Button currButton;
        private System.Windows.Forms.Button savButton;
        private System.Windows.Forms.Button defButton;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox MinPicBox;
        private System.Windows.Forms.PictureBox ClosePicBox;
        private System.Windows.Forms.PictureBox MaxPicBox;
        private System.Windows.Forms.PictureBox BackPicBox;
    }
}