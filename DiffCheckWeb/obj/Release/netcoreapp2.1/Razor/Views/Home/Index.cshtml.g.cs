#pragma checksum "E:\DiffCheckWeb\DiffCheckWeb\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "385f0b381b65e0d3bab45aaa005c1e954351202c"
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
#line 1 "E:\DiffCheckWeb\DiffCheckWeb\Views\_ViewImports.cshtml"
using DiffCheckWeb;

#line default
#line hidden
#line 2 "E:\DiffCheckWeb\DiffCheckWeb\Views\_ViewImports.cshtml"
using DiffCheckWeb.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"385f0b381b65e0d3bab45aaa005c1e954351202c", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c532954a859fa5f1f94ebaaace856df60a64357c", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/diff_match_patch_uncompressed.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("#"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("onsubmit", new global::Microsoft.AspNetCore.Html.HtmlString("return false"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 112, true);
            WriteLiteral("<!DOCTYPE HTML PUBLIC \"-//W3C//DTD HTML 4.01 Transitional//EN\" \"http://www.w3.org/TR/html4/loose.dtd\">\r\n<HTML>\r\n");
            EndContext();
            BeginContext(112, 71, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("HEAD", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f973c630c60542d89a1c4a9ac8df6f7e", async() => {
                BeginContext(118, 58, true);
                WriteLiteral("\r\n    <TITLE>Diff, Match and Patch: Demo of Diff</TITLE>\r\n");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(183, 4, true);
            WriteLiteral("\r\n\r\n");
            EndContext();
            BeginContext(187, 5963, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("BODY", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f3175afbb6ee472d90bf6f9c64f5bb26", async() => {
                BeginContext(193, 494, true);
                WriteLiteral(@"
    <H1>Diff, Match and Patch</H1>
    <H2>Demo of Diff</H2>

    <P>
        Diff takes two texts and finds the differences.  This implementation works on a character by character basis.
        The result of any diff may contain 'chaff', irrelevant small commonalities which complicate the output.
        A post-diff cleanup algorithm factors out these trivial commonalities.
    </P>
    <script src=""https://ajax.googleapis.com/ajax/libs/jquery/3.4.1/jquery.js""></script>

    ");
                EndContext();
                BeginContext(687, 61, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "366bc5160add4a5987711f704f194757", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(748, 4456, true);
                WriteLiteral(@"

    <SCRIPT>










        var addition = 0;
        var _delete = 0;

        diff_prettyHtml = function (diffs) {
            var html = [];
            var pattern_amp = /&/g;
            var pattern_lt = /</g;
            var pattern_gt = />/g;
            var pattern_para = /\n/g;
            for (var x = 0; x < diffs.length; x++) {
                debugger;
                var op = diffs[x]['operation'];    // Operation (insert, delete, equal)
                var data = diffs[x]['text'];  // Text of change.
                var text = data.replace(pattern_amp, '&amp;').replace(pattern_lt, '&lt;')
                    .replace(pattern_gt, '&gt;').replace(pattern_para, '&para;<br>');
                switch (op) {
                    //case DIFF_INSERT:
                    //  html[x] = '<ins style=""background:#e6ffe6;"">' + text + '</ins>';
                    //  break;
                    case DIFF_DELETE:
                        html[x] = '<del style=""background:red;");
                WriteLiteral(@""">' + text + '</del>';
                        _delete += 1
                        break;
                    case DIFF_EQUAL:
                        html[x] = '<span>' + text + '</span>';
                        break;
                }
            }
            return html.join('');
        };




        diff_prettyHtml1 = function (diffs) {
            var html = [];
            var pattern_amp = /&/g;
            var pattern_lt = /</g;
            var pattern_gt = />/g;
            var pattern_para = /\n/g;
            for (var x = 0; x < diffs.length; x++) {
                debugger;
                var op = diffs[x]['operation'];    // Operation (insert, delete, equal)
                var data = diffs[x]['text'];  // Text of change.
                var text = data.replace(pattern_amp, '&amp;').replace(pattern_lt, '&lt;')
                    .replace(pattern_gt, '&gt;').replace(pattern_para, '&para;<br>');
                switch (op) {
                    case DIFF_INSERT:
");
                WriteLiteral(@"                        html[x] = '<ins style=""background:green;"">' + text + '</ins>';
                        addition += 1;
                        break;
                    //case DIFF_DELETE:
                    //    html[x] = '<del style=""background:#ffe6e6;"">' + text + '</del>';
                    //    break;
                    case DIFF_EQUAL:
                        html[x] = '<span>' + text + '</span>';
                        break;
                }
            }
            return html.join('');
        };




        function escapeXML(string){

    var str = string;
    str = str.replace(/\&/g,""&amp;"");
    str = str.replace(/\>/g,""&gt;"");
    str = str.replace(/\</g,""&lt;"");
    str = str.replace(/\""/g,""&quot;"");
    str = str.replace(/\'/g,""&apos;"");

    return str;
}




        function launch() {
            var text1 = document.getElementById('text1').value;
            var text2 = document.getElementById('text2').value;

            var processTex");
                WriteLiteral(@"t1 = escapeXML(text1);
            var processText2 = escapeXML(text2);
            var textdata = '<JobModel xmlns:xsi=""http://www.w3.org/2001/XMLSchema-instance"" xmlns:xsd=""http://www.w3.org/2001/XMLSchema""><JobClass><Job><title>' + processText1 + '</title><description></description></Job><Job><title>' + processText2 + '</title><description></description></Job></JobClass></JobModel>';
            debugger;
            $.ajax({
                url: ""../../Home/ComputeDiff"",
                type: ""POST"",
                processData: false,
                data: textdata,
                contentType: ""text/xml"",
                success: function (response, textStatus, jqXHR) {
                    debugger;
                    var obj = JSON.parse(response);
                    var d = obj;
                    var ds = diff_prettyHtml(d);
                    var newText = diff_prettyHtml1(d);

                    document.getElementById('outputdiv').innerHTML = ds
                    document.");
                WriteLiteral(@"getElementById('newdiv').innerHTML = newText
                    document.getElementById('addition').innerHTML = addition
                    document.getElementById('delete').innerHTML = _delete

                },
                error: function (jqXHR, textStatus, errorThrown) {

                }
            });
        };
    </SCRIPT>

    ");
                EndContext();
                BeginContext(5204, 563, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("FORM", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e168f46f19c94a48bcf5d845710f1a59", async() => {
                    BeginContext(5245, 515, true);
                    WriteLiteral(@"
        <TABLE WIDTH=""100%"">
            <TR>
                <TD WIDTH=""50%"">
                    <H3>Text Version 1:</H3>
<TEXTAREA ID=""text1"" STYLE=""width: 100%"" rows=""10""></TEXTAREA>
                </TD>
                <TD WIDTH=""50%"">
                    <H3>Text Version 2:</H3>
<TEXTAREA ID=""text2"" STYLE=""width: 100%"" rows=""10""></TEXTAREA>
                </TD>
            </TR>
        </TABLE>






        <P><INPUT TYPE=""button"" onClick=""launch()"" VALUE=""Compute Diff""></P>
    ");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(5767, 376, true);
                WriteLiteral(@"

    <div class=""row"">

        <div class=""col-md-6""><span id=""delete""></span>Deletions</div>
        <div class=""col-md-6"">
            <span id=""addition""></span> Additions
        </div>


    </div>


    <div class=""row"">
        <DIV ID=""outputdiv"" class=""col-md-6""></DIV>

        <DIV ID=""newdiv"" class=""col-md-6""></DIV>
    </div>

    <HR>


");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(6150, 11, true);
            WriteLiteral("\r\n</HTML>\r\n");
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
