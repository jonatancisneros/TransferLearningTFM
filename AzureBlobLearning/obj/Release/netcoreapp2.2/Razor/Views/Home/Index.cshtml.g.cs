#pragma checksum "C:\Users\Administrator\Source\Repos\TransferLearningTFM\AzureBlobLearning\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8370bf446ccd8d1e9d6473f64e3ec5f836b94491"
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
#line 1 "C:\Users\Administrator\Source\Repos\TransferLearningTFM\AzureBlobLearning\Views\_ViewImports.cshtml"
using AzureBlobLearning;

#line default
#line hidden
#line 2 "C:\Users\Administrator\Source\Repos\TransferLearningTFM\AzureBlobLearning\Views\_ViewImports.cshtml"
using AzureBlobLearning.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8370bf446ccd8d1e9d6473f64e3ec5f836b94491", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a0c8fdd8207b59c4af9e65ff4f2ff4c656e8300d", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", new global::Microsoft.AspNetCore.Html.HtmlString("text/javascript"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/webcam.min.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/cameracapture.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("deleteIcon"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/Images/deleteImage.png"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("title", new global::Microsoft.AspNetCore.Html.HtmlString("Delete Image"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            BeginContext(0, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 2 "C:\Users\Administrator\Source\Repos\TransferLearningTFM\AzureBlobLearning\Views\Home\Index.cshtml"
  
    ViewBag.Title = "Index";

#line default
#line hidden
            BeginContext(59, 26, true);
            WriteLiteral("\r\n<!-- Webcam.min.js -->\r\n");
            EndContext();
            BeginContext(85, 65, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8370bf446ccd8d1e9d6473f64e3ec5f836b944915701", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(150, 72, true);
            WriteLiteral("\r\n<script src=\"https://code.jquery.com/jquery-1.12.4.min.js\"></script>\r\n");
            EndContext();
            BeginContext(222, 68, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8370bf446ccd8d1e9d6473f64e3ec5f836b944917036", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(290, 546, true);
            WriteLiteral(@"


<div class=""jumbotron"">
    <h2>KSchool TFM Labelling tool</h2>


</div>


<!-- CSS -->
<style>
    #my_camera {
        width: 320px;
        height: 240px;
        border: 1px solid black;
    }

    .Capture {
    }
</style>

<div class=""m-lg-5"" id=""my_camera""></div>
<br />
<br />
<button class=""btn"" id=""class-start"">Start Recording</button>
<button class=""btn"" id=""class-stop"">Stop Recording</button>

<input   class=""btn"" type=button value=""Take Snapshot"" onClick=""take_snapshot()"">
<br />
<br />




");
            EndContext();
#line 48 "C:\Users\Administrator\Source\Repos\TransferLearningTFM\AzureBlobLearning\Views\Home\Index.cshtml"
 using (Html.BeginForm("UploadAsync", "Home", FormMethod.Post, new { enctype = "multipart/form-data" }))
{

    

#line default
#line hidden
            BeginContext(1628, 32, true);
            WriteLiteral("    <p id=\"FilesToUpload\"></p>\r\n");
            EndContext();
#line 60 "C:\Users\Administrator\Source\Repos\TransferLearningTFM\AzureBlobLearning\Views\Home\Index.cshtml"
}

#line default
#line hidden
            BeginContext(1663, 103, true);
            WriteLiteral("\r\n\r\n<div id=\"results\" style=\"width:100%; height:300px; overflow-x:auto;\"></div>\r\n\r\n<br />\r\n\r\n<br />\r\n\r\n");
            EndContext();
#line 73 "C:\Users\Administrator\Source\Repos\TransferLearningTFM\AzureBlobLearning\Views\Home\Index.cshtml"
 if (Model != null && Model.Count > 0)
{
    foreach (var item in Model)
    {

#line default
#line hidden
            BeginContext(2174, 48, true);
            WriteLiteral("        <div class=\"imageBlock\">\r\n            <a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 2222, "\"", 2234, 1);
#line 78 "C:\Users\Administrator\Source\Repos\TransferLearningTFM\AzureBlobLearning\Views\Home\Index.cshtml"
WriteAttributeValue("", 2229, item, 2229, 5, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(2235, 35, true);
            WriteLiteral(" target=\"_blank\"><img class=\"thumb\"");
            EndContext();
            BeginWriteAttribute("src", " src=\"", 2270, "\"", 2281, 1);
#line 78 "C:\Users\Administrator\Source\Repos\TransferLearningTFM\AzureBlobLearning\Views\Home\Index.cshtml"
WriteAttributeValue("", 2276, item, 2276, 5, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(2282, 63, true);
            WriteLiteral(" alt=\"images\" /></a><br />\r\n            <div class=\"deleteDiv\">");
            EndContext();
            BeginContext(2345, 110, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "8370bf446ccd8d1e9d6473f64e3ec5f836b9449110920", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "onclick", 3, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 2430, "deleteImage(\'", 2430, 13, true);
#line 79 "C:\Users\Administrator\Source\Repos\TransferLearningTFM\AzureBlobLearning\Views\Home\Index.cshtml"
AddHtmlAttributeValue("", 2443, item, 2443, 5, false);

#line default
#line hidden
            AddHtmlAttributeValue("", 2448, "\');", 2448, 3, true);
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2455, 24, true);
            WriteLiteral("</div>\r\n        </div>\r\n");
            EndContext();
#line 81 "C:\Users\Administrator\Source\Repos\TransferLearningTFM\AzureBlobLearning\Views\Home\Index.cshtml"
    }

    using (Html.BeginForm("DeleteAll", "Home", FormMethod.Post, new { enctype = "multipart/form-data" }))
    {

#line default
#line hidden
            BeginContext(2602, 139, true);
            WriteLiteral("        <div class=\"fileUpload btn btn-danger\"><span>Delete All Files</span><input type=\"submit\" name=\"deleteAll\" class=\"upload\" /></div>\r\n");
            EndContext();
#line 86 "C:\Users\Administrator\Source\Repos\TransferLearningTFM\AzureBlobLearning\Views\Home\Index.cshtml"
    }
}

#line default
#line hidden
            BeginContext(2751, 1165, true);
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
            if ('name' in file) { html += file.name + "" (""; }
            if ('size' in file) { html += ""size: "" + file.size + "" bytes)<br>""; }
        }

        html += ""<div class='fileUpload btn btn-primary'><span>Upload</span><input type='submi");
            WriteLiteral("t\' class=\'upload\' value=\'Upload\'/></div>\"\r\n        document.getElementById(\"FilesToUpload\").innerHTML = html;\r\n    }\r\n\r\n</script>\r\n\r\n\r\n\r\n\r\n\r\n");
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
