#pragma checksum "C:\MinTic2022_HardWork\Salones.App\Salones.App.Frontend\Pages\db\Listas.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "979e69075efb34fa00dbede3d2a974cd462600ad"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(Salones.App.Frontend.Pages.db.Pages_db_Listas), @"mvc.1.0.razor-page", @"/Pages/db/Listas.cshtml")]
namespace Salones.App.Frontend.Pages.db
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"979e69075efb34fa00dbede3d2a974cd462600ad", @"/Pages/db/Listas.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"bbf0b0894639858e763f897c16bdaabffcdd0f43", @"/Pages/_ViewImports.cshtml")]
    public class Pages_db_Listas : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "C:\MinTic2022_HardWork\Salones.App\Salones.App.Frontend\Pages\db\Listas.cshtml"
  
    ViewData["Title"] = "Listas";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<h2>Consultar Listados</h2>

<!--*** Temporalmente lo pongo acá: <a asp-page=""/Personas/AddPersona"">Agregar Personas</a>-->

<h4>Personas</h4>
<ul>
    <li><a href=""/Personas/ListProfe"">Profesores</a><!-- - <a href=""DB/ModiProfe"">Modificar</a>--></li>
    <li><a href=""/Personas/ListEstud"">Estudiantes</a> <!-- - <a href=""DB/ModiEstud"">Modificar</a>--></li>
    <li><a href=""/Personas/ListDirect"">Directivo</a> <!-- - <a href=""DB/ModiDirect"">Modificar</a>--></li>
    <li><a href=""/Personas/ListAseo"">Personal de Aseo</a> <!-- - <a href=""DB/ModiAseo"">Modificar</a>--></li>
</ul>
<h4>Universidad</h4>
<ul>
    <li><a href=""/Universidad/ListSede"">Sedes</a> <!-- - <a href=""DB/ModiSede"">Modificar</a>--></li>
    <li> <a href=""/Universidad/ListSalon"">Salones</a> <!-- - <a href=""DB/ModiSalon"">Modificar</a>--></li>
</ul>

");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Salones.App.Frontend.Pages.ListasModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<Salones.App.Frontend.Pages.ListasModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<Salones.App.Frontend.Pages.ListasModel>)PageContext?.ViewData;
        public Salones.App.Frontend.Pages.ListasModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
