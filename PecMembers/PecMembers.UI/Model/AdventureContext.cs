using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace PecMembers.UI.Model
{
    public partial class ElectionsContext : DbContext
    {
        public ElectionsContext()
        {
        }

        public ElectionsContext(DbContextOptions<ElectionsContext> options)
            : base(options)
        {
        }

        public virtual DbSet<CandidatePersons> CandidatePersons { get; set; }
        public virtual DbSet<CandidateStates> CandidateStates { get; set; }
        public virtual DbSet<Candidates> Candidates { get; set; }
        public virtual DbSet<CandidatesResults> CandidatesResults { get; set; }
        public virtual DbSet<CandidatesResults1> CandidatesResults1 { get; set; }
        public virtual DbSet<CandidatesResults2> CandidatesResults2 { get; set; }
        public virtual DbSet<CandidatesResultsElectronic> CandidatesResultsElectronic { get; set; }
        public virtual DbSet<CandidatesResultsForDiagram> CandidatesResultsForDiagram { get; set; }
        public virtual DbSet<Cc1> Cc1 { get; set; }
        public virtual DbSet<City> City { get; set; }
        public virtual DbSet<CommissionElect> CommissionElect { get; set; }
        public virtual DbSet<CommissionElect1> CommissionElect1 { get; set; }
        public virtual DbSet<CommissionPersonState> CommissionPersonState { get; set; }
        public virtual DbSet<CommissionPersons> CommissionPersons { get; set; }
        public virtual DbSet<CommissionPersons0811> CommissionPersons0811 { get; set; }
        public virtual DbSet<Commissions> Commissions { get; set; }
        public virtual DbSet<Communitis> Communitis { get; set; }
        public virtual DbSet<Communitis1> Communitis1 { get; set; }
        public virtual DbSet<CucakU> CucakU { get; set; }
        public virtual DbSet<CucakY> CucakY { get; set; }
        public virtual DbSet<Districts> Districts { get; set; }
        public virtual DbSet<Ecucak> Ecucak { get; set; }
        public virtual DbSet<ElectTypeAccess> ElectTypeAccess { get; set; }
        public virtual DbSet<ElectionDecisions> ElectionDecisions { get; set; }
        public virtual DbSet<ElectionStates> ElectionStates { get; set; }
        public virtual DbSet<ElectionTypes> ElectionTypes { get; set; }
        public virtual DbSet<Elections> Elections { get; set; }
        public virtual DbSet<ElectiveResults> ElectiveResults { get; set; }
        public virtual DbSet<ElectiveResults2> ElectiveResults2 { get; set; }
        public virtual DbSet<ElectiveResultsElectronic> ElectiveResultsElectronic { get; set; }
        public virtual DbSet<ElectiveResultsForDiagram> ElectiveResultsForDiagram { get; set; }
        public virtual DbSet<EntrustingPersons> EntrustingPersons { get; set; }
        public virtual DbSet<GridWorking> GridWorking { get; set; }
        public virtual DbSet<IntermediateInfo> IntermediateInfo { get; set; }
        public virtual DbSet<IntermediateResults> IntermediateResults { get; set; }
        public virtual DbSet<Kk> Kk { get; set; }
        public virtual DbSet<Minorities> Minorities { get; set; }
        public virtual DbSet<OrganizationTypes> OrganizationTypes { get; set; }
        public virtual DbSet<Organizations> Organizations { get; set; }
        public virtual DbSet<PartieOrParty> PartieOrParty { get; set; }
        public virtual DbSet<PartieOrPartyList> PartieOrPartyList { get; set; }
        public virtual DbSet<PartieOrPartyPersons> PartieOrPartyPersons { get; set; }
        public virtual DbSet<PartieOrPartyPersonsResults> PartieOrPartyPersonsResults { get; set; }
        public virtual DbSet<PartisInfo> PartisInfo { get; set; }
        public virtual DbSet<PecMember> PecMember { get; set; }
        public virtual DbSet<PecMemberElectResult> PecMemberElectResult { get; set; }
        public virtual DbSet<PecMemberPartyResult> PecMemberPartyResult { get; set; }
        public virtual DbSet<Protocols> Protocols { get; set; }
        public virtual DbSet<RecomOrg> RecomOrg { get; set; }
        public virtual DbSet<Recommendations> Recommendations { get; set; }
        public virtual DbSet<Regions> Regions { get; set; }
        public virtual DbSet<SeesionData> SeesionData { get; set; }
        public virtual DbSet<Sheet> Sheet { get; set; }
        public virtual DbSet<Sheet1> Sheet1 { get; set; }
        public virtual DbSet<SubDistricts> SubDistricts { get; set; }
        public virtual DbSet<SubDistricts1> SubDistricts1 { get; set; }
        public virtual DbSet<Sysdiagrams> Sysdiagrams { get; set; }
        public virtual DbSet<Tmp2> Tmp2 { get; set; }
        public virtual DbSet<Tt2> Tt2 { get; set; }
        public virtual DbSet<UmCustomData> UmCustomData { get; set; }
        public virtual DbSet<UmModules> UmModules { get; set; }
        public virtual DbSet<UmRoleModules> UmRoleModules { get; set; }
        public virtual DbSet<UmRoles> UmRoles { get; set; }
        public virtual DbSet<UmSys> UmSys { get; set; }
        public virtual DbSet<UmSysNonRep> UmSysNonRep { get; set; }
        public virtual DbSet<UmUserLog> UmUserLog { get; set; }
        public virtual DbSet<UmUserMachines> UmUserMachines { get; set; }
        public virtual DbSet<UmUserRoles> UmUserRoles { get; set; }
        public virtual DbSet<UmUsers> UmUsers { get; set; }
        public virtual DbSet<VCandidate> VCandidate { get; set; }
        public virtual DbSet<VCandidateParty> VCandidateParty { get; set; }
        public virtual DbSet<VCandidatePersons> VCandidatePersons { get; set; }
        public virtual DbSet<VCandidatesResults> VCandidatesResults { get; set; }
        public virtual DbSet<VCandidatesResults2> VCandidatesResults2 { get; set; }
        public virtual DbSet<VCandidatesResultsR> VCandidatesResultsR { get; set; }
        public virtual DbSet<VColumns> VColumns { get; set; }
        public virtual DbSet<VCommunitis> VCommunitis { get; set; }
        public virtual DbSet<VElections> VElections { get; set; }
        public virtual DbSet<VElectiveResults> VElectiveResults { get; set; }
        public virtual DbSet<VElectiveResults2> VElectiveResults2 { get; set; }
        public virtual DbSet<VElectiveResultsR> VElectiveResultsR { get; set; }
        public virtual DbSet<VExpCandidatePersons> VExpCandidatePersons { get; set; }
        public virtual DbSet<VExpCommissionPersons> VExpCommissionPersons { get; set; }
        public virtual DbSet<VExpEntrustingPersons> VExpEntrustingPersons { get; set; }
        public virtual DbSet<VExpPartieOrParty> VExpPartieOrParty { get; set; }
        public virtual DbSet<VExpPartieOrPartyPersons> VExpPartieOrPartyPersons { get; set; }
        public virtual DbSet<VGeoresults> VGeoresults { get; set; }
        public virtual DbSet<VGroup> VGroup { get; set; }
        public virtual DbSet<VPartieOrPartyPersons> VPartieOrPartyPersons { get; set; }
        public virtual DbSet<VResult> VResult { get; set; }
        public virtual DbSet<VResult2> VResult2 { get; set; }
        public virtual DbSet<VResulteByDistrict> VResulteByDistrict { get; set; }
        public virtual DbSet<VRound1> VRound1 { get; set; }
        public virtual DbSet<VRound12> VRound12 { get; set; }
        public virtual DbSet<VSatisfied> VSatisfied { get; set; }
        public virtual DbSet<VSubDistricts> VSubDistricts { get; set; }
        public virtual DbSet<WatcherElectTypes> WatcherElectTypes { get; set; }
        public virtual DbSet<Watchers> Watchers { get; set; }
        public virtual DbSet<WebAnnouncement> WebAnnouncement { get; set; }
        public virtual DbSet<WebCec> WebCec { get; set; }
        public virtual DbSet<WebCecEmployee> WebCecEmployee { get; set; }
        public virtual DbSet<WebCecarx> WebCecarx { get; set; }
        public virtual DbSet<WebNews> WebNews { get; set; }
        public virtual DbSet<WebNotifications> WebNotifications { get; set; }
        public virtual DbSet<WebSessions> WebSessions { get; set; }
        public virtual DbSet<WorkPositionTypes> WorkPositionTypes { get; set; }

//        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
//        {
//            if (!optionsBuilder.IsConfigured)
//            {
//#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
//                optionsBuilder.UseSqlServer("Server=DESKTOP-9GM7NOP\\SQLEXPRESS;Database=elections;Trusted_Connection=True;");
//            }
//        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<CandidatePersons>(entity =>
            {
                entity.Property(e => e.CommunityCode).IsUnicode(false);

                entity.Property(e => e.Passport).IsUnicode(false);

                entity.Property(e => e.Pn).IsUnicode(false);

                entity.Property(e => e.RegionCode).IsUnicode(false);
            });

            modelBuilder.Entity<Candidates>(entity =>
            {
                entity.Property(e => e.OrderNum).IsUnicode(false);
            });

            modelBuilder.Entity<CandidatesResults1>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.Id).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<CandidatesResults2>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();
            });

            modelBuilder.Entity<CandidatesResultsElectronic>(entity =>
            {
                entity.HasNoKey();
            });

            modelBuilder.Entity<CandidatesResultsForDiagram>(entity =>
            {
                entity.HasNoKey();
            });

            modelBuilder.Entity<Cc1>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.CommunityCode).IsUnicode(false);

                entity.Property(e => e.Expr1).IsUnicode(false);
            });

            modelBuilder.Entity<City>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.CommunityCode).IsUnicode(false);

                entity.Property(e => e.Pr)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.RegionCode)
                    .IsUnicode(false)
                    .IsFixedLength();
            });

            modelBuilder.Entity<CommissionElect1>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.CommissionElectId).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<CommissionPersons>(entity =>
            {
                entity.Property(e => e.CommunityCode).IsUnicode(false);

                entity.Property(e => e.RegionCode).IsUnicode(false);
            });

            modelBuilder.Entity<CommissionPersons0811>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.CommunityCode).IsUnicode(false);

                entity.Property(e => e.PersonId).ValueGeneratedOnAdd();

                entity.Property(e => e.RegionCode).IsUnicode(false);
            });

            modelBuilder.Entity<Commissions>(entity =>
            {
                entity.Property(e => e.Code)
                    .IsUnicode(false)
                    .IsFixedLength();
            });

            modelBuilder.Entity<Communitis>(entity =>
            {
                entity.Property(e => e.CommunityCode).IsUnicode(false);

                entity.Property(e => e.Consolidated).IsUnicode(false);

                entity.Property(e => e.Pr).IsFixedLength();

                entity.Property(e => e.RegionCode)
                    .IsUnicode(false)
                    .IsFixedLength();
            });

            modelBuilder.Entity<Communitis1>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.CommunityCode).IsUnicode(false);

                entity.Property(e => e.RegionCode)
                    .IsUnicode(false)
                    .IsFixedLength();
            });

            modelBuilder.Entity<CucakU>(entity =>
            {
                entity.HasNoKey();
            });

            modelBuilder.Entity<CucakY>(entity =>
            {
                entity.HasNoKey();
            });

            modelBuilder.Entity<Districts>(entity =>
            {
                entity.Property(e => e.DistrictId).ValueGeneratedNever();

                entity.Property(e => e.DistrictCode).IsUnicode(false);
            });

            modelBuilder.Entity<Ecucak>(entity =>
            {
                entity.HasNoKey();
            });

            modelBuilder.Entity<ElectionDecisions>(entity =>
            {
                entity.Property(e => e.Additional).IsUnicode(false);
            });

            modelBuilder.Entity<ElectionStates>(entity =>
            {
                entity.Property(e => e.StateId).ValueGeneratedNever();
            });

            modelBuilder.Entity<ElectionTypes>(entity =>
            {
                entity.Property(e => e.TypeId).ValueGeneratedNever();
            });

            modelBuilder.Entity<Elections>(entity =>
            {
                entity.Property(e => e.CommunityCode).IsUnicode(false);
            });

            modelBuilder.Entity<ElectiveResults>(entity =>
            {
                entity.Property(e => e.SubDistrictId).ValueGeneratedNever();
            });

            modelBuilder.Entity<ElectiveResultsElectronic>(entity =>
            {
                entity.HasNoKey();
            });

            modelBuilder.Entity<ElectiveResultsForDiagram>(entity =>
            {
                entity.HasNoKey();
            });

            modelBuilder.Entity<EntrustingPersons>(entity =>
            {
                entity.Property(e => e.CommunityCode).IsUnicode(false);

                entity.Property(e => e.RegionCode).IsUnicode(false);
            });

            modelBuilder.Entity<GridWorking>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.Id).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<Kk>(entity =>
            {
                entity.HasNoKey();
            });

            modelBuilder.Entity<Minorities>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();
            });

            modelBuilder.Entity<Organizations>(entity =>
            {
                entity.Property(e => e.OrgCode)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Sertificate).IsFixedLength();
            });

            modelBuilder.Entity<PartieOrPartyPersons>(entity =>
            {
                entity.Property(e => e.CommunityCode).IsUnicode(false);

                entity.Property(e => e.Pn)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.RegionCode).IsUnicode(false);
            });

            modelBuilder.Entity<PecMember>(entity =>
            {
                entity.Property(e => e.CommunityCode).IsUnicode(false);

                entity.Property(e => e.Phone).IsUnicode(false);

                entity.Property(e => e.SubDistrictCode).IsUnicode(false);
            });

            modelBuilder.Entity<PecMemberElectResult>(entity =>
            {
                entity.Property(e => e.CommunityCode).IsUnicode(false);
            });

            modelBuilder.Entity<Protocols>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("PROTOCOLS");

                entity.Property(e => e.CommunityCode).IsUnicode(false);

                entity.Property(e => e.RegionCode).IsUnicode(false);

                entity.Property(e => e.Settlement).IsUnicode(false);

                entity.Property(e => e.SubDistrictCode).IsUnicode(false);
            });

            modelBuilder.Entity<Regions>(entity =>
            {
                entity.Property(e => e.RegionCode)
                    .IsUnicode(false)
                    .IsFixedLength();
            });

            modelBuilder.Entity<SeesionData>(entity =>
            {
                entity.Property(e => e.SessionId).ValueGeneratedNever();
            });

            modelBuilder.Entity<Sheet>(entity =>
            {
                entity.HasNoKey();
            });

            modelBuilder.Entity<Sheet1>(entity =>
            {
                entity.HasNoKey();
            });

            modelBuilder.Entity<SubDistricts>(entity =>
            {
                entity.Property(e => e.CommunityCode).IsUnicode(false);

                entity.Property(e => e.RegionCode).IsUnicode(false);

                entity.Property(e => e.Settlement).IsUnicode(false);

                entity.Property(e => e.SubDistrictCode).IsUnicode(false);
            });

            modelBuilder.Entity<SubDistricts1>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.CommunityCode).IsUnicode(false);

                entity.Property(e => e.RegionCode).IsUnicode(false);

                entity.Property(e => e.SubDistrictCode).IsUnicode(false);

                entity.Property(e => e.SubDistrictId).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<Sysdiagrams>(entity =>
            {
                entity.HasKey(e => e.DiagramId)
                    .HasName("PK__sysdiagr__C2B05B611E489488");

                entity.HasIndex(e => new { e.PrincipalId, e.Name })
                    .HasName("UK_principal_name")
                    .IsUnique();
            });

            modelBuilder.Entity<Tmp2>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.CommunityCode).IsUnicode(false);
            });

            modelBuilder.Entity<Tt2>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.CommunityCode).IsUnicode(false);
            });

            modelBuilder.Entity<UmCustomData>(entity =>
            {
                entity.Property(e => e.Name).IsUnicode(false);

                entity.Property(e => e.Value).IsUnicode(false);
            });

            modelBuilder.Entity<UmModules>(entity =>
            {
                entity.Property(e => e.Assambly).IsUnicode(false);

                entity.Property(e => e.Object).IsUnicode(false);
            });

            modelBuilder.Entity<UmRoleModules>(entity =>
            {
                entity.Property(e => e.StateParam).IsUnicode(false);
            });

            modelBuilder.Entity<UmRoles>(entity =>
            {
                entity.Property(e => e.Name)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.XmlModul).IsUnicode(false);
            });

            modelBuilder.Entity<UmSysNonRep>(entity =>
            {
                entity.HasNoKey();
            });

            modelBuilder.Entity<UmUsers>(entity =>
            {
                entity.HasIndex(e => e.Login)
                    .HasName("IX_umUsers")
                    .IsUnique();

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.FullName).IsUnicode(false);

                entity.Property(e => e.Login).IsUnicode(false);
            });

            modelBuilder.Entity<VCandidate>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vCandidate");

                entity.Property(e => e.OrderNum).IsUnicode(false);
            });

            modelBuilder.Entity<VCandidateParty>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vCandidateParty");

                entity.Property(e => e.OrderNum).IsUnicode(false);
            });

            modelBuilder.Entity<VCandidatePersons>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vCandidatePersons");

                entity.Property(e => e.CommunityCode).IsUnicode(false);

                entity.Property(e => e.Passport).IsUnicode(false);

                entity.Property(e => e.Pn).IsUnicode(false);

                entity.Property(e => e.RegionCode).IsUnicode(false);
            });

            modelBuilder.Entity<VCandidatesResults>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vCandidatesResults");
            });

            modelBuilder.Entity<VCandidatesResults2>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vCandidatesResults2");

                entity.Property(e => e.CommunityCode).IsUnicode(false);

                entity.Property(e => e.OrderNum).IsUnicode(false);

                entity.Property(e => e.RegionCode)
                    .IsUnicode(false)
                    .IsFixedLength();
            });

            modelBuilder.Entity<VCandidatesResultsR>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vCandidatesResultsR");

                entity.Property(e => e.CommunityCode).IsUnicode(false);

                entity.Property(e => e.OrderNum).IsUnicode(false);

                entity.Property(e => e.RegionCode)
                    .IsUnicode(false)
                    .IsFixedLength();
            });

            modelBuilder.Entity<VColumns>(entity =>
            {
                entity.Property(e => e.ColumnName).IsUnicode(false);
            });

            modelBuilder.Entity<VCommunitis>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vCommunitis");

                entity.Property(e => e.CommunityCode).IsUnicode(false);

                entity.Property(e => e.RegionCode)
                    .IsUnicode(false)
                    .IsFixedLength();
            });

            modelBuilder.Entity<VElections>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vElections");

                entity.Property(e => e.CommunityCode).IsUnicode(false);
            });

            modelBuilder.Entity<VElectiveResults>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vElectiveResults");
            });

            modelBuilder.Entity<VElectiveResults2>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vElectiveResults2");

                entity.Property(e => e.CommunityCode).IsUnicode(false);

                entity.Property(e => e.DistrictCode).IsUnicode(false);

                entity.Property(e => e.RegionCode)
                    .IsUnicode(false)
                    .IsFixedLength();
            });

            modelBuilder.Entity<VElectiveResultsR>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vElectiveResultsR");

                entity.Property(e => e.CommunityCode).IsUnicode(false);

                entity.Property(e => e.DistrictCode).IsUnicode(false);

                entity.Property(e => e.RegionCode)
                    .IsUnicode(false)
                    .IsFixedLength();
            });

            modelBuilder.Entity<VExpCandidatePersons>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vExpCandidatePersons");

                entity.Property(e => e.CommunityCode).IsUnicode(false);

                entity.Property(e => e.Passport).IsUnicode(false);

                entity.Property(e => e.Pn).IsUnicode(false);

                entity.Property(e => e.RegionCode).IsUnicode(false);
            });

            modelBuilder.Entity<VExpCommissionPersons>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vExpCommissionPersons");

                entity.Property(e => e.CommunityCode).IsUnicode(false);

                entity.Property(e => e.RegionCode).IsUnicode(false);
            });

            modelBuilder.Entity<VExpEntrustingPersons>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vExpEntrustingPersons");

                entity.Property(e => e.CommunityCode).IsUnicode(false);

                entity.Property(e => e.RegionCode).IsUnicode(false);
            });

            modelBuilder.Entity<VExpPartieOrParty>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vExpPartieOrParty");
            });

            modelBuilder.Entity<VExpPartieOrPartyPersons>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vExpPartieOrPartyPersons");

                entity.Property(e => e.CommunityCode).IsUnicode(false);

                entity.Property(e => e.Pn)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.RegionCode).IsUnicode(false);
            });

            modelBuilder.Entity<VGeoresults>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vGEOResults");

                entity.Property(e => e.CommunityCode).IsUnicode(false);

                entity.Property(e => e.OrderNum).IsUnicode(false);

                entity.Property(e => e.RegionCode)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.SubDistrictCode).IsUnicode(false);
            });

            modelBuilder.Entity<VGroup>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();
            });

            modelBuilder.Entity<VPartieOrPartyPersons>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vPartieOrPartyPersons");

                entity.Property(e => e.CommunityCode).IsUnicode(false);

                entity.Property(e => e.Pn)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.RegionCode).IsUnicode(false);
            });

            modelBuilder.Entity<VResult>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();
            });

            modelBuilder.Entity<VResult2>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();
            });

            modelBuilder.Entity<VResulteByDistrict>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vResulteByDistrict");
            });

            modelBuilder.Entity<VRound1>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();
            });

            modelBuilder.Entity<VRound12>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();
            });

            modelBuilder.Entity<VSatisfied>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();
            });

            modelBuilder.Entity<VSubDistricts>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vSubDistricts");

                entity.Property(e => e.CommunityCode).IsUnicode(false);

                entity.Property(e => e.DistrictCode).IsUnicode(false);

                entity.Property(e => e.RegionCode)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.SubDistrictCode).IsUnicode(false);
            });

            modelBuilder.Entity<WatcherElectTypes>(entity =>
            {
                entity.HasNoKey();
            });

            modelBuilder.Entity<Watchers>(entity =>
            {
                entity.Property(e => e.Sertificate)
                    .IsUnicode(false)
                    .IsFixedLength();
            });

            modelBuilder.Entity<WebAnnouncement>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.UId).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<WebCec>(entity =>
            {
                entity.Property(e => e.File).IsUnicode(false);

                entity.Property(e => e.FileEn).IsUnicode(false);
            });

            modelBuilder.Entity<WebCecEmployee>(entity =>
            {
                entity.Property(e => e.Email).IsUnicode(false);

                entity.Property(e => e.ImgUrl).IsUnicode(false);

                entity.Property(e => e.Phone).IsUnicode(false);
            });

            modelBuilder.Entity<WebCecarx>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.File).IsUnicode(false);

                entity.Property(e => e.FileEn).IsUnicode(false);
            });

            modelBuilder.Entity<WebNotifications>(entity =>
            {
                entity.HasKey(e => e.NotificatinId)
                    .HasName("PK_Notificatins");

                entity.Property(e => e.NotificatinId).ValueGeneratedNever();

                entity.Property(e => e.UId).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<WebSessions>(entity =>
            {
                entity.Property(e => e.FileUrl).IsUnicode(false);

                entity.Property(e => e.FileUrlEn).IsUnicode(false);

                entity.Property(e => e.VideoUrl).IsUnicode(false);
            });

            modelBuilder.Entity<WorkPositionTypes>(entity =>
            {
                entity.Property(e => e.WorkPositionId).ValueGeneratedNever();
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
