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
    public partial class fmonhoc : Form
    {
        cketnoi ketnoi = new cketnoi();
        public TextBox f_c = new TextBox();
        public fmonhoc()
        {
            InitializeComponent();
        }
        void reset()
        {
            txt_hocky.Text = "";
            cb_magiangvien.Text = "";
            cb_makhoa.Text = "";
            txt_mamonhoc.Text = "";
            
            txt_sotiet.Text = "";
            txt_sotinchi.Text = "";
            txt_tenmonhoc.Text = "";
           
        }
        void load_makhoa()
        {
            DataTable dt = ketnoi.sql_select("select makhoa from khoa");
            while(cb_makhoa.Items.Count!=0)
            {
                cb_makhoa.Items.RemoveAt(0);
            }
            if(dt.Rows.Count!=0)
            {
                for(int i=0;i<dt.Rows.Count;i++)
                {
                    cb_makhoa.Items.Add(dt.Rows[i]["makhoa"].ToString());
                }
            }
        }
        void load_magiangvien()
        {
            DataTable dt = ketnoi.sql_select("select magiangvien from giangvien");
            while (cb_magiangvien.Items.Count != 0)
            {
                cb_magiangvien.Items.RemoveAt(0);
            }
            if (dt.Rows.Count != 0)
            {
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    cb_magiangvien.Items.Add(dt.Rows[i]["magiangvien"].ToString());
                }
            }

            Color c = Color.FromArgb(211, 234, 15);
            lab_tieude.BackColor = pictureBox1.BackColor = button1.BackColor = button2.BackColor = c;

            Color v = Color.FromArgb(220, 199, 110);
            but_sua.BackColor = but_timkiem.BackColor = but_them.BackColor = but_xoa.BackColor = but_xuat.BackColor = v;
        }
        int kiemtra(string ten)
        {
            DataTable dt = ketnoi.sql_select("select makhoa from khoa");
            if(dt.Rows.Count!=0)
            {
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    if (ten == dt.Rows[i]["makhoa"].ToString())
                    {
                        return 1;
                    }
                }
                return 0;
            }
            else
            {
                return 0;
            }
            
        }
        int kiemtra_magiangvien(string ten)
        {
            DataTable dt = ketnoi.sql_select("select magiangvien from giangvien");
            if (dt.Rows.Count != 0)
            {
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    if (ten == dt.Rows[i]["magiangvien"].ToString())
                    {
                        return 1;
                    }
                }
                return 0;
            }
            else
            {
                return 0;
            }
        }
        private void but_them_Click(object sender, EventArgs e)
        {
            int test = 0;
            try
            {
                if (txt_mamonhoc.Text != "")
                {
                    if (txt_tenmonhoc.Text != "")
                    {
                        if (txt_sotinchi.Text != "" && Int32.TryParse(txt_sotinchi.Text,out test)==true)
                        {
                            if (txt_sotiet.Text != ""&& Int32.TryParse(txt_sotiet.Text,out test)==true)
                            {
                                if (cb_magiangvien.Text != "")
                                {
                                    if(kiemtra_magiangvien(cb_magiangvien.Text)==1)
                                    {
                                        if (txt_hocky.Text != "" && Int32.TryParse(txt_hocky.Text, out test) == true)
                                        {
                                            if (Convert.ToInt32(txt_hocky.Text) <= 3 && Convert.ToInt32(txt_hocky.Text) >= 1)
                                            {
                                                if (cb_makhoa.Text != "")
                                                {
                                                    if (kiemtra(cb_makhoa.Text) == 1)
                                                    {
                                                        ketnoi.sql_insert_delete_update("insert into monhoc values ('" + txt_mamonhoc.Text + "',N'" + txt_tenmonhoc.Text + "','" + Convert.ToInt32(txt_sotinchi.Text) + "','" + Convert.ToInt32(txt_sotiet.Text) + "' ,'" + cb_magiangvien.Text + "','" + Convert.ToInt32(txt_hocky.Text) + "' ,'" + cb_makhoa.Text + "')");
                                                        reset();
                                                        but_xuat_Click(sender, e);
                                                    }
                                                }
                                            }

                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }
            catch(Exception ex)
            {
                
                MessageBox.Show(ex.ToString(), "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }

        private void but_xuat_Click(object sender, EventArgs e)
        {
            DataTable dt = ketnoi.sql_select("select * from monhoc");
            if(dt.Rows.Count!=0)
            {
                data_monhoc.DataSource = dt;
                data_monhoc.Columns[0].HeaderText = "Mã môn học";
                data_monhoc.Columns[1].HeaderText = "Tên môn học";
                data_monhoc.Columns[2].HeaderText = "Số tín chỉ";
                data_monhoc.Columns[3].HeaderText = "Số tiết";
                data_monhoc.Columns[4].HeaderText = "Mã giảng viên";
                data_monhoc.Columns[5].HeaderText = "Học kỳ";
                data_monhoc.Columns[6].HeaderText = "Mã khoa";
            }
            else
            {
                data_monhoc.DataSource = null;
                data_monhoc.Rows.Clear();
            }
        }

        private void but_xoa_Click(object sender, EventArgs e)
        {
            if(txt_mamonhoc_xoa.Text!="")
            {
                ketnoi.sql_insert_delete_update("delete monhoc where mamonhoc='" + txt_mamonhoc_xoa.Text + "'");
                but_xuat_Click(sender, e);
                
            }
            txt_mamonhoc_xoa.Text = "Mã môn học";
        }

        private void but_sua_Click(object sender, EventArgs e)
        {
            int test = 0;
            try
            {
                if (txt_mamonhoc.Text != "")
                {
                    if (txt_tenmonhoc.Text != "")
                    {
                        if (txt_sotinchi.Text != "" && Int32.TryParse(txt_sotinchi.Text, out test) == true)
                        {
                            if (txt_sotiet.Text != "" && Int32.TryParse(txt_sotiet.Text, out test) == true)
                            {
                                if (cb_magiangvien.Text != "")
                                {
                                    if(kiemtra_magiangvien(cb_magiangvien.Text)==1)
                                    {
                                        if (txt_hocky.Text!="")
                                        {
                                            if (Convert.ToInt32(txt_hocky.Text) <= 3 && Convert.ToInt32(txt_hocky.Text) >= 1)
                                            {
                                                if (cb_makhoa.Text != "")
                                                {
                                                    if (txt_mamonhoc_sua.Text != "")
                                                    {
                                                        if (kiemtra(cb_makhoa.Text) == 1)
                                                        {
                                                            ketnoi.sql_insert_delete_update("update monhoc set mamonhoc='" + txt_mamonhoc.Text + "',tenmonhoc=N'" + txt_tenmonhoc.Text + "',sotinchi='" + Convert.ToInt32(txt_sotinchi.Text) + "',sotiet='" + Convert.ToInt32(txt_sotiet.Text) + "',magiangvien='" + cb_magiangvien.Text + "',hocky='" + txt_hocky.Text + "',makhoa='" + cb_makhoa.Text + "' where mamonhoc='" + txt_mamonhoc_sua.Text + "'");
                                                            but_xuat_Click(sender, e);
                                                            reset();
                                                        }
                                                    }
                                                }
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
            txt_mamonhoc_sua.Text = "Mã môn học";
        }
        
        private void but_timkiem_Click(object sender, EventArgs e)
        {
            DataTable dt = ketnoi.sql_select("select * from monhoc where mamonhoc='"+txt_mamonhoc_timkiem.Text+"'");
            txt_mamonhoc_timkiem.Text = "Mã môn học";
            if (dt.Rows.Count != 0)
            {
                data_monhoc.DataSource = dt;
                data_monhoc.Columns[0].HeaderText = "Mã môn học";
                data_monhoc.Columns[1].HeaderText = "Tên môn học";
                data_monhoc.Columns[2].HeaderText = "Số tín chỉ";
                data_monhoc.Columns[3].HeaderText = "Số tiết";
                data_monhoc.Columns[4].HeaderText = "Mã giảng viên";
                data_monhoc.Columns[5].HeaderText = "Học kỳ";
                data_monhoc.Columns[6].HeaderText = "Mã khoa";
                

            }
            else
            {
                data_monhoc.DataSource = null;
                data_monhoc.Rows.Clear();
            }
            
        }

        private void data_monhoc_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int vitri = e.RowIndex;
                txt_hocky.Text = data_monhoc.Rows[vitri].Cells["hocky"].Value.ToString();
                cb_magiangvien.Text = data_monhoc.Rows[vitri].Cells["magiangvien"].Value.ToString();
                cb_makhoa.Text = data_monhoc.Rows[vitri].Cells["makhoa"].Value.ToString();
                txt_mamonhoc.Text = data_monhoc.Rows[vitri].Cells["mamonhoc"].Value.ToString();
                txt_sotiet.Text = data_monhoc.Rows[vitri].Cells["sotiet"].Value.ToString();
                txt_sotinchi.Text = data_monhoc.Rows[vitri].Cells["sotinchi"].Value.ToString();
                txt_tenmonhoc.Text = data_monhoc.Rows[vitri].Cells["tenmonhoc"].Value.ToString();
            }catch(Exception)
            {
                return;
            }

        }

        void load_font_color()
        {
            txt_hocky.Font = cb_magiangvien.Font = cb_makhoa.Font = txt_mamonhoc.Font = txt_mamonhoc_sua.Font = txt_mamonhoc_timkiem.Font = txt_mamonhoc_xoa.Font = txt_sotiet.Font = txt_sotinchi.Font = txt_tenmonhoc.Font = f_c.Font;
            txt_hocky.ForeColor = cb_magiangvien.ForeColor = cb_makhoa.ForeColor = txt_mamonhoc.ForeColor = txt_mamonhoc_sua.ForeColor = txt_mamonhoc_timkiem.ForeColor = txt_mamonhoc_xoa.ForeColor = txt_sotiet.ForeColor = txt_sotinchi.ForeColor = txt_tenmonhoc.ForeColor = f_c.ForeColor;
        }
        
        private void fmonhoc_Load_1(object sender, EventArgs e)
        {
            load_font_color();
            load_magiangvien();
            load_makhoa();
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
