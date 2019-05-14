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
    public partial class fquanlysinhvien : Form
    {
        cketnoi ketnoi = new cketnoi();
        public TextBox f_c = new TextBox();

        public fquanlysinhvien()
        {
            InitializeComponent();
        }
        void load_font_color()
        {
            txt_diachi.Font = txt_masinhvien.Font = txt_masinhvien_sua.Font = txt_masinhvien_timkiem.Font = txt_masinhvien_xoa.Font = txt_tensinhvien.Font=cb_malop.Font=cb_gioitinh.Font=date_ngaysinh.Font = f_c.Font;
            txt_diachi.ForeColor = txt_masinhvien.ForeColor = txt_masinhvien_sua.ForeColor = txt_masinhvien_timkiem.ForeColor = txt_masinhvien_xoa.ForeColor = txt_tensinhvien.ForeColor = cb_malop.ForeColor = cb_gioitinh.ForeColor = date_ngaysinh.CalendarForeColor = f_c.ForeColor;

        }
        void load_malop()
        {
            while(cb_malop.Items.Count!=0)
            {
                cb_malop.Items.RemoveAt(0);
            }
            DataTable dt = ketnoi.sql_select("select malop from lop group by malop");
            if(dt.Rows.Count!=0)
            {
                for(int i=0;i<dt.Rows.Count;i++)
                {
                    cb_malop.Items.Add(dt.Rows[i]["malop"].ToString());
                }
            }
        }
        int kiemtra(string ten)
        {
            DataTable dt = ketnoi.sql_select("select malop from lop group by malop");
            if (dt.Rows.Count != 0)
            {
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    if(ten==dt.Rows[i]["malop"].ToString())
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
        void reset()
        {
            txt_tensinhvien.Text =  txt_masinhvien.Text = txt_diachi.Text = cb_gioitinh.Text = cb_malop.Text = date_ngaysinh.Text = "";
        }

        private void fquanlysinhvien_Load(object sender, EventArgs e)
        {
            load_font_color();
            load_malop();

            Color v = Color.FromArgb(220, 199, 110);
            but_sua.BackColor = but_timkiem.BackColor = but_them.BackColor = but_xoa.BackColor = but_xuat.BackColor = v;
            Color c = Color.FromArgb(211, 234, 15);
            lab_tieude.BackColor = button1.BackColor = button2.BackColor = pictureBox1.BackColor = c;
        }

        private void but_them_Click(object sender, EventArgs e)
        {
            try
            {
                if (txt_diachi.Text != "")
                {
                    if ( txt_masinhvien.Text != "")
                    {
                        if(txt_tensinhvien.Text!="")
                        {
                            if(cb_gioitinh.Text=="Nam" || cb_gioitinh.Text=="Nu" || cb_gioitinh.Text=="Khong xac dinh")
                            {
                                if(cb_malop.Text!="")
                                {
                                    if(kiemtra(cb_malop.Text)==1)
                                    {
                                        if (date_ngaysinh.Text != "")
                                        {
                                            ketnoi.sql_insert_delete_update("insert into sinhvien values('" + txt_masinhvien.Text + "',N'" + txt_tensinhvien.Text + "','" + date_ngaysinh.Value.ToString("yyyy/MM/dd") + "','" + cb_gioitinh.Text + "',N'" + txt_diachi.Text + "','" + cb_malop.Text + "')");
                                            reset();
                                            load_malop();
                                            but_xuat_Click(sender, e);

                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }
            catch (Exception  ex)
            {
                MessageBox.Show(ex.ToString(), "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }

        private void but_xuat_Click(object sender, EventArgs e)
        {
            DataTable dt = ketnoi.sql_select("select * from sinhvien ");
            if (dt.Rows.Count != 0)
            {
                data_danhsachsinhvien.DataSource = dt;
                data_danhsachsinhvien.Columns[0].HeaderText = "Mã sinh viên";
                data_danhsachsinhvien.Columns[1].HeaderText = "Tên sinh viên";
                data_danhsachsinhvien.Columns[2].HeaderText = "Ngày sinh";
                data_danhsachsinhvien.Columns[3].HeaderText = "Giới tính";
                data_danhsachsinhvien.Columns[4].HeaderText = "Địa chỉ";
                data_danhsachsinhvien.Columns[5].HeaderText = "Mã lớp";

            }
            else
            {
                data_danhsachsinhvien.DataSource = null;
                data_danhsachsinhvien.Rows.Clear();
            }
        }

        private void data_danhsachsinhvien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int vitri = e.RowIndex;
                txt_diachi.Text = data_danhsachsinhvien.Rows[vitri].Cells["diachi"].Value.ToString();
                txt_masinhvien.Text = data_danhsachsinhvien.Rows[vitri].Cells["masinhvien"].Value.ToString();
                txt_tensinhvien.Text = data_danhsachsinhvien.Rows[vitri].Cells["tensinhvien"].Value.ToString();
                cb_malop.Text = data_danhsachsinhvien.Rows[vitri].Cells["malop"].Value.ToString();
                cb_gioitinh.Text = data_danhsachsinhvien.Rows[vitri].Cells["gioitinh"].Value.ToString();
                date_ngaysinh.Text = data_danhsachsinhvien.Rows[vitri].Cells["ngaysinh"].Value.ToString();
            }
            catch(Exception)
            {
                return;
            }

        }

        private void but_xoa_Click(object sender, EventArgs e)
        {
            if(txt_masinhvien_xoa.Text!="")
            {
                ketnoi.sql_insert_delete_update("delete sinhvien where masinhvien='" + txt_masinhvien_xoa.Text + "'");
                load_malop();
                but_xuat_Click(sender, e);
                
            }
            txt_masinhvien_xoa.Text = "Mã sinh viên";
        }

        private void but_sua_Click(object sender, EventArgs e)
        {
            try
            {
                if (txt_diachi.Text != "")
                {
                    if (txt_masinhvien.Text != "")
                    {
                        if (txt_tensinhvien.Text != "")
                        {
                            if (cb_gioitinh.Text == "Nam" || cb_gioitinh.Text == "Nu" || cb_gioitinh.Text == "Khong xac dinh")
                            {
                                if (cb_malop.Text != "")
                                {
                                    if (date_ngaysinh.Text != "")
                                    {
                                        if(txt_masinhvien_sua.Text!="")
                                        {
                                            if(kiemtra(cb_malop.Text)==1)
                                            {
                                                ketnoi.sql_insert_delete_update("update sinhvien set masinhvien='" + txt_masinhvien.Text + "',tensinhvien=N'" + txt_tensinhvien.Text + "',ngaysinh='" + date_ngaysinh.Value.ToString("yyyy/MM/dd") + "',gioitinh='" + cb_gioitinh.Text + "',diachi=N'" + txt_diachi.Text + "',malop='" + cb_malop.Text + "' where masinhvien='" + txt_masinhvien_sua.Text + "'");

                                                load_malop();
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
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                
            }
            txt_masinhvien_sua.Text = "Mã sinh viên";
        }

        private void but_timkiem_Click(object sender, EventArgs e)
        {
              if(txt_masinhvien_timkiem.Text!="")
                {
                    DataTable dt = ketnoi.sql_select("select * from sinhvien where masinhvien='" + txt_masinhvien_timkiem.Text + "'");
                    if(dt.Rows.Count!=0)
                    {
                        data_danhsachsinhvien.DataSource = dt;
                        data_danhsachsinhvien.Columns[0].HeaderText = "Mã sinh viên";
                        data_danhsachsinhvien.Columns[1].HeaderText = "Tên sinh viên";
                        data_danhsachsinhvien.Columns[2].HeaderText = "Ngày sinh";
                        data_danhsachsinhvien.Columns[3].HeaderText = "Giới tính";
                        data_danhsachsinhvien.Columns[4].HeaderText = "Địa chỉ";
                        data_danhsachsinhvien.Columns[5].HeaderText = "Mã lớp";

                        
                    }
                    else
                    {
                        MessageBox.Show("Mã sinh viên của bạn không tồn tại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                        data_danhsachsinhvien.DataSource = null;
                        data_danhsachsinhvien.Rows.Clear();
                    }
                }
              txt_masinhvien_timkiem.Text = "Mã sinh viên";
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
