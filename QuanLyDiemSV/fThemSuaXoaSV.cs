using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyDiemSV
{
    public partial class fThemSuaXoaSV : Form
    {
        QLDiemSVCon db = new QLDiemSVCon();
        public fThemSuaXoaSV()
        {
            InitializeComponent();
        }
        private void loadList()
        {
            string key = txtTim.Text.ToString().Trim();
            if (rbtLop.Checked)
            {
                var rs = db.viewWithClass(key);
                dgvDS.DataSource = rs.ToList();
                dgvDS.Columns[0].HeaderText = "Mã Sinh Viên";
                dgvDS.Columns[1].HeaderText = "Họ Tên";
                dgvDS.Columns[2].HeaderText = "Giới Tính";
                dgvDS.Columns[3].HeaderText = "Ngày Sinh";
                dgvDS.Columns[4].HeaderText = "Số TC ĐKi";
                dgvDS.Columns[5].HeaderText = "Số TC Đạt";
                dgvDS.Columns[6].HeaderText = "Mã Lớp";
                dgvDS.Columns[7].HeaderText = "Tên Khoa";
                return;
            }
            else if (rbtMaSV.Checked)
            {
                var rs = db.viewProfile(key);
                dgvDS.DataSource = rs.ToList();
                dgvDS.Columns[0].HeaderText = "Họ Tên";
                dgvDS.Columns[1].HeaderText = "Ngày Sinh";
                dgvDS.Columns[2].HeaderText = "Giới Tính";
                dgvDS.Columns[3].HeaderText = "Điểm TL";
                dgvDS.Columns[4].HeaderText = "Số TC ĐKi";
                dgvDS.Columns[5].HeaderText = "Số TC Đạt";
                dgvDS.Columns[6].HeaderText = "Mã Lớp";
                dgvDS.Columns[7].HeaderText = "Tên Khoa";
                return;
            }
        }
        private void btnTim_Click(object sender, EventArgs e)
        {
            loadList();
        }

        private void fThemSuaXoaSV_Load(object sender, EventArgs e)
        {
 
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            txtGioiTinh.Text = "";
            txtMaLop.Text = "";
            txtMaSV.Text = "";
            txtNgaySinh.Text = "";
            txtTen.Text = "";
        }

        private void dgvDS_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (dgvDS.SelectedRows.Count > 0 && rbtLop.Checked)
            {
                DataGridViewRow rowT = dgvDS.SelectedRows[0];
                txtMaSV.Text = rowT.Cells[0].Value.ToString();
                txtTen.Text = rowT.Cells[1].Value.ToString();
                txtMaLop.Text= rowT.Cells[6].Value.ToString();
                txtNgaySinh.Text = String.Format("{0:dd/MM/yyyy}", (rowT.Cells[3].Value));
                txtGioiTinh.Text= rowT.Cells[2].Value.ToString();
            }
            else if(dgvDS.SelectedRows.Count > 0 && rbtMaSV.Checked)
            {
                DataGridViewRow rowT = dgvDS.SelectedRows[0];
                txtMaSV.Text = txtTim.Text;
                txtTen.Text = rowT.Cells[0].Value.ToString();
                txtMaLop.Text = rowT.Cells[6].Value.ToString();
                txtNgaySinh.Text =String.Format( "{0:dd/MM/yyyy}",(rowT.Cells[1].Value));
                txtGioiTinh.Text = rowT.Cells[2].Value.ToString();
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            string maSV = txtMaSV.Text.Trim();
            string maLop = txtMaLop.Text.Trim();
            string ten = txtTen.Text.Trim();
            DateTime dt =DateTime.ParseExact(txtNgaySinh.Text, "dd/MM/yyyy", null);
            string GT = txtGioiTinh.Text.Trim();
            db.addSV(maSV, ten, maLop, dt, GT);
            MessageBox.Show("Thêm thành công !");
            loadList();
        }

        private void bntSua_Click(object sender, EventArgs e)
        {

            string maSV = txtMaSV.Text.Trim();
            string maLop = txtMaLop.Text.Trim();
            string ten = txtTen.Text.Trim();
            DateTime dt = DateTime.ParseExact(txtNgaySinh.Text, "dd/MM/yyyy", null);
            string GT = txtGioiTinh.Text.Trim();
            
            var temp = db.SinhViens.Find(maSV);
            if (temp != null)
            {
                db.updSV(maSV, ten, maLop, dt, GT);
                MessageBox.Show("Sửa thành công !");
            }
            else
            {
                MessageBox.Show("Mã sinh viên không tồn tại!");
            }
            loadList();
        }

        private void bntXoa_Click(object sender, EventArgs e)
        {

            string maSV = txtMaSV.Text.Trim();
            var temp = db.SinhViens.Find(maSV);
            if (temp != null)
            {
                db.delSV(maSV);
                MessageBox.Show("Xóa thành công !");
            }
            else
            {
                MessageBox.Show("Mã sinh viên không tồn tại!");
            }
            loadList();
        }
    }
}
