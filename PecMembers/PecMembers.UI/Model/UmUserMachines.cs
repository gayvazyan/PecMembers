using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PecMembers.UI.Model
{
    [Table("umUserMachines")]
    public partial class UmUserMachines
    {
        [Key]
        public int Id { get; set; }
        public int? UserId { get; set; }
        [Column("HDID")]
        public long? Hdid { get; set; }
        [Column("msrepl_tran_version")]
        public Guid MsreplTranVersion { get; set; }
    }
}
