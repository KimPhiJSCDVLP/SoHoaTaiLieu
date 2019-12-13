namespace So_Hoa_ITVN_Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class S_DetailsVanBan
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int DetailsVanBanID { get; set; }

        public int? VanBanID { get; set; }

        public virtual S_VanBan S_VanBan { get; set; }
    }
}
