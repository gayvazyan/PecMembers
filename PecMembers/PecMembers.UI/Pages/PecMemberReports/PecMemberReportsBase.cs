using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using OfficeOpenXml;
using OfficeOpenXml.Style;
using PecMembers.UI.Data.Enums;
using PecMembers.UI.Model;
using PecMembers.UI.Services;
using PecMembers.UI.Repositories.CommunitisRepo;
using PecMembers.UI.Services.DistrictsRepo;
using PecMembers.UI.ViewModel;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Net.Mail;
using System.Threading.Tasks;
using PecMembers.UI.Repositories.ElectionsRepo;
using PecMembers.UI.Services.PecMemberElectResultRepo;
using PecMembers.UI.Repositories.PartisInfoRepo;
using PecMembers.UI.Data.PecMemberModels;
using PecMembers.UI.Repositories.GenericRepoForPecMembers.PecMembersCurrentRepo;
using PecMembers.UI.Data;
using Microsoft.JSInterop;
using PecMembers.UI.Repositories.GenericRepoForPecMembers.CurrentElectionRepo;

namespace PecMembers.UI.Pages.PecMemberReports
{
    public class PecMemberReportsBase : ComponentBase
    {
        [Inject]
        protected IJSRuntime jJSRuntime { get; set; }
        [Inject]
        protected IElectionsRepo electionsRepo { get; set; }
        [Inject]
        protected IPecMemberElectResultRepo pecMemberElectResultRepo { get; set; }
        //[Inject]
        //protected IPecMemberRepository pecMemberRepository { get; set; }
        [Inject]
        protected IPecMembersCurrentRepos pecMembersCurrentRepos { get; set; }


        [Inject]
        protected ICommunitisRepo communitisRepo { get; set; }
        [Inject]
        protected IDistrictsRepo districtsRepo { get; set; }
        [Inject]
        protected IPartisInfoRepo partisInfoRepo { get; set; }
        [Inject]
        protected IWebHostEnvironment _webHostEnvironment { get; set; }
        [Inject]
        protected IConfiguration _configuration { get; set; }
        public Elections election { get; set; }
        public List<Elections> electionList { get; set; }
        public PecMemberElectResult pecMemberElectResult { get; set; }

        public List<PecMemberElectResult> pecMemberElectResultList { get; set; }

        public Communitis community { get; set; }

        public List<Communitis> communityList { get; set; }
        public Districts district { get; set; }

        public List<Districts> districtList { get; set; }
        public PartisInfo partisInfo { get; set; }

        public List<PartisInfo> partisInfoList { get; set; }

        [Parameter]
        public List<string> ListNameParty { get; set; }
        [Parameter]
        public List<string> ListTypeForCreate { get; set; }

        public InputeForQueryViewModel forQuery { get; set; }= new InputeForQueryViewModel();
        public TimViewModel timViewModel { get; set; }
        public List<TimViewModel> timViewModelList { get; set; } = new List<TimViewModel>();
        public List<PecMembersCurrent> pecMembersCurrentList { get; set; } = new List<PecMembersCurrent>();



        [Inject]
        protected ICurrentElectionRepo currentElectionRepo { get; set; }
     //   public CurrentElection currentElection { get; set; }
        public List<CurrentElection> currentElectionList { get; set; }


        //used to store state of screen
        protected string Message = string.Empty;
        protected string StatusClass = string.Empty;
        protected bool Show = false;
        protected bool Empty = false;

        protected override async Task OnInitializedAsync()
        {

            GetEnumsValue();
            await base.OnInitializedAsync();
        }

        public void GetEnumsValue()
        {
            ListNameParty = Enum.GetValues(typeof(PartisName))
                .Cast<PartisName>()
                .Select(v => v.ToString())
                .ToList();
            ListTypeForCreate = Enum.GetValues(typeof(ElectionTypeForCreate))
                .Cast<ElectionTypeForCreate>()
                .Select(v => v.ToString())
                .ToList();

        }
        private List<TimViewModel> CreatPecTim(string name, DateTime dateElectionDay)
        {

            electionList = electionsRepo.GetAll().ToList();
            pecMemberElectResultList = pecMemberElectResultRepo.GetAll().ToList();
            communityList = communitisRepo.GetAll().ToList();
            districtList = districtsRepo.GetAll().ToList();
            partisInfoList = partisInfoRepo.GetAll().ToList();




            var ee = (from election in electionList
                      where election.SrartDate == dateElectionDay
                      select (election.CommunityCode, election.SrartDate, election.IsExtra))
                          .ToList();


            var resultTimChairman = (from PM in pecMemberElectResultList
                                     where PM.ElectionDate == dateElectionDay
                                     join C in communityList on PM.CommunityCode equals C.CommunityCode
                                     join e in ee on PM.CommunityCode equals e.CommunityCode
                                     join e2 in ee on PM.ElectionDate equals e2.SrartDate
                                     join PI2 in partisInfoList on PM.Chairman equals PI2.Id
                                     orderby (PM.DistrictId, PM.SubDistrictCode)
                                     select new
                                     {
                                         PM.DistrictId,
                                         PM.SubDistrictCode,
                                         C.Name,
                                         PM.SubDistrict,
                                         WorkPositionId = name == PI2.ShortName ? 2 : 5,
                                         WorkPosition = name == PI2.ShortName ? "նախագահ" : "անդամ",
                                         e.IsExtra
                                     })
                        .Distinct()
                        .ToList();

            var resultTimSecretary = (from PM in pecMemberElectResultList
                                      where PM.ElectionDate == dateElectionDay
                                      join C in communityList on PM.CommunityCode equals C.CommunityCode
                                      join e in ee on PM.CommunityCode equals e.CommunityCode
                                      join e2 in ee on PM.ElectionDate equals e2.SrartDate
                                      join PI2 in partisInfoList on PM.Secretary equals PI2.Id
                                      orderby (PM.DistrictId, PM.SubDistrictCode)
                                      select new
                                      {
                                          PM.DistrictId,
                                          PM.SubDistrictCode,
                                          C.Name,
                                          PM.SubDistrict,
                                          WorkPositionId = name == PI2.ShortName ? 4 : 5,
                                          WorkPosition = name == PI2.ShortName ? "քարտուղար" : "անդամ",
                                          e.IsExtra
                                      })
                       .Distinct()
                       .ToList();


            var resultTim = resultTimChairman.Concat(resultTimSecretary)
                .OrderBy(p => p.DistrictId)
                .ThenBy(p => p.SubDistrict)
                .ToList();

            List<TimViewModel> timViewModels = new List<TimViewModel>();
            foreach (var item in resultTim)
            {
                TimViewModel timViewModel = new TimViewModel()

                {
                    DistrictId = item.DistrictId,
                    SubDistrictCode = item.SubDistrictCode,
                    Name = item.Name,
                    SubDistrict = item.SubDistrict,
                    WorkPositionId = item.WorkPositionId,
                    WorkPosition = item.WorkPosition
                };
                timViewModels.Add(timViewModel);
                switch (timViewModel.WorkPositionId)
                {
                    case 2:
                        forQuery.countChairman++;
                        break;
                    case 4:
                        forQuery.countSecretary++;
                        break;
                    default:
                        forQuery.countMember++;
                        break;
                }
            }
            return timViewModels;
        }

        private List<TimViewModel> CreatPecHam(string name, DateTime dateElectionDay)
        {
            if (name == "ԱՅՈ") name = "«ԱՅՈ»";
            if (name == "ՈՉ") name = "«ՈՉ»";

            electionList = electionsRepo.GetAll().ToList();
            pecMemberElectResultList = pecMemberElectResultRepo.GetAll().ToList();
            communityList = communitisRepo.GetAll().ToList();
            districtList = districtsRepo.GetAll().ToList();
            partisInfoList = partisInfoRepo.GetAll().ToList();




            var ee = (from election in electionList
                      where election.SrartDate == dateElectionDay
                      select (election.CommunityCode, election.SrartDate, election.IsExtra))
                          .ToList();


            var resultTimChairman = (from PM in pecMemberElectResultList
                                     where PM.ElectionDate == dateElectionDay
                                     join C in communityList on PM.CommunityCode equals C.CommunityCode
                                     //join e in ee on PM.CommunityCode equals e.CommunityCode
                                     //join e2 in ee on PM.ElectionDate equals e2.SrartDate
                                     join PI2 in partisInfoList on PM.Chairman equals PI2.Id
                                     orderby (PM.DistrictId, PM.SubDistrictCode)
                                     select new
                                     {
                                         PM.DistrictId,
                                         PM.SubDistrictCode,
                                         C.Name,
                                         PM.SubDistrict,
                                         WorkPositionId = name == PI2.ShortName ? 2 : 5,
                                         WorkPosition = name == PI2.ShortName ? "նախագահ" : "անդամ",
                                         // e.IsExtra
                                     })
                        .Distinct()
                        .ToList();

            var resultTimSecretary = (from PM in pecMemberElectResultList
                                      where PM.ElectionDate == dateElectionDay
                                      join C in communityList on PM.CommunityCode equals C.CommunityCode
                                      //join e in ee on PM.CommunityCode equals e.CommunityCode
                                      //join e2 in ee on PM.ElectionDate equals e2.SrartDate
                                      join PI2 in partisInfoList on PM.Secretary equals PI2.Id
                                      orderby (PM.DistrictId, PM.SubDistrictCode)
                                      select new
                                      {
                                          PM.DistrictId,
                                          PM.SubDistrictCode,
                                          C.Name,
                                          PM.SubDistrict,
                                          WorkPositionId = name == PI2.ShortName ? 4 : 5,
                                          WorkPosition = name == PI2.ShortName ? "քարտուղար" : "անդամ",
                                          //  e.IsExtra
                                      })
                       .Distinct()
                       .ToList();


            var resultTim = resultTimChairman.Concat(resultTimSecretary)
                .OrderBy(p => p.DistrictId)
                .ThenBy(p => p.SubDistrict)
                .ToList();

            List<TimViewModel> timViewModels = new List<TimViewModel>();
            foreach (var item in resultTim)
            {
                TimViewModel timViewModel = new TimViewModel()

                {
                    DistrictId = item.DistrictId,
                    SubDistrictCode = item.SubDistrictCode,
                    Name = item.Name,
                    SubDistrict = item.SubDistrict,
                    WorkPositionId = item.WorkPositionId,
                    WorkPosition = item.WorkPosition
                };
                timViewModels.Add(timViewModel);

                switch (timViewModel.WorkPositionId)
                {
                    case 2:
                        forQuery.countChairman++;
                        break;
                    case 4:
                        forQuery.countSecretary++;
                        break;
                    default:
                        forQuery.countMember++;
                        break;
                }
            }
            return timViewModels;
        }

        public void HandleValidSubmit()
        {
            //stugum en hamapetakany
            if (ListTypeForCreate.IndexOf(forQuery.TypeForCreate) + 1<5)
            {
                timViewModelList = CreatPecHam(forQuery.NameParty, forQuery.dayElection);
            }
            else
            {

                timViewModelList = CreatPecTim(forQuery.NameParty, forQuery.dayElection);
            }

            Show = true;



            if (timViewModelList.Count != 0)
            {
                StatusClass = "alert-success";
                Message = "Տվյալները հաջողությամբ գեներացվեց";
                CultureInfo culture = new CultureInfo("hy-AM");
                forQuery.dayElectionArm = forQuery.dayElection.Day + " " + forQuery.dayElection.ToString("MMMM", culture) + "ի, " + forQuery.dayElection.Year + "թ․";

            }
            else
            {
                StatusClass = "alert-danger";
                Message = "Հարցմանը տվյալներ չգտնվեց";
                Empty = true;
            }

        }

        public void SaveToDb()
        {
            try
            {
                CurrentElection currentElection = new CurrentElection()
                {
                  ElectionId = ListTypeForCreate.IndexOf(forQuery.TypeForCreate)+1,
                    ElectionDay = forQuery.dayElection,
                    //IsExtra = forQuery.isExtra,
                    //IsRep = forQuery.isRep,
                    StartInputTime=forQuery.startInputTime,
                    EndInputTime=forQuery.endInputTime
                    

                };
                currentElectionRepo.Insert(currentElection);

                foreach (var item in timViewModelList)
                {
                   

                   

                    PecMembersCurrent pecMember = new PecMembersCurrent()
                    {
                        DistrictId = item.DistrictId,
                        SubDistrictCode = item.SubDistrictCode,
                        Name = item.Name,
                        SubDistrict = item.SubDistrict,
                        WorkPositionId = item.WorkPositionId,
                        WorkPosition = item.WorkPosition,
                        ElectionId = ListTypeForCreate.IndexOf(forQuery.TypeForCreate)+1,
                        ElectionDay = forQuery.dayElection,
                        CreatedDay = DateTime.Now,
                        PartyName = forQuery.NameParty,
                        FirstName = string.Empty,
                        LastName = string.Empty,
                        MiddleName = string.Empty,
                        Passport = string.Empty,
                        Certeficate = string.Empty,
                        PhoneNumber = string.Empty,
                        //IsExtra=forQuery.isExtra,
                        //IsRep= forQuery.isRep



                    };
                    pecMembersCurrentRepos.Insert(pecMember);



                }
                StatusClass = "alert-success";
                Message = "Տվյալները գրանցվեց բազայում";

            }
            catch (Exception ex)
            {

                StatusClass = "alert-danger";
                Message = ex.Message;
            }
        }
    }
}
