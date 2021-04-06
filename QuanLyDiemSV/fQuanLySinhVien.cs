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
    public partial class fQuanLySinhVien : Form
    {
        public static QLDiemSVCon db = new QLDiemSVCon(); 
        public fQuanLySinhVien()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnTim_Click(object sender, EventArgs e)
        {
            string idsv = txtTim.Text.ToString().Trim();
            var rs = db.viewProfile(idsv);

            List<viewProfile_Result> pfl = rs.ToList<viewProfile_Result>();
            viewProfile_Result pf = pfl[0];
            txtTen.Text = pf.HoTen.ToString();
            txtNgaySinh.Text = String.Format(" {0:dd/MM/yyyy}",pf.NgaySinh);
            txtLop.Text = pf.IDLop.ToString();
            txtKhoa.Text = pf.TenKhoa.ToString();
            txtGioiTinh.Text = pf.GioiTinh.ToString();
            txtDTL.Text = pf.DiemTichLuy.ToString();
            txtTCDK.Text = pf.SoTCDaDKi.ToString();
            txtTCD.Text = pf.SoTCDaDat.ToString();
        }
    }
}
