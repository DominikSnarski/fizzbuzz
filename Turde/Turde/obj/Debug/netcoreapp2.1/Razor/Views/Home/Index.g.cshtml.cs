#pragma checksum "C:\Users\domin\source\repos\Turde\Turde\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b91b9b3462f8ac3b70dfb0361cc32c90a05d1c97"
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
#line 1 "C:\Users\domin\source\repos\Turde\Turde\Views\_ViewImports.cshtml"
using Turde;

#line default
#line hidden
#line 2 "C:\Users\domin\source\repos\Turde\Turde\Views\_ViewImports.cshtml"
using Turde.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b91b9b3462f8ac3b70dfb0361cc32c90a05d1c97", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"23048d660be93d95835d18beb779c7124ba0885f", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "C:\Users\domin\source\repos\Turde\Turde\Views\Home\Index.cshtml"
 using (Html.BeginForm(FormMethod.Post))
{

#line default
#line hidden
            BeginContext(45, 84, true);
            WriteLiteral("    <input type=\"number\" name=\"x\"/>\r\n    <input type=\"submit\" value=\"Odpowiedz\" />\r\n");
            EndContext();
#line 5 "C:\Users\domin\source\repos\Turde\Turde\Views\Home\Index.cshtml"
}

#line default
#line hidden
            BeginContext(132, 10, true);
            WriteLiteral("\r\n    <h2>");
            EndContext();
            BeginContext(143, 14, false);
#line 7 "C:\Users\domin\source\repos\Turde\Turde\Views\Home\Index.cshtml"
   Write(ViewBag.Mydata);

#line default
#line hidden
            EndContext();
            BeginContext(157, 5, true);
            WriteLiteral("</h2>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591