namespace So_Hoa_ITVN_Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class S_FileAttachment
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int FileAttachmentID { get; set; }

        public int FileID { get; set; }

        [StringLength(800)]
        public string URL { get; set; }

        [Column(TypeName = "date")]
        public DateTime? NgayTao { get; set; }

        [Column(TypeName = "date")]
        public DateTime? NgayCapNhat { get; set; }

        public virtual S_File S_File { get; set; }
    }
}
