#pragma checksum "C:\Users\Administrator\Source\Repos\AzureBlobLearning\AzureBlobLearning\AzureBlobLearning\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "fbdc55bc2db755b670425b96df527705ae8ecbf0"
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
#line 1 "C:\Users\Administrator\Source\Repos\AzureBlobLearning\AzureBlobLearning\AzureBlobLearning\Views\_ViewImports.cshtml"
using AzureBlobLearning;

#line default
#line hidden
#line 2 "C:\Users\Administrator\Source\Repos\AzureBlobLearning\AzureBlobLearning\AzureBlobLearning\Views\_ViewImports.cshtml"
using AzureBlobLearning.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fbdc55bc2db755b670425b96df527705ae8ecbf0", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a0c8fdd8207b59c4af9e65ff4f2ff4c656e8300d", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("deleteIcon"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/Images/deleteImage.png"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("title", new global::Microsoft.AspNetCore.Html.HtmlString("Delete Image"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(809, 4, true);
            WriteLiteral("\r\n\r\n");
            EndContext();
#line 16 "C:\Users\Administrator\Source\Repos\AzureBlobLearning\AzureBlobLearning\AzureBlobLearning\Views\Home\Index.cshtml"
  
	ViewBag.Title = "Index";

#line default
#line hidden
            BeginContext(867, 368, true);
            WriteLiteral(@"<div class=""jumbotron"">
	<h2>Azure Blob Storage Photo Gallery</h2>
	<h5>Azure Blob storage is a service for storing large amounts of unstructured data, such as text or binary data, that can be accessed from anywhere in the world via HTTP or HTTPS. You can use Blob storage to expose data publicly to the world, or to store application data privately.</h5>
	<span>
");
            EndContext();
            BeginContext(1278, 171, true);
            WriteLiteral("\t\t<a class=\"btn btn-default\" href=\"http://azure.microsoft.com/en-us/documentation/articles/storage-whatis-account/\" target=\"_blank\">What is a Storage Account &raquo;</a>\r\n");
            EndContext();
            BeginContext(1493, 202, true);
            WriteLiteral("\t\t<a class=\"btn btn-default\" href=\"https://azure.microsoft.com/en-us/documentation/articles/storage-dotnet-how-to-use-blobs/\" target=\"_blank\">Getting Started with Blobs &raquo;</a>\r\n\t</span>\r\n</div>\r\n\r\n");
            EndContext();
#line 34 "C:\Users\Administrator\Source\Repos\AzureBlobLearning\AzureBlobLearning\AzureBlobLearning\Views\Home\Index.cshtml"
 using (Html.BeginForm("UploadAsync", "Home", FormMethod.Post, new { enctype = "multipart/form-data" }))
{

#line default
#line hidden
            BeginContext(2172, 189, true);
            WriteLiteral("\t<div class=\"fileUpload btn btn-primary\">\r\n\t\t<span>Select Files</span><input type=\"file\" id=\"file\" name=\"selectFiles\" class=\"upload\" onchange=\"DisplayFilesToUpload()\" multiple />\r\n\t</div>\r\n");
            EndContext();
            BeginContext(2432, 29, true);
            WriteLiteral("\t<p id=\"FilesToUpload\"></p>\r\n");
            EndContext();
#line 41 "C:\Users\Administrator\Source\Repos\AzureBlobLearning\AzureBlobLearning\AzureBlobLearning\Views\Home\Index.cshtml"
}

#line default
#line hidden
            BeginContext(2464, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 47 "C:\Users\Administrator\Source\Repos\AzureBlobLearning\AzureBlobLearning\AzureBlobLearning\Views\Home\Index.cshtml"
 if (Model != null && Model.Count > 0)
{
	foreach (var item in Model)
	{

#line default
#line hidden
            BeginContext(2859, 33, true);
            WriteLiteral("\t\t<div class=\"imageBlock\">\r\n\t\t\t<a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 2892, "\"", 2904, 1);
#line 52 "C:\Users\Administrator\Source\Repos\AzureBlobLearning\AzureBlobLearning\AzureBlobLearning\Views\Home\Index.cshtml"
WriteAttributeValue("", 2899, item, 2899, 5, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(2905, 35, true);
            WriteLiteral(" target=\"_blank\"><img class=\"thumb\"");
            EndContext();
            BeginWriteAttribute("src", " src=\"", 2940, "\"", 2951, 1);
#line 52 "C:\Users\Administrator\Source\Repos\AzureBlobLearning\AzureBlobLearning\AzureBlobLearning\Views\Home\Index.cshtml"
WriteAttributeValue("", 2946, item, 2946, 5, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(2952, 54, true);
            WriteLiteral(" alt=\"images\" /></a><br />\r\n\t\t\t<div class=\"deleteDiv\">");
            EndContext();
            BeginContext(3006, 110, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "fbdc55bc2db755b670425b96df527705ae8ecbf07947", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "onclick", 3, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 3091, "deleteImage(\'", 3091, 13, true);
#line 53 "C:\Users\Administrator\Source\Repos\AzureBlobLearning\AzureBlobLearning\AzureBlobLearning\Views\Home\Index.cshtml"
AddHtmlAttributeValue("", 3104, item, 3104, 5, false);

#line default
#line hidden
            AddHtmlAttributeValue("", 3109, "\');", 3109, 3, true);
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(3116, 18, true);
            WriteLiteral("</div>\r\n\t\t</div>\r\n");
            EndContext();
#line 55 "C:\Users\Administrator\Source\Repos\AzureBlobLearning\AzureBlobLearning\AzureBlobLearning\Views\Home\Index.cshtml"
	}

	using (Html.BeginForm("DeleteAll", "Home", FormMethod.Post, new { enctype = "multipart/form-data" }))
	{

#line default
#line hidden
            BeginContext(3248, 133, true);
            WriteLiteral("\t\t<div class=\"fileUpload btn btn-danger\"><span>Delete All Files</span><input type=\"submit\" name=\"deleteAll\" class=\"upload\" /></div>\r\n");
            EndContext();
#line 60 "C:\Users\Administrator\Source\Repos\AzureBlobLearning\AzureBlobLearning\AzureBlobLearning\Views\Home\Index.cshtml"
	}
}

#line default
#line hidden
            BeginContext(3388, 1145, true);
            WriteLiteral(@"<script>
    //Calls async Task<ActionResult> DeleteImage(string name) in the HomeController and Refreshes the page
    function deleteImage(item) {
        var url = ""/Home/DeleteImage"";
        $.post(url, { FileUri: item }, function (data) {
            window.location.href = ""/Home/Index"";
        });
    }

    //Lists the file name and size for all files to be uploaded by updating the <p id=""FilesToUpload""></p> control
    function DisplayFilesToUpload() {
        var element = document.getElementById(""file"");
        var html = """";

        html = ""<h3>Image(s) to Upload</h3>""
        for (var i = 0; i < element.files.length; i++) {
            html += ""<strong>"" + (i + 1) + ""</strong>. File: "";
            var file = element.files[i];
            if ('name' in file) {html += file.name + "" ("";}
            if ('size' in file) {html += ""size: "" + file.size + "" bytes)<br>"";}
        }

		html += ""<div class='fileUpload btn btn-primary'><span>Upload</span><input type='submit' class='");
            WriteLiteral("upload\' value=\'Upload\'/></div>\"\r\n        document.getElementById(\"FilesToUpload\").innerHTML = html;\r\n    }\r\n\r\n</script>\r\n");
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
