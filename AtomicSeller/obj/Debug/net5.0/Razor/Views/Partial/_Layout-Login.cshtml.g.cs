#pragma checksum "D:\Projects\AtomicSeller\Tech\Apps\_OrderManager\Dev\AtomicSeller\Views\Partial\_Layout-Login.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c4d550eb18a48b81b0a97a2e605221ea42f66e9e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Partial__Layout_Login), @"mvc.1.0.view", @"/Views/Partial/_Layout-Login.cshtml")]
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
#line 1 "D:\Projects\AtomicSeller\Tech\Apps\_OrderManager\Dev\AtomicSeller\Views\Partial\_Layout-Login.cshtml"
using System.Threading;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Projects\AtomicSeller\Tech\Apps\_OrderManager\Dev\AtomicSeller\Views\Partial\_Layout-Login.cshtml"
using AtomicSeller.Helpers;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\Projects\AtomicSeller\Tech\Apps\_OrderManager\Dev\AtomicSeller\Views\Partial\_Layout-Login.cshtml"
using AtomicSeller.Helpers.Navigation;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\Projects\AtomicSeller\Tech\Apps\_OrderManager\Dev\AtomicSeller\Views\Partial\_Layout-Login.cshtml"
using AtomicSeller.Helpers.Razor;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c4d550eb18a48b81b0a97a2e605221ea42f66e9e", @"/Views/Partial/_Layout-Login.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d1a0039f6a8aa9b448d53da5bc34a03f444a947e", @"/Views/_ViewImports.cshtml")]
    public class Views_Partial__Layout_Login : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/Resources/img/SoftwareDoc.jpg"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("max-width: 150px; max-height:30px; height: auto; width:auto;"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString("Labels"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/app/bundle3d.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/app/bundleJS.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 5 "D:\Projects\AtomicSeller\Tech\Apps\_OrderManager\Dev\AtomicSeller\Views\Partial\_Layout-Login.cshtml"
  

    ViewBag.Wide = ViewBag.Wide ?? false;
    ViewBag.Medium = ViewBag.Medium ?? false;

    var contentBoxClasses = "content-box " + (ViewBag.Wide ? " wide" : "") + (ViewBag.Medium ? " medium" : "");

    var primaryColor = "#0083C0";
    var CHATWITHSUPPORT = new Local().TranslatedMessage("CHATWITHSUPPORT");
    var OPENACCOUNT = new Local().TranslatedMessage("OPENACCOUNT");

    string LogoPath = "~/Resources/img/SiteLogos/LogoAtomic.gif";
    string SiteName = "AtomicSeller";


#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<!DOCTYPE html>\r\n<html lang=\"fr\">\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c4d550eb18a48b81b0a97a2e605221ea42f66e9e6864", async() => {
                WriteLiteral("\r\n    <meta charset=\"utf-8\">\r\n    <meta http-equiv=\"X-UA-Compatible\" content=\"IE=edge\">\r\n    <meta name=\"viewport\" content=\"width=device-width, initial-scale=1\">\r\n\r\n    <title>");
#nullable restore
#line 28 "D:\Projects\AtomicSeller\Tech\Apps\_OrderManager\Dev\AtomicSeller\Views\Partial\_Layout-Login.cshtml"
      Write(ViewBag.Title);

#line default
#line hidden
#nullable disable
                WriteLiteral(@" - AtomicSeller</title>

    <link rel=""stylesheet"" href=""https://maxcdn.bootstrapcdn.com/bootstrap/3.3.6/css/bootstrap.min.css"" integrity=""sha384-1q8mTJOASx8j1Au+a5WDVnPi2lkFfwwEAa8hDDdjZlpLegxhjVME1fgjWPGmkzs7"" crossorigin=""anonymous"">
    <link rel=""stylesheet"" href=""https://maxcdn.bootstrapcdn.com/bootstrap/3.3.6/css/bootstrap-theme.min.css"" integrity=""sha384-fLW2N01lMqjakBkx3l/M9EahuwpSfeNvV63J5ezn3uZzapT0u7EYsXMjQV+0En5r"" crossorigin=""anonymous"">
    <link rel=""stylesheet"" href=""https://cdnjs.cloudflare.com/ajax/libs/MaterialDesign-Webfont/1.6.50/css/materialdesignicons.min.css"">

    <link rel=""stylesheet""");
                BeginWriteAttribute("href", " href=\"", 1495, "\"", 1566, 1);
#nullable restore
#line 34 "D:\Projects\AtomicSeller\Tech\Apps\_OrderManager\Dev\AtomicSeller\Views\Partial\_Layout-Login.cshtml"
WriteAttributeValue("", 1502, Url.Content("~/Resources/3d/css/bootstrap-datepicker3.min.css"), 1502, 64, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">\r\n    <link rel=\"stylesheet\"");
                BeginWriteAttribute("href", " href=\"", 1596, "\"", 1655, 1);
#nullable restore
#line 35 "D:\Projects\AtomicSeller\Tech\Apps\_OrderManager\Dev\AtomicSeller\Views\Partial\_Layout-Login.cshtml"
WriteAttributeValue("", 1603, Url.Content("~/Resources/3d/css/flag-icon.min.css"), 1603, 52, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">\r\n    <link rel=\"stylesheet\"");
                BeginWriteAttribute("href", " href=\"", 1685, "\"", 1733, 1);
#nullable restore
#line 36 "D:\Projects\AtomicSeller\Tech\Apps\_OrderManager\Dev\AtomicSeller\Views\Partial\_Layout-Login.cshtml"
WriteAttributeValue("", 1692, Url.Content("~/Resources/css/style.css"), 1692, 41, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">\r\n    <link rel=\"stylesheet\"");
                BeginWriteAttribute("href", " href=\"", 1763, "\"", 1822, 1);
#nullable restore
#line 37 "D:\Projects\AtomicSeller\Tech\Apps\_OrderManager\Dev\AtomicSeller\Views\Partial\_Layout-Login.cshtml"
WriteAttributeValue("", 1770, Url.Content("~/Resources/css/authentification.css"), 1770, 52, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">\r\n    \r\n    <link href=\"https://fonts.googleapis.com/css?family=Roboto:400,500,300\" rel=\"stylesheet\" type=\"text/css\">\r\n\r\n    ");
#nullable restore
#line 41 "D:\Projects\AtomicSeller\Tech\Apps\_OrderManager\Dev\AtomicSeller\Views\Partial\_Layout-Login.cshtml"
Write(RenderSection("head", required: false));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n    ");
#nullable restore
#line 42 "D:\Projects\AtomicSeller\Tech\Apps\_OrderManager\Dev\AtomicSeller\Views\Partial\_Layout-Login.cshtml"
Write(Html.Partial("~/Views/Partial/_Favicons.cshtml"));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n    <meta name=\"description\" content=\"AtomicSeller\" />\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c4d550eb18a48b81b0a97a2e605221ea42f66e9e11515", async() => {
                WriteLiteral("\r\n    <div class=\"classLoader\">\r\n        <div class=\"content-watermark hidden-print\"></div>\r\n        <style scoped>.content-watermark { background-image: url(\'");
#nullable restore
#line 48 "D:\Projects\AtomicSeller\Tech\Apps\_OrderManager\Dev\AtomicSeller\Views\Partial\_Layout-Login.cshtml"
                                                             Write(Url.Content(@LogoPath));

#line default
#line hidden
#nullable disable
                WriteLiteral(@"'); }</style>
        <header class=""header"">

            <!-- TOP MENU -->
            <div class=""header-right"">

                <div class=""actions"">
                    <!--
                                        if(new Tools().IsDev())
                                         {
                                             <a href=""Url.Action(""BuyIndex"", ""Licencing"")""
                                            class=""btn btn-primary""
                                            data-toggle=""tooltip""
                                            title=""Buy"">
                                             <i class=""mdi mdi-human""></i>Buy
                                         </a>
                                         }
                        -->
                    <a class=""btn btn-primary""
                       onclick=""DisplayChat()""
                       data-toggle=""tooltip""");
                BeginWriteAttribute("title", "\r\n                       title=\"", 3286, "\"", 3334, 1);
#nullable restore
#line 69 "D:\Projects\AtomicSeller\Tech\Apps\_OrderManager\Dev\AtomicSeller\Views\Partial\_Layout-Login.cshtml"
WriteAttributeValue("", 3318, CHATWITHSUPPORT, 3318, 16, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">\r\n                        <i class=\"mdi mdi-headset\"></i>");
#nullable restore
#line 70 "D:\Projects\AtomicSeller\Tech\Apps\_OrderManager\Dev\AtomicSeller\Views\Partial\_Layout-Login.cshtml"
                                                  Write(CHATWITHSUPPORT);

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                    </a>\r\n\r\n                    <a class=\"btn btn-light btn-xs\"");
                BeginWriteAttribute("href", "\r\n                       href=\"", 3490, "\"", 3561, 1);
#nullable restore
#line 74 "D:\Projects\AtomicSeller\Tech\Apps\_OrderManager\Dev\AtomicSeller\Views\Partial\_Layout-Login.cshtml"
WriteAttributeValue("", 3521, Url.Action("GotoDocumentation", "Home"), 3521, 40, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral("\r\n                       data-toggle=\"tooltip\"\r\n                       data-placement=\"left\"\r\n                       target=\"_blank\"\r\n                       title=\"Documentation\">\r\n                        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "c4d550eb18a48b81b0a97a2e605221ea42f66e9e14743", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral(@"
                    </a>
                    <!--
                                         <a class=""btn btn-light btn-xs""
                                            href=""Url.Action(""GotoSupportTickets"", ""Home"")""
                                            data-toggle=""tooltip""
                                            data-placement=""left""
                                            target=""_blank""
                                            title=""Contact helpdesk"">
                                             <img src=""~/resources/img/Support.jpg"" style=""max-width: 150px; max-height:30px; height: auto; width:auto;"" alt=""Labels"">
                                         </a>
                        -->

                    <div class=""dropdown pull-right"" data-toggle=""tooltip"" data-placement=""left""");
                BeginWriteAttribute("title", " title=\"", 4721, "\"", 4786, 1);
                WriteAttributeValue("", 4729, new Microsoft.AspNetCore.Mvc.Razor.HelperResult(async(__razor_attribute_value_writer) => {
                    PushWriter(__razor_attribute_value_writer);
#nullable restore
#line 92 "D:\Projects\AtomicSeller\Tech\Apps\_OrderManager\Dev\AtomicSeller\Views\Partial\_Layout-Login.cshtml"
                                                                                                          new Local().TranslatedMessage("MESNULChangeLanguage");

#line default
#line hidden
#nullable disable
                    PopWriter();
                }
                ), 4729, 57, false);
                EndWriteAttribute();
                WriteLiteral(">\r\n                        <a href=\"#\" class=\"action\" data-toggle=\"dropdown\">\r\n");
#nullable restore
#line 94 "D:\Projects\AtomicSeller\Tech\Apps\_OrderManager\Dev\AtomicSeller\Views\Partial\_Layout-Login.cshtml"
                              
                                var flag = "";
                                switch (Thread.CurrentThread.CurrentCulture.TwoLetterISOLanguageName)
                                {
                                    case "en":
                                        flag = "flag-icon-gb";
                                        break;
                                    case "fr":
                                        flag = "flag-icon-fr";
                                        break;
                                    case "zh":
                                        flag = "flag-icon-cn";
                                        break;
                                    case "de":
                                        flag = "flag-icon-de";
                                        break;
                                    case "it":
                                        flag = "flag-icon-it";
                                        break;
                                    case "es":
                                        flag = "flag-icon-es";
                                        break;
                                    case "pt":
                                        flag = "flag-icon-pt";
                                        break;
                                    case "nl":
                                        flag = "flag-icon-nl";
                                        break;
                                    case "ja":
                                        flag = "flag-icon-jp";
                                        break;
                                    case "ru":
                                        flag = "flag-icon-ru";
                                        break;
                                    case "hi":
                                        flag = "flag-icon-in";
                                        break;
                                    case "pl":
                                        flag = "flag-icon-pl";
                                        break;
                                    case "id":
                                        flag = "flag-icon-id";
                                        break;
                                    case "ar":
                                        flag = "flag-icon-eg";
                                        break;
                                }
                            

#line default
#line hidden
#nullable disable
                WriteLiteral("                            <i");
                BeginWriteAttribute("class", " class=\"", 7420, "\"", 7443, 2);
                WriteAttributeValue("", 7428, "flag-icon", 7428, 9, true);
#nullable restore
#line 142 "D:\Projects\AtomicSeller\Tech\Apps\_OrderManager\Dev\AtomicSeller\Views\Partial\_Layout-Login.cshtml"
WriteAttributeValue(" ", 7437, flag, 7438, 5, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral("></i>\r\n                        </a>\r\n\r\n                        <ul class=\"dropdown-menu\">\r\n                            <li><a");
                BeginWriteAttribute("href", " href=\"", 7569, "\"", 7633, 1);
#nullable restore
#line 146 "D:\Projects\AtomicSeller\Tech\Apps\_OrderManager\Dev\AtomicSeller\Views\Partial\_Layout-Login.cshtml"
WriteAttributeValue("", 7576, Url.Action("SetCulture", "Home", new { culture = "fr" }), 7576, 57, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral("><i class=\"flag-icon flag-icon-fr\"></i> Français</a></li>\r\n                            <li><a");
                BeginWriteAttribute("href", " href=\"", 7727, "\"", 7791, 1);
#nullable restore
#line 147 "D:\Projects\AtomicSeller\Tech\Apps\_OrderManager\Dev\AtomicSeller\Views\Partial\_Layout-Login.cshtml"
WriteAttributeValue("", 7734, Url.Action("SetCulture", "Home", new { culture = "en" }), 7734, 57, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral("><i class=\"flag-icon flag-icon-gb\"></i> English</a></li>\r\n                            <li><a");
                BeginWriteAttribute("href", " href=\"", 7884, "\"", 7951, 1);
#nullable restore
#line 148 "D:\Projects\AtomicSeller\Tech\Apps\_OrderManager\Dev\AtomicSeller\Views\Partial\_Layout-Login.cshtml"
WriteAttributeValue("", 7891, Url.Action("SetCulture", "Home", new { culture = "zh-CN" }), 7891, 60, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral("><i class=\"flag-icon flag-icon-cn\"></i> 中文</a></li>\r\n                            <li><a");
                BeginWriteAttribute("href", " href=\"", 8039, "\"", 8103, 1);
#nullable restore
#line 149 "D:\Projects\AtomicSeller\Tech\Apps\_OrderManager\Dev\AtomicSeller\Views\Partial\_Layout-Login.cshtml"
WriteAttributeValue("", 8046, Url.Action("SetCulture", "Home", new { culture = "de" }), 8046, 57, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral("><i class=\"flag-icon flag-icon-de\"></i> Deutsch</a></li>\r\n                            <li><a");
                BeginWriteAttribute("href", " href=\"", 8196, "\"", 8260, 1);
#nullable restore
#line 150 "D:\Projects\AtomicSeller\Tech\Apps\_OrderManager\Dev\AtomicSeller\Views\Partial\_Layout-Login.cshtml"
WriteAttributeValue("", 8203, Url.Action("SetCulture", "Home", new { culture = "it" }), 8203, 57, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral("><i class=\"flag-icon flag-icon-it\"></i> Italiano</a></li>\r\n                            <li><a");
                BeginWriteAttribute("href", " href=\"", 8354, "\"", 8418, 1);
#nullable restore
#line 151 "D:\Projects\AtomicSeller\Tech\Apps\_OrderManager\Dev\AtomicSeller\Views\Partial\_Layout-Login.cshtml"
WriteAttributeValue("", 8361, Url.Action("SetCulture", "Home", new { culture = "es" }), 8361, 57, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral("><i class=\"flag-icon flag-icon-es\"></i> Español</a></li>\r\n                            <li><a");
                BeginWriteAttribute("href", " href=\"", 8511, "\"", 8575, 1);
#nullable restore
#line 152 "D:\Projects\AtomicSeller\Tech\Apps\_OrderManager\Dev\AtomicSeller\Views\Partial\_Layout-Login.cshtml"
WriteAttributeValue("", 8518, Url.Action("SetCulture", "Home", new { culture = "pt" }), 8518, 57, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral("><i class=\"flag-icon flag-icon-pt\"></i> Português</a></li>\r\n                            <li><a");
                BeginWriteAttribute("href", " href=\"", 8670, "\"", 8734, 1);
#nullable restore
#line 153 "D:\Projects\AtomicSeller\Tech\Apps\_OrderManager\Dev\AtomicSeller\Views\Partial\_Layout-Login.cshtml"
WriteAttributeValue("", 8677, Url.Action("SetCulture", "Home", new { culture = "nl" }), 8677, 57, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral("><i class=\"flag-icon flag-icon-nl\"></i> Nederlands</a></li>\r\n                            <li><a");
                BeginWriteAttribute("href", " href=\"", 8830, "\"", 8894, 1);
#nullable restore
#line 154 "D:\Projects\AtomicSeller\Tech\Apps\_OrderManager\Dev\AtomicSeller\Views\Partial\_Layout-Login.cshtml"
WriteAttributeValue("", 8837, Url.Action("SetCulture", "Home", new { culture = "ja" }), 8837, 57, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral("><i class=\"flag-icon flag-icon-jp\"></i> 日本語</a></li>\r\n                            <li><a");
                BeginWriteAttribute("href", " href=\"", 8983, "\"", 9047, 1);
#nullable restore
#line 155 "D:\Projects\AtomicSeller\Tech\Apps\_OrderManager\Dev\AtomicSeller\Views\Partial\_Layout-Login.cshtml"
WriteAttributeValue("", 8990, Url.Action("SetCulture", "Home", new { culture = "ru" }), 8990, 57, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral("><i class=\"flag-icon flag-icon-ru\"></i> Pусский</a></li>\r\n                            <li><a");
                BeginWriteAttribute("href", " href=\"", 9140, "\"", 9204, 1);
#nullable restore
#line 156 "D:\Projects\AtomicSeller\Tech\Apps\_OrderManager\Dev\AtomicSeller\Views\Partial\_Layout-Login.cshtml"
WriteAttributeValue("", 9147, Url.Action("SetCulture", "Home", new { culture = "hi" }), 9147, 57, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral("><i class=\"flag-icon flag-icon-in\"></i> हिन्दी</a></li>\r\n                            <li><a");
                BeginWriteAttribute("href", " href=\"", 9296, "\"", 9360, 1);
#nullable restore
#line 157 "D:\Projects\AtomicSeller\Tech\Apps\_OrderManager\Dev\AtomicSeller\Views\Partial\_Layout-Login.cshtml"
WriteAttributeValue("", 9303, Url.Action("SetCulture", "Home", new { culture = "pl" }), 9303, 57, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral("><i class=\"flag-icon flag-icon-pl\"></i> Polski</a></li>\r\n                            <li><a");
                BeginWriteAttribute("href", " href=\"", 9452, "\"", 9516, 1);
#nullable restore
#line 158 "D:\Projects\AtomicSeller\Tech\Apps\_OrderManager\Dev\AtomicSeller\Views\Partial\_Layout-Login.cshtml"
WriteAttributeValue("", 9459, Url.Action("SetCulture", "Home", new { culture = "id" }), 9459, 57, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral("><i class=\"flag-icon flag-icon-id\"></i> Indonesia</a></li>\r\n                            <li><a");
                BeginWriteAttribute("href", " href=\"", 9611, "\"", 9675, 1);
#nullable restore
#line 159 "D:\Projects\AtomicSeller\Tech\Apps\_OrderManager\Dev\AtomicSeller\Views\Partial\_Layout-Login.cshtml"
WriteAttributeValue("", 9618, Url.Action("SetCulture", "Home", new { culture = "ar" }), 9618, 57, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(@"><i class=""flag-icon flag-icon-eg""></i> عربى</a></li>
                        </ul>
                    </div>
                </div>
            </div>
        </header>

        <!--<div class=""clearfix""></div>-->

        <div class=""not-loader"">
            <div class=""container"">
                <div class=""content-wrap"">
                    <h1><span>");
#nullable restore
#line 171 "D:\Projects\AtomicSeller\Tech\Apps\_OrderManager\Dev\AtomicSeller\Views\Partial\_Layout-Login.cshtml"
                         Write(SiteName);

#line default
#line hidden
#nullable disable
                WriteLiteral("</span></h1>\r\n                    <h2>");
#nullable restore
#line 172 "D:\Projects\AtomicSeller\Tech\Apps\_OrderManager\Dev\AtomicSeller\Views\Partial\_Layout-Login.cshtml"
                          new Local().TranslatedMessage("MESNULCustomerSpace");

#line default
#line hidden
#nullable disable
                WriteLiteral("</h2>\r\n\r\n                    <div");
                BeginWriteAttribute("class", " class=\"", 10183, "\"", 10209, 1);
#nullable restore
#line 174 "D:\Projects\AtomicSeller\Tech\Apps\_OrderManager\Dev\AtomicSeller\Views\Partial\_Layout-Login.cshtml"
WriteAttributeValue("", 10191, contentBoxClasses, 10191, 18, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">\r\n                        ");
#nullable restore
#line 175 "D:\Projects\AtomicSeller\Tech\Apps\_OrderManager\Dev\AtomicSeller\Views\Partial\_Layout-Login.cshtml"
                   Write(Html.Partial("~/Views/Partial/_FlashMessages.cshtml"));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n\r\n                        <div class=\"content\">\r\n                            ");
#nullable restore
#line 178 "D:\Projects\AtomicSeller\Tech\Apps\_OrderManager\Dev\AtomicSeller\Views\Partial\_Layout-Login.cshtml"
                       Write(RenderBody());

#line default
#line hidden
#nullable disable
                WriteLiteral(@"
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>
    <div class=""nav-fullmask"" style=""display: none;""></div>
    <div id=""confirmModal"" class=""modal fade"" tabindex=""-1"" role=""dialog"">
        <div class=""modal-dialog"" role=""document"">
            <div class=""modal-content"">
                <div class=""modal-body"">
                    <button type=""button"" class=""close"" data-dismiss=""modal"" aria-label=""Close""><span aria-hidden=""true"">&times;</span></button>

                    <div class=""confirmation-message"">
                        <div class=""modal-body-content"">
                            <i class=""mdi mdi-alert-circle""></i>
                            <span></span>
                        </div>
                    </div>
                </div>
                <div class=""modal-footer"">
                    <a class=""btn btn-secondary-outline"" data-dismiss=""modal"">
                        <i class=""mdi m");
                WriteLiteral("di-close\"></i> ");
#nullable restore
#line 201 "D:\Projects\AtomicSeller\Tech\Apps\_OrderManager\Dev\AtomicSeller\Views\Partial\_Layout-Login.cshtml"
                                                        new Local().TranslatedMessage("MESNULCancel"); 

#line default
#line hidden
#nullable disable
                WriteLiteral("                    </a>\r\n                    <a class=\"btn btn-primary modal-confirm-button\" href=\"#\">\r\n                        <i class=\"mdi mdi-check\"></i> ");
#nullable restore
#line 204 "D:\Projects\AtomicSeller\Tech\Apps\_OrderManager\Dev\AtomicSeller\Views\Partial\_Layout-Login.cshtml"
                                                        new Local().TranslatedMessage("MESNULYes"); 

#line default
#line hidden
#nullable disable
                WriteLiteral(@"                    </a>
                </div>
            </div>
        </div>
    </div>

    <div id=""loader-wrapper"">
        <div id=""loader""></div>

        <div class=""loader-section section-right""></div>
    </div>
    <script src=""https://code.jquery.com/jquery-2.1.1.min.js""></script>
    <script src=""https://cdnjs.cloudflare.com/ajax/libs/jquery.tablesorter/2.26.6/js/jquery.tablesorter.min.js""></script>
    <script src=""https://cdnjs.cloudflare.com/ajax/libs/jquery.tablesorter/2.27.7/js/jquery.tablesorter.widgets.min.js""></script>
    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c4d550eb18a48b81b0a97a2e605221ea42f66e9e33168", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c4d550eb18a48b81b0a97a2e605221ea42f66e9e34268", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n    ");
#nullable restore
#line 221 "D:\Projects\AtomicSeller\Tech\Apps\_OrderManager\Dev\AtomicSeller\Views\Partial\_Layout-Login.cshtml"
Write(RenderSection("scripts", required: false));

#line default
#line hidden
#nullable disable
                WriteLiteral(@"

    <script src=""https://maxcdn.bootstrapcdn.com/bootstrap/3.3.6/js/bootstrap.min.js"" integrity=""sha384-0mSbJDEHialfmuBBQP6A4Qrprq5OVfW37PRR3j5ELqxss1yVqOtnepnHVP9aJ7xS"" crossorigin=""anonymous""></script>

    <script type='text/javascript'>
    </script>
");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "class", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 2123, "page-", 2123, 5, true);
#nullable restore
#line 45 "D:\Projects\AtomicSeller\Tech\Apps\_OrderManager\Dev\AtomicSeller\Views\Partial\_Layout-Login.cshtml"
AddHtmlAttributeValue("", 2128, ViewBag.CSSClass, 2128, 17, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            BeginWriteTagHelperAttribute();
#nullable restore
#line 45 "D:\Projects\AtomicSeller\Tech\Apps\_OrderManager\Dev\AtomicSeller\Views\Partial\_Layout-Login.cshtml"
                                                    Write(primaryColor);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __tagHelperExecutionContext.AddHtmlAttribute("data-primary-color", Html.Raw(__tagHelperStringValueBuffer), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</html>\r\n");
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
