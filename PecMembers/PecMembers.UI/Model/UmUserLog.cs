using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PecMembers.UI.Model
{
    [Table("umUserLog")]
    public partial class UmUserLog
    {
        [Key]
        public int Id { get; set; }
        public int? UserId { get; set; }
        public int? Key { get; set; }
        [StringLength(255)]
        public string Comment { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? Date { get; set; }
        public int? ElectionId { get; set; }
        public int? ObjectId { get; set; }
        [Column("msrepl_tran_version")]
        public Guid MsreplTranVersion { get; set; }
    }
}
