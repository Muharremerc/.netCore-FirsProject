#pragma checksum "C:\Users\Muharrem Erc\Desktop\Drink\DrinkETic\Views\Order\CheckoutComplate.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0ef3b0e503347ad70edb7b266bc26ce94c978bf5"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Order_CheckoutComplate), @"mvc.1.0.view", @"/Views/Order/CheckoutComplate.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Order/CheckoutComplate.cshtml", typeof(AspNetCore.Views_Order_CheckoutComplate))]
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
#line 1 "C:\Users\Muharrem Erc\Desktop\Drink\DrinkETic\Views\_ViewImports.cshtml"
using DrinkETic.Data.Models;

#line default
#line hidden
#line 2 "C:\Users\Muharrem Erc\Desktop\Drink\DrinkETic\Views\_ViewImports.cshtml"
using DrinkETic.ViewModels;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0ef3b0e503347ad70edb7b266bc26ce94c978bf5", @"/Views/Order/CheckoutComplate.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"30d9e8739772a60a9c31d145b01f7b071fbc9212", @"/Views/_ViewImports.cshtml")]
    public class Views_Order_CheckoutComplate : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 2 "C:\Users\Muharrem Erc\Desktop\Drink\DrinkETic\Views\Order\CheckoutComplate.cshtml"
  
    Layout = null;

#line default
#line hidden
            BeginContext(29, 4, true);
            WriteLiteral("<h1>");
            EndContext();
            BeginContext(34, 31, false);
#line 5 "C:\Users\Muharrem Erc\Desktop\Drink\DrinkETic\Views\Order\CheckoutComplate.cshtml"
Write(ViewBag.CheckoutComplateMessage);

#line default
#line hidden
            EndContext();
            BeginContext(65, 7, true);
            WriteLiteral("</h1>\r\n");
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
