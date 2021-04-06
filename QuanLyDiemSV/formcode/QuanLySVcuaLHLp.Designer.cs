namespace FormThemSinhVienVaoLHP
{
    partial class QuanLySVcuaLHLp
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btnKiemTra = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txtMaSV = new System.Windows.Forms.TextBox();
            this.txtHienThiMaSV = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.txtHienThiNgaySinh = new System.Windows.Forms.TextBox();
            this.txtHienThiTenSV = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtHienThiLop = new System.Windows.Forms.Label();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(2, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1004, 75);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(405, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(145, 44);
            this.label1.TabIndex = 0;
            this.label1.Text = "Thêm Sinh Viên Vào Lớp Học Phần";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(-1, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(235, 36);
            this.label2.TabIndex = 1;
            this.label2.Text = "Danh Sách Lớp";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dataGridView1);
            this.panel2.Location = new System.Drawing.Point(2, 120);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1004, 227);
            this.panel2.TabIndex = 2;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.txtHienThiLop);
            this.panel3.Controls.Add(this.label6);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.txtHienThiTenSV);
            this.panel3.Controls.Add(this.txtHienThiNgaySinh);
            this.panel3.Controls.Add(this.textBox3);
            this.panel3.Controls.Add(this.txtHienThiMaSV);
            this.panel3.Location = new System.Drawing.Point(271, 353);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(505, 130);
            this.panel3.TabIndex = 6;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.btnKiemTra);
            this.panel4.Controls.Add(this.label3);
            this.panel4.Controls.Add(this.txtMaSV);
            this.panel4.Location = new System.Drawing.Point(2, 353);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(263, 130);
            this.panel4.TabIndex = 7;
            // 
            // btnKiemTra
            // 
            this.btnKiemTra.Location = new System.Drawing.Point(187, 10);
            this.btnKiemTra.Name = "btnKiemTra";
            this.btnKiemTra.Size = new System.Drawing.Size(73, 108);
            this.btnKiemTra.TabIndex = 8;
            this.btnKiemTra.Text = "Kiểm Tra Thông Tin";
            this.btnKiemTra.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(16, 11);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(153, 37);
            this.label3.TabIndex = 7;
            this.label3.Text = "Mã Sinh Viên Cần Thêm";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtMaSV
            // 
            this.txtMaSV.Location = new System.Drawing.Point(15, 61);
            this.txtMaSV.Multiline = true;
            this.txtMaSV.Name = "txtMaSV";
            this.txtMaSV.Size = new System.Drawing.Size(154, 58);
            this.txtMaSV.TabIndex = 6;
            this.txtMaSV.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtHienThiMaSV
            // 
            this.txtHienThiMaSV.Location = new System.Drawing.Point(124, 18);
            this.txtHienThiMaSV.Multiline = true;
            this.txtHienThiMaSV.Name = "txtHienThiMaSV";
            this.txtHienThiMaSV.Size = new System.Drawing.Size(111, 40);
            this.txtHienThiMaSV.TabIndex = 0;
            this.txtHienThiMaSV.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(372, 79);
            this.textBox3.Multiline = true;
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(111, 40);
            this.textBox3.TabIndex = 1;
            // 
            // txtHienThiNgaySinh
            // 
            this.txtHienThiNgaySinh.Location = new System.Drawing.Point(124, 75);
            this.txtHienThiNgaySinh.Multiline = true;
            this.txtHienThiNgaySinh.Name = "txtHienThiNgaySinh";
            this.txtHienThiNgaySinh.Size = new System.Drawing.Size(111, 40);
            this.txtHienThiNgaySinh.TabIndex = 2;
            this.txtHienThiNgaySinh.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtHienThiTenSV
            // 
            this.txtHienThiTenSV.Location = new System.Drawing.Point(372, 18);
            this.txtHienThiTenSV.Multiline = true;
            this.txtHienThiTenSV.Name = "txtHienThiTenSV";
            this.txtHienThiTenSV.Size = new System.Drawing.Size(111, 40);
            this.txtHienThiTenSV.TabIndex = 3;
            this.txtHienThiTenSV.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(11, 18);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(95, 40);
            this.label4.TabIndex = 4;
            this.label4.Text = "Mã SV";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(11, 75);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(95, 40);
            this.label5.TabIndex = 5;
            this.label5.Text = "Ngày Sinh";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(257, 18);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(95, 40);
            this.label6.TabIndex = 6;
            this.label6.Text = "Tên Sinh Viên";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtHienThiLop
            // 
            this.txtHienThiLop.Location = new System.Drawing.Point(257, 75);
            this.txtHienThiLop.Name = "txtHienThiLop";
            this.txtHienThiLop.Size = new System.Drawing.Size(95, 40);
            this.txtHienThiLop.TabIndex = 7;
            this.txtHienThiLop.Text = "Lớp";
            this.txtHienThiLop.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(797, 353);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(93, 58);
            this.btnThem.TabIndex = 8;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(903, 419);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(93, 58);
            this.btnXoa.TabIndex = 9;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column7,
            this.Column8,
            this.Column9});
            this.dataGridView1.Location = new System.Drawing.Point(29, 6);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(944, 221);
            this.dataGridView1.TabIndex = 0;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Mã Sinh Viên";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Tên Sinh Viên";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Ngày Sinh";
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Điểm CC";
            this.Column4.Name = "Column4";
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Điểm TX";
            this.Column5.Name = "Column5";
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Điểm Thi";
            this.Column6.Name = "Column6";
            // 
            // Column7
            // 
            this.Column7.HeaderText = "Điểm Hệ 10";
            this.Column7.Name = "Column7";
            // 
            // Column8
            // 
            this.Column8.HeaderText = "Điểm Hệ 4";
            this.Column8.Name = "Column8";
            // 
            // Column9
            // 
            this.Column9.HeaderText = "Điểm Chữ";
            this.Column9.Name = "Column9";
            // 
            // QuanLySVcuaLHLp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 486);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.Name = "QuanLySVcuaLHLp";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label txtHienThiLop;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtHienThiTenSV;
        private System.Windows.Forms.TextBox txtHienThiNgaySinh;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox txtHienThiMaSV;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button btnKiemTra;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtMaSV;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column9;
    }
}

