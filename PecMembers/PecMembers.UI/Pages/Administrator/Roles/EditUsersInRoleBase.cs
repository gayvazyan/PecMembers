using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Identity;
using PecMembers.UI.Data;
using PecMembers.UI.ViewModel.RolesView;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PecMembers.UI.Pages.Administrator.Roles
{
    public class EditUsersInRoleBase : ComponentBase
    {
        [Inject]
        protected RoleManager<IdentityRole> roleManager { get; set; }

        [Inject]
        protected UserManager<ApplicationUser> userManager { get; set; }
        [Parameter]
        public string Id { get; set; }

        public IEnumerable<IdentityRole> roles { get; set; }

        [Parameter]
        public UserRoleViewModel userRoleViewModel { get; set; }
        [Parameter]
        public List<UserRoleViewModel> userRoleViewModelList { get; set; }

        //used to store state of screen
        protected string Message = string.Empty;
        protected string StatusClass = string.Empty;
        protected bool Show = false;
        protected override async Task OnInitializedAsync()
        {
            await FindeRole();
            await base.OnInitializedAsync();
        }


        public async Task FindeRole()
        {
            var role = await roleManager.FindByIdAsync(Id);
            if (role == null)
            {
                Message = Id + " ID-ով Role չգտնվեց";
                StatusClass = "alert-danger";
            }


            userRoleViewModelList = new List<UserRoleViewModel>();

            foreach (var user in userManager.Users.ToList())
            {
                var userRoleViewModel = new UserRoleViewModel
                {
                    UserId = user.Id,
                    UserName = user.UserName
                };

                if (await userManager.IsInRoleAsync(user, role.Name))
                {
                    userRoleViewModel.IsSelected = true;
                }
                else
                {
                    userRoleViewModel.IsSelected = false;
                }

                userRoleViewModelList.Add(userRoleViewModel);
            }
        }

        public async Task AddUserRole()
        {
            var role = await roleManager.FindByIdAsync(Id);
            if (role == null)
            {
                Message = Id + " ID-ով Role չգտնվեց";
                StatusClass = "alert-danger";
            }


            for (int i = 0; i < userRoleViewModelList.Count; i++)
            {
                var user = await userManager.FindByIdAsync(userRoleViewModelList[i].UserId);

                IdentityResult result = null;

                if (userRoleViewModelList[i].IsSelected && !(await userManager.IsInRoleAsync(user, role.Name)))
                {
                    result = await userManager.AddToRoleAsync(user, role.Name);
                }
                else if (!userRoleViewModelList[i].IsSelected && await userManager.IsInRoleAsync(user, role.Name))
                {
                    result = await userManager.RemoveFromRoleAsync(user, role.Name);
                }
                else
                {
                    continue;
                }
            }
            Message ="Գործողությունը հաջողությամբ իրականացվեց";
            StatusClass = "alert-success";
            Show = true;
        }
    }
}

    
