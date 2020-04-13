using Microsoft.AspNetCore.Components;
using PecMembers.UI.Data.Enums;
using PecMembers.UI.Data.PecMemberModels;
using PecMembers.UI.Model;
using PecMembers.UI.Repositories.GenericRepoForCEC.ApplicantRepo;
using PecMembers.UI.Repositories.GenericRepoForCEC.OldCerteficateRepo;
using PecMembers.UI.Repositories.GenericRepoForPecMembers.PecMembersCurrentRepo;
using PecMembers.UI.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Party = PecMembers.UI.Data.Enums.Party;
using Region = PecMembers.UI.Data.Enums.Region;

namespace PecMembers.UI.Pages.PecMembersTec
{
    public class PecMembersAddBase : ComponentBase
    {
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
        public PecMemberUIforTEC pecMember { get; set; } = new PecMemberUIforTEC { FirstName = "", LastName = "", Certeficate = "", MiddleName = "", Passport = "" };
        public List<PecMemberUIforTEC> pecmemberUIList = new List<PecMemberUIforTEC>();

        [Inject]
        protected IPecMembersCurrentRepos pecMembersCurrentRepos { get; set; }
        // public PecMembersCurrent pecMembersCurrent { get; set; }
        public List<PecMembersCurrent> pecMembersCurrentList { get; set; } = new List<PecMembersCurrent>();


        [Parameter]
        public List<string> ListCommunity { get; set; }
        [Parameter]
        public List<string> ListTEC { get; set; }


        //used to store state of screen
        protected string Message = string.Empty;
        protected string StatusClass = string.Empty;
        protected bool Show = false;
        protected bool ShowAdded = false;


        protected override async Task OnInitializedAsync()
        {
            InitializedPecMembers();
            pecMembersCurrentList = pecMembersCurrentRepos.GetAll().Where(p => (p.PartyName == "անդամ")).ToList();
            GetEnumsValue();
            await base.OnInitializedAsync();
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
            string DistrictIdString = pecMember.DistrictId.ToString();
            int? DistrictIdInt;
            DistrictIdInt = (pecMember.DistrictId != 0) ? (ListTEC.IndexOf(DistrictIdString) + 1) : 0;


            PecMembersCurrent pecMembersCurrent = new PecMembersCurrent();
            try
            {
                pecMembersCurrent.CreatedDay = DateTime.Now;
                pecMembersCurrent.ElectionDay = pecMember.ElectionDay;
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
                pecMembersCurrent.PartyName = "ՏԸՀ";
                pecMembersCurrent.SubDistrictCode = pecMember.SubDistrictCode;
                pecMembersCurrent.DistrictId = DistrictIdInt;
                pecMembersCurrent.Name = pecMember.Commun.ToString();
                pecMembersCurrent.SubDistrict= DistrictIdInt.ToString()+"/"+ pecMember.SubDistrictCode;
                pecMembersCurrent.IsEmpty = true;

                Certeficate = string.Empty;

                ShowAdded = true;
                await pecMembersCurrentRepos.InsertAsync(pecMembersCurrent);
                StatusClass = "alert-success";
                Message = "Քաղաքացի " + pecMembersCurrent.FullName + " տվյալները հաջողությամբ գրանցվեց";
            }
            catch (Exception ex)
            {

                StatusClass = "alert-danger";
                Message = ex.Message;
            }



        }
    }
}

