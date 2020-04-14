using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Identity;
using PecMembers.UI.ViewModel.RolesView;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PecMembers.UI.Pages.Administrator.Roles
{
    public class CreateRoleBase : ComponentBase
    {
        [Inject]
        protected RoleManager<IdentityRole> roleManager { get; set; }
        [Parameter]
        public CreateRoleViewModel createRoleViewModel { get; set; }

        //used to store state of screen
        protected string Message = string.Empty;
        protected string StatusClass = string.Empty;
        protected bool Show = false;
        protected override async Task OnInitializedAsync()
        {
            createRoleViewModel = new CreateRoleViewModel() { RoleName = "" };
            await base.OnInitializedAsync();
        }

        public async Task SaveRole()
        {
            try
            {
                // We just need to specify a unique role name to create a new role
                IdentityRole identityRole = new IdentityRole
                {
                    Name = createRoleViewModel.RoleName
                };
                // Saves the role in the underlying AspNetRoles table
                IdentityResult result = await roleManager.CreateAsync(identityRole);

                StatusClass = "alert-success";
                Message = "Role-ը հաջողությամբ ավելացվեց:";
                Show = true;
            }
            catch (Exception ex)
            {

                StatusClass = "alert-danger";
                Message = ex.ToString();
            }





        }
    }
}
