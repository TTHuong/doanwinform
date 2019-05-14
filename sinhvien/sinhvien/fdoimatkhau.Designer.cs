namespace sinhvien
{
    partial class fdoimatkhau
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fdoimatkhau));
            this.lab_tendangnhap = new System.Windows.Forms.Label();
            this.lab_matkhaulan1 = new System.Windows.Forms.Label();
            this.lab_matkhaulan2 = new System.Windows.Forms.Label();
            this.txt_tendangnhap = new System.Windows.Forms.TextBox();
            this.but_luu = new System.Windows.Forms.Button();
            this.txt_matkhaulan1 = new System.Windows.Forms.TextBox();
            this.txt_matkhaulan2 = new System.Windows.Forms.TextBox();
            this.but_thoat = new System.Windows.Forms.Button();
            this.lab_thongbao = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.but_anmatkhau = new System.Windows.Forms.Button();
            this.but_hienmatkhau = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lab_tendangnhap
            // 
            this.lab_tendangnhap.AutoSize = true;
            this.lab_tendangnhap.Location = new System.Drawing.Point(11, 45);
            this.lab_tendangnhap.Name = "lab_tendangnhap";
            this.lab_tendangnhap.Size = new System.Drawing.Size(86, 15);
            this.lab_tendangnhap.TabIndex = 0;
            this.lab_tendangnhap.Text = "Tên đăng nhập";
            // 
            // lab_matkhaulan1
            // 
            this.lab_matkhaulan1.AutoSize = true;
            this.lab_matkhaulan1.Location = new System.Drawing.Point(11, 93);
            this.lab_matkhaulan1.Name = "lab_matkhaulan1";
            this.lab_matkhaulan1.Size = new System.Drawing.Size(59, 15);
            this.lab_matkhaulan1.TabIndex = 1;
            this.lab_matkhaulan1.Text = "Mật khẩu";
            // 
            // lab_matkhaulan2
            // 
            this.lab_matkhaulan2.AutoSize = true;
            this.lab_matkhaulan2.Location = new System.Drawing.Point(11, 141);
            this.lab_matkhaulan2.Name = "lab_matkhaulan2";
            this.lab_matkhaulan2.Size = new System.Drawing.Size(106, 15);
            this.lab_matkhaulan2.TabIndex = 2;
            this.lab_matkhaulan2.Text = "Nhập lại mật khẩu";
            // 
            // txt_tendangnhap
            // 
            this.txt_tendangnhap.Location = new System.Drawing.Point(185, 45);
            this.txt_tendangnhap.Multiline = true;
            this.txt_tendangnhap.Name = "txt_tendangnhap";
            this.txt_tendangnhap.ReadOnly = true;
            this.txt_tendangnhap.Size = new System.Drawing.Size(333, 22);
            this.txt_tendangnhap.TabIndex = 3;
            // 
            // but_luu
            // 
            this.but_luu.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.but_luu.Image = ((System.Drawing.Image)(resources.GetObject("but_luu.Image")));
            this.but_luu.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.but_luu.Location = new System.Drawing.Point(185, 239);
            this.but_luu.Name = "but_luu";
            this.but_luu.Size = new System.Drawing.Size(87, 27);
            this.but_luu.TabIndex = 6;
            this.but_luu.Text = "Lưu";
            this.but_luu.UseVisualStyleBackColor = true;
            this.but_luu.Click += new System.EventHandler(this.but_luu_Click);
            // 
            // txt_matkhaulan1
            // 
            this.txt_matkhaulan1.Location = new System.Drawing.Point(185, 90);
            this.txt_matkhaulan1.Multiline = true;
            this.txt_matkhaulan1.Name = "txt_matkhaulan1";
            this.txt_matkhaulan1.PasswordChar = '*';
            this.txt_matkhaulan1.Size = new System.Drawing.Size(333, 22);
            this.txt_matkhaulan1.TabIndex = 4;
            // 
            // txt_matkhaulan2
            // 
            this.txt_matkhaulan2.Location = new System.Drawing.Point(185, 138);
            this.txt_matkhaulan2.Multiline = true;
            this.txt_matkhaulan2.Name = "txt_matkhaulan2";
            this.txt_matkhaulan2.PasswordChar = '*';
            this.txt_matkhaulan2.Size = new System.Drawing.Size(333, 22);
            this.txt_matkhaulan2.TabIndex = 5;
            // 
            // but_thoat
            // 
            this.but_thoat.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.but_thoat.Image = ((System.Drawing.Image)(resources.GetObject("but_thoat.Image")));
            this.but_thoat.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.but_thoat.Location = new System.Drawing.Point(431, 239);
            this.but_thoat.Name = "but_thoat";
            this.but_thoat.Size = new System.Drawing.Size(87, 27);
            this.but_thoat.TabIndex = 7;
            this.but_thoat.Text = "Thoát";
            this.but_thoat.UseVisualStyleBackColor = true;
            this.but_thoat.Click += new System.EventHandler(this.but_thoat_Click);
            // 
            // lab_thongbao
            // 
            this.lab_thongbao.AutoSize = true;
            this.lab_thongbao.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lab_thongbao.ForeColor = System.Drawing.Color.Red;
            this.lab_thongbao.Location = new System.Drawing.Point(11, 198);
            this.lab_thongbao.Name = "lab_thongbao";
            this.lab_thongbao.Size = new System.Drawing.Size(424, 24);
            this.lab_thongbao.TabIndex = 10;
            this.lab_thongbao.Text = "2 mật khẩu nhâp  không đúng vui lòng nhập lại";
            this.lab_thongbao.Visible = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(-1, -3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(80, 39);
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(78, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(524, 36);
            this.label1.TabIndex = 12;
            this.label1.Text = "ĐỔI MẬT KHẨU";
            this.label1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.label1_MouseDown);
            this.label1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.label1_MouseUp);
            // 
            // button2
            // 
            this.button2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button2.BackgroundImage")));
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button2.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Location = new System.Drawing.Point(559, 0);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(43, 23);
            this.button2.TabIndex = 11;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // but_anmatkhau
            // 
            this.but_anmatkhau.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("but_anmatkhau.BackgroundImage")));
            this.but_anmatkhau.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.but_anmatkhau.FlatAppearance.BorderSize = 0;
            this.but_anmatkhau.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.but_anmatkhau.Location = new System.Drawing.Point(524, 138);
            this.but_anmatkhau.Name = "but_anmatkhau";
            this.but_anmatkhau.Size = new System.Drawing.Size(49, 23);
            this.but_anmatkhau.TabIndex = 14;
            this.but_anmatkhau.UseVisualStyleBackColor = true;
            this.but_anmatkhau.Click += new System.EventHandler(this.but_anmatkhau_Click);
            // 
            // but_hienmatkhau
            // 
            this.but_hienmatkhau.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("but_hienmatkhau.BackgroundImage")));
            this.but_hienmatkhau.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.but_hienmatkhau.FlatAppearance.BorderSize = 0;
            this.but_hienmatkhau.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.but_hienmatkhau.Location = new System.Drawing.Point(524, 90);
            this.but_hienmatkhau.Name = "but_hienmatkhau";
            this.but_hienmatkhau.Size = new System.Drawing.Size(49, 23);
            this.but_hienmatkhau.TabIndex = 14;
            this.but_hienmatkhau.UseVisualStyleBackColor = true;
            this.but_hienmatkhau.Click += new System.EventHandler(this.but_hienmatkhau_Click);
            // 
            // fdoimatkhau
            // 
            this.AcceptButton = this.but_luu;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.CancelButton = this.button2;
            this.ClientSize = new System.Drawing.Size(601, 273);
            this.Controls.Add(this.but_hienmatkhau);
            this.Controls.Add(this.but_anmatkhau);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lab_thongbao);
            this.Controls.Add(this.but_thoat);
            this.Controls.Add(this.but_luu);
            this.Controls.Add(this.txt_matkhaulan2);
            this.Controls.Add(this.txt_matkhaulan1);
            this.Controls.Add(this.txt_tendangnhap);
            this.Controls.Add(this.lab_matkhaulan2);
            this.Controls.Add(this.lab_matkhaulan1);
            this.Controls.Add(this.lab_tendangnhap);
            this.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "fdoimatkhau";
            this.Text = "Đổi mật khẩu";
            this.Load += new System.EventHandler(this.fdoimatkhau_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lab_tendangnhap;
        private System.Windows.Forms.Label lab_matkhaulan1;
        private System.Windows.Forms.Label lab_matkhaulan2;
        private System.Windows.Forms.TextBox txt_tendangnhap;
        private System.Windows.Forms.Button but_luu;
        private System.Windows.Forms.TextBox txt_matkhaulan1;
        private System.Windows.Forms.TextBox txt_matkhaulan2;
        private System.Windows.Forms.Button but_thoat;
        private System.Windows.Forms.Label lab_thongbao;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button but_anmatkhau;
        private System.Windows.Forms.Button but_hienmatkhau;
    }
}