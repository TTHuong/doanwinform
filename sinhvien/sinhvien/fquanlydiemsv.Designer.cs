namespace sinhvien
{
    partial class fquanlydiemsv
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fquanlydiemsv));
            this.lab_tieude = new System.Windows.Forms.Label();
            this.cb_monhoc = new System.Windows.Forms.ComboBox();
            this.lab_monhoc = new System.Windows.Forms.Label();
            this.gb_ghichu = new System.Windows.Forms.GroupBox();
            this.txt_ghichu = new System.Windows.Forms.TextBox();
            this.gb_thontinchitiet = new System.Windows.Forms.GroupBox();
            this.cb_hanhkiem = new System.Windows.Forms.ComboBox();
            this.txt_diemtongket = new System.Windows.Forms.TextBox();
            this.txt_diemthi = new System.Windows.Forms.TextBox();
            this.txt_diemtb = new System.Windows.Forms.TextBox();
            this.txt_masinhvien = new System.Windows.Forms.TextBox();
            this.lab_diemtongket = new System.Windows.Forms.Label();
            this.lab_hanhkiem = new System.Windows.Forms.Label();
            this.lab_diemthi = new System.Windows.Forms.Label();
            this.lab_diemtb = new System.Windows.Forms.Label();
            this.lab_masinhvien = new System.Windows.Forms.Label();
            this.data_diemsinhvien = new System.Windows.Forms.DataGridView();
            this.but_them = new System.Windows.Forms.Button();
            this.gb_chucnang = new System.Windows.Forms.GroupBox();
            this.but_timkiem = new System.Windows.Forms.Button();
            this.txt_masinhvien_timkiem = new System.Windows.Forms.TextBox();
            this.txt_masinhvien_sua = new System.Windows.Forms.TextBox();
            this.txt_masinhvien_xoa = new System.Windows.Forms.TextBox();
            this.but_sua = new System.Windows.Forms.Button();
            this.but_xoa = new System.Windows.Forms.Button();
            this.but_xuat = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.gb_ghichu.SuspendLayout();
            this.gb_thontinchitiet.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.data_diemsinhvien)).BeginInit();
            this.gb_chucnang.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lab_tieude
            // 
            this.lab_tieude.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lab_tieude.ForeColor = System.Drawing.Color.Black;
            this.lab_tieude.Location = new System.Drawing.Point(90, 0);
            this.lab_tieude.Name = "lab_tieude";
            this.lab_tieude.Size = new System.Drawing.Size(815, 31);
            this.lab_tieude.TabIndex = 0;
            this.lab_tieude.Text = "QUẢN LÝ ĐIỂM SINH VIÊN\r\n";
            this.lab_tieude.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lab_tieude.MouseDown += new System.Windows.Forms.MouseEventHandler(this.lab_tieude_MouseDown);
            this.lab_tieude.MouseUp += new System.Windows.Forms.MouseEventHandler(this.lab_tieude_MouseUp);
            // 
            // cb_monhoc
            // 
            this.cb_monhoc.FormattingEnabled = true;
            this.cb_monhoc.Location = new System.Drawing.Point(465, 80);
            this.cb_monhoc.Name = "cb_monhoc";
            this.cb_monhoc.Size = new System.Drawing.Size(128, 23);
            this.cb_monhoc.TabIndex = 1;
            // 
            // lab_monhoc
            // 
            this.lab_monhoc.AutoSize = true;
            this.lab_monhoc.Location = new System.Drawing.Point(353, 88);
            this.lab_monhoc.Name = "lab_monhoc";
            this.lab_monhoc.Size = new System.Drawing.Size(53, 15);
            this.lab_monhoc.TabIndex = 0;
            this.lab_monhoc.Text = "Môn học";
            // 
            // gb_ghichu
            // 
            this.gb_ghichu.Controls.Add(this.txt_ghichu);
            this.gb_ghichu.Location = new System.Drawing.Point(6, 200);
            this.gb_ghichu.Name = "gb_ghichu";
            this.gb_ghichu.Size = new System.Drawing.Size(607, 151);
            this.gb_ghichu.TabIndex = 1;
            this.gb_ghichu.TabStop = false;
            this.gb_ghichu.Text = "Ghi chú";
            // 
            // txt_ghichu
            // 
            this.txt_ghichu.Location = new System.Drawing.Point(9, 21);
            this.txt_ghichu.Multiline = true;
            this.txt_ghichu.Name = "txt_ghichu";
            this.txt_ghichu.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txt_ghichu.Size = new System.Drawing.Size(584, 124);
            this.txt_ghichu.TabIndex = 1;
            // 
            // gb_thontinchitiet
            // 
            this.gb_thontinchitiet.Controls.Add(this.cb_monhoc);
            this.gb_thontinchitiet.Controls.Add(this.lab_monhoc);
            this.gb_thontinchitiet.Controls.Add(this.cb_hanhkiem);
            this.gb_thontinchitiet.Controls.Add(this.txt_diemtongket);
            this.gb_thontinchitiet.Controls.Add(this.txt_diemthi);
            this.gb_thontinchitiet.Controls.Add(this.txt_diemtb);
            this.gb_thontinchitiet.Controls.Add(this.txt_masinhvien);
            this.gb_thontinchitiet.Controls.Add(this.lab_diemtongket);
            this.gb_thontinchitiet.Controls.Add(this.lab_hanhkiem);
            this.gb_thontinchitiet.Controls.Add(this.lab_diemthi);
            this.gb_thontinchitiet.Controls.Add(this.lab_diemtb);
            this.gb_thontinchitiet.Controls.Add(this.lab_masinhvien);
            this.gb_thontinchitiet.Location = new System.Drawing.Point(6, 34);
            this.gb_thontinchitiet.Name = "gb_thontinchitiet";
            this.gb_thontinchitiet.Size = new System.Drawing.Size(607, 160);
            this.gb_thontinchitiet.TabIndex = 1;
            this.gb_thontinchitiet.TabStop = false;
            this.gb_thontinchitiet.Text = "Thông tin chi tiết";
            // 
            // cb_hanhkiem
            // 
            this.cb_hanhkiem.FormattingEnabled = true;
            this.cb_hanhkiem.Items.AddRange(new object[] {
            "Tốt",
            "Khá",
            "TB",
            "Yếu",
            "Kém"});
            this.cb_hanhkiem.Location = new System.Drawing.Point(465, 15);
            this.cb_hanhkiem.Name = "cb_hanhkiem";
            this.cb_hanhkiem.Size = new System.Drawing.Size(128, 23);
            this.cb_hanhkiem.TabIndex = 1;
            // 
            // txt_diemtongket
            // 
            this.txt_diemtongket.Location = new System.Drawing.Point(465, 50);
            this.txt_diemtongket.Multiline = true;
            this.txt_diemtongket.Name = "txt_diemtongket";
            this.txt_diemtongket.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txt_diemtongket.Size = new System.Drawing.Size(128, 22);
            this.txt_diemtongket.TabIndex = 1;
            // 
            // txt_diemthi
            // 
            this.txt_diemthi.Location = new System.Drawing.Point(103, 88);
            this.txt_diemthi.Multiline = true;
            this.txt_diemthi.Name = "txt_diemthi";
            this.txt_diemthi.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txt_diemthi.Size = new System.Drawing.Size(216, 22);
            this.txt_diemthi.TabIndex = 1;
            // 
            // txt_diemtb
            // 
            this.txt_diemtb.Location = new System.Drawing.Point(103, 53);
            this.txt_diemtb.Multiline = true;
            this.txt_diemtb.Name = "txt_diemtb";
            this.txt_diemtb.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txt_diemtb.Size = new System.Drawing.Size(216, 22);
            this.txt_diemtb.TabIndex = 1;
            // 
            // txt_masinhvien
            // 
            this.txt_masinhvien.Location = new System.Drawing.Point(103, 18);
            this.txt_masinhvien.Multiline = true;
            this.txt_masinhvien.Name = "txt_masinhvien";
            this.txt_masinhvien.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txt_masinhvien.Size = new System.Drawing.Size(216, 20);
            this.txt_masinhvien.TabIndex = 1;
            // 
            // lab_diemtongket
            // 
            this.lab_diemtongket.AutoSize = true;
            this.lab_diemtongket.Location = new System.Drawing.Point(353, 53);
            this.lab_diemtongket.Name = "lab_diemtongket";
            this.lab_diemtongket.Size = new System.Drawing.Size(84, 15);
            this.lab_diemtongket.TabIndex = 0;
            this.lab_diemtongket.Text = "Điêm tông kêt";
            // 
            // lab_hanhkiem
            // 
            this.lab_hanhkiem.AutoSize = true;
            this.lab_hanhkiem.Location = new System.Drawing.Point(353, 18);
            this.lab_hanhkiem.Name = "lab_hanhkiem";
            this.lab_hanhkiem.Size = new System.Drawing.Size(67, 15);
            this.lab_hanhkiem.TabIndex = 0;
            this.lab_hanhkiem.Text = "Hạnh kiêm";
            // 
            // lab_diemthi
            // 
            this.lab_diemthi.AutoSize = true;
            this.lab_diemthi.Location = new System.Drawing.Point(6, 88);
            this.lab_diemthi.Name = "lab_diemthi";
            this.lab_diemthi.Size = new System.Drawing.Size(57, 15);
            this.lab_diemthi.TabIndex = 0;
            this.lab_diemthi.Text = "Điêm thi ";
            // 
            // lab_diemtb
            // 
            this.lab_diemtb.AutoSize = true;
            this.lab_diemtb.Location = new System.Drawing.Point(6, 53);
            this.lab_diemtb.Name = "lab_diemtb";
            this.lab_diemtb.Size = new System.Drawing.Size(56, 15);
            this.lab_diemtb.TabIndex = 0;
            this.lab_diemtb.Text = "Điêm TB";
            // 
            // lab_masinhvien
            // 
            this.lab_masinhvien.AutoSize = true;
            this.lab_masinhvien.Location = new System.Drawing.Point(6, 18);
            this.lab_masinhvien.Name = "lab_masinhvien";
            this.lab_masinhvien.Size = new System.Drawing.Size(76, 15);
            this.lab_masinhvien.TabIndex = 0;
            this.lab_masinhvien.Text = "Ma sinh vien";
            // 
            // data_diemsinhvien
            // 
            this.data_diemsinhvien.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.data_diemsinhvien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.data_diemsinhvien.Location = new System.Drawing.Point(6, 357);
            this.data_diemsinhvien.Name = "data_diemsinhvien";
            this.data_diemsinhvien.Size = new System.Drawing.Size(893, 236);
            this.data_diemsinhvien.TabIndex = 2;
            this.data_diemsinhvien.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.data_diemsinhvien_CellClick);
            // 
            // but_them
            // 
            this.but_them.Image = ((System.Drawing.Image)(resources.GetObject("but_them.Image")));
            this.but_them.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.but_them.Location = new System.Drawing.Point(6, 20);
            this.but_them.Name = "but_them";
            this.but_them.Size = new System.Drawing.Size(102, 23);
            this.but_them.TabIndex = 3;
            this.but_them.Text = "Thêm";
            this.but_them.UseVisualStyleBackColor = true;
            this.but_them.Click += new System.EventHandler(this.but_them_Click);
            // 
            // gb_chucnang
            // 
            this.gb_chucnang.Controls.Add(this.but_timkiem);
            this.gb_chucnang.Controls.Add(this.txt_masinhvien_timkiem);
            this.gb_chucnang.Controls.Add(this.txt_masinhvien_sua);
            this.gb_chucnang.Controls.Add(this.txt_masinhvien_xoa);
            this.gb_chucnang.Controls.Add(this.but_sua);
            this.gb_chucnang.Controls.Add(this.but_xoa);
            this.gb_chucnang.Controls.Add(this.but_xuat);
            this.gb_chucnang.Controls.Add(this.but_them);
            this.gb_chucnang.Location = new System.Drawing.Point(619, 34);
            this.gb_chucnang.Name = "gb_chucnang";
            this.gb_chucnang.Size = new System.Drawing.Size(280, 317);
            this.gb_chucnang.TabIndex = 4;
            this.gb_chucnang.TabStop = false;
            this.gb_chucnang.Text = "Chưc năng";
            // 
            // but_timkiem
            // 
            this.but_timkiem.Image = ((System.Drawing.Image)(resources.GetObject("but_timkiem.Image")));
            this.but_timkiem.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.but_timkiem.Location = new System.Drawing.Point(6, 275);
            this.but_timkiem.Name = "but_timkiem";
            this.but_timkiem.Size = new System.Drawing.Size(102, 23);
            this.but_timkiem.TabIndex = 3;
            this.but_timkiem.Text = "Tìm kiêm";
            this.but_timkiem.UseVisualStyleBackColor = true;
            this.but_timkiem.Click += new System.EventHandler(this.but_timkiem_Click);
            // 
            // txt_masinhvien_timkiem
            // 
            this.txt_masinhvien_timkiem.Location = new System.Drawing.Point(135, 263);
            this.txt_masinhvien_timkiem.Multiline = true;
            this.txt_masinhvien_timkiem.Name = "txt_masinhvien_timkiem";
            this.txt_masinhvien_timkiem.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txt_masinhvien_timkiem.Size = new System.Drawing.Size(138, 35);
            this.txt_masinhvien_timkiem.TabIndex = 1;
            this.txt_masinhvien_timkiem.Text = "Mã sinh viên";
            // 
            // txt_masinhvien_sua
            // 
            this.txt_masinhvien_sua.Location = new System.Drawing.Point(135, 184);
            this.txt_masinhvien_sua.Multiline = true;
            this.txt_masinhvien_sua.Name = "txt_masinhvien_sua";
            this.txt_masinhvien_sua.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txt_masinhvien_sua.Size = new System.Drawing.Size(138, 37);
            this.txt_masinhvien_sua.TabIndex = 1;
            this.txt_masinhvien_sua.Text = "Mã sinh viên";
            // 
            // txt_masinhvien_xoa
            // 
            this.txt_masinhvien_xoa.Location = new System.Drawing.Point(135, 101);
            this.txt_masinhvien_xoa.Multiline = true;
            this.txt_masinhvien_xoa.Name = "txt_masinhvien_xoa";
            this.txt_masinhvien_xoa.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txt_masinhvien_xoa.Size = new System.Drawing.Size(138, 40);
            this.txt_masinhvien_xoa.TabIndex = 1;
            this.txt_masinhvien_xoa.Text = "Mã sinh viên";
            // 
            // but_sua
            // 
            this.but_sua.Image = ((System.Drawing.Image)(resources.GetObject("but_sua.Image")));
            this.but_sua.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.but_sua.Location = new System.Drawing.Point(6, 183);
            this.but_sua.Name = "but_sua";
            this.but_sua.Size = new System.Drawing.Size(102, 23);
            this.but_sua.TabIndex = 3;
            this.but_sua.Text = "Sửa";
            this.but_sua.UseVisualStyleBackColor = true;
            this.but_sua.Click += new System.EventHandler(this.but_sua_Click);
            // 
            // but_xoa
            // 
            this.but_xoa.Image = ((System.Drawing.Image)(resources.GetObject("but_xoa.Image")));
            this.but_xoa.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.but_xoa.Location = new System.Drawing.Point(6, 105);
            this.but_xoa.Name = "but_xoa";
            this.but_xoa.Size = new System.Drawing.Size(102, 23);
            this.but_xoa.TabIndex = 3;
            this.but_xoa.Text = "Xóa";
            this.but_xoa.UseVisualStyleBackColor = true;
            this.but_xoa.Click += new System.EventHandler(this.but_xoa_Click);
            // 
            // but_xuat
            // 
            this.but_xuat.Image = ((System.Drawing.Image)(resources.GetObject("but_xuat.Image")));
            this.but_xuat.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.but_xuat.Location = new System.Drawing.Point(170, 21);
            this.but_xuat.Name = "but_xuat";
            this.but_xuat.Size = new System.Drawing.Size(103, 23);
            this.but_xuat.TabIndex = 3;
            this.but_xuat.Text = "Xuât";
            this.but_xuat.UseVisualStyleBackColor = true;
            this.but_xuat.Click += new System.EventHandler(this.but_xuat_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(-1, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(89, 31);
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
            this.button1.Location = new System.Drawing.Point(862, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(37, 23);
            this.button1.TabIndex = 6;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // fquanlydiemsv
            // 
            this.AcceptButton = this.but_them;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.CancelButton = this.button1;
            this.ClientSize = new System.Drawing.Size(906, 605);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.gb_chucnang);
            this.Controls.Add(this.data_diemsinhvien);
            this.Controls.Add(this.gb_thontinchitiet);
            this.Controls.Add(this.gb_ghichu);
            this.Controls.Add(this.lab_tieude);
            this.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "fquanlydiemsv";
            this.Text = "Quản lý điểm sinh viên";
            this.Load += new System.EventHandler(this.fquanlydiemsv_Load);
            this.gb_ghichu.ResumeLayout(false);
            this.gb_ghichu.PerformLayout();
            this.gb_thontinchitiet.ResumeLayout(false);
            this.gb_thontinchitiet.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.data_diemsinhvien)).EndInit();
            this.gb_chucnang.ResumeLayout(false);
            this.gb_chucnang.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lab_tieude;
        private System.Windows.Forms.ComboBox cb_monhoc;
        private System.Windows.Forms.Label lab_monhoc;
        private System.Windows.Forms.GroupBox gb_ghichu;
        private System.Windows.Forms.TextBox txt_ghichu;
        private System.Windows.Forms.GroupBox gb_thontinchitiet;
        private System.Windows.Forms.ComboBox cb_hanhkiem;
        private System.Windows.Forms.TextBox txt_diemtongket;
        private System.Windows.Forms.TextBox txt_diemthi;
        private System.Windows.Forms.TextBox txt_diemtb;
        private System.Windows.Forms.TextBox txt_masinhvien;
        private System.Windows.Forms.Label lab_diemtongket;
        private System.Windows.Forms.Label lab_hanhkiem;
        private System.Windows.Forms.Label lab_diemthi;
        private System.Windows.Forms.Label lab_diemtb;
        private System.Windows.Forms.Label lab_masinhvien;
        private System.Windows.Forms.DataGridView data_diemsinhvien;
        private System.Windows.Forms.Button but_them;
        private System.Windows.Forms.GroupBox gb_chucnang;
        private System.Windows.Forms.Button but_xoa;
        private System.Windows.Forms.Button but_xuat;
        private System.Windows.Forms.Button but_timkiem;
        private System.Windows.Forms.TextBox txt_masinhvien_timkiem;
        private System.Windows.Forms.TextBox txt_masinhvien_sua;
        private System.Windows.Forms.TextBox txt_masinhvien_xoa;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button but_sua;
    }
}