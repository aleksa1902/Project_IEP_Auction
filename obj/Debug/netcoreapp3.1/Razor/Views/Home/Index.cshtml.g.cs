#pragma checksum "E:\Aleksa\ProjekatIEP\ProjectIepAuction\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "aa59d7bc208bca186acb071cf3972b64f3b2f788"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
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
#line 1 "E:\Aleksa\ProjekatIEP\ProjectIepAuction\Views\_ViewImports.cshtml"
using ProjectIepAuction;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "E:\Aleksa\ProjekatIEP\ProjectIepAuction\Views\_ViewImports.cshtml"
using ProjectIepAuction.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "E:\Aleksa\ProjekatIEP\ProjectIepAuction\Views\Home\Index.cshtml"
using X.PagedList.Mvc.Core;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "E:\Aleksa\ProjekatIEP\ProjectIepAuction\Views\Home\Index.cshtml"
using X.PagedList;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"aa59d7bc208bca186acb071cf3972b64f3b2f788", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a87ad9899cfc81274681ba05f70a6aab2ec5ecf2", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ProjectIepAuction.Models.View.IndexModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 5 "E:\Aleksa\ProjekatIEP\ProjectIepAuction\Views\Home\Index.cshtml"
  
  ViewData["Title"] = "Home Page";
  int num = 0;

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    <div class=\"card-columns\">\r\n");
#nullable restore
#line 11 "E:\Aleksa\ProjekatIEP\ProjectIepAuction\Views\Home\Index.cshtml"
         foreach (var auction in @Model.auctionsList)
        {
           string base64 = Convert.ToBase64String(auction.image);



#line default
#line hidden
#nullable disable
            WriteLiteral("        <div class=\"card\">\r\n          <img class=\"card-img-top\"");
            BeginWriteAttribute("src", " src=\"", 397, "\"", 433, 2);
            WriteAttributeValue("", 403, "data:image/png;base64,", 403, 22, true);
#nullable restore
#line 17 "E:\Aleksa\ProjekatIEP\ProjectIepAuction\Views\Home\Index.cshtml"
WriteAttributeValue(" ", 425, base64, 426, 7, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" alt=\"Card image cap\" />\r\n          <div class=\"card-body\">\r\n            <h5 class=\"card-title\">Name : ");
#nullable restore
#line 19 "E:\Aleksa\ProjekatIEP\ProjectIepAuction\Views\Home\Index.cshtml"
                                     Write(auction.name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\r\n            <p class=\"card-text\">\r\n              Current price: ");
#nullable restore
#line 21 "E:\Aleksa\ProjekatIEP\ProjectIepAuction\Views\Home\Index.cshtml"
                        Write(auction.currentPrice);

#line default
#line hidden
#nullable disable
            WriteLiteral("<br>\r\n              Last bid user : <hr>\r\n              Time :\r\n            </p>\r\n          </div>\r\n          <div class=\"card-footer\">\r\n            <button type=\"button\" class=\"btn btn-success\">Bid</button>\r\n            <a");
            BeginWriteAttribute("href", " href=\"", 865, "\"", 904, 2);
            WriteAttributeValue("", 872, "/Home/GetInfoAuction/", 872, 21, true);
#nullable restore
#line 28 "E:\Aleksa\ProjekatIEP\ProjectIepAuction\Views\Home\Index.cshtml"
WriteAttributeValue("", 893, auction.Id, 893, 11, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" type=\"button\" class=\"btn btn-info\">Info</a>\r\n          </div>\r\n        </div>\r\n");
#nullable restore
#line 31 "E:\Aleksa\ProjekatIEP\ProjectIepAuction\Views\Home\Index.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n\r\n<div class=\"row justify-content-center\">\r\n");
#nullable restore
#line 35 "E:\Aleksa\ProjekatIEP\ProjectIepAuction\Views\Home\Index.cshtml"
Write(Html.PagedListPager(Model.auctionsList, page => Url.Action("Index", new { page = page }),
    new X.PagedList.Web.Common.PagedListRenderOptionsBase
    {
        DisplayPageCountAndCurrentLocation = true,
        ContainerDivClasses = new[] { "navigation" },
        LiElementClasses = new[] { "page-item" },
        PageClasses = new[] { "page-link" }
    }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n");
            DefineSection("Scripts", async() => {
                WriteLiteral("\r\n    <script>\r\n        $(document).ready(function () {\r\n            $(\'ul.pagination > li.disabled > a\').addClass(\'page-link\');\r\n        });\r\n    </script>\r\n");
            }
            );
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ProjectIepAuction.Models.View.IndexModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
