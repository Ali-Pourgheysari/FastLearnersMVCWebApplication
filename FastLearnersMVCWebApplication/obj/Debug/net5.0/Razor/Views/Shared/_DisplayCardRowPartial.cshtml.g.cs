#pragma checksum "D:\Visual Studio\FastLearnersMVCWebApplication\FastLearnersMVCWebApplication\Views\Shared\_DisplayCardRowPartial.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "311330011c7d3b24b2599a173e178408b7d23c60"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__DisplayCardRowPartial), @"mvc.1.0.view", @"/Views/Shared/_DisplayCardRowPartial.cshtml")]
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
#line 1 "D:\Visual Studio\FastLearnersMVCWebApplication\FastLearnersMVCWebApplication\Views\_ViewImports.cshtml"
using FastLearnersMVCWebApplication;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Visual Studio\FastLearnersMVCWebApplication\FastLearnersMVCWebApplication\Views\_ViewImports.cshtml"
using FastLearnersMVCWebApplication.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "D:\Visual Studio\FastLearnersMVCWebApplication\FastLearnersMVCWebApplication\Views\Shared\_DisplayCardRowPartial.cshtml"
using FastLearnersMVCWebApplication.Entities;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"311330011c7d3b24b2599a173e178408b7d23c60", @"/Views/Shared/_DisplayCardRowPartial.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ac6efd2b4ab5d4c0b7b7f781920f12af98d74d6d", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Shared__DisplayCardRowPartial : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Category>>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 4 "D:\Visual Studio\FastLearnersMVCWebApplication\FastLearnersMVCWebApplication\Views\Shared\_DisplayCardRowPartial.cshtml"
 if (Model.Count() > 0)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"row mt-3\">\r\n");
#nullable restore
#line 7 "D:\Visual Studio\FastLearnersMVCWebApplication\FastLearnersMVCWebApplication\Views\Shared\_DisplayCardRowPartial.cshtml"
         foreach (Category item in Model)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <div class=\"col-md-3 mt-3\">\r\n                <a href=\"#\" class=\"RegisterLink text-dark\" data-categoryId=\"");
#nullable restore
#line 10 "D:\Visual Studio\FastLearnersMVCWebApplication\FastLearnersMVCWebApplication\Views\Shared\_DisplayCardRowPartial.cshtml"
                                                                       Write(item.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("\">\r\n                    <div class=\"card\">\r\n                        <img class=\"img-thumbnail\"");
            BeginWriteAttribute("src", " src=\"", 408, "\"", 438, 1);
#nullable restore
#line 12 "D:\Visual Studio\FastLearnersMVCWebApplication\FastLearnersMVCWebApplication\Views\Shared\_DisplayCardRowPartial.cshtml"
WriteAttributeValue("", 414, item.ThumbnailImagePath, 414, 24, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("alt", " alt=\"", 439, "\"", 456, 1);
#nullable restore
#line 12 "D:\Visual Studio\FastLearnersMVCWebApplication\FastLearnersMVCWebApplication\Views\Shared\_DisplayCardRowPartial.cshtml"
WriteAttributeValue("", 445, item.Title, 445, 11, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                        <div class=\"card-body\">\r\n                            <h5 class=\"card-title\">");
#nullable restore
#line 14 "D:\Visual Studio\FastLearnersMVCWebApplication\FastLearnersMVCWebApplication\Views\Shared\_DisplayCardRowPartial.cshtml"
                                              Write(item.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\r\n                            <p class=\"card-text\">");
#nullable restore
#line 15 "D:\Visual Studio\FastLearnersMVCWebApplication\FastLearnersMVCWebApplication\Views\Shared\_DisplayCardRowPartial.cshtml"
                                            Write(item.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                        </div>\r\n                    </div>\r\n                </a>\r\n            </div>\r\n");
#nullable restore
#line 20 "D:\Visual Studio\FastLearnersMVCWebApplication\FastLearnersMVCWebApplication\Views\Shared\_DisplayCardRowPartial.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </div>\r\n");
#nullable restore
#line 22 "D:\Visual Studio\FastLearnersMVCWebApplication\FastLearnersMVCWebApplication\Views\Shared\_DisplayCardRowPartial.cshtml"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Category>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
