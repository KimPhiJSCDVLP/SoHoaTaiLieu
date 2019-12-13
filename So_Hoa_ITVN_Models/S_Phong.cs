namespace So_Hoa_ITVN_Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class S_Phong
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public S_Phong()
        {
            S_LuuTru = new HashSet<S_LuuTru>();
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int PhongID { get; set; }

        public int DonViHanhChinhID { get; set; }

        [StringLength(50)]
        public string TenPhong { get; set; }

        [Column(TypeName = "date")]
        public DateTime? NgayTao { get; set; }

        [Column(TypeName = "date")]
        public DateTime? NgayCapNhat { get; set; }

        public virtual S_DonViHanhChinh S_DonViHanhChinh { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<S_LuuTru> S_LuuTru { get; set; }
    }
}
