#pragma checksum "D:\Projects\AtomicSeller\Tech\Apps\_OrderManager\Dev\AtomicSeller\Views\Shared\EditorTemplates\Boolean.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "98dd82e033e264a2243c64f9aeec002fe722c454"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_EditorTemplates_Boolean), @"mvc.1.0.view", @"/Views/Shared/EditorTemplates/Boolean.cshtml")]
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
#line 1 "D:\Projects\AtomicSeller\Tech\Apps\_OrderManager\Dev\AtomicSeller\Views\Shared\EditorTemplates\Boolean.cshtml"
using AtomicSeller.Helpers.Razor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Projects\AtomicSeller\Tech\Apps\_OrderManager\Dev\AtomicSeller\Views\Shared\EditorTemplates\Boolean.cshtml"
using AtomicSeller.Helpers.Razor.HtmlExtensions;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\Projects\AtomicSeller\Tech\Apps\_OrderManager\Dev\AtomicSeller\Views\Shared\EditorTemplates\Boolean.cshtml"
using Microsoft.AspNetCore.Routing;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"98dd82e033e264a2243c64f9aeec002fe722c454", @"/Views/Shared/EditorTemplates/Boolean.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d1a0039f6a8aa9b448d53da5bc34a03f444a947e", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_EditorTemplates_Boolean : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Boolean?>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 6 "D:\Projects\AtomicSeller\Tech\Apps\_OrderManager\Dev\AtomicSeller\Views\Shared\EditorTemplates\Boolean.cshtml"
  
    var htmlAttributes = (RouteValueDictionary) ViewBag.htmlAttributes ?? new RouteValueDictionary();
    
    if (ViewBag.@readonly != null)
    {
        htmlAttributes["readonly"] = ViewBag.@readonly;
    }

    if (ViewBag.disabled != null)
    {
        htmlAttributes["disabled"] = ViewBag.disabled;
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n<div");
            BeginWriteAttribute("class", " class=\"", 479, "\"", 545, 2);
            WriteAttributeValue("", 487, "form-group", 487, 10, true);
#nullable restore
#line 21 "D:\Projects\AtomicSeller\Tech\Apps\_OrderManager\Dev\AtomicSeller\Views\Shared\EditorTemplates\Boolean.cshtml"
WriteAttributeValue("", 497, Html.ValidationErrorFor(m => m, " has-error"), 497, 48, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n    ");
#nullable restore
#line 22 "D:\Projects\AtomicSeller\Tech\Apps\_OrderManager\Dev\AtomicSeller\Views\Shared\EditorTemplates\Boolean.cshtml"
Write(Html.Partial( "~/Views/Shared/EditorTemplates/_Label.cshtml"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n    <div");
            BeginWriteAttribute("class", " class=\"", 627, "\"", 664, 2);
            WriteAttributeValue("", 635, "controls", 635, 8, true);
#nullable restore
#line 24 "D:\Projects\AtomicSeller\Tech\Apps\_OrderManager\Dev\AtomicSeller\Views\Shared\EditorTemplates\Boolean.cshtml"
WriteAttributeValue(" ", 643, HtmlClasses.Control, 644, 20, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n        ");
#nullable restore
#line 25 "D:\Projects\AtomicSeller\Tech\Apps\_OrderManager\Dev\AtomicSeller\Views\Shared\EditorTemplates\Boolean.cshtml"
   Write(Html.CheckBox(
            "",
            Model.HasValue && Model.Value,
            htmlAttributes));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        ");
#nullable restore
#line 29 "D:\Projects\AtomicSeller\Tech\Apps\_OrderManager\Dev\AtomicSeller\Views\Shared\EditorTemplates\Boolean.cshtml"
   Write(Html.ValidationMessageFor(m => m, null, new { @class = "help-block" }));

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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Boolean?> Html { get; private set; }
    }
}
#pragma warning restore 1591