#pragma checksum "E:\2020\client_project_from_0407\france\atomic\project\ordermanager\ordermanaager\AtomicSeller\Views\Shared\DisplayTemplates\Decimal.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "cf9e6658975919dfd2a444e42a67eaecfc1ae421"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_DisplayTemplates_Decimal), @"mvc.1.0.view", @"/Views/Shared/DisplayTemplates/Decimal.cshtml")]
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
#line 1 "E:\2020\client_project_from_0407\france\atomic\project\ordermanager\ordermanaager\AtomicSeller\Views\_ViewImports.cshtml"
using AtomicSeller;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "E:\2020\client_project_from_0407\france\atomic\project\ordermanager\ordermanaager\AtomicSeller\Views\_ViewImports.cshtml"
using AtomicSeller.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "E:\2020\client_project_from_0407\france\atomic\project\ordermanager\ordermanaager\AtomicSeller\Views\Shared\DisplayTemplates\Decimal.cshtml"
using AtomicSeller.Helpers.Razor;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"cf9e6658975919dfd2a444e42a67eaecfc1ae421", @"/Views/Shared/DisplayTemplates/Decimal.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d1a0039f6a8aa9b448d53da5bc34a03f444a947e", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_DisplayTemplates_Decimal : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<object>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 4 "E:\2020\client_project_from_0407\france\atomic\project\ordermanager\ordermanaager\AtomicSeller\Views\Shared\DisplayTemplates\Decimal.cshtml"
  
    var format = ViewBag.format != null ? (string) ViewBag.format : TemplatesConsts.DecimalFormat;

    ViewBag.value = string.Format(format, Model);
    ViewBag.valueClass = "text-number";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 11 "E:\2020\client_project_from_0407\france\atomic\project\ordermanager\ordermanaager\AtomicSeller\Views\Shared\DisplayTemplates\Decimal.cshtml"
Write(Html.Partial( "~/Views/Shared/DisplayTemplates/DisplayBase.cshtml"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<object> Html { get; private set; }
    }
}
#pragma warning restore 1591
