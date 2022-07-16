#pragma checksum "D:\Visual Studio\FastLearnersMVCWebApplication\FastLearnersMVCWebApplication\Areas\Admin\Views\Shared\_UsersListViewPartial.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "522399f09d43c86a6d67cb003f321cf9ff3b8e5b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_Shared__UsersListViewPartial), @"mvc.1.0.view", @"/Areas/Admin/Views/Shared/_UsersListViewPartial.cshtml")]
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
#line 1 "D:\Visual Studio\FastLearnersMVCWebApplication\FastLearnersMVCWebApplication\Areas\Admin\Views\_ViewImports.cshtml"
using FastLearnersMVCWebApplication;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Visual Studio\FastLearnersMVCWebApplication\FastLearnersMVCWebApplication\Areas\Admin\Views\_ViewImports.cshtml"
using FastLearnersMVCWebApplication.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Visual Studio\FastLearnersMVCWebApplication\FastLearnersMVCWebApplication\Areas\Admin\Views\Shared\_UsersListViewPartial.cshtml"
using FastLearnersMVCWebApplication.Comparers;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"522399f09d43c86a6d67cb003f321cf9ff3b8e5b", @"/Areas/Admin/Views/Shared/_UsersListViewPartial.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ac6efd2b4ab5d4c0b7b7f781920f12af98d74d6d", @"/Areas/Admin/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Areas_Admin_Views_Shared__UsersListViewPartial : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<FastLearnersMVCWebApplication.Areas.Admin.Models.UsersCategoryListModel>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<table class=\"table table-hover\">\r\n    <thead>\r\n        <tr>\r\n            <th></th>\r\n            <th>First Name</th>\r\n            <th>Last Name</th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
#nullable restore
#line 13 "D:\Visual Studio\FastLearnersMVCWebApplication\FastLearnersMVCWebApplication\Areas\Admin\Views\Shared\_UsersListViewPartial.cshtml"
         if(Model.Users != null)
        {
            

#line default
#line hidden
#nullable disable
#nullable restore
#line 15 "D:\Visual Studio\FastLearnersMVCWebApplication\FastLearnersMVCWebApplication\Areas\Admin\Views\Shared\_UsersListViewPartial.cshtml"
             foreach(var user in Model.Users)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\r\n                <td style=\"text-align:center\">\r\n");
#nullable restore
#line 19 "D:\Visual Studio\FastLearnersMVCWebApplication\FastLearnersMVCWebApplication\Areas\Admin\Views\Shared\_UsersListViewPartial.cshtml"
                     if (Model.UsersSelected != null && Model.UsersSelected.Contains(user, new CompareUsers()))
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <input type=\"checkbox\" id=\"UsersSelected\" class=\"form-check-input\" name=\"UsersSelected\" checked");
            BeginWriteAttribute("value", " value=\"", 750, "\"", 766, 1);
#nullable restore
#line 21 "D:\Visual Studio\FastLearnersMVCWebApplication\FastLearnersMVCWebApplication\Areas\Admin\Views\Shared\_UsersListViewPartial.cshtml"
WriteAttributeValue("", 758, user.Id, 758, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\r\n");
#nullable restore
#line 22 "D:\Visual Studio\FastLearnersMVCWebApplication\FastLearnersMVCWebApplication\Areas\Admin\Views\Shared\_UsersListViewPartial.cshtml"
                    }
                    else
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <input type=\"checkbox\" id=\"UsersSelected\" class=\"form-check-input\" name=\"UsersSelected\"");
            BeginWriteAttribute("value", " value=\"", 955, "\"", 971, 1);
#nullable restore
#line 25 "D:\Visual Studio\FastLearnersMVCWebApplication\FastLearnersMVCWebApplication\Areas\Admin\Views\Shared\_UsersListViewPartial.cshtml"
WriteAttributeValue("", 963, user.Id, 963, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\r\n");
#nullable restore
#line 26 "D:\Visual Studio\FastLearnersMVCWebApplication\FastLearnersMVCWebApplication\Areas\Admin\Views\Shared\_UsersListViewPartial.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                </td>\r\n                <td>");
#nullable restore
#line 28 "D:\Visual Studio\FastLearnersMVCWebApplication\FastLearnersMVCWebApplication\Areas\Admin\Views\Shared\_UsersListViewPartial.cshtml"
               Write(user.FirstName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 29 "D:\Visual Studio\FastLearnersMVCWebApplication\FastLearnersMVCWebApplication\Areas\Admin\Views\Shared\_UsersListViewPartial.cshtml"
               Write(user.LastName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            </tr>\r\n");
#nullable restore
#line 31 "D:\Visual Studio\FastLearnersMVCWebApplication\FastLearnersMVCWebApplication\Areas\Admin\Views\Shared\_UsersListViewPartial.cshtml"
            }

#line default
#line hidden
#nullable disable
#nullable restore
#line 31 "D:\Visual Studio\FastLearnersMVCWebApplication\FastLearnersMVCWebApplication\Areas\Admin\Views\Shared\_UsersListViewPartial.cshtml"
             
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\r\n</table>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<FastLearnersMVCWebApplication.Areas.Admin.Models.UsersCategoryListModel> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
