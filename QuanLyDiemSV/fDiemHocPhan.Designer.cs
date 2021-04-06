
namespace QuanLyDiemSV
{
    partial class fDiemHocPhan
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
            this.LabelDiemHP = new System.Windows.Forms.Label();
            this.labelMaLHP = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.buttonTimKiem = new System.Windows.Forms.Button();
            this.txtTimKiem = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.buttonSua = new System.Windows.Forms.Button();
            this.buttonThoat = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.dgvLHP = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLHP)).BeginInit();
            this.SuspendLayout();
            // 
            // LabelDiemHP
            // 
            this.LabelDiemHP.BackColor = System.Drawing.Color.Cornsilk;
            this.LabelDiemHP.Font = new System.Drawing.Font("Bookman Old Style", 20F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelDiemHP.ForeColor = System.Drawing.Color.Red;
            this.LabelDiemHP.Location = new System.Drawing.Point(347, -3);
            this.LabelDiemHP.Name = "LabelDiemHP";
            this.LabelDiemHP.Size = new System.Drawing.Size(358, 52);
            this.LabelDiemHP.TabIndex = 0;
            this.LabelDiemHP.Text = "Điểm Học Phần";
            this.LabelDiemHP.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelMaLHP
            // 
            this.labelMaLHP.BackColor = System.Drawing.Color.Bisque;
            this.labelMaLHP.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMaLHP.ForeColor = System.Drawing.Color.Blue;
            this.labelMaLHP.Location = new System.Drawing.Point(10, 0);
            this.labelMaLHP.Name = "labelMaLHP";
            this.labelMaLHP.Size = new System.Drawing.Size(294, 47);
            this.labelMaLHP.TabIndex = 1;
            this.labelMaLHP.Text = "Nhập vào Mã Lớp Học Phần";
            this.labelMaLHP.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(65, 320);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(100, 17);
            this.label6.TabIndex = 5;
            this.label6.Text = "label6";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.LabelDiemHP);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1064, 52);
            this.panel1.TabIndex = 6;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.buttonTimKiem);
            this.panel2.Controls.Add(this.txtTimKiem);
            this.panel2.Controls.Add(this.labelMaLHP);
            this.panel2.Location = new System.Drawing.Point(12, 67);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1064, 55);
            this.panel2.TabIndex = 7;
            // 
            // buttonTimKiem
            // 
            this.buttonTimKiem.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonTimKiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonTimKiem.ForeColor = System.Drawing.Color.Blue;
            this.buttonTimKiem.Location = new System.Drawing.Point(562, 4);
            this.buttonTimKiem.Name = "buttonTimKiem";
            this.buttonTimKiem.Size = new System.Drawing.Size(102, 43);
            this.buttonTimKiem.TabIndex = 3;
            this.buttonTimKiem.Text = "Tìm Kiếm";
            this.buttonTimKiem.UseVisualStyleBackColor = false;
            this.buttonTimKiem.Click += new System.EventHandler(this.buttonTimKiem_Click);
            // 
            // txtTimKiem
            // 
            this.txtTimKiem.Location = new System.Drawing.Point(335, 3);
            this.txtTimKiem.Multiline = true;
            this.txtTimKiem.Name = "txtTimKiem";
            this.txtTimKiem.Size = new System.Drawing.Size(207, 44);
            this.txtTimKiem.TabIndex = 2;
            this.txtTimKiem.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.buttonSua);
            this.panel3.Controls.Add(this.buttonThoat);
            this.panel3.Location = new System.Drawing.Point(715, 343);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(361, 177);
            this.panel3.TabIndex = 8;
            // 
            // buttonSua
            // 
            this.buttonSua.BackColor = System.Drawing.SystemColors.Info;
            this.buttonSua.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSua.ForeColor = System.Drawing.Color.Brown;
            this.buttonSua.Location = new System.Drawing.Point(3, 15);
            this.buttonSua.Name = "buttonSua";
            this.buttonSua.Size = new System.Drawing.Size(140, 46);
            this.buttonSua.TabIndex = 2;
            this.buttonSua.Text = "Sửa";
            this.buttonSua.UseVisualStyleBackColor = false;
            this.buttonSua.Click += new System.EventHandler(this.buttonSua_Click);
            // 
            // buttonThoat
            // 
            this.buttonThoat.BackColor = System.Drawing.SystemColors.Info;
            this.buttonThoat.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonThoat.ForeColor = System.Drawing.Color.Brown;
            this.buttonThoat.Location = new System.Drawing.Point(167, 15);
            this.buttonThoat.Name = "buttonThoat";
            this.buttonThoat.Size = new System.Drawing.Size(140, 46);
            this.buttonThoat.TabIndex = 1;
            this.buttonThoat.Text = "Thoát";
            this.buttonThoat.UseVisualStyleBackColor = false;
            this.buttonThoat.Click += new System.EventHandler(this.buttonThoat_Click);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.dgvLHP);
            this.panel4.Location = new System.Drawing.Point(12, 124);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1064, 213);
            this.panel4.TabIndex = 9;
            // 
            // dgvLHP
            // 
            this.dgvLHP.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLHP.Cursor = System.Windows.Forms.Cursors.Default;
            this.dgvLHP.Location = new System.Drawing.Point(8, 3);
            this.dgvLHP.MultiSelect = false;
            this.dgvLHP.Name = "dgvLHP";
            this.dgvLHP.RowTemplate.Height = 24;
            this.dgvLHP.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dgvLHP.Size = new System.Drawing.Size(1042, 206);
            this.dgvLHP.TabIndex = 0;
            this.dgvLHP.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvLHP_CellClick);
            this.dgvLHP.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvLHP_CellContentClick);
            // 
            // fDiemHocPhan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CadetBlue;
            this.ClientSize = new System.Drawing.Size(1077, 522);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label6);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.Name = "fDiemHocPhan";
            this.Text = "Quản Lý Điểm Học Phần";
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvLHP)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label LabelDiemHP;
        private System.Windows.Forms.Label labelMaLHP;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button buttonTimKiem;
        private System.Windows.Forms.TextBox txtTimKiem;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.DataGridView dgvLHP;
        private System.Windows.Forms.Button buttonSua;
        private System.Windows.Forms.Button buttonThoat;
    }
}