#pragma checksum "C:\MinTic2022_HardWork\Salones.App\Salones.App.Frontend\Pages\Personas\EliminarDirect.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "823c7b38b8bf74df21804022a7cf4e851b9aff0b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(Salones.App.Frontend.Pages.Personas.Pages_Personas_EliminarDirect), @"mvc.1.0.razor-page", @"/Pages/Personas/EliminarDirect.cshtml")]
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
#line 1 "C:\MinTic2022_HardWork\Salones.App\Salones.App.Frontend\Pages\_ViewImports.cshtml"
using Salones.App.Frontend;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"823c7b38b8bf74df21804022a7cf4e851b9aff0b", @"/Pages/Personas/EliminarDirect.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"bbf0b0894639858e763f897c16bdaabffcdd0f43", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Personas_EliminarDirect : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", "hidden", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-primary table-tbn"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "/Personas/ListDirect", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"<h1>Se va a eliminar el Directivo</h1>
<table class=""table"">
    <thead>
        <tr>
            <th scope=""col"">Nombres</th>
            <th scope=""col"">Apellidos</th>
            <th scope=""col"">Tipo identificacion</th>
            <th scope=""col"">Numero de documento</th>
            <th scope=""col"">Edad</th>
            <th scope=""col"">Unidad</th>
            <th scope=""col"">Sintomas</th>
            <th scope=""col"">Tipo de Sintomas</th>
            <th scope=""col"">Estado Covid</th>
            <th scope=""col"">Fecha Diagnostico</th>
            <th scope=""col"">Periodo Aislamiento </th>
        </tr>
     </thead>
    <tbody>
        <tr>
            <td> ");
#nullable restore
#line 24 "C:\MinTic2022_HardWork\Salones.App\Salones.App.Frontend\Pages\Personas\EliminarDirect.cshtml"
            Write(Model.directivo.nombres);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </td>\r\n            <td> ");
#nullable restore
#line 25 "C:\MinTic2022_HardWork\Salones.App\Salones.App.Frontend\Pages\Personas\EliminarDirect.cshtml"
            Write(Model.directivo.apellidos);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </td>\r\n            <td> ");
#nullable restore
#line 26 "C:\MinTic2022_HardWork\Salones.App\Salones.App.Frontend\Pages\Personas\EliminarDirect.cshtml"
            Write(Model.directivo.tipoIdentificacion);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </td>\r\n            <td> ");
#nullable restore
#line 27 "C:\MinTic2022_HardWork\Salones.App\Salones.App.Frontend\Pages\Personas\EliminarDirect.cshtml"
            Write(Model.directivo.identificacion);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </td>\r\n            <td> ");
#nullable restore
#line 28 "C:\MinTic2022_HardWork\Salones.App\Salones.App.Frontend\Pages\Personas\EliminarDirect.cshtml"
            Write(Model.directivo.edad);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </td>\r\n            <td> ");
#nullable restore
#line 29 "C:\MinTic2022_HardWork\Salones.App\Salones.App.Frontend\Pages\Personas\EliminarDirect.cshtml"
            Write(Model.directivo.unidad);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </td>\r\n            <td> ");
#nullable restore
#line 30 "C:\MinTic2022_HardWork\Salones.App\Salones.App.Frontend\Pages\Personas\EliminarDirect.cshtml"
            Write(Model.directivo.estadoCovid.sintomas);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td> ");
#nullable restore
#line 31 "C:\MinTic2022_HardWork\Salones.App\Salones.App.Frontend\Pages\Personas\EliminarDirect.cshtml"
            Write(Model.directivo.estadoCovid.tipoSintomas);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td> ");
#nullable restore
#line 32 "C:\MinTic2022_HardWork\Salones.App\Salones.App.Frontend\Pages\Personas\EliminarDirect.cshtml"
            Write(Model.directivo.estadoCovid.estadoCovid);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td> ");
#nullable restore
#line 33 "C:\MinTic2022_HardWork\Salones.App\Salones.App.Frontend\Pages\Personas\EliminarDirect.cshtml"
            Write(Model.directivo.estadoCovid.fechaDiagnostico);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td> ");
#nullable restore
#line 34 "C:\MinTic2022_HardWork\Salones.App\Salones.App.Frontend\Pages\Personas\EliminarDirect.cshtml"
            Write(Model.directivo.estadoCovid.periodoAislamiento);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            \r\n        </tr>\r\n       </tbody>\r\n</table>\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "823c7b38b8bf74df21804022a7cf4e851b9aff0b8583", async() => {
                WriteLiteral("\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "823c7b38b8bf74df21804022a7cf4e851b9aff0b8845", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
#nullable restore
#line 40 "C:\MinTic2022_HardWork\Salones.App\Salones.App.Frontend\Pages\Personas\EliminarDirect.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.directivo.id);

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n    <div class=\"form-group\">\r\n        <button type=\"submit\" class=\"btn btn-primary\">Confirmar Eliminar</button>\r\n        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "823c7b38b8bf74df21804022a7cf4e851b9aff0b10697", async() => {
                    WriteLiteral(" Volver ");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_2.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n    </div>\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Salones.App.Frontend.Pages.EliminarDirectModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<Salones.App.Frontend.Pages.EliminarDirectModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<Salones.App.Frontend.Pages.EliminarDirectModel>)PageContext?.ViewData;
        public Salones.App.Frontend.Pages.EliminarDirectModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
