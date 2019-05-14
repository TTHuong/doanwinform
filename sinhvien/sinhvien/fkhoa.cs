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
    public partial class fkhoa : Form
    {
        cketnoi ketnoi = new cketnoi();
        public TextBox f_c=new TextBox();
        public fkhoa()
        {
            InitializeComponent();
        }

        void reset()
        {
            txt_tenkhoa.Text = "";
            txt_makhoa.Text = "";
        }
        void load_font_color()
        {
            txt_makhoa.Font = txt_makhoa_sua.Font = txt_makhoa_timkiem.Font = txt_makhoa_xoa.Font = txt_tenkhoa.Font = f_c.Font;
            txt_makhoa.ForeColor = txt_makhoa_sua.ForeColor = txt_makhoa_timkiem.ForeColor = txt_makhoa_xoa.ForeColor = txt_tenkhoa.ForeColor = f_c.ForeColor;
        }
        private void but_them_Click(object sender, EventArgs e)
        {
            try
            {
                if (txt_makhoa.Text != "")
                {
                    if (txt_tenkhoa.Text != "")
                    {
                        ketnoi.sql_insert_delete_update("insert into khoa values ('"+txt_makhoa.Text+"',N'"+txt_tenkhoa.Text+"' ) ");
                        reset();
                        but_xuat_Click(sender, e);
                    }
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }

        private void fkhoa_Load(object sender, EventArgs e)
        {
            load_font_color();

            Color c = Color.FromArgb(211, 234, 15);
            button1.BackColor = button2.BackColor = lab_tieude.BackColor = pictureBox1.BackColor = c;

            Color v = Color.FromArgb(220, 199, 110);
            but_sua.BackColor = but_timkiem.BackColor = but_them.BackColor = but_xoa.BackColor = but_xuat.BackColor = v;
        }

        private void but_xuat_Click(object sender, EventArgs e)
        {
            DataTable dt = ketnoi.sql_select("select * from khoa ");
            if(dt.Rows.Count!=0)
            {
                data_danhsachkhoa.DataSource = dt;
                data_danhsachkhoa.Columns[0].HeaderText = "Mã Khoa";
                data_danhsachkhoa.Columns[1].HeaderText = "Tên khoa";

            }
            else
            {
                data_danhsachkhoa.DataSource = null;
                data_danhsachkhoa.Rows.Clear();
            }
        }

        private void but_xoa_Click(object sender, EventArgs e)
        {
            if(txt_makhoa_xoa.Text!="")
            {
                DataTable dt = ketnoi.sql_select("select * from khoa where makhoa ='" + txt_makhoa_xoa .Text+ "'");
                if(dt.Rows.Count==0)
                {
                    MessageBox.Show("Khoa bạn muốn xóa không tồn tại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    
                }
                else
                {
                    ketnoi.sql_insert_delete_update("delete  khoa where makhoa='" + txt_makhoa_xoa.Text + "'");
                    but_xuat_Click(sender, e);

                }
            }
            txt_makhoa_xoa.Text = "Mã khoa";
        }

        private void but_sua_Click(object sender, EventArgs e)
        {
            
            try
            {
                if (txt_tenkhoa.Text != "")
                {
                    if (txt_makhoa.Text != "")
                    {
                        if (txt_makhoa_sua.Text != "")
                        {
                            DataTable dt = ketnoi.sql_select("select * from khoa where makhoa ='" + txt_makhoa_sua.Text + "'");
                            if (dt.Rows.Count == 0)
                            {
                                MessageBox.Show("Khoa bạn muốn sửa không tồn tại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                                data_danhsachkhoa.DataSource = null;
                                data_danhsachkhoa.Rows.Clear();
                            }
                            else
                            {
                                ketnoi.sql_insert_delete_update("update  khoa set makhoa='" + txt_makhoa.Text + "',tenkhoa=N'" + txt_tenkhoa.Text + "'  where makhoa='" + txt_makhoa_sua.Text + "'");

                                but_xuat_Click(sender, e);
                                reset();
                                
                            }
                        }
                    }
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Stop);


            }
            txt_makhoa_sua.Text = "Mã khoa";
        }

        private void but_timkiem_Click(object sender, EventArgs e)
        {
            if(txt_makhoa_timkiem.Text!="")
            {
                DataTable dt=ketnoi.sql_select("select * from khoa where makhoa='"+txt_makhoa_timkiem.Text+"'");
                if(dt.Rows.Count==0)
                {
                    MessageBox.Show("Khoa bạn muốn tìm không tồn tại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    txt_makhoa_timkiem.Text = "Mã khoa";
                    data_danhsachkhoa.DataSource = null;
                    data_danhsachkhoa.Rows.Clear();
                }
                else
                {
                    data_danhsachkhoa.DataSource = dt;
                    data_danhsachkhoa.Columns[0].HeaderText = "Mã khoa";
                    data_danhsachkhoa.Columns[1].HeaderText = "Tên khoa";
                    txt_makhoa_timkiem.Text = "Mã khoa";

                }
            }
        }

        private void data_danhsachkhoa_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int vitri = e.RowIndex;
                txt_makhoa.Text = data_danhsachkhoa.Rows[vitri].Cells["makhoa"].Value.ToString();
                txt_tenkhoa.Text = data_danhsachkhoa.Rows[vitri].Cells["tenkhoa"].Value.ToString();
            }
            catch(Exception)
            {
                return;
            }
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
