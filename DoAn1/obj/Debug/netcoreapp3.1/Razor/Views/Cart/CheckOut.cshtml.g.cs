#pragma checksum "C:\Users\datvn\OneDrive\Máy tính\App_23\DA1\DoAn1\Views\Cart\CheckOut.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a0b19372ee30e8b15893e211b434b1a39091deb0"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Cart_CheckOut), @"mvc.1.0.view", @"/Views/Cart/CheckOut.cshtml")]
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
#nullable restore
#line 1 "C:\Users\datvn\OneDrive\Máy tính\App_23\DA1\DoAn1\Views\Cart\CheckOut.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a0b19372ee30e8b15893e211b434b1a39091deb0", @"/Views/Cart/CheckOut.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"43da5b8a0c05820e6044dacf6ceed3ec2f937a09", @"/Views/_ViewImports.cshtml")]
    public class Views_Cart_CheckOut : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Cart", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "CheckOut", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "get", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("width:auto; height:100px"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "CheckOutDone", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "cart", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "CheckoutPayPal", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 4 "C:\Users\datvn\OneDrive\Máy tính\App_23\DA1\DoAn1\Views\Cart\CheckOut.cshtml"
  
    ViewData["Title"] = "CheckOut";
    Layout = "~/Views/Shared/_UserLayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"col-25\">\r\n    <div class=\"container\">\r\n        <h5>");
#nullable restore
#line 11 "C:\Users\datvn\OneDrive\Máy tính\App_23\DA1\DoAn1\Views\Cart\CheckOut.cshtml"
       Write(ViewBag.Message);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</h5>
       
        <hr />
    </div>
</div>

<div class=""container"" id=""invoice"">
    <div class=""invoice overflow-auto"">
        <div style=""min-width: 600px"">
            <header>
                <div class=""row"">
                    <div class=""col"">
                        <h3>CHECKOUT</h3>
                    </div>
                    <div class=""col company-details"">

                    </div>
                </div>
            </header>
            <main>
                <div class=""row contacts"">
                    <div class=""col invoice-to"">
                        <div class=""text-gray-light"">INVOICE TO:</div>
                        <h3 class=""to"">");
#nullable restore
#line 34 "C:\Users\datvn\OneDrive\Máy tính\App_23\DA1\DoAn1\Views\Cart\CheckOut.cshtml"
                                  Write(User.Identity.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n                        <div class=\"address\"></div>\r\n                    </div>\r\n                    <div class=\"col invoice-details\">\r\n                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a0b19372ee30e8b15893e211b434b1a39091deb07726", async() => {
                WriteLiteral("\r\n                            <input type=\"text\" placeholder=\"Nhập vào mã giảm giá\" name=\"voucher\" />\r\n                            <button class=\"btn btn-info\" type=\"submit\" value=\"Submit\">nhập</button>\r\n                        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                        <div class=\"date\">");
#nullable restore
#line 42 "C:\Users\datvn\OneDrive\Máy tính\App_23\DA1\DoAn1\Views\Cart\CheckOut.cshtml"
                                     Write(ViewBag.datenow);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</div>
                    </div>
                </div>

                <table border=""0"" cellspacing=""0"" cellpadding=""0"">
                    <thead>
                        <tr>
                            <th class=""text-left"">Tên sản phẩm</th>
                            <th class=""text-right"">Hình ảnh</th>
                            <th class=""text-right"">Số lượng</th>
                            <th class=""text-right"">TOTAL</th>
                        </tr>
                    </thead>
                    <tbody>
");
#nullable restore
#line 56 "C:\Users\datvn\OneDrive\Máy tính\App_23\DA1\DoAn1\Views\Cart\CheckOut.cshtml"
                         foreach (var item in ViewBag.cart)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <tr>\r\n                                <td class=\"text-left\">\r\n                                    <h3>\r\n                                        ");
#nullable restore
#line 61 "C:\Users\datvn\OneDrive\Máy tính\App_23\DA1\DoAn1\Views\Cart\CheckOut.cshtml"
                                   Write(item.Laptop.TenLaptop);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                    </h3>\r\n                                </td>\r\n                                <td class=\"unit\">");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "a0b19372ee30e8b15893e211b434b1a39091deb011509", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 2541, "~/image/", 2541, 8, true);
#nullable restore
#line 64 "C:\Users\datvn\OneDrive\Máy tính\App_23\DA1\DoAn1\Views\Cart\CheckOut.cshtml"
AddHtmlAttributeValue("", 2549, item.Laptop.HinhAnh, 2549, 20, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("</td>\r\n                                <td class=\"qty\">");
#nullable restore
#line 65 "C:\Users\datvn\OneDrive\Máy tính\App_23\DA1\DoAn1\Views\Cart\CheckOut.cshtml"
                                           Write(item.SoLuong);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                <td class=\"total\">$");
#nullable restore
#line 66 "C:\Users\datvn\OneDrive\Máy tính\App_23\DA1\DoAn1\Views\Cart\CheckOut.cshtml"
                                               Write(item.Laptop.Giatien * item.SoLuong);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                            </tr>\r\n");
#nullable restore
#line 68 "C:\Users\datvn\OneDrive\Máy tính\App_23\DA1\DoAn1\Views\Cart\CheckOut.cshtml"

                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("                    </tbody>\r\n                    <tfoot>\r\n                        <tr>\r\n                            <td colspan=\"2\">VOUCHER:</td>\r\n                            <td colspan=\"2\">");
#nullable restore
#line 74 "C:\Users\datvn\OneDrive\Máy tính\App_23\DA1\DoAn1\Views\Cart\CheckOut.cshtml"
                                       Write(ViewBag.voucher);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        </tr>\r\n                        <tr>\r\n                            <td colspan=\"2\"></td>\r\n                            <td colspan=\"2\">TOTAL</td>\r\n                            <td style=\"color:red\">$");
#nullable restore
#line 79 "C:\Users\datvn\OneDrive\Máy tính\App_23\DA1\DoAn1\Views\Cart\CheckOut.cshtml"
                                              Write(ViewBag.total);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        </tr>\r\n                    </tfoot>\r\n                </table>\r\n            </main>\r\n        </div>\r\n    </div>\r\n    <div class=\"checkout_btn_inner float-right\">\r\n        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a0b19372ee30e8b15893e211b434b1a39091deb015169", async() => {
                WriteLiteral("\r\n            <input type=\"hidden\" name=\"voucher\"");
                BeginWriteAttribute("value", " value=\"", 3647, "\"", 3671, 1);
#nullable restore
#line 88 "C:\Users\datvn\OneDrive\Máy tính\App_23\DA1\DoAn1\Views\Cart\CheckOut.cshtml"
WriteAttributeValue("", 3655, ViewBag.voucher, 3655, 16, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(@" />
            <input type=""submit"" value=""Thanh Toán COD"" class=""btn_1 checkout_btn_1"" style=""margin-right:7px; height:60px; display: inline-block; padding: 19px 61px; background-color: #0A98C0; font-size: 15px; font-weight: 700; -webkit-transition: 0.5s; transition: 0.5s; text-transform: capitalize; color: #fff;"" />
        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 87 "C:\Users\datvn\OneDrive\Máy tính\App_23\DA1\DoAn1\Views\Cart\CheckOut.cshtml"
                                                                             WriteLiteral(UserManager.GetUserId(User));

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n    </div>\r\n    <div class=\"checkout_btn_inner float-right\">\r\n        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a0b19372ee30e8b15893e211b434b1a39091deb018895", async() => {
                WriteLiteral("\r\n            <input type=\"hidden\" name=\"total\"");
                BeginWriteAttribute("value", " value=\"", 4245, "\"", 4267, 1);
#nullable restore
#line 95 "C:\Users\datvn\OneDrive\Máy tính\App_23\DA1\DoAn1\Views\Cart\CheckOut.cshtml"
WriteAttributeValue("", 4253, ViewBag.total, 4253, 14, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" />\r\n            <input type=\"hidden\" name=\"voucher\"");
                BeginWriteAttribute("value", " value=\"", 4320, "\"", 4344, 1);
#nullable restore
#line 96 "C:\Users\datvn\OneDrive\Máy tính\App_23\DA1\DoAn1\Views\Cart\CheckOut.cshtml"
WriteAttributeValue("", 4328, ViewBag.voucher, 4328, 16, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(@" />
            <input type=""submit"" value=""Paypal"" class=""btn_1 checkout_btn_1"" style=""margin-right:7px; height:60px; display: inline-block; padding: 19px 61px; background-color: #0A98C0; font-size: 15px; font-weight: 700; -webkit-transition: 0.5s; transition: 0.5s; text-transform: capitalize; color: #fff;"" />
        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_6.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_7.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_7);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 94 "C:\Users\datvn\OneDrive\Máy tính\App_23\DA1\DoAn1\Views\Cart\CheckOut.cshtml"
                                                                                WriteLiteral(UserManager.GetUserId(User));

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n    </div>\r\n</div>\r\n\r\n<div style=\"margin-bottom : 100px\"></div>");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public UserManager<DoAn1.Models.KhachHang> UserManager { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public SignInManager<DoAn1.Models.KhachHang> SignInManager { get; private set; }
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