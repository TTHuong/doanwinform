﻿using System;
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
    public partial class fhoclai : Form
    {
        public fhoclai()
        {
            InitializeComponent();
        }
        cketnoi ketnoi = new cketnoi();
        public TextBox f_c = new TextBox();
        void load_font_color()
        {
            txt_masinhvien.Font = txt_tensinhvien.Font = cb_khoa.Font = cb_lop.Font = cb_monhoc.Font = f_c.Font;
            txt_masinhvien.ForeColor = txt_tensinhvien.ForeColor = cb_khoa.ForeColor = cb_lop.ForeColor = cb_monhoc.ForeColor = f_c.ForeColor;
        }
        void load_khoa()
        {
            DataTable dt = ketnoi.sql_select("select makhoa from khoa");
            while(cb_khoa.Items.Count!=0)
            {
                cb_khoa.Items.RemoveAt(0);
            }
            if(dt.Rows.Count!=0)
            {
                for(int i=0;i<dt.Rows.Count;i++)
                {
                    cb_khoa.Items.Add(dt.Rows[i]["makhoa"].ToString());
                }
            }
        }
        void load_malop()
        {
            DataTable dt = ketnoi.sql_select("select malop from lop group by malop");
            while (cb_lop.Items.Count != 0)
            {
                MessageBox.Show(cb_lop.Items.IndexOf(0).ToString());
                cb_lop.Items.RemoveAt(0);

            }

            if (dt.Rows.Count != 0)
            {
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    cb_lop.Items.Add(dt.Rows[i]["malop"].ToString());
                }
            }
        }
        void load_mamonhoc()
        {
            DataTable dt = ketnoi.sql_select("select mamonhoc from monhoc group by mamonhoc");
            while (cb_monhoc.Items.Count != 0)
            {
                cb_monhoc.Items.RemoveAt(0);
            }

            if (dt.Rows.Count != 0)
            {
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    cb_monhoc.Items.Add(dt.Rows[i]["mamonhoc"].ToString());

                }
            }
        }
        int cong = 5;
        private void timer1_Tick(object sender, EventArgs e)
        {
            lab_tieude.Location = new Point(lab_tieude.Location.X + cong, lab_tieude.Location.Y);
            if (lab_tieude.Location.X >= (932 - lab_tieude.Width) || lab_tieude.Location.X <= 0)
            {
                cong = -cong;
            }
        }

        void hoatdong()
        {
            txt_masinhvien.Enabled = true;
            txt_tensinhvien.Enabled = true;
            
            cb_khoa.Enabled = true;
            cb_lop.Enabled = true;
            cb_monhoc.Enabled = true;
        }
        void reset()
        {
            txt_masinhvien.Text = "";
            txt_tensinhvien.Text = "";
           
            cb_khoa.Text = "";
            cb_lop.Text = "";
            cb_monhoc.Text = "";
        }
        void reset_data()
        {
            data_thongtinsinhvienthilai.DataSource = null;
            data_thongtinsinhvienthilai.Rows.Clear();
        }
        
        private void data_thongtinsinhvien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {

            }
            catch (Exception)
            {
                return;
            }
        }

        private void fhoclai_Load(object sender, EventArgs e)
        {
            load_font_color();
            load_khoa();
            load_malop();
            load_mamonhoc();

            Color v = Color.FromArgb(220, 199, 110);
            but_timkiem.BackColor = v;

            Color c = Color.FromArgb(211, 234, 15);
            button1.BackColor = button2.BackColor = lab_tieude.BackColor = pictureBox1.BackColor = c;
        }

        private void txt_masinhvien_TextChanged_1(object sender, EventArgs e)
        {
            if (txt_masinhvien.Text != "")
            {
                txt_tensinhvien.Enabled = false;

                cb_khoa.Enabled = false;
                cb_lop.Enabled = false;
                cb_monhoc.Enabled = false;
            }
            else
            {
                txt_tensinhvien.Enabled = true;

                cb_khoa.Enabled = true;
                cb_lop.Enabled = true;
                cb_monhoc.Enabled = true;
            }
        }

        private void txt_tensinhvien_TextChanged_1(object sender, EventArgs e)
        {
            if (txt_tensinhvien.Text != "")
            {
                txt_masinhvien.Enabled = false;

                cb_khoa.Enabled = false;
                cb_lop.Enabled = false;
                cb_monhoc.Enabled = false;
            }
            else
            {
                txt_masinhvien.Enabled = true;

                cb_khoa.Enabled = true;
                cb_lop.Enabled = true;
                cb_monhoc.Enabled = true;
            }
        }

        private void cb_khoa_TextChanged_1(object sender, EventArgs e)
        {
            if (cb_khoa.Text != "")
            {
                txt_masinhvien.Enabled = false;

                txt_tensinhvien.Enabled = false;
                cb_lop.Enabled = false;
                cb_monhoc.Enabled = false;
            }
            else
            {
                txt_masinhvien.Enabled = true;

                txt_tensinhvien.Enabled = true;
                cb_lop.Enabled = true;
                cb_monhoc.Enabled = true;
            }
        }

        private void cb_lop_TextChanged_1(object sender, EventArgs e)
        {
            if (cb_lop.Text != "")
            {
                txt_masinhvien.Enabled = false;

                cb_khoa.Enabled = false;
                txt_tensinhvien.Enabled = false;
                cb_monhoc.Enabled = false;
            }
            else
            {
                txt_masinhvien.Enabled = true;
                cb_khoa.Enabled = true;
                txt_tensinhvien.Enabled = true;
                cb_monhoc.Enabled = true;
            }
        }

        private void cb_monhoc_TextChanged_1(object sender, EventArgs e)
        {
            if (cb_monhoc.Text != "")
            {
                txt_masinhvien.Enabled = false;
                cb_khoa.Enabled = false;
                cb_lop.Enabled = false;
                txt_tensinhvien.Enabled = false;
            }
            else
            {
                txt_masinhvien.Enabled = true;
                cb_khoa.Enabled = true;
                cb_lop.Enabled = true;
                txt_tensinhvien.Enabled = true;
            }
        }

        private void but_timkiem_Click_1(object sender, EventArgs e)
        {
            try
            {

                DataTable dt = new DataTable();
                if (txt_masinhvien.Enabled == true)
                {
                    dt = ketnoi.sql_select("select d.masinhvien,sv.tensinhvien,d.diemthi,d.diemtb,d.diemtongket,d.hanhkiem,d.monhoc from diemsinhvien d,sinhvien sv where d.masinhvien=sv.masinhvien  and  sv.masinhvien ='" + txt_masinhvien.Text + "' and d.diemtongket<5");
                }
                if (txt_tensinhvien.Enabled == true)
                {
                    dt = ketnoi.sql_select("select d.masinhvien,sv.tensinhvien,d.diemthi,d.diemtb,d.diemtongket,d.hanhkiem,d.monhoc from diemsinhvien d,sinhvien sv where d.masinhvien=sv.masinhvien and sv.tensinhvien='" + txt_tensinhvien.Text + "' and d.diemtongket<5 ");
                }

                if (cb_khoa.Enabled == true)
                {
                    dt = ketnoi.sql_select("select d.masinhvien,sv.tensinhvien,d.diemthi,d.diemtb,d.diemtongket,d.hanhkiem,d.monhoc from diemsinhvien d,sinhvien sv,monhoc mh where d.masinhvien=sv.masinhvien and d.monhoc=mh.mamonhoc and mh.makhoa='" + cb_khoa.Text + "' and d.diemtongket<5");
                }
                if (cb_lop.Enabled == true)
                {
                    dt = ketnoi.sql_select("select d.masinhvien,sv.tensinhvien,d.diemthi,d.diemtb,d.diemtongket,d.hanhkiem,d.monhoc from diemsinhvien d,sinhvien sv where d.masinhvien=sv.masinhvien and sv.malop='" + cb_lop.Text + "' and d.diemtongket<5");
                }
                if (cb_monhoc.Enabled == true)
                {
                    dt = ketnoi.sql_select("select d.masinhvien,sv.tensinhvien,d.diemthi,d.diemtb,d.diemtongket,d.hanhkiem,d.monhoc from diemsinhvien d,sinhvien sv where d.masinhvien=sv.masinhvien and d.monhoc='" + cb_monhoc.Text + "' and d.diemtongket<5");
                }

                if (dt.Rows.Count != 0)
                {
                    data_thongtinsinhvienthilai.DataSource = dt;
                    data_thongtinsinhvienthilai.Columns[0].HeaderText = "Mã sinh viên";
                    data_thongtinsinhvienthilai.Columns[1].HeaderText = "Tên sinh viên";
                    data_thongtinsinhvienthilai.Columns[2].HeaderText = "Điểm thi";
                    data_thongtinsinhvienthilai.Columns[3].HeaderText = "Điểm trung bình";

                    data_thongtinsinhvienthilai.Columns[4].HeaderText = "Điểm tổng kết";
                    data_thongtinsinhvienthilai.Columns[5].HeaderText = "Hạnh kiểm";
                    data_thongtinsinhvienthilai.Columns[6].HeaderText = "Mã môn học";
                }
                else
                {
                    reset_data();

                }
                reset();
                hoatdong();
            }
            catch (Exception)
            {
                reset();
                hoatdong();
                return;
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
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
