#pragma checksum "D:\dev\ISCarnet\IS_CARNET\Pages\Login.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2ac90a697b557440d5d54dd9bdd008f093e4928a"
// <auto-generated/>
#pragma warning disable 1591
namespace IS_CARNET.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
#nullable restore
#line 1 "D:\dev\ISCarnet\IS_CARNET\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\dev\ISCarnet\IS_CARNET\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\dev\ISCarnet\IS_CARNET\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\dev\ISCarnet\IS_CARNET\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "D:\dev\ISCarnet\IS_CARNET\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "D:\dev\ISCarnet\IS_CARNET\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "D:\dev\ISCarnet\IS_CARNET\_Imports.razor"
using Microsoft.AspNetCore.Components;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "D:\dev\ISCarnet\IS_CARNET\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "D:\dev\ISCarnet\IS_CARNET\_Imports.razor"
using IS_CARNET;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "D:\dev\ISCarnet\IS_CARNET\_Imports.razor"
using IS_CARNET.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "D:\dev\ISCarnet\IS_CARNET\_Imports.razor"
using DataBaseLibrary;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "D:\dev\ISCarnet\IS_CARNET\_Imports.razor"
using DataBaseLibrary.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "D:\dev\ISCarnet\IS_CARNET\_Imports.razor"
using DataBaseLibrary.DTOs;

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "D:\dev\ISCarnet\IS_CARNET\_Imports.razor"
using DataBaseLibrary.DTOs.PastExam;

#line default
#line hidden
#nullable disable
#nullable restore
#line 15 "D:\dev\ISCarnet\IS_CARNET\_Imports.razor"
using Newtonsoft.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 16 "D:\dev\ISCarnet\IS_CARNET\_Imports.razor"
using System.Text;

#line default
#line hidden
#nullable disable
#nullable restore
#line 17 "D:\dev\ISCarnet\IS_CARNET\_Imports.razor"
using Radzen;

#line default
#line hidden
#nullable disable
#nullable restore
#line 18 "D:\dev\ISCarnet\IS_CARNET\_Imports.razor"
using Radzen.Blazor;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/login")]
    public partial class Login : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "form");
            __builder.AddMarkupContent(2, "\r\n");
#nullable restore
#line 3 "D:\dev\ISCarnet\IS_CARNET\Pages\Login.razor"
     if (string.IsNullOrEmpty(AdminState.CurrentUser))
    {

#line default
#line hidden
#nullable disable
            __builder.AddContent(3, "        ");
            __builder.AddMarkupContent(4, "<h1>LOGIN</h1>\r\n");
            __builder.AddContent(5, "        ");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Forms.EditForm>(6);
            __builder.AddAttribute(7, "Model", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#nullable restore
#line 7 "D:\dev\ISCarnet\IS_CARNET\Pages\Login.razor"
                          dto

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(8, "OnValidSubmit", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Forms.EditContext>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Forms.EditContext>(this, 
#nullable restore
#line 7 "D:\dev\ISCarnet\IS_CARNET\Pages\Login.razor"
                                               SearchAccount

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(9, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Forms.EditContext>)((context) => (__builder2) => {
                __builder2.AddMarkupContent(10, "\r\n            ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.DataAnnotationsValidator>(11);
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(12, "\r\n            ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.ValidationSummary>(13);
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(14, "\r\n            ");
                __builder2.OpenElement(15, "p");
                __builder2.AddMarkupContent(16, "\r\n                ");
                __builder2.AddMarkupContent(17, "<label for=\"username\">Username:</label>\r\n                ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(18);
                __builder2.AddAttribute(19, "id", "username");
                __builder2.AddAttribute(20, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 12 "D:\dev\ISCarnet\IS_CARNET\Pages\Login.razor"
                                                      dto.UserName

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(21, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => dto.UserName = __value, dto.UserName))));
                __builder2.AddAttribute(22, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => dto.UserName));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(23, "\r\n            ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(24, "\r\n\r\n            ");
                __builder2.OpenElement(25, "p");
                __builder2.AddMarkupContent(26, "\r\n                ");
                __builder2.AddMarkupContent(27, "<label for=\"password\">Password:</label>\r\n                ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(28);
                __builder2.AddAttribute(29, "type", "password");
                __builder2.AddAttribute(30, "id", "password");
                __builder2.AddAttribute(31, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 17 "D:\dev\ISCarnet\IS_CARNET\Pages\Login.razor"
                                                                      dto.Password

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(32, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => dto.Password = __value, dto.Password))));
                __builder2.AddAttribute(33, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => dto.Password));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(34, "\r\n            ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(35, "\r\n            ");
                __builder2.AddMarkupContent(36, "<button type=\"submit\">Login</button>\r\n        ");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(37, "\r\n");
#nullable restore
#line 21 "D:\dev\ISCarnet\IS_CARNET\Pages\Login.razor"
    }
    else
    {

#line default
#line hidden
#nullable disable
            __builder.AddContent(38, "        ");
            __builder.AddMarkupContent(39, "<p>Sunteti deja logat ca administrator!</p>\r\n");
#nullable restore
#line 25 "D:\dev\ISCarnet\IS_CARNET\Pages\Login.razor"
    }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(40, "\r\n");
#nullable restore
#line 27 "D:\dev\ISCarnet\IS_CARNET\Pages\Login.razor"
 if (loginAttempt)
{

#line default
#line hidden
#nullable disable
            __builder.AddContent(41, "    ");
            __builder.OpenElement(42, "p");
            __builder.AddContent(43, 
#nullable restore
#line 29 "D:\dev\ISCarnet\IS_CARNET\Pages\Login.razor"
        message

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(44, "\r\n");
#nullable restore
#line 30 "D:\dev\ISCarnet\IS_CARNET\Pages\Login.razor"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 31 "D:\dev\ISCarnet\IS_CARNET\Pages\Login.razor"
       

    AccountDTO dto = new AccountDTO();
    Boolean loginAttempt = false;
    string username = "";
    string message = String.Empty;
    private async Task SearchAccount()
    {
        HttpClient Http = new HttpClient();
        HttpContent content = new StringContent(JsonConvert.SerializeObject(dto), Encoding.UTF8, "application/json");
        HttpResponseMessage h = await Http.PostAsync("https://localhost:44365/api/Accounts", content);
        if (h.IsSuccessStatusCode)
        {
            var responseJSON = h.Content.ReadAsStringAsync().Result;
            AccountDTO acc = JsonConvert.DeserializeObject<AccountDTO>(responseJSON);
            username = acc.UserName;
            State.CurrentUser = username;
            message = "Login reusit";
            this.StateHasChanged();


        }
        else
        {
            message = "Username sau parola incorecte!";
        }
        loginAttempt = true;

    }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
