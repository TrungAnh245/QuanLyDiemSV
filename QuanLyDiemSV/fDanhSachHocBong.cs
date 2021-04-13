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
    public partial class fDanhSachHocBong : Form
    {
        public static QLDiemSVCon db = new QLDiemSVCon();
        public fDanhSachHocBong()
        {
            InitializeComponent();
        }

        private void bntTim_Click(object sender, EventArgs e)
        {
            string idhk = txtTim.Text.ToString().Trim();
            var rs = db.viewHB(idhk);
            dgvDSHB.DataSource = rs.ToList();
            dgvDSHB.Columns[0].HeaderText = "Xếp Hạng";
            dgvDSHB.Columns[1].HeaderText = "Mã Sinh Viên";
            dgvDSHB.Columns[2].HeaderText = "Họ Tên";
            dgvDSHB.Columns[3].HeaderText = "Lớp";
            dgvDSHB.Columns[4].HeaderText = "Khoa";
            dgvDSHB.Columns[5].HeaderText = "Số TC ĐKi";
            dgvDSHB.Columns[6].HeaderText = "Số TC Đạt";
            dgvDSHB.Columns[7].HeaderText = "Điểm TBC";
            dgvDSHB.Columns[8].HeaderText = "Xếp Loại";
        }
    }
}
