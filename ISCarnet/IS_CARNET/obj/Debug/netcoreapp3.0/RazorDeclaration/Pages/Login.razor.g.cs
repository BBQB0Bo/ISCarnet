#pragma checksum "C:\Users\Claudiu\Documents\GitHub\ISCarnet\ISCarnet\IS_CARNET\Pages\Login.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "74f3aeef33f2e08ca8534e21ab1826790ab9bf9d"
// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace IS_CARNET.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\Claudiu\Documents\GitHub\ISCarnet\ISCarnet\IS_CARNET\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Claudiu\Documents\GitHub\ISCarnet\ISCarnet\IS_CARNET\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Claudiu\Documents\GitHub\ISCarnet\ISCarnet\IS_CARNET\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Claudiu\Documents\GitHub\ISCarnet\ISCarnet\IS_CARNET\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Claudiu\Documents\GitHub\ISCarnet\ISCarnet\IS_CARNET\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\Claudiu\Documents\GitHub\ISCarnet\ISCarnet\IS_CARNET\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\Claudiu\Documents\GitHub\ISCarnet\ISCarnet\IS_CARNET\_Imports.razor"
using Microsoft.AspNetCore.ProtectedBrowserStorage;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\Claudiu\Documents\GitHub\ISCarnet\ISCarnet\IS_CARNET\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\Claudiu\Documents\GitHub\ISCarnet\ISCarnet\IS_CARNET\_Imports.razor"
using IS_CARNET;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\Claudiu\Documents\GitHub\ISCarnet\ISCarnet\IS_CARNET\_Imports.razor"
using IS_CARNET.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\Claudiu\Documents\GitHub\ISCarnet\ISCarnet\IS_CARNET\_Imports.razor"
using DataBaseLibrary.DTOs;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Users\Claudiu\Documents\GitHub\ISCarnet\ISCarnet\IS_CARNET\_Imports.razor"
using DataBaseLibrary.DTOs.PastExam;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "C:\Users\Claudiu\Documents\GitHub\ISCarnet\ISCarnet\IS_CARNET\_Imports.razor"
using Newtonsoft.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "C:\Users\Claudiu\Documents\GitHub\ISCarnet\ISCarnet\IS_CARNET\_Imports.razor"
using System.Text;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/login")]
    public partial class Login : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 31 "C:\Users\Claudiu\Documents\GitHub\ISCarnet\ISCarnet\IS_CARNET\Pages\Login.razor"
           
        AccountDTO dto = new AccountDTO();
        Boolean loginAttempt = false;
        string username = "";
        private async Task SearchAccount()
        {
            HttpClient Http = new HttpClient();
            HttpContent content = new StringContent(JsonConvert.SerializeObject(dto), Encoding.UTF8, "application/json");
            HttpResponseMessage h = await Http.PostAsync("https://localhost:44365/api/Accounts", content);
            var responseJSON = h.Content.ReadAsStringAsync().Result;
            AccountDTO acc = JsonConvert.DeserializeObject<AccountDTO>(responseJSON);
            username = acc.UserName;
            if (username != null)
            {
                State.CurrentUser = username;
            }
            loginAttempt = true;


        }
    

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
