#pragma checksum "C:\Users\gareg\source\repos\PecMembers\PecMembers\PecMembers.UI\Shared\GridColumn.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4eb0d331e952472031541a509582c0505077c9a4"
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
    public partial class GridColumn : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "th");
            __builder.AddAttribute(1, "style", "text-align: center; border-color:white; color: white");
            __builder.AddMarkupContent(2, "\r\n    ");
            __builder.AddContent(3, 
#nullable restore
#line 3 "C:\Users\gareg\source\repos\PecMembers\PecMembers\PecMembers.UI\Shared\GridColumn.razor"
     ColumnTitle

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(4, "\r\n\r\n    ");
            __builder.OpenElement(5, "input");
            __builder.AddAttribute(6, "class", "form-control");
            __builder.AddAttribute(7, "placeholder", "");
            __builder.AddAttribute(8, "value", 
#nullable restore
#line 5 "C:\Users\gareg\source\repos\PecMembers\PecMembers\PecMembers.UI\Shared\GridColumn.razor"
                                                       Value

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(9, "oninput", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.ChangeEventArgs>(this, 
#nullable restore
#line 5 "C:\Users\gareg\source\repos\PecMembers\PecMembers\PecMembers.UI\Shared\GridColumn.razor"
                                                                        OnSearchTextChanged

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseElement();
            __builder.AddMarkupContent(10, "\r\n\r\n");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 10 "C:\Users\gareg\source\repos\PecMembers\PecMembers\PecMembers.UI\Shared\GridColumn.razor"
       

    [Parameter]
    public string ColumnTitle { get; set; }
    [Parameter]
    public string Value { get; set; }

    [Parameter]
    public EventCallback<ChangeEventArgs> OnSearchTextChanged { get; set; }


#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
