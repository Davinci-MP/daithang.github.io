#pragma checksum "C:\Users\Thang PC\Downloads\BanGameBanQuyen\BanGameBanQuyen\BanGameBanQuyen\Views\SanPham\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b7f7b5ff9ecbb39a22ac3c30d0be619851325bcb"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_SanPham_Index), @"mvc.1.0.view", @"/Views/SanPham/Index.cshtml")]
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
#line 1 "C:\Users\Thang PC\Downloads\BanGameBanQuyen\BanGameBanQuyen\BanGameBanQuyen\Views\_ViewImports.cshtml"
using BanGameBanQuyen;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Thang PC\Downloads\BanGameBanQuyen\BanGameBanQuyen\BanGameBanQuyen\Views\_ViewImports.cshtml"
using BanGameBanQuyen.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b7f7b5ff9ecbb39a22ac3c30d0be619851325bcb", @"/Views/SanPham/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6096982c53bb0743ea35cf4f22dad9089c846218", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_SanPham_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<BanGameBanQuyen.Models.SanPham>>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Details", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-primary btn-sm"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", new global::Microsoft.AspNetCore.Html.HtmlString("button"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("className", new global::Microsoft.AspNetCore.Html.HtmlString("snippet-body"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.SingleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\Thang PC\Downloads\BanGameBanQuyen\BanGameBanQuyen\BanGameBanQuyen\Views\SanPham\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b7f7b5ff9ecbb39a22ac3c30d0be619851325bcb5214", async() => {
                WriteLiteral(@"
                                <meta charset='utf-8'>
                                <meta name='viewport' content='width=device-width, initial-scale=1'>
                                <title>Snippet - BBBootstrap</title>
                                <link href='https://stackpath.bootstrapcdn.com/bootstrap/4.4.1/css/bootstrap.min.css' rel='stylesheet'>
                                <link href='https://cdnjs.cloudflare.com/ajax/libs/font-awesome/4.7.0/css/font-awesome.min.css' rel='stylesheet'>
                                <script type='text/javascript' src='https://cdnjs.cloudflare.com/ajax/libs/jquery/3.2.1/jquery.min.js'></script>
                                <style>::-webkit-scrollbar {
                                  width: 8px;
                                }
                                /* Track */
                                ::-webkit-scrollbar-track {
                                  background: #f1f1f1; 
                                }
                      ");
                WriteLiteral(@"           
                                /* Handle */
                                ::-webkit-scrollbar-thumb {
                                  background: #888; 
                                }
                                
                                /* Handle on hover */
                                ::-webkit-scrollbar-thumb:hover {
                                  background: #555; 
                                } body{background:#eee}.ratings i{font-size: 16px;color: red}.strike-text{color: red;text-decoration: line-through}.product-image{width: 100%}.dot{height: 7px;width: 7px;margin-left: 6px;margin-right: 6px;margin-top: 3px;background-color: blue;border-radius: 50%;display: inline-block}.spec-1{color: #938787;font-size: 15px}h5{font-weight: 400}.para{font-size: 16px}</style>
                                ");
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
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b7f7b5ff9ecbb39a22ac3c30d0be619851325bcb8096", async() => {
                WriteLiteral("\r\n    <div class=\"container mt-5 mb-5\">\r\n    <div class=\"d-flex justify-content-center row\">\r\n        <div class=\"col-md-10\">\r\n");
#nullable restore
#line 38 "C:\Users\Thang PC\Downloads\BanGameBanQuyen\BanGameBanQuyen\BanGameBanQuyen\Views\SanPham\Index.cshtml"
              
                var gameView = Model.Where(x=>x.TrangThai == true);
            

#line default
#line hidden
#nullable disable
#nullable restore
#line 41 "C:\Users\Thang PC\Downloads\BanGameBanQuyen\BanGameBanQuyen\BanGameBanQuyen\Views\SanPham\Index.cshtml"
             foreach (var item in gameView)
           {

#line default
#line hidden
#nullable disable
                WriteLiteral("               <div class=\"row p-2 bg-white border rounded mt-2\">\r\n                <div class=\"col-md-3 mt-1\" style=\"margin:auto !important;\"><img class=\"img-fluid img-responsive rounded product-image\"");
                BeginWriteAttribute("src", " src=\"", 2590, "\"", 2607, 1);
#nullable restore
#line 44 "C:\Users\Thang PC\Downloads\BanGameBanQuyen\BanGameBanQuyen\BanGameBanQuyen\Views\SanPham\Index.cshtml"
WriteAttributeValue("", 2596, item.AnhSp, 2596, 11, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" style=\"width:150px;\"></div>\r\n                <div class=\"col-md-6 mt-1\">\r\n                    <h5>");
#nullable restore
#line 46 "C:\Users\Thang PC\Downloads\BanGameBanQuyen\BanGameBanQuyen\BanGameBanQuyen\Views\SanPham\Index.cshtml"
                   Write(item.TenSp);

#line default
#line hidden
#nullable disable
                WriteLiteral(@"</h5>
                    <div class=""d-flex flex-row"">
                        <div class=""ratings mr-2""><i class=""fa fa-star""></i><i class=""fa fa-star""></i><i class=""fa fa-star""></i><i class=""fa fa-star""></i></div><span>310</span>
                    </div>
                    <div class=""mt-1 mb-1 spec-1""><span>Game ");
#nullable restore
#line 50 "C:\Users\Thang PC\Downloads\BanGameBanQuyen\BanGameBanQuyen\BanGameBanQuyen\Views\SanPham\Index.cshtml"
                                                        Write(item.MaDmNavigation.TenDm);

#line default
#line hidden
#nullable disable
                WriteLiteral("</span></div>\r\n                    <p class=\"text-justify text-truncate para mb-0\">");
#nullable restore
#line 51 "C:\Users\Thang PC\Downloads\BanGameBanQuyen\BanGameBanQuyen\BanGameBanQuyen\Views\SanPham\Index.cshtml"
                                                               Write(item.MotaSp);

#line default
#line hidden
#nullable disable
                WriteLiteral(@"<br><br></p>
                </div>
                <div class=""align-items-center align-content-center col-md-3 border-left mt-1"">
                    <div class=""d-flex flex-row align-items-center"">
                        <h5 class=""mr-1"" style=""font-weight:900;"">");
#nullable restore
#line 55 "C:\Users\Thang PC\Downloads\BanGameBanQuyen\BanGameBanQuyen\BanGameBanQuyen\Views\SanPham\Index.cshtml"
                                                             Write(item.GiaSp.ToString("#,##0"));

#line default
#line hidden
#nullable disable
                WriteLiteral(" VNĐ</h5><span class=\"strike-text\">");
#nullable restore
#line 55 "C:\Users\Thang PC\Downloads\BanGameBanQuyen\BanGameBanQuyen\BanGameBanQuyen\Views\SanPham\Index.cshtml"
                                                                                                                             Write(item.GiaSp.ToString("#,##0"));

#line default
#line hidden
#nullable disable
                WriteLiteral(" VNĐ</span>\r\n                    </div>\r\n                    <small class=\"text-success\">Bán chạy</small>\r\n                    <div class=\"d-flex flex-column mt-4\">\r\n                        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b7f7b5ff9ecbb39a22ac3c30d0be619851325bcb12282", async() => {
                    WriteLiteral("Xem");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
                if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
                {
                    throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
                }
                BeginWriteTagHelperAttribute();
#nullable restore
#line 59 "C:\Users\Thang PC\Downloads\BanGameBanQuyen\BanGameBanQuyen\BanGameBanQuyen\Views\SanPham\Index.cshtml"
                                                  WriteLiteral(item.MaSp);

#line default
#line hidden
#nullable disable
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                BeginWriteTagHelperAttribute();
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __tagHelperExecutionContext.AddHtmlAttribute("st", Html.Raw(__tagHelperStringValueBuffer), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.Minimized);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                        <button class=\"btn btn-outline-primary btn-sm mt-2\" type=\"button\">Mua Ngay</button></div>\r\n                </div>\r\n            </div>\r\n");
#nullable restore
#line 63 "C:\Users\Thang PC\Downloads\BanGameBanQuyen\BanGameBanQuyen\BanGameBanQuyen\Views\SanPham\Index.cshtml"
           }

#line default
#line hidden
#nullable disable
                WriteLiteral(@"            

        </div>
    </div>
</div>
<script type='text/javascript' src='https://stackpath.bootstrapcdn.com/bootstrap/4.4.1/js/bootstrap.bundle.min.js'></script>
<script type='text/javascript'>var myLink = document.querySelector('a[href=""#""]');
myLink.addEventListener('click', function(e) {
e.preventDefault();
});</script>
                            
");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<BanGameBanQuyen.Models.SanPham>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591