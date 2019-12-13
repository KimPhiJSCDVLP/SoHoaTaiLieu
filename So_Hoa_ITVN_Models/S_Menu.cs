namespace So_Hoa_ITVN_Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class S_Menu
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int MenuID { get; set; }

        [StringLength(10)]
        public string MenuName { get; set; }

        public int? RoleID { get; set; }

        [Column(TypeName = "date")]
        public DateTime? NgayTao { get; set; }

        [Column(TypeName = "date")]
        public DateTime? NgayCapNhat { get; set; }

        public virtual S_Role S_Role { get; set; }
    }
}
