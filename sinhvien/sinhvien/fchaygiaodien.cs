using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sinhvien
{
    public partial class fchaygiaodien : Form
    {
        public fchaygiaodien()
        {
            InitializeComponent();
        }
        public bool ketthuc = false;

        int i = 1;
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (i <=10 )
            {
                if (i % 2 == 0)
                {
                    label1.Text = "Chương trình đang chạy ...(" + i.ToString() + "0" + "%)";
                }
                i++;
            }
            else
            {
                ketthuc = true;
                this.Close();
            }
        }

        private void fchaygiaodien_Load(object sender, EventArgs e)
        {
            label1.Text += "...(0 %)";
            this.label1.Parent = this.pictureBox1;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            ketthuc = true;
            this.Close();
        }

    }
}
