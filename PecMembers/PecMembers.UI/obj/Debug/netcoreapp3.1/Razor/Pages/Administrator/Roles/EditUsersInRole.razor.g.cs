#pragma checksum "C:\Users\gareg\source\repos\PecMembers\PecMembers\PecMembers.UI\Pages\Administrator\Roles\EditUsersInRole.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6f1e7418459b9db42fa151dec404bb287df7a084"
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
#nullable restore
#line 4 "C:\Users\gareg\source\repos\PecMembers\PecMembers\PecMembers.UI\Pages\Administrator\Roles\EditUsersInRole.razor"
           [Authorize(Roles = "Admin")]

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/Administrator/Roles/EditUsersInRole")]
    [Microsoft.AspNetCore.Components.RouteAttribute("/Administrator/Roles/EditUsersInRole/{Id}")]
    public partial class EditUsersInRole : EditUsersInRoleBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h2 style=\"text-align:center;color:forestgreen\"> Կցել կամ հեռացնել User</h2>\r\n");
            __builder.OpenElement(1, "div");
            __builder.AddAttribute(2, "class", "alert" + " " + (
#nullable restore
#line 7 "C:\Users\gareg\source\repos\PecMembers\PecMembers\PecMembers.UI\Pages\Administrator\Roles\EditUsersInRole.razor"
                   StatusClass

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(3, 
#nullable restore
#line 7 "C:\Users\gareg\source\repos\PecMembers\PecMembers\PecMembers.UI\Pages\Administrator\Roles\EditUsersInRole.razor"
                                 Message

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(4, "\r\n\r\n\r\n");
#nullable restore
#line 10 "C:\Users\gareg\source\repos\PecMembers\PecMembers\PecMembers.UI\Pages\Administrator\Roles\EditUsersInRole.razor"
 if (!Show)
{

    

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "C:\Users\gareg\source\repos\PecMembers\PecMembers\PecMembers.UI\Pages\Administrator\Roles\EditUsersInRole.razor"
     if (userRoleViewModelList != null)
    {

#line default
#line hidden
#nullable disable
            __builder.AddContent(5, "        ");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Forms.EditForm>(6);
            __builder.AddAttribute(7, "Model", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#nullable restore
#line 15 "C:\Users\gareg\source\repos\PecMembers\PecMembers\PecMembers.UI\Pages\Administrator\Roles\EditUsersInRole.razor"
                          userRoleViewModelList

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(8, "OnValidSubmit", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Forms.EditContext>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Forms.EditContext>(this, 
#nullable restore
#line 15 "C:\Users\gareg\source\repos\PecMembers\PecMembers\PecMembers.UI\Pages\Administrator\Roles\EditUsersInRole.razor"
                                                                 AddUserRole

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(9, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Forms.EditContext>)((context) => (__builder2) => {
                __builder2.AddMarkupContent(10, "\r\n\r\n\r\n            ");
                __builder2.OpenElement(11, "div");
                __builder2.AddAttribute(12, "class", "card-header");
                __builder2.AddMarkupContent(13, "\r\n");
#nullable restore
#line 19 "C:\Users\gareg\source\repos\PecMembers\PecMembers\PecMembers.UI\Pages\Administrator\Roles\EditUsersInRole.razor"
                 foreach (var item in userRoleViewModelList)
                {

#line default
#line hidden
#nullable disable
                __builder2.AddContent(14, "                    ");
                __builder2.OpenElement(15, "div");
                __builder2.AddAttribute(16, "class", "form-group row");
                __builder2.AddMarkupContent(17, "\r\n                        ");
                __builder2.OpenElement(18, "label");
                __builder2.AddMarkupContent(19, "\r\n                            ");
                __builder2.OpenElement(20, "label");
                __builder2.AddAttribute(21, "for", "UserName");
                __builder2.AddAttribute(22, "class", "col-sm-3");
                __builder2.AddMarkupContent(23, "Օգտատեր`");
                __builder2.AddContent(24, 
#nullable restore
#line 24 "C:\Users\gareg\source\repos\PecMembers\PecMembers\PecMembers.UI\Pages\Administrator\Roles\EditUsersInRole.razor"
                                                                            item.UserName

#line default
#line hidden
#nullable disable
                );
                __builder2.AddContent(25, " ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(26, "\r\n                            ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputCheckbox>(27);
                __builder2.AddAttribute(28, "class", "form-control col-sm-8");
                __builder2.AddAttribute(29, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 25 "C:\Users\gareg\source\repos\PecMembers\PecMembers\PecMembers.UI\Pages\Administrator\Roles\EditUsersInRole.razor"
                                                                                       item.IsSelected

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(30, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.Boolean>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.Boolean>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => item.IsSelected = __value, item.IsSelected))));
                __builder2.AddAttribute(31, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.Boolean>>>(() => item.IsSelected));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(32, "\r\n                        ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(33, "\r\n                    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(34, "\r\n");
#nullable restore
#line 28 "C:\Users\gareg\source\repos\PecMembers\PecMembers\PecMembers.UI\Pages\Administrator\Roles\EditUsersInRole.razor"
                }

#line default
#line hidden
#nullable disable
                __builder2.AddMarkupContent(35, "                <br>\r\n                ");
                __builder2.AddMarkupContent(36, "<button type=\"submit\" class=\"btn btn-primary \">Թարմացնել</button>&nbsp; &nbsp;\r\n                ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Routing.NavLink>(37);
                __builder2.AddAttribute(38, "href", 
#nullable restore
#line 31 "C:\Users\gareg\source\repos\PecMembers\PecMembers\PecMembers.UI\Pages\Administrator\Roles\EditUsersInRole.razor"
                                 $"/Administrator/RolesEditRole/{@Id}"

#line default
#line hidden
#nullable disable
                );
                __builder2.AddAttribute(39, "class", "btn btn-danger");
                __builder2.AddAttribute(40, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddMarkupContent(41, "\r\n                    Չեղարկել\r\n                ");
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(42, "\r\n            ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(43, "\r\n\r\n\r\n        ");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(44, "\r\n");
#nullable restore
#line 38 "C:\Users\gareg\source\repos\PecMembers\PecMembers\PecMembers.UI\Pages\Administrator\Roles\EditUsersInRole.razor"
    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 38 "C:\Users\gareg\source\repos\PecMembers\PecMembers\PecMembers.UI\Pages\Administrator\Roles\EditUsersInRole.razor"
     

}
else
{

#line default
#line hidden
#nullable disable
            __builder.AddContent(45, "    ");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Routing.NavLink>(46);
            __builder.AddAttribute(47, "href", 
#nullable restore
#line 43 "C:\Users\gareg\source\repos\PecMembers\PecMembers\PecMembers.UI\Pages\Administrator\Roles\EditUsersInRole.razor"
                     $"/Administrator/Roles/EditRole/{@Id}"

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(48, "class", "btn btn-success");
            __builder.AddAttribute(49, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(50, "\r\n        Վերադառնալ ցանկին\r\n    ");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(51, "\r\n");
#nullable restore
#line 46 "C:\Users\gareg\source\repos\PecMembers\PecMembers\PecMembers.UI\Pages\Administrator\Roles\EditUsersInRole.razor"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591
