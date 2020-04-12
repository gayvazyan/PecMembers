using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PecMembers.UI.Model
{
    [Table("umCustomData")]
    public partial class UmCustomData
    {
        [Key]
        public int Id { get; set; }
        public int? RoleId { get; set; }
        [StringLength(64)]
        public string Name { get; set; }
        [StringLength(255)]
        public string Value { get; set; }
        [StringLength(255)]
        public string Comment { get; set; }
        [Column("msrepl_tran_version")]
        public Guid MsreplTranVersion { get; set; }
    }
}
