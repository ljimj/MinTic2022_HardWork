#pragma checksum "C:\MinTic2022_HardWork\salones.app\salones.app.frontend\Pages\Personas\DetallesEstud.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a929f56b4d38831c6b8365d26a76f08ba691172e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(Salones.App.Frontend.Pages.Personas.Pages_Personas_DetallesEstud), @"mvc.1.0.razor-page", @"/Pages/Personas/DetallesEstud.cshtml")]
namespace Salones.App.Frontend.Pages.Personas
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "C:\MinTic2022_HardWork\salones.app\salones.app.frontend\Pages\_ViewImports.cshtml"
using Salones.App.Frontend;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a929f56b4d38831c6b8365d26a76f08ba691172e", @"/Pages/Personas/DetallesEstud.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"bbf0b0894639858e763f897c16bdaabffcdd0f43", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Personas_DetallesEstud : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("nav-link"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-area", "", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "/Personas/ListEstud", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "C:\MinTic2022_HardWork\salones.app\salones.app.frontend\Pages\Personas\DetallesEstud.cshtml"
  
    ViewData["Title"] = "Listas";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<h1>Detalles Estudiante</h1>

<table class=""table table-striped"">
    <thead>
        <tr>
            <th scope=""col"">Nombres</th>
            <th scope=""col"">Apellidos</th>
            <th scope=""col"">Tipo identificacion</th>
            <th scope=""col"">Numero de documento</th>
            <th scope=""col"">Edad</th>
            <th scope=""col"">Estado COVID</th>
            <th scope=""col"">Cerrera</th>
            <th scope=""col"">Semestre</th>
            <th scope=""col"">Facultad</th>
            <th scope=""col"">Sintomas</th>
            <th scope=""col"">Estado Covid</th>
            <th scope=""col"">Fecha Diagnostico</th>
            <th scope=""col"">Periodo Aislamiento </th>
        </tr>
     </thead>
    <tbody>
        <tr>
            <td> ");
#nullable restore
#line 28 "C:\MinTic2022_HardWork\salones.app\salones.app.frontend\Pages\Personas\DetallesEstud.cshtml"
            Write(Model.estudiante.nombres);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </td>\r\n            <td> ");
#nullable restore
#line 29 "C:\MinTic2022_HardWork\salones.app\salones.app.frontend\Pages\Personas\DetallesEstud.cshtml"
            Write(Model.estudiante.apellidos);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </td>\r\n            <td> ");
#nullable restore
#line 30 "C:\MinTic2022_HardWork\salones.app\salones.app.frontend\Pages\Personas\DetallesEstud.cshtml"
            Write(Model.estudiante.tipoIdentificacion);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </td>\r\n            <td> ");
#nullable restore
#line 31 "C:\MinTic2022_HardWork\salones.app\salones.app.frontend\Pages\Personas\DetallesEstud.cshtml"
            Write(Model.estudiante.identificacion);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </td>\r\n            <td> ");
#nullable restore
#line 32 "C:\MinTic2022_HardWork\salones.app\salones.app.frontend\Pages\Personas\DetallesEstud.cshtml"
            Write(Model.estudiante.edad);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </td>\r\n            <td> ");
#nullable restore
#line 33 "C:\MinTic2022_HardWork\salones.app\salones.app.frontend\Pages\Personas\DetallesEstud.cshtml"
            Write(Model.estudiante.estadoCovid);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </td>\r\n            <td> ");
#nullable restore
#line 34 "C:\MinTic2022_HardWork\salones.app\salones.app.frontend\Pages\Personas\DetallesEstud.cshtml"
            Write(Model.estudiante.carrera);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </td>\r\n            <td> ");
#nullable restore
#line 35 "C:\MinTic2022_HardWork\salones.app\salones.app.frontend\Pages\Personas\DetallesEstud.cshtml"
            Write(Model.estudiante.semestre);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </td>\r\n            <td> ");
#nullable restore
#line 36 "C:\MinTic2022_HardWork\salones.app\salones.app.frontend\Pages\Personas\DetallesEstud.cshtml"
            Write(Model.estudiante.facultad);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </td>\r\n            <td> </td>\r\n            <td> </td>\r\n            <td> </td>\r\n            <td> </td>\r\n            \r\n        </tr>\r\n       </tbody>\r\n</table>\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a929f56b4d38831c6b8365d26a76f08ba691172e7627", async() => {
                WriteLiteral("Volver");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Area = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Salones.App.Frontend.Pages.DetallesEstudModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<Salones.App.Frontend.Pages.DetallesEstudModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<Salones.App.Frontend.Pages.DetallesEstudModel>)PageContext?.ViewData;
        public Salones.App.Frontend.Pages.DetallesEstudModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
