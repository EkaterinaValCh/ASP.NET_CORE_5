#pragma checksum "D:\playground\C#\ASP.NET_CORE_5\Newsfeed\Newsfeed\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "493b65d8154fca0c3037c11a68c0d44222da9044"
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
#line 1 "D:\playground\C#\ASP.NET_CORE_5\Newsfeed\Newsfeed\Views\_ViewImports.cshtml"
using Newsfeed;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\playground\C#\ASP.NET_CORE_5\Newsfeed\Newsfeed\Views\_ViewImports.cshtml"
using Newsfeed.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"493b65d8154fca0c3037c11a68c0d44222da9044", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"094adbb42f95de89d5d566b9e35e5adfb8843143", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Newsfeed.Models.Home>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "D:\playground\C#\ASP.NET_CORE_5\Newsfeed\Newsfeed\Views\Home\Index.cshtml"
  ViewData["Title"] = "Home Page";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"text-center\">\r\n    <h1 class=\"display-4\">Welcome</h1>\r\n    <p>Learn about <a href=\"https://docs.microsoft.com/aspnet/core\">building Web apps with ASP.NET Core</a>.</p>\r\n</div>\r\n\r\n<div class=\"container p-3\">\r\n    <br />\r\n");
#nullable restore
#line 11 "D:\playground\C#\ASP.NET_CORE_5\Newsfeed\Newsfeed\Views\Home\Index.cshtml"
     if (Model.Count() > 0)
    {
        

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "D:\playground\C#\ASP.NET_CORE_5\Newsfeed\Newsfeed\Views\Home\Index.cshtml"
         foreach (var news in Model)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <div width=\"100%\">\r\n                <div>\r\n                    <h3 class=\"text-primary\">");
#nullable restore
#line 17 "D:\playground\C#\ASP.NET_CORE_5\Newsfeed\Newsfeed\Views\Home\Index.cshtml"
                                        Write(news.Topic);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n                    <p>");
#nullable restore
#line 18 "D:\playground\C#\ASP.NET_CORE_5\Newsfeed\Newsfeed\Views\Home\Index.cshtml"
                  Write(news.DateTimeCreated);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                </div>\r\n                <div>");
#nullable restore
#line 20 "D:\playground\C#\ASP.NET_CORE_5\Newsfeed\Newsfeed\Views\Home\Index.cshtml"
                Write(news.Content);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n            </div>\r\n");
#nullable restore
#line 22 "D:\playground\C#\ASP.NET_CORE_5\Newsfeed\Newsfeed\Views\Home\Index.cshtml"
        }

#line default
#line hidden
#nullable disable
#nullable restore
#line 22 "D:\playground\C#\ASP.NET_CORE_5\Newsfeed\Newsfeed\Views\Home\Index.cshtml"
         
    }
    else
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <p>No news created yet</p>\r\n");
#nullable restore
#line 27 "D:\playground\C#\ASP.NET_CORE_5\Newsfeed\Newsfeed\Views\Home\Index.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Newsfeed.Models.Home>> Html { get; private set; }
    }
}
#pragma warning restore 1591
