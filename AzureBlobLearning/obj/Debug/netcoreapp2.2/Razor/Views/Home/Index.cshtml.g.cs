#pragma checksum "/Users/jonatancisnerosrodriguez/Desktop/Varios2019/Transferlearning/AzureBlobLearning/Views/Home/Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3aef724492a7a4c6eead95cda7215e67789b7211"
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
#line 1 "/Users/jonatancisnerosrodriguez/Desktop/Varios2019/Transferlearning/AzureBlobLearning/Views/_ViewImports.cshtml"
using AzureBlobLearning;

#line default
#line hidden
#line 2 "/Users/jonatancisnerosrodriguez/Desktop/Varios2019/Transferlearning/AzureBlobLearning/Views/_ViewImports.cshtml"
using AzureBlobLearning.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3aef724492a7a4c6eead95cda7215e67789b7211", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a13b200a163ac0ca1952646bcc40713e024e31a6", @"/Views/_ViewImports.cshtml")]
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
#line 2 "/Users/jonatancisnerosrodriguez/Desktop/Varios2019/Transferlearning/AzureBlobLearning/Views/Home/Index.cshtml"
  
    ViewBag.Title = "Labeling Tool";

#line default
#line hidden
            BeginContext(67, 1181, true);
            WriteLiteral(@"

<script>//Calls async Task<ActionResult> DeleteImage(string name) in the HomeController and Refreshes the page
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

        html += ""<div class='fileUpload btn btn-primary'><span>Upload</span><input type='submit'");
            WriteLiteral(" class=\'upload\' value=\'Upload\'/></div>\"\r\n        document.getElementById(\"FilesToUpload\").innerHTML = html;\r\n    }</script>\r\n\r\n\r\n\r\n\r\n<!-- Webcam.min.js -->\r\n");
            EndContext();
            BeginContext(1248, 65, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3aef724492a7a4c6eead95cda7215e67789b72116921", async() => {
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
            BeginContext(1313, 72, true);
            WriteLiteral("\r\n<script src=\"https://code.jquery.com/jquery-1.12.4.min.js\"></script>\r\n");
            EndContext();
            BeginContext(1385, 68, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3aef724492a7a4c6eead95cda7215e67789b72118239", async() => {
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
            BeginContext(1453, 1521, true);
            WriteLiteral(@"





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
<div class=""row"">
    <div class=""col-sm-12 col-sm-12 alert alert-success alert-dismissible fade show"">
        <br />
        <p>Instructions:</p>
        <p>1) Click on record.</p>
        <p>2) Let your webcam Capture Images while you make signs like start, stop and the numbers.</p>
        <p>3) Select a label and click on upload.</p>
        <br />
         These images will be used for training an ML model that will let you give instructions to your smart home devices without voice.
        <br />
        Provide feedback to jonatane.cisneros@gmail.com
        <br />

    </div>

</div>
<div class=""row"">

<div class=""col-sm-12 alert alert-info alert-dismissible fade show"" role=""alert"">
    <h3 id=""MessageBox""> Ready to record..</h3>
</div>
</div>
<div class=""row"">
    <div class=""col-sm-4"">
        <div id=");
            WriteLiteral(@"""my_camera""></div>
        <br />

    </div>

    <div id=""results"" class=""col-sm-4"" style=""height:240px; overflow:auto""></div>
  
</div>

<div class=""row"">

      <div class=""col-sm-9"">
        <button class=""btn btn-primary"" id=""class-start"">Start Recording</button>
        <button class=""btn btn-danger"" id=""class-stop"">Stop Recording</button>

        <input class=""btn btn-info"" type=button value=""Take Snapshot"" onClick=""take_snapshot()"">
    </div>

</div>

<br />

");
            EndContext();
#line 105 "/Users/jonatancisnerosrodriguez/Desktop/Varios2019/Transferlearning/AzureBlobLearning/Views/Home/Index.cshtml"
 using (Html.BeginForm("UploadAsync", "Home", FormMethod.Post, new { enctype = "multipart/form-data" }))
{

    

#line default
#line hidden
            BeginContext(3766, 32, true);
            WriteLiteral("    <p id=\"FilesToUpload\"></p>\r\n");
            EndContext();
#line 117 "/Users/jonatancisnerosrodriguez/Desktop/Varios2019/Transferlearning/AzureBlobLearning/Views/Home/Index.cshtml"
}

#line default
#line hidden
            BeginContext(3801, 328, true);
            WriteLiteral(@"



<div class=""row"">
    <div class=""col-sm-12 col-sm-12 alert alert-light alert-dismissible fade show"">
        <br />
     The following images have been captured for training and can be used as example for instructions.
        <br />

    </div>



    <div class=""row"" style="" height:300px; overflow:auto"">
");
            EndContext();
#line 133 "/Users/jonatancisnerosrodriguez/Desktop/Varios2019/Transferlearning/AzureBlobLearning/Views/Home/Index.cshtml"
         if (Model != null && Model.Count > 0)
        {
            foreach (var item in Model)
            {



#line default
#line hidden
            BeginContext(4248, 64, true);
            WriteLiteral("                <div class=\"imageBlock\">\r\n                    <a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 4312, "\"", 4324, 1);
#line 140 "/Users/jonatancisnerosrodriguez/Desktop/Varios2019/Transferlearning/AzureBlobLearning/Views/Home/Index.cshtml"
WriteAttributeValue("", 4319, item, 4319, 5, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(4325, 35, true);
            WriteLiteral(" target=\"_blank\"><img class=\"thumb\"");
            EndContext();
            BeginWriteAttribute("src", " src=\"", 4360, "\"", 4371, 1);
#line 140 "/Users/jonatancisnerosrodriguez/Desktop/Varios2019/Transferlearning/AzureBlobLearning/Views/Home/Index.cshtml"
WriteAttributeValue("", 4366, item, 4366, 5, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(4372, 17, true);
            WriteLiteral(" alt=\"images\" /> ");
            EndContext();
            BeginContext(4390, 4, false);
#line 140 "/Users/jonatancisnerosrodriguez/Desktop/Varios2019/Transferlearning/AzureBlobLearning/Views/Home/Index.cshtml"
                                                                                              Write(item);

#line default
#line hidden
            EndContext();
            BeginContext(4394, 55, true);
            WriteLiteral("</a><br />\r\n                    <div class=\"deleteDiv\">");
            EndContext();
            BeginContext(4449, 110, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "3aef724492a7a4c6eead95cda7215e67789b721113855", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "onclick", 3, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 4534, "deleteImage(\'", 4534, 13, true);
#line 141 "/Users/jonatancisnerosrodriguez/Desktop/Varios2019/Transferlearning/AzureBlobLearning/Views/Home/Index.cshtml"
AddHtmlAttributeValue("", 4547, item, 4547, 5, false);

#line default
#line hidden
            AddHtmlAttributeValue("", 4552, "\');", 4552, 3, true);
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(4559, 32, true);
            WriteLiteral("</div>\r\n                </div>\r\n");
            EndContext();
#line 143 "/Users/jonatancisnerosrodriguez/Desktop/Varios2019/Transferlearning/AzureBlobLearning/Views/Home/Index.cshtml"
            }

            using (Html.BeginForm("DeleteAll", "Home", FormMethod.Post, new { enctype = "multipart/form-data" }))
            {
                

#line default
#line hidden
#line 147 "/Users/jonatancisnerosrodriguez/Desktop/Varios2019/Transferlearning/AzureBlobLearning/Views/Home/Index.cshtml"
                                                                                                                                                     
            }
        }

#line default
#line hidden
            BeginContext(4915, 14, true);
            WriteLiteral("\r\n    </div>\r\n");
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
