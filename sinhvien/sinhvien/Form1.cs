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
    public partial class fmain : Form
    {
        string tendangnhap = "";
        string quyen = "";
        bool dangnhap = false;
        TextBox f_c = new TextBox();
        public fmain()
        {
            InitializeComponent();
        }

        private void đăngXuấtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tendangnhap = "";
            quyen = "";
            dangnhap = false;
            đăngNhậpToolStripMenuItem.Text = "Đăng nhập";
            đăngNhậpToolStripMenuItem.Enabled = true;

            đăngXuấtToolStripMenuItem.Enabled = false;

            đổiMậtKhẩuToolStripMenuItem.Enabled = false;
            quảnLýNgườiDùngToolStripMenuItem.Visible = false;
            danhMụcToolStripMenuItem.Visible = false;
            quảnLíToolStripMenuItem.Visible = false;
            khoaToolStripMenuItem.Visible = false;
            giảngViênToolStripMenuItem.Visible = false;
            tìmKiếmToolStripMenuItem.Visible = false;
            thốngKệToolStripMenuItem.Visible = false;
            khoaToolStripMenuItem.Visible = false;
            giảngViênToolStripMenuItem.Visible = false;
        }

        private void fmain_Load(object sender, EventArgs e)
        {
            đăngXuấtToolStripMenuItem.Enabled = false;
            quảnLýNgườiDùngToolStripMenuItem.Visible = false;

            đổiMậtKhẩuToolStripMenuItem.Enabled = false;
            danhMụcToolStripMenuItem.Visible = false;
            quảnLíToolStripMenuItem.Visible = false;
            tìmKiếmToolStripMenuItem.Visible = false;
            thốngKệToolStripMenuItem.Visible = false;
            khoaToolStripMenuItem.Visible = false;
            giảngViênToolStripMenuItem.Visible = false;
            //
            f_c.ForeColor = Color.Black;
            FontFamily f = new FontFamily("Times New Roman");
            f_c.Font = new Font(f, 10);

            this.Location = new Point(0, 0);
            //

            this.Hide();
            fchaygiaodien gd = new fchaygiaodien();
            gd.ShowDialog();
            if(gd.ketthuc==true)
            {
                this.Show();
            }

            Color xanhla = Color.FromArgb(211, 234, 15);
            lab_khungtieude.BackColor = xanhla;
            label1.BackColor = xanhla;
            but_exit.BackColor = xanhla;
            but_anform.BackColor = xanhla;
            pic_icon.BackColor = xanhla;

        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult kq = MessageBox.Show("Bạn có chắc muốn tắt", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if(kq==DialogResult.Yes)
            {
                Application.Exit();
            }
            if(kq==DialogResult.No)
            {
                return;
            }
            
        }

        private void fontToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(fontDialog_hethong.ShowDialog()==DialogResult.OK)
            {
                f_c.Font = fontDialog_hethong.Font;
            }
        }

        private void colorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(colorDialog_hethong.ShowDialog()==DialogResult.OK)
            {
                f_c.ForeColor = colorDialog_hethong.Color;
            }
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            ftrogiup tg = new ftrogiup();
            tg.Location = new Point(0, 0);
            tg.ShowDialog();
            this.Show();
        }

        private void đổiMậtKhẩuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            fdoimatkhau mk = new fdoimatkhau();
            mk.f_c = f_c;
            mk.tendangnhap = tendangnhap;
            mk.Location = new Point(0, 0);
            mk.ShowDialog();
            if (mk.thaydoimatkhau == true)
            {
                MessageBox.Show("Bạn đã thay đổi mật khẩu thành công", "Thông báo");
                đăngXuấtToolStripMenuItem_Click(sender, e);
                
            }
            this.Show();
            
        }

        private void quảnLýNgườiDùngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            fquanlynguoidung nd = new fquanlynguoidung();
            nd.f_c = f_c;
            nd.Location = new Point(0, 0);
            nd.ShowDialog();
            this.Show();
        }

        private void mônHọcToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            fmonhoc mh = new fmonhoc();
            mh.f_c = f_c;
            mh.Location = new Point(0, 0);
            mh.ShowDialog();
            this.Show();
        }

        private void khoaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            fkhoa k = new fkhoa();
            k.f_c = f_c;
            k.Location = new Point(0, 0);
            k.ShowDialog();
            this.Show();
        }

        private void lớpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            flop l = new flop();
            l.f_c = f_c;
            l.Location = new Point(0, 0);
            l.ShowDialog();
            this.Show();
        }

        private void sinhViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            fquanlysinhvien sinhvien = new fquanlysinhvien();
            sinhvien.f_c = f_c;
            sinhvien.Location = new Point(0, 0);
            sinhvien.ShowDialog();
            this.Show();
        }

        private void giảngViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            fgiangvien gv = new fgiangvien();
            gv.f_c = f_c;
            gv.Location = new Point(0, 0);
            gv.ShowDialog();
            this.Show();
        }

        private void điểmMônHọcToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            fquanlydiemsv diem = new fquanlydiemsv();
            diem.f_c = f_c;
            diem.Location = new Point(0, 0);
            diem.ShowDialog();
            this.Show();
        }

        private void danhSáchSvToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            fdssv sv = new fdssv();
            sv.Location = new Point(0, 0);
            sv.ShowDialog();
            this.Show();
        }

        private void điểmTổngKếtSvToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            fdiemtongketsv sv = new fdiemtongketsv();
            sv.Location = new Point(0, 0);
            sv.ShowDialog();
            this.Show();
        }

        private void họcLạiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            fhoclai sv = new fhoclai();
            sv.f_c = f_c;
            sv.Location = new Point(0, 0);
            sv.ShowDialog();
            this.Show();
        }

        private void thốngKêSinhViênToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            ftimkiemsinhvien sv = new ftimkiemsinhvien();
            sv.f_c = f_c;
            sv.Location = new Point(0, 0);
            sv.ShowDialog();
            this.Show();
        }

        private void đăngNhậpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            fdangnhap dn = new fdangnhap();

            dn.f_c = f_c;
            dn.Location = new Point(0, 0);
            dn.ShowDialog();
            if (dn.dangnhap == true)
            {

                tendangnhap = dn.tendangnhap;
                quyen = dn.quyen;
                dangnhap = dn.dangnhap;
                đăngNhậpToolStripMenuItem.Text = tendangnhap;
                đăngNhậpToolStripMenuItem.Enabled = false;
                đăngXuấtToolStripMenuItem.Enabled = true;

                đổiMậtKhẩuToolStripMenuItem.Enabled = true;
                if (quyen == "admin     ")
                {
                    quảnLýNgườiDùngToolStripMenuItem.Visible = true;
                    khoaToolStripMenuItem.Visible = true;
                    giảngViênToolStripMenuItem.Visible = true;
                    khoaToolStripMenuItem.Visible = true;
                    giảngViênToolStripMenuItem.Visible = true;
                }

                danhMụcToolStripMenuItem.Visible = true;
                quảnLíToolStripMenuItem.Visible = true;
                tìmKiếmToolStripMenuItem.Visible = true;
                thốngKệToolStripMenuItem.Visible = true;
            }
            this.Show();
        }

        private void but_exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            try
            {
                openFileDialog1.ShowDialog();
                if (string.IsNullOrEmpty(openFileDialog1.FileName)) return;
                Image anh = Image.FromFile(openFileDialog1.FileName);
                pictureBox1.BackgroundImage = anh;
            }
            catch(Exception)
            {
                return;
            }
        }
        
        private void but_anform_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        int x, y;
        private void lab_khungtieude_MouseDown(object sender, MouseEventArgs e)
        {
            x = e.X;
            y = e.Y;
        }

        private void lab_khungtieude_MouseUp(object sender, MouseEventArgs e)
        {
            this.Location = new Point((e.X-x) + this.Location.X, (e.Y-y) + this.Location.Y);
        }


    }
}
