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
    
    public partial class KetQuaLopHP
    {
        public string IDSinhVien { get; set; }
        public string IDLopHP { get; set; }
        public Nullable<double> DiemCC { get; set; }
        public Nullable<double> DiemTX { get; set; }
        public Nullable<double> DiemThi { get; set; }
        public Nullable<double> DiemHe10 { get; set; }
        public Nullable<double> DiemHe4 { get; set; }
        public string DiemChu { get; set; }
    
        public virtual LopHP LopHP { get; set; }
        public virtual SinhVien SinhVien { get; set; }
    }
}