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
    public partial class fquanlynguoidung : Form
    {
        cketnoi ketnoi = new cketnoi();
        public TextBox f_c = new TextBox();
        public fquanlynguoidung()
        {
            InitializeComponent();
        }

        void reset()
        {
            txt_matkhau.Text = "";
            txt_tendangnhap.Text = "";
            cb_quyenhan.Text = "";
            loadquyenhan();
        }
        private void but_them_Click(object sender, EventArgs e)
        {
            try
            {
                if (txt_tendangnhap.Text != "")
                {
                    if (txt_matkhau.Text != "")
                    {
                        if (cb_quyenhan.Text != "")
                        {
                            ketnoi.sql_insert_delete_update("insert into dangnhap values ('" + txt_tendangnhap.Text + "','" + txt_matkhau.Text + "','" + cb_quyenhan.Text + "')");
                            reset();
                            but_xuất_Click(sender, e);
                        }
                    }
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }

        private void but_xoa_Click(object sender, EventArgs e)
        {
            if(txt_tendangnhap_xoa.Text!="")
            {
                ketnoi.sql_insert_delete_update("delete dangnhap where tendangnhap ='" + txt_tendangnhap_xoa.Text + "'");
                
                reset();
                but_xuất_Click(sender, e);
            }
            txt_tendangnhap_xoa.Text = "Tên đăng nhập";
        }

        private void but_sua_Click(object sender, EventArgs e)
        {
            try
            {
                if (txt_tendangnhap.Text != "")
                {
                    if (txt_matkhau.Text != "")
                    {
                        if (cb_quyenhan.Text != "")
                        {
                            if (txt_tendangnhap_xoa.Text != "")
                            {
                                ketnoi.sql_insert_delete_update("update dangnhap set tendangnhap='" + txt_tendangnhap.Text + "',matkhau='" + txt_matkhau.Text + "',quyen='" + cb_quyenhan.Text + "' where tendangnhap ='" + txt_tendangnhap_sua.Text + "'");
                                
                                reset();
                                but_xuất_Click(sender, e);
                            }
                        }
                    }
                }
            }

            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
            txt_tendangnhap_sua.Text = "Tên đăng nhập";
        }

        void loadquyenhan()
        {
            
            while(cb_quyenhan.Items.Count!=0)
            {
                cb_quyenhan.Items.RemoveAt(0);
            }
            DataTable dt = ketnoi.sql_select(" select quyen from dangnhap group by quyen");
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                cb_quyenhan.Items.Add(dt.Rows[i]["quyen"].ToString());

            }
        }
        void load_font_color()
        {
            txt_matkhau.Font = txt_tendangnhap.Font = txt_tendangnhap_sua.Font = txt_tendangnhap_timkiem.Font = txt_tendangnhap_xoa.Font=cb_quyenhan.Font = f_c.Font;
            txt_tendangnhap_xoa.ForeColor = txt_tendangnhap_timkiem.ForeColor = txt_tendangnhap_sua.ForeColor = txt_tendangnhap.ForeColor = cb_quyenhan.ForeColor = txt_matkhau.ForeColor = f_c.ForeColor;
        }
        private void fquanlynguoidung_Load(object sender, EventArgs e)
        {
            loadquyenhan();
            load_font_color();

            Color c = Color.FromArgb(211, 234, 15);
            button1.BackColor = button2.BackColor = label1.BackColor = pictureBox1.BackColor = c;
            Color v = Color.FromArgb(220, 199, 110);
            but_sua.BackColor = but_timkiem.BackColor = but_them.BackColor = but_xoa.BackColor = but_xuất.BackColor = v;
        }

        private void but_xuất_Click(object sender, EventArgs e)
        {
            DataTable dt = ketnoi.sql_select("select * from dangnhap");
            if(dt.Rows.Count==0)
            {
                data_quanlynguoidung.Rows.Clear();
                data_quanlynguoidung.DataSource = null;
                return;
            }
            else
            {
                data_quanlynguoidung.DataSource = dt;
                data_quanlynguoidung.Columns[0].HeaderText = "Tên đăng nhập";
                data_quanlynguoidung.Columns[1].HeaderText = "Mật khẩu";
                data_quanlynguoidung.Columns[2].HeaderText = "Quyền hạn";

            }
        }
        void timkiemquyenhan()
        {
           DataTable dt = ketnoi.sql_select("select * from dangnhap where quyen='" + txt_tendangnhap_timkiem.Text + "'");
            if (dt.Rows.Count != 0)
            {
                data_quanlynguoidung.DataSource = dt;
                data_quanlynguoidung.Columns[0].HeaderText = "Tên đăng nhập";
                data_quanlynguoidung.Columns[1].HeaderText = "Mật khẩu";
                data_quanlynguoidung.Columns[2].HeaderText = "Quyền hạn";
                
            }
            if (dt.Rows.Count == 0)
            {
               
                data_quanlynguoidung.DataSource = null;
                data_quanlynguoidung.Rows.Clear();
                return;
            }
            txt_tendangnhap_timkiem.Text = "Tên đăng nhập hoặc quyền hạn";
        }
        private void but_timkiem_Click(object sender, EventArgs e)
        {
            DataTable dt = ketnoi.sql_select("select * from dangnhap where tendangnhap='"+txt_tendangnhap_timkiem.Text+"' ");
            if (dt.Rows.Count != 0)
            {
                data_quanlynguoidung.DataSource = dt;
                data_quanlynguoidung.Columns[0].HeaderText = "Tên đăng nhập";
                data_quanlynguoidung.Columns[1].HeaderText = "Mật khẩu";
                data_quanlynguoidung.Columns[2].HeaderText = "Quyền hạn";
                
            }
            if(dt.Rows.Count==0)
            {
                timkiemquyenhan();
            }
            txt_tendangnhap_timkiem.Text = "Tên đăng nhập hoặc quyền hạn";
        }

        private void data_quanlynguoidung_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int vitri = e.RowIndex;
                txt_tendangnhap.Text = data_quanlynguoidung.Rows[vitri].Cells["tendangnhap"].Value.ToString();
                txt_matkhau.Text = data_quanlynguoidung.Rows[vitri].Cells["matkhau"].Value.ToString();
                cb_quyenhan.Text = data_quanlynguoidung.Rows[vitri].Cells["quyen"].Value.ToString();
            }
            catch(Exception)
            {
                return;
            }
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
