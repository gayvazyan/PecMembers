#pragma checksum "C:\Users\gareg\source\repos\PecMembers\PecMembers\PecMembers.UI\Pages\Administrator\Roles\CreateRole.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0d36b5fd68dd7efbd0f1b3421bd263e6ff8a0e4d"
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
    [Microsoft.AspNetCore.Components.RouteAttribute("/Administrator/Roles/CreateRole")]
    public partial class CreateRole : CreateRoleBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h2 style=\"text-align:center;color:forestgreen\">Ստեղծել Role</h2>\r\n");
            __builder.OpenElement(1, "div");
            __builder.AddAttribute(2, "class", "alert" + " " + (
#nullable restore
#line 6 "C:\Users\gareg\source\repos\PecMembers\PecMembers\PecMembers.UI\Pages\Administrator\Roles\CreateRole.razor"
                   StatusClass

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(3, 
#nullable restore
#line 6 "C:\Users\gareg\source\repos\PecMembers\PecMembers\PecMembers.UI\Pages\Administrator\Roles\CreateRole.razor"
                                 Message

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(4, "\r\n<br>\r\n");
#nullable restore
#line 8 "C:\Users\gareg\source\repos\PecMembers\PecMembers\PecMembers.UI\Pages\Administrator\Roles\CreateRole.razor"
 if (!Show)
{

#line default
#line hidden
#nullable disable
            __builder.AddContent(5, "    ");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Forms.EditForm>(6);
            __builder.AddAttribute(7, "Model", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#nullable restore
#line 10 "C:\Users\gareg\source\repos\PecMembers\PecMembers\PecMembers.UI\Pages\Administrator\Roles\CreateRole.razor"
                      createRoleViewModel

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(8, "OnValidSubmit", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Forms.EditContext>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Forms.EditContext>(this, 
#nullable restore
#line 10 "C:\Users\gareg\source\repos\PecMembers\PecMembers\PecMembers.UI\Pages\Administrator\Roles\CreateRole.razor"
                                                           SaveRole

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(9, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Forms.EditContext>)((context) => (__builder2) => {
                __builder2.AddMarkupContent(10, "\r\n        ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.DataAnnotationsValidator>(11);
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(12, "\r\n        ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.ValidationSummary>(13);
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(14, "\r\n        ");
                __builder2.OpenElement(15, "div");
                __builder2.AddAttribute(16, "class", "col-12 row");
                __builder2.AddMarkupContent(17, "\r\n            ");
                __builder2.OpenElement(18, "div");
                __builder2.AddAttribute(19, "class", "col-10 row");
                __builder2.AddMarkupContent(20, "\r\n                ");
                __builder2.OpenElement(21, "div");
                __builder2.AddAttribute(22, "class", "col-xs-12 col-sm-8");
                __builder2.AddMarkupContent(23, "\r\n                    ");
                __builder2.OpenElement(24, "div");
                __builder2.AddAttribute(25, "class", "form-group row");
                __builder2.AddMarkupContent(26, "\r\n                        ");
                __builder2.AddMarkupContent(27, "<label class=\"col-sm-4 col-form-label\">Role-ի անունը</label>\r\n                        ");
                __builder2.OpenElement(28, "div");
                __builder2.AddAttribute(29, "class", "col-sm-8");
                __builder2.AddMarkupContent(30, "\r\n                            ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(31);
                __builder2.AddAttribute(32, "style", "width:100px");
                __builder2.AddAttribute(33, "class", "form-control col-sm-8");
                __builder2.AddAttribute(34, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 19 "C:\Users\gareg\source\repos\PecMembers\PecMembers\PecMembers.UI\Pages\Administrator\Roles\CreateRole.razor"
                                                                                                       createRoleViewModel.RoleName

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(35, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => createRoleViewModel.RoleName = __value, createRoleViewModel.RoleName))));
                __builder2.AddAttribute(36, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => createRoleViewModel.RoleName));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(37, "\r\n                        ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(38, "\r\n                    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(39, "\r\n                    ");
                __builder2.OpenElement(40, "div");
                __builder2.AddAttribute(41, "class", "form-group row");
                __builder2.AddMarkupContent(42, "\r\n                        ");
                __builder2.AddMarkupContent(43, "<button type=\"submit\" class=\"btn btn-primary \">Ավելացնել</button>&nbsp;&nbsp;\r\n                        ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Routing.NavLink>(44);
                __builder2.AddAttribute(45, "href", 
#nullable restore
#line 24 "C:\Users\gareg\source\repos\PecMembers\PecMembers\PecMembers.UI\Pages\Administrator\Roles\CreateRole.razor"
                                         $"/Administrator/Roles/ListRoles"

#line default
#line hidden
#nullable disable
                );
                __builder2.AddAttribute(46, "class", "btn btn-danger");
                __builder2.AddAttribute(47, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddMarkupContent(48, "\r\n                            Չեղարկել\r\n                        ");
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(49, "\r\n                    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(50, "\r\n                ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(51, "\r\n            ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(52, "\r\n        ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(53, "\r\n    ");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(54, "\r\n");
#nullable restore
#line 32 "C:\Users\gareg\source\repos\PecMembers\PecMembers\PecMembers.UI\Pages\Administrator\Roles\CreateRole.razor"
}
else
{

#line default
#line hidden
#nullable disable
            __builder.AddContent(55, "    ");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Routing.NavLink>(56);
            __builder.AddAttribute(57, "href", 
#nullable restore
#line 35 "C:\Users\gareg\source\repos\PecMembers\PecMembers\PecMembers.UI\Pages\Administrator\Roles\CreateRole.razor"
                     $"Administrator/Roles/ListRoles"

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(58, "class", "btn btn-info table-btn");
            __builder.AddAttribute(59, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(60, "\r\n        Վերադառնալ ցուցակ\r\n    ");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(61, "\r\n");
#nullable restore
#line 38 "C:\Users\gareg\source\repos\PecMembers\PecMembers\PecMembers.UI\Pages\Administrator\Roles\CreateRole.razor"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591
