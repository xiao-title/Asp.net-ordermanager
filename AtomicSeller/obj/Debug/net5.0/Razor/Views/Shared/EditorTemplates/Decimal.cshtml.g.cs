#pragma checksum "D:\Projects\AtomicSeller\Tech\Apps\_OrderManager\Dev\AtomicSeller\Views\Shared\EditorTemplates\Decimal.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d7dc0d086e7dbe964529c98133841c9364c4271c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_EditorTemplates_Decimal), @"mvc.1.0.view", @"/Views/Shared/EditorTemplates/Decimal.cshtml")]
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
#line 1 "D:\Projects\AtomicSeller\Tech\Apps\_OrderManager\Dev\AtomicSeller\Views\_ViewImports.cshtml"
using AtomicSeller;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Projects\AtomicSeller\Tech\Apps\_OrderManager\Dev\AtomicSeller\Views\_ViewImports.cshtml"
using AtomicSeller.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "D:\Projects\AtomicSeller\Tech\Apps\_OrderManager\Dev\AtomicSeller\Views\Shared\EditorTemplates\Decimal.cshtml"
using System.Globalization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Projects\AtomicSeller\Tech\Apps\_OrderManager\Dev\AtomicSeller\Views\Shared\EditorTemplates\Decimal.cshtml"
using Microsoft.AspNetCore.Routing;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d7dc0d086e7dbe964529c98133841c9364c4271c", @"/Views/Shared/EditorTemplates/Decimal.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d1a0039f6a8aa9b448d53da5bc34a03f444a947e", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_EditorTemplates_Decimal : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<decimal?>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 5 "D:\Projects\AtomicSeller\Tech\Apps\_OrderManager\Dev\AtomicSeller\Views\Shared\EditorTemplates\Decimal.cshtml"
  
    ViewBag.htmlAttributes = (RouteValueDictionary)ViewBag.htmlAttributes ?? new RouteValueDictionary();
    ViewBag.htmlAttributes["data-autonumeric"] = "true";

    // AutoNumeric needs dd.dd instead of dd,dd
    var numberFormatInfo = new NumberFormatInfo { NumberDecimalSeparator = "." };
    ViewBag.value = Model.HasValue ? String.Format(numberFormatInfo, "{0:0.00}", Model.Value) : "";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 14 "D:\Projects\AtomicSeller\Tech\Apps\_OrderManager\Dev\AtomicSeller\Views\Shared\EditorTemplates\Decimal.cshtml"
Write(Html.Partial("~/Views/Shared/EditorTemplates/TextBoxBase.cshtml"));

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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<decimal?> Html { get; private set; }
    }
}
#pragma warning restore 1591
