#pragma checksum "C:\Users\Claudiu\Documents\GitHub\ISCarnet\ISCarnet\Client\Client\Pages\FetchData.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f524af76aeb2e6a3dd380a28b6f74621b57dfedd"
// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace Client.Client.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\Claudiu\Documents\GitHub\ISCarnet\ISCarnet\Client\Client\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Claudiu\Documents\GitHub\ISCarnet\ISCarnet\Client\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Claudiu\Documents\GitHub\ISCarnet\ISCarnet\Client\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Claudiu\Documents\GitHub\ISCarnet\ISCarnet\Client\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Claudiu\Documents\GitHub\ISCarnet\ISCarnet\Client\Client\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Claudiu\Documents\GitHub\ISCarnet\ISCarnet\Client\Client\Pages\FetchData.razor"
using Client.Shared;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/fetchdata")]
    public partial class FetchData : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 38 "C:\Users\Claudiu\Documents\GitHub\ISCarnet\ISCarnet\Client\Client\Pages\FetchData.razor"
       
    private ExamDTO dto = new ExamDTO();
    private List<ExaminatorDTO> examinas = new List<ExaminatorDTO>();


    // AICI TREBUIE MODIFICAT LINKUL DE API SI CREAT APIUL CARE RETURNEAZA LISTA CU EXAMINATORI
    private string apiUrl = "https://localhost:44369/api/Examinators";
    protected override async Task OnInitializedAsync()
    {
        dto.ExamDate = DateTime.Today;
        examinas = await Http.GetJsonAsync<List<ExaminatorDTO>>(apiUrl);
    }


#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private HttpClient Http { get; set; }
    }
}
#pragma warning restore 1591
