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
    public partial class fMain : Form
    {
        public fMain()
        {
            InitializeComponent();
        }

        private void buttonDiemHocPhan_Click(object sender, EventArgs e)
        {
            fDiemHocPhan fDHP = new fDiemHocPhan();
            fDHP.ShowDialog();
        }

        private void buttonSinhVien_Click(object sender, EventArgs e)
        {
            fThemSuaXoaSV f= new fThemSuaXoaSV();
            f.ShowDialog();
        }

        private void buttonDanhSachHocBong_Click(object sender, EventArgs e)
        {
            fDanhSachHocBong ds = new fDanhSachHocBong();
            ds.ShowDialog();
        }

        private void buttonTimKiemThongTinSV_Click(object sender, EventArgs e)
        {
            fQuanLySinhVien f = new fQuanLySinhVien();
            f.ShowDialog();
        }

        private void buttonQuanLyLopChuyenNganh_Click(object sender, EventArgs e)
        {
            fLopChuyenNganh f = new fLopChuyenNganh();
            f.ShowDialog();
        }

        private void buttonQuanLyKhoa_Click(object sender, EventArgs e)
        {
            fQuanLyKhoa f = new fQuanLyKhoa();
            f.ShowDialog();
        }

        private void buttonQuanLyLopHP_Click(object sender, EventArgs e)
        {
            fLopHocPhan f = new fLopHocPhan();
            f.ShowDialog();
        }

        private void buttonDanhSachCCHT_Click(object sender, EventArgs e)
        {
            fDanhSachCanhCao f = new fDanhSachCanhCao();
            f.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
