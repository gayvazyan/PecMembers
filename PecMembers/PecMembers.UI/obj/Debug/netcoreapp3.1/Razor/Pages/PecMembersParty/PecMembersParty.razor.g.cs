#pragma checksum "C:\Users\gareg\source\repos\PecMembers\PecMembers\PecMembers.UI\Pages\PecMembersParty\PecMembersParty.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "bdd35cab9856f98bdf3dc6366ecfd9c948ec7c8e"
// <auto-generated/>
#pragma warning disable 1591
namespace PecMembers.UI.Pages.PecMembersParty
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
#line 3 "C:\Users\gareg\source\repos\PecMembers\PecMembers\PecMembers.UI\Pages\PecMembersParty\PecMembersParty.razor"
           [Authorize(Roles = "Admin,Party")]

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/PecMembersParty/PecMembersParty")]
    public partial class PecMembersParty : PecMembersPartyBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h3 style=\"text-align:center;color:forestgreen\">ՏԸՀ անդամների լրացում կուսակցություններից</h3>\r\n");
            __builder.OpenElement(1, "div");
            __builder.AddAttribute(2, "class", "card-header");
            __builder.AddAttribute(3, "style", "padding:10px");
            __builder.AddMarkupContent(4, "\r\n    ");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Routing.NavLink>(5);
            __builder.AddAttribute(6, "href", 
#nullable restore
#line 7 "C:\Users\gareg\source\repos\PecMembers\PecMembers\PecMembers.UI\Pages\PecMembersParty\PecMembersParty.razor"
                     $"PecMembersParty/PecMembersPartyAdd"

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(7, "class", "btn btn-success table-btn");
            __builder.AddAttribute(8, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(9, "\r\n        Լրացնել\r\n    ");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(10, "\r\n    ");
            __builder.OpenElement(11, "button");
            __builder.AddAttribute(12, "class", "btn btn-primary text-black-50");
            __builder.AddAttribute(13, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 10 "C:\Users\gareg\source\repos\PecMembers\PecMembers\PecMembers.UI\Pages\PecMembersParty\PecMembersParty.razor"
                                                              () => Clear()

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(14, "\r\n        ");
            __builder.AddMarkupContent(15, "<h7 style=\"color:white\">Մաքրել որոնման դաշտերը</h7>\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(16, "\r\n");
            __builder.CloseElement();
            __builder.AddMarkupContent(17, "\r\n\r\n\r\n\r\n");
            __builder.OpenElement(18, "div");
            __builder.AddAttribute(19, "class", "grid card-body p-0");
            __builder.AddMarkupContent(20, "\r\n    ");
            __builder.OpenElement(21, "div");
            __builder.AddAttribute(22, "class", "alert" + " " + (
#nullable restore
#line 18 "C:\Users\gareg\source\repos\PecMembers\PecMembers\PecMembers.UI\Pages\PecMembersParty\PecMembersParty.razor"
                       StatusClass

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(23, 
#nullable restore
#line 18 "C:\Users\gareg\source\repos\PecMembers\PecMembers\PecMembers.UI\Pages\PecMembersParty\PecMembersParty.razor"
                                     Message

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(24, "\r\n    ");
            __builder.OpenElement(25, "table");
            __builder.AddAttribute(26, "class", "table table-responsive-sm table-striped");
            __builder.AddMarkupContent(27, "\r\n        ");
            __builder.OpenElement(28, "thead");
            __builder.AddMarkupContent(29, "\r\n            ");
            __builder.AddMarkupContent(30, @"<tr style=""background-color:white"">
                <td colspan=""10"">
                    <h7 style=""color:red"">*նախատեսում եմ որ յուրաքանչյուր կուսակցություն տեսնի իր ցուցակը,իսկ ԿԸՀ-ն բոլորը(ինչպես հիմա տեսնում ենք)</h7>
                </td>
            </tr>
            ");
            __builder.OpenElement(31, "tr");
            __builder.AddAttribute(32, "style", "background-color:limegreen");
            __builder.AddMarkupContent(33, "\r\n                ");
            __builder.OpenComponent<PecMembers.UI.Shared.GridColumn>(34);
            __builder.AddAttribute(35, "ColumnTitle", "Ամսաթիվ");
            __builder.AddAttribute(36, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 27 "C:\Users\gareg\source\repos\PecMembers\PecMembers\PecMembers.UI\Pages\PecMembersParty\PecMembersParty.razor"
                                                          SerchColumType1

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(37, "OnSearchTextChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.ChangeEventArgs>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.ChangeEventArgs>(this, 
#nullable restore
#line 27 "C:\Users\gareg\source\repos\PecMembers\PecMembers\PecMembers.UI\Pages\PecMembersParty\PecMembersParty.razor"
                                                                                                  e => OnPublisherSearchTextChanged(e, "Ամսաթիվ")

#line default
#line hidden
#nullable disable
            )));
            __builder.CloseComponent();
            __builder.AddMarkupContent(38, "\r\n                ");
            __builder.OpenComponent<PecMembers.UI.Shared.GridColumn>(39);
            __builder.AddAttribute(40, "ColumnTitle", "ԸԸՀ");
            __builder.AddAttribute(41, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 28 "C:\Users\gareg\source\repos\PecMembers\PecMembers\PecMembers.UI\Pages\PecMembersParty\PecMembersParty.razor"
                                                      SerchColumType2

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(42, "OnSearchTextChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.ChangeEventArgs>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.ChangeEventArgs>(this, 
#nullable restore
#line 28 "C:\Users\gareg\source\repos\PecMembers\PecMembers\PecMembers.UI\Pages\PecMembersParty\PecMembersParty.razor"
                                                                                              e => OnPublisherSearchTextChanged(e, "ԸԸՀ")

#line default
#line hidden
#nullable disable
            )));
            __builder.CloseComponent();
            __builder.AddMarkupContent(43, "\r\n                ");
            __builder.OpenComponent<PecMembers.UI.Shared.GridColumn>(44);
            __builder.AddAttribute(45, "ColumnTitle", "ՏԸՀ");
            __builder.AddAttribute(46, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 29 "C:\Users\gareg\source\repos\PecMembers\PecMembers\PecMembers.UI\Pages\PecMembersParty\PecMembersParty.razor"
                                                      SerchColumType3

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(47, "OnSearchTextChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.ChangeEventArgs>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.ChangeEventArgs>(this, 
#nullable restore
#line 29 "C:\Users\gareg\source\repos\PecMembers\PecMembers\PecMembers.UI\Pages\PecMembersParty\PecMembersParty.razor"
                                                                                              e => OnPublisherSearchTextChanged(e, "ՏԸՀ")

#line default
#line hidden
#nullable disable
            )));
            __builder.CloseComponent();
            __builder.AddMarkupContent(48, "\r\n                ");
            __builder.OpenComponent<PecMembers.UI.Shared.GridColumn>(49);
            __builder.AddAttribute(50, "ColumnTitle", "Համայնք");
            __builder.AddAttribute(51, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 30 "C:\Users\gareg\source\repos\PecMembers\PecMembers\PecMembers.UI\Pages\PecMembersParty\PecMembersParty.razor"
                                                          SerchColumType4

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(52, "OnSearchTextChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.ChangeEventArgs>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.ChangeEventArgs>(this, 
#nullable restore
#line 30 "C:\Users\gareg\source\repos\PecMembers\PecMembers\PecMembers.UI\Pages\PecMembersParty\PecMembersParty.razor"
                                                                                                  e => OnPublisherSearchTextChanged(e, "Համայնք")

#line default
#line hidden
#nullable disable
            )));
            __builder.CloseComponent();
            __builder.AddMarkupContent(53, "\r\n                ");
            __builder.OpenComponent<PecMembers.UI.Shared.GridColumn>(54);
            __builder.AddAttribute(55, "ColumnTitle", "Անուն,Ազգանուն,Հայրանուն");
            __builder.AddAttribute(56, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 31 "C:\Users\gareg\source\repos\PecMembers\PecMembers\PecMembers.UI\Pages\PecMembersParty\PecMembersParty.razor"
                                                                           SerchColumType5

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(57, "OnSearchTextChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.ChangeEventArgs>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.ChangeEventArgs>(this, 
#nullable restore
#line 31 "C:\Users\gareg\source\repos\PecMembers\PecMembers\PecMembers.UI\Pages\PecMembersParty\PecMembersParty.razor"
                                                                                                                   e => OnPublisherSearchTextChanged(e, "Անուն,Ազգանուն,Հայրանուն")

#line default
#line hidden
#nullable disable
            )));
            __builder.CloseComponent();
            __builder.AddMarkupContent(58, "\r\n                ");
            __builder.OpenComponent<PecMembers.UI.Shared.GridColumn>(59);
            __builder.AddAttribute(60, "ColumnTitle", "Վկայական");
            __builder.AddAttribute(61, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 32 "C:\Users\gareg\source\repos\PecMembers\PecMembers\PecMembers.UI\Pages\PecMembersParty\PecMembersParty.razor"
                                                           SerchColumType6

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(62, "OnSearchTextChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.ChangeEventArgs>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.ChangeEventArgs>(this, 
#nullable restore
#line 32 "C:\Users\gareg\source\repos\PecMembers\PecMembers\PecMembers.UI\Pages\PecMembersParty\PecMembersParty.razor"
                                                                                                   e => OnPublisherSearchTextChanged(e, "Վկայական")

#line default
#line hidden
#nullable disable
            )));
            __builder.CloseComponent();
            __builder.AddMarkupContent(63, "\r\n                ");
            __builder.OpenComponent<PecMembers.UI.Shared.GridColumn>(64);
            __builder.AddAttribute(65, "ColumnTitle", "Հեռախոս");
            __builder.AddAttribute(66, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 33 "C:\Users\gareg\source\repos\PecMembers\PecMembers\PecMembers.UI\Pages\PecMembersParty\PecMembersParty.razor"
                                                          SerchColumType7

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(67, "OnSearchTextChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.ChangeEventArgs>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.ChangeEventArgs>(this, 
#nullable restore
#line 33 "C:\Users\gareg\source\repos\PecMembers\PecMembers\PecMembers.UI\Pages\PecMembersParty\PecMembersParty.razor"
                                                                                                  e => OnPublisherSearchTextChanged(e, "Հեռախոս")

#line default
#line hidden
#nullable disable
            )));
            __builder.CloseComponent();
            __builder.AddMarkupContent(68, "\r\n                ");
            __builder.OpenComponent<PecMembers.UI.Shared.GridColumn>(69);
            __builder.AddAttribute(70, "ColumnTitle", "Կուսակ․");
            __builder.AddAttribute(71, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 34 "C:\Users\gareg\source\repos\PecMembers\PecMembers\PecMembers.UI\Pages\PecMembersParty\PecMembersParty.razor"
                                                          SerchColumType8

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(72, "OnSearchTextChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.ChangeEventArgs>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.ChangeEventArgs>(this, 
#nullable restore
#line 34 "C:\Users\gareg\source\repos\PecMembers\PecMembers\PecMembers.UI\Pages\PecMembersParty\PecMembersParty.razor"
                                                                                                  e => OnPublisherSearchTextChanged(e, "Կուսակ․")

#line default
#line hidden
#nullable disable
            )));
            __builder.CloseComponent();
            __builder.AddMarkupContent(73, "\r\n                ");
            __builder.OpenComponent<PecMembers.UI.Shared.GridColumn>(74);
            __builder.AddAttribute(75, "ColumnTitle", "Պաշտոն");
            __builder.AddAttribute(76, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 35 "C:\Users\gareg\source\repos\PecMembers\PecMembers\PecMembers.UI\Pages\PecMembersParty\PecMembersParty.razor"
                                                         SerchColumType9

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(77, "OnSearchTextChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.ChangeEventArgs>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.ChangeEventArgs>(this, 
#nullable restore
#line 35 "C:\Users\gareg\source\repos\PecMembers\PecMembers\PecMembers.UI\Pages\PecMembersParty\PecMembersParty.razor"
                                                                                                 e => OnPublisherSearchTextChanged(e, "Պաշտոն")

#line default
#line hidden
#nullable disable
            )));
            __builder.CloseComponent();
            __builder.AddMarkupContent(78, "\r\n\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(79, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(80, "\r\n        ");
            __builder.OpenElement(81, "tbody");
            __builder.AddMarkupContent(82, "\r\n\r\n");
#nullable restore
#line 41 "C:\Users\gareg\source\repos\PecMembers\PecMembers\PecMembers.UI\Pages\PecMembersParty\PecMembersParty.razor"
             foreach (var pecMemeber in filteredPecMemberViewModelList)
            {

                {

#line default
#line hidden
#nullable disable
            __builder.AddContent(83, "                    ");
            __builder.OpenElement(84, "tr");
            __builder.AddAttribute(85, "style", "background-color:blanchedalmond");
            __builder.AddMarkupContent(86, "\r\n                        ");
            __builder.OpenElement(87, "td");
            __builder.AddAttribute(88, "style", "border-color:black");
            __builder.AddContent(89, 
#nullable restore
#line 46 "C:\Users\gareg\source\repos\PecMembers\PecMembers\PecMembers.UI\Pages\PecMembersParty\PecMembersParty.razor"
                                                        pecMemeber.ElectionDayView

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(90, "\r\n                        ");
            __builder.OpenElement(91, "td");
            __builder.AddAttribute(92, "style", "text-align:center;border-color:black");
            __builder.AddContent(93, 
#nullable restore
#line 47 "C:\Users\gareg\source\repos\PecMembers\PecMembers\PecMembers.UI\Pages\PecMembersParty\PecMembersParty.razor"
                                                                          pecMemeber.DistrictView

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(94, "\r\n                        ");
            __builder.OpenElement(95, "td");
            __builder.AddAttribute(96, "style", "text-align:center;border-color:black");
            __builder.AddContent(97, 
#nullable restore
#line 48 "C:\Users\gareg\source\repos\PecMembers\PecMembers\PecMembers.UI\Pages\PecMembersParty\PecMembersParty.razor"
                                                                          pecMemeber.SubDistrictCodeView

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(98, "\r\n                        ");
            __builder.OpenElement(99, "td");
            __builder.AddAttribute(100, "style", "text-align:center;border-color:black");
            __builder.AddContent(101, 
#nullable restore
#line 49 "C:\Users\gareg\source\repos\PecMembers\PecMembers\PecMembers.UI\Pages\PecMembersParty\PecMembersParty.razor"
                                                                          pecMemeber.CommunityView

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(102, "\r\n                        ");
            __builder.OpenElement(103, "td");
            __builder.AddAttribute(104, "style", "text-align:center;border-color:black");
            __builder.AddContent(105, 
#nullable restore
#line 50 "C:\Users\gareg\source\repos\PecMembers\PecMembers\PecMembers.UI\Pages\PecMembersParty\PecMembersParty.razor"
                                                                          pecMemeber.FullName

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(106, "\r\n                        ");
            __builder.OpenElement(107, "td");
            __builder.AddAttribute(108, "style", "text-align:center;border-color:black");
            __builder.AddContent(109, 
#nullable restore
#line 51 "C:\Users\gareg\source\repos\PecMembers\PecMembers\PecMembers.UI\Pages\PecMembersParty\PecMembersParty.razor"
                                                                          pecMemeber.CerteficateView

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(110, "\r\n                        ");
            __builder.OpenElement(111, "td");
            __builder.AddAttribute(112, "style", "text-align:center;border-color:black");
            __builder.AddContent(113, 
#nullable restore
#line 52 "C:\Users\gareg\source\repos\PecMembers\PecMembers\PecMembers.UI\Pages\PecMembersParty\PecMembersParty.razor"
                                                                          pecMemeber.PhoneNumberView

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(114, "\r\n                        ");
            __builder.OpenElement(115, "td");
            __builder.AddAttribute(116, "style", "text-align:center;border-color:black");
            __builder.AddContent(117, 
#nullable restore
#line 53 "C:\Users\gareg\source\repos\PecMembers\PecMembers\PecMembers.UI\Pages\PecMembersParty\PecMembersParty.razor"
                                                                          pecMemeber.PartyView

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(118, "\r\n                        ");
            __builder.OpenElement(119, "td");
            __builder.AddAttribute(120, "style", "text-align:center;border-color:black");
            __builder.AddContent(121, 
#nullable restore
#line 54 "C:\Users\gareg\source\repos\PecMembers\PecMembers\PecMembers.UI\Pages\PecMembersParty\PecMembersParty.razor"
                                                                          pecMemeber.PositionView

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(122, "\r\n                    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(123, "\r\n");
#nullable restore
#line 56 "C:\Users\gareg\source\repos\PecMembers\PecMembers\PecMembers.UI\Pages\PecMembersParty\PecMembersParty.razor"
                }
            }

#line default
#line hidden
#nullable disable
            __builder.AddContent(124, "        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(125, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(126, "\r\n");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591
