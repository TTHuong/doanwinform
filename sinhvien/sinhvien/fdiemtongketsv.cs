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
    public partial class fdiemtongketsv : Form
    {
        public fdiemtongketsv()
        {
            InitializeComponent();
        }

        private void data_diemtongketsv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {

            }
            catch(Exception)
            {
                return;
            }
        }
        cketnoi ketnoi = new cketnoi();
        private void fdiemtongketsv_Load(object sender, EventArgs e)
        {
            DataTable dt = ketnoi.sql_select("select * from diemsinhvien");
            if(dt.Rows.Count!=0)
            {
                data_diemtongketsv.DataSource = dt;
                data_diemtongketsv.Columns[0].HeaderText = "Mã sinh viên";
                data_diemtongketsv.Columns[1].HeaderText = "Điểm trung bình";
                data_diemtongketsv.Columns[2].HeaderText = "Điểm thi";
                data_diemtongketsv.Columns[3].HeaderText = "Điểm tổng kết";
                data_diemtongketsv.Columns[4].HeaderText = "Hạnh kiểm";
                data_diemtongketsv.Columns[5].HeaderText = "Mã môn học";
                data_diemtongketsv.Columns[6].HeaderText = "Ghi chú";
            }

            Color c = Color.FromArgb(211, 234, 15);
            button1.BackColor =  label1.BackColor = pictureBox1.BackColor =this.BackColor= c;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
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
