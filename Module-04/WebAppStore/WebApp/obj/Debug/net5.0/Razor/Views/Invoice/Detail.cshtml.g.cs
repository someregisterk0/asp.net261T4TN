#pragma checksum "C:\Users\Totoro\source\repos\asp.net261T4TN\Module-04\WebAppStore\WebApp\Views\Invoice\Detail.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7e581069327143b2906e69629f65d387b69adff9"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Invoice_Detail), @"mvc.1.0.view", @"/Views/Invoice/Detail.cshtml")]
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
#nullable restore
#line 1 "C:\Users\Totoro\source\repos\asp.net261T4TN\Module-04\WebAppStore\WebApp\Views\_ViewImports.cshtml"
using WebApp.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7e581069327143b2906e69629f65d387b69adff9", @"/Views/Invoice/Detail.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ee2e25ed8b2fdc34cc2ed11280fba0ebc34d2baa", @"/Views/_ViewImports.cshtml")]
    public class Views_Invoice_Detail : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Invoice>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n    <p>Your Invoice</p>\r\n    <h2>");
#nullable restore
#line 4 "C:\Users\Totoro\source\repos\asp.net261T4TN\Module-04\WebAppStore\WebApp\Views\Invoice\Detail.cshtml"
   Write(Model.Fullname);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2>\r\n    <p>");
#nullable restore
#line 5 "C:\Users\Totoro\source\repos\asp.net261T4TN\Module-04\WebAppStore\WebApp\Views\Invoice\Detail.cshtml"
  Write(Model.Address);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n\r\n    <table class=\"table table-bordered\">\r\n        <tr>\r\n            <th>Product</th>\r\n            <th>Image</th>\r\n            <th>Price</th>\r\n            <th>Quantity</th>\r\n        </tr>\r\n");
#nullable restore
#line 14 "C:\Users\Totoro\source\repos\asp.net261T4TN\Module-04\WebAppStore\WebApp\Views\Invoice\Detail.cshtml"
         foreach (InvoiceDetail item in Model.InvoiceDetails)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\r\n                <td>");
#nullable restore
#line 17 "C:\Users\Totoro\source\repos\asp.net261T4TN\Module-04\WebAppStore\WebApp\Views\Invoice\Detail.cshtml"
               Write(item.ProductName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td><img");
            BeginWriteAttribute("src", " src=\"", 450, "\"", 492, 2);
            WriteAttributeValue("", 456, "/photos/", 456, 8, true);
#nullable restore
#line 18 "C:\Users\Totoro\source\repos\asp.net261T4TN\Module-04\WebAppStore\WebApp\Views\Invoice\Detail.cshtml"
WriteAttributeValue("", 464, item.ImageUrl.Split(',')[0], 464, 28, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("alt", " alt=\"", 493, "\"", 516, 1);
#nullable restore
#line 18 "C:\Users\Totoro\source\repos\asp.net261T4TN\Module-04\WebAppStore\WebApp\Views\Invoice\Detail.cshtml"
WriteAttributeValue("", 499, item.ProductName, 499, 17, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" width=\"70\" /></td>\r\n                <td>");
#nullable restore
#line 19 "C:\Users\Totoro\source\repos\asp.net261T4TN\Module-04\WebAppStore\WebApp\Views\Invoice\Detail.cshtml"
               Write(item.UnitOfPrice);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 20 "C:\Users\Totoro\source\repos\asp.net261T4TN\Module-04\WebAppStore\WebApp\Views\Invoice\Detail.cshtml"
               Write(item.Quantity);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            </tr>\r\n");
#nullable restore
#line 22 "C:\Users\Totoro\source\repos\asp.net261T4TN\Module-04\WebAppStore\WebApp\Views\Invoice\Detail.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </table>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Invoice> Html { get; private set; }
    }
}
#pragma warning restore 1591
