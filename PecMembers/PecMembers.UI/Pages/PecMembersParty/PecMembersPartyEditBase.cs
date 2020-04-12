using Microsoft.AspNetCore.Components;
using Microsoft.JSInterop;
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

namespace PecMembers.UI.Pages.PecMembersParty
{
    public class PecMembersPartyEditBase : ComponentBase
    {
        [Parameter]
        public int Id { get; set; }

        [Inject]
        protected IApplicantRepasitory applicantRepasitory { get; set; }
        public Applicant applicant { get; set; }
        public List<Applicant> applicantList { get; set; } = null;

        [Inject]
        protected IPecMembersCurrentRepos pecMembersCurrentRepos { get; set; }
        public PecMembersCurrent pecMembersCurrent { get; set; }
        public List<PecMembersCurrent> pecMembersCurrentList { get; set; } = new List<PecMembersCurrent>();

        [Parameter]
        public string FirstName { get; set; } = string.Empty;
        [Parameter]
        public string LastName { get; set; } = string.Empty;
        [Parameter]
        public string MiddleName { get; set; } = string.Empty;
        [Parameter]
        public string PhoneNumber { get; set; } = string.Empty;
        [Parameter]
        public string Passport { get; set; } = string.Empty;
        [Parameter]
        public string Adress { get; set; } = string.Empty;
        [Parameter]
        public string Email { get; set; } = string.Empty;
        [Parameter]
        public string SSN { get; set; } = string.Empty;
        [Parameter]
        public PecMemberUIForParty pecMember { get; set; } = new PecMemberUIForParty { FirstName = "", LastName = "", Certeficate = "", MiddleName = "", Passport = "", Adress = "", Email = "", SSN = "" };
        public List<PecMemberUIForParty> pecmemberUIList = new List<PecMemberUIForParty>();


        [Parameter]
        public string Certeficate { get; set; } = string.Empty;

        //used to store state of screen
        protected string Message = string.Empty;
        protected string StatusClass = string.Empty;
        protected bool Show = false;
        protected bool ShowAdded = false;


        protected override async Task OnInitializedAsync()
        {
            pecMembersCurrent = pecMembersCurrentRepos.GetByID(Id);
            InitializedPecMembers();
            await base.OnInitializedAsync();
        }


        private void InitializedPecMembers()
        {

            applicantList = applicantRepasitory.GetAll().ToList();

            foreach (var item in applicantList)
            {
                PecMemberUIForParty pecMember = new PecMemberUIForParty
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
        }
        public void GetResult()
        {
            pecMember = pecmemberUIList.FirstOrDefault(p => p.Certeficate == Certeficate);
            if (pecMember == null)
            {
                StatusClass = "alert-danger";
                Message = "Սխալ!!! Մուտքագրված վկայականի համարով տվյալ չգտնվեց։";
            }
            else
            {
                FirstName = pecMember.FirstName;
                LastName = pecMember.LastName;
                MiddleName = pecMember.MiddleName;
                PhoneNumber = pecMember.PhoneNumber;
                Passport = pecMember.Passport;
                Email = pecMember.Email;
                Adress = pecMember.Adress;
                SSN = pecMember.SSN;
                StatusClass = "alert-success";
                Message = "Մուտքագրված է՝ " + LastName + " " + FirstName + " քաղաքացու տվյալները։ Շարունակեք Քայլ 2-ը։";
                Show = true;
            }

        }
        public async Task SavePecMember()
        {
            try
            {
                pecMembersCurrent.CreatedDay = DateTime.Now;
                pecMembersCurrent.Certeficate = pecMember.Certeficate;
                pecMembersCurrent.FirstName = pecMember.FirstName;
                pecMembersCurrent.LastName = pecMember.LastName;
                pecMembersCurrent.MiddleName = pecMember.MiddleName;
                pecMembersCurrent.Passport = pecMember.Passport;
                pecMembersCurrent.PhoneNumber = PhoneNumber;
                pecMembersCurrent.Adress = pecMember.Adress;
                pecMembersCurrent.Email = Email;
                pecMembersCurrent.SSN = pecMember.SSN;
                pecMembersCurrent.IsEmpty = true;

                ShowAdded = true;
                await pecMembersCurrentRepos.UpdateAsync(pecMembersCurrent);
                StatusClass = "alert-success";
                Message = "Քաղաքացի " + pecMembersCurrent.FullName + " տվյալները հաջողությամբ գրանցվեց";
            }
            catch (Exception ex)
            {

                StatusClass = "alert-danger";
                Message =ex.Message;
            }
            
            
        }
    }
}


