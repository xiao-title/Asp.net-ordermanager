#pragma checksum "E:\2020\client_project_from_0407\france\atomic\project\ordermanager\ordermanaager\AtomicSeller\Views\Shared\EditorTemplates\Date.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a4543a39cddfd3304864d267aa20c0840ace2469"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_EditorTemplates_Date), @"mvc.1.0.view", @"/Views/Shared/EditorTemplates/Date.cshtml")]
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
#line 1 "E:\2020\client_project_from_0407\france\atomic\project\ordermanager\ordermanaager\AtomicSeller\Views\Shared\EditorTemplates\Date.cshtml"
using AtomicSeller.Helpers.Razor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "E:\2020\client_project_from_0407\france\atomic\project\ordermanager\ordermanaager\AtomicSeller\Views\Shared\EditorTemplates\Date.cshtml"
using Microsoft.AspNetCore.Routing;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a4543a39cddfd3304864d267aa20c0840ace2469", @"/Views/Shared/EditorTemplates/Date.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d1a0039f6a8aa9b448d53da5bc34a03f444a947e", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_EditorTemplates_Date : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<DateTime?>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 5 "E:\2020\client_project_from_0407\france\atomic\project\ordermanager\ordermanaager\AtomicSeller\Views\Shared\EditorTemplates\Date.cshtml"
  
    var format = System.Threading.Thread.CurrentThread.CurrentUICulture.DateTimeFormat.ShortDatePattern;
    DateTime? date = Model;

    if (date.HasValue)
    {
        if (ViewBag.min_date != null && date < (DateTime)ViewBag.min_date)
        {
            date = (DateTime)ViewBag.min_date;
        }

        if (ViewBag.max_date != null && date > (DateTime)ViewBag.max_date)
        {
            date = (DateTime)ViewBag.max_date;
        }
    }

    var strDate = date.HasValue ? date.Value.ToString(format) : null;

    ViewBag.htmlAttributes = (RouteValueDictionary)ViewBag.htmlAttributes ?? new RouteValueDictionary();
    ViewBag.htmlAttributes["class"] = "datepicker";
    ViewBag.htmlAttributes["Value"] = strDate;
    ViewBag.htmlAttributes["data_provide"] = "datepicker";
    ViewBag.htmlAttributes["data_date"] = strDate;
    ViewBag.htmlAttributes["data_date_format"] = format.Replace("M", "m");
    ViewBag.htmlAttributes["placeholder"] = ViewBag.placeholder;
    ViewBag.htmlAttributes["data-date-min"] = ViewBag.min_date != null ? HtmlHelpers.ToJavascriptDate(ViewBag.min_date) : null;
    ViewBag.htmlAttributes["data-date-max"] = ViewBag.max_date != null ? HtmlHelpers.ToJavascriptDate(ViewBag.max_date) : null;

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 35 "E:\2020\client_project_from_0407\france\atomic\project\ordermanager\ordermanaager\AtomicSeller\Views\Shared\EditorTemplates\Date.cshtml"
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<DateTime?> Html { get; private set; }
    }
}
#pragma warning restore 1591
