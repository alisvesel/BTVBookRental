#pragma checksum "C:\Desktop\Cloud\BTVBookRental\BTVBookRental\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3266bd05867ab0380f2be701eb2194ee9cb70b12"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Index.cshtml", typeof(AspNetCore.Views_Home_Index))]
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
#line 1 "C:\Desktop\Cloud\BTVBookRental\BTVBookRental\Views\_ViewImports.cshtml"
using BTVBookRental;

#line default
#line hidden
#line 2 "C:\Desktop\Cloud\BTVBookRental\BTVBookRental\Views\_ViewImports.cshtml"
using BTVBookRental.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3266bd05867ab0380f2be701eb2194ee9cb70b12", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ee109d02ea1ad79f9e1e8cab8af50cb0ae8aa9da", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<BTVBookRental.Models.UserAccount>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "C:\Desktop\Cloud\BTVBookRental\BTVBookRental\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Home Page";

#line default
#line hidden
            BeginContext(99, 94, true);
            WriteLiteral("\r\n<div class=\"row\">\r\n    <div class=\"col-md-12\">\r\n        <h2>Utilizatori inregistrati:</h2>\r\n");
            EndContext();
#line 9 "C:\Desktop\Cloud\BTVBookRental\BTVBookRental\Views\Home\Index.cshtml"
         if(Model.Any())
        {

#line default
#line hidden
            BeginContext(230, 235, true);
            WriteLiteral("            <table class=\"table\">\r\n                <tr>\r\n                    <th>Prenume</th>\r\n                    <th>Nume</th>\r\n                    <th>Nume Utilizator</th>\r\n                    <th>Email</th>\r\n                </tr>\r\n");
            EndContext();
#line 18 "C:\Desktop\Cloud\BTVBookRental\BTVBookRental\Views\Home\Index.cshtml"
                 foreach(var item in Model)
                {

#line default
#line hidden
            BeginContext(529, 46, true);
            WriteLiteral("                <tr>\r\n                    <td>");
            EndContext();
            BeginContext(576, 14, false);
#line 21 "C:\Desktop\Cloud\BTVBookRental\BTVBookRental\Views\Home\Index.cshtml"
                   Write(item.FirstName);

#line default
#line hidden
            EndContext();
            BeginContext(590, 31, true);
            WriteLiteral("</td>\r\n                    <td>");
            EndContext();
            BeginContext(622, 13, false);
#line 22 "C:\Desktop\Cloud\BTVBookRental\BTVBookRental\Views\Home\Index.cshtml"
                   Write(item.LastName);

#line default
#line hidden
            EndContext();
            BeginContext(635, 31, true);
            WriteLiteral("</td>\r\n                    <td>");
            EndContext();
            BeginContext(667, 13, false);
#line 23 "C:\Desktop\Cloud\BTVBookRental\BTVBookRental\Views\Home\Index.cshtml"
                   Write(item.Username);

#line default
#line hidden
            EndContext();
            BeginContext(680, 31, true);
            WriteLiteral("</td>\r\n                    <td>");
            EndContext();
            BeginContext(712, 10, false);
#line 24 "C:\Desktop\Cloud\BTVBookRental\BTVBookRental\Views\Home\Index.cshtml"
                   Write(item.Email);

#line default
#line hidden
            EndContext();
            BeginContext(722, 30, true);
            WriteLiteral("</td>\r\n                </tr>\r\n");
            EndContext();
#line 26 "C:\Desktop\Cloud\BTVBookRental\BTVBookRental\Views\Home\Index.cshtml"
                }

#line default
#line hidden
            BeginContext(771, 22, true);
            WriteLiteral("            </table>\r\n");
            EndContext();
#line 28 "C:\Desktop\Cloud\BTVBookRental\BTVBookRental\Views\Home\Index.cshtml"
        }
        else
        {

#line default
#line hidden
            BeginContext(829, 61, true);
            WriteLiteral("            <p>Nu avem nici un utilizator intregistrat.</p>\r\n");
            EndContext();
#line 32 "C:\Desktop\Cloud\BTVBookRental\BTVBookRental\Views\Home\Index.cshtml"
        }

#line default
#line hidden
            BeginContext(901, 18, true);
            WriteLiteral("    </div>\r\n</div>");
            EndContext();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<BTVBookRental.Models.UserAccount>> Html { get; private set; }
    }
}
#pragma warning restore 1591
