#pragma checksum "D:\dev\Github\ISCarnet\ISCarnet\IS_CARNET\Pages\AddExam.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "19171b1dc52d58a118303ed212524d6291c1885b"
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
#nullable restore
#line 3 "D:\dev\Github\ISCarnet\ISCarnet\IS_CARNET\Pages\AddExam.razor"
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
#nullable restore
#line 7 "D:\dev\Github\ISCarnet\ISCarnet\IS_CARNET\Pages\AddExam.razor"
 if (!string.IsNullOrEmpty(AdminState.CurrentUser))
{

#line default
#line hidden
#nullable disable
            __builder.AddContent(0, "    ");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Forms.EditForm>(1);
            __builder.AddAttribute(2, "Model", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#nullable restore
#line 9 "D:\dev\Github\ISCarnet\ISCarnet\IS_CARNET\Pages\AddExam.razor"
                      dto

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(3, "OnValidSubmit", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Forms.EditContext>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Forms.EditContext>(this, 
#nullable restore
#line 9 "D:\dev\Github\ISCarnet\ISCarnet\IS_CARNET\Pages\AddExam.razor"
                                           SubmitExam

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(4, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Forms.EditContext>)((context) => (__builder2) => {
                __builder2.AddMarkupContent(5, "\r\n        ");
                __builder2.OpenElement(6, "div");
                __builder2.AddAttribute(7, "class", "login-page");
                __builder2.AddMarkupContent(8, "\r\n            <img src=\"img/logo.png\" class=\"logo_middle\">\r\n            ");
                __builder2.AddMarkupContent(9, "<button onclick=\"location.href = \'/\'\" class=\"fixedButton\">HOME</button>\r\n            ");
                __builder2.OpenElement(10, "div");
                __builder2.AddAttribute(11, "class", "form");
                __builder2.AddMarkupContent(12, "\r\n               \r\n                    ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.DataAnnotationsValidator>(13);
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(14, "\r\n                    ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.ValidationSummary>(15);
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(16, "\r\n                    ");
                __builder2.OpenElement(17, "p");
                __builder2.AddMarkupContent(18, "\r\n                        ");
                __builder2.AddMarkupContent(19, "<label for=\"username\">Username:</label>\r\n                        ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(20);
                __builder2.AddAttribute(21, "id", "username");
                __builder2.AddAttribute(22, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 19 "D:\dev\Github\ISCarnet\ISCarnet\IS_CARNET\Pages\AddExam.razor"
                                                              dto.usernameCandidate

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(23, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => dto.usernameCandidate = __value, dto.usernameCandidate))));
                __builder2.AddAttribute(24, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => dto.usernameCandidate));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(25, "\r\n                    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(26, "\r\n                    ");
                __builder2.OpenElement(27, "p");
                __builder2.AddMarkupContent(28, "\r\n                        ");
                __builder2.AddMarkupContent(29, "<label for=\"date\">Date:</label>\r\n                        ");
                __Blazor.IS_CARNET.Pages.AddExam.TypeInference.CreateInputDate_0(__builder2, 30, 31, "birthdate", 32, 
#nullable restore
#line 23 "D:\dev\Github\ISCarnet\ISCarnet\IS_CARNET\Pages\AddExam.razor"
                                                               dto.ExamDate

#line default
#line hidden
#nullable disable
                , 33, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => dto.ExamDate = __value, dto.ExamDate)), 34, () => dto.ExamDate);
                __builder2.AddMarkupContent(35, "\r\n                    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(36, "\r\n                    ");
                __builder2.OpenElement(37, "p");
                __builder2.AddMarkupContent(38, "\r\n                        ");
                __builder2.AddMarkupContent(39, "<label for=\"examinator\">Examinator:</label>\r\n                        ");
                __Blazor.IS_CARNET.Pages.AddExam.TypeInference.CreateInputSelect_1(__builder2, 40, 41, "username", 42, "Model.examinators", 43, 
#nullable restore
#line 27 "D:\dev\Github\ISCarnet\ISCarnet\IS_CARNET\Pages\AddExam.razor"
                                                                                              dto.ExaminatorName

#line default
#line hidden
#nullable disable
                , 44, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => dto.ExaminatorName = __value, dto.ExaminatorName)), 45, () => dto.ExaminatorName, 46, (__builder3) => {
                    __builder3.AddMarkupContent(47, "\r\n");
#nullable restore
#line 28 "D:\dev\Github\ISCarnet\ISCarnet\IS_CARNET\Pages\AddExam.razor"
                             foreach (ExaminatorDTO ex in examinas)
                                {

#line default
#line hidden
#nullable disable
                    __builder3.AddContent(48, "                                ");
                    __builder3.OpenElement(49, "option");
                    __builder3.AddAttribute(50, "value", 
#nullable restore
#line 30 "D:\dev\Github\ISCarnet\ISCarnet\IS_CARNET\Pages\AddExam.razor"
                                                ex.FirstName + " " + ex.LastName

#line default
#line hidden
#nullable disable
                    );
                    __builder3.AddContent(51, 
#nullable restore
#line 30 "D:\dev\Github\ISCarnet\ISCarnet\IS_CARNET\Pages\AddExam.razor"
                                                                                    ex.FirstName + " " + ex.LastName

#line default
#line hidden
#nullable disable
                    );
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(52, "\r\n");
#nullable restore
#line 31 "D:\dev\Github\ISCarnet\ISCarnet\IS_CARNET\Pages\AddExam.razor"
                                }

#line default
#line hidden
#nullable disable
                    __builder3.AddMarkupContent(53, "                            /**/\r\n                            /**/\r\n                            /**/\r\n                            /**/\r\n                            /**/\r\n                            /**/\r\n\r\n\r\n                        ");
                }
                );
                __builder2.AddMarkupContent(54, "\r\n                    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(55, "\r\n                    ");
                __builder2.OpenElement(56, "p");
                __builder2.AddMarkupContent(57, "\r\n                        ");
                __builder2.AddMarkupContent(58, "<label for=\"examinator\">Locatie de plecare:</label>\r\n                        ");
                __Blazor.IS_CARNET.Pages.AddExam.TypeInference.CreateInputSelect_2(__builder2, 59, 60, "username", 61, "Model.locations", 62, 
#nullable restore
#line 44 "D:\dev\Github\ISCarnet\ISCarnet\IS_CARNET\Pages\AddExam.razor"
                                                                                            dto.LocationName

#line default
#line hidden
#nullable disable
                , 63, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => dto.LocationName = __value, dto.LocationName)), 64, () => dto.LocationName, 65, (__builder3) => {
                    __builder3.AddMarkupContent(66, "\r\n");
#nullable restore
#line 45 "D:\dev\Github\ISCarnet\ISCarnet\IS_CARNET\Pages\AddExam.razor"
                             foreach (LocationDTO l in locations)
                                {

#line default
#line hidden
#nullable disable
                    __builder3.AddContent(67, "                                ");
                    __builder3.OpenElement(68, "option");
                    __builder3.AddAttribute(69, "value", 
#nullable restore
#line 47 "D:\dev\Github\ISCarnet\ISCarnet\IS_CARNET\Pages\AddExam.razor"
                                               l.LocationName

#line default
#line hidden
#nullable disable
                    );
                    __builder3.AddContent(70, 
#nullable restore
#line 47 "D:\dev\Github\ISCarnet\ISCarnet\IS_CARNET\Pages\AddExam.razor"
                                                               l.LocationName

#line default
#line hidden
#nullable disable
                    );
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(71, "\r\n");
#nullable restore
#line 48 "D:\dev\Github\ISCarnet\ISCarnet\IS_CARNET\Pages\AddExam.razor"
                                }

#line default
#line hidden
#nullable disable
                    __builder3.AddMarkupContent(72, "                            /**/\r\n                            /**/\r\n                            /**/\r\n                            /**/\r\n                            /**/\r\n                            /**/\r\n\r\n\r\n                        ");
                }
                );
                __builder2.AddMarkupContent(73, "\r\n                    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(74, "\r\n                    ");
                __builder2.AddMarkupContent(75, "<button type=\"submit\">ADD EXAM</button>\r\n\r\n\r\n                ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(76, "\r\n                ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(77, "\r\n    ");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(78, "\r\n");
#nullable restore
#line 65 "D:\dev\Github\ISCarnet\ISCarnet\IS_CARNET\Pages\AddExam.razor"
}
else
{
    showError("Trebuie sa fii logat ca administrator pentru a accesa aceasta pagina!");
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 71 "D:\dev\Github\ISCarnet\ISCarnet\IS_CARNET\Pages\AddExam.razor"
       

    async Task showError(string error)
    {
        await JSRuntime.InvokeVoidAsync("createError", error);
        NavigationManager.NavigateTo("/");
    }

    private CreateExam dto = new CreateExam();
    private List<ExaminatorDTO> examinas = new List<ExaminatorDTO>();
    private List<LocationDTO> locations = new List<LocationDTO>();

    string message = string.Empty;

     async Task ShowAlert(string error)
    {
        if (error == "A aparut o eroare la adaugarea examenului")
        {

            await JSRuntime.InvokeVoidAsync("createError", error);
        }
        else
        {
            await JSRuntime.InvokeVoidAsync("createSuccess", error);
        }
    }

    // AICI TREBUIE MODIFICAT LINKUL DE API SI CREAT APIUL CARE RETURNEAZA LISTA CU EXAMINATORI
    HttpClient Http = new HttpClient();
    private string apiUrl = "https://localhost:44369/api/Examinators";
    private string locationsApiUrl = "https://localhost:44363/api/Location";
    protected override async Task OnInitializedAsync()
    {
        dto.ExamDate = DateTime.Today;
        examinas = await Http.GetJsonAsync<List<ExaminatorDTO>>
        (apiUrl);
        locations = await Http.GetJsonAsync<List<LocationDTO>>(locationsApiUrl);
    }

    // FUNCTIA DE SUBMIT
    private async Task SubmitExam()
    {

        HttpContent content = new StringContent(JsonConvert.SerializeObject(dto), Encoding.UTF8, "application/json");
        HttpResponseMessage h = await Http.PostAsync("https://localhost:44316/api/pastExam", content);
        var responseJSON = h.Content.ReadAsStringAsync().Result;
        Exam exam = JsonConvert.DeserializeObject<Exam>(responseJSON);
        if (h.IsSuccessStatusCode)
        {
            message = "Examenul a fost adaugat cu succes";
        }
        else
        {
            message = "A aparut o eroare la adaugarea examenului";
        }
        await ShowAlert(message);

    }


#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavigationManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IJSRuntime JSRuntime { get; set; }
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
        public static void CreateInputSelect_2<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, System.Object __arg0, int __seq1, System.Object __arg1, int __seq2, TValue __arg2, int __seq3, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg3, int __seq4, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg4, int __seq5, global::Microsoft.AspNetCore.Components.RenderFragment __arg5)
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
