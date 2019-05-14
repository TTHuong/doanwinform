namespace sinhvien
{
    partial class fchuphinh
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fchuphinh));
            this.gb_anhdachup = new System.Windows.Forms.GroupBox();
            this.pc_anhdachup = new System.Windows.Forms.PictureBox();
            this.gb_camera = new System.Windows.Forms.GroupBox();
            this.pc_camera = new System.Windows.Forms.PictureBox();
            this.gb_chucnang = new System.Windows.Forms.GroupBox();
            this.cb_camera = new System.Windows.Forms.ComboBox();
            this.lab_danhsachcamera = new System.Windows.Forms.Label();
            this.but_takeaphoto = new System.Windows.Forms.Button();
            this.But_stop = new System.Windows.Forms.Button();
            this.but_start = new System.Windows.Forms.Button();
            this.gb_xacnhan = new System.Windows.Forms.GroupBox();
            this.lab_hoi = new System.Windows.Forms.Label();
            this.But_huy = new System.Windows.Forms.Button();
            this.but_dongy = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.but_exit = new System.Windows.Forms.Button();
            this.but_anform = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.gb_anhdachup.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pc_anhdachup)).BeginInit();
            this.gb_camera.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pc_camera)).BeginInit();
            this.gb_chucnang.SuspendLayout();
            this.gb_xacnhan.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // gb_anhdachup
            // 
            this.gb_anhdachup.Controls.Add(this.pc_anhdachup);
            this.gb_anhdachup.Location = new System.Drawing.Point(3, 68);
            this.gb_anhdachup.Name = "gb_anhdachup";
            this.gb_anhdachup.Size = new System.Drawing.Size(455, 358);
            this.gb_anhdachup.TabIndex = 0;
            this.gb_anhdachup.TabStop = false;
            this.gb_anhdachup.Text = "Ảnh Đã chụp";
            // 
            // pc_anhdachup
            // 
            this.pc_anhdachup.BackColor = System.Drawing.SystemColors.Control;
            this.pc_anhdachup.Location = new System.Drawing.Point(13, 20);
            this.pc_anhdachup.Name = "pc_anhdachup";
            this.pc_anhdachup.Size = new System.Drawing.Size(436, 332);
            this.pc_anhdachup.TabIndex = 0;
            this.pc_anhdachup.TabStop = false;
            // 
            // gb_camera
            // 
            this.gb_camera.Controls.Add(this.pc_camera);
            this.gb_camera.Location = new System.Drawing.Point(464, 68);
            this.gb_camera.Name = "gb_camera";
            this.gb_camera.Size = new System.Drawing.Size(444, 358);
            this.gb_camera.TabIndex = 0;
            this.gb_camera.TabStop = false;
            this.gb_camera.Text = "Camera";
            // 
            // pc_camera
            // 
            this.pc_camera.BackColor = System.Drawing.SystemColors.Control;
            this.pc_camera.Location = new System.Drawing.Point(8, 20);
            this.pc_camera.Name = "pc_camera";
            this.pc_camera.Size = new System.Drawing.Size(423, 332);
            this.pc_camera.TabIndex = 0;
            this.pc_camera.TabStop = false;
            // 
            // gb_chucnang
            // 
            this.gb_chucnang.Controls.Add(this.cb_camera);
            this.gb_chucnang.Controls.Add(this.lab_danhsachcamera);
            this.gb_chucnang.Controls.Add(this.but_takeaphoto);
            this.gb_chucnang.Controls.Add(this.But_stop);
            this.gb_chucnang.Controls.Add(this.but_start);
            this.gb_chucnang.Location = new System.Drawing.Point(3, 433);
            this.gb_chucnang.Name = "gb_chucnang";
            this.gb_chucnang.Size = new System.Drawing.Size(455, 103);
            this.gb_chucnang.TabIndex = 1;
            this.gb_chucnang.TabStop = false;
            this.gb_chucnang.Text = "Chức Năng";
            // 
            // cb_camera
            // 
            this.cb_camera.FormattingEnabled = true;
            this.cb_camera.Location = new System.Drawing.Point(172, 20);
            this.cb_camera.Name = "cb_camera";
            this.cb_camera.Size = new System.Drawing.Size(264, 21);
            this.cb_camera.TabIndex = 2;
            // 
            // lab_danhsachcamera
            // 
            this.lab_danhsachcamera.AutoSize = true;
            this.lab_danhsachcamera.Location = new System.Drawing.Point(23, 20);
            this.lab_danhsachcamera.Name = "lab_danhsachcamera";
            this.lab_danhsachcamera.Size = new System.Drawing.Size(135, 13);
            this.lab_danhsachcamera.TabIndex = 1;
            this.lab_danhsachcamera.Text = "Danh sách camera hiện có";
            // 
            // but_takeaphoto
            // 
            this.but_takeaphoto.Image = ((System.Drawing.Image)(resources.GetObject("but_takeaphoto.Image")));
            this.but_takeaphoto.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.but_takeaphoto.Location = new System.Drawing.Point(336, 48);
            this.but_takeaphoto.Name = "but_takeaphoto";
            this.but_takeaphoto.Size = new System.Drawing.Size(100, 36);
            this.but_takeaphoto.TabIndex = 0;
            this.but_takeaphoto.Text = "Chụp ảnh";
            this.but_takeaphoto.UseVisualStyleBackColor = true;
            this.but_takeaphoto.Click += new System.EventHandler(this.but_takeaphoto_Click);
            // 
            // But_stop
            // 
            this.But_stop.Image = ((System.Drawing.Image)(resources.GetObject("But_stop.Image")));
            this.But_stop.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.But_stop.Location = new System.Drawing.Point(172, 48);
            this.But_stop.Name = "But_stop";
            this.But_stop.Size = new System.Drawing.Size(95, 36);
            this.But_stop.TabIndex = 0;
            this.But_stop.Text = "Dừng lại";
            this.But_stop.UseVisualStyleBackColor = true;
            this.But_stop.Click += new System.EventHandler(this.But_stop_Click);
            // 
            // but_start
            // 
            this.but_start.Image = ((System.Drawing.Image)(resources.GetObject("but_start.Image")));
            this.but_start.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.but_start.Location = new System.Drawing.Point(23, 48);
            this.but_start.Name = "but_start";
            this.but_start.Size = new System.Drawing.Size(92, 36);
            this.but_start.TabIndex = 0;
            this.but_start.Text = "Bắt đầu";
            this.but_start.UseVisualStyleBackColor = true;
            this.but_start.Click += new System.EventHandler(this.but_start_Click);
            // 
            // gb_xacnhan
            // 
            this.gb_xacnhan.Controls.Add(this.lab_hoi);
            this.gb_xacnhan.Controls.Add(this.But_huy);
            this.gb_xacnhan.Controls.Add(this.but_dongy);
            this.gb_xacnhan.Location = new System.Drawing.Point(464, 433);
            this.gb_xacnhan.Name = "gb_xacnhan";
            this.gb_xacnhan.Size = new System.Drawing.Size(444, 103);
            this.gb_xacnhan.TabIndex = 1;
            this.gb_xacnhan.TabStop = false;
            this.gb_xacnhan.Text = "Xác Nhận";
            // 
            // lab_hoi
            // 
            this.lab_hoi.AutoSize = true;
            this.lab_hoi.Location = new System.Drawing.Point(6, 27);
            this.lab_hoi.Name = "lab_hoi";
            this.lab_hoi.Size = new System.Drawing.Size(207, 13);
            this.lab_hoi.TabIndex = 1;
            this.lab_hoi.Text = "Bạn có chắc là muốn lấy ảnh này không ?\r\n";
            // 
            // But_huy
            // 
            this.But_huy.Image = ((System.Drawing.Image)(resources.GetObject("But_huy.Image")));
            this.But_huy.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.But_huy.Location = new System.Drawing.Point(305, 48);
            this.But_huy.Name = "But_huy";
            this.But_huy.Size = new System.Drawing.Size(98, 36);
            this.But_huy.TabIndex = 0;
            this.But_huy.Text = "Hủy";
            this.But_huy.UseVisualStyleBackColor = true;
            this.But_huy.Click += new System.EventHandler(this.But_huy_Click);
            // 
            // but_dongy
            // 
            this.but_dongy.Image = ((System.Drawing.Image)(resources.GetObject("but_dongy.Image")));
            this.but_dongy.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.but_dongy.Location = new System.Drawing.Point(44, 48);
            this.but_dongy.Name = "but_dongy";
            this.but_dongy.Size = new System.Drawing.Size(101, 36);
            this.but_dongy.TabIndex = 0;
            this.but_dongy.Text = "Đồng ý";
            this.but_dongy.UseVisualStyleBackColor = true;
            this.but_dongy.Click += new System.EventHandler(this.but_dongy_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(89, 36);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // but_exit
            // 
            this.but_exit.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("but_exit.BackgroundImage")));
            this.but_exit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.but_exit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.but_exit.FlatAppearance.BorderSize = 0;
            this.but_exit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.but_exit.Location = new System.Drawing.Point(864, 0);
            this.but_exit.Name = "but_exit";
            this.but_exit.Size = new System.Drawing.Size(44, 36);
            this.but_exit.TabIndex = 3;
            this.but_exit.UseVisualStyleBackColor = true;
            this.but_exit.Click += new System.EventHandler(this.but_exit_Click);
            // 
            // but_anform
            // 
            this.but_anform.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.but_anform.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("but_anform.BackgroundImage")));
            this.but_anform.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.but_anform.FlatAppearance.BorderSize = 0;
            this.but_anform.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.but_anform.Location = new System.Drawing.Point(823, 0);
            this.but_anform.Name = "but_anform";
            this.but_anform.Size = new System.Drawing.Size(44, 36);
            this.but_anform.TabIndex = 3;
            this.but_anform.UseVisualStyleBackColor = false;
            this.but_anform.Click += new System.EventHandler(this.but_anform_Click);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(89, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(738, 36);
            this.label1.TabIndex = 4;
            this.label1.Text = "CHỤP HÌNH";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.label1_MouseDown);
            this.label1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.label1_MouseUp);
            // 
            // fchuphinh
            // 
            this.AcceptButton = this.but_start;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.CancelButton = this.but_exit;
            this.ClientSize = new System.Drawing.Size(912, 548);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.but_anform);
            this.Controls.Add(this.but_exit);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.gb_xacnhan);
            this.Controls.Add(this.gb_chucnang);
            this.Controls.Add(this.gb_camera);
            this.Controls.Add(this.gb_anhdachup);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Name = "fchuphinh";
            this.Text = "Chụp ảnh";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.fchuphinh_FormClosing);
            this.Load += new System.EventHandler(this.fchuphinh_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.fchuphinh_KeyDown);
            this.gb_anhdachup.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pc_anhdachup)).EndInit();
            this.gb_camera.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pc_camera)).EndInit();
            this.gb_chucnang.ResumeLayout(false);
            this.gb_chucnang.PerformLayout();
            this.gb_xacnhan.ResumeLayout(false);
            this.gb_xacnhan.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gb_anhdachup;
        private System.Windows.Forms.PictureBox pc_anhdachup;
        private System.Windows.Forms.GroupBox gb_camera;
        private System.Windows.Forms.PictureBox pc_camera;
        private System.Windows.Forms.GroupBox gb_chucnang;
        private System.Windows.Forms.Button but_takeaphoto;
        private System.Windows.Forms.Button But_stop;
        private System.Windows.Forms.Button but_start;
        private System.Windows.Forms.GroupBox gb_xacnhan;
        private System.Windows.Forms.Label lab_hoi;
        private System.Windows.Forms.Button But_huy;
        private System.Windows.Forms.Button but_dongy;
        private System.Windows.Forms.ComboBox cb_camera;
        private System.Windows.Forms.Label lab_danhsachcamera;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button but_exit;
        private System.Windows.Forms.Button but_anform;
        private System.Windows.Forms.Label label1;
    }
}