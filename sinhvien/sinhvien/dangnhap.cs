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
    public partial class fdangnhap : Form
    {
        public string tendangnhap = "";
        public string quyen = "";
        public bool dangnhap = false;
        cketnoi ketnoi = new cketnoi();
        int dem = 0;
        public TextBox f_c = new TextBox();
        
        public fdangnhap()
        {
            InitializeComponent();
        }
        private void but_hienthimatkhau_Click(object sender, EventArgs e)
        {
            txt_matkhau.PasswordChar = '\0';
            but_anmatkhau.Visible = true;
            but_hienthimatkhau.Visible = false;
        }

        private void but_anmatkhau_Click(object sender, EventArgs e)
        {
            txt_matkhau.PasswordChar = '*';
            but_anmatkhau.Visible = false;
            but_hienthimatkhau.Visible = true;
        }

        private void but_dangnhap_Click(object sender, EventArgs e)
        {
            if(txt_tendangnhap.Text!="")
            {
                if(txt_matkhau.Text!="")
                {
                    if(dem<=3)
                    {
                        
                        DataTable dt = ketnoi.sql_select("select tendangnhap,quyen from dangnhap where tendangnhap='"+txt_tendangnhap.Text+"' and matkhau='"+txt_matkhau.Text+"'");
                        
                        if (dt.Rows.Count == 0)
                        {
                            MessageBox.Show("Bạn đã đăng nhập sai rồi", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                            dem ++;
                            return;
                        }
                        else
                        {
                            tendangnhap = dt.Rows[0]["tendangnhap"].ToString();
                            quyen = dt.Rows[0]["quyen"].ToString();
                            dangnhap = true;
                            this.Close();
                        }
                        
                    }
                    else if (dem>3)
                    {

                        MessageBox.Show("Bạn đã đăng nhập sai quá nhiều!!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                        txt_matkhau.Enabled = false;
                        txt_tendangnhap.Enabled = false;
                    }
                }
                
            }
            

        }

        private void but_thoat_Click(object sender, EventArgs e)
        {
                this.Close();
            
        }
        void load_font_color()
        {
            txt_matkhau.Font = txt_tendangnhap.Font = f_c.Font;
            txt_tendangnhap.ForeColor = txt_matkhau.ForeColor = f_c.ForeColor;
        }

        private void dangnhap_Load(object sender, EventArgs e)
        {
            but_hienthimatkhau.Visible = true;
            but_anmatkhau.Visible = false;
            
            load_font_color();

            this.txt_tendangnhap.Leave += txt_tendangnhap_Leave;
            this.txt_tendangnhap.Enter += txt_tendangnhap_Enter;
            this.txt_matkhau.Leave += txt_matkhau_Leave;
            this.txt_matkhau.Enter += txt_matkhau_Enter;

            Color c=Color.FromArgb(250, 190, 10);

            this.BackColor = c;
            but_anmatkhau.BackColor = c;
            but_hienthimatkhau.BackColor = c;

            Color x = Color.FromArgb(211, 234, 15);
            but_exit.BackColor = x;
            but_anform.BackColor = x;
            lab_tieude.BackColor = x;
            pictureBox1.BackColor = x;

            Color xanh_blue = Color.FromArgb(220, 199, 110);
            but_dangnhap.BackColor = xanh_blue;
            but_thoat.BackColor = xanh_blue;


        }

        void txt_matkhau_Enter(object sender, EventArgs e)
        {
           if(txt_matkhau.Text=="Vui lòng nhập mật khẩu" || txt_matkhau.Text=="Bạn chưa nhập mật khẩu")
           {
               txt_matkhau.PasswordChar = '*';
               txt_matkhau.Text = "";
           }
        }

        void txt_matkhau_Leave(object sender, EventArgs e)
        {
            if (txt_matkhau.Text == "")
            {
                txt_matkhau.Text = "Vui lòng nhập mật khẩu";
                txt_matkhau.PasswordChar = '\0';
              
            }
                
        }

        void txt_tendangnhap_Enter(object sender, EventArgs e)
        {
            if(txt_tendangnhap.Text=="Vui lòng nhập tên đăng nhập vào")
            {
                txt_tendangnhap.Text = "";
            }
        }

        void txt_tendangnhap_Leave(object sender, EventArgs e)
        {
            if(txt_tendangnhap.Text=="")
            {
                txt_tendangnhap.Text = "Vui lòng nhập tên đăng nhập vào";
            }
        }

        private void but_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void but_anform_Click(object sender, EventArgs e)
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
            this.Location = new Point(this.Location.X + (-x + e.X), this.Location.Y + (-y + e.Y));
        }

    }
}
