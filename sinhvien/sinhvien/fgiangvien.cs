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
using System.IO;

namespace sinhvien
{
    public partial class fgiangvien : Form
    {
        cketnoi ketnoi = new cketnoi();
        public TextBox f_c = new TextBox();

        void load_font_color()
        {
            txt_email.Font = txt_magiangvien.Font = txt_magiangvien_sua.Font = txt_magiangvien_timkiem.Font = txt_magiangvien_xoa.Font = txt_sdt.Font = txt_tengiangvien.Font = date_ngaysinh.Font = cb_gioitinh.Font = f_c.Font;
            txt_email.ForeColor = txt_magiangvien.ForeColor = txt_magiangvien_sua.ForeColor = txt_magiangvien_timkiem.ForeColor = txt_magiangvien_xoa.ForeColor = txt_sdt.ForeColor = txt_tengiangvien.ForeColor = date_ngaysinh.ForeColor = cb_gioitinh.ForeColor = f_c.ForeColor;

        }
        void reset()
        {
            txt_email.Text = txt_magiangvien.Text = txt_sdt.Text = txt_tengiangvien.Text = date_ngaysinh.Text = cb_gioitinh.Text =cb_danhsachanh.Text= "";

            pic_anhdaidien.Image = new Bitmap(Application.StartupPath + "\\Resources\\andanh.jpg");

        }
        public fgiangvien()
        {
            InitializeComponent();
        }

        private void fgiangvien_Load(object sender, EventArgs e)
        {
            load_font_color();

            Color c = Color.FromArgb(211, 234, 15);
            button1.BackColor = button2.BackColor = lab_tieude.BackColor = pictureBox1.BackColor = c;

            Color v = Color.FromArgb(220, 199, 110);
            but_chupanh.BackColor = but_suagiangvien.BackColor = but_timkiem.BackColor = but_themgiangvien.BackColor = but_xoa.BackColor = but_xuat.BackColor = v;

        }
        void sql_insert_image(string magiangvien)
        {
            
            MydbcontextDataContext mydb = new MydbcontextDataContext();
            anhdaidien_giangvien anh = new anhdaidien_giangvien();
            MemoryStream stream = new MemoryStream();
            pic_anhdaidien.Image.Save(stream, System.Drawing.Imaging.ImageFormat.Jpeg);
            anh.magiangvien = magiangvien;
            anh.anhdaidien = stream.ToArray();
            mydb.anhdaidien_giangviens.InsertOnSubmit(anh);
            mydb.SubmitChanges();
        }
        void sql_load_image(string magiangvien)
        {
            
            MydbcontextDataContext mydb = new MydbcontextDataContext();
            anhdaidien_giangvien anh = mydb.anhdaidien_giangviens.Where(em => em.magiangvien == magiangvien).FirstOrDefault();
            if (anh == null) return;
            MemoryStream stream = new MemoryStream(anh.anhdaidien.ToArray());
            Image ima = Image.FromStream(stream);
            if (ima == null) return;
            pic_anhdaidien.Image = ima;

        }
        private void data_danhsachgiangvien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int vitri = e.RowIndex;
            try
            {
                txt_email.Text = data_danhsachgiangvien.Rows[vitri].Cells["email"].Value.ToString();
                txt_magiangvien.Text = data_danhsachgiangvien.Rows[vitri].Cells["magiangvien"].Value.ToString();
                txt_sdt.Text = data_danhsachgiangvien.Rows[vitri].Cells["sdt"].Value.ToString();
                txt_tengiangvien.Text = data_danhsachgiangvien.Rows[vitri].Cells["tengiangvien"].Value.ToString();
                cb_gioitinh.Text = data_danhsachgiangvien.Rows[vitri].Cells["gioitinh"].Value.ToString();
                date_ngaysinh.Text = data_danhsachgiangvien.Rows[vitri].Cells["ngaysinh"].Value.ToString();

                string magiangvien = data_danhsachgiangvien.Rows[vitri].Cells["magiangvien"].Value.ToString();
                sql_load_image(magiangvien);
            }
            catch(Exception)
            {
                return;
            }
           
        }

        private void but_themgiangvien_Click(object sender, EventArgs e)
        {
            int thunghiem = 0;
            try
            {
                if (txt_email.Text != "")
                {
                    if (txt_magiangvien.Text != "")
                    {
                        if (txt_sdt.Text != "" && Int32.TryParse(txt_sdt.Text,out thunghiem)==true)
                        {
                            if (txt_tengiangvien.Text != "")
                            {
                                if (cb_gioitinh.Text != "")
                                {
                                    if (date_ngaysinh.Text != "")
                                    {

                                        ketnoi.sql_insert_delete_update("insert into giangvien values ('" + txt_magiangvien.Text + "',N'" + txt_tengiangvien.Text + "','" + date_ngaysinh.Value.ToString("yyyy/MM/dd") + "','" + cb_gioitinh.Text + "','" + txt_sdt.Text + "','" + txt_email.Text + "')");
                                        sql_insert_image(txt_magiangvien.Text);
                                        reset();
                                        but_xuat_Click(sender, e);
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
            DataTable dt = ketnoi.sql_select("select * from giangvien ");
            if(dt.Rows.Count!=0)
            {
                data_danhsachgiangvien.DataSource = dt;
                data_danhsachgiangvien.Columns[0].HeaderText = "Mã giảng viên";
                data_danhsachgiangvien.Columns[1].HeaderText = "Tên giảng viên";
                data_danhsachgiangvien.Columns[2].HeaderText = "Ngày sinh";
                data_danhsachgiangvien.Columns[3].HeaderText = "Giới tính";
                data_danhsachgiangvien.Columns[4].HeaderText = "Số điện thoại";
                data_danhsachgiangvien.Columns[5].HeaderText = "Email";

            }
            else
            {
                data_danhsachgiangvien.DataSource = null;
                data_danhsachgiangvien.Rows.Clear();
            }
        }

        private void pic_anhdaidien_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                openFile_anh.ShowDialog();
                string file = openFile_anh.FileName;
                if (string.IsNullOrEmpty(file)) return;
                Image myimage = Image.FromFile(file);
                pic_anhdaidien.Image = myimage;
            }
            catch(Exception)
            {
                return;
            }
            
        }

        private void cb_danhsachan_TextChanged(object sender, EventArgs e)
        {
            if(cb_danhsachanh.Text=="(None)")
            {
                pic_anhdaidien.Image = new Bitmap(Application.StartupPath + "\\Resources\\andanh.jpg");
            }
            if(cb_danhsachanh.Text=="Tý")
            {
                pic_anhdaidien.Image = new Bitmap(Application.StartupPath + "\\Resources\\ty.png");
            }
            if (cb_danhsachanh.Text == "Sửu")
            {
                pic_anhdaidien.Image = new Bitmap(Application.StartupPath + "\\Resources\\suu.png");
            }
            if (cb_danhsachanh.Text == "Dần")
            {
                pic_anhdaidien.Image = new Bitmap(Application.StartupPath + "\\Resources\\dan.png");
            }
            if (cb_danhsachanh.Text == "Mẹo")
            {
                pic_anhdaidien.Image = new Bitmap(Application.StartupPath + "\\Resources\\mao.png");
            }
            if (cb_danhsachanh.Text == "Thìn")
            {
                pic_anhdaidien.Image = new Bitmap(Application.StartupPath + "\\Resources\\thin.png");
            }
            if (cb_danhsachanh.Text == "Tị")
            {
                pic_anhdaidien.Image = new Bitmap(Application.StartupPath + "\\Resources\\ti.png");
            }
            if (cb_danhsachanh.Text == "Ngọ")
            {
                pic_anhdaidien.Image = new Bitmap(Application.StartupPath + "\\Resources\\ngo.png");
            }
            if (cb_danhsachanh.Text == "Mùi")
            {
                pic_anhdaidien.Image = new Bitmap(Application.StartupPath + "\\Resources\\mui.png");
            }
            if (cb_danhsachanh.Text == "Thân")
            {
                pic_anhdaidien.Image = new Bitmap(Application.StartupPath + "\\Resources\\than.png");
            }
            if (cb_danhsachanh.Text == "Dậu")
            {
                pic_anhdaidien.Image = new Bitmap(Application.StartupPath + "\\Resources\\dau.png");
            }
            if (cb_danhsachanh.Text == "Tuất")
            {
                pic_anhdaidien.Image = new Bitmap(Application.StartupPath + "\\Resources\\tuat.png");
            }
            if (cb_danhsachanh.Text == "Hợi")
            {
                pic_anhdaidien.Image = new Bitmap(Application.StartupPath + "\\Resources\\hoi.png");
            }
        }

        private void but_suagiangvien_Click(object sender, EventArgs e)
        {
            try
            {
                if (txt_email.Text != "")
                {
                    if (txt_magiangvien.Text != "")
                    {
                        if (txt_sdt.Text != "")
                        {
                            if (txt_tengiangvien.Text != "")
                            {
                                if (cb_gioitinh.Text != "")
                                {
                                    if (date_ngaysinh.Text != "")
                                    {

                                        if (txt_magiangvien_sua.Text != "")
                                        {
                                            ketnoi.sql_insert_delete_update("update giangvien set magiangvien= '" + txt_magiangvien.Text + "',tengiangvien=N'" + txt_tengiangvien.Text + "',ngaysinh='" + date_ngaysinh.Value.ToString("yyyy/MM/dd") + "',gioitinh='" + cb_gioitinh.Text + "',sdt='" + txt_sdt.Text + "',email='" + txt_email.Text + "' where magiangvien='" + txt_magiangvien_sua.Text + "' ");

                                            //update anh vao sql
                                            ketnoi.sql_insert_delete_update("delete anhdaidien_giangvien where magiangvien='" + txt_magiangvien_sua.Text + "' ");

                                            sql_insert_image(txt_magiangvien.Text);
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

            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                
            }
            txt_magiangvien_sua.Text = "Mã giảng viên";
        }

        private void but_xoa_Click(object sender, EventArgs e)
        {
            if(txt_magiangvien_xoa.Text!="")
            {
                ketnoi.sql_insert_delete_update("delete giangvien where magiangvien='" + txt_magiangvien_xoa.Text + "'");
                ketnoi.sql_insert_delete_update("delete anhdaidien_giangvien where magiangvien='" + txt_magiangvien_xoa.Text + "'");
                
                but_xuat_Click(sender, e);
            }
            txt_magiangvien_xoa.Text = "Mã giảng viên";
        }

        private void but_timkiem_Click(object sender, EventArgs e)
        {
            DataTable dt = ketnoi.sql_select("select * from giangvien where magiangvien='" + txt_magiangvien_timkiem.Text + "'");
            if(dt.Rows.Count!=0)
            {
                data_danhsachgiangvien.DataSource = dt;
                data_danhsachgiangvien.Columns[0].HeaderText = "Mã giảng viên";
                data_danhsachgiangvien.Columns[1].HeaderText = "Tên giảng viên";
                data_danhsachgiangvien.Columns[2].HeaderText = "Ngày sinh";
                data_danhsachgiangvien.Columns[3].HeaderText = "Giới tính";
                data_danhsachgiangvien.Columns[4].HeaderText = "Số điện thoại";
                data_danhsachgiangvien.Columns[5].HeaderText = "Email";
                txt_magiangvien_timkiem.Text = "Mã giảng viên";
            }
            else
            {
                txt_magiangvien_timkiem.Text = "Mã giảng viên";
                data_danhsachgiangvien.DataSource = null;
                data_danhsachgiangvien.Rows.Clear();
            }
        }

        private void but_chupanh_Click(object sender, EventArgs e)
        {
            fchuphinh chupanh = new fchuphinh();
            this.Hide();
            chupanh.ShowDialog();
            if(chupanh.anh.Image!=null)
            {
                pic_anhdaidien.Image = chupanh.anh.Image;
            }
            this.Show();
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
