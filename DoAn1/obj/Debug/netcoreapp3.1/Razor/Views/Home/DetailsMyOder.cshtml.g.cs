#pragma checksum "C:\Users\datvn\OneDrive\Máy tính\App_23\DA1\DoAn1\Views\Home\DetailsMyOder.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d5ffc1e95baa323cbad905e91ca61f6c70c91049"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_DetailsMyOder), @"mvc.1.0.view", @"/Views/Home/DetailsMyOder.cshtml")]
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
#line 1 "C:\Users\datvn\OneDrive\Máy tính\App_23\DA1\DoAn1\Views\_ViewImports.cshtml"
using DoAn1;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\datvn\OneDrive\Máy tính\App_23\DA1\DoAn1\Views\_ViewImports.cshtml"
using DoAn1.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d5ffc1e95baa323cbad905e91ca61f6c70c91049", @"/Views/Home/DetailsMyOder.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"43da5b8a0c05820e6044dacf6ceed3ec2f937a09", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_DetailsMyOder : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<DoAn1.Models.CT_HoaDon>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\datvn\OneDrive\Máy tính\App_23\DA1\DoAn1\Views\Home\DetailsMyOder.cshtml"
  
    ViewData["Title"] = "DetailsMyOder";
    Layout = "~/Views/Shared/_UserLayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<h3>DetailsMyOder</h3>

<table class=""table table-striped"">
    <thead>
        <tr>
            <th>
                Laptop
            </th>
            <th>
                Số lượng
            </th>
            <th>
                Tổng tiền
            </th>
            <th></th>
        </tr>
    </thead>
    <tbody>
");
#nullable restore
#line 26 "C:\Users\datvn\OneDrive\Máy tính\App_23\DA1\DoAn1\Views\Home\DetailsMyOder.cshtml"
         foreach (var item in Model)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\r\n                <td>\r\n                    ");
#nullable restore
#line 30 "C:\Users\datvn\OneDrive\Máy tính\App_23\DA1\DoAn1\Views\Home\DetailsMyOder.cshtml"
               Write(Html.DisplayFor(modelItem => item.Laptop.TenLaptop));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 33 "C:\Users\datvn\OneDrive\Máy tính\App_23\DA1\DoAn1\Views\Home\DetailsMyOder.cshtml"
               Write(Html.DisplayFor(modelItem => item.SoLuong));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 36 "C:\Users\datvn\OneDrive\Máy tính\App_23\DA1\DoAn1\Views\Home\DetailsMyOder.cshtml"
               Write(Html.DisplayFor(modelItem => item.TongTien));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n            </tr>\r\n");
#nullable restore
#line 39 "C:\Users\datvn\OneDrive\Máy tính\App_23\DA1\DoAn1\Views\Home\DetailsMyOder.cshtml"
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<DoAn1.Models.CT_HoaDon>> Html { get; private set; }
    }
}
#pragma warning restore 1591
