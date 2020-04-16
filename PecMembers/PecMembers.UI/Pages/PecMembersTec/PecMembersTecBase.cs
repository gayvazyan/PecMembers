using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Authorization;
using Microsoft.AspNetCore.Identity;
using PecMembers.UI.Data;
using PecMembers.UI.Data.PecMemberModels;
using PecMembers.UI.Model;
using PecMembers.UI.Repositories.GenericRepoForCEC.ApplicantRepo;
using PecMembers.UI.Repositories.GenericRepoForPecMembers.PecMembersCurrentRepo;
using PecMembers.UI.ViewModel;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading.Tasks;

namespace PecMembers.UI.Pages.PecMembersTec
{
    public class PecMembersTecBase:ComponentBase
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
        protected IPecMembersCurrentRepos pecMembersCurrentRepos { get; set; }
        public PecMembersCurrent pecMembersCurrent { get; set; }
        public List<PecMembersCurrent> pecMembersCurrentList { get; set; } = new List<PecMembersCurrent>();
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
        protected bool Show = false;
        protected override async Task OnInitializedAsync()
        {
            userName = await GetPartyName();
            InitializedPecMember();
            if (userName != string.Empty)
            {
                pecMemberViewModelList = InitializedPecMemberViewModel().Where(p => p.PartyView == userName).ToList();
            }
            else
            {
                pecMemberViewModelList = InitializedPecMemberViewModel().Where(p=>p.PartyView.Contains("ԸԸՀ")).ToList();
            }

            filteredPecMemberViewModelList = pecMemberViewModelList;
            await base.OnInitializedAsync();
        }

        private void InitializedPecMember()
        {
            pecMembersCurrentList = pecMembersCurrentRepos.GetAll().ToList();
        }

        private async Task<string> GetPartyName()
        {
            string partyN = string.Empty;
            var authState = await authenticationStateTask;
            var user1 = authState.User;
            user = await userManager.GetUserAsync(user1);
            if (await userManager.IsInRoleAsync(user, "Admin"))
            {
                partyN = string.Empty;
            }
            else
            {
                partyN = user.PName;
            }
            return partyN;
        }

        public List<PecMemberViewModel> InitializedPecMemberViewModel()
        {
            CultureInfo culture = new CultureInfo("hy-AM");
            List<PecMemberViewModel> pecMemberViewModelList = new List<PecMemberViewModel>();

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
