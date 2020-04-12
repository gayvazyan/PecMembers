using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PecMembers.UI.Model
{
    [Table("umUserRoles")]
    public partial class UmUserRoles
    {
        [Key]
        public int Id { get; set; }
        [Column("UserID")]
        public int? UserId { get; set; }
        [Column("RoleID")]
        public int? RoleId { get; set; }
        [Column("msrepl_tran_version")]
        public Guid MsreplTranVersion { get; set; }
    }
}
