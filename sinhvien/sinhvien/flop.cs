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
    public partial class flop : Form
    {
        cketnoi ketnoi = new cketnoi();
        public TextBox f_c = new TextBox();
        void load_font_color()
        {
            txt_malop.Font = txt_malop_sua.Font = txt_malop_timkiem.Font = txt_malop_xoa.Font = txt_tenlop.Font =cb_makhoa.Font = f_c.Font;
            txt_malop.ForeColor = txt_malop_sua.ForeColor = txt_malop_timkiem.ForeColor = txt_malop_xoa.ForeColor = txt_tenlop.ForeColor = cb_makhoa.ForeColor = f_c.ForeColor;
        }
        void reset()
        {
            txt_malop.Text = "";
            txt_tenlop.Text = "";
            cb_makhoa.Text = "";
        }
        void load_makhoa()
        {
            while(cb_makhoa.Items.Count!=0)
            {
                cb_makhoa.Items.RemoveAt(0);
            }
            
            DataTable dt = ketnoi.sql_select("select makhoa  from khoa group by makhoa ");
            if(dt.Rows.Count!=0)
            {
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    cb_makhoa.Items.Add(dt.Rows[i]["makhoa"].ToString());
                }
            }
        }
        int kiemtra(string ten)
        {
            DataTable dt = ketnoi.sql_select("select makhoa  from khoa group by makhoa ");
            if (dt.Rows.Count != 0)
            {
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    if(ten==dt.Rows[i]["makhoa"].ToString())
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
        public flop()
        {
            InitializeComponent();
        }

        private void flop_Load(object sender, EventArgs e)
        {
            load_font_color();
            load_makhoa();

            Color v = Color.FromArgb(220, 199, 110);
            but_sua.BackColor = but_timkiem.BackColor = but_them.BackColor = but_xoa.BackColor = but_xuat.BackColor = v;

            Color c = Color.FromArgb(211, 234, 15);
            lab_tieude.BackColor = pictureBox1.BackColor = button1.BackColor = button2.BackColor = c;
        }

        private void but_them_Click(object sender, EventArgs e)
        {
            try
            {
                if (txt_malop.Text != "")
                {
                    if (txt_tenlop.Text != "")
                    {
                        if (cb_makhoa.Text != "")
                        {
                            if(kiemtra(cb_makhoa.Text)==1)
                            {
                                ketnoi.sql_insert_delete_update("insert into lop values('" + txt_malop.Text + "',N'" + txt_tenlop.Text + "','" + cb_makhoa.Text + "') ");
                                reset();
                                load_makhoa();
                                but_xuat_Click(sender, e);
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
            DataTable dt = ketnoi.sql_select("select * from lop");
            if(dt.Rows.Count!=0)
            {
                data_danhsachlop.DataSource = dt;
                data_danhsachlop.Columns[0].HeaderText = "Mã lớp";
                data_danhsachlop.Columns[1].HeaderText = "Tên lớp";
                data_danhsachlop.Columns[2].HeaderText = "mã khoa";

            }
            else
            {
                data_danhsachlop.DataSource = null;
                data_danhsachlop.Rows.Clear();
            }
        }

        private void but_xoa_Click(object sender, EventArgs e)
        {
            if(txt_malop_xoa.Text!="")
            {
                DataTable dt = ketnoi.sql_select("select * from lop where malop='" + txt_malop_xoa.Text + "'");
                if(dt.Rows.Count!=0)
                {
                    ketnoi.sql_insert_delete_update("delete lop where malop ='" + txt_malop_xoa.Text + "'");
                    
                    but_xuat_Click(sender, e);
                    load_makhoa();
                }
                else
                {
                    MessageBox.Show("Mã lớp bạn muốn xóa không tồn tại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                 
                    data_danhsachlop.DataSource = null;
                    data_danhsachlop.Rows.Clear();
                }
            }
            txt_malop_xoa.Text = "Mã lớp";
        }

        private void but_sua_Click(object sender, EventArgs e)
        {
            try
            {
                if (txt_malop.Text != "")
                {
                    if (txt_tenlop.Text != "")
                    {
                        if (cb_makhoa.Text != "")
                        {
                            if(txt_malop_sua.Text!="")
                            {
                                if(kiemtra(cb_makhoa.Text)==1)
                                {
                                    ketnoi.sql_insert_delete_update("update lop set malop='" + txt_malop.Text + "',tenlop=N'" + txt_tenlop.Text + "',makhoa='" + cb_makhoa.Text + "' where malop ='" + txt_malop_sua.Text + "'");

                                    but_xuat_Click(sender, e);
                                    load_makhoa();
                                    reset();
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
            txt_malop_sua.Text = "Mã lớp";
        }

        private void but_timkiem_Click(object sender, EventArgs e)
        {
            if(txt_malop_timkiem.Text!="")
            {
                DataTable dt = ketnoi.sql_select("select * from lop where malop='" + txt_malop_timkiem.Text + "'");
                if (dt.Rows.Count != 0)
                {
                    data_danhsachlop.DataSource = dt;
                    data_danhsachlop.Columns[0].HeaderText = "Mã lớp";
                    data_danhsachlop.Columns[1].HeaderText = "Tên lớp";
                    data_danhsachlop.Columns[2].HeaderText = "mã khoa";

                    
                    
                }
                else
                {
                    MessageBox.Show("Mã lớp bạn muốn tìm không tồn tại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    data_danhsachlop.DataSource = null;
                    data_danhsachlop.Rows.Clear();
                }
            }
            txt_malop_timkiem.Text = "Mã lớp";
        }

        private void data_danhsachlop_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int vitri = e.RowIndex;
                txt_malop.Text = data_danhsachlop.Rows[vitri].Cells["malop"].Value.ToString();
                txt_tenlop.Text = data_danhsachlop.Rows[vitri].Cells["tenlop"].Value.ToString();
                cb_makhoa.Text = data_danhsachlop.Rows[vitri].Cells["makhoa"].Value.ToString();
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
