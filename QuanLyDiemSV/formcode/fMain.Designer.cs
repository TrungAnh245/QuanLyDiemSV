namespace formMain
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.buttonSinhVien = new System.Windows.Forms.Button();
            this.buttonDanhSachHocBong = new System.Windows.Forms.Button();
            this.buttonTimKiemThongTinSV = new System.Windows.Forms.Button();
            this.buttonDiemHocPhan = new System.Windows.Forms.Button();
            this.buttonQuanLyLopChuyenNganh = new System.Windows.Forms.Button();
            this.buttonQuanLyKhoa = new System.Windows.Forms.Button();
            this.buttonQuanLyLopHP = new System.Windows.Forms.Button();
            this.buttonDanhSachCCHT = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.CadetBlue;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1084, 129);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Coral;
            this.label1.Font = new System.Drawing.Font("Segoe Script", 25.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Cornsilk;
            this.label1.Location = new System.Drawing.Point(3, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1078, 109);
            this.label1.TabIndex = 0;
            this.label1.Text = "CHƯƠNG TRÌNH QUẢN LÝ ĐIỂM SINH VIÊN";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.CadetBlue;
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Location = new System.Drawing.Point(2, 137);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(358, 391);
            this.panel2.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.buttonDanhSachCCHT);
            this.panel3.Controls.Add(this.buttonQuanLyLopHP);
            this.panel3.Controls.Add(this.buttonQuanLyKhoa);
            this.panel3.Controls.Add(this.buttonQuanLyLopChuyenNganh);
            this.panel3.Controls.Add(this.buttonDiemHocPhan);
            this.panel3.Controls.Add(this.buttonTimKiemThongTinSV);
            this.panel3.Controls.Add(this.buttonDanhSachHocBong);
            this.panel3.Controls.Add(this.buttonSinhVien);
            this.panel3.Location = new System.Drawing.Point(366, 137);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(720, 391);
            this.panel3.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.OrangeRed;
            this.label2.Location = new System.Drawing.Point(3, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(352, 138);
            this.label2.TabIndex = 0;
            this.label2.Text = "Nhấn chọn các thông tin cần xem ";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(82, 150);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(273, 238);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // buttonSinhVien
            // 
            this.buttonSinhVien.Font = new System.Drawing.Font("Comic Sans MS", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSinhVien.ForeColor = System.Drawing.SystemColors.GrayText;
            this.buttonSinhVien.Location = new System.Drawing.Point(380, 150);
            this.buttonSinhVien.Name = "buttonSinhVien";
            this.buttonSinhVien.Size = new System.Drawing.Size(329, 39);
            this.buttonSinhVien.TabIndex = 9;
            this.buttonSinhVien.Text = "Quản Lý Sinh Viên";
            this.buttonSinhVien.UseVisualStyleBackColor = true;
            // 
            // buttonDanhSachHocBong
            // 
            this.buttonDanhSachHocBong.Font = new System.Drawing.Font("Comic Sans MS", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDanhSachHocBong.ForeColor = System.Drawing.SystemColors.GrayText;
            this.buttonDanhSachHocBong.Location = new System.Drawing.Point(380, 248);
            this.buttonDanhSachHocBong.Name = "buttonDanhSachHocBong";
            this.buttonDanhSachHocBong.Size = new System.Drawing.Size(329, 39);
            this.buttonDanhSachHocBong.TabIndex = 11;
            this.buttonDanhSachHocBong.Text = "Danh Sách Học Bổng";
            this.buttonDanhSachHocBong.UseVisualStyleBackColor = true;
            // 
            // buttonTimKiemThongTinSV
            // 
            this.buttonTimKiemThongTinSV.Font = new System.Drawing.Font("Comic Sans MS", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonTimKiemThongTinSV.ForeColor = System.Drawing.SystemColors.GrayText;
            this.buttonTimKiemThongTinSV.Location = new System.Drawing.Point(380, 341);
            this.buttonTimKiemThongTinSV.Name = "buttonTimKiemThongTinSV";
            this.buttonTimKiemThongTinSV.Size = new System.Drawing.Size(329, 39);
            this.buttonTimKiemThongTinSV.TabIndex = 13;
            this.buttonTimKiemThongTinSV.Text = "Tìm Kiếm Thông Tin Sinh Viên";
            this.buttonTimKiemThongTinSV.UseVisualStyleBackColor = true;
            // 
            // buttonDiemHocPhan
            // 
            this.buttonDiemHocPhan.Font = new System.Drawing.Font("Comic Sans MS", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDiemHocPhan.ForeColor = System.Drawing.SystemColors.GrayText;
            this.buttonDiemHocPhan.Location = new System.Drawing.Point(380, 62);
            this.buttonDiemHocPhan.Name = "buttonDiemHocPhan";
            this.buttonDiemHocPhan.Size = new System.Drawing.Size(329, 39);
            this.buttonDiemHocPhan.TabIndex = 14;
            this.buttonDiemHocPhan.Text = "Quản Lý Điểm Học Phần";
            this.buttonDiemHocPhan.UseVisualStyleBackColor = true;
            this.buttonDiemHocPhan.Click += new System.EventHandler(this.button1_Click);
            // 
            // buttonQuanLyLopChuyenNganh
            // 
            this.buttonQuanLyLopChuyenNganh.Font = new System.Drawing.Font("Comic Sans MS", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonQuanLyLopChuyenNganh.ForeColor = System.Drawing.SystemColors.GrayText;
            this.buttonQuanLyLopChuyenNganh.Location = new System.Drawing.Point(13, 20);
            this.buttonQuanLyLopChuyenNganh.Name = "buttonQuanLyLopChuyenNganh";
            this.buttonQuanLyLopChuyenNganh.Size = new System.Drawing.Size(329, 39);
            this.buttonQuanLyLopChuyenNganh.TabIndex = 15;
            this.buttonQuanLyLopChuyenNganh.Text = "Quản Lý Lớp Chuyên Ngành";
            this.buttonQuanLyLopChuyenNganh.UseVisualStyleBackColor = true;
            // 
            // buttonQuanLyKhoa
            // 
            this.buttonQuanLyKhoa.Font = new System.Drawing.Font("Comic Sans MS", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonQuanLyKhoa.ForeColor = System.Drawing.SystemColors.GrayText;
            this.buttonQuanLyKhoa.Location = new System.Drawing.Point(13, 108);
            this.buttonQuanLyKhoa.Name = "buttonQuanLyKhoa";
            this.buttonQuanLyKhoa.Size = new System.Drawing.Size(329, 39);
            this.buttonQuanLyKhoa.TabIndex = 17;
            this.buttonQuanLyKhoa.Text = "Quản Lý Khoa";
            this.buttonQuanLyKhoa.UseVisualStyleBackColor = true;
            // 
            // buttonQuanLyLopHP
            // 
            this.buttonQuanLyLopHP.Font = new System.Drawing.Font("Comic Sans MS", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonQuanLyLopHP.ForeColor = System.Drawing.SystemColors.GrayText;
            this.buttonQuanLyLopHP.Location = new System.Drawing.Point(13, 200);
            this.buttonQuanLyLopHP.Name = "buttonQuanLyLopHP";
            this.buttonQuanLyLopHP.Size = new System.Drawing.Size(329, 39);
            this.buttonQuanLyLopHP.TabIndex = 18;
            this.buttonQuanLyLopHP.Text = "Quản Lý Lớp Học Phần";
            this.buttonQuanLyLopHP.UseVisualStyleBackColor = true;
            // 
            // buttonDanhSachCCHT
            // 
            this.buttonDanhSachCCHT.Font = new System.Drawing.Font("Comic Sans MS", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDanhSachCCHT.ForeColor = System.Drawing.SystemColors.GrayText;
            this.buttonDanhSachCCHT.Location = new System.Drawing.Point(13, 292);
            this.buttonDanhSachCCHT.Name = "buttonDanhSachCCHT";
            this.buttonDanhSachCCHT.Size = new System.Drawing.Size(329, 39);
            this.buttonDanhSachCCHT.TabIndex = 19;
            this.buttonDanhSachCCHT.Text = "Danh Sách Cảnh Cáo Học Tập";
            this.buttonDanhSachCCHT.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CadetBlue;
            this.ClientSize = new System.Drawing.Size(1087, 529);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button buttonDanhSachCCHT;
        private System.Windows.Forms.Button buttonQuanLyLopHP;
        private System.Windows.Forms.Button buttonQuanLyKhoa;
        private System.Windows.Forms.Button buttonQuanLyLopChuyenNganh;
        private System.Windows.Forms.Button buttonDiemHocPhan;
        private System.Windows.Forms.Button buttonTimKiemThongTinSV;
        private System.Windows.Forms.Button buttonDanhSachHocBong;
        private System.Windows.Forms.Button buttonSinhVien;
    }
}

