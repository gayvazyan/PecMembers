#pragma checksum "C:\Users\gareg\source\repos\PecMembers\PecMembers\PecMembers.UI\Pages\PecMembersTec\PecMembersView.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e5c797cf3980fbc990c0cabbb59b8cd1a9202e12"
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
#line 3 "C:\Users\gareg\source\repos\PecMembers\PecMembers\PecMembers.UI\Pages\PecMembersTec\PecMembersView.razor"
           [Authorize(Roles = "Admin,Tec")]

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/PecMembersTec/PecMembersView")]
    public partial class PecMembersView : PecMembersViewBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h3 style=\"text-align:center;color:forestgreen\">ՏԸՀ անդամների ցանկ </h3>\r\n");
            __builder.OpenElement(1, "div");
            __builder.AddAttribute(2, "class", "card-header");
            __builder.AddAttribute(3, "style", "padding:10px");
            __builder.AddMarkupContent(4, "\r\n    ");
            __builder.OpenElement(5, "button");
            __builder.AddAttribute(6, "class", "btn btn-success");
            __builder.AddAttribute(7, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 7 "C:\Users\gareg\source\repos\PecMembers\PecMembers\PecMembers.UI\Pages\PecMembersTec\PecMembersView.razor"
                                              DownloadExcel

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(8, "Ներբեռնել");
            __builder.CloseElement();
            __builder.AddMarkupContent(9, "\r\n    ");
            __builder.OpenElement(10, "button");
            __builder.AddAttribute(11, "class", "btn btn-primary text-black-50");
            __builder.AddAttribute(12, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 8 "C:\Users\gareg\source\repos\PecMembers\PecMembers\PecMembers.UI\Pages\PecMembersTec\PecMembersView.razor"
                                                              () => Clear()

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(13, "\r\n        ");
            __builder.AddMarkupContent(14, "<h7 style=\"color:white\">Մաքրել որոնման դաշտերը</h7>\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(15, "\r\n");
            __builder.CloseElement();
            __builder.AddMarkupContent(16, "\r\n\r\n<br>\r\n\r\n");
            __builder.OpenElement(17, "div");
            __builder.AddMarkupContent(18, "\r\n    ");
            __builder.OpenElement(19, "div");
            __builder.AddAttribute(20, "class", "form-group row");
            __builder.AddMarkupContent(21, "\r\n        ");
            __builder.AddMarkupContent(22, "<label for=\"StartShowDate\" class=\"col-sm-3\">Ցուցադրված ամսաթվի սկիզբ</label>\r\n        ");
            __builder.OpenElement(23, "input");
            __builder.AddAttribute(24, "type", "date");
            __builder.AddAttribute(25, "id", "StartShowDate");
            __builder.AddAttribute(26, "class", "form-control col-sm-8");
            __builder.AddAttribute(27, "placeholder", "StartShowDate");
            __builder.AddAttribute(28, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 18 "C:\Users\gareg\source\repos\PecMembers\PecMembers\PecMembers.UI\Pages\PecMembersTec\PecMembersView.razor"
                                                                                    StartShowDate

#line default
#line hidden
#nullable disable
            , format: "yyyy-MM-dd", culture: global::System.Globalization.CultureInfo.InvariantCulture));
            __builder.AddAttribute(29, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => StartShowDate = __value, StartShowDate, format: "yyyy-MM-dd", culture: global::System.Globalization.CultureInfo.InvariantCulture));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(30, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(31, "\r\n    ");
            __builder.OpenElement(32, "div");
            __builder.AddAttribute(33, "class", "form-group row");
            __builder.AddMarkupContent(34, "\r\n        ");
            __builder.AddMarkupContent(35, "<label for=\"EndShowDate\" class=\"col-sm-3\">Ցուցադրված ամսաթվի վերջ </label>\r\n        ");
            __builder.OpenElement(36, "input");
            __builder.AddAttribute(37, "type", "date");
            __builder.AddAttribute(38, "id", "EndShowDate");
            __builder.AddAttribute(39, "class", "form-control col-sm-8");
            __builder.AddAttribute(40, "placeholder", "EndShowDate");
            __builder.AddAttribute(41, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 22 "C:\Users\gareg\source\repos\PecMembers\PecMembers\PecMembers.UI\Pages\PecMembersTec\PecMembersView.razor"
                                                                                  EndShowDate

#line default
#line hidden
#nullable disable
            , format: "yyyy-MM-dd", culture: global::System.Globalization.CultureInfo.InvariantCulture));
            __builder.AddAttribute(42, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => EndShowDate = __value, EndShowDate, format: "yyyy-MM-dd", culture: global::System.Globalization.CultureInfo.InvariantCulture));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(43, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(44, "\r\n    ");
            __builder.OpenElement(45, "button");
            __builder.AddAttribute(46, "class", "btn btn-primary");
            __builder.AddAttribute(47, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 24 "C:\Users\gareg\source\repos\PecMembers\PecMembers\PecMembers.UI\Pages\PecMembersTec\PecMembersView.razor"
                                               ShowResult

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(48, " Ցուցադրել ընտրված ամսաթվով");
            __builder.CloseElement();
            __builder.AddMarkupContent(49, "\r\n");
            __builder.CloseElement();
            __builder.AddMarkupContent(50, "\r\n\r\n");
            __builder.OpenElement(51, "div");
            __builder.AddAttribute(52, "class", "grid card-body p-0");
            __builder.AddMarkupContent(53, "\r\n    ");
            __builder.OpenElement(54, "div");
            __builder.AddAttribute(55, "class", "alert" + " " + (
#nullable restore
#line 28 "C:\Users\gareg\source\repos\PecMembers\PecMembers\PecMembers.UI\Pages\PecMembersTec\PecMembersView.razor"
                       StatusClass

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(56, 
#nullable restore
#line 28 "C:\Users\gareg\source\repos\PecMembers\PecMembers\PecMembers.UI\Pages\PecMembersTec\PecMembersView.razor"
                                     Message

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(57, "\r\n    ");
            __builder.OpenElement(58, "table");
            __builder.AddAttribute(59, "class", "table table-responsive-sm table-striped");
            __builder.AddMarkupContent(60, "\r\n        ");
            __builder.OpenElement(61, "thead");
            __builder.AddMarkupContent(62, "\r\n            ");
            __builder.OpenElement(63, "tr");
            __builder.AddAttribute(64, "style", "background-color:limegreen");
            __builder.AddMarkupContent(65, "\r\n                ");
            __builder.OpenComponent<PecMembers.UI.Shared.GridColumn>(66);
            __builder.AddAttribute(67, "ColumnTitle", "Ամսաթիվ");
            __builder.AddAttribute(68, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 32 "C:\Users\gareg\source\repos\PecMembers\PecMembers\PecMembers.UI\Pages\PecMembersTec\PecMembersView.razor"
                                                          SerchColumType1

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(69, "OnSearchTextChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.ChangeEventArgs>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.ChangeEventArgs>(this, 
#nullable restore
#line 32 "C:\Users\gareg\source\repos\PecMembers\PecMembers\PecMembers.UI\Pages\PecMembersTec\PecMembersView.razor"
                                                                                                  e => OnPublisherSearchTextChanged(e, "Ամսաթիվ")

#line default
#line hidden
#nullable disable
            )));
            __builder.CloseComponent();
            __builder.AddMarkupContent(70, "\r\n                ");
            __builder.OpenComponent<PecMembers.UI.Shared.GridColumn>(71);
            __builder.AddAttribute(72, "ColumnTitle", "ԸԸՀ");
            __builder.AddAttribute(73, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 33 "C:\Users\gareg\source\repos\PecMembers\PecMembers\PecMembers.UI\Pages\PecMembersTec\PecMembersView.razor"
                                                      SerchColumType2

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(74, "OnSearchTextChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.ChangeEventArgs>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.ChangeEventArgs>(this, 
#nullable restore
#line 33 "C:\Users\gareg\source\repos\PecMembers\PecMembers\PecMembers.UI\Pages\PecMembersTec\PecMembersView.razor"
                                                                                              e => OnPublisherSearchTextChanged(e, "ԸԸՀ")

#line default
#line hidden
#nullable disable
            )));
            __builder.CloseComponent();
            __builder.AddMarkupContent(75, "\r\n                ");
            __builder.OpenComponent<PecMembers.UI.Shared.GridColumn>(76);
            __builder.AddAttribute(77, "ColumnTitle", "ՏԸՀ");
            __builder.AddAttribute(78, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 34 "C:\Users\gareg\source\repos\PecMembers\PecMembers\PecMembers.UI\Pages\PecMembersTec\PecMembersView.razor"
                                                      SerchColumType3

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(79, "OnSearchTextChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.ChangeEventArgs>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.ChangeEventArgs>(this, 
#nullable restore
#line 34 "C:\Users\gareg\source\repos\PecMembers\PecMembers\PecMembers.UI\Pages\PecMembersTec\PecMembersView.razor"
                                                                                              e => OnPublisherSearchTextChanged(e, "ՏԸՀ")

#line default
#line hidden
#nullable disable
            )));
            __builder.CloseComponent();
            __builder.AddMarkupContent(80, "\r\n                ");
            __builder.OpenComponent<PecMembers.UI.Shared.GridColumn>(81);
            __builder.AddAttribute(82, "ColumnTitle", "Համայնք");
            __builder.AddAttribute(83, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 35 "C:\Users\gareg\source\repos\PecMembers\PecMembers\PecMembers.UI\Pages\PecMembersTec\PecMembersView.razor"
                                                          SerchColumType4

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(84, "OnSearchTextChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.ChangeEventArgs>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.ChangeEventArgs>(this, 
#nullable restore
#line 35 "C:\Users\gareg\source\repos\PecMembers\PecMembers\PecMembers.UI\Pages\PecMembersTec\PecMembersView.razor"
                                                                                                  e => OnPublisherSearchTextChanged(e, "Համայնք")

#line default
#line hidden
#nullable disable
            )));
            __builder.CloseComponent();
            __builder.AddMarkupContent(85, "\r\n                ");
            __builder.OpenComponent<PecMembers.UI.Shared.GridColumn>(86);
            __builder.AddAttribute(87, "ColumnTitle", "Անուն,Ազգանուն,Հայրանուն");
            __builder.AddAttribute(88, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 36 "C:\Users\gareg\source\repos\PecMembers\PecMembers\PecMembers.UI\Pages\PecMembersTec\PecMembersView.razor"
                                                                           SerchColumType5

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(89, "OnSearchTextChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.ChangeEventArgs>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.ChangeEventArgs>(this, 
#nullable restore
#line 36 "C:\Users\gareg\source\repos\PecMembers\PecMembers\PecMembers.UI\Pages\PecMembersTec\PecMembersView.razor"
                                                                                                                   e => OnPublisherSearchTextChanged(e, "Անուն,Ազգանուն,Հայրանուն")

#line default
#line hidden
#nullable disable
            )));
            __builder.CloseComponent();
            __builder.AddMarkupContent(90, "\r\n                ");
            __builder.OpenComponent<PecMembers.UI.Shared.GridColumn>(91);
            __builder.AddAttribute(92, "ColumnTitle", "Վկայական");
            __builder.AddAttribute(93, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 37 "C:\Users\gareg\source\repos\PecMembers\PecMembers\PecMembers.UI\Pages\PecMembersTec\PecMembersView.razor"
                                                           SerchColumType6

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(94, "OnSearchTextChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.ChangeEventArgs>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.ChangeEventArgs>(this, 
#nullable restore
#line 37 "C:\Users\gareg\source\repos\PecMembers\PecMembers\PecMembers.UI\Pages\PecMembersTec\PecMembersView.razor"
                                                                                                   e => OnPublisherSearchTextChanged(e, "Վկայական")

#line default
#line hidden
#nullable disable
            )));
            __builder.CloseComponent();
            __builder.AddMarkupContent(95, "\r\n                ");
            __builder.OpenComponent<PecMembers.UI.Shared.GridColumn>(96);
            __builder.AddAttribute(97, "ColumnTitle", "Հեռախոս");
            __builder.AddAttribute(98, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 38 "C:\Users\gareg\source\repos\PecMembers\PecMembers\PecMembers.UI\Pages\PecMembersTec\PecMembersView.razor"
                                                          SerchColumType7

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(99, "OnSearchTextChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.ChangeEventArgs>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.ChangeEventArgs>(this, 
#nullable restore
#line 38 "C:\Users\gareg\source\repos\PecMembers\PecMembers\PecMembers.UI\Pages\PecMembersTec\PecMembersView.razor"
                                                                                                  e => OnPublisherSearchTextChanged(e, "Հեռախոս")

#line default
#line hidden
#nullable disable
            )));
            __builder.CloseComponent();
            __builder.AddMarkupContent(100, "\r\n                ");
            __builder.OpenComponent<PecMembers.UI.Shared.GridColumn>(101);
            __builder.AddAttribute(102, "ColumnTitle", "Կուսակ․");
            __builder.AddAttribute(103, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 39 "C:\Users\gareg\source\repos\PecMembers\PecMembers\PecMembers.UI\Pages\PecMembersTec\PecMembersView.razor"
                                                          SerchColumType8

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(104, "OnSearchTextChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.ChangeEventArgs>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.ChangeEventArgs>(this, 
#nullable restore
#line 39 "C:\Users\gareg\source\repos\PecMembers\PecMembers\PecMembers.UI\Pages\PecMembersTec\PecMembersView.razor"
                                                                                                  e => OnPublisherSearchTextChanged(e, "Կուսակ․")

#line default
#line hidden
#nullable disable
            )));
            __builder.CloseComponent();
            __builder.AddMarkupContent(105, "\r\n                ");
            __builder.OpenComponent<PecMembers.UI.Shared.GridColumn>(106);
            __builder.AddAttribute(107, "ColumnTitle", "Պաշտոն");
            __builder.AddAttribute(108, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 40 "C:\Users\gareg\source\repos\PecMembers\PecMembers\PecMembers.UI\Pages\PecMembersTec\PecMembersView.razor"
                                                         SerchColumType9

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(109, "OnSearchTextChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.ChangeEventArgs>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.ChangeEventArgs>(this, 
#nullable restore
#line 40 "C:\Users\gareg\source\repos\PecMembers\PecMembers\PecMembers.UI\Pages\PecMembersTec\PecMembersView.razor"
                                                                                                 e => OnPublisherSearchTextChanged(e, "Պաշտոն")

#line default
#line hidden
#nullable disable
            )));
            __builder.CloseComponent();
            __builder.AddMarkupContent(110, "\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(111, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(112, "\r\n        ");
            __builder.OpenElement(113, "tbody");
            __builder.AddMarkupContent(114, "\r\n");
#nullable restore
#line 44 "C:\Users\gareg\source\repos\PecMembers\PecMembers\PecMembers.UI\Pages\PecMembersTec\PecMembersView.razor"
             if (filteredPecMemberViewModelList != null)
            {
                

#line default
#line hidden
#nullable disable
#nullable restore
#line 46 "C:\Users\gareg\source\repos\PecMembers\PecMembers\PecMembers.UI\Pages\PecMembersTec\PecMembersView.razor"
                 foreach (var pecMemeber in filteredPecMemberViewModelList)
                {

                    {

#line default
#line hidden
#nullable disable
            __builder.AddContent(115, "                        ");
            __builder.OpenElement(116, "tr");
            __builder.AddAttribute(117, "style", "background-color:blanchedalmond");
            __builder.AddMarkupContent(118, "\r\n                            ");
            __builder.OpenElement(119, "td");
            __builder.AddAttribute(120, "style", "border-color:black");
            __builder.AddContent(121, 
#nullable restore
#line 51 "C:\Users\gareg\source\repos\PecMembers\PecMembers\PecMembers.UI\Pages\PecMembersTec\PecMembersView.razor"
                                                            pecMemeber.ElectionDayView

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
#line 52 "C:\Users\gareg\source\repos\PecMembers\PecMembers\PecMembers.UI\Pages\PecMembersTec\PecMembersView.razor"
                                                                              pecMemeber.DistrictView

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(126, "\r\n                            ");
            __builder.OpenElement(127, "td");
            __builder.AddAttribute(128, "style", "text-align:center;border-color:black");
            __builder.AddContent(129, 
#nullable restore
#line 53 "C:\Users\gareg\source\repos\PecMembers\PecMembers\PecMembers.UI\Pages\PecMembersTec\PecMembersView.razor"
                                                                              pecMemeber.SubDistrictCodeView

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(130, "\r\n                            ");
            __builder.OpenElement(131, "td");
            __builder.AddAttribute(132, "style", "text-align:center;border-color:black");
            __builder.AddContent(133, 
#nullable restore
#line 54 "C:\Users\gareg\source\repos\PecMembers\PecMembers\PecMembers.UI\Pages\PecMembersTec\PecMembersView.razor"
                                                                              pecMemeber.CommunityView

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(134, "\r\n                            ");
            __builder.OpenElement(135, "td");
            __builder.AddAttribute(136, "style", "text-align:center;border-color:black");
            __builder.AddContent(137, 
#nullable restore
#line 55 "C:\Users\gareg\source\repos\PecMembers\PecMembers\PecMembers.UI\Pages\PecMembersTec\PecMembersView.razor"
                                                                              pecMemeber.FullName

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(138, "\r\n                            ");
            __builder.OpenElement(139, "td");
            __builder.AddAttribute(140, "style", "text-align:center;border-color:black");
            __builder.AddContent(141, 
#nullable restore
#line 56 "C:\Users\gareg\source\repos\PecMembers\PecMembers\PecMembers.UI\Pages\PecMembersTec\PecMembersView.razor"
                                                                              pecMemeber.CerteficateView

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(142, "\r\n                            ");
            __builder.OpenElement(143, "td");
            __builder.AddAttribute(144, "style", "text-align:center;border-color:black");
            __builder.AddContent(145, 
#nullable restore
#line 57 "C:\Users\gareg\source\repos\PecMembers\PecMembers\PecMembers.UI\Pages\PecMembersTec\PecMembersView.razor"
                                                                              pecMemeber.PhoneNumberView

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(146, "\r\n                            ");
            __builder.OpenElement(147, "td");
            __builder.AddAttribute(148, "style", "text-align:center;border-color:black");
            __builder.AddContent(149, 
#nullable restore
#line 58 "C:\Users\gareg\source\repos\PecMembers\PecMembers\PecMembers.UI\Pages\PecMembersTec\PecMembersView.razor"
                                                                              pecMemeber.PartyView

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(150, "\r\n                            ");
            __builder.OpenElement(151, "td");
            __builder.AddAttribute(152, "style", "text-align:center;border-color:black");
            __builder.AddContent(153, 
#nullable restore
#line 59 "C:\Users\gareg\source\repos\PecMembers\PecMembers\PecMembers.UI\Pages\PecMembersTec\PecMembersView.razor"
                                                                              pecMemeber.PositionView

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(154, "\r\n                        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(155, "\r\n");
#nullable restore
#line 61 "C:\Users\gareg\source\repos\PecMembers\PecMembers\PecMembers.UI\Pages\PecMembersTec\PecMembersView.razor"
                    }
                }

#line default
#line hidden
#nullable disable
#nullable restore
#line 62 "C:\Users\gareg\source\repos\PecMembers\PecMembers\PecMembers.UI\Pages\PecMembersTec\PecMembersView.razor"
                 
            }

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(156, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(157, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(158, "\r\n");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591
