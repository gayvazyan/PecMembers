using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PecMembers.UI.Pages.Administrator.Roles
{
    public class ListRolesBase : ComponentBase
    {
        [Inject]
        protected RoleManager<IdentityRole> roleManager { get; set; }

        public IEnumerable<IdentityRole> roles { get; set; }
        //   [Parameter]
        //  public CreateRoleViewModel createRoleViewModel { get; set; }

        //used to store state of screen
        protected string Message = string.Empty;
        protected string StatusClass = string.Empty;
        protected bool Show = false;
        protected override async Task OnInitializedAsync()
        {
            roles = roleManager.Roles;
            await base.OnInitializedAsync();
        }

    }
}
