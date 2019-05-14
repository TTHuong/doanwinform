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
    public partial class fdssv : Form
    {
        cketnoi ketnoi = new cketnoi();

        public fdssv()
        {
            InitializeComponent();
        }

        private void data_dssv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {

            }
            catch(Exception)
            {
                return;
            }
        }

        private void fdssv_Load(object sender, EventArgs e)
        {
            DataTable dt = ketnoi.sql_select("select * from sinhvien ");
            if(dt.Rows.Count!=0)
            {
                data_dssv.DataSource = dt;
                data_dssv.Columns[0].HeaderText = "Mã sinh viên";
                data_dssv.Columns[1].HeaderText = "Tên sinh viên";
                data_dssv.Columns[2].HeaderText = "Ngày sinh";
                data_dssv.Columns[3].HeaderText = "Giới tính";
                data_dssv.Columns[4].HeaderText = "Địa chỉ";
                data_dssv.Columns[5].HeaderText = "Mã lớp";
            }
            else
            {
                data_dssv.DataSource = null;
                data_dssv.Rows.Clear();
            }
            Color c = Color.FromArgb(211, 234, 15);
            pictureBox1.BackColor = button1.BackColor = button2.BackColor = label1.BackColor = c;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        int x, y;
        private void label1_MouseDown(object sender, MouseEventArgs e)
        {
            x = e.X;
            y = e.Y;
        }

        private void label1_MouseUp(object sender, MouseEventArgs e)
        {
            this.Location = new Point(this.Location.X + (e.X - x), this.Location.Y + (e.Y - y));
        }

    }
}
