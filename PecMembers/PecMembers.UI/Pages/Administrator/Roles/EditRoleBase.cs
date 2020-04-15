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
    public class EditRoleBase : ComponentBase
    {
        [Inject]
        protected RoleManager<IdentityRole> roleManager { get; set; }

        [Inject]
        protected UserManager<ApplicationUser> userManager { get; set; }
        [Parameter]
        public string Id { get; set; }

        public IEnumerable<IdentityRole> roles { get; set; }

        [Parameter]
        public EditRoleViewModel editRoleViewModel { get; set; } = new EditRoleViewModel() { Id = "", RoleName = "" };

        //used to store state of screen
        protected string Message = string.Empty;
        protected string StatusClass = string.Empty;
        protected bool Deleted = false;
        protected override async Task OnInitializedAsync()
        {
            await FindeRole();
            await base.OnInitializedAsync();
        }

        public async Task FindeRole()
        {
            var role = await roleManager.FindByIdAsync(Id);
            if (role != null)
            {
                editRoleViewModel = new EditRoleViewModel
                {
                    Id = role.Id,
                    RoleName = role.Name,
                };

                // Retrieve all the Users 
                // userManager.Users-ը փոխում ենք userManager.Users.ToList()
                foreach (var user in userManager.Users.ToList())
                {

                    if (await userManager.IsInRoleAsync(user, role.Name))
                    {
                        editRoleViewModel.Users.Add(user.UserName);
                    }
                }
            }
        }

        public async Task UpdateRole()
        {
            var role = await roleManager.FindByIdAsync(editRoleViewModel.Id);
            role.Name = editRoleViewModel.RoleName;

            // Update the Role using UpdateAsync
            var result = await roleManager.UpdateAsync(role);
            StatusClass = "alert-success";
            Message = "Role-ի անունը փոխվեց";
        }

        public async Task DeleteRole()
        {
            var role = await roleManager.FindByIdAsync(Id);
            var result = await roleManager.DeleteAsync(role);
            if (result.Succeeded)
            {
                Message = role.Name.ToString() + " Role-ը հաջողությամբ հեռացվեց";
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
