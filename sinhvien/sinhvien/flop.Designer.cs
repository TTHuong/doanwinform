namespace sinhvien
{
    partial class flop
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(flop));
            this.gb_thongtin = new System.Windows.Forms.GroupBox();
            this.cb_makhoa = new System.Windows.Forms.ComboBox();
            this.but_timkiem = new System.Windows.Forms.Button();
            this.but_sua = new System.Windows.Forms.Button();
            this.but_xoa = new System.Windows.Forms.Button();
            this.but_xuat = new System.Windows.Forms.Button();
            this.but_them = new System.Windows.Forms.Button();
            this.lab_makhoa = new System.Windows.Forms.Label();
            this.lab_tenlop = new System.Windows.Forms.Label();
            this.lab_malop = new System.Windows.Forms.Label();
            this.txt_malop_timkiem = new System.Windows.Forms.TextBox();
            this.txt_malop_sua = new System.Windows.Forms.TextBox();
            this.txt_malop_xoa = new System.Windows.Forms.TextBox();
            this.txt_tenlop = new System.Windows.Forms.TextBox();
            this.txt_malop = new System.Windows.Forms.TextBox();
            this.data_danhsachlop = new System.Windows.Forms.DataGridView();
            this.gb_danhsachlop = new System.Windows.Forms.GroupBox();
            this.lab_tieude = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.gb_thongtin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.data_danhsachlop)).BeginInit();
            this.gb_danhsachlop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // gb_thongtin
            // 
            this.gb_thongtin.Controls.Add(this.cb_makhoa);
            this.gb_thongtin.Controls.Add(this.but_timkiem);
            this.gb_thongtin.Controls.Add(this.but_sua);
            this.gb_thongtin.Controls.Add(this.but_xoa);
            this.gb_thongtin.Controls.Add(this.but_xuat);
            this.gb_thongtin.Controls.Add(this.but_them);
            this.gb_thongtin.Controls.Add(this.lab_makhoa);
            this.gb_thongtin.Controls.Add(this.lab_tenlop);
            this.gb_thongtin.Controls.Add(this.lab_malop);
            this.gb_thongtin.Controls.Add(this.txt_malop_timkiem);
            this.gb_thongtin.Controls.Add(this.txt_malop_sua);
            this.gb_thongtin.Controls.Add(this.txt_malop_xoa);
            this.gb_thongtin.Controls.Add(this.txt_tenlop);
            this.gb_thongtin.Controls.Add(this.txt_malop);
            this.gb_thongtin.Location = new System.Drawing.Point(1, 57);
            this.gb_thongtin.Name = "gb_thongtin";
            this.gb_thongtin.Size = new System.Drawing.Size(345, 456);
            this.gb_thongtin.TabIndex = 0;
            this.gb_thongtin.TabStop = false;
            this.gb_thongtin.Text = "Thông tin";
            // 
            // cb_makhoa
            // 
            this.cb_makhoa.FormattingEnabled = true;
            this.cb_makhoa.Location = new System.Drawing.Point(105, 130);
            this.cb_makhoa.Name = "cb_makhoa";
            this.cb_makhoa.Size = new System.Drawing.Size(116, 23);
            this.cb_makhoa.TabIndex = 3;
            // 
            // but_timkiem
            // 
            this.but_timkiem.Image = ((System.Drawing.Image)(resources.GetObject("but_timkiem.Image")));
            this.but_timkiem.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.but_timkiem.Location = new System.Drawing.Point(7, 413);
            this.but_timkiem.Name = "but_timkiem";
            this.but_timkiem.Size = new System.Drawing.Size(87, 27);
            this.but_timkiem.TabIndex = 2;
            this.but_timkiem.Text = "Tìm kiếm";
            this.but_timkiem.UseVisualStyleBackColor = true;
            this.but_timkiem.Click += new System.EventHandler(this.but_timkiem_Click);
            // 
            // but_sua
            // 
            this.but_sua.Image = ((System.Drawing.Image)(resources.GetObject("but_sua.Image")));
            this.but_sua.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.but_sua.Location = new System.Drawing.Point(7, 354);
            this.but_sua.Name = "but_sua";
            this.but_sua.Size = new System.Drawing.Size(87, 27);
            this.but_sua.TabIndex = 2;
            this.but_sua.Text = "Sửa";
            this.but_sua.UseVisualStyleBackColor = true;
            this.but_sua.Click += new System.EventHandler(this.but_sua_Click);
            // 
            // but_xoa
            // 
            this.but_xoa.Image = ((System.Drawing.Image)(resources.GetObject("but_xoa.Image")));
            this.but_xoa.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.but_xoa.Location = new System.Drawing.Point(7, 295);
            this.but_xoa.Name = "but_xoa";
            this.but_xoa.Size = new System.Drawing.Size(87, 27);
            this.but_xoa.TabIndex = 2;
            this.but_xoa.Text = "Xóa";
            this.but_xoa.UseVisualStyleBackColor = true;
            this.but_xoa.Click += new System.EventHandler(this.but_xoa_Click);
            // 
            // but_xuat
            // 
            this.but_xuat.Image = ((System.Drawing.Image)(resources.GetObject("but_xuat.Image")));
            this.but_xuat.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.but_xuat.Location = new System.Drawing.Point(7, 237);
            this.but_xuat.Name = "but_xuat";
            this.but_xuat.Size = new System.Drawing.Size(87, 27);
            this.but_xuat.TabIndex = 2;
            this.but_xuat.Text = "Xuất";
            this.but_xuat.UseVisualStyleBackColor = true;
            this.but_xuat.Click += new System.EventHandler(this.but_xuat_Click);
            // 
            // but_them
            // 
            this.but_them.Image = ((System.Drawing.Image)(resources.GetObject("but_them.Image")));
            this.but_them.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.but_them.Location = new System.Drawing.Point(7, 178);
            this.but_them.Name = "but_them";
            this.but_them.Size = new System.Drawing.Size(87, 27);
            this.but_them.TabIndex = 2;
            this.but_them.Text = "Thêm";
            this.but_them.UseVisualStyleBackColor = true;
            this.but_them.Click += new System.EventHandler(this.but_them_Click);
            // 
            // lab_makhoa
            // 
            this.lab_makhoa.AutoSize = true;
            this.lab_makhoa.Location = new System.Drawing.Point(7, 130);
            this.lab_makhoa.Name = "lab_makhoa";
            this.lab_makhoa.Size = new System.Drawing.Size(54, 15);
            this.lab_makhoa.TabIndex = 1;
            this.lab_makhoa.Text = "Mã khoa";
            // 
            // lab_tenlop
            // 
            this.lab_tenlop.AutoSize = true;
            this.lab_tenlop.Location = new System.Drawing.Point(7, 83);
            this.lab_tenlop.Name = "lab_tenlop";
            this.lab_tenlop.Size = new System.Drawing.Size(48, 15);
            this.lab_tenlop.TabIndex = 1;
            this.lab_tenlop.Text = "Tên lớp";
            // 
            // lab_malop
            // 
            this.lab_malop.AutoSize = true;
            this.lab_malop.Location = new System.Drawing.Point(7, 36);
            this.lab_malop.Name = "lab_malop";
            this.lab_malop.Size = new System.Drawing.Size(44, 15);
            this.lab_malop.TabIndex = 1;
            this.lab_malop.Text = "Mã lớp";
            // 
            // txt_malop_timkiem
            // 
            this.txt_malop_timkiem.Location = new System.Drawing.Point(101, 413);
            this.txt_malop_timkiem.Multiline = true;
            this.txt_malop_timkiem.Name = "txt_malop_timkiem";
            this.txt_malop_timkiem.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txt_malop_timkiem.Size = new System.Drawing.Size(116, 22);
            this.txt_malop_timkiem.TabIndex = 0;
            this.txt_malop_timkiem.Text = "Mã lớp";
            // 
            // txt_malop_sua
            // 
            this.txt_malop_sua.Location = new System.Drawing.Point(101, 354);
            this.txt_malop_sua.Multiline = true;
            this.txt_malop_sua.Name = "txt_malop_sua";
            this.txt_malop_sua.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txt_malop_sua.Size = new System.Drawing.Size(116, 22);
            this.txt_malop_sua.TabIndex = 0;
            this.txt_malop_sua.Text = "Mã lớp";
            // 
            // txt_malop_xoa
            // 
            this.txt_malop_xoa.Location = new System.Drawing.Point(105, 298);
            this.txt_malop_xoa.Multiline = true;
            this.txt_malop_xoa.Name = "txt_malop_xoa";
            this.txt_malop_xoa.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txt_malop_xoa.Size = new System.Drawing.Size(116, 22);
            this.txt_malop_xoa.TabIndex = 0;
            this.txt_malop_xoa.Text = "Mã lớp";
            // 
            // txt_tenlop
            // 
            this.txt_tenlop.Location = new System.Drawing.Point(105, 83);
            this.txt_tenlop.Multiline = true;
            this.txt_tenlop.Name = "txt_tenlop";
            this.txt_tenlop.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txt_tenlop.Size = new System.Drawing.Size(116, 22);
            this.txt_tenlop.TabIndex = 0;
            // 
            // txt_malop
            // 
            this.txt_malop.Location = new System.Drawing.Point(105, 36);
            this.txt_malop.Multiline = true;
            this.txt_malop.Name = "txt_malop";
            this.txt_malop.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txt_malop.Size = new System.Drawing.Size(116, 22);
            this.txt_malop.TabIndex = 0;
            // 
            // data_danhsachlop
            // 
            this.data_danhsachlop.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.data_danhsachlop.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.data_danhsachlop.Location = new System.Drawing.Point(7, 22);
            this.data_danhsachlop.Name = "data_danhsachlop";
            this.data_danhsachlop.Size = new System.Drawing.Size(556, 420);
            this.data_danhsachlop.TabIndex = 3;
            this.data_danhsachlop.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.data_danhsachlop_CellClick);
            // 
            // gb_danhsachlop
            // 
            this.gb_danhsachlop.Controls.Add(this.data_danhsachlop);
            this.gb_danhsachlop.Location = new System.Drawing.Point(353, 57);
            this.gb_danhsachlop.Name = "gb_danhsachlop";
            this.gb_danhsachlop.Size = new System.Drawing.Size(570, 456);
            this.gb_danhsachlop.TabIndex = 0;
            this.gb_danhsachlop.TabStop = false;
            this.gb_danhsachlop.Text = "Danh sách lớp";
            // 
            // lab_tieude
            // 
            this.lab_tieude.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lab_tieude.ForeColor = System.Drawing.Color.Black;
            this.lab_tieude.Location = new System.Drawing.Point(94, 0);
            this.lab_tieude.Name = "lab_tieude";
            this.lab_tieude.Size = new System.Drawing.Size(831, 33);
            this.lab_tieude.TabIndex = 1;
            this.lab_tieude.Text = "QUẢN LÝ LỚP";
            this.lab_tieude.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lab_tieude.MouseDown += new System.Windows.Forms.MouseEventHandler(this.lab_tieude_MouseDown);
            this.lab_tieude.MouseUp += new System.Windows.Forms.MouseEventHandler(this.lab_tieude_MouseUp);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(1, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(94, 33);
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
            this.button1.Location = new System.Drawing.Point(885, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(29, 23);
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
            this.button2.Location = new System.Drawing.Point(826, 0);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(41, 23);
            this.button2.TabIndex = 3;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // flop
            // 
            this.AcceptButton = this.but_them;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.CancelButton = this.button1;
            this.ClientSize = new System.Drawing.Size(926, 516);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lab_tieude);
            this.Controls.Add(this.gb_danhsachlop);
            this.Controls.Add(this.gb_thongtin);
            this.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "flop";
            this.Text = "Quản lý lớp";
            this.Load += new System.EventHandler(this.flop_Load);
            this.gb_thongtin.ResumeLayout(false);
            this.gb_thongtin.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.data_danhsachlop)).EndInit();
            this.gb_danhsachlop.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gb_thongtin;
        private System.Windows.Forms.DataGridView data_danhsachlop;
        private System.Windows.Forms.Button but_them;
        private System.Windows.Forms.Label lab_malop;
        private System.Windows.Forms.TextBox txt_malop;
        private System.Windows.Forms.Button but_timkiem;
        private System.Windows.Forms.Button but_sua;
        private System.Windows.Forms.Button but_xoa;
        private System.Windows.Forms.Button but_xuat;
        private System.Windows.Forms.Label lab_makhoa;
        private System.Windows.Forms.Label lab_tenlop;
        private System.Windows.Forms.TextBox txt_malop_timkiem;
        private System.Windows.Forms.TextBox txt_malop_sua;
        private System.Windows.Forms.TextBox txt_malop_xoa;
        private System.Windows.Forms.TextBox txt_tenlop;
        private System.Windows.Forms.GroupBox gb_danhsachlop;
        private System.Windows.Forms.ComboBox cb_makhoa;
        private System.Windows.Forms.Label lab_tieude;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}