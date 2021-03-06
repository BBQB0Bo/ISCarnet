#pragma checksum "C:\Users\Claudiu\Documents\GitHub\ISCarnet\ISCarnet\IS_CARNET\Pages\FetchPastExams.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f099ec7ba9b182328d6ebed29a6894252e5a2ade"
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
using Microsoft.AspNetCore.Components;

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
using DataBaseLibrary;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Users\Claudiu\Documents\GitHub\ISCarnet\ISCarnet\IS_CARNET\_Imports.razor"
using DataBaseLibrary.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "C:\Users\Claudiu\Documents\GitHub\ISCarnet\ISCarnet\IS_CARNET\_Imports.razor"
using DataBaseLibrary.DTOs;

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "C:\Users\Claudiu\Documents\GitHub\ISCarnet\ISCarnet\IS_CARNET\_Imports.razor"
using DataBaseLibrary.DTOs.PastExam;

#line default
#line hidden
#nullable disable
#nullable restore
#line 15 "C:\Users\Claudiu\Documents\GitHub\ISCarnet\ISCarnet\IS_CARNET\_Imports.razor"
using Newtonsoft.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 16 "C:\Users\Claudiu\Documents\GitHub\ISCarnet\ISCarnet\IS_CARNET\_Imports.razor"
using System.Text;

#line default
#line hidden
#nullable disable
#nullable restore
#line 17 "C:\Users\Claudiu\Documents\GitHub\ISCarnet\ISCarnet\IS_CARNET\_Imports.razor"
using Radzen;

#line default
#line hidden
#nullable disable
#nullable restore
#line 18 "C:\Users\Claudiu\Documents\GitHub\ISCarnet\ISCarnet\IS_CARNET\_Imports.razor"
using Radzen.Blazor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Claudiu\Documents\GitHub\ISCarnet\ISCarnet\IS_CARNET\Pages\FetchPastExams.razor"
using IS_CARNET.Data;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/fetchpastexams")]
    public partial class FetchPastExams : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "form");
            __builder.AddMarkupContent(2, "\r\n    ");
            __builder.AddMarkupContent(3, "<h1>Past Exams</h1>\r\n\r\n\r\n");
#nullable restore
#line 9 "C:\Users\Claudiu\Documents\GitHub\ISCarnet\ISCarnet\IS_CARNET\Pages\FetchPastExams.razor"
     if (State.CurrentUser != null)
    {

#line default
#line hidden
#nullable disable
            __builder.AddContent(4, "        ");
            __builder.OpenElement(5, "p");
            __builder.AddContent(6, 
#nullable restore
#line 11 "C:\Users\Claudiu\Documents\GitHub\ISCarnet\ISCarnet\IS_CARNET\Pages\FetchPastExams.razor"
            State.CurrentUser

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(7, "\r\n");
#nullable restore
#line 12 "C:\Users\Claudiu\Documents\GitHub\ISCarnet\ISCarnet\IS_CARNET\Pages\FetchPastExams.razor"
         if (exams != null && exams.Length >= 1)
        {
            

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "C:\Users\Claudiu\Documents\GitHub\ISCarnet\ISCarnet\IS_CARNET\Pages\FetchPastExams.razor"
             foreach (var exam in exams)
            {

#line default
#line hidden
#nullable disable
            __builder.AddContent(8, "                ");
            __builder.OpenElement(9, "h4");
            __builder.AddContent(10, 
#nullable restore
#line 16 "C:\Users\Claudiu\Documents\GitHub\ISCarnet\ISCarnet\IS_CARNET\Pages\FetchPastExams.razor"
                      "Date:" + exam.ExamDate.ToShortDateString() + "Score:" + exam.Score + " Result:" + exam.Result + " Examinator:" + exam.Examinator

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(11, "\r\n");
#nullable restore
#line 17 "C:\Users\Claudiu\Documents\GitHub\ISCarnet\ISCarnet\IS_CARNET\Pages\FetchPastExams.razor"
                if (exam.Mistakes.Count > 0)
                {

#line default
#line hidden
#nullable disable
            __builder.AddContent(12, " ");
            __builder.OpenElement(13, "table");
            __builder.AddAttribute(14, "class", "table");
            __builder.AddMarkupContent(15, "\r\n                        ");
            __builder.AddMarkupContent(16, "<thead>\r\n                            <tr>\r\n                                <th>Mistake</th>\r\n                                <th>Score</th>\r\n                            </tr>\r\n                        </thead>\r\n                        ");
            __builder.OpenElement(17, "tbody");
            __builder.AddMarkupContent(18, "\r\n");
#nullable restore
#line 26 "C:\Users\Claudiu\Documents\GitHub\ISCarnet\ISCarnet\IS_CARNET\Pages\FetchPastExams.razor"
                             foreach (var mistake in exam.Mistakes)
                            {

#line default
#line hidden
#nullable disable
            __builder.AddContent(19, "                                ");
            __builder.OpenElement(20, "tr");
            __builder.AddMarkupContent(21, "\r\n                                    ");
            __builder.OpenElement(22, "td");
            __builder.AddContent(23, 
#nullable restore
#line 29 "C:\Users\Claudiu\Documents\GitHub\ISCarnet\ISCarnet\IS_CARNET\Pages\FetchPastExams.razor"
                                         mistake.MistakeType

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(24, "\r\n                                    ");
            __builder.OpenElement(25, "td");
            __builder.AddContent(26, 
#nullable restore
#line 30 "C:\Users\Claudiu\Documents\GitHub\ISCarnet\ISCarnet\IS_CARNET\Pages\FetchPastExams.razor"
                                         mistake.Score

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(27, "\r\n\r\n                                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(28, "\r\n");
#nullable restore
#line 33 "C:\Users\Claudiu\Documents\GitHub\ISCarnet\ISCarnet\IS_CARNET\Pages\FetchPastExams.razor"
                            }

#line default
#line hidden
#nullable disable
            __builder.AddContent(29, "                        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(30, "\r\n                    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(31, "\r\n");
#nullable restore
#line 36 "C:\Users\Claudiu\Documents\GitHub\ISCarnet\ISCarnet\IS_CARNET\Pages\FetchPastExams.razor"
                }
            }

#line default
#line hidden
#nullable disable
#nullable restore
#line 37 "C:\Users\Claudiu\Documents\GitHub\ISCarnet\ISCarnet\IS_CARNET\Pages\FetchPastExams.razor"
             
        }
        else
        {

#line default
#line hidden
#nullable disable
            __builder.AddContent(32, " ");
            __builder.AddMarkupContent(33, "<p>Nu aveti examene inregistrate</p>");
#nullable restore
#line 40 "C:\Users\Claudiu\Documents\GitHub\ISCarnet\ISCarnet\IS_CARNET\Pages\FetchPastExams.razor"
                                              }

#line default
#line hidden
#nullable disable
#nullable restore
#line 40 "C:\Users\Claudiu\Documents\GitHub\ISCarnet\ISCarnet\IS_CARNET\Pages\FetchPastExams.razor"
                                               
    }
    else
    {

#line default
#line hidden
#nullable disable
            __builder.AddContent(34, "        ");
            __builder.AddMarkupContent(35, "<p>Va rugam sa va logati pentru a accesa istoricul examenelor</p>\r\n");
#nullable restore
#line 45 "C:\Users\Claudiu\Documents\GitHub\ISCarnet\ISCarnet\IS_CARNET\Pages\FetchPastExams.razor"
    }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 49 "C:\Users\Claudiu\Documents\GitHub\ISCarnet\ISCarnet\IS_CARNET\Pages\FetchPastExams.razor"
       
    private ExamDTO[] exams;

    HttpClient Http = new HttpClient();
    private string apiUrl = "https://localhost:44316/api/pastExam/" + State.CurrentUser;
    protected override async Task OnInitializedAsync()
    {
        exams = await Http.GetJsonAsync<ExamDTO[]>(apiUrl);
    }




#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
