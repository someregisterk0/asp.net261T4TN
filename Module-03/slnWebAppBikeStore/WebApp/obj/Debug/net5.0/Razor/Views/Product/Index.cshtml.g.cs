#pragma checksum "D:\asp.net261T4TN\Module-03\slnWebAppBikeStore\WebApp\Views\Product\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5cd2bae4dcc6305da09d0e0c0f5cf125fe5e4f6b"
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5cd2bae4dcc6305da09d0e0c0f5cf125fe5e4f6b", @"/Views/Product/Index.cshtml")]
    public class Views_Product_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<WebApp.Models.Product>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"
    <a href=""/product/create"">Create</a>
<table>
    <thead>
        <tr>
            <th>Id</th>
            <th>Name</th>
            <th>Brand</th>
            <th>Category</th>
            <th>Model Year</th>
            <th>Price</th>
        </tr>
    </thead>
    <tbody>
");
#nullable restore
#line 16 "D:\asp.net261T4TN\Module-03\slnWebAppBikeStore\WebApp\Views\Product\Index.cshtml"
         foreach (WebApp.Models.Product item in Model)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\r\n                <td>");
#nullable restore
#line 19 "D:\asp.net261T4TN\Module-03\slnWebAppBikeStore\WebApp\Views\Product\Index.cshtml"
               Write(item.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 20 "D:\asp.net261T4TN\Module-03\slnWebAppBikeStore\WebApp\Views\Product\Index.cshtml"
               Write(item.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 21 "D:\asp.net261T4TN\Module-03\slnWebAppBikeStore\WebApp\Views\Product\Index.cshtml"
               Write(item.BrandId);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 22 "D:\asp.net261T4TN\Module-03\slnWebAppBikeStore\WebApp\Views\Product\Index.cshtml"
               Write(item.CategoryId);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 23 "D:\asp.net261T4TN\Module-03\slnWebAppBikeStore\WebApp\Views\Product\Index.cshtml"
               Write(item.ModelYear);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 24 "D:\asp.net261T4TN\Module-03\slnWebAppBikeStore\WebApp\Views\Product\Index.cshtml"
               Write(item.Price);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            </tr>\r\n");
#nullable restore
#line 26 "D:\asp.net261T4TN\Module-03\slnWebAppBikeStore\WebApp\Views\Product\Index.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\r\n</table>\r\n");
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
