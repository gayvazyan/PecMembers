#pragma checksum "C:\Users\gareg\source\repos\PecMembers\PecMembers\PecMembers.UI\Pages\PecMembersTec\PecMembersTec.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "fa72121899e64900a4f462316e27b8792096cbc3"
// <auto-generated/>
#pragma warning disable 1591
namespace PecMembers.UI.Pages.PecMembersTec
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
#line 3 "C:\Users\gareg\source\repos\PecMembers\PecMembers\PecMembers.UI\Pages\PecMembersTec\PecMembersTec.razor"
           [Authorize(Roles = "Admin,Tec")]

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/PecMembersTec/PecMembersTec")]
    public partial class PecMembersTec : PecMembersTecBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h3 style=\"text-align:center;color:forestgreen\">ՏԸՀ անդամների ավելացում ընտրատարածքից</h3>\r\n");
            __builder.OpenElement(1, "div");
            __builder.AddAttribute(2, "class", "card-header");
            __builder.AddAttribute(3, "style", "padding:10px");
            __builder.AddMarkupContent(4, "\r\n    ");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Routing.NavLink>(5);
            __builder.AddAttribute(6, "href", 
#nullable restore
#line 7 "C:\Users\gareg\source\repos\PecMembers\PecMembers\PecMembers.UI\Pages\PecMembersTec\PecMembersTec.razor"
                     $"PecMembersTec/PecMembersAdd"

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(7, "class", "btn btn-success table-btn");
            __builder.AddAttribute(8, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(9, "\r\n        Ավելացնել նորը\r\n    ");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(10, "\r\n");
            __builder.CloseElement();
            __builder.AddMarkupContent(11, "\r\n\r\n\r\n\r\n");
            __builder.OpenElement(12, "div");
            __builder.AddAttribute(13, "class", "grid card-body p-0");
            __builder.AddMarkupContent(14, "\r\n    ");
            __builder.OpenElement(15, "div");
            __builder.AddAttribute(16, "class", "alert" + " " + (
#nullable restore
#line 15 "C:\Users\gareg\source\repos\PecMembers\PecMembers\PecMembers.UI\Pages\PecMembersTec\PecMembersTec.razor"
                       StatusClass

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(17, 
#nullable restore
#line 15 "C:\Users\gareg\source\repos\PecMembers\PecMembers\PecMembers.UI\Pages\PecMembersTec\PecMembersTec.razor"
                                     Message

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(18, "\r\n    ");
            __builder.OpenElement(19, "table");
            __builder.AddAttribute(20, "class", "table table-responsive-sm table-striped");
            __builder.AddMarkupContent(21, "\r\n        ");
            __builder.OpenElement(22, "thead");
            __builder.AddMarkupContent(23, "\r\n            ");
            __builder.OpenElement(24, "tr");
            __builder.AddAttribute(25, "style", "background-color:limegreen");
            __builder.AddMarkupContent(26, "\r\n                ");
            __builder.OpenComponent<PecMembers.UI.Shared.GridColumn>(27);
            __builder.AddAttribute(28, "ColumnTitle", "Ամսաթիվ");
            __builder.AddAttribute(29, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 19 "C:\Users\gareg\source\repos\PecMembers\PecMembers\PecMembers.UI\Pages\PecMembersTec\PecMembersTec.razor"
                                                          SerchColumType1

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(30, "OnSearchTextChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.ChangeEventArgs>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.ChangeEventArgs>(this, 
#nullable restore
#line 19 "C:\Users\gareg\source\repos\PecMembers\PecMembers\PecMembers.UI\Pages\PecMembersTec\PecMembersTec.razor"
                                                                                                  e => OnPublisherSearchTextChanged(e, "Ամսաթիվ")

#line default
#line hidden
#nullable disable
            )));
            __builder.CloseComponent();
            __builder.AddMarkupContent(31, "\r\n                ");
            __builder.OpenComponent<PecMembers.UI.Shared.GridColumn>(32);
            __builder.AddAttribute(33, "ColumnTitle", "ԸԸՀ");
            __builder.AddAttribute(34, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 20 "C:\Users\gareg\source\repos\PecMembers\PecMembers\PecMembers.UI\Pages\PecMembersTec\PecMembersTec.razor"
                                                      SerchColumType2

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(35, "OnSearchTextChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.ChangeEventArgs>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.ChangeEventArgs>(this, 
#nullable restore
#line 20 "C:\Users\gareg\source\repos\PecMembers\PecMembers\PecMembers.UI\Pages\PecMembersTec\PecMembersTec.razor"
                                                                                              e => OnPublisherSearchTextChanged(e, "ԸԸՀ")

#line default
#line hidden
#nullable disable
            )));
            __builder.CloseComponent();
            __builder.AddMarkupContent(36, "\r\n                ");
            __builder.OpenComponent<PecMembers.UI.Shared.GridColumn>(37);
            __builder.AddAttribute(38, "ColumnTitle", "ՏԸՀ");
            __builder.AddAttribute(39, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 21 "C:\Users\gareg\source\repos\PecMembers\PecMembers\PecMembers.UI\Pages\PecMembersTec\PecMembersTec.razor"
                                                      SerchColumType3

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(40, "OnSearchTextChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.ChangeEventArgs>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.ChangeEventArgs>(this, 
#nullable restore
#line 21 "C:\Users\gareg\source\repos\PecMembers\PecMembers\PecMembers.UI\Pages\PecMembersTec\PecMembersTec.razor"
                                                                                              e => OnPublisherSearchTextChanged(e, "ՏԸՀ")

#line default
#line hidden
#nullable disable
            )));
            __builder.CloseComponent();
            __builder.AddMarkupContent(41, "\r\n                ");
            __builder.OpenComponent<PecMembers.UI.Shared.GridColumn>(42);
            __builder.AddAttribute(43, "ColumnTitle", "Համայնք");
            __builder.AddAttribute(44, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 22 "C:\Users\gareg\source\repos\PecMembers\PecMembers\PecMembers.UI\Pages\PecMembersTec\PecMembersTec.razor"
                                                          SerchColumType4

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(45, "OnSearchTextChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.ChangeEventArgs>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.ChangeEventArgs>(this, 
#nullable restore
#line 22 "C:\Users\gareg\source\repos\PecMembers\PecMembers\PecMembers.UI\Pages\PecMembersTec\PecMembersTec.razor"
                                                                                                  e => OnPublisherSearchTextChanged(e, "Համայնք")

#line default
#line hidden
#nullable disable
            )));
            __builder.CloseComponent();
            __builder.AddMarkupContent(46, "\r\n                ");
            __builder.OpenComponent<PecMembers.UI.Shared.GridColumn>(47);
            __builder.AddAttribute(48, "ColumnTitle", "Անուն,Ազգանուն,Հայրանուն");
            __builder.AddAttribute(49, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 23 "C:\Users\gareg\source\repos\PecMembers\PecMembers\PecMembers.UI\Pages\PecMembersTec\PecMembersTec.razor"
                                                                           SerchColumType5

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(50, "OnSearchTextChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.ChangeEventArgs>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.ChangeEventArgs>(this, 
#nullable restore
#line 23 "C:\Users\gareg\source\repos\PecMembers\PecMembers\PecMembers.UI\Pages\PecMembersTec\PecMembersTec.razor"
                                                                                                                   e => OnPublisherSearchTextChanged(e, "Անուն,Ազգանուն,Հայրանուն")

#line default
#line hidden
#nullable disable
            )));
            __builder.CloseComponent();
            __builder.AddMarkupContent(51, "\r\n                ");
            __builder.OpenComponent<PecMembers.UI.Shared.GridColumn>(52);
            __builder.AddAttribute(53, "ColumnTitle", "Վկայական");
            __builder.AddAttribute(54, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 24 "C:\Users\gareg\source\repos\PecMembers\PecMembers\PecMembers.UI\Pages\PecMembersTec\PecMembersTec.razor"
                                                           SerchColumType6

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(55, "OnSearchTextChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.ChangeEventArgs>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.ChangeEventArgs>(this, 
#nullable restore
#line 24 "C:\Users\gareg\source\repos\PecMembers\PecMembers\PecMembers.UI\Pages\PecMembersTec\PecMembersTec.razor"
                                                                                                   e => OnPublisherSearchTextChanged(e, "Վկայական")

#line default
#line hidden
#nullable disable
            )));
            __builder.CloseComponent();
            __builder.AddMarkupContent(56, "\r\n                ");
            __builder.OpenComponent<PecMembers.UI.Shared.GridColumn>(57);
            __builder.AddAttribute(58, "ColumnTitle", "Հեռախոս");
            __builder.AddAttribute(59, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 25 "C:\Users\gareg\source\repos\PecMembers\PecMembers\PecMembers.UI\Pages\PecMembersTec\PecMembersTec.razor"
                                                          SerchColumType7

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(60, "OnSearchTextChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.ChangeEventArgs>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.ChangeEventArgs>(this, 
#nullable restore
#line 25 "C:\Users\gareg\source\repos\PecMembers\PecMembers\PecMembers.UI\Pages\PecMembersTec\PecMembersTec.razor"
                                                                                                  e => OnPublisherSearchTextChanged(e, "Հեռախոս")

#line default
#line hidden
#nullable disable
            )));
            __builder.CloseComponent();
            __builder.AddMarkupContent(61, "\r\n                ");
            __builder.OpenComponent<PecMembers.UI.Shared.GridColumn>(62);
            __builder.AddAttribute(63, "ColumnTitle", "Կուսակ․");
            __builder.AddAttribute(64, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 26 "C:\Users\gareg\source\repos\PecMembers\PecMembers\PecMembers.UI\Pages\PecMembersTec\PecMembersTec.razor"
                                                          SerchColumType8

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(65, "OnSearchTextChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.ChangeEventArgs>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.ChangeEventArgs>(this, 
#nullable restore
#line 26 "C:\Users\gareg\source\repos\PecMembers\PecMembers\PecMembers.UI\Pages\PecMembersTec\PecMembersTec.razor"
                                                                                                  e => OnPublisherSearchTextChanged(e, "Կուսակ․")

#line default
#line hidden
#nullable disable
            )));
            __builder.CloseComponent();
            __builder.AddMarkupContent(66, "\r\n                ");
            __builder.OpenComponent<PecMembers.UI.Shared.GridColumn>(67);
            __builder.AddAttribute(68, "ColumnTitle", "Պաշտոն");
            __builder.AddAttribute(69, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 27 "C:\Users\gareg\source\repos\PecMembers\PecMembers\PecMembers.UI\Pages\PecMembersTec\PecMembersTec.razor"
                                                         SerchColumType9

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(70, "OnSearchTextChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.ChangeEventArgs>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.ChangeEventArgs>(this, 
#nullable restore
#line 27 "C:\Users\gareg\source\repos\PecMembers\PecMembers\PecMembers.UI\Pages\PecMembersTec\PecMembersTec.razor"
                                                                                                 e => OnPublisherSearchTextChanged(e, "Պաշտոն")

#line default
#line hidden
#nullable disable
            )));
            __builder.CloseComponent();
            __builder.AddMarkupContent(71, "\r\n\r\n\r\n\r\n\r\n                ");
            __builder.OpenElement(72, "td");
            __builder.AddAttribute(73, "style", "text-align:center;font:bold;color:white");
            __builder.AddMarkupContent(74, "\r\n                    ");
            __builder.AddMarkupContent(75, "<label>Հրամաններ</label> <br>\r\n                    ");
            __builder.OpenElement(76, "button");
            __builder.AddAttribute(77, "class", "btn btn-primary text-black-50");
            __builder.AddAttribute(78, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 34 "C:\Users\gareg\source\repos\PecMembers\PecMembers\PecMembers.UI\Pages\PecMembersTec\PecMembersTec.razor"
                                                                              () => Clear()

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(79, "\r\n                        ");
            __builder.AddMarkupContent(80, "<h7 style=\"color:white\">Մաքրել</h7>\r\n                    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(81, "\r\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(82, "\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(83, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(84, "\r\n        ");
            __builder.OpenElement(85, "tbody");
            __builder.AddMarkupContent(86, "\r\n");
#nullable restore
#line 41 "C:\Users\gareg\source\repos\PecMembers\PecMembers\PecMembers.UI\Pages\PecMembersTec\PecMembersTec.razor"
             if (filteredPecMemberViewModelList != null)
            {
                

#line default
#line hidden
#nullable disable
#nullable restore
#line 43 "C:\Users\gareg\source\repos\PecMembers\PecMembers\PecMembers.UI\Pages\PecMembersTec\PecMembersTec.razor"
                 foreach (var pecMemeber in filteredPecMemberViewModelList)
                {

                    {

#line default
#line hidden
#nullable disable
            __builder.AddContent(87, "                        ");
            __builder.OpenElement(88, "tr");
            __builder.AddAttribute(89, "style", "background-color:blanchedalmond");
            __builder.AddMarkupContent(90, "\r\n                            ");
            __builder.OpenElement(91, "td");
            __builder.AddAttribute(92, "style", "border-color:black");
            __builder.AddContent(93, 
#nullable restore
#line 48 "C:\Users\gareg\source\repos\PecMembers\PecMembers\PecMembers.UI\Pages\PecMembersTec\PecMembersTec.razor"
                                                            pecMemeber.ElectionDayView

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(94, "\r\n                            ");
            __builder.OpenElement(95, "td");
            __builder.AddAttribute(96, "style", "text-align:center;border-color:black");
            __builder.AddContent(97, 
#nullable restore
#line 49 "C:\Users\gareg\source\repos\PecMembers\PecMembers\PecMembers.UI\Pages\PecMembersTec\PecMembersTec.razor"
                                                                              pecMemeber.DistrictView

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(98, "\r\n                            ");
            __builder.OpenElement(99, "td");
            __builder.AddAttribute(100, "style", "text-align:center;border-color:black");
            __builder.AddContent(101, 
#nullable restore
#line 50 "C:\Users\gareg\source\repos\PecMembers\PecMembers\PecMembers.UI\Pages\PecMembersTec\PecMembersTec.razor"
                                                                              pecMemeber.SubDistrictCodeView

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(102, "\r\n                            ");
            __builder.OpenElement(103, "td");
            __builder.AddAttribute(104, "style", "text-align:center;border-color:black");
            __builder.AddContent(105, 
#nullable restore
#line 51 "C:\Users\gareg\source\repos\PecMembers\PecMembers\PecMembers.UI\Pages\PecMembersTec\PecMembersTec.razor"
                                                                              pecMemeber.CommunityView

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(106, "\r\n                            ");
            __builder.OpenElement(107, "td");
            __builder.AddAttribute(108, "style", "text-align:center;border-color:black");
            __builder.AddContent(109, 
#nullable restore
#line 52 "C:\Users\gareg\source\repos\PecMembers\PecMembers\PecMembers.UI\Pages\PecMembersTec\PecMembersTec.razor"
                                                                              pecMemeber.FullName

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(110, "\r\n                            ");
            __builder.OpenElement(111, "td");
            __builder.AddAttribute(112, "style", "text-align:center;border-color:black");
            __builder.AddContent(113, 
#nullable restore
#line 53 "C:\Users\gareg\source\repos\PecMembers\PecMembers\PecMembers.UI\Pages\PecMembersTec\PecMembersTec.razor"
                                                                              pecMemeber.CerteficateView

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(114, "\r\n                            ");
            __builder.OpenElement(115, "td");
            __builder.AddAttribute(116, "style", "text-align:center;border-color:black");
            __builder.AddContent(117, 
#nullable restore
#line 54 "C:\Users\gareg\source\repos\PecMembers\PecMembers\PecMembers.UI\Pages\PecMembersTec\PecMembersTec.razor"
                                                                              pecMemeber.PhoneNumberView

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(118, "\r\n                            ");
            __builder.OpenElement(119, "td");
            __builder.AddAttribute(120, "style", "text-align:center;border-color:black");
            __builder.AddContent(121, 
#nullable restore
#line 55 "C:\Users\gareg\source\repos\PecMembers\PecMembers\PecMembers.UI\Pages\PecMembersTec\PecMembersTec.razor"
                                                                              pecMemeber.PartyView

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(122, "\r\n                            ");
            __builder.OpenElement(123, "td");
            __builder.AddAttribute(124, "style", "text-align:center;border-color:black");
            __builder.AddContent(125, 
#nullable restore
#line 56 "C:\Users\gareg\source\repos\PecMembers\PecMembers\PecMembers.UI\Pages\PecMembersTec\PecMembersTec.razor"
                                                                              pecMemeber.PositionView

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(126, "\r\n\r\n                            ");
            __builder.OpenElement(127, "td");
            __builder.AddAttribute(128, "style", "text-align:center;border-color:black");
            __builder.AddMarkupContent(129, "\r\n\r\n                                ");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Routing.NavLink>(130);
            __builder.AddAttribute(131, "href", 
#nullable restore
#line 60 "C:\Users\gareg\source\repos\PecMembers\PecMembers\PecMembers.UI\Pages\PecMembersTec\PecMembersTec.razor"
                                                 $"PecMembersTec/PecMembersEdit/{pecMemeber.Id}"

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(132, "class", "btn btn-primary table-btn");
            __builder.AddAttribute(133, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(134, "\r\n                                    Խմբագրել\r\n                                ");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(135, "\r\n                            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(136, "\r\n                        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(137, "\r\n");
#nullable restore
#line 65 "C:\Users\gareg\source\repos\PecMembers\PecMembers\PecMembers.UI\Pages\PecMembersTec\PecMembersTec.razor"
                    }
                }

#line default
#line hidden
#nullable disable
#nullable restore
#line 66 "C:\Users\gareg\source\repos\PecMembers\PecMembers\PecMembers.UI\Pages\PecMembersTec\PecMembersTec.razor"
                 
            }

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(138, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(139, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(140, "\r\n");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591
