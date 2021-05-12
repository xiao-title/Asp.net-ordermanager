#pragma checksum "E:\2020\client_project_from_0407\france\atomic\project\ordermanager\ordermanaager\AtomicSeller\Views\Partial\_Breadcrumb.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7e80877804deafdfb1b5538f25b5cef90474e424"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Partial__Breadcrumb), @"mvc.1.0.view", @"/Views/Partial/_Breadcrumb.cshtml")]
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
#line 1 "E:\2020\client_project_from_0407\france\atomic\project\ordermanager\ordermanaager\AtomicSeller\Views\Partial\_Breadcrumb.cshtml"
using AtomicSeller.Helpers;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "E:\2020\client_project_from_0407\france\atomic\project\ordermanager\ordermanaager\AtomicSeller\Views\Partial\_Breadcrumb.cshtml"
using AtomicSeller.Helpers.Navigation;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7e80877804deafdfb1b5538f25b5cef90474e424", @"/Views/Partial/_Breadcrumb.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d1a0039f6a8aa9b448d53da5bc34a03f444a947e", @"/Views/_ViewImports.cshtml")]
    public class Views_Partial__Breadcrumb : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "E:\2020\client_project_from_0407\france\atomic\project\ordermanager\ordermanaager\AtomicSeller\Views\Partial\_Breadcrumb.cshtml"
  
    var navigationHelper = NavigationHelper.Instance;
    var breadcrumb = navigationHelper.GetBreadcrumb();

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<ul class=\"breadcrumb\">\r\n    <li><a");
            BeginWriteAttribute("href", " href=\"", 224, "\"", 259, 1);
#nullable restore
#line 9 "E:\2020\client_project_from_0407\france\atomic\project\ordermanager\ordermanaager\AtomicSeller\Views\Partial\_Breadcrumb.cshtml"
WriteAttributeValue("", 231, Url.Action("Index", "Home"), 231, 28, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"breadcrumb-root\"><i class=\"mdi mdi-home-variant\"></i> AtomicSeller</a></li>\r\n\r\n");
#nullable restore
#line 11 "E:\2020\client_project_from_0407\france\atomic\project\ordermanager\ordermanaager\AtomicSeller\Views\Partial\_Breadcrumb.cshtml"
     if (breadcrumb.Count > 0)
    {
        var lastItem = breadcrumb.Last();
        foreach (var item in breadcrumb)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <li class=\"divider\">\r\n                <i class=\"mdi mdi-chevron-right\"></i>\r\n            </li>\r\n");
#nullable restore
#line 19 "E:\2020\client_project_from_0407\france\atomic\project\ordermanager\ordermanaager\AtomicSeller\Views\Partial\_Breadcrumb.cshtml"

            var menuItem = item as MenuItem;


#line default
#line hidden
#nullable disable
            WriteLiteral("            <li ");
#nullable restore
#line 22 "E:\2020\client_project_from_0407\france\atomic\project\ordermanager\ordermanaager\AtomicSeller\Views\Partial\_Breadcrumb.cshtml"
                 if (lastItem == item && ViewBag.ActiveMenuItem == null) { 

#line default
#line hidden
#nullable disable
            WriteLiteral("class=\"active\"");
#nullable restore
#line 22 "E:\2020\client_project_from_0407\france\atomic\project\ordermanager\ordermanaager\AtomicSeller\Views\Partial\_Breadcrumb.cshtml"
                                                                                                       }

#line default
#line hidden
#nullable disable
            WriteLiteral(">\r\n");
#nullable restore
#line 23 "E:\2020\client_project_from_0407\france\atomic\project\ordermanager\ordermanaager\AtomicSeller\Views\Partial\_Breadcrumb.cshtml"
                 if (menuItem != null)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <a");
            BeginWriteAttribute("href", " href=\"", 828, "\"", 923, 1);
            WriteAttributeValue("", 835, new Microsoft.AspNetCore.Mvc.Razor.HelperResult(async(__razor_attribute_value_writer) => {
                PushWriter(__razor_attribute_value_writer);
#nullable restore
#line 25 "E:\2020\client_project_from_0407\france\atomic\project\ordermanager\ordermanaager\AtomicSeller\Views\Partial\_Breadcrumb.cshtml"
                              if (menuItem.Controller != null) { 

#line default
#line hidden
#nullable disable
#nullable restore
#line 25 "E:\2020\client_project_from_0407\france\atomic\project\ordermanager\ordermanaager\AtomicSeller\Views\Partial\_Breadcrumb.cshtml"
                                                            Write(Url.Action(menuItem.Action, menuItem.Controller));

#line default
#line hidden
#nullable disable
#nullable restore
#line 25 "E:\2020\client_project_from_0407\france\atomic\project\ordermanager\ordermanaager\AtomicSeller\Views\Partial\_Breadcrumb.cshtml"
                                                                                                                  ; }

#line default
#line hidden
#nullable disable
                PopWriter();
            }
            ), 835, 88, false);
            EndWriteAttribute();
            WriteLiteral(">\r\n                        <i");
            BeginWriteAttribute("class", " class=\"", 953, "\"", 979, 2);
            WriteAttributeValue("", 961, "mdi", 961, 3, true);
#nullable restore
#line 26 "E:\2020\client_project_from_0407\france\atomic\project\ordermanager\ordermanaager\AtomicSeller\Views\Partial\_Breadcrumb.cshtml"
WriteAttributeValue(" ", 964, menuItem.Icon, 965, 14, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("></i>\r\n                        ");
#nullable restore
#line 27 "E:\2020\client_project_from_0407\france\atomic\project\ordermanager\ordermanaager\AtomicSeller\Views\Partial\_Breadcrumb.cshtml"
                   Write(menuItem.Label);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </a>\r\n");
#nullable restore
#line 29 "E:\2020\client_project_from_0407\france\atomic\project\ordermanager\ordermanaager\AtomicSeller\Views\Partial\_Breadcrumb.cshtml"
                }
                else
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <a href=\"#\"><i");
            BeginWriteAttribute("class", " class=\"", 1148, "\"", 1170, 2);
            WriteAttributeValue("", 1156, "mdi", 1156, 3, true);
#nullable restore
#line 32 "E:\2020\client_project_from_0407\france\atomic\project\ordermanager\ordermanaager\AtomicSeller\Views\Partial\_Breadcrumb.cshtml"
WriteAttributeValue(" ", 1159, item.Icon, 1160, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("></i> ");
#nullable restore
#line 32 "E:\2020\client_project_from_0407\france\atomic\project\ordermanager\ordermanaager\AtomicSeller\Views\Partial\_Breadcrumb.cshtml"
                                                          Write(item.Label);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\r\n");
#nullable restore
#line 33 "E:\2020\client_project_from_0407\france\atomic\project\ordermanager\ordermanaager\AtomicSeller\Views\Partial\_Breadcrumb.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </li>\r\n");
#nullable restore
#line 35 "E:\2020\client_project_from_0407\france\atomic\project\ordermanager\ordermanaager\AtomicSeller\Views\Partial\_Breadcrumb.cshtml"
        }

        if (ViewBag.ActiveMenuItem != null)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <li class=\"divider\">\r\n                <i class=\"mdi mdi-chevron-right\"></i>\r\n            </li>\r\n");
            WriteLiteral("            <li class=\"active\">\r\n                <a href=\"#\">\r\n                    <i");
            BeginWriteAttribute("class", " class=\"", 1496, "\"", 1522, 2);
            WriteAttributeValue("", 1504, "mdi", 1504, 3, true);
#nullable restore
#line 45 "E:\2020\client_project_from_0407\france\atomic\project\ordermanager\ordermanaager\AtomicSeller\Views\Partial\_Breadcrumb.cshtml"
WriteAttributeValue(" ", 1507, lastItem.Icon, 1508, 14, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("></i>\r\n                    ");
#nullable restore
#line 46 "E:\2020\client_project_from_0407\france\atomic\project\ordermanager\ordermanaager\AtomicSeller\Views\Partial\_Breadcrumb.cshtml"
               Write(ViewBag.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </a>\r\n            </li>\r\n");
#nullable restore
#line 49 "E:\2020\client_project_from_0407\france\atomic\project\ordermanager\ordermanaager\AtomicSeller\Views\Partial\_Breadcrumb.cshtml"
        }
    }
    else
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <li class=\"divider\">\r\n            <i class=\"mdi mdi-chevron-right\"></i>\r\n        </li>\r\n        <li class=\"active\">\r\n            <a href=\"#\">");
#nullable restore
#line 57 "E:\2020\client_project_from_0407\france\atomic\project\ordermanager\ordermanaager\AtomicSeller\Views\Partial\_Breadcrumb.cshtml"
                   Write(ViewBag.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\r\n        </li>\r\n");
#nullable restore
#line 59 "E:\2020\client_project_from_0407\france\atomic\project\ordermanager\ordermanaager\AtomicSeller\Views\Partial\_Breadcrumb.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</ul>\r\n");
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
