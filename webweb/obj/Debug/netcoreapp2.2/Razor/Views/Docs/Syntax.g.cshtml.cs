#pragma checksum "/home/benjamin/webweb-core/webweb/Views/Docs/Syntax.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "25b8c726fb34a4b9abab46b192b02ff167c7fbc9"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Docs_Syntax), @"mvc.1.0.view", @"/Views/Docs/Syntax.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Docs/Syntax.cshtml", typeof(AspNetCore.Views_Docs_Syntax))]
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
#line 1 "/home/benjamin/webweb-core/webweb/Views/_ViewImports.cshtml"
using webweb;

#line default
#line hidden
#line 2 "/home/benjamin/webweb-core/webweb/Views/_ViewImports.cshtml"
using webweb.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"25b8c726fb34a4b9abab46b192b02ff167c7fbc9", @"/Views/Docs/Syntax.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a39a320ce272370ca152eb63bcde58811c6813e3", @"/Views/_ViewImports.cshtml")]
    public class Views_Docs_Syntax : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "_Navbar", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "/home/benjamin/webweb-core/webweb/Views/Docs/Syntax.cshtml"
  
    Layout = null;

#line default
#line hidden
            BeginContext(24, 29, true);
            WriteLiteral("\n<!DOCTYPE html>\n\n<html>\n    ");
            EndContext();
            BeginContext(53, 858, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "25b8c726fb34a4b9abab46b192b02ff167c7fbc93775", async() => {
                BeginContext(59, 31, true);
                WriteLiteral("\n        <title>Syntax guide | ");
                EndContext();
                BeginContext(91, 20, false);
#line 9 "/home/benjamin/webweb-core/webweb/Views/Docs/Syntax.cshtml"
                         Write(ViewData["SiteName"]);

#line default
#line hidden
                EndContext();
                BeginContext(111, 793, true);
                WriteLiteral(@"</title>
        <script src=""https://cdn.jsdelivr.net/npm/jquery@3.3.1/dist/jquery.min.js""></script>
        <link rel=""stylesheet"" type=""text/css"" href=""https://cdn.jsdelivr.net/npm/fomantic-ui@2.7.6/dist/semantic.min.css"">
        <script src=""https://cdn.jsdelivr.net/npm/fomantic-ui@2.7.6/dist/semantic.min.js""></script>
        <style>
            body {
                margin: 14px;
                /*margin-right: 14px;*/
            }
        </style>
        <script>
            function decodeHtml(html) {
                var txt = document.createElement(""textarea"");
                txt.innerHTML = html;
                return txt.value;
            }
            $( document ).ready(function() {
                $('.dropdown').dropdown();
            });
        </script>
    ");
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
            BeginContext(911, 5, true);
            WriteLiteral("\n    ");
            EndContext();
            BeginContext(916, 4188, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "25b8c726fb34a4b9abab46b192b02ff167c7fbc96109", async() => {
                BeginContext(922, 9, true);
                WriteLiteral("\n        ");
                EndContext();
                BeginContext(931, 26, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("partial", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "25b8c726fb34a4b9abab46b192b02ff167c7fbc96491", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Name = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(957, 138, true);
                WriteLiteral("\n        <div id=\"customContent\">\n            <div class=\"ui header\">\n                Syntax guide\n            </div>\n            <p>With ");
                EndContext();
                BeginContext(1096, 24, false);
#line 36 "/home/benjamin/webweb-core/webweb/Views/Docs/Syntax.cshtml"
               Write(ViewData["SoftwareName"]);

#line default
#line hidden
                EndContext();
                BeginContext(1120, 2167, true);
                WriteLiteral(@", you can edit the HTML of a page to gain full control of its contents. However, HTML syntax can be cumbersome, so webweb lets you use abbreviated syntax to edit pages faster.</p>
            <div class=""ui small header"">
                Links
            </div>
            <p>To link to internal pages, you can use square brackets [[like this]]. You can escape square brackets using backslash.</p>
            <p>What you write: <code>[[PageName]]</code></p>
            <p>What you get: <code>&lt;a href=&quot;/ViewPage/PageName&quot;&gt;PageName&lt;/a&gt;</code></p>
            <p>Here's some more examples to show how escaping works:</p>
            <code>
                [[This should be a link]]<br>
                [[This should also be a link]][[s]][[mall links work too]]<br>
                \[[This should not be a link]][[but this one should be]]<br>
                [[this should be a link]]\[[but this one shouldn't be]]<br>
                [[]]<br>
                [[This should be a link despite \]] having");
                WriteLiteral(@" escaped \]]s in it]]<br>
                [[[[wow extra brackets, but this should still work]]]]
            </code>
            <div class=""ui small header"">
                Page name
            </div>
            <p>To get the current page name, type <code>{{PAGENAME}}</code>.</p>
            <p>What you write: <code>{{PAGENAME}}</code></p>
            <p>What you get: <code>Index</code></p>
            <div class=""ui small header"">
                Hide navbar
            </div>
            <p>In some cases, you may wish to hide the navbar. Luckily, that is easy to do. Just put <code>{{HIDENAVBAR}}</code> at the top of your page. Make sure to put a line break after it, like this:</p>
            <code>
                {{HIDENAVBAR}}<br/>
                Page contents go here
            </code>
            <p style=""margin-top: 1em"">To access the navbar on a page where it is hidden, either press the <kbd>ESC</kbd> key or click on the version text at the bottom of a page.</p>
            <div class=""ui smal");
                WriteLiteral("l header\">\n                Remove margin\n            </div>\n            <p>To make the content of the page look nicer, ");
                EndContext();
                BeginContext(3288, 24, false);
#line 71 "/home/benjamin/webweb-core/webweb/Views/Docs/Syntax.cshtml"
                                                      Write(ViewData["SoftwareName"]);

#line default
#line hidden
                EndContext();
                BeginContext(3312, 1721, true);
                WriteLiteral(@" automatically applies a margin of <code>1em</code> to the <code>&lt;body&gt;</code> element. You can disable this by typing <code>{{NOMARGIN}}</code>, similar to how you would use <code>{{HIDENAVBAR}}</code>.</p>
            <div class=""ui small header"">
                Structure of document
            </div>
            <p>When applying styles to the document, you should apply them to the element that contains the custom HTML, not the <code>&lt;body&gt;</code> element. If you apply styles to the <code>&lt;body&gt;</code> element, the navbar will also be affected.</p>
            <code>
                &lt;head&gt;<br/>
                &nbsp;&nbsp;&lt;style&gt;<br/>
                &nbsp;&nbsp;&nbsp;&nbsp;&lt;!-- Custom CSS goes here --&gt; <br/>
                &nbsp;&nbsp;&lt;/style&gt;<br/>
                &lt;/head&gt;<br/>
                &lt;body&gt; <br/>
                &nbsp;&nbsp;&lt;div id=&quot;navbarContainer&quot;&gt; <br/>
                &nbsp;&nbsp;&nbsp;&nbsp;&lt;!-- Navbar goes here --&gt");
                WriteLiteral(@"; <br/>
                &nbsp;&nbsp;&lt;/div&gt; <br/>
                &nbsp;&nbsp;&lt;div id=&quot;customContent&quot;&gt;<br/>
                &nbsp;&nbsp;&nbsp;&nbsp;&lt;!-- Custom HTML goes here --&gt;<br/>
                &nbsp;&nbsp;&lt;/div&gt;<br/>
                &nbsp;&nbsp;&lt;div class=&quot;ui divider&quot;&gt;&lt;/div&gt;<br/>
                &nbsp;&nbsp;&lt;span id=&quot;version=&quot;&gt;&lt;/span&gt;<br/>
                &nbsp;&nbsp;&lt;script&gt;&lt;!-- Custom JS goes here --&gt;&lt;/script&gt;<br/>
                &lt;/body&gt;<br/>
            </code>
        </div>
        <div class=""ui divider""></div>
        <span id=""version"" class=""ui small grey text"">Powered by ");
                EndContext();
                BeginContext(5034, 24, false);
#line 96 "/home/benjamin/webweb-core/webweb/Views/Docs/Syntax.cshtml"
                                                            Write(ViewData["SoftwareName"]);

#line default
#line hidden
                EndContext();
                BeginContext(5058, 1, true);
                WriteLiteral(" ");
                EndContext();
                BeginContext(5060, 25, false);
#line 96 "/home/benjamin/webweb-core/webweb/Views/Docs/Syntax.cshtml"
                                                                                      Write(ViewData["VersionNumber"]);

#line default
#line hidden
                EndContext();
                BeginContext(5085, 12, true);
                WriteLiteral("</span>\n    ");
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
            BeginContext(5104, 13, true);
            WriteLiteral("\n</html>\n\n\n\n\n");
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
