namespace So_Hoa_ITVN_Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class S_LoaiVanBan
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public S_LoaiVanBan()
        {
            S_VanBan = new HashSet<S_VanBan>();
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int LoaiVanBanID { get; set; }

        [StringLength(10)]
        public string TenLoaiVanBan { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<S_VanBan> S_VanBan { get; set; }
    }
}
