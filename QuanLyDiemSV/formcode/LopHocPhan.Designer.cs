
namespace QuanlyDiemSinhVien
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.title = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.MaLHP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenHocPhan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PhongHoc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SoTC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NgayThi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GiangVien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SoSinhVien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HocKy = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.buttonThem = new System.Windows.Forms.Button();
            this.buttonSua = new System.Windows.Forms.Button();
            this.buttonXoa = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.buttonSearch = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // title
            // 
            this.title.AutoSize = true;
            this.title.Font = new System.Drawing.Font("Times New Roman", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.title.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.title.Location = new System.Drawing.Point(268, 52);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(871, 54);
            this.title.TabIndex = 1;
            this.title.Text = "QUẢN LÝ THÔNG TIN LỚP HỌC PHẦN";
            this.title.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaLHP,
            this.TenHocPhan,
            this.PhongHoc,
            this.SoTC,
            this.NgayThi,
            this.GiangVien,
            this.SoSinhVien,
            this.HocKy});
            this.dataGridView1.Location = new System.Drawing.Point(57, 154);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(1283, 238);
            this.dataGridView1.TabIndex = 2;
            // 
            // MaLHP
            // 
            this.MaLHP.HeaderText = "Mã LHP";
            this.MaLHP.Name = "MaLHP";
            this.MaLHP.ReadOnly = true;
            this.MaLHP.Width = 150;
            // 
            // TenHocPhan
            // 
            this.TenHocPhan.HeaderText = "Tên Học Phần";
            this.TenHocPhan.Name = "TenHocPhan";
            this.TenHocPhan.ReadOnly = true;
            this.TenHocPhan.Width = 250;
            // 
            // PhongHoc
            // 
            this.PhongHoc.HeaderText = "Phòng Học";
            this.PhongHoc.Name = "PhongHoc";
            this.PhongHoc.ReadOnly = true;
            this.PhongHoc.Width = 120;
            // 
            // SoTC
            // 
            this.SoTC.HeaderText = "Số TC";
            this.SoTC.Name = "SoTC";
            this.SoTC.ReadOnly = true;
            // 
            // NgayThi
            // 
            this.NgayThi.HeaderText = "Ngày Thi";
            this.NgayThi.Name = "NgayThi";
            this.NgayThi.ReadOnly = true;
            this.NgayThi.Width = 150;
            // 
            // GiangVien
            // 
            this.GiangVien.HeaderText = "Giảng Viên";
            this.GiangVien.Name = "GiangVien";
            this.GiangVien.ReadOnly = true;
            this.GiangVien.Width = 250;
            // 
            // SoSinhVien
            // 
            this.SoSinhVien.HeaderText = "Số Sinh Viên";
            this.SoSinhVien.Name = "SoSinhVien";
            this.SoSinhVien.ReadOnly = true;
            // 
            // HocKy
            // 
            this.HocKy.HeaderText = "Học Kỳ";
            this.HocKy.Name = "HocKy";
            this.HocKy.ReadOnly = true;
            this.HocKy.Width = 120;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(57, 436);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 19);
            this.label1.TabIndex = 3;
            this.label1.Text = "Mã LHP";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(193, 436);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(187, 26);
            this.textBox1.TabIndex = 4;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(57, 490);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 19);
            this.label2.TabIndex = 5;
            this.label2.Text = "Mã Học Phần";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(57, 541);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 19);
            this.label3.TabIndex = 6;
            this.label3.Text = "Học Kỳ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(433, 436);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 19);
            this.label4.TabIndex = 7;
            this.label4.Text = "Ngày Thi";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(435, 490);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 19);
            this.label5.TabIndex = 8;
            this.label5.Text = "Mã LHP";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(435, 541);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(100, 19);
            this.label6.TabIndex = 9;
            this.label6.Text = "Mã Giảng Viên";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(193, 490);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(187, 26);
            this.textBox2.TabIndex = 10;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(193, 541);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(187, 26);
            this.textBox3.TabIndex = 11;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(581, 436);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(204, 26);
            this.textBox4.TabIndex = 12;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(581, 490);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(204, 26);
            this.textBox5.TabIndex = 13;
            this.textBox5.TextChanged += new System.EventHandler(this.textBox5_TextChanged);
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(581, 541);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(204, 26);
            this.textBox6.TabIndex = 14;
            // 
            // buttonThem
            // 
            this.buttonThem.Location = new System.Drawing.Point(848, 436);
            this.buttonThem.Name = "buttonThem";
            this.buttonThem.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.buttonThem.Size = new System.Drawing.Size(88, 34);
            this.buttonThem.TabIndex = 15;
            this.buttonThem.Text = "Thêm";
            this.buttonThem.UseVisualStyleBackColor = true;
            this.buttonThem.Click += new System.EventHandler(this.buttonThem_Click);
            // 
            // buttonSua
            // 
            this.buttonSua.Location = new System.Drawing.Point(848, 485);
            this.buttonSua.Name = "buttonSua";
            this.buttonSua.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.buttonSua.Size = new System.Drawing.Size(88, 34);
            this.buttonSua.TabIndex = 16;
            this.buttonSua.Text = "Sửa";
            this.buttonSua.UseVisualStyleBackColor = true;
            // 
            // buttonXoa
            // 
            this.buttonXoa.Location = new System.Drawing.Point(848, 536);
            this.buttonXoa.Name = "buttonXoa";
            this.buttonXoa.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.buttonXoa.Size = new System.Drawing.Size(88, 34);
            this.buttonXoa.TabIndex = 17;
            this.buttonXoa.Text = "Xóa";
            this.buttonXoa.UseVisualStyleBackColor = true;
            this.buttonXoa.Click += new System.EventHandler(this.buttonXoa_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(1068, 423);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(218, 23);
            this.label7.TabIndex = 18;
            this.label7.Text = "TÌM KIẾM THÔNG TIN";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(963, 472);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.comboBox1.Size = new System.Drawing.Size(192, 27);
            this.comboBox1.TabIndex = 19;
            this.comboBox1.Text = "Chọn trường cần tìm kiếm";
            // 
            // textBox7
            // 
            this.textBox7.Location = new System.Drawing.Point(1183, 472);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(184, 26);
            this.textBox7.TabIndex = 20;
            // 
            // buttonSearch
            // 
            this.buttonSearch.Location = new System.Drawing.Point(1088, 541);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.buttonSearch.Size = new System.Drawing.Size(153, 34);
            this.buttonSearch.TabIndex = 21;
            this.buttonSearch.Text = "TÌM KIẾM";
            this.buttonSearch.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1399, 632);
            this.Controls.Add(this.buttonSearch);
            this.Controls.Add(this.textBox7);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.buttonXoa);
            this.Controls.Add(this.buttonSua);
            this.Controls.Add(this.buttonThem);
            this.Controls.Add(this.textBox6);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.title);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Name = "Form1";
            this.Text = "Xóa";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label title;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaLHP;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenHocPhan;
        private System.Windows.Forms.DataGridViewTextBoxColumn PhongHoc;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoTC;
        private System.Windows.Forms.DataGridViewTextBoxColumn NgayThi;
        private System.Windows.Forms.DataGridViewTextBoxColumn GiangVien;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoSinhVien;
        private System.Windows.Forms.DataGridViewTextBoxColumn HocKy;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.Button buttonThem;
        private System.Windows.Forms.Button buttonSua;
        private System.Windows.Forms.Button buttonXoa;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.Button buttonSearch;
    }
}

