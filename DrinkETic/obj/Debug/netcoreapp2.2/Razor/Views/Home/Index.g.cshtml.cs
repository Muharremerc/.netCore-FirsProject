#pragma checksum "C:\Users\Muharrem Erc\Desktop\Drink\DrinkETic\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "70efb10f8ac66f2e115efa891168da79a973d679"
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
#line 1 "C:\Users\Muharrem Erc\Desktop\Drink\DrinkETic\Views\_ViewImports.cshtml"
using DrinkETic.Data.Models;

#line default
#line hidden
#line 2 "C:\Users\Muharrem Erc\Desktop\Drink\DrinkETic\Views\_ViewImports.cshtml"
using DrinkETic.ViewModels;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"70efb10f8ac66f2e115efa891168da79a973d679", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"30d9e8739772a60a9c31d145b01f7b071fbc9212", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<HomeViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(23, 35, false);
#line 2 "C:\Users\Muharrem Erc\Desktop\Drink\DrinkETic\Views\Home\Index.cshtml"
Write(await Html.PartialAsync("Carousel"));

#line default
#line hidden
            EndContext();
            BeginContext(58, 23, true);
            WriteLiteral("\r\n\r\n<div class=\"row\">\r\n");
            EndContext();
#line 5 "C:\Users\Muharrem Erc\Desktop\Drink\DrinkETic\Views\Home\Index.cshtml"
   foreach (var item in Model.PreferredDrinks)
  {
      

#line default
#line hidden
            BeginContext(141, 33, false);
#line 7 "C:\Users\Muharrem Erc\Desktop\Drink\DrinkETic\Views\Home\Index.cshtml"
 Write(Html.Partial("DrinkSummary",item));

#line default
#line hidden
            EndContext();
#line 7 "C:\Users\Muharrem Erc\Desktop\Drink\DrinkETic\Views\Home\Index.cshtml"
                                        
  }

#line default
#line hidden
            BeginContext(181, 6, true);
            WriteLiteral("</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<HomeViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
