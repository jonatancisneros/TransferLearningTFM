#pragma checksum "C:\Users\Administrator\Source\Repos\TransferLearningTFM\AzureBlobLearning\Views\Shared\Error.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f5a5ed1ffe592af1143ca61b9b048cc484ef4124"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Error), @"mvc.1.0.view", @"/Views/Shared/Error.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Shared/Error.cshtml", typeof(AspNetCore.Views_Shared_Error))]
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
#line 1 "C:\Users\Administrator\Source\Repos\TransferLearningTFM\AzureBlobLearning\Views\_ViewImports.cshtml"
using AzureBlobLearning;

#line default
#line hidden
#line 2 "C:\Users\Administrator\Source\Repos\TransferLearningTFM\AzureBlobLearning\Views\_ViewImports.cshtml"
using AzureBlobLearning.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f5a5ed1ffe592af1143ca61b9b048cc484ef4124", @"/Views/Shared/Error.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a0c8fdd8207b59c4af9e65ff4f2ff4c656e8300d", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_Error : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 2 "C:\Users\Administrator\Source\Repos\TransferLearningTFM\AzureBlobLearning\Views\Shared\Error.cshtml"
  
	ViewBag.Title = "Error";
	Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
            BeginContext(80, 55, true);
            WriteLiteral("\r\n<h3>An error occurred while processing your request: ");
            EndContext();
            BeginContext(136, 19, false);
#line 7 "C:\Users\Administrator\Source\Repos\TransferLearningTFM\AzureBlobLearning\Views\Shared\Error.cshtml"
                                                Write(ViewData["message"]);

#line default
#line hidden
            EndContext();
            BeginContext(155, 50, true);
            WriteLiteral("</h3><br />\r\n<strong>Stack Trace</strong> <br />\r\n");
            EndContext();
            BeginContext(206, 17, false);
#line 9 "C:\Users\Administrator\Source\Repos\TransferLearningTFM\AzureBlobLearning\Views\Shared\Error.cshtml"
Write(ViewData["trace"]);

#line default
#line hidden
            EndContext();
            BeginContext(223, 4, true);
            WriteLiteral("\r\n\r\n");
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
