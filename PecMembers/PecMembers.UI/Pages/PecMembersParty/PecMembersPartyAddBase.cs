using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Authorization;
using Microsoft.AspNetCore.Identity;
using PecMembers.UI.Data;
using PecMembers.UI.Data.Enums;
using PecMembers.UI.Data.PecMemberModels;
using PecMembers.UI.Model;
using PecMembers.UI.Repositories.GenericRepoForCEC.ApplicantRepo;
using PecMembers.UI.Repositories.GenericRepoForPecMembers.CurrentElectionRepo;
using PecMembers.UI.Repositories.GenericRepoForPecMembers.PecMembersCurrentRepo;
using PecMembers.UI.ViewModel;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading.Tasks;
using Party = PecMembers.UI.Data.Enums.Party;
using Region = PecMembers.UI.Data.Enums.Region;

namespace PecMembers.UI.Pages.PecMembersParty
{
    public class PecMembersPartyAddBase : ComponentBase
    {
        [Inject]
        protected UserManager<ApplicationUser> UserManager { get; set; }
        public ApplicationUser User { get; set; }
        [Parameter]
        public string NameParty { get; set; } = string.Empty;
        [Parameter]
        public string TypeForCreate { get; set; } = string.Empty;
        [Parameter]
        public bool isExtra { get; set; } = false;

        [CascadingParameter]
        private Task<AuthenticationState> authenticationStateTask { get; set; }

        [Parameter]
        public int Id { get; set; }
        [Inject]
        protected IPecMembersCurrentRepos pecMembersCurrentRepos { get; set; }

        public List<PecMembersCurrent> pecMembersCurrentList { get; set; } = new List<PecMembersCurrent>();

        [Parameter]
        public List<string> ListNameParty { get; set; }
        public List<string> ListTypeForCreate { get; set; }
        
        public DateTime dayElection { get; set; } = DateTime.Now;
        public DateTime startInputTime { get; set; }
        public DateTime endInputTime { get; set; }


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

        public List<PecMemberViewModel> pecMemberViewModelList { get; set; }
        public List<PecMemberViewModel> filteredPecMemberViewModelList { get; set; }

        [Inject]
        protected ICurrentElectionRepo currentElectionRepo { get; set; }
        public CurrentElection currentElection { get; set; }
       

        //used to store state of screen
        protected string Message = string.Empty;
        protected string StatusClass = string.Empty;
        protected bool Show = false;
        //poxel false
        protected bool InputValid = true;


        protected override async Task OnInitializedAsync()
        {
            GetEnumsValue();
            NameParty = await GetPartyName();
            if (Id != 0)
            {
                ReturnCondition();
            }
            else
            {
                pecMembersCurrentList = pecMembersCurrentRepos.GetAll().ToList();
                pecMemberViewModelList = InitializedPecMemberViewModel(pecMembersCurrentList);
                filteredPecMemberViewModelList = pecMemberViewModelList;
            }
            await base.OnInitializedAsync();
        }





        private async Task<string> GetPartyName()
        {
            string partyN = string.Empty;
            var authState = await authenticationStateTask;
            var user1 = authState.User;
            User = await UserManager.GetUserAsync(user1);
            if (await UserManager.IsInRoleAsync(User, "Admin"))
            {
                partyN = string.Empty;
            }
            else
            {
                partyN = User.PName;
            }

            return partyN;
        }

        public void ReturnCondition()
        {
            Show = true;
            PecMembersCurrent pecMembersCurrent = pecMembersCurrentRepos.GetByID(Id);
            currentElection = currentElectionRepo.GetAll().FirstOrDefault(p => (p.ElectionDay == pecMembersCurrent.ElectionDay) && (p.ElectionId == pecMembersCurrent.ElectionId));
            int idEl = pecMembersCurrent.ElectionId;
            NameParty = pecMembersCurrent.PartyName;
            dayElection = pecMembersCurrent.ElectionDay;
            pecMembersCurrentList = pecMembersCurrentRepos.GetAll().Where(p => (p.PartyName == NameParty) && (p.ElectionId == idEl)).ToList();

            pecMemberViewModelList = InitializedPecMemberViewModel(pecMembersCurrentList);
            filteredPecMemberViewModelList = pecMemberViewModelList;
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

        public void GetResult()
        {
            int idEl = ListTypeForCreate.IndexOf(TypeForCreate) + 1;
            pecMembersCurrentList = pecMembersCurrentRepos.GetAll()
                                                           .Where(p => (p.PartyName == NameParty) && (p.ElectionId == idEl))
                                                           .ToList();
            Show = true;
            if (pecMembersCurrentList.Count != 0)
            {
                filteredPecMemberViewModelList = InitializedPecMemberViewModel(pecMembersCurrentList);

                PecMembersCurrent pecMembersCurrent = pecMembersCurrentList.First();
                DateTime electionDay = pecMembersCurrent.ElectionDay;
                DateTime dateTimeNow = DateTime.Now;

                currentElection = currentElectionRepo.GetAll().FirstOrDefault(p => (p.ElectionDay == pecMembersCurrent.ElectionDay) && (p.ElectionId == pecMembersCurrent.ElectionId));

                endInputTime = currentElection.EndInputTime.AddHours(18);
                startInputTime = currentElection.StartInputTime.AddHours(9);


                if (dateTimeNow >= startInputTime && dateTimeNow <= endInputTime)
                {
                    InputValid = true;
                }

            }

            else
            {
                filteredPecMemberViewModelList = null;
            }
        }

        public List<PecMemberViewModel> InitializedPecMemberViewModel(List<PecMembersCurrent> List)
        {

            //CultureInfo culture = new CultureInfo("hy-AM");
            List<PecMemberViewModel> pecMemberViewModelList = new List<PecMemberViewModel>();

            foreach (var item in List)
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
                    IsEmpty = item.IsEmpty

                };
                pecMemberViewModelList.Add(pecMemberViewModel);
            }
            return pecMemberViewModelList;

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
    }
}
