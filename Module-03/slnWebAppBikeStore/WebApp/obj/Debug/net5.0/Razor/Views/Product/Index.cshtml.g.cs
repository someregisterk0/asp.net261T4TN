#pragma checksum "D:\asp.net261T4TN\Module-03\slnWebAppBikeStore\WebApp\Views\Product\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "62b0ebd03cf21df0b71a1b9b358e9db3da7cf4eb"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Product_Index), @"mvc.1.0.view", @"/Views/Product/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"62b0ebd03cf21df0b71a1b9b358e9db3da7cf4eb", @"/Views/Product/Index.cshtml")]
    public class Views_Product_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<WebApp.Models.Product>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("/product/search"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "get", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("/product/searchloadmore"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "Product", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<ul>\r\n    <li><a class=\"btn-primary\" href=\"/product/loadmore\">Load More</a></li>\r\n    <li><a class=\"btn-primary\" href=\"/product/lazy\">Lazy</a></li>\r\n    <li><a class=\"btn-primary\" href=\"/product/create\">Create</a></li>\r\n</ul>\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "62b0ebd03cf21df0b71a1b9b358e9db3da7cf4eb4414", async() => {
                WriteLiteral("\r\n    <input type=\"text\" name=\"q\" />\r\n    <button>Search</button>\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "62b0ebd03cf21df0b71a1b9b358e9db3da7cf4eb6005", async() => {
                WriteLiteral("\r\n    <input type=\"text\" placeholder=\"Search Load More\" name=\"q\" />\r\n    <button>Search</button>\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n");
#nullable restore
#line 20 "D:\asp.net261T4TN\Module-03\slnWebAppBikeStore\WebApp\Views\Product\Index.cshtml"
   int p = ViewContext.RouteData.Values["id"] is null ? 1 : Convert.ToInt32(ViewContext.RouteData.Values["id"]); 

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<ul class=\"pagination\">\r\n");
#nullable restore
#line 23 "D:\asp.net261T4TN\Module-03\slnWebAppBikeStore\WebApp\Views\Product\Index.cshtml"
     if (p > 1)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <li class=\"page-item\">\r\n            <a class=\"page-link\"");
            BeginWriteAttribute("href", " href=\"", 834, "\"", 864, 2);
            WriteAttributeValue("", 841, "/product/index/", 841, 15, true);
#nullable restore
#line 26 "D:\asp.net261T4TN\Module-03\slnWebAppBikeStore\WebApp\Views\Product\Index.cshtml"
WriteAttributeValue("", 856, p - 1, 856, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Previous</a>\r\n        </li>\r\n");
#nullable restore
#line 28 "D:\asp.net261T4TN\Module-03\slnWebAppBikeStore\WebApp\Views\Product\Index.cshtml"
    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 29 "D:\asp.net261T4TN\Module-03\slnWebAppBikeStore\WebApp\Views\Product\Index.cshtml"
     for (int i = 1; i <= ViewBag.pages; i++)
    {
        if (i == ViewBag.p) // i == p
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <li class=\"page-item active\">\r\n                <a class=\"page-link\"");
            BeginWriteAttribute("href", " href=\"", 1085, "\"", 1109, 2);
            WriteAttributeValue("", 1092, "/product/index/", 1092, 15, true);
#nullable restore
#line 34 "D:\asp.net261T4TN\Module-03\slnWebAppBikeStore\WebApp\Views\Product\Index.cshtml"
WriteAttributeValue("", 1107, i, 1107, 2, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 34 "D:\asp.net261T4TN\Module-03\slnWebAppBikeStore\WebApp\Views\Product\Index.cshtml"
                                                         Write(i);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\r\n            </li>\r\n");
#nullable restore
#line 36 "D:\asp.net261T4TN\Module-03\slnWebAppBikeStore\WebApp\Views\Product\Index.cshtml"
        }
        else
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <li class=\"page-item\">\r\n                <a class=\"page-link\"");
            BeginWriteAttribute("href", " href=\"", 1246, "\"", 1270, 2);
            WriteAttributeValue("", 1253, "/product/index/", 1253, 15, true);
#nullable restore
#line 40 "D:\asp.net261T4TN\Module-03\slnWebAppBikeStore\WebApp\Views\Product\Index.cshtml"
WriteAttributeValue("", 1268, i, 1268, 2, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 40 "D:\asp.net261T4TN\Module-03\slnWebAppBikeStore\WebApp\Views\Product\Index.cshtml"
                                                         Write(i);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\r\n            </li>\r\n");
#nullable restore
#line 42 "D:\asp.net261T4TN\Module-03\slnWebAppBikeStore\WebApp\Views\Product\Index.cshtml"
        }
    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 44 "D:\asp.net261T4TN\Module-03\slnWebAppBikeStore\WebApp\Views\Product\Index.cshtml"
     if (p < ViewBag.pages)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <li class=\"page-item\">\r\n            <a class=\"page-link\"");
            BeginWriteAttribute("href", " href=\"", 1417, "\"", 1447, 2);
            WriteAttributeValue("", 1424, "/product/index/", 1424, 15, true);
#nullable restore
#line 47 "D:\asp.net261T4TN\Module-03\slnWebAppBikeStore\WebApp\Views\Product\Index.cshtml"
WriteAttributeValue("", 1439, p + 1, 1439, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Next</a>\r\n        </li>\r\n");
#nullable restore
#line 49 "D:\asp.net261T4TN\Module-03\slnWebAppBikeStore\WebApp\Views\Product\Index.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</ul>\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("partial", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "62b0ebd03cf21df0b71a1b9b358e9db3da7cf4eb12183", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Name = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
#nullable restore
#line 52 "D:\asp.net261T4TN\Module-03\slnWebAppBikeStore\WebApp\Views\Product\Index.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Model = Model;

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext.AddTagHelperAttribute("model", __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Model, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n");
            WriteLiteral("\r\n\r\n\r\n<ul id=\"pagination\" class=\"pagination\">\r\n");
#nullable restore
#line 87 "D:\asp.net261T4TN\Module-03\slnWebAppBikeStore\WebApp\Views\Product\Index.cshtml"
     if (p > 1)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <li class=\"page-item\">\r\n            <a class=\"page-link\"");
            BeginWriteAttribute("href", " href=\"", 2623, "\"", 2653, 2);
            WriteAttributeValue("", 2630, "/product/index/", 2630, 15, true);
#nullable restore
#line 90 "D:\asp.net261T4TN\Module-03\slnWebAppBikeStore\WebApp\Views\Product\Index.cshtml"
WriteAttributeValue("", 2645, p - 1, 2645, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Previous</a>\r\n        </li>\r\n");
#nullable restore
#line 92 "D:\asp.net261T4TN\Module-03\slnWebAppBikeStore\WebApp\Views\Product\Index.cshtml"
    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 93 "D:\asp.net261T4TN\Module-03\slnWebAppBikeStore\WebApp\Views\Product\Index.cshtml"
     for (int i = 1; i <= ViewBag.pages; i++)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <li class=\"p page-item\">\r\n            <a class=\"page-link\"");
            BeginWriteAttribute("href", " href=\"", 2811, "\"", 2835, 2);
            WriteAttributeValue("", 2818, "/product/index/", 2818, 15, true);
#nullable restore
#line 96 "D:\asp.net261T4TN\Module-03\slnWebAppBikeStore\WebApp\Views\Product\Index.cshtml"
WriteAttributeValue("", 2833, i, 2833, 2, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 96 "D:\asp.net261T4TN\Module-03\slnWebAppBikeStore\WebApp\Views\Product\Index.cshtml"
                                                     Write(i);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\r\n        </li>\r\n");
#nullable restore
#line 98 "D:\asp.net261T4TN\Module-03\slnWebAppBikeStore\WebApp\Views\Product\Index.cshtml"
    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 99 "D:\asp.net261T4TN\Module-03\slnWebAppBikeStore\WebApp\Views\Product\Index.cshtml"
     if (p < ViewBag.pages)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <li class=\"page-item\">\r\n            <a class=\"page-link\"");
            BeginWriteAttribute("href", " href=\"", 2967, "\"", 2997, 2);
            WriteAttributeValue("", 2974, "/product/index/", 2974, 15, true);
#nullable restore
#line 102 "D:\asp.net261T4TN\Module-03\slnWebAppBikeStore\WebApp\Views\Product\Index.cshtml"
WriteAttributeValue("", 2989, p + 1, 2989, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Next</a>\r\n        </li>\r\n");
#nullable restore
#line 104 "D:\asp.net261T4TN\Module-03\slnWebAppBikeStore\WebApp\Views\Product\Index.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</ul>\r\n\r\n<script>\r\n    $($(\'li.p\')[");
#nullable restore
#line 108 "D:\asp.net261T4TN\Module-03\slnWebAppBikeStore\WebApp\Views\Product\Index.cshtml"
           Write(p);

#line default
#line hidden
#nullable disable
            WriteLiteral("-1]).addClass(\'active\');\r\n</script>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<WebApp.Models.Product>> Html { get; private set; }
    }
}
#pragma warning restore 1591
