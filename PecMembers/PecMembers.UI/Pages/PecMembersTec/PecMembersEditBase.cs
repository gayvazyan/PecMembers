using Microsoft.AspNetCore.Components;
using PecMembers.UI.Data.Enums;
using PecMembers.UI.Data.PecMemberModels;
using PecMembers.UI.Model;
using PecMembers.UI.Repositories.GenericRepoForCEC.ApplicantRepo;
using PecMembers.UI.Repositories.GenericRepoForPecMembers.PecMembersCurrentRepo;
using PecMembers.UI.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PecMembers.UI.Pages.PecMembersTec
{
    public class PecMembersEditBase:ComponentBase
    {
        [Parameter]
        public int Id { get; set; }
        [Parameter]
        public string DistrictIdString { get; set; } = string.Empty;
        [Inject]
        protected IPecMembersCurrentRepos pecMembersCurrentRepos { get; set; }
        public PecMembersCurrent pecMemberCurrent { get; set; }

        [Parameter]
        public List<string> ListCommunity { get; set; }
        [Parameter]
        public List<string> ListTEC { get; set; }

        //used to store state of screen
        protected string Message = string.Empty;
        protected string StatusClass = string.Empty;
        protected bool Show = false;
        protected bool ShowDelete = false;

        protected override async Task OnInitializedAsync()
        {
            if (Id != 0)
            {
                pecMemberCurrent = pecMembersCurrentRepos.GetByID(Id);
                DistrictIdString = pecMemberCurrent.DistrictId.ToString();
                Show = false;
                ShowDelete = false;
            }
            GetEnumsValue();
            await base.OnInitializedAsync();
        }
        public void GetEnumsValue()
        {
            ListCommunity = Enum.GetValues(typeof(Commun))
                .Cast<Commun>()
                .Select(v => v.ToString())
                .ToList();
            ListTEC = Enum.GetValues(typeof(District))
                .Cast<District>()
                .Select(v => v.ToString())
                .ToList();
        }
    
        public async Task UpdatePecMember()
        {
            if (!ShowDelete)
            {
                try
                {
                    /// int? DistrictIdInt = ListTEC.IndexOf(DistrictIdString) + 1;
                    pecMemberCurrent.DistrictId = ListTEC.IndexOf(DistrictIdString) + 1;
                    await pecMembersCurrentRepos.UpdateAsync(pecMemberCurrent);
                    Show = true;
                    StatusClass = "alert-success";
                    Message = "Քաղաքացի " + pecMemberCurrent.FullName + " տվյալները հաջողությամբ թարմացվեց:";
                }
                catch (Exception ex)
                {
                    StatusClass = "alert-danger";
                    Message = ex.Message;
                }
            }
        }

        public async Task DeletePecMember(PecMembersCurrent pecMemberCurrent)
        {
            try
            {
                await pecMembersCurrentRepos.DeleteAsync(pecMemberCurrent);
                StatusClass = "alert-danger";
                Message = "Քաղաքացի " + pecMemberCurrent.FullName + " տվյալները հաջողությամբ հեռացվեց:";
                Show = true;
                ShowDelete = true;
            }
            catch (Exception ex)
            {
                StatusClass = "alert-danger";
                Message = ex.Message;
            }
        }
    }
}

