#pragma checksum "C:\Users\gareg\source\repos\PecMembers\PecMembers\PecMembers.UI\Pages\Administrator\Administrator.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a2908bae91116e4327ee531383c7b206deaa293f"
// <auto-generated/>
#pragma warning disable 1591
namespace PecMembers.UI.Pages.Administrator
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\gareg\source\repos\PecMembers\PecMembers\PecMembers.UI\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\gareg\source\repos\PecMembers\PecMembers\PecMembers.UI\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\gareg\source\repos\PecMembers\PecMembers\PecMembers.UI\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\gareg\source\repos\PecMembers\PecMembers\PecMembers.UI\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\gareg\source\repos\PecMembers\PecMembers\PecMembers.UI\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\gareg\source\repos\PecMembers\PecMembers\PecMembers.UI\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\gareg\source\repos\PecMembers\PecMembers\PecMembers.UI\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\gareg\source\repos\PecMembers\PecMembers\PecMembers.UI\_Imports.razor"
using PecMembers.UI;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\gareg\source\repos\PecMembers\PecMembers\PecMembers.UI\_Imports.razor"
using PecMembers.UI.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\gareg\source\repos\PecMembers\PecMembers\PecMembers.UI\Pages\Administrator\Administrator.razor"
           [Authorize(Roles = "Admin")]

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/Administrator/Administrator")]
    public partial class Administrator : AdministratorBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "card-header");
            __builder.AddAttribute(2, "style", "padding:10px");
            __builder.AddMarkupContent(3, "\r\n        ");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Routing.NavLink>(4);
            __builder.AddAttribute(5, "href", 
#nullable restore
#line 9 "C:\Users\gareg\source\repos\PecMembers\PecMembers\PecMembers.UI\Pages\Administrator\Administrator.razor"
                         $"Administrator/Users/Users"

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(6, "class", "btn btn-primary table-btn");
            __builder.AddAttribute(7, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(8, "\r\n            User-ներ\r\n        ");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(9, "\r\n        ");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Routing.NavLink>(10);
            __builder.AddAttribute(11, "href", 
#nullable restore
#line 12 "C:\Users\gareg\source\repos\PecMembers\PecMembers\PecMembers.UI\Pages\Administrator\Administrator.razor"
                         $"Administrator/Roles/ListRoles"

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(12, "class", "btn btn-info table-btn");
            __builder.AddAttribute(13, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(14, "\r\n            Role-ներ\r\n        ");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(15, "\r\n        <br>\r\n    ");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591
