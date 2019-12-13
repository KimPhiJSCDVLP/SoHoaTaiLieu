namespace So_Hoa_ITVN_Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class S_DonViHanhChinh
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public S_DonViHanhChinh()
        {
            S_Phong = new HashSet<S_Phong>();
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int DonViHanhChinhID { get; set; }

        [StringLength(50)]
        public string TenDonViHanhChinh { get; set; }

        [Column(TypeName = "date")]
        public DateTime? NgayTao { get; set; }

        [Column(TypeName = "date")]
        public DateTime? NgayCapNhat { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<S_Phong> S_Phong { get; set; }
    }
}
