#pragma checksum "D:\Projects\AtomicSeller\Tech\Apps\_OrderManager\Dev\AtomicSeller\Views\Shared\EditorTemplates\HttpPostedFileBase.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "018ba6a1bb558c55ffb35176184ce43f61474257"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_EditorTemplates_HttpPostedFileBase), @"mvc.1.0.view", @"/Views/Shared/EditorTemplates/HttpPostedFileBase.cshtml")]
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
#line 1 "D:\Projects\AtomicSeller\Tech\Apps\_OrderManager\Dev\AtomicSeller\Views\Shared\EditorTemplates\HttpPostedFileBase.cshtml"
using AtomicSeller.Helpers.Razor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Projects\AtomicSeller\Tech\Apps\_OrderManager\Dev\AtomicSeller\Views\Shared\EditorTemplates\HttpPostedFileBase.cshtml"
using AtomicSeller.Helpers.Razor.HtmlExtensions;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"018ba6a1bb558c55ffb35176184ce43f61474257", @"/Views/Shared/EditorTemplates/HttpPostedFileBase.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d1a0039f6a8aa9b448d53da5bc34a03f444a947e", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_EditorTemplates_HttpPostedFileBase : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 4 "D:\Projects\AtomicSeller\Tech\Apps\_OrderManager\Dev\AtomicSeller\Views\Shared\EditorTemplates\HttpPostedFileBase.cshtml"
  
    var showLabel = ViewBag.noLabel == null;
    var controlsClasses = showLabel ? HtmlClasses.Label : "control-label";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div");
            BeginWriteAttribute("class", " class=\"", 222, "\"", 343, 3);
            WriteAttributeValue("", 230, "form-group", 230, 10, true);
#nullable restore
#line 9 "D:\Projects\AtomicSeller\Tech\Apps\_OrderManager\Dev\AtomicSeller\Views\Shared\EditorTemplates\HttpPostedFileBase.cshtml"
WriteAttributeValue("", 240, Html.ValidationErrorFor(m => m, " has-error"), 240, 48, false);

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "D:\Projects\AtomicSeller\Tech\Apps\_OrderManager\Dev\AtomicSeller\Views\Shared\EditorTemplates\HttpPostedFileBase.cshtml"
WriteAttributeValue("", 288, ViewData.ModelMetadata.IsRequired ? " required" : "", 288, 55, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n    ");
#nullable restore
#line 10 "D:\Projects\AtomicSeller\Tech\Apps\_OrderManager\Dev\AtomicSeller\Views\Shared\EditorTemplates\HttpPostedFileBase.cshtml"
Write(Html.Partial("~/Views/Shared/EditorTemplates/_Label.cshtml"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n    <div");
            BeginWriteAttribute("class", " class=\"", 424, "\"", 448, 1);
#nullable restore
#line 12 "D:\Projects\AtomicSeller\Tech\Apps\_OrderManager\Dev\AtomicSeller\Views\Shared\EditorTemplates\HttpPostedFileBase.cshtml"
WriteAttributeValue("", 432, controlsClasses, 432, 16, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n        <div class=\"input-group input-file\">\r\n            <div class=\"input-group-btn\">\r\n                <span class=\"btn btn-default btn-file\">\r\n");
#nullable restore
#line 16 "D:\Projects\AtomicSeller\Tech\Apps\_OrderManager\Dev\AtomicSeller\Views\Shared\EditorTemplates\HttpPostedFileBase.cshtml"
                      new Local().TranslatedMessage("BROWSE");

#line default
#line hidden
#nullable disable
            WriteLiteral("&hellip; <input type=\"File\"");
            BeginWriteAttribute("name", " name=\"", 688, "\"", 714, 1);
#nullable restore
#line 16 "D:\Projects\AtomicSeller\Tech\Apps\_OrderManager\Dev\AtomicSeller\Views\Shared\EditorTemplates\HttpPostedFileBase.cshtml"
WriteAttributeValue("", 695, Html.IdFor(m => m), 695, 19, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("id", " id=\"", 715, "\"", 739, 1);
#nullable restore
#line 16 "D:\Projects\AtomicSeller\Tech\Apps\_OrderManager\Dev\AtomicSeller\Views\Shared\EditorTemplates\HttpPostedFileBase.cshtml"
WriteAttributeValue("", 720, Html.IdFor(m => m), 720, 19, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn-default btn-file\" />\r\n                </span>\r\n            </div>\r\n            <input type=\"text\" class=\"form-control\" readonly/>\r\n        </div>\r\n\r\n        ");
#nullable restore
#line 22 "D:\Projects\AtomicSeller\Tech\Apps\_OrderManager\Dev\AtomicSeller\Views\Shared\EditorTemplates\HttpPostedFileBase.cshtml"
   Write(Html.ValidationMessageFor(m => m, null, new {@class = "help-block"}));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </div>\r\n</div>\r\n");
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
