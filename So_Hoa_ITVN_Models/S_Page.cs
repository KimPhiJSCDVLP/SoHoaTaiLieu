namespace So_Hoa_ITVN_Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class S_Page
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int PageID { get; set; }

        public int? SystemID { get; set; }

        [StringLength(800)]
        public string PageName { get; set; }

        [StringLength(800)]
        public string URLPage { get; set; }

        [StringLength(50)]
        public string NguoiTao { get; set; }

        [Column(TypeName = "date")]
        public DateTime? NgayTao { get; set; }

        [Column(TypeName = "date")]
        public DateTime? NgayCapNhat { get; set; }

        public virtual S_Role_Uers_Atuthority_ S_Role_Uers_Atuthority_ { get; set; }
    }
}
