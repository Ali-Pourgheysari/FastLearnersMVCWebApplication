#pragma checksum "D:\Visual Studio\FastLearnersMVCWebApplication\FastLearnersMVCWebApplication\Views\Content\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e2ef4e43584faf155e9480f72d73ffe53013ec9c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Content_Index), @"mvc.1.0.view", @"/Views/Content/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e2ef4e43584faf155e9480f72d73ffe53013ec9c", @"/Views/Content/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ac6efd2b4ab5d4c0b7b7f781920f12af98d74d6d", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Content_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<FastLearnersMVCWebApplication.Entities.Content>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<h2>");
#nullable restore
#line 3 "D:\Visual Studio\FastLearnersMVCWebApplication\FastLearnersMVCWebApplication\Views\Content\Index.cshtml"
Write(Model.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2>\r\n\r\n");
#nullable restore
#line 5 "D:\Visual Studio\FastLearnersMVCWebApplication\FastLearnersMVCWebApplication\Views\Content\Index.cshtml"
 if (Model.HTMLContent != null)
{ 

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"row\">\r\n        <div id=\"TextContent\" class=\"mt-3 col-md-10\"> \r\n            ");
#nullable restore
#line 9 "D:\Visual Studio\FastLearnersMVCWebApplication\FastLearnersMVCWebApplication\Views\Content\Index.cshtml"
       Write(Html.Raw(Model.HTMLContent));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </div>\r\n    </div>\r\n");
#nullable restore
#line 12 "D:\Visual Studio\FastLearnersMVCWebApplication\FastLearnersMVCWebApplication\Views\Content\Index.cshtml"
}

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "D:\Visual Studio\FastLearnersMVCWebApplication\FastLearnersMVCWebApplication\Views\Content\Index.cshtml"
 if (Model.VideoLink != null)
{ 

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"row\">\r\n        <div class=\"mt-3 col-md-10\">\r\n            <div id=\"VideoContent\" class=\"video-container mt-3\">\r\n                <iframe width=\"550\" height=\"350\"");
            BeginWriteAttribute("src", " src=\"", 481, "\"", 503, 1);
#nullable restore
#line 18 "D:\Visual Studio\FastLearnersMVCWebApplication\FastLearnersMVCWebApplication\Views\Content\Index.cshtml"
WriteAttributeValue("", 487, Model.VideoLink, 487, 16, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("allowfullscreen", " allowfullscreen=\"", 504, "\"", 522, 0);
            EndWriteAttribute();
            WriteLiteral(" frameborder=\"0\">\r\n\r\n                </iframe>\r\n            </div>\r\n        </div>\r\n    </div>\r\n");
#nullable restore
#line 24 "D:\Visual Studio\FastLearnersMVCWebApplication\FastLearnersMVCWebApplication\Views\Content\Index.cshtml"
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<FastLearnersMVCWebApplication.Entities.Content> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
