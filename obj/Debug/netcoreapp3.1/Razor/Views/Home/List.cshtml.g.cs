#pragma checksum "D:\GitHub\Project_IEP_Auction\Views\Home\List.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1d16bae2d784ca357258c7fbacfc57855ce307d1"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_List), @"mvc.1.0.view", @"/Views/Home/List.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1d16bae2d784ca357258c7fbacfc57855ce307d1", @"/Views/Home/List.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a87ad9899cfc81274681ba05f70a6aab2ec5ecf2", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_List : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ProjectIepAuction.Models.View.IndexModel>
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
#line 3 "D:\GitHub\Project_IEP_Auction\Views\Home\List.cshtml"
  
  ViewData["Title"] = "Home Page";
  int i = 0;

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"album\">\r\n    <div class=\"container\">\r\n      <div class=\"row\">\r\n\r\n");
#nullable restore
#line 12 "D:\GitHub\Project_IEP_Auction\Views\Home\List.cshtml"
       foreach (var auction in @Model.auctionsList){
        string base64 = Convert.ToBase64String(auction.image);


#line default
#line hidden
#nullable disable
            WriteLiteral("        <div class=\"col-md-3\">\r\n          <div class=\"card mb-2 box-shadow\"");
            BeginWriteAttribute("id", " id=\"", 384, "\"", 425, 1);
#nullable restore
#line 16 "D:\GitHub\Project_IEP_Auction\Views\Home\List.cshtml"
WriteAttributeValue("", 389, Html.Raw("changeColor"+@auction.Id), 389, 36, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n            <img class=\"card-img-top\"");
            BeginWriteAttribute("src", " src=\"", 466, "\"", 502, 2);
            WriteAttributeValue("", 472, "data:image/png;base64,", 472, 22, true);
#nullable restore
#line 17 "D:\GitHub\Project_IEP_Auction\Views\Home\List.cshtml"
WriteAttributeValue(" ", 494, base64, 495, 7, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" alt=\"Card image cap\" />\r\n          <div class=\"card-body\">\r\n            <h5 class=\"card-title\">Name : ");
#nullable restore
#line 19 "D:\GitHub\Project_IEP_Auction\Views\Home\List.cshtml"
                                     Write(auction.name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\r\n            <p class=\"card-text\">\r\n              Current price:<span");
            BeginWriteAttribute("id", " id=\"", 694, "\"", 729, 1);
#nullable restore
#line 21 "D:\GitHub\Project_IEP_Auction\Views\Home\List.cshtml"
WriteAttributeValue("", 699, Html.Raw("price"+@auction.Id), 699, 30, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("> ");
#nullable restore
#line 21 "D:\GitHub\Project_IEP_Auction\Views\Home\List.cshtml"
                                                                  Write(auction.currentPrice);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </span><br>\r\n              Last bid user : \r\n              <span");
            BeginWriteAttribute("id", " id=\"", 818, "\"", 854, 1);
#nullable restore
#line 23 "D:\GitHub\Project_IEP_Auction\Views\Home\List.cshtml"
WriteAttributeValue("", 823, Html.Raw("winner"+@auction.Id), 823, 31, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("> \r\n                  ");
#nullable restore
#line 24 "D:\GitHub\Project_IEP_Auction\Views\Home\List.cshtml"
             Write(Model.winners.Where(u => u.Key == auction.Id).FirstOrDefault().Value);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </span><hr>\r\n            </p>\r\n            <p class=\"card-text\">\r\n              Time :\r\n");
#nullable restore
#line 29 "D:\GitHub\Project_IEP_Auction\Views\Home\List.cshtml"
               if(auction.state.Equals("OPEN")){
              i = i + 1;

#line default
#line hidden
#nullable disable
            WriteLiteral("              <div");
            BeginWriteAttribute("id", " id=\"", 1146, "\"", 1187, 1);
#nullable restore
#line 31 "D:\GitHub\Project_IEP_Auction\Views\Home\List.cshtml"
WriteAttributeValue("", 1151, Html.Raw("changeColor"+@auction.Id), 1151, 36, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                <input type=\"hidden\"");
            BeginWriteAttribute("id", " id=\"", 1227, "\"", 1257, 1);
#nullable restore
#line 32 "D:\GitHub\Project_IEP_Auction\Views\Home\List.cshtml"
WriteAttributeValue("", 1232, Html.Raw("closeTime"+@i), 1232, 25, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("class", " class=\"", 1258, "\"", 1300, 1);
#nullable restore
#line 32 "D:\GitHub\Project_IEP_Auction\Views\Home\List.cshtml"
WriteAttributeValue("", 1266, Html.Raw("closeTime"+@auction.Id), 1266, 34, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("value", " value=\"", 1301, "\"", 1355, 1);
#nullable restore
#line 32 "D:\GitHub\Project_IEP_Auction\Views\Home\List.cshtml"
WriteAttributeValue("", 1309, auction.closeDate.ToString("yyyy,MM,d,H,m,s"), 1309, 46, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("/>\r\n                <div class=\"list-group-item bg-success text-white\" style=\"text-align: center;\"><i class=\"fa fa-clock-o\" aria-hidden=\"true\"></i> <span");
            BeginWriteAttribute("class", " class=\"", 1509, "\"", 1546, 1);
#nullable restore
#line 33 "D:\GitHub\Project_IEP_Auction\Views\Home\List.cshtml"
WriteAttributeValue("", 1517, Html.Raw("time"+@auction.Id), 1517, 29, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("id", " id=\"", 1547, "\"", 1572, 1);
#nullable restore
#line 33 "D:\GitHub\Project_IEP_Auction\Views\Home\List.cshtml"
WriteAttributeValue("", 1552, Html.Raw("time"+@i), 1552, 20, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">--:--:--:--</span></div>\r\n              </div>\r\n");
#nullable restore
#line 35 "D:\GitHub\Project_IEP_Auction\Views\Home\List.cshtml"
              }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </p>\r\n          </div>\r\n          <div class=\"card-footer\">\r\n            <div class=\"row\"> \r\n              <div class=\"col\"");
            BeginWriteAttribute("id", " id = \"", 1774, "\"", 1812, 1);
#nullable restore
#line 40 "D:\GitHub\Project_IEP_Auction\Views\Home\List.cshtml"
WriteAttributeValue("", 1781, Html.Raw("divBid"+@auction.Id), 1781, 31, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n              <input type=\"button\" class=\"btn btn-success\"");
            BeginWriteAttribute("onclick", " onclick=\"", 1874, "\"", 1902, 3);
            WriteAttributeValue("", 1884, "Bid(\'", 1884, 5, true);
#nullable restore
#line 41 "D:\GitHub\Project_IEP_Auction\Views\Home\List.cshtml"
WriteAttributeValue("", 1889, auction.Id, 1889, 11, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1900, "\')", 1900, 2, true);
            EndWriteAttribute();
            WriteLiteral(" value=\"Bid\"  />\r\n              </div>\r\n              <div class=\"col\">\r\n              <a");
            BeginWriteAttribute("href", " href=\"", 1992, "\"", 2031, 2);
            WriteAttributeValue("", 1999, "/Home/GetInfoAuction/", 1999, 21, true);
#nullable restore
#line 44 "D:\GitHub\Project_IEP_Auction\Views\Home\List.cshtml"
WriteAttributeValue("", 2020, auction.Id, 2020, 11, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" type=\"button\" class=\"btn btn-info\">Info</a>\r\n              </div>\r\n            \r\n            </div>\r\n          </div>\r\n          </div>\r\n        </div>\r\n");
#nullable restore
#line 51 "D:\GitHub\Project_IEP_Auction\Views\Home\List.cshtml"

      }

#line default
#line hidden
#nullable disable
            WriteLiteral("      </div>\r\n    </div>\r\n  </div>\r\n\r\n<div class=\"row justify-content-center pt-5\">\r\n        <nav aria-label=\"Page navigation example\">\r\n            <ul class=\"pagination\">\r\n");
#nullable restore
#line 60 "D:\GitHub\Project_IEP_Auction\Views\Home\List.cshtml"
                 if (Model.currentPage > 1){
                    int previousPage = @Model.currentPage-1;
                    

#line default
#line hidden
#nullable disable
            WriteLiteral("<li class=\"page-item\">\r\n                        <button class=\"page-link\" aria-label=\"Previous\"");
            BeginWriteAttribute("onclick", " onclick=\"", 2594, "\"", 2636, 4);
            WriteAttributeValue("", 2604, "nextPage(", 2604, 9, true);
#nullable restore
#line 63 "D:\GitHub\Project_IEP_Auction\Views\Home\List.cshtml"
WriteAttributeValue("", 2613, Model.currentPage, 2613, 18, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue(" ", 2631, "-", 2632, 2, true);
            WriteAttributeValue(" ", 2633, "1)", 2634, 3, true);
            EndWriteAttribute();
            WriteLiteral(">\r\n                            <span aria-hidden=\"true\"> ");
#nullable restore
#line 64 "D:\GitHub\Project_IEP_Auction\Views\Home\List.cshtml"
                                                 Write(Html.Raw("<"));

#line default
#line hidden
#nullable disable
            WriteLiteral(" </span>\r\n                            <span class=\"sr-only\">Previous</span>\r\n                        </button>\r\n                    </li>   \r\n");
#nullable restore
#line 68 "D:\GitHub\Project_IEP_Auction\Views\Home\List.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 70 "D:\GitHub\Project_IEP_Auction\Views\Home\List.cshtml"
                 for(i = 1; i<=Model.pageNumbers;i++)
                {
                    if(i==Model.currentPage)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <li class=\"page-item active\">\r\n                            <button class=\"page-link\">");
#nullable restore
#line 75 "D:\GitHub\Project_IEP_Auction\Views\Home\List.cshtml"
                                                 Write(i);

#line default
#line hidden
#nullable disable
            WriteLiteral("</button>\r\n                        </li>\r\n");
#nullable restore
#line 77 "D:\GitHub\Project_IEP_Auction\Views\Home\List.cshtml"
                    }
                    else
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <li class=\"page-item\">\r\n                            <button class=\"page-link\"");
            BeginWriteAttribute("onclick", " onclick=\"", 3340, "\"", 3364, 3);
            WriteAttributeValue("", 3350, "nextPage(\'", 3350, 10, true);
#nullable restore
#line 81 "D:\GitHub\Project_IEP_Auction\Views\Home\List.cshtml"
WriteAttributeValue("", 3360, i, 3360, 2, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 3362, "\')", 3362, 2, true);
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 81 "D:\GitHub\Project_IEP_Auction\Views\Home\List.cshtml"
                                                                          Write(i);

#line default
#line hidden
#nullable disable
            WriteLiteral("</button>\r\n                        </li>\r\n");
#nullable restore
#line 83 "D:\GitHub\Project_IEP_Auction\Views\Home\List.cshtml"

                    }

                }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 88 "D:\GitHub\Project_IEP_Auction\Views\Home\List.cshtml"
                 if(Model.currentPage < Model.pageNumbers)
                {
                    int nextPage = @Model.currentPage+1;
                    

#line default
#line hidden
#nullable disable
            WriteLiteral("<li class=\"page-item\">\r\n                        <button class=\"page-link\" aria-label=\"Next\"");
            BeginWriteAttribute("onclick", " onclick=\"", 3706, "\"", 3737, 3);
            WriteAttributeValue("", 3716, "nextPage(\'", 3716, 10, true);
#nullable restore
#line 92 "D:\GitHub\Project_IEP_Auction\Views\Home\List.cshtml"
WriteAttributeValue("", 3726, nextPage, 3726, 9, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 3735, "\')", 3735, 2, true);
            EndWriteAttribute();
            WriteLiteral(">\r\n                            <span aria-hidden=\"true\"> ");
#nullable restore
#line 93 "D:\GitHub\Project_IEP_Auction\Views\Home\List.cshtml"
                                                 Write(Html.Raw(">"));

#line default
#line hidden
#nullable disable
            WriteLiteral(" </span>\r\n                            <span class=\"sr-only\">Next</span>\r\n                        </button>\r\n                    </li>\r\n");
#nullable restore
#line 97 "D:\GitHub\Project_IEP_Auction\Views\Home\List.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </ul>\r\n        </nav>\r\n    </div>\r\n\r\n");
            DefineSection("Scripts", async() => {
                WriteLiteral("\r\n    <script");
                BeginWriteAttribute("src", " src=\"", 4048, "\"", 4082, 1);
#nullable restore
#line 104 "D:\GitHub\Project_IEP_Auction\Views\Home\List.cshtml"
WriteAttributeValue("", 4054, Url.Content("~/js/site.js"), 4054, 28, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral("></script>\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1d16bae2d784ca357258c7fbacfc57855ce307d118009", async() => {
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
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1d16bae2d784ca357258c7fbacfc57855ce307d119109", async() => {
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
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1d16bae2d784ca357258c7fbacfc57855ce307d120209", async() => {
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