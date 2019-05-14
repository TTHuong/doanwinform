namespace sinhvien
{
    partial class fgiangvien
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fgiangvien));
            this.gb_thongtinchitiet = new System.Windows.Forms.GroupBox();
            this.but_chupanh = new System.Windows.Forms.Button();
            this.cb_danhsachanh = new System.Windows.Forms.ComboBox();
            this.date_ngaysinh = new System.Windows.Forms.DateTimePicker();
            this.but_timkiem = new System.Windows.Forms.Button();
            this.but_xoa = new System.Windows.Forms.Button();
            this.but_suagiangvien = new System.Windows.Forms.Button();
            this.but_xuat = new System.Windows.Forms.Button();
            this.but_themgiangvien = new System.Windows.Forms.Button();
            this.pic_anhdaidien = new System.Windows.Forms.PictureBox();
            this.cb_gioitinh = new System.Windows.Forms.ComboBox();
            this.txt_email = new System.Windows.Forms.TextBox();
            this.txt_sdt = new System.Windows.Forms.TextBox();
            this.txt_tengiangvien = new System.Windows.Forms.TextBox();
            this.txt_magiangvien_timkiem = new System.Windows.Forms.TextBox();
            this.txt_magiangvien_xoa = new System.Windows.Forms.TextBox();
            this.txt_magiangvien_sua = new System.Windows.Forms.TextBox();
            this.txt_magiangvien = new System.Windows.Forms.TextBox();
            this.lab_email = new System.Windows.Forms.Label();
            this.lab_ngaysinh = new System.Windows.Forms.Label();
            this.lab_anhdaidien = new System.Windows.Forms.Label();
            this.lab_gioitinh = new System.Windows.Forms.Label();
            this.lab_sdt = new System.Windows.Forms.Label();
            this.lab_tengiangvien = new System.Windows.Forms.Label();
            this.lab_maginagvien = new System.Windows.Forms.Label();
            this.lab_tieude = new System.Windows.Forms.Label();
            this.gb_danhsachgiangvien = new System.Windows.Forms.GroupBox();
            this.data_danhsachgiangvien = new System.Windows.Forms.DataGridView();
            this.openFile_anh = new System.Windows.Forms.OpenFileDialog();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.gb_thongtinchitiet.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_anhdaidien)).BeginInit();
            this.gb_danhsachgiangvien.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.data_danhsachgiangvien)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // gb_thongtinchitiet
            // 
            this.gb_thongtinchitiet.Controls.Add(this.but_chupanh);
            this.gb_thongtinchitiet.Controls.Add(this.cb_danhsachanh);
            this.gb_thongtinchitiet.Controls.Add(this.date_ngaysinh);
            this.gb_thongtinchitiet.Controls.Add(this.but_timkiem);
            this.gb_thongtinchitiet.Controls.Add(this.but_xoa);
            this.gb_thongtinchitiet.Controls.Add(this.but_suagiangvien);
            this.gb_thongtinchitiet.Controls.Add(this.but_xuat);
            this.gb_thongtinchitiet.Controls.Add(this.but_themgiangvien);
            this.gb_thongtinchitiet.Controls.Add(this.pic_anhdaidien);
            this.gb_thongtinchitiet.Controls.Add(this.cb_gioitinh);
            this.gb_thongtinchitiet.Controls.Add(this.txt_email);
            this.gb_thongtinchitiet.Controls.Add(this.txt_sdt);
            this.gb_thongtinchitiet.Controls.Add(this.txt_tengiangvien);
            this.gb_thongtinchitiet.Controls.Add(this.txt_magiangvien_timkiem);
            this.gb_thongtinchitiet.Controls.Add(this.txt_magiangvien_xoa);
            this.gb_thongtinchitiet.Controls.Add(this.txt_magiangvien_sua);
            this.gb_thongtinchitiet.Controls.Add(this.txt_magiangvien);
            this.gb_thongtinchitiet.Controls.Add(this.lab_email);
            this.gb_thongtinchitiet.Controls.Add(this.lab_ngaysinh);
            this.gb_thongtinchitiet.Controls.Add(this.lab_anhdaidien);
            this.gb_thongtinchitiet.Controls.Add(this.lab_gioitinh);
            this.gb_thongtinchitiet.Controls.Add(this.lab_sdt);
            this.gb_thongtinchitiet.Controls.Add(this.lab_tengiangvien);
            this.gb_thongtinchitiet.Controls.Add(this.lab_maginagvien);
            this.gb_thongtinchitiet.Location = new System.Drawing.Point(1, 61);
            this.gb_thongtinchitiet.Name = "gb_thongtinchitiet";
            this.gb_thongtinchitiet.Size = new System.Drawing.Size(302, 612);
            this.gb_thongtinchitiet.TabIndex = 0;
            this.gb_thongtinchitiet.TabStop = false;
            this.gb_thongtinchitiet.Text = "Thông tin chi tiết";
            // 
            // but_chupanh
            // 
            this.but_chupanh.Image = ((System.Drawing.Image)(resources.GetObject("but_chupanh.Image")));
            this.but_chupanh.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.but_chupanh.Location = new System.Drawing.Point(3, 361);
            this.but_chupanh.Name = "but_chupanh";
            this.but_chupanh.Size = new System.Drawing.Size(84, 29);
            this.but_chupanh.TabIndex = 7;
            this.but_chupanh.Text = "Chụp ảnh";
            this.but_chupanh.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.but_chupanh.UseVisualStyleBackColor = true;
            this.but_chupanh.Click += new System.EventHandler(this.but_chupanh_Click);
            // 
            // cb_danhsachanh
            // 
            this.cb_danhsachanh.FormattingEnabled = true;
            this.cb_danhsachanh.Items.AddRange(new object[] {
            "(None)",
            "Tý",
            "Sửu",
            "Dần",
            "Mẹo",
            "Thìn",
            "Tị",
            "Ngọ",
            "Mùi",
            "Thân",
            "Dậu",
            "Tuất",
            "Hợi"});
            this.cb_danhsachanh.Location = new System.Drawing.Point(3, 331);
            this.cb_danhsachanh.Name = "cb_danhsachanh";
            this.cb_danhsachanh.Size = new System.Drawing.Size(84, 23);
            this.cb_danhsachanh.TabIndex = 6;
            this.cb_danhsachanh.TextChanged += new System.EventHandler(this.cb_danhsachan_TextChanged);
            // 
            // date_ngaysinh
            // 
            this.date_ngaysinh.Location = new System.Drawing.Point(129, 117);
            this.date_ngaysinh.Name = "date_ngaysinh";
            this.date_ngaysinh.Size = new System.Drawing.Size(165, 22);
            this.date_ngaysinh.TabIndex = 5;
            // 
            // but_timkiem
            // 
            this.but_timkiem.Image = ((System.Drawing.Image)(resources.GetObject("but_timkiem.Image")));
            this.but_timkiem.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.but_timkiem.Location = new System.Drawing.Point(0, 575);
            this.but_timkiem.Name = "but_timkiem";
            this.but_timkiem.Size = new System.Drawing.Size(87, 27);
            this.but_timkiem.TabIndex = 4;
            this.but_timkiem.Text = "Tìm kiếm";
            this.but_timkiem.UseVisualStyleBackColor = true;
            this.but_timkiem.Click += new System.EventHandler(this.but_timkiem_Click);
            // 
            // but_xoa
            // 
            this.but_xoa.Image = ((System.Drawing.Image)(resources.GetObject("but_xoa.Image")));
            this.but_xoa.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.but_xoa.Location = new System.Drawing.Point(0, 527);
            this.but_xoa.Name = "but_xoa";
            this.but_xoa.Size = new System.Drawing.Size(87, 27);
            this.but_xoa.TabIndex = 4;
            this.but_xoa.Text = "Xóa";
            this.but_xoa.UseVisualStyleBackColor = true;
            this.but_xoa.Click += new System.EventHandler(this.but_xoa_Click);
            // 
            // but_suagiangvien
            // 
            this.but_suagiangvien.Image = ((System.Drawing.Image)(resources.GetObject("but_suagiangvien.Image")));
            this.but_suagiangvien.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.but_suagiangvien.Location = new System.Drawing.Point(0, 480);
            this.but_suagiangvien.Name = "but_suagiangvien";
            this.but_suagiangvien.Size = new System.Drawing.Size(87, 27);
            this.but_suagiangvien.TabIndex = 4;
            this.but_suagiangvien.Text = "Sửa";
            this.but_suagiangvien.UseVisualStyleBackColor = true;
            this.but_suagiangvien.Click += new System.EventHandler(this.but_suagiangvien_Click);
            // 
            // but_xuat
            // 
            this.but_xuat.Image = ((System.Drawing.Image)(resources.GetObject("but_xuat.Image")));
            this.but_xuat.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.but_xuat.Location = new System.Drawing.Point(207, 438);
            this.but_xuat.Name = "but_xuat";
            this.but_xuat.Size = new System.Drawing.Size(87, 27);
            this.but_xuat.TabIndex = 4;
            this.but_xuat.Text = "Xuất";
            this.but_xuat.UseVisualStyleBackColor = true;
            this.but_xuat.Click += new System.EventHandler(this.but_xuat_Click);
            // 
            // but_themgiangvien
            // 
            this.but_themgiangvien.Image = ((System.Drawing.Image)(resources.GetObject("but_themgiangvien.Image")));
            this.but_themgiangvien.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.but_themgiangvien.Location = new System.Drawing.Point(0, 438);
            this.but_themgiangvien.Name = "but_themgiangvien";
            this.but_themgiangvien.Size = new System.Drawing.Size(87, 27);
            this.but_themgiangvien.TabIndex = 4;
            this.but_themgiangvien.Text = "Thêm";
            this.but_themgiangvien.UseVisualStyleBackColor = true;
            this.but_themgiangvien.Click += new System.EventHandler(this.but_themgiangvien_Click);
            // 
            // pic_anhdaidien
            // 
            this.pic_anhdaidien.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pic_anhdaidien.Image = ((System.Drawing.Image)(resources.GetObject("pic_anhdaidien.Image")));
            this.pic_anhdaidien.Location = new System.Drawing.Point(129, 312);
            this.pic_anhdaidien.Name = "pic_anhdaidien";
            this.pic_anhdaidien.Size = new System.Drawing.Size(166, 119);
            this.pic_anhdaidien.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic_anhdaidien.TabIndex = 3;
            this.pic_anhdaidien.TabStop = false;
            this.pic_anhdaidien.DoubleClick += new System.EventHandler(this.pic_anhdaidien_DoubleClick);
            // 
            // cb_gioitinh
            // 
            this.cb_gioitinh.FormattingEnabled = true;
            this.cb_gioitinh.Items.AddRange(new object[] {
            "Nam",
            "Nu"});
            this.cb_gioitinh.Location = new System.Drawing.Point(129, 165);
            this.cb_gioitinh.Name = "cb_gioitinh";
            this.cb_gioitinh.Size = new System.Drawing.Size(165, 23);
            this.cb_gioitinh.TabIndex = 2;
            // 
            // txt_email
            // 
            this.txt_email.Location = new System.Drawing.Point(129, 260);
            this.txt_email.Multiline = true;
            this.txt_email.Name = "txt_email";
            this.txt_email.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txt_email.Size = new System.Drawing.Size(165, 22);
            this.txt_email.TabIndex = 1;
            // 
            // txt_sdt
            // 
            this.txt_sdt.Location = new System.Drawing.Point(129, 213);
            this.txt_sdt.Multiline = true;
            this.txt_sdt.Name = "txt_sdt";
            this.txt_sdt.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txt_sdt.Size = new System.Drawing.Size(165, 22);
            this.txt_sdt.TabIndex = 1;
            // 
            // txt_tengiangvien
            // 
            this.txt_tengiangvien.Location = new System.Drawing.Point(129, 70);
            this.txt_tengiangvien.Multiline = true;
            this.txt_tengiangvien.Name = "txt_tengiangvien";
            this.txt_tengiangvien.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txt_tengiangvien.Size = new System.Drawing.Size(165, 22);
            this.txt_tengiangvien.TabIndex = 1;
            // 
            // txt_magiangvien_timkiem
            // 
            this.txt_magiangvien_timkiem.Location = new System.Drawing.Point(129, 575);
            this.txt_magiangvien_timkiem.Multiline = true;
            this.txt_magiangvien_timkiem.Name = "txt_magiangvien_timkiem";
            this.txt_magiangvien_timkiem.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txt_magiangvien_timkiem.Size = new System.Drawing.Size(165, 22);
            this.txt_magiangvien_timkiem.TabIndex = 1;
            this.txt_magiangvien_timkiem.Text = "Mã giảng viên";
            // 
            // txt_magiangvien_xoa
            // 
            this.txt_magiangvien_xoa.Location = new System.Drawing.Point(129, 527);
            this.txt_magiangvien_xoa.Multiline = true;
            this.txt_magiangvien_xoa.Name = "txt_magiangvien_xoa";
            this.txt_magiangvien_xoa.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txt_magiangvien_xoa.Size = new System.Drawing.Size(165, 22);
            this.txt_magiangvien_xoa.TabIndex = 1;
            this.txt_magiangvien_xoa.Text = "Mã giảng viên";
            // 
            // txt_magiangvien_sua
            // 
            this.txt_magiangvien_sua.Location = new System.Drawing.Point(129, 480);
            this.txt_magiangvien_sua.Multiline = true;
            this.txt_magiangvien_sua.Name = "txt_magiangvien_sua";
            this.txt_magiangvien_sua.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txt_magiangvien_sua.Size = new System.Drawing.Size(165, 22);
            this.txt_magiangvien_sua.TabIndex = 1;
            this.txt_magiangvien_sua.Text = "Mã giảng viên";
            // 
            // txt_magiangvien
            // 
            this.txt_magiangvien.Location = new System.Drawing.Point(129, 23);
            this.txt_magiangvien.Multiline = true;
            this.txt_magiangvien.Name = "txt_magiangvien";
            this.txt_magiangvien.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txt_magiangvien.Size = new System.Drawing.Size(165, 22);
            this.txt_magiangvien.TabIndex = 0;
            // 
            // lab_email
            // 
            this.lab_email.AutoSize = true;
            this.lab_email.Location = new System.Drawing.Point(0, 258);
            this.lab_email.Name = "lab_email";
            this.lab_email.Size = new System.Drawing.Size(38, 15);
            this.lab_email.TabIndex = 0;
            this.lab_email.Text = "Email";
            // 
            // lab_ngaysinh
            // 
            this.lab_ngaysinh.AutoSize = true;
            this.lab_ngaysinh.Location = new System.Drawing.Point(0, 117);
            this.lab_ngaysinh.Name = "lab_ngaysinh";
            this.lab_ngaysinh.Size = new System.Drawing.Size(62, 15);
            this.lab_ngaysinh.TabIndex = 0;
            this.lab_ngaysinh.Text = "Ngày sinh";
            // 
            // lab_anhdaidien
            // 
            this.lab_anhdaidien.AutoSize = true;
            this.lab_anhdaidien.Location = new System.Drawing.Point(0, 312);
            this.lab_anhdaidien.Name = "lab_anhdaidien";
            this.lab_anhdaidien.Size = new System.Drawing.Size(75, 15);
            this.lab_anhdaidien.TabIndex = 0;
            this.lab_anhdaidien.Text = "Ảnh đại diện";
            // 
            // lab_gioitinh
            // 
            this.lab_gioitinh.AutoSize = true;
            this.lab_gioitinh.Location = new System.Drawing.Point(0, 164);
            this.lab_gioitinh.Name = "lab_gioitinh";
            this.lab_gioitinh.Size = new System.Drawing.Size(56, 15);
            this.lab_gioitinh.TabIndex = 0;
            this.lab_gioitinh.Text = "Giới tính";
            // 
            // lab_sdt
            // 
            this.lab_sdt.AutoSize = true;
            this.lab_sdt.Location = new System.Drawing.Point(0, 211);
            this.lab_sdt.Name = "lab_sdt";
            this.lab_sdt.Size = new System.Drawing.Size(77, 15);
            this.lab_sdt.TabIndex = 0;
            this.lab_sdt.Text = "Số điện thoại";
            // 
            // lab_tengiangvien
            // 
            this.lab_tengiangvien.AutoSize = true;
            this.lab_tengiangvien.Location = new System.Drawing.Point(0, 70);
            this.lab_tengiangvien.Name = "lab_tengiangvien";
            this.lab_tengiangvien.Size = new System.Drawing.Size(87, 15);
            this.lab_tengiangvien.TabIndex = 0;
            this.lab_tengiangvien.Text = "Tên giảng viên";
            // 
            // lab_maginagvien
            // 
            this.lab_maginagvien.AutoSize = true;
            this.lab_maginagvien.Location = new System.Drawing.Point(0, 23);
            this.lab_maginagvien.Name = "lab_maginagvien";
            this.lab_maginagvien.Size = new System.Drawing.Size(83, 15);
            this.lab_maginagvien.TabIndex = 0;
            this.lab_maginagvien.Text = "Mã giảng viên";
            // 
            // lab_tieude
            // 
            this.lab_tieude.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lab_tieude.ForeColor = System.Drawing.Color.Black;
            this.lab_tieude.Location = new System.Drawing.Point(85, 0);
            this.lab_tieude.Name = "lab_tieude";
            this.lab_tieude.Size = new System.Drawing.Size(913, 41);
            this.lab_tieude.TabIndex = 1;
            this.lab_tieude.Text = "QUẢN LÝ GIẢNG VIÊN";
            this.lab_tieude.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lab_tieude.MouseDown += new System.Windows.Forms.MouseEventHandler(this.lab_tieude_MouseDown);
            this.lab_tieude.MouseUp += new System.Windows.Forms.MouseEventHandler(this.lab_tieude_MouseUp);
            // 
            // gb_danhsachgiangvien
            // 
            this.gb_danhsachgiangvien.Controls.Add(this.data_danhsachgiangvien);
            this.gb_danhsachgiangvien.Location = new System.Drawing.Point(310, 61);
            this.gb_danhsachgiangvien.Name = "gb_danhsachgiangvien";
            this.gb_danhsachgiangvien.Size = new System.Drawing.Size(688, 612);
            this.gb_danhsachgiangvien.TabIndex = 0;
            this.gb_danhsachgiangvien.TabStop = false;
            this.gb_danhsachgiangvien.Text = "Danh sách giảng viên";
            // 
            // data_danhsachgiangvien
            // 
            this.data_danhsachgiangvien.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.data_danhsachgiangvien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.data_danhsachgiangvien.Location = new System.Drawing.Point(8, 23);
            this.data_danhsachgiangvien.Name = "data_danhsachgiangvien";
            this.data_danhsachgiangvien.Size = new System.Drawing.Size(680, 580);
            this.data_danhsachgiangvien.TabIndex = 0;
            this.data_danhsachgiangvien.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.data_danhsachgiangvien_CellClick);
            // 
            // openFile_anh
            // 
            this.openFile_anh.FileName = "openFileDialog1";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(1, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(87, 41);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // button1
            // 
            this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button1.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(945, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(43, 23);
            this.button1.TabIndex = 3;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button2.BackgroundImage")));
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Location = new System.Drawing.Point(896, 0);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(43, 23);
            this.button2.TabIndex = 3;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // fgiangvien
            // 
            this.AcceptButton = this.but_themgiangvien;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.CancelButton = this.button1;
            this.ClientSize = new System.Drawing.Size(1000, 678);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lab_tieude);
            this.Controls.Add(this.gb_danhsachgiangvien);
            this.Controls.Add(this.gb_thongtinchitiet);
            this.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "fgiangvien";
            this.Text = "Quản lý giảng viên";
            this.Load += new System.EventHandler(this.fgiangvien_Load);
            this.gb_thongtinchitiet.ResumeLayout(false);
            this.gb_thongtinchitiet.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_anhdaidien)).EndInit();
            this.gb_danhsachgiangvien.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.data_danhsachgiangvien)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gb_thongtinchitiet;
        private System.Windows.Forms.Label lab_tieude;
        private System.Windows.Forms.GroupBox gb_danhsachgiangvien;
        private System.Windows.Forms.DataGridView data_danhsachgiangvien;
        private System.Windows.Forms.Button but_timkiem;
        private System.Windows.Forms.Button but_xoa;
        private System.Windows.Forms.Button but_suagiangvien;
        private System.Windows.Forms.Button but_xuat;
        private System.Windows.Forms.Button but_themgiangvien;
        private System.Windows.Forms.PictureBox pic_anhdaidien;
        private System.Windows.Forms.ComboBox cb_gioitinh;
        private System.Windows.Forms.TextBox txt_email;
        private System.Windows.Forms.TextBox txt_sdt;
        private System.Windows.Forms.TextBox txt_tengiangvien;
        private System.Windows.Forms.TextBox txt_magiangvien_timkiem;
        private System.Windows.Forms.TextBox txt_magiangvien_xoa;
        private System.Windows.Forms.TextBox txt_magiangvien_sua;
        private System.Windows.Forms.TextBox txt_magiangvien;
        private System.Windows.Forms.Label lab_email;
        private System.Windows.Forms.Label lab_anhdaidien;
        private System.Windows.Forms.Label lab_gioitinh;
        private System.Windows.Forms.Label lab_sdt;
        private System.Windows.Forms.Label lab_tengiangvien;
        private System.Windows.Forms.Label lab_maginagvien;
        private System.Windows.Forms.DateTimePicker date_ngaysinh;
        private System.Windows.Forms.Label lab_ngaysinh;
        private System.Windows.Forms.OpenFileDialog openFile_anh;
        private System.Windows.Forms.ComboBox cb_danhsachanh;
        private System.Windows.Forms.Button but_chupanh;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}