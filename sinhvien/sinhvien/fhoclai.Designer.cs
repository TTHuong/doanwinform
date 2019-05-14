namespace sinhvien
{
    partial class fhoclai
    {
        ///// <summary>
        ///// Required designer variable.
        ///// </summary>
        //private System.ComponentModel.IContainer components = null;

        ///// <summary>
        ///// Clean up any resources being used.
        ///// </summary>
        ///// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        //protected override void Dispose(bool disposing)
        //{
        //    if (disposing && (components != null))
        //    {
        //        components.Dispose();
        //    }
        //    base.Dispose(disposing);
        //}

        //#region Windows Form Designer generated code

        ///// <summary>
        ///// Required method for Designer support - do not modify
        ///// the contents of this method with the code editor.
        ///// </summary>
        //private void InitializeComponent()
        //{
        //    this.SuspendLayout();
        //    // 
        //    // fhoclai
        //    // 
        //    this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
        //    this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        //    this.ClientSize = new System.Drawing.Size(873, 470);
        //    this.Name = "fhoclai";
        //    this.Text = "fhoclai";
        //    this.ResumeLayout(false);

        //}

        //#endregion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fhoclai));
            this.gb_timkiem = new System.Windows.Forms.GroupBox();
            this.but_timkiem = new System.Windows.Forms.Button();
            this.cb_monhoc = new System.Windows.Forms.ComboBox();
            this.cb_lop = new System.Windows.Forms.ComboBox();
            this.cb_khoa = new System.Windows.Forms.ComboBox();
            this.txt_tensinhvien = new System.Windows.Forms.TextBox();
            this.txt_masinhvien = new System.Windows.Forms.TextBox();
            this.lab_monhoc = new System.Windows.Forms.Label();
            this.lab_lop = new System.Windows.Forms.Label();
            this.lab_khoa = new System.Windows.Forms.Label();
            this.lab_tensinhvien = new System.Windows.Forms.Label();
            this.lab_masinhvien = new System.Windows.Forms.Label();
            this.lab_tieude = new System.Windows.Forms.Label();
            this.data_thongtinsinhvienthilai = new System.Windows.Forms.DataGridView();
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
            this.gb_timkiem.Controls.Add(this.lab_monhoc);
            this.gb_timkiem.Controls.Add(this.lab_lop);
            this.gb_timkiem.Controls.Add(this.lab_khoa);
            this.gb_timkiem.Controls.Add(this.lab_tensinhvien);
            this.gb_timkiem.Controls.Add(this.lab_masinhvien);
            this.gb_timkiem.Location = new System.Drawing.Point(4, 54);
            this.gb_timkiem.Name = "gb_timkiem";
            this.gb_timkiem.Size = new System.Drawing.Size(913, 133);
            this.gb_timkiem.TabIndex = 0;
            this.gb_timkiem.TabStop = false;
            this.gb_timkiem.Text = "Tìm kiếm";
            // 
            // but_timkiem
            // 
            this.but_timkiem.Image = ((System.Drawing.Image)(resources.GetObject("but_timkiem.Image")));
            this.but_timkiem.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.but_timkiem.Location = new System.Drawing.Point(11, 89);
            this.but_timkiem.Name = "but_timkiem";
            this.but_timkiem.Size = new System.Drawing.Size(102, 23);
            this.but_timkiem.TabIndex = 13;
            this.but_timkiem.Text = "Tìm kiếm";
            this.but_timkiem.UseVisualStyleBackColor = true;
            this.but_timkiem.Click += new System.EventHandler(this.but_timkiem_Click_1);
            // 
            // cb_monhoc
            // 
            this.cb_monhoc.FormattingEnabled = true;
            this.cb_monhoc.Location = new System.Drawing.Point(708, 21);
            this.cb_monhoc.Name = "cb_monhoc";
            this.cb_monhoc.Size = new System.Drawing.Size(188, 23);
            this.cb_monhoc.TabIndex = 12;
            this.cb_monhoc.TextChanged += new System.EventHandler(this.cb_monhoc_TextChanged_1);
            // 
            // cb_lop
            // 
            this.cb_lop.FormattingEnabled = true;
            this.cb_lop.Location = new System.Drawing.Point(393, 50);
            this.cb_lop.Name = "cb_lop";
            this.cb_lop.Size = new System.Drawing.Size(236, 23);
            this.cb_lop.TabIndex = 12;
            this.cb_lop.TextChanged += new System.EventHandler(this.cb_lop_TextChanged_1);
            // 
            // cb_khoa
            // 
            this.cb_khoa.FormattingEnabled = true;
            this.cb_khoa.Location = new System.Drawing.Point(393, 18);
            this.cb_khoa.Name = "cb_khoa";
            this.cb_khoa.Size = new System.Drawing.Size(236, 23);
            this.cb_khoa.TabIndex = 12;
            this.cb_khoa.TextChanged += new System.EventHandler(this.cb_khoa_TextChanged_1);
            // 
            // txt_tensinhvien
            // 
            this.txt_tensinhvien.Location = new System.Drawing.Point(109, 50);
            this.txt_tensinhvien.Name = "txt_tensinhvien";
            this.txt_tensinhvien.Size = new System.Drawing.Size(212, 22);
            this.txt_tensinhvien.TabIndex = 11;
            this.txt_tensinhvien.TextChanged += new System.EventHandler(this.txt_tensinhvien_TextChanged_1);
            // 
            // txt_masinhvien
            // 
            this.txt_masinhvien.Location = new System.Drawing.Point(109, 18);
            this.txt_masinhvien.Name = "txt_masinhvien";
            this.txt_masinhvien.Size = new System.Drawing.Size(212, 22);
            this.txt_masinhvien.TabIndex = 11;
            this.txt_masinhvien.TextChanged += new System.EventHandler(this.txt_masinhvien_TextChanged_1);
            // 
            // lab_monhoc
            // 
            this.lab_monhoc.AutoSize = true;
            this.lab_monhoc.Location = new System.Drawing.Point(649, 21);
            this.lab_monhoc.Name = "lab_monhoc";
            this.lab_monhoc.Size = new System.Drawing.Size(53, 15);
            this.lab_monhoc.TabIndex = 10;
            this.lab_monhoc.Text = "Môn học";
            // 
            // lab_lop
            // 
            this.lab_lop.AutoSize = true;
            this.lab_lop.Location = new System.Drawing.Point(334, 50);
            this.lab_lop.Name = "lab_lop";
            this.lab_lop.Size = new System.Drawing.Size(28, 15);
            this.lab_lop.TabIndex = 9;
            this.lab_lop.Text = "Lớp";
            // 
            // lab_khoa
            // 
            this.lab_khoa.AutoSize = true;
            this.lab_khoa.Location = new System.Drawing.Point(334, 18);
            this.lab_khoa.Name = "lab_khoa";
            this.lab_khoa.Size = new System.Drawing.Size(35, 15);
            this.lab_khoa.TabIndex = 8;
            this.lab_khoa.Text = "Khoa";
            // 
            // lab_tensinhvien
            // 
            this.lab_tensinhvien.AutoSize = true;
            this.lab_tensinhvien.Location = new System.Drawing.Point(8, 50);
            this.lab_tensinhvien.Name = "lab_tensinhvien";
            this.lab_tensinhvien.Size = new System.Drawing.Size(80, 15);
            this.lab_tensinhvien.TabIndex = 7;
            this.lab_tensinhvien.Text = "Tên sinh viên";
            // 
            // lab_masinhvien
            // 
            this.lab_masinhvien.AutoSize = true;
            this.lab_masinhvien.Location = new System.Drawing.Point(8, 18);
            this.lab_masinhvien.Name = "lab_masinhvien";
            this.lab_masinhvien.Size = new System.Drawing.Size(76, 15);
            this.lab_masinhvien.TabIndex = 6;
            this.lab_masinhvien.Text = "Mã sinh viên";
            // 
            // lab_tieude
            // 
            this.lab_tieude.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lab_tieude.ForeColor = System.Drawing.Color.Black;
            this.lab_tieude.Location = new System.Drawing.Point(101, 0);
            this.lab_tieude.Name = "lab_tieude";
            this.lab_tieude.Size = new System.Drawing.Size(816, 36);
            this.lab_tieude.TabIndex = 1;
            this.lab_tieude.Text = "THÔNG TIN SINH VIÊN THI LẠI";
            this.lab_tieude.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lab_tieude.MouseDown += new System.Windows.Forms.MouseEventHandler(this.lab_tieude_MouseDown);
            this.lab_tieude.MouseUp += new System.Windows.Forms.MouseEventHandler(this.lab_tieude_MouseUp);
            // 
            // data_thongtinsinhvienthilai
            // 
            this.data_thongtinsinhvienthilai.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.data_thongtinsinhvienthilai.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.data_thongtinsinhvienthilai.Location = new System.Drawing.Point(1, 193);
            this.data_thongtinsinhvienthilai.Name = "data_thongtinsinhvienthilai";
            this.data_thongtinsinhvienthilai.Size = new System.Drawing.Size(916, 303);
            this.data_thongtinsinhvienthilai.TabIndex = 2;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(1, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 36);
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // button1
            // 
            this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button1.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(861, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(38, 23);
            this.button1.TabIndex = 4;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button2.BackgroundImage")));
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Location = new System.Drawing.Point(817, 0);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(38, 23);
            this.button2.TabIndex = 4;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // fhoclai
            // 
            this.AcceptButton = this.but_timkiem;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.CancelButton = this.button1;
            this.ClientSize = new System.Drawing.Size(916, 498);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.data_thongtinsinhvienthilai);
            this.Controls.Add(this.lab_tieude);
            this.Controls.Add(this.gb_timkiem);
            this.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "fhoclai";
            this.Text = "Thông tin sinh viên thi lại";
            this.Load += new System.EventHandler(this.fhoclai_Load);
            this.gb_timkiem.ResumeLayout(false);
            this.gb_timkiem.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.data_thongtinsinhvienthilai)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gb_timkiem;
        private System.Windows.Forms.Label lab_tieude;
        private System.Windows.Forms.Label lab_khoa;
        private System.Windows.Forms.Label lab_tensinhvien;
        private System.Windows.Forms.Label lab_masinhvien;
        private System.Windows.Forms.Label lab_monhoc;
        private System.Windows.Forms.Label lab_lop;
        private System.Windows.Forms.DataGridView data_thongtinsinhvienthilai;
        private System.Windows.Forms.ComboBox cb_monhoc;
        private System.Windows.Forms.ComboBox cb_lop;
        private System.Windows.Forms.ComboBox cb_khoa;
        private System.Windows.Forms.TextBox txt_tensinhvien;
        private System.Windows.Forms.TextBox txt_masinhvien;
        private System.Windows.Forms.Button but_timkiem;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}