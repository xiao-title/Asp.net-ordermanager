#pragma checksum "E:\2020\client_project_from_0407\france\atomic\project\ordermanager\ordermanaager\AtomicSeller\Views\Shared\EditorTemplates\Enum.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0f24f422213199f261aac0cf4aac40b9b38492ef"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_EditorTemplates_Enum), @"mvc.1.0.view", @"/Views/Shared/EditorTemplates/Enum.cshtml")]
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
#line 1 "E:\2020\client_project_from_0407\france\atomic\project\ordermanager\ordermanaager\AtomicSeller\Views\Shared\EditorTemplates\Enum.cshtml"
using AtomicSeller.Helpers.Razor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "E:\2020\client_project_from_0407\france\atomic\project\ordermanager\ordermanaager\AtomicSeller\Views\Shared\EditorTemplates\Enum.cshtml"
using AtomicSeller.Helpers.Razor.HtmlExtensions;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0f24f422213199f261aac0cf4aac40b9b38492ef", @"/Views/Shared/EditorTemplates/Enum.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d1a0039f6a8aa9b448d53da5bc34a03f444a947e", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_EditorTemplates_Enum : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<object>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n\r\n<div");
            BeginWriteAttribute("class", " class=\"", 108, "\"", 225, 3);
            WriteAttributeValue("", 116, "form-group", 116, 10, true);
#nullable restore
#line 6 "E:\2020\client_project_from_0407\france\atomic\project\ordermanager\ordermanaager\AtomicSeller\Views\Shared\EditorTemplates\Enum.cshtml"
WriteAttributeValue("", 126, Html.ValidationErrorFor(m => m, " has-error"), 126, 48, false);

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "E:\2020\client_project_from_0407\france\atomic\project\ordermanager\ordermanaager\AtomicSeller\Views\Shared\EditorTemplates\Enum.cshtml"
WriteAttributeValue("", 174, ViewData.ModelMetadata.IsRequired?" required":"", 174, 51, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n    ");
#nullable restore
#line 7 "E:\2020\client_project_from_0407\france\atomic\project\ordermanager\ordermanaager\AtomicSeller\Views\Shared\EditorTemplates\Enum.cshtml"
Write(Html.Partial( "~/Views/Shared/EditorTemplates/_Label.cshtml"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n    <div");
            BeginWriteAttribute("class", " class=\"", 307, "\"", 344, 2);
            WriteAttributeValue("", 315, "controls", 315, 8, true);
#nullable restore
#line 9 "E:\2020\client_project_from_0407\france\atomic\project\ordermanager\ordermanaager\AtomicSeller\Views\Shared\EditorTemplates\Enum.cshtml"
WriteAttributeValue(" ", 323, HtmlClasses.Control, 324, 20, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n");
            WriteLiteral("        ");
#nullable restore
#line 11 "E:\2020\client_project_from_0407\france\atomic\project\ordermanager\ordermanaager\AtomicSeller\Views\Shared\EditorTemplates\Enum.cshtml"
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<object> Html { get; private set; }
    }
}
#pragma warning restore 1591
