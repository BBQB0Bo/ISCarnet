#pragma checksum "C:\Users\Claudiu\Documents\GitHub\ISCarnet\ISCarnet\IS_CARNET\Pages\AddExam.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ab00de8de38f576c59d5b6b704d0a6b71fb5dce8"
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
using DataBaseLibrary.DTOs;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "C:\Users\Claudiu\Documents\GitHub\ISCarnet\ISCarnet\IS_CARNET\_Imports.razor"
using DataBaseLibrary.DTOs.PastExam;

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "C:\Users\Claudiu\Documents\GitHub\ISCarnet\ISCarnet\IS_CARNET\_Imports.razor"
using Newtonsoft.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 15 "C:\Users\Claudiu\Documents\GitHub\ISCarnet\ISCarnet\IS_CARNET\_Imports.razor"
using System.Text;

#line default
#line hidden
#nullable disable
#nullable restore
#line 16 "C:\Users\Claudiu\Documents\GitHub\ISCarnet\ISCarnet\IS_CARNET\_Imports.razor"
using Radzen;

#line default
#line hidden
#nullable disable
#nullable restore
#line 17 "C:\Users\Claudiu\Documents\GitHub\ISCarnet\ISCarnet\IS_CARNET\_Imports.razor"
using Radzen.Blazor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Claudiu\Documents\GitHub\ISCarnet\ISCarnet\IS_CARNET\Pages\AddExam.razor"
using IS_CARNET.Data;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/addexam")]
    public partial class AddExam : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Forms.EditForm>(0);
            __builder.AddAttribute(1, "Model", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#nullable restore
#line 5 "C:\Users\Claudiu\Documents\GitHub\ISCarnet\ISCarnet\IS_CARNET\Pages\AddExam.razor"
                  dto

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(2, "OnValidSubmit", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Forms.EditContext>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Forms.EditContext>(this, 
#nullable restore
#line 5 "C:\Users\Claudiu\Documents\GitHub\ISCarnet\ISCarnet\IS_CARNET\Pages\AddExam.razor"
                                       SubmitExam

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(3, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Forms.EditContext>)((context) => (__builder2) => {
                __builder2.AddMarkupContent(4, "\r\n    ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.DataAnnotationsValidator>(5);
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(6, "\r\n    ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.ValidationSummary>(7);
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(8, "\r\n    ");
                __builder2.OpenElement(9, "div");
                __builder2.AddAttribute(10, "class", "form");
                __builder2.AddMarkupContent(11, "\r\n        ");
                __builder2.AddMarkupContent(12, "<h1>ADD Exam</h1>\r\n\r\n        ");
                __builder2.OpenElement(13, "p");
                __builder2.AddMarkupContent(14, "\r\n            ");
                __builder2.AddMarkupContent(15, "<label for=\"username\">Username:</label>\r\n            ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(16);
                __builder2.AddAttribute(17, "id", "username");
                __builder2.AddAttribute(18, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 13 "C:\Users\Claudiu\Documents\GitHub\ISCarnet\ISCarnet\IS_CARNET\Pages\AddExam.razor"
                                                  dto.usernameCandidate

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(19, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => dto.usernameCandidate = __value, dto.usernameCandidate))));
                __builder2.AddAttribute(20, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => dto.usernameCandidate));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(21, "\r\n        ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(22, "\r\n        ");
                __builder2.OpenElement(23, "p");
                __builder2.AddMarkupContent(24, "\r\n            ");
                __builder2.AddMarkupContent(25, "<label for=\"date\">Date:</label>\r\n            ");
                __Blazor.IS_CARNET.Pages.AddExam.TypeInference.CreateInputDate_0(__builder2, 26, 27, "birthdate", 28, 
#nullable restore
#line 17 "C:\Users\Claudiu\Documents\GitHub\ISCarnet\ISCarnet\IS_CARNET\Pages\AddExam.razor"
                                                   dto.ExamDate

#line default
#line hidden
#nullable disable
                , 29, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => dto.ExamDate = __value, dto.ExamDate)), 30, () => dto.ExamDate);
                __builder2.AddMarkupContent(31, "\r\n        ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(32, "\r\n        ");
                __builder2.OpenElement(33, "p");
                __builder2.AddMarkupContent(34, "\r\n            ");
                __builder2.AddMarkupContent(35, "<label for=\"examinator\">Examinator:</label>\r\n            ");
                __Blazor.IS_CARNET.Pages.AddExam.TypeInference.CreateInputSelect_1(__builder2, 36, 37, "username", 38, "Model.examinators", 39, 
#nullable restore
#line 21 "C:\Users\Claudiu\Documents\GitHub\ISCarnet\ISCarnet\IS_CARNET\Pages\AddExam.razor"
                                                                                  dto.ExaminatorName

#line default
#line hidden
#nullable disable
                , 40, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => dto.ExaminatorName = __value, dto.ExaminatorName)), 41, () => dto.ExaminatorName, 42, (__builder3) => {
                    __builder3.AddMarkupContent(43, "\r\n");
#nullable restore
#line 22 "C:\Users\Claudiu\Documents\GitHub\ISCarnet\ISCarnet\IS_CARNET\Pages\AddExam.razor"
                 foreach (ExaminatorDTO ex in examinas)
                {

#line default
#line hidden
#nullable disable
                    __builder3.AddContent(44, "                    ");
                    __builder3.OpenElement(45, "option");
                    __builder3.AddAttribute(46, "value", 
#nullable restore
#line 24 "C:\Users\Claudiu\Documents\GitHub\ISCarnet\ISCarnet\IS_CARNET\Pages\AddExam.razor"
                                    ex.FirstName + " " + ex.LastName

#line default
#line hidden
#nullable disable
                    );
                    __builder3.AddContent(47, 
#nullable restore
#line 24 "C:\Users\Claudiu\Documents\GitHub\ISCarnet\ISCarnet\IS_CARNET\Pages\AddExam.razor"
                                                                        ex.FirstName + " " + ex.LastName

#line default
#line hidden
#nullable disable
                    );
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(48, "\r\n");
#nullable restore
#line 25 "C:\Users\Claudiu\Documents\GitHub\ISCarnet\ISCarnet\IS_CARNET\Pages\AddExam.razor"
                }

#line default
#line hidden
#nullable disable
                    __builder3.AddMarkupContent(49, "\r\n            ");
                }
                );
                __builder2.AddMarkupContent(50, "\r\n        ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(51, "\r\n        ");
                __builder2.AddMarkupContent(52, "<button type=\"submit\">ADD EXAM</button>\r\n\r\n\r\n    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(53, "\r\n");
            }
            ));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
#nullable restore
#line 35 "C:\Users\Claudiu\Documents\GitHub\ISCarnet\ISCarnet\IS_CARNET\Pages\AddExam.razor"
       



    private CreateExam dto = new CreateExam();
    private List<ExaminatorDTO> examinas = new List<ExaminatorDTO>();


    // AICI TREBUIE MODIFICAT LINKUL DE API SI CREAT APIUL CARE RETURNEAZA LISTA CU EXAMINATORI
    HttpClient Http = new HttpClient();
    private string apiUrl = "https://localhost:44369/api/Examinators";
    protected override async Task OnInitializedAsync()
    {
        dto.ExamDate = DateTime.Today;
        examinas = await Http.GetJsonAsync<List<ExaminatorDTO>>
        (apiUrl);
    }

    // FUNCTIA DE SUBMIT
    private async Task SubmitExam()
    {

        HttpContent content = new StringContent(JsonConvert.SerializeObject(dto), Encoding.UTF8, "application/json");
        HttpResponseMessage h = await Http.PostAsync("https://localhost:44316/api/pastExam", content);
        var responseJSON = h.Content.ReadAsStringAsync().Result;
        Exam exam = JsonConvert.DeserializeObject<Exam>(responseJSON);

    }


#line default
#line hidden
#nullable disable
    }
}
namespace __Blazor.IS_CARNET.Pages.AddExam
{
    #line hidden
    internal static class TypeInference
    {
        public static void CreateInputDate_0<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, System.Object __arg0, int __seq1, TValue __arg1, int __seq2, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg2, int __seq3, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg3)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.InputDate<TValue>>(seq);
        __builder.AddAttribute(__seq0, "id", __arg0);
        __builder.AddAttribute(__seq1, "Value", __arg1);
        __builder.AddAttribute(__seq2, "ValueChanged", __arg2);
        __builder.AddAttribute(__seq3, "ValueExpression", __arg3);
        __builder.CloseComponent();
        }
        public static void CreateInputSelect_1<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, System.Object __arg0, int __seq1, System.Object __arg1, int __seq2, TValue __arg2, int __seq3, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg3, int __seq4, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg4, int __seq5, global::Microsoft.AspNetCore.Components.RenderFragment __arg5)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.InputSelect<TValue>>(seq);
        __builder.AddAttribute(__seq0, "id", __arg0);
        __builder.AddAttribute(__seq1, "asp-items", __arg1);
        __builder.AddAttribute(__seq2, "Value", __arg2);
        __builder.AddAttribute(__seq3, "ValueChanged", __arg3);
        __builder.AddAttribute(__seq4, "ValueExpression", __arg4);
        __builder.AddAttribute(__seq5, "ChildContent", __arg5);
        __builder.CloseComponent();
        }
    }
}
#pragma warning restore 1591
