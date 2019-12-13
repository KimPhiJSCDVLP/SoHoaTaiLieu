namespace So_Hoa_ITVN_Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class S_Authority
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public S_Authority()
        {
            S_Role_Uers_Atuthority_ = new HashSet<S_Role_Uers_Atuthority_>();
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int AuthorityID { get; set; }

        [StringLength(10)]
        public string AuthorityName { get; set; }

        [Column(TypeName = "date")]
        public DateTime? NgayTao { get; set; }

        [Column(TypeName = "date")]
        public DateTime? NgayCapNhat { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<S_Role_Uers_Atuthority_> S_Role_Uers_Atuthority_ { get; set; }
    }
}
