//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace QuanLyDiemSV
{
    using System;
    using System.Collections.Generic;
    
    public partial class TongKetKy
    {
        public string IDSinhVien { get; set; }
        public string IDHocKy { get; set; }
        public Nullable<double> DiemTBC { get; set; }
        public Nullable<int> SoTCDKi { get; set; }
        public Nullable<int> SoTCNo { get; set; }
        public string XepLoai { get; set; }
    
        public virtual HocKy HocKy { get; set; }
        public virtual SinhVien SinhVien { get; set; }
    }
}
