using Microsoft.AspNetCore.Components;
using PecMembers.UI.Data.Permissions;
using PecMembers.UI.Repositories.GenericRepoForPecMembers.PermissionsRepo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PecMembers.UI.Pages.Administrator.Permissions
{
    public class PermissionsBase:ComponentBase
    {
        [Inject]
        protected IPermissionsRepo permissionsRepo { get; set; }

        public PermissionModel permission  { get; set; }
        public List<PermissionModel> permissionList  { get; set; }

        //used to store state of screen
        protected string Message = string.Empty;
        protected string StatusClass = string.Empty;
        protected bool Show = false;
        protected override async Task OnInitializedAsync()
        {
            permissionList = permissionsRepo.GetAll().ToList();
            await base.OnInitializedAsync();
        }

        public async Task SavePermission()
        {
            try
            {
                if (permissionList != null)
                {
                    foreach (var permission in permissionList)
                    {
                        await permissionsRepo.UpdateAsync(permission);
                    }
                }
                StatusClass = "alert-success";
                Message = "Լիազորությունների խմբագրումը հաջողությամբ հաստատվեց";
                Show = true;
            }
            catch (Exception ex)
            {

                StatusClass = "alert-danger";
                Message = ex.Message;
            }

        }
    }
}
