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
    
    public partial class SinhVien
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public SinhVien()
        {
            this.KetQuaLopHPs = new HashSet<KetQuaLopHP>();
            this.TongKetKies = new HashSet<TongKetKy>();
        }
    
        public string IDSinhVien { get; set; }
        public string HoTen { get; set; }
        public Nullable<System.DateTime> NgaySinh { get; set; }
        public string GioiTinh { get; set; }
        public string KhoaDKi { get; set; }
        public Nullable<int> SoTCDaDat { get; set; }
        public Nullable<int> SoTCDaDKi { get; set; }
        public Nullable<double> DiemTichLuy { get; set; }
        public string IDLop { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<KetQuaLopHP> KetQuaLopHPs { get; set; }
        public virtual Lop Lop { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TongKetKy> TongKetKies { get; set; }
    }
}
