#pragma checksum "C:\Users\gareg\source\repos\PecMembers\PecMembers\PecMembers.UI\Pages\PecMembersTec\PecMembersEdit.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d46826a30a9b918496da44da42733d81a42b9f5a"
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
    [Microsoft.AspNetCore.Components.RouteAttribute("/PecMembersTec/PecMembersEdit")]
    [Microsoft.AspNetCore.Components.RouteAttribute("/PecMembersTec/PecMembersEdit/{Id:int}")]
    public partial class PecMembersEdit : PecMembersEditBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h2 style=\"text-align:center;color:forestgreen\">ՏԸՀ անդամի տվյալների խմբագրում</h2>\r\n\r\n");
            __builder.OpenElement(1, "div");
            __builder.AddAttribute(2, "class", "alert" + " " + (
#nullable restore
#line 7 "C:\Users\gareg\source\repos\PecMembers\PecMembers\PecMembers.UI\Pages\PecMembersTec\PecMembersEdit.razor"
                   StatusClass

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(3, 
#nullable restore
#line 7 "C:\Users\gareg\source\repos\PecMembers\PecMembers\PecMembers.UI\Pages\PecMembersTec\PecMembersEdit.razor"
                                 Message

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(4, "\r\n\r\n");
#nullable restore
#line 9 "C:\Users\gareg\source\repos\PecMembers\PecMembers\PecMembers.UI\Pages\PecMembersTec\PecMembersEdit.razor"
 if (!Show)
{

#line default
#line hidden
#nullable disable
            __builder.AddContent(5, "    ");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Forms.EditForm>(6);
            __builder.AddAttribute(7, "Model", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#nullable restore
#line 11 "C:\Users\gareg\source\repos\PecMembers\PecMembers\PecMembers.UI\Pages\PecMembersTec\PecMembersEdit.razor"
                      pecMemberCurrent

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(8, "OnValidSubmit", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Forms.EditContext>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Forms.EditContext>(this, 
#nullable restore
#line 11 "C:\Users\gareg\source\repos\PecMembers\PecMembers\PecMembers.UI\Pages\PecMembersTec\PecMembersEdit.razor"
                                                        UpdatePecMember

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
                __builder2.AddMarkupContent(27, "<label class=\"col-sm-4 col-form-label\">Անուն։</label>\r\n                        ");
                __builder2.OpenElement(28, "div");
                __builder2.AddAttribute(29, "class", "col-sm-8");
                __builder2.AddMarkupContent(30, "\r\n                            ");
                __builder2.OpenElement(31, "label");
                __builder2.AddAttribute(32, "type", "text");
                __builder2.AddAttribute(33, "readonly", true);
                __builder2.AddAttribute(34, "class", "form-control-plaintext");
                __builder2.AddAttribute(35, "style", "color:forestgreen");
                __builder2.AddContent(36, 
#nullable restore
#line 20 "C:\Users\gareg\source\repos\PecMembers\PecMembers\PecMembers.UI\Pages\PecMembersTec\PecMembersEdit.razor"
                                                                                                                  pecMemberCurrent.LastName

#line default
#line hidden
#nullable disable
                );
                __builder2.AddContent(37, " ");
                __builder2.AddContent(38, 
#nullable restore
#line 20 "C:\Users\gareg\source\repos\PecMembers\PecMembers\PecMembers.UI\Pages\PecMembersTec\PecMembersEdit.razor"
                                                                                                                                             pecMemberCurrent.FirstName

#line default
#line hidden
#nullable disable
                );
                __builder2.AddContent(39, " ");
                __builder2.AddContent(40, 
#nullable restore
#line 20 "C:\Users\gareg\source\repos\PecMembers\PecMembers\PecMembers.UI\Pages\PecMembersTec\PecMembersEdit.razor"
                                                                                                                                                                         pecMemberCurrent.MiddleName

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(41, "\r\n                        ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(42, "\r\n                    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(43, "\r\n                    ");
                __builder2.OpenElement(44, "div");
                __builder2.AddAttribute(45, "class", "form-group row");
                __builder2.AddMarkupContent(46, "\r\n                        ");
                __builder2.AddMarkupContent(47, "<label class=\"col-sm-4 col-form-label\">Վկայական:</label>\r\n                        ");
                __builder2.OpenElement(48, "div");
                __builder2.AddAttribute(49, "class", "col-sm-8");
                __builder2.AddMarkupContent(50, "\r\n                            ");
                __builder2.OpenElement(51, "label");
                __builder2.AddAttribute(52, "type", "text");
                __builder2.AddAttribute(53, "readonly", true);
                __builder2.AddAttribute(54, "class", "form-control-plaintext");
                __builder2.AddAttribute(55, "style", "color:forestgreen");
                __builder2.AddContent(56, 
#nullable restore
#line 26 "C:\Users\gareg\source\repos\PecMembers\PecMembers\PecMembers.UI\Pages\PecMembersTec\PecMembersEdit.razor"
                                                                                                                  pecMemberCurrent.Certeficate

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(57, "\r\n                        ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(58, "\r\n                    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(59, "\r\n                    ");
                __builder2.OpenElement(60, "div");
                __builder2.AddAttribute(61, "class", "form-group row");
                __builder2.AddMarkupContent(62, "\r\n                        ");
                __builder2.AddMarkupContent(63, "<label class=\"col-sm-4 col-form-label\">Անձնագիր:</label>\r\n                        ");
                __builder2.OpenElement(64, "div");
                __builder2.AddAttribute(65, "class", "col-sm-8");
                __builder2.AddMarkupContent(66, "\r\n                            ");
                __builder2.OpenElement(67, "label");
                __builder2.AddAttribute(68, "type", "text");
                __builder2.AddAttribute(69, "readonly", true);
                __builder2.AddAttribute(70, "class", "form-control-plaintext");
                __builder2.AddAttribute(71, "style", "color:forestgreen");
                __builder2.AddContent(72, 
#nullable restore
#line 32 "C:\Users\gareg\source\repos\PecMembers\PecMembers\PecMembers.UI\Pages\PecMembersTec\PecMembersEdit.razor"
                                                                                                                  pecMemberCurrent.Passport

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(73, "\r\n                        ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(74, "\r\n                    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(75, "\r\n                    ");
                __builder2.OpenElement(76, "div");
                __builder2.AddAttribute(77, "class", "form-group row");
                __builder2.AddMarkupContent(78, "\r\n                        ");
                __builder2.AddMarkupContent(79, "<label class=\"col-sm-4 col-form-label\">Հ․Ծ․Հ․</label>\r\n                        ");
                __builder2.OpenElement(80, "div");
                __builder2.AddAttribute(81, "class", "col-sm-8");
                __builder2.AddMarkupContent(82, "\r\n                            ");
                __builder2.OpenElement(83, "label");
                __builder2.AddAttribute(84, "type", "text");
                __builder2.AddAttribute(85, "readonly", true);
                __builder2.AddAttribute(86, "class", "form-control-plaintext");
                __builder2.AddAttribute(87, "style", "color:forestgreen");
                __builder2.AddContent(88, 
#nullable restore
#line 38 "C:\Users\gareg\source\repos\PecMembers\PecMembers\PecMembers.UI\Pages\PecMembersTec\PecMembersEdit.razor"
                                                                                                                  pecMemberCurrent.SSN

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(89, "\r\n                        ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(90, "\r\n                    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(91, "\r\n                    ");
                __builder2.OpenElement(92, "div");
                __builder2.AddAttribute(93, "class", "form-group row");
                __builder2.AddMarkupContent(94, "\r\n                        ");
                __builder2.AddMarkupContent(95, "<label class=\"col-sm-4 col-form-label\">Հաշվառման հասցե:</label>\r\n                        ");
                __builder2.OpenElement(96, "div");
                __builder2.AddAttribute(97, "class", "col-sm-8");
                __builder2.AddMarkupContent(98, "\r\n                            ");
                __builder2.OpenElement(99, "label");
                __builder2.AddAttribute(100, "type", "text");
                __builder2.AddAttribute(101, "readonly", true);
                __builder2.AddAttribute(102, "class", "form-control-plaintext");
                __builder2.AddAttribute(103, "style", "color:forestgreen");
                __builder2.AddContent(104, 
#nullable restore
#line 44 "C:\Users\gareg\source\repos\PecMembers\PecMembers\PecMembers.UI\Pages\PecMembersTec\PecMembersEdit.razor"
                                                                                                                  pecMemberCurrent.Adress

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(105, "\r\n                        ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(106, "\r\n                    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(107, "\r\n\r\n                    ");
                __builder2.OpenElement(108, "div");
                __builder2.AddAttribute(109, "class", "form-group row");
                __builder2.AddMarkupContent(110, "\r\n                        ");
                __builder2.AddMarkupContent(111, "<label class=\"col-sm-4 col-form-label\">Հեռախոս</label>\r\n                        ");
                __builder2.OpenElement(112, "div");
                __builder2.AddAttribute(113, "class", "col-sm-8");
                __builder2.AddMarkupContent(114, "\r\n                            ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(115);
                __builder2.AddAttribute(116, "style", "width:170px");
                __builder2.AddAttribute(117, "class", "form-control col-sm-8");
                __builder2.AddAttribute(118, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 51 "C:\Users\gareg\source\repos\PecMembers\PecMembers\PecMembers.UI\Pages\PecMembersTec\PecMembersEdit.razor"
                                                                                                       pecMemberCurrent.PhoneNumber

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(119, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => pecMemberCurrent.PhoneNumber = __value, pecMemberCurrent.PhoneNumber))));
                __builder2.AddAttribute(120, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => pecMemberCurrent.PhoneNumber));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(121, "\r\n                        ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(122, "\r\n                    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(123, "\r\n                    ");
                __builder2.OpenElement(124, "div");
                __builder2.AddAttribute(125, "class", "form-group row");
                __builder2.AddMarkupContent(126, "\r\n                        ");
                __builder2.AddMarkupContent(127, "<label class=\"col-sm-4 col-form-label\">Էլ․ հասցե</label>\r\n                        ");
                __builder2.OpenElement(128, "div");
                __builder2.AddAttribute(129, "class", "col-sm-8");
                __builder2.AddMarkupContent(130, "\r\n                            ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(131);
                __builder2.AddAttribute(132, "style", "width:200px");
                __builder2.AddAttribute(133, "class", "form-control col-sm-8");
                __builder2.AddAttribute(134, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 57 "C:\Users\gareg\source\repos\PecMembers\PecMembers\PecMembers.UI\Pages\PecMembersTec\PecMembersEdit.razor"
                                                                                                       pecMemberCurrent.Email

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(135, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => pecMemberCurrent.Email = __value, pecMemberCurrent.Email))));
                __builder2.AddAttribute(136, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => pecMemberCurrent.Email));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(137, "\r\n                        ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(138, "\r\n                    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(139, "\r\n                    ");
                __builder2.OpenElement(140, "div");
                __builder2.AddAttribute(141, "class", "form-group row");
                __builder2.AddMarkupContent(142, "\r\n                        ");
                __builder2.AddMarkupContent(143, "<label class=\"col-sm-4 col-form-label\">Ընտրության օր</label>\r\n                        ");
                __builder2.OpenElement(144, "div");
                __builder2.AddAttribute(145, "class", "col-sm-8");
                __builder2.AddMarkupContent(146, "\r\n                            ");
                __Blazor.PecMembers.UI.Pages.PecMembersTec.PecMembersEdit.TypeInference.CreateInputDate_0(__builder2, 147, 148, "width:170px", 149, "form-control col-sm-8", 150, 
#nullable restore
#line 63 "C:\Users\gareg\source\repos\PecMembers\PecMembers\PecMembers.UI\Pages\PecMembersTec\PecMembersEdit.razor"
                                                                                                       pecMemberCurrent.ElectionDay

#line default
#line hidden
#nullable disable
                , 151, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => pecMemberCurrent.ElectionDay = __value, pecMemberCurrent.ElectionDay)), 152, () => pecMemberCurrent.ElectionDay);
                __builder2.AddMarkupContent(153, "\r\n                        ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(154, "\r\n                    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(155, "\r\n\r\n                    ");
                __builder2.OpenElement(156, "div");
                __builder2.AddAttribute(157, "class", "form-group row");
                __builder2.AddMarkupContent(158, "\r\n                        ");
                __builder2.AddMarkupContent(159, "<label class=\"col-sm-4 col-form-label\">Ընտրատարածք</label>\r\n                        ");
                __builder2.OpenElement(160, "div");
                __builder2.AddAttribute(161, "class", "col-sm-8");
                __builder2.AddMarkupContent(162, "\r\n                            ");
                __Blazor.PecMembers.UI.Pages.PecMembersTec.PecMembersEdit.TypeInference.CreateInputSelect_1(__builder2, 163, 164, "width:170px", 165, "TEC", 166, "form-control col-sm-8", 167, "TEC", 168, 
#nullable restore
#line 70 "C:\Users\gareg\source\repos\PecMembers\PecMembers\PecMembers.UI\Pages\PecMembersTec\PecMembersEdit.razor"
                                                                                                                  DistrictIdString

#line default
#line hidden
#nullable disable
                , 169, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => DistrictIdString = __value, DistrictIdString)), 170, () => DistrictIdString, 171, (__builder3) => {
                    __builder3.AddMarkupContent(172, "\r\n");
#nullable restore
#line 71 "C:\Users\gareg\source\repos\PecMembers\PecMembers\PecMembers.UI\Pages\PecMembersTec\PecMembersEdit.razor"
                                 foreach (var item in ListTEC)
                                    {

#line default
#line hidden
#nullable disable
                    __builder3.AddContent(173, "                                    ");
                    __builder3.OpenElement(174, "option");
                    __builder3.AddAttribute(175, "value", 
#nullable restore
#line 73 "C:\Users\gareg\source\repos\PecMembers\PecMembers\PecMembers.UI\Pages\PecMembersTec\PecMembersEdit.razor"
                                                    item

#line default
#line hidden
#nullable disable
                    );
                    __builder3.AddContent(176, 
#nullable restore
#line 73 "C:\Users\gareg\source\repos\PecMembers\PecMembers\PecMembers.UI\Pages\PecMembersTec\PecMembersEdit.razor"
                                                           item.ToString().Replace("_", " ")

#line default
#line hidden
#nullable disable
                    );
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(177, "\r\n");
#nullable restore
#line 74 "C:\Users\gareg\source\repos\PecMembers\PecMembers\PecMembers.UI\Pages\PecMembersTec\PecMembersEdit.razor"
                                    }

#line default
#line hidden
#nullable disable
                    __builder3.AddMarkupContent(178, @"                                /**/
                                /**/
                                /**/
                                /**/
                                /**/
                                /**/
                            ");
                }
                );
                __builder2.AddMarkupContent(179, "\r\n                        ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(180, "\r\n                    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(181, "\r\n                    ");
                __builder2.OpenElement(182, "div");
                __builder2.AddAttribute(183, "class", "form-group row");
                __builder2.AddMarkupContent(184, "\r\n                        ");
                __builder2.AddMarkupContent(185, "<label class=\"col-sm-4 col-form-label\">Տեղամաս</label>\r\n                        ");
                __builder2.OpenElement(186, "div");
                __builder2.AddAttribute(187, "class", "col-sm-8");
                __builder2.AddMarkupContent(188, "\r\n                            ");
                __Blazor.PecMembers.UI.Pages.PecMembersTec.PecMembersEdit.TypeInference.CreateInputNumber_2(__builder2, 189, 190, "width:100px", 191, "form-control col-sm-8", 192, 
#nullable restore
#line 87 "C:\Users\gareg\source\repos\PecMembers\PecMembers\PecMembers.UI\Pages\PecMembersTec\PecMembersEdit.razor"
                                                                                                         pecMemberCurrent.SubDistrictCode

#line default
#line hidden
#nullable disable
                , 193, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => pecMemberCurrent.SubDistrictCode = __value, pecMemberCurrent.SubDistrictCode)), 194, () => pecMemberCurrent.SubDistrictCode);
                __builder2.AddMarkupContent(195, "\r\n                        ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(196, "\r\n                    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(197, "\r\n                    ");
                __builder2.OpenElement(198, "div");
                __builder2.AddAttribute(199, "class", "form-group row");
                __builder2.AddMarkupContent(200, "\r\n                        ");
                __builder2.AddMarkupContent(201, "<label class=\"col-sm-4 col-form-label\">Համայնք</label>\r\n                        ");
                __builder2.OpenElement(202, "div");
                __builder2.AddAttribute(203, "class", "col-sm-8");
                __builder2.AddMarkupContent(204, "\r\n                            ");
                __Blazor.PecMembers.UI.Pages.PecMembersTec.PecMembersEdit.TypeInference.CreateInputSelect_3(__builder2, 205, 206, "width:170px", 207, "Comunity", 208, "form-control col-sm-8", 209, "Comunity", 210, 
#nullable restore
#line 93 "C:\Users\gareg\source\repos\PecMembers\PecMembers\PecMembers.UI\Pages\PecMembersTec\PecMembersEdit.razor"
                                                                                                                       pecMemberCurrent.Name

#line default
#line hidden
#nullable disable
                , 211, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => pecMemberCurrent.Name = __value, pecMemberCurrent.Name)), 212, () => pecMemberCurrent.Name, 213, (__builder3) => {
                    __builder3.AddMarkupContent(214, "\r\n");
#nullable restore
#line 94 "C:\Users\gareg\source\repos\PecMembers\PecMembers\PecMembers.UI\Pages\PecMembersTec\PecMembersEdit.razor"
                                 foreach (var item in ListCommunity)
                                    {

#line default
#line hidden
#nullable disable
                    __builder3.AddContent(215, "                                    ");
                    __builder3.OpenElement(216, "option");
                    __builder3.AddAttribute(217, "value", 
#nullable restore
#line 96 "C:\Users\gareg\source\repos\PecMembers\PecMembers\PecMembers.UI\Pages\PecMembersTec\PecMembersEdit.razor"
                                                    item

#line default
#line hidden
#nullable disable
                    );
                    __builder3.AddContent(218, 
#nullable restore
#line 96 "C:\Users\gareg\source\repos\PecMembers\PecMembers\PecMembers.UI\Pages\PecMembersTec\PecMembersEdit.razor"
                                                           item

#line default
#line hidden
#nullable disable
                    );
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(219, "\r\n");
#nullable restore
#line 97 "C:\Users\gareg\source\repos\PecMembers\PecMembers\PecMembers.UI\Pages\PecMembersTec\PecMembersEdit.razor"
                                    }

#line default
#line hidden
#nullable disable
                    __builder3.AddMarkupContent(220, @"                                /**/
                                /**/
                                /**/
                                /**/
                                /**/
                                /**/
                                /**/
                            ");
                }
                );
                __builder2.AddMarkupContent(221, "\r\n                        ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(222, "\r\n                    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(223, "\r\n\r\n                    ");
                __builder2.OpenElement(224, "div");
                __builder2.AddAttribute(225, "class", "form-group row");
                __builder2.AddMarkupContent(226, "\r\n                        ");
                __builder2.AddMarkupContent(227, "<button type=\"submit\" class=\"btn btn-primary \">Թարմացնել</button>&nbsp;&nbsp;\r\n                        ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Routing.NavLink>(228);
                __builder2.AddAttribute(229, "href", 
#nullable restore
#line 112 "C:\Users\gareg\source\repos\PecMembers\PecMembers\PecMembers.UI\Pages\PecMembersTec\PecMembersEdit.razor"
                                         $"/PecMembersTec/PecMembersTec"

#line default
#line hidden
#nullable disable
                );
                __builder2.AddAttribute(230, "class", "btn btn-danger");
                __builder2.AddAttribute(231, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddMarkupContent(232, "\r\n                            Չեղարկել\r\n                        ");
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(233, " &nbsp;&nbsp;\r\n                        ");
                __builder2.OpenElement(234, "button");
                __builder2.AddAttribute(235, "class", "btn btn-danger text-black-50");
                __builder2.AddAttribute(236, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 115 "C:\Users\gareg\source\repos\PecMembers\PecMembers\PecMembers.UI\Pages\PecMembersTec\PecMembersEdit.razor"
                                                                                 () => DeletePecMember(pecMemberCurrent)

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddMarkupContent(237, "\r\n                            Հեռացնել\r\n                        ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(238, "\r\n                    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(239, "\r\n                ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(240, "\r\n            ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(241, "\r\n        ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(242, "\r\n    ");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(243, "\r\n");
#nullable restore
#line 123 "C:\Users\gareg\source\repos\PecMembers\PecMembers\PecMembers.UI\Pages\PecMembersTec\PecMembersEdit.razor"
}
else
{

#line default
#line hidden
#nullable disable
            __builder.AddContent(244, "    ");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Routing.NavLink>(245);
            __builder.AddAttribute(246, "href", 
#nullable restore
#line 126 "C:\Users\gareg\source\repos\PecMembers\PecMembers\PecMembers.UI\Pages\PecMembersTec\PecMembersEdit.razor"
                     $"/PecMembersTec/PecMembersTec"

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(247, "class", "btn btn-outline-success table-btn");
            __builder.AddAttribute(248, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(249, "\r\n        <i class=\"fas fa-edit\"></i>\r\n        Վերադառնալ ընդհանուր ցանկ\r\n    ");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(250, "\r\n");
#nullable restore
#line 130 "C:\Users\gareg\source\repos\PecMembers\PecMembers\PecMembers.UI\Pages\PecMembersTec\PecMembersEdit.razor"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
    }
}
namespace __Blazor.PecMembers.UI.Pages.PecMembersTec.PecMembersEdit
{
    #line hidden
    internal static class TypeInference
    {
        public static void CreateInputDate_0<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, System.Object __arg0, int __seq1, System.Object __arg1, int __seq2, TValue __arg2, int __seq3, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg3, int __seq4, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg4)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.InputDate<TValue>>(seq);
        __builder.AddAttribute(__seq0, "style", __arg0);
        __builder.AddAttribute(__seq1, "class", __arg1);
        __builder.AddAttribute(__seq2, "Value", __arg2);
        __builder.AddAttribute(__seq3, "ValueChanged", __arg3);
        __builder.AddAttribute(__seq4, "ValueExpression", __arg4);
        __builder.CloseComponent();
        }
        public static void CreateInputSelect_1<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, System.Object __arg0, int __seq1, System.Object __arg1, int __seq2, System.Object __arg2, int __seq3, System.Object __arg3, int __seq4, TValue __arg4, int __seq5, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg5, int __seq6, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg6, int __seq7, global::Microsoft.AspNetCore.Components.RenderFragment __arg7)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.InputSelect<TValue>>(seq);
        __builder.AddAttribute(__seq0, "style", __arg0);
        __builder.AddAttribute(__seq1, "id", __arg1);
        __builder.AddAttribute(__seq2, "class", __arg2);
        __builder.AddAttribute(__seq3, "placeholder", __arg3);
        __builder.AddAttribute(__seq4, "Value", __arg4);
        __builder.AddAttribute(__seq5, "ValueChanged", __arg5);
        __builder.AddAttribute(__seq6, "ValueExpression", __arg6);
        __builder.AddAttribute(__seq7, "ChildContent", __arg7);
        __builder.CloseComponent();
        }
        public static void CreateInputNumber_2<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, System.Object __arg0, int __seq1, System.Object __arg1, int __seq2, TValue __arg2, int __seq3, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg3, int __seq4, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg4)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.InputNumber<TValue>>(seq);
        __builder.AddAttribute(__seq0, "style", __arg0);
        __builder.AddAttribute(__seq1, "class", __arg1);
        __builder.AddAttribute(__seq2, "Value", __arg2);
        __builder.AddAttribute(__seq3, "ValueChanged", __arg3);
        __builder.AddAttribute(__seq4, "ValueExpression", __arg4);
        __builder.CloseComponent();
        }
        public static void CreateInputSelect_3<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, System.Object __arg0, int __seq1, System.Object __arg1, int __seq2, System.Object __arg2, int __seq3, System.Object __arg3, int __seq4, TValue __arg4, int __seq5, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg5, int __seq6, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg6, int __seq7, global::Microsoft.AspNetCore.Components.RenderFragment __arg7)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.InputSelect<TValue>>(seq);
        __builder.AddAttribute(__seq0, "style", __arg0);
        __builder.AddAttribute(__seq1, "id", __arg1);
        __builder.AddAttribute(__seq2, "class", __arg2);
        __builder.AddAttribute(__seq3, "placeholder", __arg3);
        __builder.AddAttribute(__seq4, "Value", __arg4);
        __builder.AddAttribute(__seq5, "ValueChanged", __arg5);
        __builder.AddAttribute(__seq6, "ValueExpression", __arg6);
        __builder.AddAttribute(__seq7, "ChildContent", __arg7);
        __builder.CloseComponent();
        }
    }
}
#pragma warning restore 1591
