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
    public partial class fQuanLySinhVienLHP : Form
    {
        QLDiemSVCon db = new QLDiemSVCon();
        public fQuanLySinhVienLHP()
        {
            InitializeComponent();
        }

        private void txtHienThiTenSV_TextChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void fQuanLySinhVienLHP_Load(object sender, EventArgs e)
        {
            lblMaLop.Text = maLop;
            dgvDSL.DataSource = db.viewSTPrInLHP(maLop).ToList();
            

        }

        private void dgvDSL_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
