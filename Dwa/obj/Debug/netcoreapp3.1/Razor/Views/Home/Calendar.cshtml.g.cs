#pragma checksum "C:\Users\111\Desktop\Dwa\Dwa\Views\Home\Calendar.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a0c0c68b9b8c29cfb9af185d8b8b106a8975c44e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Calendar), @"mvc.1.0.view", @"/Views/Home/Calendar.cshtml")]
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
#line 1 "C:\Users\111\Desktop\Dwa\Dwa\Views\_ViewImports.cshtml"
using Dwa;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\111\Desktop\Dwa\Dwa\Views\_ViewImports.cshtml"
using Dwa.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a0c0c68b9b8c29cfb9af185d8b8b106a8975c44e", @"/Views/Home/Calendar.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7327186173abd67ef9c92a88a88c80879cacb189", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Calendar : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\111\Desktop\Dwa\Dwa\Views\Home\Calendar.cshtml"
  
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            DefineSection("Calendar", async() => {
                WriteLiteral(@"
    <div id=""calendar-window"" class=""calendar row d-none"">
        <div class=""calendar-window card text-center col-md-9 col-sm-12 align-self-center"">
            <div class=""month card-header d-flex flex-row justify-content-between align-items-center"">
                <i class=""fas fa-angle-left prev""></i>
                <div class=""date"">
                    <h4 class=""card-title""></h4>
                    <p></p>
                </div>
                <i class=""fas fa-angle-right next""></i>
            </div>
            <div class=""week-days"">
                <div class=""border-secondary border"">Пн</div>
                <div class=""border-secondary border"">Вт</div>
                <div class=""border-secondary border"">Ср</div>
                <div class=""border-secondary border"">Чт</div>
                <div class=""border-secondary border"">Пт</div>
                <div class=""border-secondary border"">Сб</div>
                <div class=""border-secondary border"">Вс</div>
            </d");
                WriteLiteral("iv>\r\n            <div class=\"days\">\r\n\r\n            </div>\r\n        </div>\r\n    </div>\r\n    ");
            }
            );
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
