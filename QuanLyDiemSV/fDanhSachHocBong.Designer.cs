
namespace QuanLyDiemSV
{
    partial class fDanhSachHocBong
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
            this.bntTim = new System.Windows.Forms.Button();
            this.txtTim = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dgvDSHB = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSHB)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bell MT", 20F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.label1.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label1.Location = new System.Drawing.Point(106, 34);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(266, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Danh Sách Học Bổng";
            // 
            // bntTim
            // 
            this.bntTim.Location = new System.Drawing.Point(517, 42);
            this.bntTim.Margin = new System.Windows.Forms.Padding(2);
            this.bntTim.Name = "bntTim";
            this.bntTim.Size = new System.Drawing.Size(94, 23);
            this.bntTim.TabIndex = 2;
            this.bntTim.Text = "Lấy Thông Tin";
            this.bntTim.UseVisualStyleBackColor = true;
            this.bntTim.Click += new System.EventHandler(this.bntTim_Click);
            // 
            // txtTim
            // 
            this.txtTim.Location = new System.Drawing.Point(382, 42);
            this.txtTim.Margin = new System.Windows.Forms.Padding(2);
            this.txtTim.Name = "txtTim";
            this.txtTim.Size = new System.Drawing.Size(117, 20);
            this.txtTim.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(410, 18);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Mã Học Kỳ";
            // 
            // dgvDSHB
            // 
            this.dgvDSHB.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDSHB.Location = new System.Drawing.Point(11, 113);
            this.dgvDSHB.Margin = new System.Windows.Forms.Padding(2);
            this.dgvDSHB.Name = "dgvDSHB";
            this.dgvDSHB.RowHeadersWidth = 62;
            this.dgvDSHB.Size = new System.Drawing.Size(714, 245);
            this.dgvDSHB.TabIndex = 1;
            this.dgvDSHB.Text = "dataGridView1";
            // 
            // fDanhSachHocBong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(737, 369);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtTim);
            this.Controls.Add(this.bntTim);
            this.Controls.Add(this.dgvDSHB);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "fDanhSachHocBong";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSHB)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button bntTim;
        private System.Windows.Forms.TextBox txtTim;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgvDSHB;
    }
}