namespace sinhvien
{
    partial class fquanlynguoidung
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fquanlynguoidung));
            this.but_them = new System.Windows.Forms.Button();
            this.gb_thongtin = new System.Windows.Forms.GroupBox();
            this.cb_quyenhan = new System.Windows.Forms.ComboBox();
            this.txt_matkhau = new System.Windows.Forms.TextBox();
            this.txt_tendangnhap = new System.Windows.Forms.TextBox();
            this.lab_quyen = new System.Windows.Forms.Label();
            this.lab_matkhau = new System.Windows.Forms.Label();
            this.lab_tendangnhap = new System.Windows.Forms.Label();
            this.gb_chucnang = new System.Windows.Forms.GroupBox();
            this.but_sua = new System.Windows.Forms.Button();
            this.but_timkiem = new System.Windows.Forms.Button();
            this.but_xoa = new System.Windows.Forms.Button();
            this.txt_tendangnhap_sua = new System.Windows.Forms.TextBox();
            this.txt_tendangnhap_timkiem = new System.Windows.Forms.TextBox();
            this.txt_tendangnhap_xoa = new System.Windows.Forms.TextBox();
            this.but_xuất = new System.Windows.Forms.Button();
            this.data_quanlynguoidung = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.gb_thongtin.SuspendLayout();
            this.gb_chucnang.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.data_quanlynguoidung)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // but_them
            // 
            this.but_them.Image = ((System.Drawing.Image)(resources.GetObject("but_them.Image")));
            this.but_them.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.but_them.Location = new System.Drawing.Point(7, 16);
            this.but_them.Name = "but_them";
            this.but_them.Size = new System.Drawing.Size(119, 27);
            this.but_them.TabIndex = 3;
            this.but_them.Text = "Thêm";
            this.but_them.UseVisualStyleBackColor = true;
            this.but_them.Click += new System.EventHandler(this.but_them_Click);
            // 
            // gb_thongtin
            // 
            this.gb_thongtin.Controls.Add(this.cb_quyenhan);
            this.gb_thongtin.Controls.Add(this.txt_matkhau);
            this.gb_thongtin.Controls.Add(this.txt_tendangnhap);
            this.gb_thongtin.Controls.Add(this.lab_quyen);
            this.gb_thongtin.Controls.Add(this.lab_matkhau);
            this.gb_thongtin.Controls.Add(this.lab_tendangnhap);
            this.gb_thongtin.Location = new System.Drawing.Point(2, 68);
            this.gb_thongtin.Name = "gb_thongtin";
            this.gb_thongtin.Size = new System.Drawing.Size(474, 212);
            this.gb_thongtin.TabIndex = 4;
            this.gb_thongtin.TabStop = false;
            this.gb_thongtin.Text = "Thông tin";
            // 
            // cb_quyenhan
            // 
            this.cb_quyenhan.FormattingEnabled = true;
            this.cb_quyenhan.Location = new System.Drawing.Point(167, 156);
            this.cb_quyenhan.Name = "cb_quyenhan";
            this.cb_quyenhan.Size = new System.Drawing.Size(299, 23);
            this.cb_quyenhan.TabIndex = 2;
            // 
            // txt_matkhau
            // 
            this.txt_matkhau.Location = new System.Drawing.Point(167, 90);
            this.txt_matkhau.Multiline = true;
            this.txt_matkhau.Name = "txt_matkhau";
            this.txt_matkhau.Size = new System.Drawing.Size(299, 37);
            this.txt_matkhau.TabIndex = 1;
            // 
            // txt_tendangnhap
            // 
            this.txt_tendangnhap.Location = new System.Drawing.Point(167, 14);
            this.txt_tendangnhap.Multiline = true;
            this.txt_tendangnhap.Name = "txt_tendangnhap";
            this.txt_tendangnhap.Size = new System.Drawing.Size(299, 39);
            this.txt_tendangnhap.TabIndex = 0;
            // 
            // lab_quyen
            // 
            this.lab_quyen.AutoSize = true;
            this.lab_quyen.Location = new System.Drawing.Point(7, 165);
            this.lab_quyen.Name = "lab_quyen";
            this.lab_quyen.Size = new System.Drawing.Size(66, 15);
            this.lab_quyen.TabIndex = 3;
            this.lab_quyen.Text = "Quyền hạn";
            // 
            // lab_matkhau
            // 
            this.lab_matkhau.AutoSize = true;
            this.lab_matkhau.Location = new System.Drawing.Point(7, 93);
            this.lab_matkhau.Name = "lab_matkhau";
            this.lab_matkhau.Size = new System.Drawing.Size(59, 15);
            this.lab_matkhau.TabIndex = 4;
            this.lab_matkhau.Text = "Mật khẩu";
            // 
            // lab_tendangnhap
            // 
            this.lab_tendangnhap.AutoSize = true;
            this.lab_tendangnhap.Location = new System.Drawing.Point(7, 22);
            this.lab_tendangnhap.Name = "lab_tendangnhap";
            this.lab_tendangnhap.Size = new System.Drawing.Size(86, 15);
            this.lab_tendangnhap.TabIndex = 5;
            this.lab_tendangnhap.Text = "Tên đăng nhập";
            // 
            // gb_chucnang
            // 
            this.gb_chucnang.Controls.Add(this.but_sua);
            this.gb_chucnang.Controls.Add(this.but_timkiem);
            this.gb_chucnang.Controls.Add(this.but_xoa);
            this.gb_chucnang.Controls.Add(this.txt_tendangnhap_sua);
            this.gb_chucnang.Controls.Add(this.txt_tendangnhap_timkiem);
            this.gb_chucnang.Controls.Add(this.txt_tendangnhap_xoa);
            this.gb_chucnang.Controls.Add(this.but_xuất);
            this.gb_chucnang.Controls.Add(this.but_them);
            this.gb_chucnang.Location = new System.Drawing.Point(482, 68);
            this.gb_chucnang.Name = "gb_chucnang";
            this.gb_chucnang.Size = new System.Drawing.Size(364, 212);
            this.gb_chucnang.TabIndex = 9;
            this.gb_chucnang.TabStop = false;
            this.gb_chucnang.Text = "Chức năng";
            // 
            // but_sua
            // 
            this.but_sua.Image = ((System.Drawing.Image)(resources.GetObject("but_sua.Image")));
            this.but_sua.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.but_sua.Location = new System.Drawing.Point(7, 178);
            this.but_sua.Name = "but_sua";
            this.but_sua.Size = new System.Drawing.Size(119, 27);
            this.but_sua.TabIndex = 3;
            this.but_sua.Text = "Sửa";
            this.but_sua.UseVisualStyleBackColor = true;
            this.but_sua.Click += new System.EventHandler(this.but_sua_Click);
            // 
            // but_timkiem
            // 
            this.but_timkiem.Image = ((System.Drawing.Image)(resources.GetObject("but_timkiem.Image")));
            this.but_timkiem.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.but_timkiem.Location = new System.Drawing.Point(7, 97);
            this.but_timkiem.Name = "but_timkiem";
            this.but_timkiem.Size = new System.Drawing.Size(119, 27);
            this.but_timkiem.TabIndex = 3;
            this.but_timkiem.Text = "Tìm kiếm";
            this.but_timkiem.UseVisualStyleBackColor = true;
            this.but_timkiem.Click += new System.EventHandler(this.but_timkiem_Click);
            // 
            // but_xoa
            // 
            this.but_xoa.Image = ((System.Drawing.Image)(resources.GetObject("but_xoa.Image")));
            this.but_xoa.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.but_xoa.Location = new System.Drawing.Point(7, 137);
            this.but_xoa.Name = "but_xoa";
            this.but_xoa.Size = new System.Drawing.Size(119, 27);
            this.but_xoa.TabIndex = 3;
            this.but_xoa.Text = "Xóa";
            this.but_xoa.UseVisualStyleBackColor = true;
            this.but_xoa.Click += new System.EventHandler(this.but_xoa_Click);
            // 
            // txt_tendangnhap_sua
            // 
            this.txt_tendangnhap_sua.Location = new System.Drawing.Point(132, 176);
            this.txt_tendangnhap_sua.Multiline = true;
            this.txt_tendangnhap_sua.Name = "txt_tendangnhap_sua";
            this.txt_tendangnhap_sua.Size = new System.Drawing.Size(222, 24);
            this.txt_tendangnhap_sua.TabIndex = 4;
            this.txt_tendangnhap_sua.Text = "Tên đăng nhập";
            // 
            // txt_tendangnhap_timkiem
            // 
            this.txt_tendangnhap_timkiem.Location = new System.Drawing.Point(132, 97);
            this.txt_tendangnhap_timkiem.Multiline = true;
            this.txt_tendangnhap_timkiem.Name = "txt_tendangnhap_timkiem";
            this.txt_tendangnhap_timkiem.Size = new System.Drawing.Size(222, 24);
            this.txt_tendangnhap_timkiem.TabIndex = 3;
            this.txt_tendangnhap_timkiem.Text = "Tên đăng nhập hoặc quyền hạn\r\n";
            // 
            // txt_tendangnhap_xoa
            // 
            this.txt_tendangnhap_xoa.Location = new System.Drawing.Point(132, 135);
            this.txt_tendangnhap_xoa.Multiline = true;
            this.txt_tendangnhap_xoa.Name = "txt_tendangnhap_xoa";
            this.txt_tendangnhap_xoa.Size = new System.Drawing.Size(222, 24);
            this.txt_tendangnhap_xoa.TabIndex = 3;
            this.txt_tendangnhap_xoa.Text = "Tên đăng nhập";
            // 
            // but_xuất
            // 
            this.but_xuất.Image = ((System.Drawing.Image)(resources.GetObject("but_xuất.Image")));
            this.but_xuất.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.but_xuất.Location = new System.Drawing.Point(7, 57);
            this.but_xuất.Name = "but_xuất";
            this.but_xuất.Size = new System.Drawing.Size(119, 27);
            this.but_xuất.TabIndex = 3;
            this.but_xuất.Text = "Xuất";
            this.but_xuất.UseVisualStyleBackColor = true;
            this.but_xuất.Click += new System.EventHandler(this.but_xuất_Click);
            // 
            // data_quanlynguoidung
            // 
            this.data_quanlynguoidung.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.data_quanlynguoidung.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.data_quanlynguoidung.Location = new System.Drawing.Point(1, 286);
            this.data_quanlynguoidung.Name = "data_quanlynguoidung";
            this.data_quanlynguoidung.Size = new System.Drawing.Size(845, 219);
            this.data_quanlynguoidung.TabIndex = 10;
            this.data_quanlynguoidung.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.data_quanlynguoidung_CellClick);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(75, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(771, 32);
            this.label1.TabIndex = 11;
            this.label1.Text = "QUẢN LÝ NGƯỜI DÙNG";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.label1_MouseDown);
            this.label1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.label1_MouseUp);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(1, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(74, 32);
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            // 
            // button1
            // 
            this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button1.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(798, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(38, 23);
            this.button1.TabIndex = 13;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button2.BackgroundImage")));
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Location = new System.Drawing.Point(754, 0);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(38, 23);
            this.button2.TabIndex = 13;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // fquanlynguoidung
            // 
            this.AcceptButton = this.but_them;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.CancelButton = this.button1;
            this.ClientSize = new System.Drawing.Size(848, 508);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.data_quanlynguoidung);
            this.Controls.Add(this.gb_chucnang);
            this.Controls.Add(this.gb_thongtin);
            this.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "fquanlynguoidung";
            this.Text = "Quản lý người dùng";
            this.Load += new System.EventHandler(this.fquanlynguoidung_Load);
            this.gb_thongtin.ResumeLayout(false);
            this.gb_thongtin.PerformLayout();
            this.gb_chucnang.ResumeLayout(false);
            this.gb_chucnang.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.data_quanlynguoidung)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button but_them;
        private System.Windows.Forms.GroupBox gb_thongtin;
        private System.Windows.Forms.ComboBox cb_quyenhan;
        private System.Windows.Forms.TextBox txt_matkhau;
        private System.Windows.Forms.TextBox txt_tendangnhap;
        private System.Windows.Forms.Label lab_quyen;
        private System.Windows.Forms.Label lab_matkhau;
        private System.Windows.Forms.Label lab_tendangnhap;
        private System.Windows.Forms.GroupBox gb_chucnang;
        private System.Windows.Forms.Button but_sua;
        private System.Windows.Forms.Button but_xoa;
        private System.Windows.Forms.TextBox txt_tendangnhap_sua;
        private System.Windows.Forms.TextBox txt_tendangnhap_xoa;
        private System.Windows.Forms.DataGridView data_quanlynguoidung;
        private System.Windows.Forms.Button but_timkiem;
        private System.Windows.Forms.TextBox txt_tendangnhap_timkiem;
        private System.Windows.Forms.Button but_xuất;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}