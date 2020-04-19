using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Authorization;
using Microsoft.AspNetCore.Identity;
using OfficeOpenXml.FormulaParsing.Excel.Functions.Text;
using PecMembers.UI.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PecMembers.UI.Pages.PecMemberReports
{
    public class PecMembersGenBase : ComponentBase
    {
        protected override async Task OnInitializedAsync()
        {
           
              await base.OnInitializedAsync();
        }
        
    }


}





