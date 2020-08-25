using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace atmUI
{
    public partial class AccForm : Form
    {
        public AccForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            QueryForm Q = new QueryForm();
            Q.Show();
        }

        private void currButton_MouseHover(object sender, EventArgs e)
        {
            currButton.BackColor = Color.DarkSlateGray;
        }

        private void currButton_MouseLeave(object sender, EventArgs e)
        {
            currButton.BackColor = Color.DarkGray;
        }

        private void savButton_MouseHover(object sender, EventArgs e)
        {
            savButton.BackColor = Color.DarkSlateGray;
        }

        private void savButton_MouseLeave(object sender, EventArgs e)
        {
            savButton.BackColor = Color.DarkGray;
        }

        private void defButton_MouseHover(object sender, EventArgs e)
        {
            defButton.BackColor = Color.DarkSlateGray;
        }

        private void defButton_MouseLeave(object sender, EventArgs e)
        {
            defButton.BackColor = Color.DarkGray;
        }

        private void MaxPicBox_Click(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Maximized)
            {
                this.WindowState = FormWindowState.Normal;

                int CurActForX = 0, CurCloPicLocX = 0, CurMaxPicLocX = 0, CurMinPicLocX = 0;

                CurActForX = ActiveForm.Width;
                CurCloPicLocX = (CurActForX - 32);
                CurMaxPicLocX = (CurActForX - 64);
                CurMinPicLocX = (CurActForX - 96);

                this.ClosePicBox.Location = new Point(CurCloPicLocX, 0);
                this.MaxPicBox.Location = new Point(CurMaxPicLocX, 0);
                this.MinPicBox.Location = new Point(CurMinPicLocX, 0);
            }
            else
            {
                this.WindowState = FormWindowState.Maximized;

                int ActForX = 0, CloPicLocX = 0, MaxPicLocX = 0, MinPicLocX = 0;

                ActForX = ActiveForm.Width;
                CloPicLocX = (ActForX - 32);
                MaxPicLocX = (ActForX - 64);
                MinPicLocX = (ActForX - 96);

                this.ClosePicBox.Location = new Point(CloPicLocX, 0);
                this.MaxPicBox.Location = new Point(MaxPicLocX, 0);
                this.MinPicBox.Location = new Point(MinPicLocX, 0);
            }
        }

        private void MinPicBox_Click(object sender, EventArgs e)
        {
            if (this.WindowState != FormWindowState.Minimized)
            {
                this.WindowState = FormWindowState.Minimized;
            }
        }

        private void ClosePicBox_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AccForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Dispose();
        }

        private void MinPicBox_MouseHover(object sender, EventArgs e)
        {
            MinPicBox.BackColor = Color.DarkSlateGray;
        }

        private void MinPicBox_MouseLeave(object sender, EventArgs e)
        {
            MinPicBox.BackColor = Color.Transparent;
        }

        private void MaxPicBox_MouseHover(object sender, EventArgs e)
        {
            MaxPicBox.BackColor = Color.DarkSlateGray;
        }

        private void MaxPicBox_MouseLeave(object sender, EventArgs e)
        {
            MaxPicBox.BackColor = Color.Transparent;
        }

        private void ClosePicBox_MouseHover(object sender, EventArgs e)
        {
            ClosePicBox.BackColor = Color.DarkSlateGray;
        }

        private void ClosePicBox_MouseLeave(object sender, EventArgs e)
        {
            ClosePicBox.BackColor = Color.Transparent;
        }

        private void BackPicBox_Click(object sender, EventArgs e)
        {
            this.Hide();
            PinForm p = new PinForm();
            p.Show();
        }

        private void BackPicBox_MouseHover(object sender, EventArgs e)
        {
            BackPicBox.BackColor = Color.DarkSlateGray;
        }

        private void BackPicBox_MouseLeave(object sender, EventArgs e)
        {
            BackPicBox.BackColor = Color.Transparent;
        }
    }
}
