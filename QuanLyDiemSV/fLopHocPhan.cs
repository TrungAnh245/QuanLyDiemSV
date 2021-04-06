using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyDiemSV
{
    public partial class fLopHocPhan : Form
    {
        private static QLDiemSVCon db = new QLDiemSVCon();
        public fLopHocPhan()
        {
            InitializeComponent();
        }

        private void dataGridView1_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            fQuanLySinhVienLHP f = new fQuanLySinhVienLHP();

            int r = e.RowIndex;
            DataGridViewCell cell = ((DataGridView)sender)[0, r];
            string maLopTemp = cell.Value.ToString();
            f.maLop = maLopTemp;
            f.ShowDialog();
        }

        private void fLopHocPhan_Load(object sender, EventArgs e)
        {

        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            string key = txtTim.Text.Trim();
            dgvLHP.DataSource = db.viewHP(key).ToList();
            dgvLHP.Columns[0].HeaderText = "Mã LHP";
            dgvLHP.Columns[1].HeaderText = "Phòng Học";
            dgvLHP.Columns[2].HeaderText = "Ngày Thi";
            dgvLHP.Columns[3].HeaderText = "Học Kỳ";
            dgvLHP.Columns[4].HeaderText = "Số Sinh Viên";
            dgvLHP.Columns[5].HeaderText = "Tên Học Phần";
            dgvLHP.Columns[6].HeaderText = "Giảng Viên";
        }

        private void dgvLHP_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvLHP.SelectedRows.Count > 0)
            {
                string maHP = dgvLHP.SelectedRows[0].Cells[0].Value.ToString().Trim();
                txtMaLHP.Text = maHP;
                txtMaHP.Text = db.LopHPs.Find(maHP).IDHocPhan.ToString().Trim();
                txtHK.Text = dgvLHP.SelectedRows[0].Cells[3].Value.ToString().Trim();
                txtNT.Text = String.Format("{0:dd/MM/yyyy}",dgvLHP.SelectedRows[0].Cells[2].Value);
                txtPH.Text = dgvLHP.SelectedRows[0].Cells[1].Value.ToString().Trim();
                txtMaGV.Text= db.LopHPs.Find(maHP).IDGV.ToString().Trim();

            }
        }

        private void buttonThem_Click(object sender, EventArgs e)
        {
            string maLHP = txtMaLHP.Text.Trim();
            string maHP = txtMaHP.Text.Trim();
            string hk = txtHK.Text.Trim();
            DateTime nt = DateTime.Parse(txtNT.Text.Trim());
            string ph = txtPH.Text.Trim();
            string maGV = txtMaGV.Text.Trim();
            try
            {
                db.addLHP(maLHP, maHP, hk, nt, ph, maGV);
                MessageBox.Show("Thêm thành công!");
                buttonSearch_Click(sender, e);
            }
            catch (Exception)
            {
                MessageBox.Show("Thêm không thành công!");
                
            }
        }

        private void buttonSua_Click(object sender, EventArgs e)
        {
            string maLHP = txtMaLHP.Text.Trim();
            string maHP = txtMaHP.Text.Trim();
            string hk = txtHK.Text.Trim();
            DateTime nt = DateTime.Parse(txtNT.Text.Trim());
            string ph = txtPH.Text.Trim();
            string maGV = txtMaGV.Text.Trim();
            try
            {
                db.updLHP(maLHP, maHP, hk, nt, ph, maGV);
                MessageBox.Show("Sửa thành công!");
                buttonSearch_Click(sender, e);
            }
            catch (Exception)
            {
                MessageBox.Show("Sửa không thành công!");

            }
        }

        private void buttonXoa_Click(object sender, EventArgs e)
        {
            string maLHP = txtMaLHP.Text.Trim();
            
            try
            {
                db.delLHP(maLHP);
                MessageBox.Show("Xóa thành công!");
                buttonSearch_Click(sender, e);
            }
            catch (Exception)
            {
                MessageBox.Show("Xóa không thành công!");

            }
        }
    }
}
