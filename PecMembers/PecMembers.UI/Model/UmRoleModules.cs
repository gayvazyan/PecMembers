using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PecMembers.UI.Model
{
    [Table("umRoleModules")]
    public partial class UmRoleModules
    {
        [Key]
        public int Id { get; set; }
        public int RoleId { get; set; }
        public int ModuleId { get; set; }
        [Required]
        [StringLength(64)]
        public string StateParam { get; set; }
        [Column("msrepl_tran_version")]
        public Guid MsreplTranVersion { get; set; }
    }
}
