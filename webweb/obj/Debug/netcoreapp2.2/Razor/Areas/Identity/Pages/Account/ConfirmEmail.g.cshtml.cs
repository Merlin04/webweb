#pragma checksum "/home/benjamin/webweb-core/webweb/Areas/Identity/Pages/Account/ConfirmEmail.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6bc9bedfa063a4e9c854929851d99bcfae7e2ae7"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(webweb.Areas.Identity.Pages.Account.Areas_Identity_Pages_Account_ConfirmEmail), @"mvc.1.0.razor-page", @"/Areas/Identity/Pages/Account/ConfirmEmail.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.RazorPages.Infrastructure.RazorPageAttribute(@"/Areas/Identity/Pages/Account/ConfirmEmail.cshtml", typeof(webweb.Areas.Identity.Pages.Account.Areas_Identity_Pages_Account_ConfirmEmail), null)]
namespace webweb.Areas.Identity.Pages.Account
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#line 1 "/home/benjamin/webweb-core/webweb/Areas/Identity/Pages/_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#line 2 "/home/benjamin/webweb-core/webweb/Areas/Identity/Pages/_ViewImports.cshtml"
using webweb.Areas.Identity;

#line default
#line hidden
#line 1 "/home/benjamin/webweb-core/webweb/Areas/Identity/Pages/Account/_ViewImports.cshtml"
using webweb.Areas.Identity.Pages.Account;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6bc9bedfa063a4e9c854929851d99bcfae7e2ae7", @"/Areas/Identity/Pages/Account/ConfirmEmail.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f34edb2562dc70188f037ef5eee29c6b166d7075", @"/Areas/Identity/Pages/_ViewImports.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"df3337637764dbc0e492d4c31185f49b751ae779", @"/Areas/Identity/Pages/Account/_ViewImports.cshtml")]
    public class Areas_Identity_Pages_Account_ConfirmEmail : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
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
#line 5 "/home/benjamin/webweb-core/webweb/Areas/Identity/Pages/Account/ConfirmEmail.cshtml"
  
    wwBuildInfo.wwBuildInfo wwbi = new wwBuildInfo.wwBuildInfo();
    ViewData["SoftwareName"] = wwbi.GetName();
    ViewData["VersionNumber"] = wwbi.GetVersion();
    ViewData["ProjectUrl"] = wwbi.GetUrl();
    ViewData["SiteName"] = wwbi.getSiteSettings()["SiteName"];

#line default
#line hidden
            BeginContext(414, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 13 "/home/benjamin/webweb-core/webweb/Areas/Identity/Pages/Account/ConfirmEmail.cshtml"
  
    Layout = null;

#line default
#line hidden
            BeginContext(443, 33, true);
            WriteLiteral("\r\n<!DOCTYPE html>\r\n\r\n<html>\r\n    ");
            EndContext();
            BeginContext(476, 880, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6bc9bedfa063a4e9c854929851d99bcfae7e2ae74993", async() => {
                BeginContext(482, 33, true);
                WriteLiteral("\r\n        <title>Confirm email | ");
                EndContext();
                BeginContext(516, 20, false);
#line 21 "/home/benjamin/webweb-core/webweb/Areas/Identity/Pages/Account/ConfirmEmail.cshtml"
                          Write(ViewData["SiteName"]);

#line default
#line hidden
                EndContext();
                BeginContext(536, 813, true);
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
            BeginContext(1356, 6, true);
            WriteLiteral("\r\n    ");
            EndContext();
            BeginContext(1362, 469, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6bc9bedfa063a4e9c854929851d99bcfae7e2ae77381", async() => {
                BeginContext(1368, 10, true);
                WriteLiteral("\r\n        ");
                EndContext();
                BeginContext(1378, 26, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("partial", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "6bc9bedfa063a4e9c854929851d99bcfae7e2ae77768", async() => {
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
                BeginContext(1404, 355, true);
                WriteLiteral(@"
        <div id=""customContent"">
            <div class=""ui header"">
                Thank you for confirming your email. 
            </div>
            <a href=""/Identity/Account/Manage"">Go to your account settings page.</a>
        </div>
        <div class=""ui divider""></div>
        <span id=""version"" class=""ui small grey text"">Powered by ");
                EndContext();
                BeginContext(1760, 24, false);
#line 51 "/home/benjamin/webweb-core/webweb/Areas/Identity/Pages/Account/ConfirmEmail.cshtml"
                                                            Write(ViewData["SoftwareName"]);

#line default
#line hidden
                EndContext();
                BeginContext(1784, 1, true);
                WriteLiteral(" ");
                EndContext();
                BeginContext(1786, 25, false);
#line 51 "/home/benjamin/webweb-core/webweb/Areas/Identity/Pages/Account/ConfirmEmail.cshtml"
                                                                                      Write(ViewData["VersionNumber"]);

#line default
#line hidden
                EndContext();
                BeginContext(1811, 13, true);
                WriteLiteral("</span>\r\n    ");
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
            BeginContext(1831, 9, true);
            WriteLiteral("\r\n</html>");
            EndContext();
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public SignInManager<IdentityUser> SignInManager { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public UserManager<IdentityUser> UserManager { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ConfirmEmailModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<ConfirmEmailModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<ConfirmEmailModel>)PageContext?.ViewData;
        public ConfirmEmailModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591