#pragma checksum "C:\Users\X\Documents\SDSU\unidad 2\107\PropertyRental\Views\Catalog\index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b893d8881f99885b5f76b11ef473ea59e2af775a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Catalog_index), @"mvc.1.0.view", @"/Views/Catalog/index.cshtml")]
namespace AspNetCore
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
#line 1 "C:\Users\X\Documents\SDSU\unidad 2\107\PropertyRental\Views\_ViewImports.cshtml"
using PropertyRental;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\X\Documents\SDSU\unidad 2\107\PropertyRental\Views\_ViewImports.cshtml"
using PropertyRental.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b893d8881f99885b5f76b11ef473ea59e2af775a", @"/Views/Catalog/index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a59eb52cf4fd9ebb4436dd5a1fef24adf2457ae8", @"/Views/_ViewImports.cshtml")]
    public class Views_Catalog_index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"<h1>Our amazing</h1>

<div id=""catalog-container"">
            <!--table id=""regTable"" class=""table table-hover table-dark"">
                <thead id=""theader"">
                    <th>ID</th>
                    <th>Title</th>
                    <th>ImageUrl</th>
                    <th></th>
                </thead>
                <tbody id=""tbody""></tbody>
            </table-->

</div>

");
            DefineSection("Styles", async() => {
                WriteLiteral("\r\n    <link href=\"/css/catalog.css\" rel=\"stylesheet\">\r\n");
            }
            );
            WriteLiteral("\r\n");
            DefineSection("Scripts", async() => {
                WriteLiteral("\r\n    <script src=\"/js/catalog.js\"></script>\r\n");
            }
            );
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
