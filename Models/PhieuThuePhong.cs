//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DoAnHMS.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class PhieuThuePhong
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public PhieuThuePhong()
        {
            this.CTPhieuThuePhong = new HashSet<CTPhieuThuePhong>();
        }
    
        public string maPTP { get; set; }
        public string maPDP { get; set; }
        public string maKH { get; set; }
        public string maNV { get; set; }
        public System.DateTime ngayThue { get; set; }
        public System.DateTime ngayTra { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CTPhieuThuePhong> CTPhieuThuePhong { get; set; }
        public virtual HoaDon HoaDon { get; set; }
        public virtual KhachHang KhachHang { get; set; }
        public virtual NhanVien NhanVien { get; set; }
        public virtual PhieuDatPhong PhieuDatPhong { get; set; }
    }
}