using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
namespace sinhvien
{
    public partial class ftrogiup : Form
    {
        public TextBox f_c = new TextBox();
        public ftrogiup()
        {
            InitializeComponent();
        }

        private void link_gmail_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            using (Process pro = new Process())
            {
                pro.StartInfo.FileName = "mailto:" + link_gmail.Text;
                pro.Start();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void ftrogiup_Load(object sender, EventArgs e)
        {
            Color c = Color.FromArgb(211, 234, 15);
            button1.BackColor = button2.BackColor = pictureBox1.BackColor = lab_tieude.BackColor = c;
        }
        int x, y;
        private void lab_tieude_MouseDown(object sender, MouseEventArgs e)
        {
            x = e.X;
            y = e.Y;
        }

        private void lab_tieude_MouseUp(object sender, MouseEventArgs e)
        {
            this.Location = new Point(this.Location.X + (e.X - x), this.Location.Y + (e.Y - y));
        }
    }
}
