using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Authorization;
using Microsoft.AspNetCore.Identity;
using PecMembers.UI.Data;
using PecMembers.UI.Data.Enums;
using PecMembers.UI.Data.PecMemberModels;
using PecMembers.UI.Model;
using PecMembers.UI.Repositories.GenericRepoForCEC.ApplicantRepo;
using PecMembers.UI.Repositories.GenericRepoForCEC.OldCerteficateRepo;
using PecMembers.UI.Repositories.GenericRepoForPecMembers.CurrentElectionRepo;
using PecMembers.UI.Repositories.GenericRepoForPecMembers.PecMembersCurrentRepo;
using PecMembers.UI.ViewModel;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Security.AccessControl;
using System.Threading.Tasks;
using Party = PecMembers.UI.Data.Enums.Party;
using Region = PecMembers.UI.Data.Enums.Region;

namespace PecMembers.UI.Pages.PecMembersTec
{
    public class PecMembersAddBase : ComponentBase
    {
        [Inject]
        protected RoleManager<IdentityRole> roleManager { get; set; }
        [Inject]
        protected UserManager<ApplicationUser> userManager { get; set; }
        public ApplicationUser user { get; set; }
        [Parameter]
        public string userName { get; set; } = string.Empty;

        [CascadingParameter]
        private Task<AuthenticationState> authenticationStateTask { get; set; }

        [Inject]
        protected IApplicantRepasitory applicantRepasitory { get; set; }
        public Applicant applicant { get; set; }
        public List<Applicant> applicantList { get; set; } = null;
        [Inject]
        protected IOldCerteficateRepository oldCerteficateRepository { get; set; }
        public OldCerteficate oldCerteficate { get; set; }
        public List<OldCerteficate> oldCerteficateList { get; set; } = null;

        [Parameter]
        public string Certeficate { get; set; } = string.Empty;
        [Parameter]
        public string TypeForCreate { get; set; } = string.Empty;

        
        [Parameter]
        public int ComunityId { get; set; }
        public string stringElectionId { get; set; } = "ընտրեք ընտրության տեսակը․․․";
       

        [Parameter]
        public PecMemberUIforTEC pecMember { get; set; } = new PecMemberUIforTEC { FirstName = "", LastName = "", Certeficate = "", MiddleName = "", Passport = "" };
        public List<PecMemberUIforTEC> pecmemberUIList = new List<PecMemberUIforTEC>();

        [Inject]
        protected IPecMembersCurrentRepos pecMembersCurrentRepos { get; set; }
        public List<PecMembersCurrent> pecMembersCurrentList { get; set; } = new List<PecMembersCurrent>();


        [Parameter]
        public List<string> ListCommunity { get; set; } = new List<string>();
        [Parameter]
        public List<string> ListTEC { get; set; } = new List<string>();

        [Parameter]
        public List<string> ListPEC { get; set; } = new List<string>();
        [Parameter]
        public List<string> ListTypeForCreate { get; set; } = new List<string>();


        [Inject]
        protected ICurrentElectionRepo currentElectionRepo { get; set; }
        public CurrentElection currentElection { get; set; }
        public DateTime dayElection { get; set; } = DateTime.Now;
        public DateTime startInputTime { get; set; }
        public DateTime endInputTime { get; set; }

        public List<PecMemberViewModel> pecMemberViewModelList { get; set; }
        public List<PecMemberViewModel> filteredPecMemberViewModelList { get; set; }

        [Parameter]
        public string SerchColumType1 { get; set; } = string.Empty;
        [Parameter]
        public string SerchColumType2 { get; set; } = string.Empty;
        [Parameter]
        public string SerchColumType3 { get; set; } = string.Empty;[Parameter]
        public string SerchColumType4 { get; set; } = string.Empty;
        [Parameter]
        public string SerchColumType5 { get; set; } = string.Empty;
        [Parameter]
        public string SerchColumType6 { get; set; } = string.Empty;
        [Parameter]
        public string SerchColumType7 { get; set; } = string.Empty;
        [Parameter]
        public string SerchColumType8 { get; set; } = string.Empty;
        [Parameter]
        public string SerchColumType9 { get; set; } = string.Empty;

        //used to store state of screen
        protected string Message = string.Empty;
        protected string StatusClass = string.Empty;
        protected bool ShowChooseElectionDay = true;
        protected bool Show = false;
        protected bool ShowAdded = false;
        //poxel false
        protected bool InputValid = true;


        protected override async Task OnInitializedAsync()
        {

            GetEnumsValue();
            InitializedPecMembers();
            //pecMembersCurrentList = pecMembersCurrentRepos.GetAll().ToList();
            userName = await GetTecName();
           
            //if (userName == "RoleAdmin")
            //{
            //    pecMemberViewModelList = InitializedPecMemberViewModel().Where(p => p.PartyView.Contains("ԸԸՀ")).ToList();
            //}
            //else
            //{
            //    pecMemberViewModelList = InitializedPecMemberViewModel().Where(p => p.PartyView.Contains(userName)).ToList();
            //}

            //filteredPecMemberViewModelList = pecMemberViewModelList;



            await base.OnInitializedAsync();
        }

        public List<PecMemberViewModel> InitializedPecMemberViewModel()
        {
            List<PecMemberViewModel> pecMemberViewModelList = new List<PecMemberViewModel>();
            pecMembersCurrentList = pecMembersCurrentRepos.GetAll()
                                                        .Where(p=>(p.ElectionDay==dayElection)
                                                        &&(p.ElectionId== ListTypeForCreate.IndexOf(stringElectionId)))
                                                        .ToList();
            foreach (var item in pecMembersCurrentList)
            {
                PecMemberViewModel pecMemberViewModel = new PecMemberViewModel()
                {
                    Id = item.Id,
                    ElectionDayView = item.ElectionDay.ToString("dd.MM.yyyy"),
                    DistrictView = item.DistrictId.ToString() != null ? item.DistrictId.ToString() : "",
                    SubDistrictCodeView = item.SubDistrictCode.ToString() != null ? item.SubDistrictCode.ToString() : "",
                    CommunityView = item.Name != null ? item.Name : "",
                    FullName = item.LastName + " " + item.FirstName + " " + item.MiddleName,
                    CerteficateView = item.Certeficate != null ? item.Certeficate : "",
                    PhoneNumberView = item.PhoneNumber != null ? item.PhoneNumber : "",
                    PartyView = item.PartyName != null ? item.PartyName : "",
                    PositionView = item.WorkPosition != null ? item.WorkPosition : "",
                };
                pecMemberViewModelList.Add(pecMemberViewModel);
            }
            return pecMemberViewModelList;

        }

        public void GetCommunityLst()
        {
            int idEl = ListTypeForCreate.IndexOf(stringElectionId);
            List<PecMembersCurrent> pecMembersList;
            if (userName == "RoleAdmin")
            {

                pecMembersList = pecMembersCurrentRepos.GetAll()
                    .Where(p => (p.ElectionDay == dayElection) && (p.ElectionId == idEl))
                    .ToList();

                var ListAllCommunity = new List<string>();
                foreach (var item in pecMembersList)
                {

                    ListAllCommunity.Add(item.Name);
                }
                var ListCommunity1 = ListAllCommunity.Distinct().ToList();
                ListCommunity.Add("");
                foreach (var item in ListCommunity1)
                {
                    ListCommunity.Add(item);
                }

                var ListAllPEC = new List<int?>();
                foreach (var item in pecMembersList)
                {
                    ListAllPEC.Add(item.SubDistrictCode);
                }
                var ListPecInt = ListAllPEC.Distinct()
                                     .OrderBy(p => p)
                                     .ToList();
                ListPEC.Add("");
                foreach (var item in ListPecInt)
                {
                    ListPEC.Add(item.ToString());
                }
            }
            else
            {
                ComunityId = ListTEC.IndexOf(userName);

                pecMembersList = pecMembersCurrentRepos.GetAll()
                   .Where(p => (p.DistrictId == ComunityId) && (p.ElectionDay == dayElection) && (p.ElectionId == idEl))
                   .ToList();

                var ListAllCommunity = new List<string>();
                foreach (var item in pecMembersList)
                {

                    ListAllCommunity.Add(item.Name);
                }

                var ListCommunity1 = ListAllCommunity.Distinct().ToList();
                ListCommunity.Add("");
                foreach (var item in ListCommunity1)
                {
                    ListCommunity.Add(item);
                }

                var ListAllPEC = new List<int?>();
                foreach (var item in pecMembersList)
                {
                    ListAllPEC.Add(item.SubDistrictCode);
                }

                var ListPecInt = ListAllPEC.Distinct()
                                     .OrderBy(p => p)
                                     .ToList();
                ListPEC.Add("");
                foreach (var item in ListPecInt)
                {
                    ListPEC.Add(item.ToString());
                }
            }

            if (stringElectionId== "ընտրեք ընտրության տեսակը․․․")
            {
                StatusClass = "alert-danger";
                Message = " ընտրեք ընտրության տեսակը․․․ ";
            }

            else
            {
                if (pecMembersList.Count() == 0)
                {
                    StatusClass = "alert-danger";
                    Message = dayElection.ToString("dd.MM.yyyy") + " ընտրության օրով " + stringElectionId.ToString().Replace("_", " ") + " ընտրություն չգտնվեց։";
                }
                else
                {
                    PecMembersCurrent pecMembersCurrent = pecMembersList.First();
                    DateTime electionDay = pecMembersCurrent.ElectionDay;
                    DateTime dateTimeNow = DateTime.Now;

                    currentElection = currentElectionRepo.GetAll().FirstOrDefault(p => (p.ElectionDay == pecMembersCurrent.ElectionDay) && (p.ElectionId == pecMembersCurrent.ElectionId));

                    endInputTime = currentElection.EndInputTime.AddHours(18);
                    startInputTime = currentElection.StartInputTime.AddHours(9);


                    if (dateTimeNow >= startInputTime && dateTimeNow <= endInputTime)
                    {
                        InputValid = true;
                    }


                    ShowChooseElectionDay = false;
                    Message = string.Empty;
                    StatusClass = string.Empty;


                    if (userName == "RoleAdmin")
                    {
                        pecMemberViewModelList = InitializedPecMemberViewModel().Where(p => p.PartyView.Contains("ԸԸՀ")).ToList();
                    }
                    else
                    {
                        pecMemberViewModelList = InitializedPecMemberViewModel().Where(p => p.PartyView.Contains(userName)).ToList();
                    }

                    filteredPecMemberViewModelList = pecMemberViewModelList;


                }
            }
        }

        private async Task<string> GetTecName()
        {
            string partyN = string.Empty;
            var authState = await authenticationStateTask;
            var user1 = authState.User;
            user = await userManager.GetUserAsync(user1);
            if (await userManager.IsInRoleAsync(user, "Admin"))
            {
                partyN = "RoleAdmin";
            }
            else
            {
                partyN = user.PName;
            }

            return partyN;
        }

        private void InitializedPecMembers()
        {
            applicantList = applicantRepasitory.GetAll().ToList();
            oldCerteficateList = oldCerteficateRepository.GetAll().ToList();
            foreach (var item in applicantList)
            {
                PecMemberUIforTEC pecMember = new PecMemberUIforTEC
                {
                    FirstName = item.ApplicantFirstName,
                    LastName = item.ApplicantLastName,
                    MiddleName = item.ApplicantMiddleName,
                    Passport = item.PassportNumber,
                    Certeficate = item.CertificateNumber.ToString(),
                    PhoneNumber = item.PhoneNumber,
                    Adress = item.Address,
                    Email = item.Email,
                    SSN = item.Ssn

                };
                pecmemberUIList.Add(pecMember);
            }

            foreach (var item in oldCerteficateList)
            {
                PecMemberUIforTEC pecMember = new PecMemberUIforTEC
                {
                    FirstName = item.FirstName,
                    LastName = item.LastName,
                    MiddleName = item.MiddleName,
                    Passport = item.Passport,
                    Certeficate = item.Certeficate,
                    PhoneNumber = "",
                    Adress = item.Address,
                    Email = "",
                    SSN = ""

                };
                pecmemberUIList.Add(pecMember);
            }
        }

        public List<PecMembersCurrent> GetAllPecMembers(DateTime electionDay)
        {
            List<PecMembersCurrent> allPecMembers = pecMembersCurrentRepos.GetAll()
                                                                           .Where(p => p.ElectionDay == electionDay)
                                                                           .ToList();
            return allPecMembers;
        }

        public void GetEnumsValue()
        {
            var ListTECWithOut = Enum.GetValues(typeof(District))
                 .Cast<District>()
                 .Select(v => v.ToString())
                 .ToList();

            ListTEC.Add("");
            foreach (var item in ListTECWithOut)
            {
                ListTEC.Add(item);
            }

            var ListTypeForCreateWithOut = Enum.GetValues(typeof(ElectionTypeForCreate))
                 .Cast<ElectionTypeForCreate>()
                 .Select(v => v.ToString())
                 .ToList();

            ListTypeForCreate.Add("");
            foreach (var item in ListTypeForCreateWithOut)
            {
                ListTypeForCreate.Add(item);
            }
        }

        public void PassportGet()
        {
            ShowAdded = false;
            Show = false;
            pecMember = pecmemberUIList.FirstOrDefault(p => p.Certeficate == Certeficate);

            if (pecMember == null)
            {
                StatusClass = "alert-danger";
                Message = "Սխալ!!! Մուտքագրված վկայականի համարով տվյալ չգտնվեց։";
            }
            else
            {
                StatusClass = "alert-success";
                Message = "Մուտքագրված է քաղաքացի՝ " + pecMember.LastName + " " + pecMember.FirstName + " " + pecMember.MiddleName + " տվյալները։ Շարունակեք Քայլ 2-ը։";
                Show = true;
            }
        }

        public async Task SavePecMember()
        {
            string DistrictIdString = string.Empty;
            int? DistrictIdInt;
            if (userName == "RoleAdmin")
            {
                if (pecMember.DistrictId != 0)
                {
                    DistrictIdString = pecMember.DistrictId.ToString();

                    DistrictIdInt = (pecMember.DistrictId != 0) ? (ListTEC.IndexOf(DistrictIdString)) : 0;
                }
                else
                {
                    DistrictIdString = "ԸԸՀ_1";
                    DistrictIdInt = ListTEC.IndexOf("ԸԸՀ_1");
                }

            }
            else
            {
                DistrictIdString = userName;
                DistrictIdInt = ListTEC.IndexOf(DistrictIdString);
            }


            var result = GetAllPecMembers(dayElection).Where(p => p.Certeficate == Certeficate).ToList();

            if (result.Count == 0)
            {
                PecMembersCurrent pecMembersCurrent = new PecMembersCurrent();
                try
                {
                    pecMembersCurrent.CreatedDay = DateTime.Now;
                    pecMembersCurrent.ElectionDay = dayElection;
                    pecMembersCurrent.Certeficate = pecMember.Certeficate;
                    pecMembersCurrent.FirstName = pecMember.FirstName;
                    pecMembersCurrent.LastName = pecMember.LastName;
                    pecMembersCurrent.MiddleName = pecMember.MiddleName;
                    pecMembersCurrent.Passport = pecMember.Passport;
                    pecMembersCurrent.SSN = pecMember.SSN;
                    pecMembersCurrent.PhoneNumber = pecMember.PhoneNumber;
                    pecMembersCurrent.Adress = pecMember.Adress;
                    pecMembersCurrent.Email = pecMember.Email;
                    pecMembersCurrent.WorkPosition = "անդամ";
                    pecMembersCurrent.WorkPositionId = 5;

                    pecMembersCurrent.PartyName = DistrictIdString;
                    pecMembersCurrent.SubDistrictCode = Convert.ToInt32(pecMember.SubDistrictCode);
                    pecMembersCurrent.DistrictId = DistrictIdInt;
                    pecMembersCurrent.Name = pecMember.ComunityName;
                    pecMembersCurrent.SubDistrict = DistrictIdInt.ToString() + "/" + pecMember.SubDistrictCode;
                    pecMembersCurrent.IsEmpty = true;
                    pecMembersCurrent.ElectionId = ListTypeForCreate.IndexOf(stringElectionId);

                    Certeficate = string.Empty;

                    ShowAdded = true;
                    await pecMembersCurrentRepos.InsertAsync(pecMembersCurrent);
                    StatusClass = "alert-success";
                    Message = "Քաղաքացի " + pecMembersCurrent.FullName + " տվյալները հաջողությամբ գրանցվեց";
                    Show = false;
                }
                catch (Exception ex)
                {

                    StatusClass = "alert-danger";
                    Message = ex.Message;
                }

            }
            else
            {
                StatusClass = "alert-danger";
                Message = Certeficate + " վկայականի համարով քաղաքացու տվյալները արդեն մուտքագրված են համակարգ։";
            }

        }


        public void OnPublisherSearchTextChanged(ChangeEventArgs changeEventArgs, string columnTitle)
        {
            string searchText = changeEventArgs.Value.ToString();
            // filteredPecMemberViewModelList = pecMemberViewModelList.Where(p => p.PartyView.Contains(searchText)).ToList();

            switch (columnTitle)
            {
                case "Ամսաթիվ":
                    SerchColumType1 = searchText;
                    break;
                case "ԸԸՀ":
                    SerchColumType2 = searchText;
                    break;
                case "ՏԸՀ":
                    SerchColumType3 = searchText;
                    break;
                case "Համայնք":
                    SerchColumType4 = searchText;
                    break;
                case "Անուն,Ազգանուն,Հայրանուն":
                    SerchColumType5 = searchText;
                    break;
                case "Վկայական":
                    SerchColumType6 = searchText;
                    break;
                case "Հեռախոս":
                    SerchColumType7 = searchText;
                    break;
                case "Կուսակ․":
                    SerchColumType8 = searchText;
                    break;
                case "Պաշտոն":
                    SerchColumType9 = searchText;
                    break;
                default:
                    Console.WriteLine("Default case");
                    break;
            }

            filteredPecMemberViewModelList = pecMemberViewModelList.Where(p => (p.ElectionDayView.Contains(SerchColumType1))
                                                                        && (p.DistrictView.Contains(SerchColumType2))
                                                                        && (p.SubDistrictCodeView.Contains(SerchColumType3))
                                                                        && (p.CommunityView.Contains(SerchColumType4))
                                                                        && (p.FullName.Contains(SerchColumType5))
                                                                        && (p.CerteficateView.Contains(SerchColumType6))
                                                                        && (p.PhoneNumberView.Contains(SerchColumType7))
                                                                        && (p.PartyView.Contains(SerchColumType8))
                                                                        && (p.PositionView.Contains(SerchColumType9)))
                                                                            .ToList();
        }

        public void Clear()
        {
            SerchColumType1 = string.Empty;
            SerchColumType2 = string.Empty;
            SerchColumType3 = string.Empty;
            SerchColumType4 = string.Empty;
            SerchColumType5 = string.Empty;
            SerchColumType6 = string.Empty;
            SerchColumType7 = string.Empty;
            SerchColumType8 = string.Empty;
            SerchColumType9 = string.Empty;
            filteredPecMemberViewModelList = pecMemberViewModelList;
        }

        public async Task Delete(PecMemberViewModel pecMemeber)
        {
            var pecMembersDeleted = pecMembersCurrentRepos.GetAll().FirstOrDefault(p => p.Id == pecMemeber.Id);
            try
            {
                await pecMembersCurrentRepos.DeleteAsync(pecMembersDeleted);

                StatusClass = "alert-success";
                Message = "Հաջողությամբ հեռացվեցին, թարմացրեք էջը ";
            }
            catch (Exception ex)
            {

                StatusClass = "alert-danger";
                Message = ex.Message;
            }
        }

    }
}

