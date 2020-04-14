#pragma checksum "C:\Users\gareg\source\repos\PecMembers\PecMembers\PecMembers.UI\Pages\Administrator\Roles\ListRoles.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "624007df09d1d08091174cd17e49d79d962a588c"
// <auto-generated/>
#pragma warning disable 1591
namespace PecMembers.UI.Pages.Administrator.Roles
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
    [Microsoft.AspNetCore.Components.RouteAttribute("/Administrator/Roles/ListRoles")]
    public partial class ListRoles : ListRolesBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h2 style=\"text-align:center;color:forestgreen\">Բոլոր Role-ները</h2>\r\n");
            __builder.OpenElement(1, "div");
            __builder.AddAttribute(2, "class", "alert" + " " + (
#nullable restore
#line 5 "C:\Users\gareg\source\repos\PecMembers\PecMembers\PecMembers.UI\Pages\Administrator\Roles\ListRoles.razor"
                   StatusClass

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(3, 
#nullable restore
#line 5 "C:\Users\gareg\source\repos\PecMembers\PecMembers\PecMembers.UI\Pages\Administrator\Roles\ListRoles.razor"
                                 Message

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(4, "\r\n\r\n");
#nullable restore
#line 7 "C:\Users\gareg\source\repos\PecMembers\PecMembers\PecMembers.UI\Pages\Administrator\Roles\ListRoles.razor"
 if (roles.Any())
{

#line default
#line hidden
#nullable disable
            __builder.AddContent(5, "    ");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Routing.NavLink>(6);
            __builder.AddAttribute(7, "href", 
#nullable restore
#line 9 "C:\Users\gareg\source\repos\PecMembers\PecMembers\PecMembers.UI\Pages\Administrator\Roles\ListRoles.razor"
                     $"Administrator/Roles/CreateRole"

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(8, "class", "btn btn-primary");
            __builder.AddAttribute(9, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(10, "\r\n        Ավելացնել նոր Role\r\n    ");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(11, "\r\n    <br>\r\n");
#nullable restore
#line 13 "C:\Users\gareg\source\repos\PecMembers\PecMembers\PecMembers.UI\Pages\Administrator\Roles\ListRoles.razor"
    foreach (var role in roles)
    {

#line default
#line hidden
#nullable disable
            __builder.AddContent(12, "        ");
            __builder.OpenElement(13, "div");
            __builder.AddAttribute(14, "class", "card mb-3");
            __builder.AddMarkupContent(15, "\r\n            ");
            __builder.OpenElement(16, "div");
            __builder.AddAttribute(17, "class", "card-header");
            __builder.AddMarkupContent(18, "\r\n                Role Id : ");
            __builder.AddContent(19, 
#nullable restore
#line 17 "C:\Users\gareg\source\repos\PecMembers\PecMembers\PecMembers.UI\Pages\Administrator\Roles\ListRoles.razor"
                           role.Id

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(20, "\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(21, "\r\n            ");
            __builder.OpenElement(22, "div");
            __builder.AddAttribute(23, "class", "card-body");
            __builder.AddMarkupContent(24, "\r\n                ");
            __builder.OpenElement(25, "h5");
            __builder.AddAttribute(26, "class", "card-title");
            __builder.AddContent(27, 
#nullable restore
#line 20 "C:\Users\gareg\source\repos\PecMembers\PecMembers\PecMembers.UI\Pages\Administrator\Roles\ListRoles.razor"
                                        role.Name

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(28, "\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(29, "\r\n            ");
            __builder.OpenElement(30, "div");
            __builder.AddAttribute(31, "class", "card-footer");
            __builder.AddMarkupContent(32, "\r\n                ");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Routing.NavLink>(33);
            __builder.AddAttribute(34, "href", 
#nullable restore
#line 23 "C:\Users\gareg\source\repos\PecMembers\PecMembers\PecMembers.UI\Pages\Administrator\Roles\ListRoles.razor"
                                 $"Administrator/Roles/EditRole/{role.Id}"

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(35, "class", "btn btn-info table-btn");
            __builder.AddAttribute(36, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(37, "\r\n                    Խմբագրել\r\n                ");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(38, "\r\n                ");
            __builder.AddMarkupContent(39, "<a href=\"#\" class=\"btn btn-danger\">Հեռացնել</a>\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(40, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(41, "\r\n");
#nullable restore
#line 29 "C:\Users\gareg\source\repos\PecMembers\PecMembers\PecMembers.UI\Pages\Administrator\Roles\ListRoles.razor"
    }
}
else
{

#line default
#line hidden
#nullable disable
            __builder.AddContent(42, "    ");
            __builder.OpenElement(43, "div");
            __builder.AddAttribute(44, "class", "card");
            __builder.AddMarkupContent(45, "\r\n        ");
            __builder.AddMarkupContent(46, "<div class=\"card-header\">\r\n           Ստեղծված Role չկա\r\n        </div>\r\n        ");
            __builder.OpenElement(47, "div");
            __builder.AddAttribute(48, "class", "card-body");
            __builder.AddMarkupContent(49, "\r\n            ");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Routing.NavLink>(50);
            __builder.AddAttribute(51, "href", 
#nullable restore
#line 38 "C:\Users\gareg\source\repos\PecMembers\PecMembers\PecMembers.UI\Pages\Administrator\Roles\ListRoles.razor"
                             $"Administrator/Roles/CreateRole"

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(52, "class", "btn btn-primary");
            __builder.AddAttribute(53, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(54, "\r\n                Ավելացնել նոր Role\r\n            ");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(55, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(56, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(57, "\r\n");
#nullable restore
#line 43 "C:\Users\gareg\source\repos\PecMembers\PecMembers\PecMembers.UI\Pages\Administrator\Roles\ListRoles.razor"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591
