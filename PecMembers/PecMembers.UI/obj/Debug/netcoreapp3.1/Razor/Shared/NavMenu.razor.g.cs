#pragma checksum "C:\Users\gareg\source\repos\PecMembers\PecMembers\PecMembers.UI\Shared\NavMenu.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "bf19064890d3b5f1f7ce882bd813df2e6081afaf"
// <auto-generated/>
#pragma warning disable 1591
namespace PecMembers.UI.Shared
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
    public partial class NavMenu : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "top-row pl-4 navbar navbar-dark");
            __builder.AddMarkupContent(2, "\r\n    ");
            __builder.AddMarkupContent(3, "<a class=\"navbar-brand\" href>ՏԸՀ անդամներ</a>\r\n    ");
            __builder.OpenElement(4, "button");
            __builder.AddAttribute(5, "class", "navbar-toggler");
            __builder.AddAttribute(6, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 4 "C:\Users\gareg\source\repos\PecMembers\PecMembers\PecMembers.UI\Shared\NavMenu.razor"
                                             ToggleNavMenu

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(7, "\r\n        <span class=\"navbar-toggler-icon\"></span>\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(8, "\r\n");
            __builder.CloseElement();
            __builder.AddMarkupContent(9, "\r\n\r\n");
            __builder.OpenElement(10, "div");
            __builder.AddAttribute(11, "class", 
#nullable restore
#line 9 "C:\Users\gareg\source\repos\PecMembers\PecMembers\PecMembers.UI\Shared\NavMenu.razor"
             NavMenuCssClass

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(12, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 9 "C:\Users\gareg\source\repos\PecMembers\PecMembers\PecMembers.UI\Shared\NavMenu.razor"
                                        ToggleNavMenu

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(13, "\r\n\r\n    ");
            __builder.OpenElement(14, "ul");
            __builder.AddAttribute(15, "class", "nav flex-column");
            __builder.AddMarkupContent(16, "\r\n        ");
            __builder.OpenElement(17, "li");
            __builder.AddAttribute(18, "class", "nav-item px-3");
            __builder.AddMarkupContent(19, "\r\n            ");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Routing.NavLink>(20);
            __builder.AddAttribute(21, "class", "nav-link");
            __builder.AddAttribute(22, "href", "");
            __builder.AddAttribute(23, "Match", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.Routing.NavLinkMatch>(
#nullable restore
#line 13 "C:\Users\gareg\source\repos\PecMembers\PecMembers\PecMembers.UI\Shared\NavMenu.razor"
                                                     NavLinkMatch.All

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(24, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(25, "\r\n                <span class=\"oi oi-home\" aria-hidden=\"true\"></span> Սկիզբ\r\n            ");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(26, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(27, "\r\n        ");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Authorization.AuthorizeView>(28);
            __builder.AddAttribute(29, "Roles", "Admin");
            __builder.AddAttribute(30, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Authorization.AuthenticationState>)((context) => (__builder2) => {
                __builder2.AddMarkupContent(31, "\r\n            ");
                __builder2.OpenElement(32, "li");
                __builder2.AddAttribute(33, "class", "nav-item px-3");
                __builder2.AddMarkupContent(34, "\r\n                ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Routing.NavLink>(35);
                __builder2.AddAttribute(36, "class", "nav-link");
                __builder2.AddAttribute(37, "href", "PecMemberReports/PecMembersGen");
                __builder2.AddAttribute(38, "Match", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.Routing.NavLinkMatch>(
#nullable restore
#line 19 "C:\Users\gareg\source\repos\PecMembers\PecMembers\PecMembers.UI\Shared\NavMenu.razor"
                                                                                       NavLinkMatch.All

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(39, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddMarkupContent(40, "\r\n                    <span class=\"oi oi-pencil\" aria-hidden=\"true\"></span> ՏԸՀ կազմ\r\n                ");
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(41, "\r\n            ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(42, "\r\n        ");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(43, "\r\n        ");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Authorization.AuthorizeView>(44);
            __builder.AddAttribute(45, "Roles", "Admin,Tec");
            __builder.AddAttribute(46, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Authorization.AuthenticationState>)((context) => (__builder2) => {
                __builder2.AddMarkupContent(47, "\r\n\r\n            ");
                __builder2.OpenElement(48, "li");
                __builder2.AddAttribute(49, "class", "nav-item px-3");
                __builder2.AddMarkupContent(50, "\r\n                ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Routing.NavLink>(51);
                __builder2.AddAttribute(52, "class", "nav-link");
                __builder2.AddAttribute(53, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 27 "C:\Users\gareg\source\repos\PecMembers\PecMembers\PecMembers.UI\Shared\NavMenu.razor"
                                                    ()=>expandSubNavTec = !expandSubNavTec

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(54, "Match", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.Routing.NavLinkMatch>(
#nullable restore
#line 27 "C:\Users\gareg\source\repos\PecMembers\PecMembers\PecMembers.UI\Shared\NavMenu.razor"
                                                                                                   NavLinkMatch.All

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(55, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddMarkupContent(56, "\r\n                    <span class=\"oi oi-people\" aria-hidden=\"true\"></span> ՏԸՀ ընտր․\r\n                ");
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(57, "\r\n\r\n");
#nullable restore
#line 31 "C:\Users\gareg\source\repos\PecMembers\PecMembers\PecMembers.UI\Shared\NavMenu.razor"
                 if (expandSubNavTec)
                {

#line default
#line hidden
#nullable disable
                __builder2.AddContent(58, "                ");
                __builder2.OpenElement(59, "li");
                __builder2.AddAttribute(60, "class", "nav-item px-3");
                __builder2.AddMarkupContent(61, "\r\n                    ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Routing.NavLink>(62);
                __builder2.AddAttribute(63, "class", "expand-menu");
                __builder2.AddAttribute(64, "href", "PecMembersTec/PecMembersTec");
                __builder2.AddAttribute(65, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddMarkupContent(66, "\r\n                        &nbsp;&nbsp;&nbsp;&nbsp;  <span class=\"oi oi-inbox\" aria-hidden=\"true\"></span>Դիտել\r\n                    ");
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(67, "\r\n                ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(68, "\r\n                ");
                __builder2.OpenElement(69, "li");
                __builder2.AddAttribute(70, "class", "nav-item px-3");
                __builder2.AddMarkupContent(71, "\r\n                    ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Routing.NavLink>(72);
                __builder2.AddAttribute(73, "class", "");
                __builder2.AddAttribute(74, "href", "PecMembersTec/PecMembersAdd");
                __builder2.AddAttribute(75, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddMarkupContent(76, "\r\n                        &nbsp;&nbsp;&nbsp;&nbsp; <span class=\"oi oi-pencil\" aria-hidden=\"true\"></span>Ավելացնել\r\n                    ");
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(77, "\r\n                ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(78, "\r\n");
#nullable restore
#line 43 "C:\Users\gareg\source\repos\PecMembers\PecMembers\PecMembers.UI\Shared\NavMenu.razor"
            }

#line default
#line hidden
#nullable disable
                __builder2.AddMarkupContent(79, "\r\n                ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(80, "\r\n            ");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(81, "\r\n\r\n\r\n        ");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Authorization.AuthorizeView>(82);
            __builder.AddAttribute(83, "Roles", "Admin,Party");
            __builder.AddAttribute(84, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Authorization.AuthenticationState>)((context) => (__builder2) => {
                __builder2.AddMarkupContent(85, "\r\n            ");
                __builder2.OpenElement(86, "li");
                __builder2.AddAttribute(87, "class", "nav-item px-3");
                __builder2.AddMarkupContent(88, "\r\n                ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Routing.NavLink>(89);
                __builder2.AddAttribute(90, "class", "nav-link");
                __builder2.AddAttribute(91, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 51 "C:\Users\gareg\source\repos\PecMembers\PecMembers\PecMembers.UI\Shared\NavMenu.razor"
                                                    ()=>expandSubNav = !expandSubNav

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(92, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddMarkupContent(93, "\r\n                    <span class=\"oi oi-people\" aria-hidden=\"true\"></span> ՏԸՀ կուսակց․\r\n                ");
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(94, "\r\n\r\n");
#nullable restore
#line 55 "C:\Users\gareg\source\repos\PecMembers\PecMembers\PecMembers.UI\Shared\NavMenu.razor"
                 if (expandSubNav)
                {

#line default
#line hidden
#nullable disable
                __builder2.AddContent(95, "                ");
                __builder2.OpenElement(96, "li");
                __builder2.AddAttribute(97, "class", "nav-item px-3");
                __builder2.AddMarkupContent(98, "\r\n                    ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Routing.NavLink>(99);
                __builder2.AddAttribute(100, "class", "expand-menu");
                __builder2.AddAttribute(101, "href", "PecMembersParty/PecMembersParty");
                __builder2.AddAttribute(102, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddMarkupContent(103, "\r\n                        &nbsp;&nbsp;&nbsp;&nbsp;  <span class=\"oi oi-inbox\" aria-hidden=\"true\"></span>Դիտել\r\n                    ");
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(104, "\r\n                ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(105, "\r\n                ");
                __builder2.OpenElement(106, "li");
                __builder2.AddAttribute(107, "class", "nav-item px-3");
                __builder2.AddMarkupContent(108, "\r\n                    ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Routing.NavLink>(109);
                __builder2.AddAttribute(110, "class", "");
                __builder2.AddAttribute(111, "href", "PecMembersParty/PecMembersPartyAdd");
                __builder2.AddAttribute(112, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddMarkupContent(113, "\r\n                        &nbsp;&nbsp;&nbsp;&nbsp; <span class=\"oi oi-pencil\" aria-hidden=\"true\"></span>Լրացնել\r\n                    ");
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(114, "\r\n                ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(115, "\r\n");
#nullable restore
#line 67 "C:\Users\gareg\source\repos\PecMembers\PecMembers\PecMembers.UI\Shared\NavMenu.razor"
            }

#line default
#line hidden
#nullable disable
                __builder2.AddMarkupContent(116, "\r\n                ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(117, "\r\n            ");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(118, "\r\n\r\n\r\n            ");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Authorization.AuthorizeView>(119);
            __builder.AddAttribute(120, "Roles", "Admin");
            __builder.AddAttribute(121, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Authorization.AuthenticationState>)((context) => (__builder2) => {
                __builder2.AddMarkupContent(122, "\r\n                ");
                __builder2.OpenElement(123, "li");
                __builder2.AddAttribute(124, "class", "nav-item px-3");
                __builder2.AddMarkupContent(125, "\r\n                    ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Routing.NavLink>(126);
                __builder2.AddAttribute(127, "class", "nav-link");
                __builder2.AddAttribute(128, "href", "Administrator/Administrator");
                __builder2.AddAttribute(129, "Match", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.Routing.NavLinkMatch>(
#nullable restore
#line 75 "C:\Users\gareg\source\repos\PecMembers\PecMembers\PecMembers.UI\Shared\NavMenu.razor"
                                                                                        NavLinkMatch.All

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(130, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddMarkupContent(131, "\r\n                        <span class=\"oi oi-wrench\" aria-hidden=\"true\"></span>Կարգավորումներ\r\n                    ");
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(132, "\r\n                ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(133, "\r\n            ");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(134, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(135, "\r\n    ");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 85 "C:\Users\gareg\source\repos\PecMembers\PecMembers\PecMembers.UI\Shared\NavMenu.razor"
           
        private bool expandSubNav;
        private bool expandSubNavTec;
        
        private bool collapseNavMenu = true;

        private string NavMenuCssClass => collapseNavMenu ? "collapse" : null;

        private void ToggleNavMenu()
        {
            collapseNavMenu = !collapseNavMenu;
        }
    

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
