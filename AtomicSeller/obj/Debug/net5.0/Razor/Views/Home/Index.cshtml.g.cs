#pragma checksum "D:\Projects\AtomicSeller\Tech\Apps\_OrderManager\Dev\AtomicSeller\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "df9ba0e2ff42398f072f473c62dfd8640f6cfed5"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
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
#line 1 "D:\Projects\AtomicSeller\Tech\Apps\_OrderManager\Dev\AtomicSeller\Views\Home\Index.cshtml"
using AtomicSeller.Helpers;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Projects\AtomicSeller\Tech\Apps\_OrderManager\Dev\AtomicSeller\Views\Home\Index.cshtml"
using AtomicSeller.Helpers.Razor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\Projects\AtomicSeller\Tech\Apps\_OrderManager\Dev\AtomicSeller\Views\Home\Index.cshtml"
using AtomicSeller.Helpers.Razor.HtmlExtensions;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\Projects\AtomicSeller\Tech\Apps\_OrderManager\Dev\AtomicSeller\Views\Home\Index.cshtml"
using System.Globalization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "D:\Projects\AtomicSeller\Tech\Apps\_OrderManager\Dev\AtomicSeller\Views\Home\Index.cshtml"
using System.Threading;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"df9ba0e2ff42398f072f473c62dfd8640f6cfed5", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d1a0039f6a8aa9b448d53da5bc34a03f444a947e", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 7 "D:\Projects\AtomicSeller\Tech\Apps\_OrderManager\Dev\AtomicSeller\Views\Home\Index.cshtml"
  
    ViewBag.Title = new Local().TranslatedMessage("MITFAFquickProcessToolStripMenuItem");

    ViewBag.ShowH2 = false;
    ViewBag.PageCol = HtmlConsts.Dimens.DefaultPageCol;
    ViewBag.PageColOffset = HtmlConsts.Dimens.DefaultPageColOffset;

    //CultureInfo Culture;
    //Culture = Thread.CurrentThread.CurrentUICulture;
    //string CultureCode = Culture.Name;

    string SiteName = "AtomicSeller";


#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<!-- Html.AntiForgeryToken() -->\r\n\r\n<div class=\"row\">\r\n    <div class=\"col-md-8 col-md-offset-2\">\r\n");
#nullable restore
#line 26 "D:\Projects\AtomicSeller\Tech\Apps\_OrderManager\Dev\AtomicSeller\Views\Home\Index.cshtml"
         using (Html.PanelWrap(@SiteName))
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <div class=\"panel-body\">\r\n                <p>");
#nullable restore
#line 29 "D:\Projects\AtomicSeller\Tech\Apps\_OrderManager\Dev\AtomicSeller\Views\Home\Index.cshtml"
                     new Local().TranslatedMessage("MITFAFWELCOME"); 

#line default
#line hidden
#nullable disable
            WriteLiteral(" V2.12 </p>\r\n            </div>\r\n");
#nullable restore
#line 31 "D:\Projects\AtomicSeller\Tech\Apps\_OrderManager\Dev\AtomicSeller\Views\Home\Index.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </div>\r\n</div>");
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
