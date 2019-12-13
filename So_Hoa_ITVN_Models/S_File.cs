namespace So_Hoa_ITVN_Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class S_File
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int FileID { get; set; }

        public int VanBanID { get; set; }

        [StringLength(50)]
        public string TenFile { get; set; }

        [Column(TypeName = "date")]
        public DateTime? NgayTao { get; set; }

        [Column(TypeName = "date")]
        public DateTime? NgayCapNhat { get; set; }

        [StringLength(50)]
        public string GhiChu { get; set; }

        public virtual S_VanBan S_VanBan { get; set; }

        public virtual S_FileAttachment S_FileAttachment { get; set; }
    }
}
