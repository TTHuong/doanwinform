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
    public partial class fdoimatkhau : Form
    {
        public string tendangnhap = "";
        cketnoi ketnoi = new cketnoi();
        public bool thaydoimatkhau = false;

        public TextBox f_c = new TextBox();
        public fdoimatkhau()
        {
            InitializeComponent();
        }
        
        void load_font_color()
        {
            txt_matkhaulan1.Font = txt_matkhaulan2.Font = txt_tendangnhap.Font = f_c.Font;
            txt_matkhaulan1.ForeColor = txt_matkhaulan2.ForeColor = txt_tendangnhap.ForeColor = f_c.ForeColor;

        }
        private void fdoimatkhau_Load(object sender, EventArgs e)
        {
            but_anmatkhau.Visible = false;
            but_hienmatkhau.Visible = true;
            txt_tendangnhap.Text = tendangnhap;

            load_font_color();

            Color c = Color.FromArgb(211, 234, 15);
            label1.BackColor= button2.BackColor = pictureBox1.BackColor = c;

            Color v=Color.FromArgb(220, 199, 110);
            but_luu.BackColor=but_thoat.BackColor=v;
        }

        private void but_thoat_Click(object sender, EventArgs e)
        {
       
                this.Close();
            
        }

        private void but_luu_Click(object sender, EventArgs e)
        {
            if(txt_matkhaulan1.Text !="")
            {
                if(txt_matkhaulan2.Text !="")
                {
                    if (txt_matkhaulan1.Text == txt_matkhaulan2.Text)
                    {
                      
                            ketnoi.sql_insert_delete_update("update dangnhap set matkhau='"+txt_matkhaulan1.Text+"' where tendangnhap='"+txt_tendangnhap.Text+"'");
                            thaydoimatkhau = true;
                            this.Close();
                    }
                    else
                    {
                            lab_thongbao.Visible = true;

                    }
                }
            }
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

        private void button2_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void but_anmatkhau_Click(object sender, EventArgs e)
        {
            

            //an mat khau
            txt_matkhaulan1.PasswordChar = '*';
            txt_matkhaulan2.PasswordChar = '*';
            but_anmatkhau.Visible = false;
            but_hienmatkhau.Visible = true;
            but_hienmatkhau.Location = new Point(524, 90);
            but_anmatkhau.Location = new Point(524, 138);
        }

        private void but_hienmatkhau_Click(object sender, EventArgs e)
        {
            //hien mat khau
            txt_matkhaulan1.PasswordChar = '\0';
            txt_matkhaulan2.PasswordChar = '\0';
            but_anmatkhau.Visible = true;
            but_hienmatkhau.Visible = false;
            but_hienmatkhau.Location = new Point(524, 138);
            but_anmatkhau.Location = new Point(524, 90);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }
    }
}
