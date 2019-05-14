namespace sinhvien
{
    partial class fdangnhap
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fdangnhap));
            this.lab_tendangnhap = new System.Windows.Forms.Label();
            this.lab_matkhau = new System.Windows.Forms.Label();
            this.txt_matkhau = new System.Windows.Forms.TextBox();
            this.txt_tendangnhap = new System.Windows.Forms.TextBox();
            this.but_dangnhap = new System.Windows.Forms.Button();
            this.but_thoat = new System.Windows.Forms.Button();
            this.but_anmatkhau = new System.Windows.Forms.Button();
            this.but_hienthimatkhau = new System.Windows.Forms.Button();
            this.but_exit = new System.Windows.Forms.Button();
            this.but_anform = new System.Windows.Forms.Button();
            this.lab_tieude = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lab_tendangnhap
            // 
            this.lab_tendangnhap.Image = ((System.Drawing.Image)(resources.GetObject("lab_tendangnhap.Image")));
            this.lab_tendangnhap.Location = new System.Drawing.Point(9, 58);
            this.lab_tendangnhap.Name = "lab_tendangnhap";
            this.lab_tendangnhap.Size = new System.Drawing.Size(86, 37);
            this.lab_tendangnhap.TabIndex = 0;
            // 
            // lab_matkhau
            // 
            this.lab_matkhau.Image = ((System.Drawing.Image)(resources.GetObject("lab_matkhau.Image")));
            this.lab_matkhau.Location = new System.Drawing.Point(12, 123);
            this.lab_matkhau.Name = "lab_matkhau";
            this.lab_matkhau.Size = new System.Drawing.Size(83, 40);
            this.lab_matkhau.TabIndex = 0;
            // 
            // txt_matkhau
            // 
            this.txt_matkhau.Location = new System.Drawing.Point(101, 123);
            this.txt_matkhau.Multiline = true;
            this.txt_matkhau.Name = "txt_matkhau";
            this.txt_matkhau.Size = new System.Drawing.Size(328, 40);
            this.txt_matkhau.TabIndex = 2;
            this.txt_matkhau.Text = "Vui lòng nhập mật khẩu";
            // 
            // txt_tendangnhap
            // 
            this.txt_tendangnhap.Location = new System.Drawing.Point(101, 58);
            this.txt_tendangnhap.Multiline = true;
            this.txt_tendangnhap.Name = "txt_tendangnhap";
            this.txt_tendangnhap.Size = new System.Drawing.Size(328, 37);
            this.txt_tendangnhap.TabIndex = 1;
            this.txt_tendangnhap.Text = "Vui lòng nhập tên đăng nhập vào";
            // 
            // but_dangnhap
            // 
            this.but_dangnhap.Image = ((System.Drawing.Image)(resources.GetObject("but_dangnhap.Image")));
            this.but_dangnhap.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.but_dangnhap.Location = new System.Drawing.Point(101, 186);
            this.but_dangnhap.Name = "but_dangnhap";
            this.but_dangnhap.Size = new System.Drawing.Size(129, 42);
            this.but_dangnhap.TabIndex = 3;
            this.but_dangnhap.Text = "Đăng nhập";
            this.but_dangnhap.UseVisualStyleBackColor = true;
            this.but_dangnhap.Click += new System.EventHandler(this.but_dangnhap_Click);
            // 
            // but_thoat
            // 
            this.but_thoat.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.but_thoat.Image = ((System.Drawing.Image)(resources.GetObject("but_thoat.Image")));
            this.but_thoat.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.but_thoat.Location = new System.Drawing.Point(313, 186);
            this.but_thoat.Name = "but_thoat";
            this.but_thoat.Size = new System.Drawing.Size(116, 42);
            this.but_thoat.TabIndex = 4;
            this.but_thoat.Text = "Thoát";
            this.but_thoat.UseVisualStyleBackColor = true;
            this.but_thoat.Click += new System.EventHandler(this.but_thoat_Click);
            // 
            // but_anmatkhau
            // 
            this.but_anmatkhau.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.but_anmatkhau.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("but_anmatkhau.BackgroundImage")));
            this.but_anmatkhau.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.but_anmatkhau.FlatAppearance.BorderSize = 0;
            this.but_anmatkhau.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.but_anmatkhau.Location = new System.Drawing.Point(433, 123);
            this.but_anmatkhau.Name = "but_anmatkhau";
            this.but_anmatkhau.Size = new System.Drawing.Size(49, 27);
            this.but_anmatkhau.TabIndex = 0;
            this.but_anmatkhau.UseVisualStyleBackColor = false;
            this.but_anmatkhau.Click += new System.EventHandler(this.but_anmatkhau_Click);
            // 
            // but_hienthimatkhau
            // 
            this.but_hienthimatkhau.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.but_hienthimatkhau.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("but_hienthimatkhau.BackgroundImage")));
            this.but_hienthimatkhau.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.but_hienthimatkhau.FlatAppearance.BorderSize = 0;
            this.but_hienthimatkhau.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.but_hienthimatkhau.Location = new System.Drawing.Point(433, 123);
            this.but_hienthimatkhau.Name = "but_hienthimatkhau";
            this.but_hienthimatkhau.Size = new System.Drawing.Size(49, 27);
            this.but_hienthimatkhau.TabIndex = 0;
            this.but_hienthimatkhau.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.but_hienthimatkhau.UseVisualStyleBackColor = false;
            this.but_hienthimatkhau.Click += new System.EventHandler(this.but_hienthimatkhau_Click);
            // 
            // but_exit
            // 
            this.but_exit.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.but_exit.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("but_exit.BackgroundImage")));
            this.but_exit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.but_exit.FlatAppearance.BorderSize = 0;
            this.but_exit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.but_exit.Location = new System.Drawing.Point(461, 1);
            this.but_exit.Name = "but_exit";
            this.but_exit.Size = new System.Drawing.Size(33, 34);
            this.but_exit.TabIndex = 0;
            this.but_exit.UseVisualStyleBackColor = false;
            this.but_exit.Click += new System.EventHandler(this.but_exit_Click);
            // 
            // but_anform
            // 
            this.but_anform.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.but_anform.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("but_anform.BackgroundImage")));
            this.but_anform.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.but_anform.FlatAppearance.BorderSize = 0;
            this.but_anform.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.but_anform.Location = new System.Drawing.Point(410, 1);
            this.but_anform.Name = "but_anform";
            this.but_anform.Size = new System.Drawing.Size(54, 34);
            this.but_anform.TabIndex = 0;
            this.but_anform.UseVisualStyleBackColor = false;
            this.but_anform.Click += new System.EventHandler(this.but_anform_Click);
            // 
            // lab_tieude
            // 
            this.lab_tieude.Location = new System.Drawing.Point(77, 1);
            this.lab_tieude.Name = "lab_tieude";
            this.lab_tieude.Size = new System.Drawing.Size(336, 34);
            this.lab_tieude.TabIndex = 0;
            this.lab_tieude.Text = "ĐĂNG NHẬP";
            this.lab_tieude.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lab_tieude.MouseDown += new System.Windows.Forms.MouseEventHandler(this.lab_tieude_MouseDown);
            this.lab_tieude.MouseUp += new System.Windows.Forms.MouseEventHandler(this.lab_tieude_MouseUp);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(1, 1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(77, 34);
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // fdangnhap
            // 
            this.AcceptButton = this.but_dangnhap;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.CancelButton = this.but_thoat;
            this.ClientSize = new System.Drawing.Size(494, 246);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lab_tieude);
            this.Controls.Add(this.but_anform);
            this.Controls.Add(this.but_exit);
            this.Controls.Add(this.but_anmatkhau);
            this.Controls.Add(this.but_hienthimatkhau);
            this.Controls.Add(this.but_thoat);
            this.Controls.Add(this.but_dangnhap);
            this.Controls.Add(this.txt_tendangnhap);
            this.Controls.Add(this.txt_matkhau);
            this.Controls.Add(this.lab_matkhau);
            this.Controls.Add(this.lab_tendangnhap);
            this.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Name = "fdangnhap";
            this.Text = "Đăng nhập";
            this.Load += new System.EventHandler(this.dangnhap_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lab_tendangnhap;
        private System.Windows.Forms.Label lab_matkhau;
        private System.Windows.Forms.TextBox txt_matkhau;
        private System.Windows.Forms.TextBox txt_tendangnhap;
        private System.Windows.Forms.Button but_dangnhap;
        private System.Windows.Forms.Button but_thoat;
        private System.Windows.Forms.Button but_anmatkhau;
        private System.Windows.Forms.Button but_hienthimatkhau;
        private System.Windows.Forms.Button but_exit;
        private System.Windows.Forms.Button but_anform;
        private System.Windows.Forms.Label lab_tieude;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}