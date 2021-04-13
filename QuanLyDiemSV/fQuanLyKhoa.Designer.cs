
namespace QuanLyDiemSV
{
    partial class fQuanLyKhoa
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxNhapMaKhoa = new System.Windows.Forms.TextBox();
            this.textBoxNhapTenKhoa = new System.Windows.Forms.TextBox();
            this.buttonThem = new System.Windows.Forms.Button();
            this.buttonSua = new System.Windows.Forms.Button();
            this.buttonXoa = new System.Windows.Forms.Button();
            this.buttonLuu = new System.Windows.Forms.Button();
            this.buttonThoat = new System.Windows.Forms.Button();
            this.MaKhoa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenKhoa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SoLop = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SoGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bell MT", 20F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label1.Location = new System.Drawing.Point(465, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(390, 46);
            this.label1.TabIndex = 0;
            this.label1.Text = "THÔNG TIN KHOA";

            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(71, 423);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "Mã Khoa";

            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(412, 423);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 25);
            this.label3.TabIndex = 3;
            this.label3.Text = "Tên Khoa";
            // 
            // textBoxNhapMaKhoa
            // 
            this.textBoxNhapMaKhoa.Location = new System.Drawing.Point(195, 423);
            this.textBoxNhapMaKhoa.Name = "textBoxNhapMaKhoa";
            this.textBoxNhapMaKhoa.Size = new System.Drawing.Size(150, 31);
            this.textBoxNhapMaKhoa.TabIndex = 4;
            // 
            // textBoxNhapTenKhoa
            // 
            this.textBoxNhapTenKhoa.Location = new System.Drawing.Point(544, 423);
            this.textBoxNhapTenKhoa.Name = "textBoxNhapTenKhoa";
            this.textBoxNhapTenKhoa.Size = new System.Drawing.Size(150, 31);
            this.textBoxNhapTenKhoa.TabIndex = 5;

            // 
            // buttonThem
            // 
            this.buttonThem.Location = new System.Drawing.Point(776, 388);
            this.buttonThem.Name = "buttonThem";
            this.buttonThem.Size = new System.Drawing.Size(112, 34);
            this.buttonThem.TabIndex = 6;
            this.buttonThem.Text = "Thêm";
            this.buttonThem.UseVisualStyleBackColor = true;
            // 
            // buttonSua
            // 
            this.buttonSua.Location = new System.Drawing.Point(923, 388);
            this.buttonSua.Name = "buttonSua";
            this.buttonSua.Size = new System.Drawing.Size(112, 34);
            this.buttonSua.TabIndex = 7;
            this.buttonSua.Text = "Sửa";
            this.buttonSua.UseVisualStyleBackColor = true;

            // 
            // buttonXoa
            // 
            this.buttonXoa.Location = new System.Drawing.Point(1063, 388);
            this.buttonXoa.Name = "buttonXoa";
            this.buttonXoa.Size = new System.Drawing.Size(112, 34);
            this.buttonXoa.TabIndex = 8;
            this.buttonXoa.Text = "Xóa";
            this.buttonXoa.UseVisualStyleBackColor = true;

            // 
            // buttonLuu
            // 
            this.buttonLuu.Location = new System.Drawing.Point(846, 454);
            this.buttonLuu.Name = "buttonLuu";
            this.buttonLuu.Size = new System.Drawing.Size(112, 34);
            this.buttonLuu.TabIndex = 9;
            this.buttonLuu.Text = "Lưu";
            this.buttonLuu.UseVisualStyleBackColor = true;
            // 
            // buttonThoat
            // 
            this.buttonThoat.Location = new System.Drawing.Point(995, 454);
            this.buttonThoat.Name = "buttonThoat";
            this.buttonThoat.Size = new System.Drawing.Size(112, 34);
            this.buttonThoat.TabIndex = 10;
            this.buttonThoat.Text = "Thoát";
            this.buttonThoat.UseVisualStyleBackColor = true;
            // 
            // MaKhoa
            // 
            this.MaKhoa.HeaderText = "Mã Khoa";
            this.MaKhoa.MinimumWidth = 8;
            this.MaKhoa.Name = "MaKhoa";
            this.MaKhoa.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.MaKhoa.Width = 260;
            // 
            // TenKhoa
            // 
            this.TenKhoa.HeaderText = "Tên Khoa";
            this.TenKhoa.MinimumWidth = 8;
            this.TenKhoa.Name = "TenKhoa";
            this.TenKhoa.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.TenKhoa.Width = 260;
            // 
            // SoLop
            // 
            this.SoLop.HeaderText = "Số Lớp";
            this.SoLop.MinimumWidth = 8;
            this.SoLop.Name = "SoLop";
            this.SoLop.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.SoLop.Width = 260;
            // 
            // SoGV
            // 
            this.SoGV.HeaderText = "Số Giảng Viên";
            this.SoGV.MinimumWidth = 8;
            this.SoGV.Name = "SoGV";
            this.SoGV.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.SoGV.Width = 260;
            // 
            // FormThongTinKhoa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1269, 517);
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaKhoa,
            this.TenKhoa,
            this.SoLop,
            this.SoGV});
            this.dataGridView2.Location = new System.Drawing.Point(71, 115);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersWidth = 62;
            this.dataGridView2.Size = new System.Drawing.Size(1104, 225);
            this.dataGridView2.TabIndex = 11;
            this.dataGridView2.Text = "dataGridView2";
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.buttonThoat);
            this.Controls.Add(this.buttonLuu);
            this.Controls.Add(this.buttonXoa);
            this.Controls.Add(this.buttonSua);
            this.Controls.Add(this.buttonThem);
            this.Controls.Add(this.textBoxNhapTenKhoa);
            this.Controls.Add(this.textBoxNhapMaKhoa);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FormThongTinKhoa";
            this.Text = "FormThongTinKhoa";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxNhapMaKhoa;
        private System.Windows.Forms.TextBox textBoxNhapTenKhoa;
        private System.Windows.Forms.Button buttonThem;
        private System.Windows.Forms.Button buttonSua;
        private System.Windows.Forms.Button buttonXoa;
        private System.Windows.Forms.Button buttonLuu;
        private System.Windows.Forms.Button buttonThoat;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaKhoa;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenKhoa;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoLop;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoGV;
        private System.Windows.Forms.DataGridView dataGridView2;
    }
}