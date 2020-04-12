using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PecMembers.UI.Model
{
    public partial class Regions
    {
        [Key]
        [StringLength(2)]
        public string RegionCode { get; set; }
        [StringLength(64)]
        public string Name { get; set; }
        [Column("Name_en")]
        [StringLength(64)]
        public string NameEn { get; set; }
        [Column("msrepl_tran_version")]
        public Guid MsreplTranVersion { get; set; }
    }
}
