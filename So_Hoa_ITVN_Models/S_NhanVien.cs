namespace So_Hoa_ITVN_Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class S_NhanVien
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int NhanVienID { get; set; }

        [StringLength(50)]
        public string User { get; set; }

        [StringLength(50)]
        public string TenNhanVien { get; set; }

        [Column(TypeName = "date")]
        public DateTime? NgaySinh { get; set; }

        [StringLength(50)]
        public string Email { get; set; }

        [StringLength(20)]
        public string CMND { get; set; }

        public int? UserID { get; set; }

        public virtual S_Users S_Users { get; set; }
    }
}
