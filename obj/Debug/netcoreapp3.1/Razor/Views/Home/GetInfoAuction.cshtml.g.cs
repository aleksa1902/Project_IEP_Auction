#pragma checksum "D:\GitHub\Project_IEP_Auction\Views\Home\GetInfoAuction.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c8dd3a3dceb4d1ce0f764e7d53545339b55003ae"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_GetInfoAuction), @"mvc.1.0.view", @"/Views/Home/GetInfoAuction.cshtml")]
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
#line 1 "D:\GitHub\Project_IEP_Auction\Views\_ViewImports.cshtml"
using ProjectIepAuction;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\GitHub\Project_IEP_Auction\Views\_ViewImports.cshtml"
using ProjectIepAuction.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\GitHub\Project_IEP_Auction\Views\Home\GetInfoAuction.cshtml"
using X.PagedList.Mvc.Core;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\GitHub\Project_IEP_Auction\Views\Home\GetInfoAuction.cshtml"
using X.PagedList;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c8dd3a3dceb4d1ce0f764e7d53545339b55003ae", @"/Views/Home/GetInfoAuction.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a87ad9899cfc81274681ba05f70a6aab2ec5ecf2", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_GetInfoAuction : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ProjectIepAuction.Models.View.IndexModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/signalr/dist/browser/signalr.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/signalr/dist/browser/signalr.min.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/bid.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 5 "D:\GitHub\Project_IEP_Auction\Views\Home\GetInfoAuction.cshtml"
  
    Layout = "_Layout";
    int i = 0;
    int num = 0;
    string flag;

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 12 "D:\GitHub\Project_IEP_Auction\Views\Home\GetInfoAuction.cshtml"
  
string base64 = Convert.ToBase64String(@Model.auction.image);

#line default
#line hidden
#nullable disable
#nullable restore
#line 15 "D:\GitHub\Project_IEP_Auction\Views\Home\GetInfoAuction.cshtml"
     if(@Model.auction.state == "OPEN"){
        flag = "bg-info";
    }else if(@Model.auction.state == "SOLD"){
        flag = "bg-success";
    }else if(@Model.auction.state == "EXPIRED"){
        flag = "bg-danger";
    }else if(@Model.auction.state == "READY"){
        flag = "bg-primary";
    }else{
        flag = "bg-warning";
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("    \r\n  <div");
            BeginWriteAttribute("class", " class=\"", 622, "\"", 645, 3);
            WriteAttributeValue("", 630, "card", 630, 4, true);
            WriteAttributeValue(" ", 634, "mb-3", 635, 5, true);
#nullable restore
#line 27 "D:\GitHub\Project_IEP_Auction\Views\Home\GetInfoAuction.cshtml"
WriteAttributeValue(" ", 639, flag, 640, 5, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n    <img class=\"card-img-top\"");
            BeginWriteAttribute("src", " src=\"", 678, "\"", 714, 2);
            WriteAttributeValue("", 684, "data:image/png;base64,", 684, 22, true);
#nullable restore
#line 28 "D:\GitHub\Project_IEP_Auction\Views\Home\GetInfoAuction.cshtml"
WriteAttributeValue(" ", 706, base64, 707, 7, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" alt=\"Card image cap\" />\r\n    <div class=\"card-body\">\r\n      <h5 class=\"card-title\">Auction name : ");
#nullable restore
#line 30 "D:\GitHub\Project_IEP_Auction\Views\Home\GetInfoAuction.cshtml"
                                       Write(Model.auction.name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\r\n      <p class=\"card-text\">\r\n        Description : ");
#nullable restore
#line 32 "D:\GitHub\Project_IEP_Auction\Views\Home\GetInfoAuction.cshtml"
                 Write(Model.auction.description);

#line default
#line hidden
#nullable disable
            WriteLiteral(" <br>\r\n        Open auction : ");
#nullable restore
#line 33 "D:\GitHub\Project_IEP_Auction\Views\Home\GetInfoAuction.cshtml"
                  Write(Model.auction.openDate);

#line default
#line hidden
#nullable disable
            WriteLiteral("<br>\r\n        Close auction : ");
#nullable restore
#line 34 "D:\GitHub\Project_IEP_Auction\Views\Home\GetInfoAuction.cshtml"
                   Write(Model.auction.closeDate);

#line default
#line hidden
#nullable disable
            WriteLiteral("<br>\r\n        Auction owner : ");
#nullable restore
#line 35 "D:\GitHub\Project_IEP_Auction\Views\Home\GetInfoAuction.cshtml"
                   Write(Model.auction.owner);

#line default
#line hidden
#nullable disable
            WriteLiteral("<br>\r\n        Time:\r\n");
#nullable restore
#line 37 "D:\GitHub\Project_IEP_Auction\Views\Home\GetInfoAuction.cshtml"
         if(Model.auction.state.Equals("OPEN")){
          i = i + 1;

#line default
#line hidden
#nullable disable
            WriteLiteral("          <div");
            BeginWriteAttribute("id", " id=\"", 1181, "\"", 1228, 1);
#nullable restore
#line 39 "D:\GitHub\Project_IEP_Auction\Views\Home\GetInfoAuction.cshtml"
WriteAttributeValue("", 1186, Html.Raw("changeColor"+@Model.auction.Id), 1186, 42, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                <input type=\"hidden\"");
            BeginWriteAttribute("id", " id=\"", 1268, "\"", 1298, 1);
#nullable restore
#line 40 "D:\GitHub\Project_IEP_Auction\Views\Home\GetInfoAuction.cshtml"
WriteAttributeValue("", 1273, Html.Raw("closeTime"+@i), 1273, 25, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("class", " class=\"", 1299, "\"", 1347, 1);
#nullable restore
#line 40 "D:\GitHub\Project_IEP_Auction\Views\Home\GetInfoAuction.cshtml"
WriteAttributeValue("", 1307, Html.Raw("closeTime"+@Model.auction.Id), 1307, 40, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("value", " value=\"", 1348, "\"", 1408, 1);
#nullable restore
#line 40 "D:\GitHub\Project_IEP_Auction\Views\Home\GetInfoAuction.cshtml"
WriteAttributeValue("", 1356, Model.auction.closeDate.ToString("yyyy,MM,d,H,m,s"), 1356, 52, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("/>\r\n                <div class=\"list-group-item bg-success text-white\" style=\"text-align: center;\"><i class=\"fa fa-clock-o\" aria-hidden=\"true\"></i> <span");
            BeginWriteAttribute("class", " class=\"", 1562, "\"", 1605, 1);
#nullable restore
#line 41 "D:\GitHub\Project_IEP_Auction\Views\Home\GetInfoAuction.cshtml"
WriteAttributeValue("", 1570, Html.Raw("time"+@Model.auction.Id), 1570, 35, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("id", " id=\"", 1606, "\"", 1631, 1);
#nullable restore
#line 41 "D:\GitHub\Project_IEP_Auction\Views\Home\GetInfoAuction.cshtml"
WriteAttributeValue("", 1611, Html.Raw("time"+@i), 1611, 20, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">--:--:--:--</span></div>\r\n              </div>\r\n");
#nullable restore
#line 43 "D:\GitHub\Project_IEP_Auction\Views\Home\GetInfoAuction.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    \r\n      <div class=\"card-footer\">\r\n          Current price:<span");
            BeginWriteAttribute("id", " id=\"", 1760, "\"", 1801, 1);
#nullable restore
#line 46 "D:\GitHub\Project_IEP_Auction\Views\Home\GetInfoAuction.cshtml"
WriteAttributeValue("", 1765, Html.Raw("price"+@Model.auction.Id), 1765, 36, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("> ");
#nullable restore
#line 46 "D:\GitHub\Project_IEP_Auction\Views\Home\GetInfoAuction.cshtml"
                                                                    Write(Model.auction.currentPrice);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </span><br>\r\n          Last bid user : \r\n          <span");
            BeginWriteAttribute("id", " id=\"", 1888, "\"", 1930, 1);
#nullable restore
#line 48 "D:\GitHub\Project_IEP_Auction\Views\Home\GetInfoAuction.cshtml"
WriteAttributeValue("", 1893, Html.Raw("winner"+@Model.auction.Id), 1893, 37, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("> \r\n              ");
#nullable restore
#line 49 "D:\GitHub\Project_IEP_Auction\Views\Home\GetInfoAuction.cshtml"
         Write(Model.winners.Where(u => u.Key == Model.auction.Id).FirstOrDefault().Value);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n          </span><br>\r\n    <input type=\"hidden\"");
            BeginWriteAttribute("id", " id=\"", 2073, "\"", 2103, 1);
#nullable restore
#line 51 "D:\GitHub\Project_IEP_Auction\Views\Home\GetInfoAuction.cshtml"
WriteAttributeValue("", 2078, Html.Raw("auctionId"+@i), 2078, 25, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" name=\"custId\"");
            BeginWriteAttribute("value", " value=\"", 2118, "\"", 2143, 1);
#nullable restore
#line 51 "D:\GitHub\Project_IEP_Auction\Views\Home\GetInfoAuction.cshtml"
WriteAttributeValue("", 2126, Model.auction.Id, 2126, 17, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n    <div class=\"row\"> \r\n");
#nullable restore
#line 53 "D:\GitHub\Project_IEP_Auction\Views\Home\GetInfoAuction.cshtml"
         if(@Model.auction.state == "OPEN"){

#line default
#line hidden
#nullable disable
            WriteLiteral("              <div class=\"col\"");
            BeginWriteAttribute("id", " id = \"", 2247, "\"", 2291, 1);
#nullable restore
#line 54 "D:\GitHub\Project_IEP_Auction\Views\Home\GetInfoAuction.cshtml"
WriteAttributeValue("", 2254, Html.Raw("divBid"+@Model.auction.Id), 2254, 37, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n              <input type=\"button\" class=\"btn btn-success\"");
            BeginWriteAttribute("onclick", " onclick=\"", 2353, "\"", 2387, 3);
            WriteAttributeValue("", 2363, "Bid(\'", 2363, 5, true);
#nullable restore
#line 55 "D:\GitHub\Project_IEP_Auction\Views\Home\GetInfoAuction.cshtml"
WriteAttributeValue("", 2368, Model.auction.Id, 2368, 17, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2385, "\')", 2385, 2, true);
            EndWriteAttribute();
            WriteLiteral(" value=\"Bid\"  />\r\n              </div>\r\n");
#nullable restore
#line 57 "D:\GitHub\Project_IEP_Auction\Views\Home\GetInfoAuction.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"            </div>
  </div>
  </div>
  </div>


<h1>Transaction history</h1><hr>

    <table class=""table"">
    <thead>
        <tr>
         <th >#</th>
         <th >Date</th>
         <th >UserName</th>
         <th >Price</th>
        </tr>
    </thead>
    <tbody>
");
#nullable restore
#line 76 "D:\GitHub\Project_IEP_Auction\Views\Home\GetInfoAuction.cshtml"
        foreach (var item in @Model.bids)
        {
            
            num++;

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\r\n                <th scope=\"row\">");
#nullable restore
#line 81 "D:\GitHub\Project_IEP_Auction\Views\Home\GetInfoAuction.cshtml"
                           Write(num);

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n\r\n                <td>");
#nullable restore
#line 83 "D:\GitHub\Project_IEP_Auction\Views\Home\GetInfoAuction.cshtml"
               Write(item.bidDate);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n\r\n                <td>");
#nullable restore
#line 85 "D:\GitHub\Project_IEP_Auction\Views\Home\GetInfoAuction.cshtml"
               Write(Model.userNames.Where(u => u.Key == item.Id).FirstOrDefault().Value);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n\r\n                <td style=\"font-weight: bold;\">");
#nullable restore
#line 87 "D:\GitHub\Project_IEP_Auction\Views\Home\GetInfoAuction.cshtml"
                                          Write(item.price);

#line default
#line hidden
#nullable disable
            WriteLiteral("$</td>\r\n            </tr>\r\n");
#nullable restore
#line 89 "D:\GitHub\Project_IEP_Auction\Views\Home\GetInfoAuction.cshtml"

           
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\r\n    </table>\r\n\r\n\r\n<div class=\"row justify-content-center\">\r\n");
#nullable restore
#line 97 "D:\GitHub\Project_IEP_Auction\Views\Home\GetInfoAuction.cshtml"
Write(Html.PagedListPager(Model.bids, page => Url.Action("GetInfoAuction", new { page = page }),
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
                WriteLiteral("\r\n    <script>\r\n        $(document).ready(function () {\r\n            $(\'ul.pagination > li.disabled > a\').addClass(\'page-link\');\r\n        });   \r\n    </script>\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c8dd3a3dceb4d1ce0f764e7d53545339b55003ae17222", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c8dd3a3dceb4d1ce0f764e7d53545339b55003ae18322", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c8dd3a3dceb4d1ce0f764e7d53545339b55003ae19422", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n");
            }
            );
            WriteLiteral("\r\n</div>\r\n");
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
