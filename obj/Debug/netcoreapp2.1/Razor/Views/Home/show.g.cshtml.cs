#pragma checksum "/Users/yamin/Desktop/Codingdojo/c#/ASP.NET/WeddingPlanner/Views/Home/show.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "754bf667d69c1b91497eac8e8b1c18744e200924"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_show), @"mvc.1.0.view", @"/Views/Home/show.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/show.cshtml", typeof(AspNetCore.Views_Home_show))]
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
#line 1 "/Users/yamin/Desktop/Codingdojo/c#/ASP.NET/WeddingPlanner/Views/_ViewImports.cshtml"
using WeddingPlanner;

#line default
#line hidden
#line 2 "/Users/yamin/Desktop/Codingdojo/c#/ASP.NET/WeddingPlanner/Views/_ViewImports.cshtml"
using WeddingPlanner.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"754bf667d69c1b91497eac8e8b1c18744e200924", @"/Views/Home/show.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9e9e38482b8beecdb199b7be73dfa5c3d6a2f574", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_show : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Wedding>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(15, 73, true);
            WriteLiteral("<h3><a href=\"/dashboard\">Dashboard|<a href=\"log_out\">Logout</a></h3>\n<h2>");
            EndContext();
            BeginContext(89, 15, false);
#line 3 "/Users/yamin/Desktop/Codingdojo/c#/ASP.NET/WeddingPlanner/Views/Home/show.cshtml"
Write(Model.WedderOne);

#line default
#line hidden
            EndContext();
            BeginContext(104, 5, true);
            WriteLiteral(" and ");
            EndContext();
            BeginContext(110, 15, false);
#line 3 "/Users/yamin/Desktop/Codingdojo/c#/ASP.NET/WeddingPlanner/Views/Home/show.cshtml"
                    Write(Model.WedderTwo);

#line default
#line hidden
            EndContext();
            BeginContext(125, 10, true);
            WriteLiteral("</h2>\n<h4>");
            EndContext();
            BeginContext(136, 32, false);
#line 4 "/Users/yamin/Desktop/Codingdojo/c#/ASP.NET/WeddingPlanner/Views/Home/show.cshtml"
Write(Model.Date.ToString("MMM d,yyy"));

#line default
#line hidden
            EndContext();
            BeginContext(168, 22, true);
            WriteLiteral("</h4>\n<h5>Guest:</h5>\n");
            EndContext();
#line 6 "/Users/yamin/Desktop/Codingdojo/c#/ASP.NET/WeddingPlanner/Views/Home/show.cshtml"
 foreach(var i in ViewBag.Allguest.Users)
{

#line default
#line hidden
            BeginContext(234, 5, true);
            WriteLiteral("  <p>");
            EndContext();
            BeginContext(240, 17, false);
#line 8 "/Users/yamin/Desktop/Codingdojo/c#/ASP.NET/WeddingPlanner/Views/Home/show.cshtml"
Write(i.Auser.FirstName);

#line default
#line hidden
            EndContext();
            BeginContext(257, 1, true);
            WriteLiteral(" ");
            EndContext();
            BeginContext(259, 16, false);
#line 8 "/Users/yamin/Desktop/Codingdojo/c#/ASP.NET/WeddingPlanner/Views/Home/show.cshtml"
                   Write(i.Auser.LastName);

#line default
#line hidden
            EndContext();
            BeginContext(275, 5, true);
            WriteLiteral("</p>\n");
            EndContext();
#line 9 "/Users/yamin/Desktop/Codingdojo/c#/ASP.NET/WeddingPlanner/Views/Home/show.cshtml"
}

#line default
#line hidden
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Wedding> Html { get; private set; }
    }
}
#pragma warning restore 1591
