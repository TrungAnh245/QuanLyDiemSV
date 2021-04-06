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
    public partial class fDanhSachCanhCao : Form
    {
        private static QLDiemSVCon db = new QLDiemSVCon();
        public fDanhSachCanhCao()
        {
            InitializeComponent();
        }

        private void buttonTimKiem_Click(object sender, EventArgs e)
        {
            string key = txtTim.Text.Trim();
            // if (db.viewCCHT(key).t)
            var data = db.viewCCHT(key);
            dgvDS.DataSource = data.ToList();
            dgvDS.Columns[0].HeaderText = "Mã Sinh Viên";
            dgvDS.Columns[1].HeaderText = "Họ Tên";
            dgvDS.Columns[2].HeaderText = "Mã Lớp";
            dgvDS.Columns[3].HeaderText = "Ngày Sinh";
            dgvDS.Columns[4].HeaderText = "Giới Tính";
            dgvDS.Columns[5].HeaderText = "Khoa";
            dgvDS.Columns[6].HeaderText = "Điểm TBC";
            dgvDS.Columns[7].HeaderText = "Số Mức Cảnh Cáo";

        }
    }
}
