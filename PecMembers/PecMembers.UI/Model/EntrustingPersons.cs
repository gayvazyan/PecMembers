﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PecMembers.UI.Model
{
    public partial class EntrustingPersons
    {
        [Key]
        public int PersonId { get; set; }
        public int? CandidateId { get; set; }
        [StringLength(32)]
        public string FirstName { get; set; }
        [StringLength(64)]
        public string MiddleName { get; set; }
        [StringLength(32)]
        public string LastName { get; set; }
        [StringLength(2)]
        public string RegionCode { get; set; }
        [StringLength(3)]
        public string CommunityCode { get; set; }
        [StringLength(128)]
        public string Address { get; set; }
        public bool? MaleFemale { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? Birthdate { get; set; }
        [StringLength(9)]
        public string Passport { get; set; }
        public int? WorkType { get; set; }
        [StringLength(64)]
        public string WorkPosition { get; set; }
        [StringLength(128)]
        public string WorkAddress { get; set; }
        public int? CommissionId { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? ActivityDate { get; set; }
        [Column("msrepl_tran_version")]
        public Guid MsreplTranVersion { get; set; }
    }
}
