namespace sinhvien
{
    partial class ftimkiemsinhvien
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ftimkiemsinhvien));
            this.gb_timkiem = new System.Windows.Forms.GroupBox();
            this.but_timkiem = new System.Windows.Forms.Button();
            this.cb_monhoc = new System.Windows.Forms.ComboBox();
            this.cb_lop = new System.Windows.Forms.ComboBox();
            this.cb_khoa = new System.Windows.Forms.ComboBox();
            this.txt_tensinhvien = new System.Windows.Forms.TextBox();
            this.txt_masinhvien = new System.Windows.Forms.TextBox();
            this.lab_lop = new System.Windows.Forms.Label();
            this.lab_tensinhvien = new System.Windows.Forms.Label();
            this.lab_monhoc = new System.Windows.Forms.Label();
            this.lab_khoa = new System.Windows.Forms.Label();
            this.lab_masinhvien = new System.Windows.Forms.Label();
            this.data_thongtinsinhvienthilai = new System.Windows.Forms.DataGridView();
            this.lab_tieude = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.gb_timkiem.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.data_thongtinsinhvienthilai)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // gb_timkiem
            // 
            this.gb_timkiem.Controls.Add(this.but_timkiem);
            this.gb_timkiem.Controls.Add(this.cb_monhoc);
            this.gb_timkiem.Controls.Add(this.cb_lop);
            this.gb_timkiem.Controls.Add(this.cb_khoa);
            this.gb_timkiem.Controls.Add(this.txt_tensinhvien);
            this.gb_timkiem.Controls.Add(this.txt_masinhvien);
            this.gb_timkiem.Controls.Add(this.lab_lop);
            this.gb_timkiem.Controls.Add(this.lab_tensinhvien);
            this.gb_timkiem.Controls.Add(this.lab_monhoc);
            this.gb_timkiem.Controls.Add(this.lab_khoa);
            this.gb_timkiem.Controls.Add(this.lab_masinhvien);
            this.gb_timkiem.Location = new System.Drawing.Point(2, 70);
            this.gb_timkiem.Name = "gb_timkiem";
            this.gb_timkiem.Size = new System.Drawing.Size(1022, 152);
            this.gb_timkiem.TabIndex = 0;
            this.gb_timkiem.TabStop = false;
            this.gb_timkiem.Text = "Tìm kiếm";
            // 
            // but_timkiem
            // 
            this.but_timkiem.Image = ((System.Drawing.Image)(resources.GetObject("but_timkiem.Image")));
            this.but_timkiem.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.but_timkiem.Location = new System.Drawing.Point(29, 100);
            this.but_timkiem.Name = "but_timkiem";
            this.but_timkiem.Size = new System.Drawing.Size(99, 34);
            this.but_timkiem.TabIndex = 0;
            this.but_timkiem.Text = "Tìm kiếm";
            this.but_timkiem.UseVisualStyleBackColor = true;
            this.but_timkiem.Click += new System.EventHandler(this.but_timkiem_Click_1);
            // 
            // cb_monhoc
            // 
            this.cb_monhoc.FormattingEnabled = true;
            this.cb_monhoc.Location = new System.Drawing.Point(814, 23);
            this.cb_monhoc.Name = "cb_monhoc";
            this.cb_monhoc.Size = new System.Drawing.Size(177, 23);
            this.cb_monhoc.TabIndex = 5;
            this.cb_monhoc.TextChanged += new System.EventHandler(this.cb_monhoc_TextChanged_1);
            // 
            // cb_lop
            // 
            this.cb_lop.FormattingEnabled = true;
            this.cb_lop.Location = new System.Drawing.Point(446, 57);
            this.cb_lop.Name = "cb_lop";
            this.cb_lop.Size = new System.Drawing.Size(269, 23);
            this.cb_lop.TabIndex = 4;
            this.cb_lop.TextChanged += new System.EventHandler(this.cb_lop_TextChanged_1);
            // 
            // cb_khoa
            // 
            this.cb_khoa.FormattingEnabled = true;
            this.cb_khoa.Location = new System.Drawing.Point(446, 21);
            this.cb_khoa.Name = "cb_khoa";
            this.cb_khoa.Size = new System.Drawing.Size(269, 23);
            this.cb_khoa.TabIndex = 3;
            this.cb_khoa.TextChanged += new System.EventHandler(this.cb_khoa_TextChanged_1);
            // 
            // txt_tensinhvien
            // 
            this.txt_tensinhvien.Location = new System.Drawing.Point(129, 58);
            this.txt_tensinhvien.Name = "txt_tensinhvien";
            this.txt_tensinhvien.Size = new System.Drawing.Size(224, 22);
            this.txt_tensinhvien.TabIndex = 2;
            this.txt_tensinhvien.TextChanged += new System.EventHandler(this.txt_tensinhvien_TextChanged_1);
            // 
            // txt_masinhvien
            // 
            this.txt_masinhvien.Location = new System.Drawing.Point(129, 23);
            this.txt_masinhvien.Name = "txt_masinhvien";
            this.txt_masinhvien.Size = new System.Drawing.Size(224, 22);
            this.txt_masinhvien.TabIndex = 1;
            this.txt_masinhvien.TextChanged += new System.EventHandler(this.txt_masinhvien_TextChanged_1);
            // 
            // lab_lop
            // 
            this.lab_lop.AutoSize = true;
            this.lab_lop.Location = new System.Drawing.Point(383, 66);
            this.lab_lop.Name = "lab_lop";
            this.lab_lop.Size = new System.Drawing.Size(28, 15);
            this.lab_lop.TabIndex = 9;
            this.lab_lop.Text = "Lớp";
            // 
            // lab_tensinhvien
            // 
            this.lab_tensinhvien.AutoSize = true;
            this.lab_tensinhvien.Location = new System.Drawing.Point(26, 66);
            this.lab_tensinhvien.Name = "lab_tensinhvien";
            this.lab_tensinhvien.Size = new System.Drawing.Size(80, 15);
            this.lab_tensinhvien.TabIndex = 7;
            this.lab_tensinhvien.Text = "Tên sinh viên";
            // 
            // lab_monhoc
            // 
            this.lab_monhoc.AutoSize = true;
            this.lab_monhoc.Location = new System.Drawing.Point(740, 23);
            this.lab_monhoc.Name = "lab_monhoc";
            this.lab_monhoc.Size = new System.Drawing.Size(53, 15);
            this.lab_monhoc.TabIndex = 10;
            this.lab_monhoc.Text = "Môn học";
            // 
            // lab_khoa
            // 
            this.lab_khoa.AutoSize = true;
            this.lab_khoa.Location = new System.Drawing.Point(383, 23);
            this.lab_khoa.Name = "lab_khoa";
            this.lab_khoa.Size = new System.Drawing.Size(35, 15);
            this.lab_khoa.TabIndex = 8;
            this.lab_khoa.Text = "Khoa";
            // 
            // lab_masinhvien
            // 
            this.lab_masinhvien.AutoSize = true;
            this.lab_masinhvien.Location = new System.Drawing.Point(26, 23);
            this.lab_masinhvien.Name = "lab_masinhvien";
            this.lab_masinhvien.Size = new System.Drawing.Size(76, 15);
            this.lab_masinhvien.TabIndex = 6;
            this.lab_masinhvien.Text = "Mã sinh viên";
            // 
            // data_thongtinsinhvienthilai
            // 
            this.data_thongtinsinhvienthilai.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.data_thongtinsinhvienthilai.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.data_thongtinsinhvienthilai.Location = new System.Drawing.Point(2, 230);
            this.data_thongtinsinhvienthilai.Name = "data_thongtinsinhvienthilai";
            this.data_thongtinsinhvienthilai.Size = new System.Drawing.Size(1022, 286);
            this.data_thongtinsinhvienthilai.TabIndex = 1;
            // 
            // lab_tieude
            // 
            this.lab_tieude.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lab_tieude.ForeColor = System.Drawing.Color.Black;
            this.lab_tieude.Location = new System.Drawing.Point(92, 1);
            this.lab_tieude.Name = "lab_tieude";
            this.lab_tieude.Size = new System.Drawing.Size(932, 35);
            this.lab_tieude.TabIndex = 1;
            this.lab_tieude.Text = "TÌM KIẾM DANH SÁCH SINH VIÊN ";
            this.lab_tieude.MouseDown += new System.Windows.Forms.MouseEventHandler(this.lab_tieude_MouseDown);
            this.lab_tieude.MouseUp += new System.Windows.Forms.MouseEventHandler(this.lab_tieude_MouseUp);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(2, 1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(91, 35);
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
            this.button1.Location = new System.Drawing.Point(991, 1);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(33, 23);
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
            this.button2.Location = new System.Drawing.Point(952, 1);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(33, 23);
            this.button2.TabIndex = 3;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // ftimkiemsinhvien
            // 
            this.AcceptButton = this.but_timkiem;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.CancelButton = this.button1;
            this.ClientSize = new System.Drawing.Size(1025, 516);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lab_tieude);
            this.Controls.Add(this.data_thongtinsinhvienthilai);
            this.Controls.Add(this.gb_timkiem);
            this.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ftimkiemsinhvien";
            this.Text = "Danh sách sinh viên";
            this.Load += new System.EventHandler(this.fdanhsachhoclai_Load);
            this.gb_timkiem.ResumeLayout(false);
            this.gb_timkiem.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.data_thongtinsinhvienthilai)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gb_timkiem;
        private System.Windows.Forms.DataGridView data_thongtinsinhvienthilai;
        private System.Windows.Forms.Button but_timkiem;
        private System.Windows.Forms.ComboBox cb_monhoc;
        private System.Windows.Forms.ComboBox cb_lop;
        private System.Windows.Forms.ComboBox cb_khoa;
        private System.Windows.Forms.TextBox txt_tensinhvien;
        private System.Windows.Forms.TextBox txt_masinhvien;
        private System.Windows.Forms.Label lab_lop;
        private System.Windows.Forms.Label lab_tensinhvien;
        private System.Windows.Forms.Label lab_monhoc;
        private System.Windows.Forms.Label lab_khoa;
        private System.Windows.Forms.Label lab_masinhvien;
        private System.Windows.Forms.Label lab_tieude;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}