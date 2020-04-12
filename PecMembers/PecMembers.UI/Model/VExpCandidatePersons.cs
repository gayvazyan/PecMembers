﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PecMembers.UI.Model
{
    public partial class VExpCandidatePersons
    {
        public int PersonId { get; set; }
        public int CandidateId { get; set; }
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
        [Column("PN")]
        [StringLength(50)]
        public string Pn { get; set; }
        [StringLength(16)]
        public string Passport { get; set; }
        public int? WorkType { get; set; }
        [StringLength(64)]
        public string WorkPosition { get; set; }
        [StringLength(128)]
        public string WorkAddress { get; set; }
        public int? OrgId { get; set; }
        public int? RecOrgId { get; set; }
        [StringLength(32)]
        public string RecName { get; set; }
        [StringLength(255)]
        public string OrgName { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime ElectDate { get; set; }
        [StringLength(387)]
        public string ElectName { get; set; }
        [StringLength(255)]
        public string ElectTypeName { get; set; }
        [StringLength(130)]
        public string FullName { get; set; }
        [StringLength(64)]
        public string RegionName { get; set; }
        [StringLength(64)]
        public string CommunityName { get; set; }
        public int? ElectionId { get; set; }
        public int? DistrictId { get; set; }
        public int? State { get; set; }
        public int? RecommendationId { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? ActivityDate { get; set; }
        public int? CommissionId { get; set; }
    }
}
