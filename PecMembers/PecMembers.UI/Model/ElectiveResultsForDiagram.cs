using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PecMembers.UI.Model
{
    public partial class ElectiveResultsForDiagram
    {
        public int SubDistrictId { get; set; }
        public int CountOfBody { get; set; }
        public int TotalCards { get; set; }
        public int TotalEnvelopes { get; set; }
        public int ElNum { get; set; }
        public int? ElNum1 { get; set; }
        public int BadElecCards { get; set; }
        public int BadEnvelopes { get; set; }
        public int BodyCount { get; set; }
        public int NoElecCards { get; set; }
        public int ElecCardsEl { get; set; }
        public int TrueCards { get; set; }
        public int FalseCards { get; set; }
        public int CardsCount { get; set; }
        public int EnvelopesCount { get; set; }
        [Column("NoRSize")]
        public int NoRsize { get; set; }
        [Column("NoRSize1")]
        public int? NoRsize1 { get; set; }
        [Column("NoRSize2")]
        public int? NoRsize2 { get; set; }
        [Column("NoRSize3")]
        public int? NoRsize3 { get; set; }
        [Column("NoRSize4")]
        public int? NoRsize4 { get; set; }
        [Column("NoRSizeR")]
        public int? NoRsizeR { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? EnterDate { get; set; }
        public int? State { get; set; }
        public int? EnterUser { get; set; }
        public bool? Control { get; set; }
        public int? NonRegList { get; set; }
        public int? OtherCommList { get; set; }
        public int? PoliceList { get; set; }
        public int? StationarList { get; set; }
        public int? CaughtList { get; set; }
        public int? PrecinctList { get; set; }
        public int? BodyList { get; set; }
        public int? NonRegList2 { get; set; }
        public int? OtherCommList2 { get; set; }
        public int? PoliceList2 { get; set; }
        public int? StationarList2 { get; set; }
        public int? CaughtList2 { get; set; }
        public int? PrecinctList2 { get; set; }
        public int? BodyList2 { get; set; }
        [Column("msrepl_tran_version")]
        public Guid MsreplTranVersion { get; set; }
    }
}
