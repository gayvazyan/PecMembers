using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Identity;
using PecMembers.UI.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PecMembers.UI.Pages.Administrator.Users
{
    public class UsersBase : ComponentBase
    {
        [Inject]
        protected UserManager<ApplicationUser> userManager { get; set; }
        public List<ApplicationUser> userList { get; set; }
        protected override async Task OnInitializedAsync()
        {
            GetListOfUsers();
            await base.OnInitializedAsync();
        }

        public void GetListOfUsers()
        {
            userList = new List<ApplicationUser>();
            foreach (var user in userManager.Users.ToList())
            {

                userList.Add(user);
            }
        }

    }
}
