namespace So_Hoa_ITVN_Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class S_MucLucHoSo
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public S_MucLucHoSo()
        {
            S_HopSo = new HashSet<S_HopSo>();
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int MucLucHoSoID { get; set; }

        public int LuuTruID { get; set; }

        [StringLength(50)]
        public string TenMucLucHoSo { get; set; }

        [Column(TypeName = "date")]
        public DateTime? NgayTao { get; set; }

        [Column(TypeName = "date")]
        public DateTime? NgayCapNhat { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<S_HopSo> S_HopSo { get; set; }

        public virtual S_LuuTru S_LuuTru { get; set; }
    }
}
