namespace So_Hoa_ITVN_Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class S_LuuTru
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public S_LuuTru()
        {
            S_MucLucHoSo = new HashSet<S_MucLucHoSo>();
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int LuuTruID { get; set; }

        public int? KhoID { get; set; }

        public int? PhongID { get; set; }

        public virtual S_Kho S_Kho { get; set; }

        public virtual S_Phong S_Phong { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<S_MucLucHoSo> S_MucLucHoSo { get; set; }
    }
}
