#pragma checksum "/home/benjamin/webweb-core/webweb/Views/Shared/_Navbar.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "71bd696ea3aca6118f192f89f43032556a16e84f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__Navbar), @"mvc.1.0.view", @"/Views/Shared/_Navbar.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Shared/_Navbar.cshtml", typeof(AspNetCore.Views_Shared__Navbar))]
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
#line 1 "/home/benjamin/webweb-core/webweb/Views/Shared/_Navbar.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"71bd696ea3aca6118f192f89f43032556a16e84f", @"/Views/Shared/_Navbar.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a39a320ce272370ca152eb63bcde58811c6813e3", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared__Navbar : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("item"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("navigateForm"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("/Page/NavigateForm"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("right item"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-area", "Identity", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "/Account/Manage/Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("title", new global::Microsoft.AspNetCore.Html.HtmlString("Manage"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_8 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "/Account/Logout", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_9 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "/Account/Login", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_10 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("flex-grow: 1;"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_11 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("ui item"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(133, 71, true);
            WriteLiteral("\n<!-- Regular menu -->\n<div class=\"ui inverted menu\" id=\"desktopMenu\">\n");
            EndContext();
#line 7 "/home/benjamin/webweb-core/webweb/Views/Shared/_Navbar.cshtml"
     try
    {
        if (ViewData["PageName"].ToString() == "Index")
        {

#line default
#line hidden
            BeginContext(285, 83, true);
            WriteLiteral("            <a href=\"/\" class=\"active item\">\n                Home\n            </a>\n");
            EndContext();
#line 14 "/home/benjamin/webweb-core/webweb/Views/Shared/_Navbar.cshtml"
            if (SignInManager.IsSignedIn(User))
            {

#line default
#line hidden
            BeginContext(430, 18, true);
            WriteLiteral("                <a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 448, "\"", 486, 2);
            WriteAttributeValue("", 455, "/EditPage/", 455, 10, true);
#line 16 "/home/benjamin/webweb-core/webweb/Views/Shared/_Navbar.cshtml"
WriteAttributeValue("", 465, ViewData["PageName"], 465, 21, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(487, 66, true);
            WriteLiteral(" class=\"item\">\n                    Edit Page\n                </a>\n");
            EndContext();
#line 19 "/home/benjamin/webweb-core/webweb/Views/Shared/_Navbar.cshtml"
            }
        }
        else if (ViewData["PageName"].ToString().Length > 0)
        {

#line default
#line hidden
            BeginContext(648, 90, true);
            WriteLiteral("            <a href=\"/\" class=\"item\">\n                Home\n            </a>\n            <a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 738, "\"", 776, 2);
            WriteAttributeValue("", 745, "/ViewPage/", 745, 10, true);
#line 26 "/home/benjamin/webweb-core/webweb/Views/Shared/_Navbar.cshtml"
WriteAttributeValue("", 755, ViewData["PageName"], 755, 21, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(777, 38, true);
            WriteLiteral(" class=\"active item\">\n                ");
            EndContext();
            BeginContext(816, 20, false);
#line 27 "/home/benjamin/webweb-core/webweb/Views/Shared/_Navbar.cshtml"
           Write(ViewData["PageName"]);

#line default
#line hidden
            EndContext();
            BeginContext(836, 18, true);
            WriteLiteral("\n            </a>\n");
            EndContext();
#line 29 "/home/benjamin/webweb-core/webweb/Views/Shared/_Navbar.cshtml"
            if (SignInManager.IsSignedIn(User))
            {

#line default
#line hidden
            BeginContext(916, 18, true);
            WriteLiteral("                <a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 934, "\"", 972, 2);
            WriteAttributeValue("", 941, "/EditPage/", 941, 10, true);
#line 31 "/home/benjamin/webweb-core/webweb/Views/Shared/_Navbar.cshtml"
WriteAttributeValue("", 951, ViewData["PageName"], 951, 21, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(973, 66, true);
            WriteLiteral(" class=\"item\">\n                    Edit Page\n                </a>\n");
            EndContext();
#line 34 "/home/benjamin/webweb-core/webweb/Views/Shared/_Navbar.cshtml"
            }
        }
        else
        {

#line default
#line hidden
            BeginContext(1086, 76, true);
            WriteLiteral("            <a href=\"/\" class=\"item\">\n                Home\n            </a>\n");
            EndContext();
#line 41 "/home/benjamin/webweb-core/webweb/Views/Shared/_Navbar.cshtml"
        }
    }
    catch
    {

#line default
#line hidden
            BeginContext(1194, 64, true);
            WriteLiteral("        <a href=\"/\" class=\"item\">\n            Home\n        </a>\n");
            EndContext();
#line 48 "/home/benjamin/webweb-core/webweb/Views/Shared/_Navbar.cshtml"
    }

#line default
#line hidden
            BeginContext(1264, 4, true);
            WriteLiteral("    ");
            EndContext();
            BeginContext(1268, 301, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "71bd696ea3aca6118f192f89f43032556a16e84f11518", async() => {
                BeginContext(1347, 215, true);
                WriteLiteral("\n        <div class=\"ui inverted transparent input\">\n            <input type=\"text\" name=\"pageName\" placeholder=\"Navigate to...\">\n        </div>\n        <button type=\"submit\" class=\"ui black button\">Go</button>\n    ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1569, 1, true);
            WriteLiteral("\n");
            EndContext();
#line 55 "/home/benjamin/webweb-core/webweb/Views/Shared/_Navbar.cshtml"
     if (SignInManager.IsSignedIn(User))
    {

#line default
#line hidden
            BeginContext(1617, 8, true);
            WriteLiteral("        ");
            EndContext();
            BeginContext(1625, 121, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "71bd696ea3aca6118f192f89f43032556a16e84f13871", async() => {
                BeginContext(1715, 7, true);
                WriteLiteral("Hello, ");
                EndContext();
                BeginContext(1723, 18, false);
#line 57 "/home/benjamin/webweb-core/webweb/Views/Shared/_Navbar.cshtml"
                                                                                                    Write(User.Identity.Name);

#line default
#line hidden
                EndContext();
                BeginContext(1741, 1, true);
                WriteLiteral("!");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Area = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_6.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_7);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1746, 9, true);
            WriteLiteral("\n        ");
            EndContext();
            BeginContext(1755, 245, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "71bd696ea3aca6118f192f89f43032556a16e84f16005", async() => {
                BeginContext(1892, 101, true);
                WriteLiteral("\n            <button id=\"logoutButton\" type=\"submit\" class=\"ui black button\">Logout</button>\n        ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Area = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Page = (string)__tagHelperAttribute_8.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_8);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-returnurl", "Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 58 "/home/benjamin/webweb-core/webweb/Views/Shared/_Navbar.cshtml"
                                                                                   WriteLiteral(Url.Action("ViewPage", "Page", new {area = ""}));

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.RouteValues["returnurl"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-returnurl", __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.RouteValues["returnurl"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2000, 774, true);
            WriteLiteral(@"
        <div class=""ui inverted dropdown icon item"">
            <i class=""wrench icon""></i>
            <div class=""menu"">
                <a class=""item"" href=""/ViewPage/Special|List of pages"">
                    Special|List of pages
                </a>
                <a class=""item"" href=""/NewPage"">
                    New Page
                </a>
                <a class=""item"" href=""/ManageTemplates"">
                    Manage Templates
                </a>
                <a class=""item"" href=""/ManageFiles"">
                    Manage Files
                </a>
                <a class=""item"" href=""/Admin/ControlPanel"">
                    Control Panel
                </a>
                <a class=""item"" href=""/Docs/About"">
                    About ");
            EndContext();
            BeginContext(2775, 24, false);
#line 80 "/home/benjamin/webweb-core/webweb/Views/Shared/_Navbar.cshtml"
                     Write(ViewData["SoftwareName"]);

#line default
#line hidden
            EndContext();
            BeginContext(2799, 163, true);
            WriteLiteral("\n                </a>\n                <a class=\"item\" href=\"/Docs/Syntax\">\n                    Syntax Guide\n                </a>\n            </div>\n        </div>\n");
            EndContext();
#line 87 "/home/benjamin/webweb-core/webweb/Views/Shared/_Navbar.cshtml"
    }
    else
    {

#line default
#line hidden
            BeginContext(2983, 8, true);
            WriteLiteral("        ");
            EndContext();
            BeginContext(2991, 77, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "71bd696ea3aca6118f192f89f43032556a16e84f20569", async() => {
                BeginContext(3059, 5, true);
                WriteLiteral("Login");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Area = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_9.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_9);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(3068, 1, true);
            WriteLiteral("\n");
            EndContext();
#line 91 "/home/benjamin/webweb-core/webweb/Views/Shared/_Navbar.cshtml"
    }

#line default
#line hidden
            BeginContext(3075, 82, true);
            WriteLiteral("</div>\n\n<!-- Mobile menu -->\n<div class=\"ui inverted menu\" id=\"mobileMenuButton\">\n");
            EndContext();
#line 96 "/home/benjamin/webweb-core/webweb/Views/Shared/_Navbar.cshtml"
     if (SignInManager.IsSignedIn(User))
    {

#line default
#line hidden
            BeginContext(3204, 155, true);
            WriteLiteral("        <a onclick=\"$(\'#mobileMenu\').accordion(\'toggle\', 0)\" class=\"ui item\" id=\"mobileMenuTrigger\">\n            <i class=\"sidebar icon\"></i>\n        </a>\n");
            EndContext();
#line 101 "/home/benjamin/webweb-core/webweb/Views/Shared/_Navbar.cshtml"
    }

#line default
#line hidden
            BeginContext(3365, 4, true);
            WriteLiteral("    ");
            EndContext();
#line 102 "/home/benjamin/webweb-core/webweb/Views/Shared/_Navbar.cshtml"
     try
    {
        if (ViewData["PageName"].ToString() == "Index")
        {

#line default
#line hidden
            BeginContext(3446, 86, true);
            WriteLiteral("            <a class=\"ui active item\" href=\"/\">\n                Home\n            </a>\n");
            EndContext();
#line 109 "/home/benjamin/webweb-core/webweb/Views/Shared/_Navbar.cshtml"
        }
        else
        {

#line default
#line hidden
            BeginContext(3565, 79, true);
            WriteLiteral("            <a class=\"ui item\" href=\"/\">\n                Home\n            </a>\n");
            EndContext();
#line 115 "/home/benjamin/webweb-core/webweb/Views/Shared/_Navbar.cshtml"
        }
    }
    catch
    {

#line default
#line hidden
            BeginContext(3676, 67, true);
            WriteLiteral("        <a class=\"ui item\" href=\"/\">\n            Home\n        </a>\n");
            EndContext();
#line 122 "/home/benjamin/webweb-core/webweb/Views/Shared/_Navbar.cshtml"
    }

#line default
#line hidden
            BeginContext(3749, 4, true);
            WriteLiteral("    ");
            EndContext();
            BeginContext(3753, 373, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "71bd696ea3aca6118f192f89f43032556a16e84f24325", async() => {
                BeginContext(3836, 283, true);
                WriteLiteral(@"
        <div class=""ui inverted transparent input"">
            <input style=""width: 10px;"" type=""text"" name=""pageName"" placeholder=""Navigate to..."">
        </div>
        <button style=""padding-left: 8px; padding-right: 8px;"" type=""submit"" class=""ui black button"">Go</button>
    ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_10);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(4126, 1, true);
            WriteLiteral("\n");
            EndContext();
#line 129 "/home/benjamin/webweb-core/webweb/Views/Shared/_Navbar.cshtml"
     if (!SignInManager.IsSignedIn(User))
    {

#line default
#line hidden
            BeginContext(4175, 8, true);
            WriteLiteral("        ");
            EndContext();
            BeginContext(4183, 129, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "71bd696ea3aca6118f192f89f43032556a16e84f26749", async() => {
                BeginContext(4248, 60, true);
                WriteLiteral("\n            <i class=\"sign in alternate icon\"></i>\n        ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_11);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Area = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_9.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_9);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(4312, 1, true);
            WriteLiteral("\n");
            EndContext();
#line 134 "/home/benjamin/webweb-core/webweb/Views/Shared/_Navbar.cshtml"
    }

#line default
#line hidden
            BeginContext(4319, 7, true);
            WriteLiteral("</div>\n");
            EndContext();
#line 136 "/home/benjamin/webweb-core/webweb/Views/Shared/_Navbar.cshtml"
 if (SignInManager.IsSignedIn(User))
{

#line default
#line hidden
            BeginContext(4365, 249, true);
            WriteLiteral("    <div class=\"ui fluid accordion\" id=\"mobileMenu\">\n        <div class=\"title\" style=\"display:none\">\n\n        </div>\n        <div class=\"content\" style=\"padding-bottom: 21px;\">\n            <div class=\"ui stackable inverted menu\">\n                <a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 4614, "\"", 4652, 2);
            WriteAttributeValue("", 4621, "/EditPage/", 4621, 10, true);
#line 144 "/home/benjamin/webweb-core/webweb/Views/Shared/_Navbar.cshtml"
WriteAttributeValue("", 4631, ViewData["PageName"], 4631, 21, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(4653, 82, true);
            WriteLiteral(" class=\"item\">\n                    Edit Page\n                </a>\n                ");
            EndContext();
            BeginContext(4735, 108, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "71bd696ea3aca6118f192f89f43032556a16e84f29696", async() => {
                BeginContext(4825, 14, true);
                WriteLiteral("Manage Account");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Area = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_6.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_7);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(4843, 778, true);
            WriteLiteral(@"
                <a class=""item"" href=""#"" onclick=""$('#logoutButton').click();"">
                    Logout
                </a>
                <a class=""item"" href=""/ViewPage/Special|List of pages"">
                    Special|List of pages
                </a>
                <a class=""item"" href=""/NewPage"">
                    New Page
                </a>
                <a class=""item"" href=""/ManageTemplates"">
                    Manage Templates
                </a>
                <a class=""item"" href=""/ManageFiles"">
                    Manage Files
                </a>
                <a class=""item"" href=""/Admin/ControlPanel"">
                    Control Panel
                </a>
                <a class=""item"" href=""/Docs/About"">
                    About ");
            EndContext();
            BeginContext(5622, 24, false);
#line 167 "/home/benjamin/webweb-core/webweb/Views/Shared/_Navbar.cshtml"
                     Write(ViewData["SoftwareName"]);

#line default
#line hidden
            EndContext();
            BeginContext(5646, 174, true);
            WriteLiteral("\n                </a>\n                <a class=\"item\" href=\"/Docs/Syntax\">\n                    Syntax Guide\n                </a>\n            </div>\n        </div>\n    </div>\n");
            EndContext();
#line 175 "/home/benjamin/webweb-core/webweb/Views/Shared/_Navbar.cshtml"
}

#line default
#line hidden
#line 176 "/home/benjamin/webweb-core/webweb/Views/Shared/_Navbar.cshtml"
  
    if (SignInManager.IsSignedIn(User))
    {
        ViewData["mobileWidth"] = "900px"; // Signed in users have more navbar items
    }
    else
    {
        ViewData["mobileWidth"] = "500px";
    }

#line default
#line hidden
            BeginContext(6028, 286, true);
            WriteLiteral(@"<script>
    $(document).ready(function() {
        $('.ui.accordion')
          .accordion()
        ;
    });
    // Add style through JS so that I don't have to go through every file and add it
    var styles = `
    #mobileMenu, #mobileMenuButton {
        display: none;
    }
    ");
            EndContext();
            BeginContext(6315, 35, true);
            WriteLiteral("@media only screen and (max-width: ");
            EndContext();
            BeginContext(6351, 23, false);
#line 197 "/home/benjamin/webweb-core/webweb/Views/Shared/_Navbar.cshtml"
                                   Write(ViewData["mobileWidth"]);

#line default
#line hidden
            EndContext();
            BeginContext(6374, 432, true);
            WriteLiteral(@") {
          #desktopMenu {
            display: none !important;
          }
          #mobileMenuButton {
            display: flex;
            margin-top: 0px;
          }
          #mobileMenu {
            display: flex;
          }
        }
    `;
    var styleSheet = document.createElement(""style"");
    styleSheet.type = ""text/css"";
    styleSheet.innerText = styles;
    document.head.appendChild(styleSheet);
</script>");
            EndContext();
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public UserManager<IdentityUser> UserManager { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public SignInManager<IdentityUser> SignInManager { get; private set; }
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
