namespace So_Hoa_ITVN_Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class S_Users
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public S_Users()
        {
            S_NhanVien = new HashSet<S_NhanVien>();
            S_Role_Uers_Atuthority_ = new HashSet<S_Role_Uers_Atuthority_>();
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int UserID { get; set; }

        [StringLength(50)]
        public string Name { get; set; }

        [StringLength(50)]
        public string UserName { get; set; }

        [StringLength(800)]
        public string Password { get; set; }

        [StringLength(800)]
        public string PasswordSalt { get; set; }

        [StringLength(50)]
        public string NguoiTao { get; set; }

        [StringLength(50)]
        public string NguoiCapNhat { get; set; }

        [Column(TypeName = "date")]
        public DateTime? NgayTao { get; set; }

        [Column(TypeName = "date")]
        public DateTime? NgayCapNhat { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<S_NhanVien> S_NhanVien { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<S_Role_Uers_Atuthority_> S_Role_Uers_Atuthority_ { get; set; }
    }
}
