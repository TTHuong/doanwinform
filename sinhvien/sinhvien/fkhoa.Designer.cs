namespace sinhvien
{
    partial class fkhoa
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fkhoa));
            this.lab_tenkhoa = new System.Windows.Forms.Label();
            this.but_them = new System.Windows.Forms.Button();
            this.txt_makhoa = new System.Windows.Forms.TextBox();
            this.gb_thongtin = new System.Windows.Forms.GroupBox();
            this.but_timkiem = new System.Windows.Forms.Button();
            this.but_sua = new System.Windows.Forms.Button();
            this.but_xoa = new System.Windows.Forms.Button();
            this.but_xuat = new System.Windows.Forms.Button();
            this.lab_makhoa = new System.Windows.Forms.Label();
            this.txt_tenkhoa = new System.Windows.Forms.TextBox();
            this.txt_makhoa_timkiem = new System.Windows.Forms.TextBox();
            this.txt_makhoa_sua = new System.Windows.Forms.TextBox();
            this.txt_makhoa_xoa = new System.Windows.Forms.TextBox();
            this.gb_danhsachkhoa = new System.Windows.Forms.GroupBox();
            this.data_danhsachkhoa = new System.Windows.Forms.DataGridView();
            this.lab_tieude = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.gb_thongtin.SuspendLayout();
            this.gb_danhsachkhoa.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.data_danhsachkhoa)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lab_tenkhoa
            // 
            this.lab_tenkhoa.AutoSize = true;
            this.lab_tenkhoa.Location = new System.Drawing.Point(7, 120);
            this.lab_tenkhoa.Name = "lab_tenkhoa";
            this.lab_tenkhoa.Size = new System.Drawing.Size(58, 15);
            this.lab_tenkhoa.TabIndex = 1;
            this.lab_tenkhoa.Text = "Tên khoa";
            // 
            // but_them
            // 
            this.but_them.Image = ((System.Drawing.Image)(resources.GetObject("but_them.Image")));
            this.but_them.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.but_them.Location = new System.Drawing.Point(10, 155);
            this.but_them.Name = "but_them";
            this.but_them.Size = new System.Drawing.Size(87, 27);
            this.but_them.TabIndex = 2;
            this.but_them.Text = "Thêm";
            this.but_them.UseVisualStyleBackColor = true;
            this.but_them.Click += new System.EventHandler(this.but_them_Click);
            // 
            // txt_makhoa
            // 
            this.txt_makhoa.Location = new System.Drawing.Point(128, 47);
            this.txt_makhoa.Name = "txt_makhoa";
            this.txt_makhoa.Size = new System.Drawing.Size(116, 22);
            this.txt_makhoa.TabIndex = 3;
            // 
            // gb_thongtin
            // 
            this.gb_thongtin.Controls.Add(this.but_timkiem);
            this.gb_thongtin.Controls.Add(this.but_sua);
            this.gb_thongtin.Controls.Add(this.but_xoa);
            this.gb_thongtin.Controls.Add(this.but_xuat);
            this.gb_thongtin.Controls.Add(this.but_them);
            this.gb_thongtin.Controls.Add(this.lab_makhoa);
            this.gb_thongtin.Controls.Add(this.lab_tenkhoa);
            this.gb_thongtin.Controls.Add(this.txt_tenkhoa);
            this.gb_thongtin.Controls.Add(this.txt_makhoa_timkiem);
            this.gb_thongtin.Controls.Add(this.txt_makhoa_sua);
            this.gb_thongtin.Controls.Add(this.txt_makhoa_xoa);
            this.gb_thongtin.Controls.Add(this.txt_makhoa);
            this.gb_thongtin.Location = new System.Drawing.Point(3, 39);
            this.gb_thongtin.Name = "gb_thongtin";
            this.gb_thongtin.Size = new System.Drawing.Size(371, 427);
            this.gb_thongtin.TabIndex = 4;
            this.gb_thongtin.TabStop = false;
            this.gb_thongtin.Text = "Thông tin";
            // 
            // but_timkiem
            // 
            this.but_timkiem.Image = ((System.Drawing.Image)(resources.GetObject("but_timkiem.Image")));
            this.but_timkiem.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.but_timkiem.Location = new System.Drawing.Point(10, 387);
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
            this.but_sua.Location = new System.Drawing.Point(10, 329);
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
            this.but_xoa.Location = new System.Drawing.Point(10, 271);
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
            this.but_xuat.Location = new System.Drawing.Point(10, 213);
            this.but_xuat.Name = "but_xuat";
            this.but_xuat.Size = new System.Drawing.Size(87, 27);
            this.but_xuat.TabIndex = 2;
            this.but_xuat.Text = "Xuất";
            this.but_xuat.UseVisualStyleBackColor = true;
            this.but_xuat.Click += new System.EventHandler(this.but_xuat_Click);
            // 
            // lab_makhoa
            // 
            this.lab_makhoa.AutoSize = true;
            this.lab_makhoa.Location = new System.Drawing.Point(7, 47);
            this.lab_makhoa.Name = "lab_makhoa";
            this.lab_makhoa.Size = new System.Drawing.Size(54, 15);
            this.lab_makhoa.TabIndex = 1;
            this.lab_makhoa.Text = "Mã khoa";
            // 
            // txt_tenkhoa
            // 
            this.txt_tenkhoa.Location = new System.Drawing.Point(128, 120);
            this.txt_tenkhoa.Name = "txt_tenkhoa";
            this.txt_tenkhoa.Size = new System.Drawing.Size(116, 22);
            this.txt_tenkhoa.TabIndex = 3;
            // 
            // txt_makhoa_timkiem
            // 
            this.txt_makhoa_timkiem.Location = new System.Drawing.Point(132, 387);
            this.txt_makhoa_timkiem.Name = "txt_makhoa_timkiem";
            this.txt_makhoa_timkiem.Size = new System.Drawing.Size(116, 22);
            this.txt_makhoa_timkiem.TabIndex = 3;
            this.txt_makhoa_timkiem.Text = "Mã khoa";
            // 
            // txt_makhoa_sua
            // 
            this.txt_makhoa_sua.Location = new System.Drawing.Point(132, 329);
            this.txt_makhoa_sua.Name = "txt_makhoa_sua";
            this.txt_makhoa_sua.Size = new System.Drawing.Size(116, 22);
            this.txt_makhoa_sua.TabIndex = 3;
            this.txt_makhoa_sua.Text = "Mã khoa";
            // 
            // txt_makhoa_xoa
            // 
            this.txt_makhoa_xoa.Location = new System.Drawing.Point(132, 271);
            this.txt_makhoa_xoa.Name = "txt_makhoa_xoa";
            this.txt_makhoa_xoa.Size = new System.Drawing.Size(116, 22);
            this.txt_makhoa_xoa.TabIndex = 3;
            this.txt_makhoa_xoa.Text = "Mã khoa";
            // 
            // gb_danhsachkhoa
            // 
            this.gb_danhsachkhoa.Controls.Add(this.data_danhsachkhoa);
            this.gb_danhsachkhoa.Location = new System.Drawing.Point(381, 39);
            this.gb_danhsachkhoa.Name = "gb_danhsachkhoa";
            this.gb_danhsachkhoa.Size = new System.Drawing.Size(490, 427);
            this.gb_danhsachkhoa.TabIndex = 4;
            this.gb_danhsachkhoa.TabStop = false;
            this.gb_danhsachkhoa.Text = "Danh sách khoa";
            // 
            // data_danhsachkhoa
            // 
            this.data_danhsachkhoa.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.data_danhsachkhoa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.data_danhsachkhoa.Location = new System.Drawing.Point(7, 22);
            this.data_danhsachkhoa.Name = "data_danhsachkhoa";
            this.data_danhsachkhoa.Size = new System.Drawing.Size(476, 392);
            this.data_danhsachkhoa.TabIndex = 0;
            this.data_danhsachkhoa.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.data_danhsachkhoa_CellClick);
            // 
            // lab_tieude
            // 
            this.lab_tieude.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lab_tieude.ForeColor = System.Drawing.Color.Black;
            this.lab_tieude.Location = new System.Drawing.Point(64, 0);
            this.lab_tieude.Name = "lab_tieude";
            this.lab_tieude.Size = new System.Drawing.Size(807, 26);
            this.lab_tieude.TabIndex = 1;
            this.lab_tieude.Text = "QUẢN LÝ KHOA";
            this.lab_tieude.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lab_tieude.MouseDown += new System.Windows.Forms.MouseEventHandler(this.lab_tieude_MouseDown);
            this.lab_tieude.MouseUp += new System.Windows.Forms.MouseEventHandler(this.lab_tieude_MouseUp);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(-1, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(65, 26);
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
            this.button1.Location = new System.Drawing.Point(817, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(42, 23);
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
            this.button2.Location = new System.Drawing.Point(769, 0);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(42, 23);
            this.button2.TabIndex = 6;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // fkhoa
            // 
            this.AcceptButton = this.but_them;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.CancelButton = this.button1;
            this.ClientSize = new System.Drawing.Size(871, 467);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.gb_danhsachkhoa);
            this.Controls.Add(this.gb_thongtin);
            this.Controls.Add(this.lab_tieude);
            this.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "fkhoa";
            this.Text = "Quản lý khoa";
            this.Load += new System.EventHandler(this.fkhoa_Load);
            this.gb_thongtin.ResumeLayout(false);
            this.gb_thongtin.PerformLayout();
            this.gb_danhsachkhoa.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.data_danhsachkhoa)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lab_tenkhoa;
        private System.Windows.Forms.Button but_them;
        private System.Windows.Forms.TextBox txt_makhoa;
        private System.Windows.Forms.GroupBox gb_thongtin;
        private System.Windows.Forms.Button but_timkiem;
        private System.Windows.Forms.Button but_sua;
        private System.Windows.Forms.Button but_xoa;
        private System.Windows.Forms.Button but_xuat;
        private System.Windows.Forms.Label lab_makhoa;
        private System.Windows.Forms.TextBox txt_tenkhoa;
        private System.Windows.Forms.GroupBox gb_danhsachkhoa;
        private System.Windows.Forms.DataGridView data_danhsachkhoa;
        private System.Windows.Forms.TextBox txt_makhoa_timkiem;
        private System.Windows.Forms.TextBox txt_makhoa_sua;
        private System.Windows.Forms.TextBox txt_makhoa_xoa;
        private System.Windows.Forms.Label lab_tieude;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}