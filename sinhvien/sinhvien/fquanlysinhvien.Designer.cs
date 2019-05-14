namespace sinhvien
{
    partial class fquanlysinhvien
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fquanlysinhvien));
            this.lab_tieude = new System.Windows.Forms.Label();
            this.gb_thongtin = new System.Windows.Forms.GroupBox();
            this.but_timkiem = new System.Windows.Forms.Button();
            this.but_sua = new System.Windows.Forms.Button();
            this.but_xoa = new System.Windows.Forms.Button();
            this.but_xuat = new System.Windows.Forms.Button();
            this.but_them = new System.Windows.Forms.Button();
            this.cb_malop = new System.Windows.Forms.ComboBox();
            this.cb_gioitinh = new System.Windows.Forms.ComboBox();
            this.date_ngaysinh = new System.Windows.Forms.DateTimePicker();
            this.txt_masinhvien_timkiem = new System.Windows.Forms.TextBox();
            this.txt_masinhvien_sua = new System.Windows.Forms.TextBox();
            this.txt_masinhvien_xoa = new System.Windows.Forms.TextBox();
            this.txt_diachi = new System.Windows.Forms.TextBox();
            this.lab_malop = new System.Windows.Forms.Label();
            this.lab_diachi = new System.Windows.Forms.Label();
            this.lab_gioitinh = new System.Windows.Forms.Label();
            this.lab_ngaysinh = new System.Windows.Forms.Label();
            this.txt_tensinhvien = new System.Windows.Forms.TextBox();
            this.lab_tensinhvien = new System.Windows.Forms.Label();
            this.txt_masinhvien = new System.Windows.Forms.TextBox();
            this.lab_masinhvien = new System.Windows.Forms.Label();
            this.data_danhsachsinhvien = new System.Windows.Forms.DataGridView();
            this.gb_danhsachsinhvien = new System.Windows.Forms.GroupBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.gb_thongtin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.data_danhsachsinhvien)).BeginInit();
            this.gb_danhsachsinhvien.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lab_tieude
            // 
            this.lab_tieude.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lab_tieude.ForeColor = System.Drawing.Color.Black;
            this.lab_tieude.Location = new System.Drawing.Point(93, 0);
            this.lab_tieude.Name = "lab_tieude";
            this.lab_tieude.Size = new System.Drawing.Size(754, 41);
            this.lab_tieude.TabIndex = 0;
            this.lab_tieude.Text = "QUẢN LÝ SINH VIÊN";
            this.lab_tieude.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lab_tieude.MouseDown += new System.Windows.Forms.MouseEventHandler(this.lab_tieude_MouseDown);
            this.lab_tieude.MouseUp += new System.Windows.Forms.MouseEventHandler(this.lab_tieude_MouseUp);
            // 
            // gb_thongtin
            // 
            this.gb_thongtin.Controls.Add(this.but_timkiem);
            this.gb_thongtin.Controls.Add(this.but_sua);
            this.gb_thongtin.Controls.Add(this.but_xoa);
            this.gb_thongtin.Controls.Add(this.but_xuat);
            this.gb_thongtin.Controls.Add(this.but_them);
            this.gb_thongtin.Controls.Add(this.cb_malop);
            this.gb_thongtin.Controls.Add(this.cb_gioitinh);
            this.gb_thongtin.Controls.Add(this.date_ngaysinh);
            this.gb_thongtin.Controls.Add(this.txt_masinhvien_timkiem);
            this.gb_thongtin.Controls.Add(this.txt_masinhvien_sua);
            this.gb_thongtin.Controls.Add(this.txt_masinhvien_xoa);
            this.gb_thongtin.Controls.Add(this.txt_diachi);
            this.gb_thongtin.Controls.Add(this.lab_malop);
            this.gb_thongtin.Controls.Add(this.lab_diachi);
            this.gb_thongtin.Controls.Add(this.lab_gioitinh);
            this.gb_thongtin.Controls.Add(this.lab_ngaysinh);
            this.gb_thongtin.Controls.Add(this.txt_tensinhvien);
            this.gb_thongtin.Controls.Add(this.lab_tensinhvien);
            this.gb_thongtin.Controls.Add(this.txt_masinhvien);
            this.gb_thongtin.Controls.Add(this.lab_masinhvien);
            this.gb_thongtin.Location = new System.Drawing.Point(6, 78);
            this.gb_thongtin.Name = "gb_thongtin";
            this.gb_thongtin.Size = new System.Drawing.Size(250, 526);
            this.gb_thongtin.TabIndex = 1;
            this.gb_thongtin.TabStop = false;
            this.gb_thongtin.Text = "Thông  tin chi tiết";
            // 
            // but_timkiem
            // 
            this.but_timkiem.Image = ((System.Drawing.Image)(resources.GetObject("but_timkiem.Image")));
            this.but_timkiem.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.but_timkiem.Location = new System.Drawing.Point(6, 490);
            this.but_timkiem.Name = "but_timkiem";
            this.but_timkiem.Size = new System.Drawing.Size(96, 23);
            this.but_timkiem.TabIndex = 2;
            this.but_timkiem.Text = "Tìm kiếm";
            this.but_timkiem.UseVisualStyleBackColor = true;
            this.but_timkiem.Click += new System.EventHandler(this.but_timkiem_Click);
            // 
            // but_sua
            // 
            this.but_sua.Image = ((System.Drawing.Image)(resources.GetObject("but_sua.Image")));
            this.but_sua.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.but_sua.Location = new System.Drawing.Point(6, 439);
            this.but_sua.Name = "but_sua";
            this.but_sua.Size = new System.Drawing.Size(96, 23);
            this.but_sua.TabIndex = 2;
            this.but_sua.Text = "Sửa";
            this.but_sua.UseVisualStyleBackColor = true;
            this.but_sua.Click += new System.EventHandler(this.but_sua_Click);
            // 
            // but_xoa
            // 
            this.but_xoa.Image = ((System.Drawing.Image)(resources.GetObject("but_xoa.Image")));
            this.but_xoa.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.but_xoa.Location = new System.Drawing.Point(6, 388);
            this.but_xoa.Name = "but_xoa";
            this.but_xoa.Size = new System.Drawing.Size(96, 23);
            this.but_xoa.TabIndex = 2;
            this.but_xoa.Text = "Xóa";
            this.but_xoa.UseVisualStyleBackColor = true;
            this.but_xoa.Click += new System.EventHandler(this.but_xoa_Click);
            // 
            // but_xuat
            // 
            this.but_xuat.Image = ((System.Drawing.Image)(resources.GetObject("but_xuat.Image")));
            this.but_xuat.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.but_xuat.Location = new System.Drawing.Point(6, 337);
            this.but_xuat.Name = "but_xuat";
            this.but_xuat.Size = new System.Drawing.Size(96, 23);
            this.but_xuat.TabIndex = 2;
            this.but_xuat.Text = "Xuất";
            this.but_xuat.UseVisualStyleBackColor = true;
            this.but_xuat.Click += new System.EventHandler(this.but_xuat_Click);
            // 
            // but_them
            // 
            this.but_them.Image = ((System.Drawing.Image)(resources.GetObject("but_them.Image")));
            this.but_them.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.but_them.Location = new System.Drawing.Point(6, 282);
            this.but_them.Name = "but_them";
            this.but_them.Size = new System.Drawing.Size(96, 27);
            this.but_them.TabIndex = 2;
            this.but_them.Text = "Thêm";
            this.but_them.UseVisualStyleBackColor = true;
            this.but_them.Click += new System.EventHandler(this.but_them_Click);
            // 
            // cb_malop
            // 
            this.cb_malop.FormattingEnabled = true;
            this.cb_malop.Location = new System.Drawing.Point(87, 235);
            this.cb_malop.Name = "cb_malop";
            this.cb_malop.Size = new System.Drawing.Size(121, 23);
            this.cb_malop.TabIndex = 3;
            // 
            // cb_gioitinh
            // 
            this.cb_gioitinh.FormattingEnabled = true;
            this.cb_gioitinh.Items.AddRange(new object[] {
            "Nam",
            "Nu"});
            this.cb_gioitinh.Location = new System.Drawing.Point(87, 150);
            this.cb_gioitinh.Name = "cb_gioitinh";
            this.cb_gioitinh.Size = new System.Drawing.Size(121, 23);
            this.cb_gioitinh.Sorted = true;
            this.cb_gioitinh.TabIndex = 3;
            // 
            // date_ngaysinh
            // 
            this.date_ngaysinh.Location = new System.Drawing.Point(89, 106);
            this.date_ngaysinh.Name = "date_ngaysinh";
            this.date_ngaysinh.Size = new System.Drawing.Size(119, 22);
            this.date_ngaysinh.TabIndex = 2;
            // 
            // txt_masinhvien_timkiem
            // 
            this.txt_masinhvien_timkiem.Location = new System.Drawing.Point(108, 490);
            this.txt_masinhvien_timkiem.Multiline = true;
            this.txt_masinhvien_timkiem.Name = "txt_masinhvien_timkiem";
            this.txt_masinhvien_timkiem.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txt_masinhvien_timkiem.Size = new System.Drawing.Size(100, 22);
            this.txt_masinhvien_timkiem.TabIndex = 1;
            this.txt_masinhvien_timkiem.Text = "Mã sinh viên";
            // 
            // txt_masinhvien_sua
            // 
            this.txt_masinhvien_sua.Location = new System.Drawing.Point(108, 440);
            this.txt_masinhvien_sua.Multiline = true;
            this.txt_masinhvien_sua.Name = "txt_masinhvien_sua";
            this.txt_masinhvien_sua.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txt_masinhvien_sua.Size = new System.Drawing.Size(100, 22);
            this.txt_masinhvien_sua.TabIndex = 1;
            this.txt_masinhvien_sua.Text = "Mã sinh viên";
            // 
            // txt_masinhvien_xoa
            // 
            this.txt_masinhvien_xoa.Location = new System.Drawing.Point(108, 389);
            this.txt_masinhvien_xoa.Multiline = true;
            this.txt_masinhvien_xoa.Name = "txt_masinhvien_xoa";
            this.txt_masinhvien_xoa.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txt_masinhvien_xoa.Size = new System.Drawing.Size(100, 22);
            this.txt_masinhvien_xoa.TabIndex = 1;
            this.txt_masinhvien_xoa.Text = "Mã sinh viên";
            // 
            // txt_diachi
            // 
            this.txt_diachi.Location = new System.Drawing.Point(87, 194);
            this.txt_diachi.Multiline = true;
            this.txt_diachi.Name = "txt_diachi";
            this.txt_diachi.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txt_diachi.Size = new System.Drawing.Size(121, 22);
            this.txt_diachi.TabIndex = 1;
            // 
            // lab_malop
            // 
            this.lab_malop.AutoSize = true;
            this.lab_malop.Location = new System.Drawing.Point(6, 238);
            this.lab_malop.Name = "lab_malop";
            this.lab_malop.Size = new System.Drawing.Size(44, 15);
            this.lab_malop.TabIndex = 0;
            this.lab_malop.Text = "Mã lớp";
            // 
            // lab_diachi
            // 
            this.lab_diachi.AutoSize = true;
            this.lab_diachi.Location = new System.Drawing.Point(6, 194);
            this.lab_diachi.Name = "lab_diachi";
            this.lab_diachi.Size = new System.Drawing.Size(46, 15);
            this.lab_diachi.TabIndex = 0;
            this.lab_diachi.Text = "Địa chỉ";
            // 
            // lab_gioitinh
            // 
            this.lab_gioitinh.AutoSize = true;
            this.lab_gioitinh.Location = new System.Drawing.Point(6, 150);
            this.lab_gioitinh.Name = "lab_gioitinh";
            this.lab_gioitinh.Size = new System.Drawing.Size(56, 15);
            this.lab_gioitinh.TabIndex = 0;
            this.lab_gioitinh.Text = "Giới tính";
            // 
            // lab_ngaysinh
            // 
            this.lab_ngaysinh.AutoSize = true;
            this.lab_ngaysinh.Location = new System.Drawing.Point(6, 106);
            this.lab_ngaysinh.Name = "lab_ngaysinh";
            this.lab_ngaysinh.Size = new System.Drawing.Size(62, 15);
            this.lab_ngaysinh.TabIndex = 0;
            this.lab_ngaysinh.Text = "Ngày sinh";
            // 
            // txt_tensinhvien
            // 
            this.txt_tensinhvien.Location = new System.Drawing.Point(89, 62);
            this.txt_tensinhvien.Multiline = true;
            this.txt_tensinhvien.Name = "txt_tensinhvien";
            this.txt_tensinhvien.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txt_tensinhvien.Size = new System.Drawing.Size(119, 22);
            this.txt_tensinhvien.TabIndex = 1;
            // 
            // lab_tensinhvien
            // 
            this.lab_tensinhvien.AutoSize = true;
            this.lab_tensinhvien.Location = new System.Drawing.Point(6, 62);
            this.lab_tensinhvien.Name = "lab_tensinhvien";
            this.lab_tensinhvien.Size = new System.Drawing.Size(80, 15);
            this.lab_tensinhvien.TabIndex = 0;
            this.lab_tensinhvien.Text = "Tên sinh viên";
            // 
            // txt_masinhvien
            // 
            this.txt_masinhvien.Location = new System.Drawing.Point(87, 18);
            this.txt_masinhvien.Multiline = true;
            this.txt_masinhvien.Name = "txt_masinhvien";
            this.txt_masinhvien.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txt_masinhvien.Size = new System.Drawing.Size(121, 20);
            this.txt_masinhvien.TabIndex = 1;
            // 
            // lab_masinhvien
            // 
            this.lab_masinhvien.AutoSize = true;
            this.lab_masinhvien.Location = new System.Drawing.Point(6, 18);
            this.lab_masinhvien.Name = "lab_masinhvien";
            this.lab_masinhvien.Size = new System.Drawing.Size(76, 15);
            this.lab_masinhvien.TabIndex = 0;
            this.lab_masinhvien.Text = "Mã sinh viên";
            // 
            // data_danhsachsinhvien
            // 
            this.data_danhsachsinhvien.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.data_danhsachsinhvien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.data_danhsachsinhvien.Location = new System.Drawing.Point(6, 23);
            this.data_danhsachsinhvien.Name = "data_danhsachsinhvien";
            this.data_danhsachsinhvien.Size = new System.Drawing.Size(573, 497);
            this.data_danhsachsinhvien.TabIndex = 3;
            this.data_danhsachsinhvien.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.data_danhsachsinhvien_CellClick);
            // 
            // gb_danhsachsinhvien
            // 
            this.gb_danhsachsinhvien.Controls.Add(this.data_danhsachsinhvien);
            this.gb_danhsachsinhvien.Location = new System.Drawing.Point(262, 78);
            this.gb_danhsachsinhvien.Name = "gb_danhsachsinhvien";
            this.gb_danhsachsinhvien.Size = new System.Drawing.Size(585, 526);
            this.gb_danhsachsinhvien.TabIndex = 4;
            this.gb_danhsachsinhvien.TabStop = false;
            this.gb_danhsachsinhvien.Text = "Danh sách sinh viên";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(-3, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(95, 41);
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // button1
            // 
            this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button1.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(807, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(33, 23);
            this.button1.TabIndex = 6;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button2.BackgroundImage")));
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Location = new System.Drawing.Point(768, 0);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(33, 23);
            this.button2.TabIndex = 6;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // fquanlysinhvien
            // 
            this.AcceptButton = this.but_them;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.CancelButton = this.button1;
            this.ClientSize = new System.Drawing.Size(847, 607);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.gb_danhsachsinhvien);
            this.Controls.Add(this.gb_thongtin);
            this.Controls.Add(this.lab_tieude);
            this.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "fquanlysinhvien";
            this.Text = "Quản lý sinh viên";
            this.Load += new System.EventHandler(this.fquanlysinhvien_Load);
            this.gb_thongtin.ResumeLayout(false);
            this.gb_thongtin.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.data_danhsachsinhvien)).EndInit();
            this.gb_danhsachsinhvien.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lab_tieude;
        private System.Windows.Forms.GroupBox gb_thongtin;
        private System.Windows.Forms.DataGridView data_danhsachsinhvien;
        private System.Windows.Forms.Button but_them;
        private System.Windows.Forms.TextBox txt_masinhvien;
        private System.Windows.Forms.Label lab_masinhvien;
        private System.Windows.Forms.ComboBox cb_malop;
        private System.Windows.Forms.ComboBox cb_gioitinh;
        private System.Windows.Forms.DateTimePicker date_ngaysinh;
        private System.Windows.Forms.TextBox txt_diachi;
        private System.Windows.Forms.Label lab_malop;
        private System.Windows.Forms.Label lab_diachi;
        private System.Windows.Forms.Label lab_gioitinh;
        private System.Windows.Forms.Label lab_ngaysinh;
        private System.Windows.Forms.TextBox txt_tensinhvien;
        private System.Windows.Forms.Label lab_tensinhvien;
        private System.Windows.Forms.Button but_timkiem;
        private System.Windows.Forms.Button but_sua;
        private System.Windows.Forms.Button but_xoa;
        private System.Windows.Forms.Button but_xuat;
        private System.Windows.Forms.TextBox txt_masinhvien_timkiem;
        private System.Windows.Forms.TextBox txt_masinhvien_sua;
        private System.Windows.Forms.TextBox txt_masinhvien_xoa;
        private System.Windows.Forms.GroupBox gb_danhsachsinhvien;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}