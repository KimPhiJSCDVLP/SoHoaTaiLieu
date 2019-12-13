namespace So_Hoa_ITVN_Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("S_Role_Uers_Atuthority]")]
    public partial class S_Role_Uers_Atuthority_
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public S_Role_Uers_Atuthority_()
        {
            S_Page = new HashSet<S_Page>();
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int SystemID { get; set; }

        public int? UserID { get; set; }

        public int? AuthorityID { get; set; }

        public int? RoleID { get; set; }

        [Column(TypeName = "date")]
        public DateTime? NgayTao { get; set; }

        [Column(TypeName = "date")]
        public DateTime? NgayCapNhat { get; set; }

        public virtual S_Authority S_Authority { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<S_Page> S_Page { get; set; }

        public virtual S_Role S_Role { get; set; }

        public virtual S_Users S_Users { get; set; }
    }
}
