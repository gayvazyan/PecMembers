using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Identity;
using PecMembers.UI.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PecMembers.UI.Pages.Administrator.Users
{
    public class ListUserBase:ComponentBase
    {
        [Parameter]
        public string Id { get; set; }
        [Inject]
        protected UserManager<ApplicationUser> userManager { get; set; }
        public List<ApplicationUser> userList { get; set; }
        public ApplicationUser user { get; set; }

        //used to store state of screen
        protected string Message = string.Empty;
        protected string StatusClass = string.Empty;
        protected bool  Deleted = false;

        protected override async Task OnInitializedAsync()
        {
            GetUser();
            await base.OnInitializedAsync();
        }

        public void GetUser()
        {
            user = userManager.Users.FirstOrDefault(p => p.Id == Id);
        }
        public async Task DeleteUser()
        {
          var result =   await userManager.DeleteAsync(user);
            if (result.Succeeded)
            {
                Message = user.UserName.ToString()+ " օգտատերը հաջողությամբ հեռացվեց";
                StatusClass = "alert-success";
                Deleted = true;
            }
            else
            {
                Message = result.Errors.ToString();
                StatusClass = "alert-danger";
            }
        }
    }
}
