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
    public partial class fDiemHocPhan : Form
    {
        private static QLDiemSVCon db=new QLDiemSVCon();
        public fDiemHocPhan()
        {
            InitializeComponent();
        }
        private void loadDGV()
        {
             
            string idlhp = txtTimKiem.Text.ToString().Trim();
            var dt = db.viewDiemLHP(idlhp);
            dgvLHP.DataSource = dt.ToList();
            dgvLHP.Columns[0].HeaderText = "Mã sinh viên";
            dgvLHP.Columns[1].HeaderText = "Họ tên";
            dgvLHP.Columns[2].HeaderText = "Mã lớp học phần";
            dgvLHP.Columns[3].HeaderText = "Điểm chuyên cần";
            dgvLHP.Columns[4].HeaderText = "Điểm thường xuyên";
            dgvLHP.Columns[5].HeaderText = "Điểm thi";
            dgvLHP.Columns[6].HeaderText = "Hệ 10";
            dgvLHP.Columns[7].HeaderText = "Hê 4";
            dgvLHP.Columns[8].HeaderText = "Điểm chữ";
            //Set readonly
            dgvLHP.Columns[0].ReadOnly = true;
            dgvLHP.Columns[1].ReadOnly = true;
            dgvLHP.Columns[2].ReadOnly = true;
            dgvLHP.Columns[3].ReadOnly = false;
            dgvLHP.Columns[4].ReadOnly = false;
            dgvLHP.Columns[5].ReadOnly = true;
            dgvLHP.Columns[6].ReadOnly = true;
            dgvLHP.Columns[7].ReadOnly = true;
            dgvLHP.Columns[8].ReadOnly = true;
            var ngayThi = db.LopHPs.Find(idlhp).NgayThi;
            DateTime now = DateTime.Now;
            if (ngayThi < now)
            {
                dgvLHP.Columns[5].ReadOnly = false;

            }
            
        }

        private void buttonTimKiem_Click(object sender, EventArgs e)
        {
            loadDGV();
            
        }

        private void dgvLHP_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void buttonThem_Click(object sender, EventArgs e)
        {
            /*float dcc = float.Parse(txtDCC.Text);
            float dtx = float.Parse(txtDTX.Text);
            float dt = float.Parse(txtDT.Text);
            string idsv = txtMaSV.Text.ToString().Trim();
            string idlhp = txtTimKiem.Text.ToString().Trim();
            if (dcc < 0 || dcc > 10 || dtx < 0 || dtx > 10 || dt < 0 || dt > 10)
            {
                MessageBox.Show("Thông tin điểm nhập vào sai !");
            }
            else
            {
                try
                {
                    db.insertDHP(idsv, idlhp, dcc, dtx, dt);
                    loadDGV();
                    MessageBox.Show("Thêm thành công !");
                }
                catch (Exception ex)
                {

                    MessageBox.Show("Thêm dữ liệu không thành công !, lỗi"+ex.ToString());
                }
            }*/
            
        }

        private void buttonSua_Click(object sender, EventArgs e)
        {
            if (dgvLHP.SelectedCells.Count > 0)
            {
                try
                {
                    int rowIndex = dgvLHP.CurrentCell.RowIndex;
                    float dcc = float.Parse(dgvLHP.Rows[rowIndex].Cells[3].Value.ToString());
                    float dtx = float.Parse(dgvLHP.Rows[rowIndex].Cells[4].Value.ToString());
                    float dt = float.Parse(dgvLHP.Rows[rowIndex].Cells[5].Value.ToString());
                    string idsv = dgvLHP.Rows[rowIndex].Cells[0].Value.ToString().Trim();
                    string idlhp = txtTimKiem.Text.ToString().Trim();
                    int return_= db.insertDHP(idsv, idlhp, dcc, dtx, dt);
                    MessageBox.Show("Sửa thành công !");
                }
                catch (Exception)
                {
                    MessageBox.Show("Sửa không thành công !");
                   
                }
                

            }
            
        }

        private void buttonThoat_Click(object sender, EventArgs e)
        {
            this.Visible = false;
        }

        private void dgvLHP_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
