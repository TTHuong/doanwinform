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
    public partial class fquanlydiemsv : Form
    {
        public fquanlydiemsv()
        {
            InitializeComponent();
        }
        cketnoi ketnoi = new cketnoi();
        public TextBox f_c = new TextBox();
     
        void load_font_color()
        {
            txt_diemtb.Font = txt_diemtongket.Font = txt_diemthi.Font = txt_ghichu.Font  = txt_masinhvien.Font = txt_masinhvien_sua.Font = txt_masinhvien_timkiem.Font = txt_masinhvien_xoa.Font = cb_hanhkiem.Font =  cb_monhoc.Font = f_c.Font;
            txt_diemtb.ForeColor = txt_diemtongket.ForeColor = txt_diemthi.ForeColor = txt_ghichu.ForeColor =  txt_masinhvien.ForeColor = txt_masinhvien_sua.ForeColor = txt_masinhvien_timkiem.ForeColor = txt_masinhvien_xoa.ForeColor = cb_hanhkiem.ForeColor =  cb_monhoc.ForeColor = f_c.ForeColor;

        }
        
        void load_monhoc()
        {
            DataTable dt = ketnoi.sql_select("select mamonhoc from monhoc");
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
        int kiemtra(string ten)
        {
            DataTable dt = ketnoi.sql_select("select mamonhoc from monhoc where mamonhoc='"+ten+"'");
            if(dt.Rows.Count!=0)
            {
                
                return 1;
            }
            else
            {
                return 0;
            }
        }
        int kiemtra_masinhvien(string ten)
        {
            DataTable dt = ketnoi.sql_select("select masinhvien from sinhvien where masinhvien='"+ten+"' ");
            if(dt.Rows.Count!=0)
            {
                
                return 1;
            }
            else
            {
                return 0;
            }
        }
        private void fquanlydiemsv_Load(object sender, EventArgs e)
        {
            load_font_color();
            load_monhoc();

            Color v = Color.FromArgb(220, 199, 110);
            but_sua.BackColor = but_timkiem.BackColor = but_them.BackColor = but_xoa.BackColor = but_xuat.BackColor = v;

            Color c = Color.FromArgb(211, 234, 15);
            lab_tieude.BackColor = button1.BackColor =  pictureBox1.BackColor = c;
        }
        void reset()
        {
            txt_diemtb.Text = txt_diemtongket.Text = txt_diemthi.Text = txt_ghichu.Text =  txt_masinhvien.Text = cb_hanhkiem.Text =  cb_monhoc.Text = "";
        }
        private void data_diemsinhvien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int vitri = e.RowIndex;
                txt_diemtb.Text = data_diemsinhvien.Rows[vitri].Cells["diemtb"].Value.ToString();
                txt_diemtongket.Text = data_diemsinhvien.Rows[vitri].Cells["diemtongket"].Value.ToString();
                txt_diemthi.Text = data_diemsinhvien.Rows[vitri].Cells["diemthi"].Value.ToString();
                txt_ghichu.Text = data_diemsinhvien.Rows[vitri].Cells["ghichu"].Value.ToString();
                
                txt_masinhvien.Text = data_diemsinhvien.Rows[vitri].Cells["masinhvien"].Value.ToString();
                cb_hanhkiem.Text = data_diemsinhvien.Rows[vitri].Cells["hanhkiem"].Value.ToString();

                cb_monhoc.Text = data_diemsinhvien.Rows[vitri].Cells["monhoc"].Value.ToString();
            }
            catch(Exception)
            {
                return;
            }

        }

        private void but_them_Click(object sender, EventArgs e)
        {
            int thunghiem = 0;
            try
            {
                if (txt_diemtb.Text != "" && Int32.TryParse(txt_diemtb.Text, out thunghiem) == true)
                {
                    if (Convert.ToInt32(txt_diemtb.Text) >= 0 && Convert.ToInt32(txt_diemtb.Text) <= 10)
                    {
                        if (txt_diemtongket.Text != "" && Int32.TryParse(txt_diemtongket.Text, out thunghiem) == true)
                        {
                            if (Convert.ToInt32(txt_diemtongket.Text) >= 0 && Convert.ToInt32(txt_diemtongket.Text) <= 10)
                            {
                                if (txt_diemthi.Text != "" && Int32.TryParse(txt_diemthi.Text, out thunghiem) == true)
                                {
                                    if (Convert.ToInt32(txt_diemthi.Text) >= 0 && Convert.ToInt32(txt_diemthi.Text) <= 10)
                                    {
                                        if ( cb_monhoc.Text != "")
                                        {
                                            if ( kiemtra(cb_monhoc.Text) == 1)
                                            {
                                                if (txt_masinhvien.Text != "")
                                                {
                                                    if (kiemtra_masinhvien(txt_masinhvien.Text) == 1)
                                                    {
                                                        if (cb_hanhkiem.Text == "Tốt" || cb_hanhkiem.Text == "Khá" || cb_hanhkiem.Text == "TB" || cb_hanhkiem.Text == "Yếu" || cb_hanhkiem.Text == "Kém")
                                                        {
                                                            ketnoi.sql_insert_delete_update("insert into diemsinhvien values('" + txt_masinhvien.Text + "','" + Convert.ToInt32(txt_diemtb.Text) + "','" + Convert.ToInt32(txt_diemthi.Text) + "','" + Convert.ToInt32(txt_diemtongket.Text) + "',N'" + cb_hanhkiem.Text + "','" + cb_monhoc.Text + "',N'" + txt_ghichu.Text + "')");
                                                            reset();

                                                            load_monhoc();
                                                            but_xuat_Click(sender, e);
                                                        }
                                                    }
                                                    else
                                                    {
                                                        MessageBox.Show("Mã sinh viên này không tồn tại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Stop);

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
                kiemtra_masinhvien(txt_masinhvien.Text);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }

        private void but_xuat_Click(object sender, EventArgs e)
        {
            DataTable dt = ketnoi.sql_select("select * from diemsinhvien");
            if(dt.Rows.Count!=0)
            {
                data_diemsinhvien.DataSource = dt;
                data_diemsinhvien.Columns[0].HeaderText = "Mã sinh viên";
                data_diemsinhvien.Columns[1].HeaderText = "Điểm TB";
                data_diemsinhvien.Columns[2].HeaderText = "Điểm thi";
                data_diemsinhvien.Columns[3].HeaderText = "Điểm tổng kết";
                data_diemsinhvien.Columns[4].HeaderText = "Hạnh kiêm";
                data_diemsinhvien.Columns[5].HeaderText = "Môn học";
                data_diemsinhvien.Columns[6].HeaderText = "Ghi chú";
            }
            else
            {
                data_diemsinhvien.DataSource = null;
                data_diemsinhvien.Rows.Clear();
            }
        }

        private void but_xoa_Click(object sender, EventArgs e)
        {
            if(txt_masinhvien_xoa.Text!="")
            {
                ketnoi.sql_insert_delete_update("delete diemsinhvien where masinhvien='" + txt_masinhvien_xoa.Text + "'");
                load_monhoc();
                but_xuat_Click(sender, e);
            }
            txt_masinhvien_xoa.Text = "Mã sinh viên";
        }

        private void but_timkiem_Click(object sender, EventArgs e)
        {
            if(txt_masinhvien_timkiem.Text!="")
            {
                DataTable dt = ketnoi.sql_select("select * from diemsinhvien where masinhvien='"+txt_masinhvien_timkiem.Text+"'");
                if (dt.Rows.Count != 0)
                {
                    data_diemsinhvien.DataSource = dt;
                    data_diemsinhvien.Columns[0].HeaderText = "Mã sinh viên";
                    data_diemsinhvien.Columns[1].HeaderText = "Điểm TB";
                    data_diemsinhvien.Columns[2].HeaderText = "Điểm thi";
                    data_diemsinhvien.Columns[3].HeaderText = "Điểm tổng kết";
                    data_diemsinhvien.Columns[4].HeaderText = "Hạnh kiêm";
                    data_diemsinhvien.Columns[5].HeaderText = "Môn học";
                    data_diemsinhvien.Columns[6].HeaderText = "Ghi chú";
                }
                else
                {
                    data_diemsinhvien.DataSource = null;
                    data_diemsinhvien.Rows.Clear();
                }
                txt_masinhvien_timkiem.Text = "Mã sinh viên";
            }
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

        private void but_sua_Click(object sender, EventArgs e)
        {
            int thunghiem = 0;
            try
            {
                if (txt_diemtb.Text != "" && Int32.TryParse(txt_diemtb.Text, out thunghiem) == true)
                {
                    if (Convert.ToInt32(txt_diemtb.Text) >= 0 && Convert.ToInt32(txt_diemtb.Text) <= 10)
                    {
                        if (txt_diemtongket.Text != "" && Int32.TryParse(txt_diemtongket.Text, out thunghiem) == true)
                        {
                            if (Convert.ToInt32(txt_diemtongket.Text) >= 0 && Convert.ToInt32(txt_diemtongket.Text) <= 10)
                            {
                                if (txt_diemthi.Text != "" && Int32.TryParse(txt_diemthi.Text, out thunghiem) == true)
                                {
                                    if (Convert.ToInt32(txt_diemthi.Text) >= 0 && Convert.ToInt32(txt_diemthi.Text) <= 10)
                                    {
                                        if (txt_masinhvien.Text != "")
                                        {
                                            if (cb_hanhkiem.Text != "")
                                            {
                                                if (cb_monhoc.Text != "")
                                                {
                                                    if (txt_masinhvien_sua.Text != "")
                                                    {
                                                        if (kiemtra(cb_monhoc.Text) == 1)
                                                        {
                                                            if (kiemtra_masinhvien(txt_masinhvien_sua.Text) == 1)
                                                            {
                                                                ketnoi.sql_insert_delete_update("update  diemsinhvien set masinhvien='" + txt_masinhvien.Text + "',diemtb='" + Convert.ToInt32(txt_diemtb.Text) + "',diemthi='" + Convert.ToInt32(txt_diemthi.Text) + "',diemtongket='" + Convert.ToInt32(txt_diemtongket.Text) + "',hanhkiem=N'" + cb_hanhkiem.Text + "',monhoc='" + cb_monhoc.Text + "',ghichu=N'" + txt_ghichu.Text + "' where masinhvien='" + txt_masinhvien_sua.Text + "'");
                                                                reset();

                                                                load_monhoc();
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
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
            txt_masinhvien_sua.Text = "Mã sinh viên";
        }
    }
}
