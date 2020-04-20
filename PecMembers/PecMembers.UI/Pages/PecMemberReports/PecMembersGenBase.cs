using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Authorization;
using Microsoft.AspNetCore.Identity;
using OfficeOpenXml.FormulaParsing.Excel.Functions.Text;
using PecMembers.UI.Data;
using PecMembers.UI.Data.Enums;
using PecMembers.UI.Data.PecMemberModels;
using PecMembers.UI.Repositories.GenericRepoForPecMembers.PecMembersCurrentRepo;
using PecMembers.UI.ViewModel;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading.Tasks;

namespace PecMembers.UI.Pages.PecMemberReports
{
    public class PecMembersGenBase : ComponentBase
    {

        public List<PecMemberViewModel> pecMemberViewModelList { get; set; }
        public List<PecMemberViewModel> filteredPecMemberViewModelList { get; set; }


        [Inject]
        protected IPecMembersCurrentRepos pecMembersCurrentRepos { get; set; }
        public PecMembersCurrent pecMembersCurrent { get; set; }
        public List<PecMembersCurrent> pecMembersCurrentList { get; set; } = new List<PecMembersCurrent>();


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
        [Parameter]
        public string SerchColumType10 { get; set; } = string.Empty;

        [Parameter]
        public string TypeForCreate { get; set; } = string.Empty;
        public List<string> ListTypeForCreate { get; set; }
        //used to store state of screen
        protected string Message = string.Empty;
        protected string StatusClass = string.Empty;



        protected override async Task OnInitializedAsync()
        {
            GetEnumsValue();
            InitializedPecMember();
            pecMemberViewModelList = InitializedPecMemberViewModel();
            filteredPecMemberViewModelList = pecMemberViewModelList;
            await base.OnInitializedAsync();
        }

        private void InitializedPecMember()
        {
            pecMembersCurrentList = pecMembersCurrentRepos.GetAll().ToList();
        }

        public List<PecMemberViewModel> InitializedPecMemberViewModel()
        {
           // CultureInfo culture = new CultureInfo("hy-AM");
            List<PecMemberViewModel> pecMemberViewModelList = new List<PecMemberViewModel>();

            foreach (var item in pecMembersCurrentList)
            {
                // string text = ListTypeForCreate.FindIndex()


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
                    TypeView = ListTypeForCreate[item.ElectionId - 1].ToString().Replace("_", " ")
                };
                pecMemberViewModelList.Add(pecMemberViewModel);
            }
            return pecMemberViewModelList;

        }
        public void GetEnumsValue()
        {

            ListTypeForCreate = Enum.GetValues(typeof(ElectionTypeForCreate))
               .Cast<ElectionTypeForCreate>()
               .Select(v => v.ToString())
               .ToList();
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
                case "Տեսակը":
                    SerchColumType10 = searchText;
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
                                                                        && (p.PositionView.Contains(SerchColumType9))
                                                                        && (p.TypeView.Contains(SerchColumType10)))
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
            SerchColumType10 = string.Empty;
            filteredPecMemberViewModelList = pecMemberViewModelList;
        }

        public async Task Delete()
        {
            try
            {
                pecMembersCurrentList = pecMembersCurrentRepos.GetAll().ToList();
                foreach (var item in pecMembersCurrentList)
                {
                    await pecMembersCurrentRepos.DeleteAsync(item);
                }
                
                StatusClass = "alert-success";
                Message = "Տվյալները հաջողությամբ հեռացվեցին, թարմացրեք էջը ";
            }
            catch (Exception ex)
            {

                StatusClass = "alert-danger";
                Message = ex.Message;
            }
        }

        public async Task DeletePecMember(PecMemberViewModel pecMemeber)
        {
            var pecMembersDeleted = pecMembersCurrentRepos.GetAll().FirstOrDefault(p => p.Id == pecMemeber.Id);
            try
            {
                    await pecMembersCurrentRepos.DeleteAsync(pecMembersDeleted);

                StatusClass = "alert-success";
                Message = "Տվյալները հաջողությամբ հեռացվեցին, թարմացրեք էջը ";
            }
            catch (Exception ex)
            {

                StatusClass = "alert-danger";
                Message = ex.Message;
            }
        }


    }


}





