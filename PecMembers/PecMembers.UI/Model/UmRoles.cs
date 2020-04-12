using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PecMembers.UI.Model
{
    [Table("umRoles")]
    public partial class UmRoles
    {
        [Key]
        public int Id { get; set; }
        [StringLength(10)]
        public string Name { get; set; }
        [StringLength(512)]
        public string XmlModul { get; set; }
        [Column("msrepl_tran_version")]
        public Guid MsreplTranVersion { get; set; }
    }
}
