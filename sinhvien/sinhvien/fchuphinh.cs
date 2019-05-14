using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using AForge.Video;
using AForge.Video.DirectShow;

namespace sinhvien
{
    public partial class fchuphinh : Form
    {
        public fchuphinh()
        {
            InitializeComponent();
        }
        FilterInfoCollection camera;
        VideoCaptureDevice cam;
        public PictureBox anh = new PictureBox();
        private void fchuphinh_Load(object sender, EventArgs e)
        {
            try
            {
                camera = new FilterInfoCollection(FilterCategory.VideoInputDevice);
                foreach (FilterInfo i in camera)
                {
                    cb_camera.Items.Add(i.Name);
                }
                cb_camera.SelectedIndex = 0;

                Color c = Color.FromArgb(223, 239, 255);
                this.BackColor = c;
                pictureBox1.BackColor = c;
                but_anform.BackColor = c;
                but_exit.BackColor = c;
                label1.BackColor = c;
            }
            catch(Exception)
            {
                MessageBox.Show("Bạn không thiết bị máy ảnh nào hiện tại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                this.Close();
            }
        }

        private void but_start_Click(object sender, EventArgs e)
        {
            try
            {
                if (cb_camera.Text != "")
                {
                    if (cam != null && cam.IsRunning)
                        cam.Stop();
                    cam = new VideoCaptureDevice(camera[cb_camera.SelectedIndex].MonikerString);
                    cam.NewFrame += cam_NewFrame;
                    cam.Start();
                }
                else
                {
                    MessageBox.Show("Danh sách camera của bạn đang trống", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                }
            }
            catch(Exception)
            {
                MessageBox.Show("Bạn không thiết bị máy ảnh nào hiện tại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                this.Close();
            }
        }

        void cam_NewFrame(object sender, NewFrameEventArgs eventArgs)
        {
            Bitmap bm = (Bitmap)eventArgs.Frame.Clone();
            pc_camera.Image = bm;
        }

        private void But_stop_Click(object sender, EventArgs e)
        {
            try
            {
                if (cam != null && cam.IsRunning)
                    cam.Stop();
            }
            catch(Exception)
            {
                MessageBox.Show("Bạn không thiết bị máy ảnh nào hiện tại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                this.Close();
            }
        }

        private void but_takeaphoto_Click(object sender, EventArgs e)
        {
            pc_anhdachup.Image = pc_camera.Image;
        }

        private void but_dongy_Click(object sender, EventArgs e)
        {
            if(pc_anhdachup.Image==null)
            {
                MessageBox.Show("Bạn không có ảnh nào cả", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
            else
            {
                anh.Image = pc_anhdachup.Image;
                cam.Stop();
                this.Close();
            }
        }

        private void But_huy_Click(object sender, EventArgs e)
        {
            pc_anhdachup.Image = null;
        }

        private void fchuphinh_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                cam.Stop();
            }
            catch(Exception)
            {
                return;
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

        private void fchuphinh_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.Control==true && e.KeyCode==Keys.Y)
            {
                but_dongy_Click(sender, e as EventArgs);
            }
            if (e.Control == true && e.KeyCode == Keys.N)
            {
                But_huy_Click(sender, e as EventArgs);
            }
            if (e.Control == true && e.KeyCode == Keys.S)
            {
                But_stop_Click(sender, e as EventArgs);
            }
            if (e.Control == true && e.KeyCode == Keys.T)
            {
                but_takeaphoto_Click(sender, e as EventArgs);
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

    }
}
