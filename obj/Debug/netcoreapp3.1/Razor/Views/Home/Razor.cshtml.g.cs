#pragma checksum "C:\Users\Kab\source\repos\Lab3.NET\Views\Home\Razor.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a90658d2f630aff3358f9c3bbbfbb3c66e66ab69"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Razor), @"mvc.1.0.view", @"/Views/Home/Razor.cshtml")]
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
#line 1 "C:\Users\Kab\source\repos\Lab3.NET\Views\_ViewImports.cshtml"
using Lab3.NET;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Kab\source\repos\Lab3.NET\Views\_ViewImports.cshtml"
using Lab3.NET.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a90658d2f630aff3358f9c3bbbfbb3c66e66ab69", @"/Views/Home/Razor.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"66a1f352354f529100e98ca561efb55b815dac96", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Razor : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\Kab\source\repos\Lab3.NET\Views\Home\Razor.cshtml"
  
    ViewData["Title"] = "Razor";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div>\r\n    <strong>Table</strong>\r\n    <br />\r\n</div>\r\n<table style=\"width:100%\" border=\"1\">\r\n");
#nullable restore
#line 10 "C:\Users\Kab\source\repos\Lab3.NET\Views\Home\Razor.cshtml"
      
        int num = 1;
        

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Users\Kab\source\repos\Lab3.NET\Views\Home\Razor.cshtml"
         for (int i = 0; i < 4; i++)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\r\n");
#nullable restore
#line 15 "C:\Users\Kab\source\repos\Lab3.NET\Views\Home\Razor.cshtml"
                 for (int j = 0; j < 10; j++)
                {


#line default
#line hidden
#nullable disable
            WriteLiteral("                    <td>");
#nullable restore
#line 18 "C:\Users\Kab\source\repos\Lab3.NET\Views\Home\Razor.cshtml"
                    Write(num + (10 * i) + j);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n");
#nullable restore
#line 19 "C:\Users\Kab\source\repos\Lab3.NET\Views\Home\Razor.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </tr>\r\n");
#nullable restore
#line 21 "C:\Users\Kab\source\repos\Lab3.NET\Views\Home\Razor.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("</table>\r\n\r\n<div>\r\n    <br />\r\n    <strong>99 Bottles of Beer</strong>\r\n</div>\r\n<div>\r\n    <table>\r\n");
#nullable restore
#line 31 "C:\Users\Kab\source\repos\Lab3.NET\Views\Home\Razor.cshtml"
         for (int i = 99; i > 0; i--)
        {
            if (i % 20 == 0)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <tr>WOOO!<br /><br /></tr>\r\n");
#nullable restore
#line 36 "C:\Users\Kab\source\repos\Lab3.NET\Views\Home\Razor.cshtml"
            }
            else if (i % 50 == 0)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <tr>awwww :(<br /><br /></tr>\r\n");
#nullable restore
#line 40 "C:\Users\Kab\source\repos\Lab3.NET\Views\Home\Razor.cshtml"
            }
            else
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <tr>");
#nullable restore
#line 43 "C:\Users\Kab\source\repos\Lab3.NET\Views\Home\Razor.cshtml"
               Write(i);

#line default
#line hidden
#nullable disable
            WriteLiteral(" Bottles of beer on the wall, ");
#nullable restore
#line 43 "C:\Users\Kab\source\repos\Lab3.NET\Views\Home\Razor.cshtml"
                                               Write(i);

#line default
#line hidden
#nullable disable
            WriteLiteral(" bottles of beer. You take one down, you pass it around, ");
#nullable restore
#line 43 "C:\Users\Kab\source\repos\Lab3.NET\Views\Home\Razor.cshtml"
                                                                                                           Write(i - 1);

#line default
#line hidden
#nullable disable
            WriteLiteral(" <br /><br /></tr>\r\n");
#nullable restore
#line 44 "C:\Users\Kab\source\repos\Lab3.NET\Views\Home\Razor.cshtml"
            }
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </table>\r\n</div>\r\n<a href=\"/Home/Index\">Go Home</a>");
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
