#pragma checksum "D:\dev\Github\ISCarnet\ISCarnet\IS_CARNET\Shared\NavMenu.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5cb8c097a3184d47da58f9f9950faf4d64bb3bb4"
// <auto-generated/>
#pragma warning disable 1591
namespace IS_CARNET.Shared
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
#nullable restore
#line 1 "D:\dev\Github\ISCarnet\ISCarnet\IS_CARNET\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\dev\Github\ISCarnet\ISCarnet\IS_CARNET\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\dev\Github\ISCarnet\ISCarnet\IS_CARNET\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\dev\Github\ISCarnet\ISCarnet\IS_CARNET\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "D:\dev\Github\ISCarnet\ISCarnet\IS_CARNET\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "D:\dev\Github\ISCarnet\ISCarnet\IS_CARNET\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "D:\dev\Github\ISCarnet\ISCarnet\IS_CARNET\_Imports.razor"
using Microsoft.AspNetCore.Components;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "D:\dev\Github\ISCarnet\ISCarnet\IS_CARNET\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "D:\dev\Github\ISCarnet\ISCarnet\IS_CARNET\_Imports.razor"
using IS_CARNET;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "D:\dev\Github\ISCarnet\ISCarnet\IS_CARNET\_Imports.razor"
using IS_CARNET.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "D:\dev\Github\ISCarnet\ISCarnet\IS_CARNET\_Imports.razor"
using DataBaseLibrary;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "D:\dev\Github\ISCarnet\ISCarnet\IS_CARNET\_Imports.razor"
using DataBaseLibrary.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "D:\dev\Github\ISCarnet\ISCarnet\IS_CARNET\_Imports.razor"
using DataBaseLibrary.DTOs;

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "D:\dev\Github\ISCarnet\ISCarnet\IS_CARNET\_Imports.razor"
using DataBaseLibrary.DTOs.PastExam;

#line default
#line hidden
#nullable disable
#nullable restore
#line 15 "D:\dev\Github\ISCarnet\ISCarnet\IS_CARNET\_Imports.razor"
using Newtonsoft.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 16 "D:\dev\Github\ISCarnet\ISCarnet\IS_CARNET\_Imports.razor"
using System.Text;

#line default
#line hidden
#nullable disable
#nullable restore
#line 17 "D:\dev\Github\ISCarnet\ISCarnet\IS_CARNET\_Imports.razor"
using Radzen;

#line default
#line hidden
#nullable disable
#nullable restore
#line 18 "D:\dev\Github\ISCarnet\ISCarnet\IS_CARNET\_Imports.razor"
using Radzen.Blazor;

#line default
#line hidden
#nullable disable
    public partial class NavMenu : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
#nullable restore
#line 4 "D:\dev\Github\ISCarnet\ISCarnet\IS_CARNET\Shared\NavMenu.razor"
 if (string.IsNullOrEmpty(State.CurrentUser) && string.IsNullOrEmpty(State.CurrentUser))
{

#line default
#line hidden
#nullable disable
            __builder.AddContent(0, "    ");
            __builder.OpenElement(1, "div");
            __builder.AddAttribute(2, "class", "topnav");
            __builder.AddMarkupContent(3, "\r\n        ");
            __builder.AddMarkupContent(4, "<a class=\"active\" href=\"#home\">Home</a>\r\n        ");
            __builder.AddMarkupContent(5, "<a href=\"#news\">News</a>\r\n        ");
            __builder.AddMarkupContent(6, "<a href=\"#contact\">Contact</a>\r\n        ");
            __builder.AddMarkupContent(7, "<a href=\"#about\">About</a>\r\n        ");
            __builder.AddMarkupContent(8, "<a class=\"partdr\" href>Login</a>\r\n        ");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Routing.NavLink>(9);
            __builder.AddAttribute(10, "class", "nav-link");
            __builder.AddAttribute(11, "href", "");
            __builder.AddAttribute(12, "Match", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.Routing.NavLinkMatch>(
#nullable restore
#line 12 "D:\dev\Github\ISCarnet\ISCarnet\IS_CARNET\Shared\NavMenu.razor"
                                                 NavLinkMatch.All

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(13, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(14, "\r\n            <span class=\"oi oi-home\" aria-hidden=\"true\"></span> Home\r\n        ");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(15, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(16, "\r\n");
#nullable restore
#line 16 "D:\dev\Github\ISCarnet\ISCarnet\IS_CARNET\Shared\NavMenu.razor"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 19 "D:\dev\Github\ISCarnet\ISCarnet\IS_CARNET\Shared\NavMenu.razor"
       
    bool collapseNavMenu = true;

    string NavMenuCssClass => collapseNavMenu ? "collapse" : null;

    void ToggleNavMenu()
    {
        collapseNavMenu = !collapseNavMenu;
    }
    void Logout()
    {
        State.CurrentUser = string.Empty;
        AdminState.CurrentUser = string.Empty;
        NavigationManager.NavigateTo("");

    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavigationManager { get; set; }
    }
}
#pragma warning restore 1591
