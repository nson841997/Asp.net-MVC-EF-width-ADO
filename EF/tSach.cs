namespace QLThuVien.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("tSach")]
    public partial class tSach
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tSach()
        {
            tBanSaoSaches = new HashSet<tBanSaoSach>();
        }

        [Key]
        [StringLength(25)]
        public string MaSach { get; set; }

        [StringLength(155)]
        public string TenSach { get; set; }

        [StringLength(25)]
        public string MaLoai { get; set; }

        [StringLength(25)]
        public string MaNgonNgu { get; set; }

        [StringLength(25)]
        public string MaNXB { get; set; }

        [StringLength(150)]
        public string TacGia { get; set; }

        [StringLength(4)]
        public string NamXB { get; set; }

        [StringLength(3)]
        public string LanXB { get; set; }

        [Column(TypeName = "text")]
        public string GioiThieu { get; set; }

        [StringLength(6)]
        public string TongSoTrang { get; set; }

        [StringLength(4)]
        public string Tap { get; set; }

        [StringLength(4)]
        public string TongSoTap { get; set; }

        public double? GiaTriSach { get; set; }

        [StringLength(100)]
        public string FileAnh { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tBanSaoSach> tBanSaoSaches { get; set; }

        public virtual tLoaiSach tLoaiSach { get; set; }

        public virtual tNgonNgu tNgonNgu { get; set; }

        public virtual tNhaXB tNhaXB { get; set; }
    }
}
