#pragma checksum "E:\Aleksa\ProjekatIEP\ProjectIepAuction\Views\User\EditAuctionList.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0af310759f12ba70ea986b001770a24b85b144a5"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_User_EditAuctionList), @"mvc.1.0.view", @"/Views/User/EditAuctionList.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0af310759f12ba70ea986b001770a24b85b144a5", @"/Views/User/EditAuctionList.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a87ad9899cfc81274681ba05f70a6aab2ec5ecf2", @"/Views/_ViewImports.cshtml")]
    public class Views_User_EditAuctionList : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ProjectIepAuction.Models.View.UserListModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "User", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "CreateAuction", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-primary mb-3"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("width:auto"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-primary"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-asp-controller", new global::Microsoft.AspNetCore.Html.HtmlString("User"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "E:\Aleksa\ProjekatIEP\ProjectIepAuction\Views\User\EditAuctionList.cshtml"
  
    ViewData["Title"] = "Auction list";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Auction List</h1>\r\n\r\n");
#nullable restore
#line 9 "E:\Aleksa\ProjekatIEP\ProjectIepAuction\Views\User\EditAuctionList.cshtml"
 if(Model.auctionList.Any()){

#line default
#line hidden
#nullable disable
            WriteLiteral("    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0af310759f12ba70ea986b001770a24b85b144a55635", async() => {
                WriteLiteral("Add new auction");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n    <div class=\"card-columns\">\r\n");
#nullable restore
#line 12 "E:\Aleksa\ProjekatIEP\ProjectIepAuction\Views\User\EditAuctionList.cshtml"
     foreach(var auction in Model.auctionList){
        

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "E:\Aleksa\ProjekatIEP\ProjectIepAuction\Views\User\EditAuctionList.cshtml"
         if(auction.state == "DRAFT"){
            string base64 = Convert.ToBase64String(auction.image);

#line default
#line hidden
#nullable disable
            WriteLiteral("            <div");
            BeginWriteAttribute("id", " id=\"", 492, "\"", 508, 1);
#nullable restore
#line 15 "E:\Aleksa\ProjekatIEP\ProjectIepAuction\Views\User\EditAuctionList.cshtml"
WriteAttributeValue("", 497, auction.Id, 497, 11, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                <div class = \"card\">\r\n                    <img class=\"card-img-top\"");
            BeginWriteAttribute("src", " src=\"", 595, "\"", 631, 2);
            WriteAttributeValue("", 601, "data:image/png;base64,", 601, 22, true);
#nullable restore
#line 17 "E:\Aleksa\ProjekatIEP\ProjectIepAuction\Views\User\EditAuctionList.cshtml"
WriteAttributeValue(" ", 623, base64, 624, 7, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" alt=\"Card image cap\" />\r\n                    <div class = \"card-header\">\r\n                        Auction Id : ");
#nullable restore
#line 19 "E:\Aleksa\ProjekatIEP\ProjectIepAuction\Views\User\EditAuctionList.cshtml"
                                Write(auction.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral(";\r\n                    </div>\r\n                    <div class = \"card-body\">\r\n                        <h5 class = \"card-title\">");
#nullable restore
#line 22 "E:\Aleksa\ProjekatIEP\ProjectIepAuction\Views\User\EditAuctionList.cshtml"
                                            Write(auction.name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\r\n                        <br>\r\n                        ");
#nullable restore
#line 24 "E:\Aleksa\ProjekatIEP\ProjectIepAuction\Views\User\EditAuctionList.cshtml"
                   Write(auction.description);

#line default
#line hidden
#nullable disable
            WriteLiteral("; (Create date : ");
#nullable restore
#line 24 "E:\Aleksa\ProjekatIEP\ProjectIepAuction\Views\User\EditAuctionList.cshtml"
                                                        Write(auction.createDate);

#line default
#line hidden
#nullable disable
            WriteLiteral(", Start date : ");
#nullable restore
#line 24 "E:\Aleksa\ProjekatIEP\ProjectIepAuction\Views\User\EditAuctionList.cshtml"
                                                                                          Write(auction.openDate);

#line default
#line hidden
#nullable disable
            WriteLiteral(")<br>\r\n                        Start price : ");
#nullable restore
#line 25 "E:\Aleksa\ProjekatIEP\ProjectIepAuction\Views\User\EditAuctionList.cshtml"
                                 Write(auction.startPrice);

#line default
#line hidden
#nullable disable
            WriteLiteral(";\r\n                    </div>\r\n                    <div class = \"card-footer\">\r\n                        <button type=\"button\" class=\"btn btn-success\"");
            BeginWriteAttribute("onclick", " onclick=\"", 1257, "\"", 1293, 3);
            WriteAttributeValue("", 1267, "editAuction(\'", 1267, 13, true);
#nullable restore
#line 28 "E:\Aleksa\ProjekatIEP\ProjectIepAuction\Views\User\EditAuctionList.cshtml"
WriteAttributeValue("", 1280, auction.Id, 1280, 11, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1291, "\')", 1291, 2, true);
            EndWriteAttribute();
            WriteLiteral(">Edit</button>\r\n                    </div>\r\n                </div>\r\n            </div>\r\n");
#nullable restore
#line 32 "E:\Aleksa\ProjekatIEP\ProjectIepAuction\Views\User\EditAuctionList.cshtml"
        }else if(auction.state == "OPEN"){
            string base64 = Convert.ToBase64String(auction.image);

#line default
#line hidden
#nullable disable
            WriteLiteral("            <div");
            BeginWriteAttribute("id", " id=\"", 1510, "\"", 1526, 1);
#nullable restore
#line 34 "E:\Aleksa\ProjekatIEP\ProjectIepAuction\Views\User\EditAuctionList.cshtml"
WriteAttributeValue("", 1515, auction.Id, 1515, 11, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                <div class = \"card bg-success\">\r\n                    <img class=\"card-img-top\"");
            BeginWriteAttribute("src", " src=\"", 1624, "\"", 1660, 2);
            WriteAttributeValue("", 1630, "data:image/png;base64,", 1630, 22, true);
#nullable restore
#line 36 "E:\Aleksa\ProjekatIEP\ProjectIepAuction\Views\User\EditAuctionList.cshtml"
WriteAttributeValue(" ", 1652, base64, 1653, 7, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" alt=\"Card image cap\" />\r\n                    <div class = \"card-header\">\r\n                        Auction Id : ");
#nullable restore
#line 38 "E:\Aleksa\ProjekatIEP\ProjectIepAuction\Views\User\EditAuctionList.cshtml"
                                Write(auction.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral(";\r\n                    </div>\r\n                    <div class = \"card-body\">\r\n                        <h5 class = \"card-title\">");
#nullable restore
#line 41 "E:\Aleksa\ProjekatIEP\ProjectIepAuction\Views\User\EditAuctionList.cshtml"
                                            Write(auction.name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\r\n                        <br>\r\n                        ");
#nullable restore
#line 43 "E:\Aleksa\ProjekatIEP\ProjectIepAuction\Views\User\EditAuctionList.cshtml"
                   Write(auction.description);

#line default
#line hidden
#nullable disable
            WriteLiteral("; (Create date : ");
#nullable restore
#line 43 "E:\Aleksa\ProjekatIEP\ProjectIepAuction\Views\User\EditAuctionList.cshtml"
                                                        Write(auction.createDate);

#line default
#line hidden
#nullable disable
            WriteLiteral(", Start date : ");
#nullable restore
#line 43 "E:\Aleksa\ProjekatIEP\ProjectIepAuction\Views\User\EditAuctionList.cshtml"
                                                                                          Write(auction.openDate);

#line default
#line hidden
#nullable disable
            WriteLiteral(")<br>\r\n                        Start price : ");
#nullable restore
#line 44 "E:\Aleksa\ProjekatIEP\ProjectIepAuction\Views\User\EditAuctionList.cshtml"
                                 Write(auction.startPrice);

#line default
#line hidden
#nullable disable
            WriteLiteral(";\r\n                    </div>\r\n                    <div class = \"card-footer\">\r\n                        <a");
            BeginWriteAttribute("href", " href=\"", 2243, "\"", 2282, 2);
            WriteAttributeValue("", 2250, "/Home/GetInfoAuction/", 2250, 21, true);
#nullable restore
#line 47 "E:\Aleksa\ProjekatIEP\ProjectIepAuction\Views\User\EditAuctionList.cshtml"
WriteAttributeValue("", 2271, auction.Id, 2271, 11, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" type=\"button\" class=\"btn btn-info\">Info</a>\r\n                    </div>\r\n                </div>\r\n            </div>\r\n");
#nullable restore
#line 51 "E:\Aleksa\ProjekatIEP\ProjectIepAuction\Views\User\EditAuctionList.cshtml"
        }else if(auction.state == "DELETED"){
            string base64 = Convert.ToBase64String(auction.image);

#line default
#line hidden
#nullable disable
            WriteLiteral("            <div");
            BeginWriteAttribute("id", " id=\"", 2532, "\"", 2548, 1);
#nullable restore
#line 53 "E:\Aleksa\ProjekatIEP\ProjectIepAuction\Views\User\EditAuctionList.cshtml"
WriteAttributeValue("", 2537, auction.Id, 2537, 11, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                <div class = \"card bg-danger\">\r\n                    <img class=\"card-img-top\"");
            BeginWriteAttribute("src", " src=\"", 2645, "\"", 2681, 2);
            WriteAttributeValue("", 2651, "data:image/png;base64,", 2651, 22, true);
#nullable restore
#line 55 "E:\Aleksa\ProjekatIEP\ProjectIepAuction\Views\User\EditAuctionList.cshtml"
WriteAttributeValue(" ", 2673, base64, 2674, 7, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" alt=\"Card image cap\" />\r\n                    <div class = \"card-header\">\r\n                        Auction Id : ");
#nullable restore
#line 57 "E:\Aleksa\ProjekatIEP\ProjectIepAuction\Views\User\EditAuctionList.cshtml"
                                Write(auction.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral(";\r\n                    </div>\r\n                    <div class = \"card-body\">\r\n                        <h5 class = \"card-title\">");
#nullable restore
#line 60 "E:\Aleksa\ProjekatIEP\ProjectIepAuction\Views\User\EditAuctionList.cshtml"
                                            Write(auction.name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\r\n                        <br>\r\n                        ");
#nullable restore
#line 62 "E:\Aleksa\ProjekatIEP\ProjectIepAuction\Views\User\EditAuctionList.cshtml"
                   Write(auction.description);

#line default
#line hidden
#nullable disable
            WriteLiteral("; (Create date : ");
#nullable restore
#line 62 "E:\Aleksa\ProjekatIEP\ProjectIepAuction\Views\User\EditAuctionList.cshtml"
                                                        Write(auction.createDate);

#line default
#line hidden
#nullable disable
            WriteLiteral(", Start date : ");
#nullable restore
#line 62 "E:\Aleksa\ProjekatIEP\ProjectIepAuction\Views\User\EditAuctionList.cshtml"
                                                                                          Write(auction.openDate);

#line default
#line hidden
#nullable disable
            WriteLiteral(")<br>\r\n                        Start price : ");
#nullable restore
#line 63 "E:\Aleksa\ProjekatIEP\ProjectIepAuction\Views\User\EditAuctionList.cshtml"
                                 Write(auction.startPrice);

#line default
#line hidden
#nullable disable
            WriteLiteral(";\r\n                    </div>\r\n                    <div class = \"card-footer\">\r\n                        <a");
            BeginWriteAttribute("href", " href=\"", 3264, "\"", 3303, 2);
            WriteAttributeValue("", 3271, "/Home/GetInfoAuction/", 3271, 21, true);
#nullable restore
#line 66 "E:\Aleksa\ProjekatIEP\ProjectIepAuction\Views\User\EditAuctionList.cshtml"
WriteAttributeValue("", 3292, auction.Id, 3292, 11, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" type=\"button\" class=\"btn btn-info\">Info</a>\r\n                    </div>\r\n                </div>\r\n            </div>\r\n");
#nullable restore
#line 70 "E:\Aleksa\ProjekatIEP\ProjectIepAuction\Views\User\EditAuctionList.cshtml"
        }else{
            string base64 = Convert.ToBase64String(auction.image);

#line default
#line hidden
#nullable disable
            WriteLiteral("            <div");
            BeginWriteAttribute("id", " id=\"", 3522, "\"", 3538, 1);
#nullable restore
#line 72 "E:\Aleksa\ProjekatIEP\ProjectIepAuction\Views\User\EditAuctionList.cshtml"
WriteAttributeValue("", 3527, auction.Id, 3527, 11, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                <div class = \"card bg-secondary\">\r\n                    <img class=\"card-img-top\"");
            BeginWriteAttribute("src", " src=\"", 3638, "\"", 3674, 2);
            WriteAttributeValue("", 3644, "data:image/png;base64,", 3644, 22, true);
#nullable restore
#line 74 "E:\Aleksa\ProjekatIEP\ProjectIepAuction\Views\User\EditAuctionList.cshtml"
WriteAttributeValue(" ", 3666, base64, 3667, 7, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" alt=\"Card image cap\" />\r\n                    <div class = \"card-header\">\r\n                        Auction Id : ");
#nullable restore
#line 76 "E:\Aleksa\ProjekatIEP\ProjectIepAuction\Views\User\EditAuctionList.cshtml"
                                Write(auction.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral(";\r\n                    </div>\r\n                    <div class = \"card-body\">\r\n                        <h5 class = \"card-title\">");
#nullable restore
#line 79 "E:\Aleksa\ProjekatIEP\ProjectIepAuction\Views\User\EditAuctionList.cshtml"
                                            Write(auction.name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\r\n                        <br>\r\n                        ");
#nullable restore
#line 81 "E:\Aleksa\ProjekatIEP\ProjectIepAuction\Views\User\EditAuctionList.cshtml"
                   Write(auction.description);

#line default
#line hidden
#nullable disable
            WriteLiteral("; (Create date : ");
#nullable restore
#line 81 "E:\Aleksa\ProjekatIEP\ProjectIepAuction\Views\User\EditAuctionList.cshtml"
                                                        Write(auction.createDate);

#line default
#line hidden
#nullable disable
            WriteLiteral(", Start date : ");
#nullable restore
#line 81 "E:\Aleksa\ProjekatIEP\ProjectIepAuction\Views\User\EditAuctionList.cshtml"
                                                                                          Write(auction.openDate);

#line default
#line hidden
#nullable disable
            WriteLiteral(")<br>\r\n                        Start price : ");
#nullable restore
#line 82 "E:\Aleksa\ProjekatIEP\ProjectIepAuction\Views\User\EditAuctionList.cshtml"
                                 Write(auction.startPrice);

#line default
#line hidden
#nullable disable
            WriteLiteral(";\r\n                    </div>\r\n                    <div class = \"card-footer\">\r\n                        <a");
            BeginWriteAttribute("href", " href=\"", 4257, "\"", 4296, 2);
            WriteAttributeValue("", 4264, "/Home/GetInfoAuction/", 4264, 21, true);
#nullable restore
#line 85 "E:\Aleksa\ProjekatIEP\ProjectIepAuction\Views\User\EditAuctionList.cshtml"
WriteAttributeValue("", 4285, auction.Id, 4285, 11, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" type=\"button\" class=\"btn btn-info\">Info</a>\r\n                    </div>\r\n                </div>\r\n            </div>\r\n");
#nullable restore
#line 89 "E:\Aleksa\ProjekatIEP\ProjectIepAuction\Views\User\EditAuctionList.cshtml"
        }

#line default
#line hidden
#nullable disable
#nullable restore
#line 89 "E:\Aleksa\ProjekatIEP\ProjectIepAuction\Views\User\EditAuctionList.cshtml"
         
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </div>\r\n");
#nullable restore
#line 92 "E:\Aleksa\ProjekatIEP\ProjectIepAuction\Views\User\EditAuctionList.cshtml"
}
else{

#line default
#line hidden
#nullable disable
            WriteLiteral(@"    <div class = ""card"">
        <div class = ""card-header"">
            No auctions created yet
        </div>
        <div class = ""card-body"">
            <h5 class = ""card-title"">
                Use the button below to create a auction
            </h5>
            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0af310759f12ba70ea986b001770a24b85b144a523662", async() => {
                WriteLiteral("\r\n                Add new auction\r\n            ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n        </div>\r\n    </div>     \r\n");
#nullable restore
#line 107 "E:\Aleksa\ProjekatIEP\ProjectIepAuction\Views\User\EditAuctionList.cshtml"
}

#line default
#line hidden
#nullable disable
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ProjectIepAuction.Models.View.UserListModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
