#pragma checksum "E:\Aleksa\ProjekatIEP\ProjectIepAuction\Views\User\EditAuctionList.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "bcbd6ac54e2a752aca9ae349f6591bb985f0eaf1"
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"bcbd6ac54e2a752aca9ae349f6591bb985f0eaf1", @"/Views/User/EditAuctionList.cshtml")]
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
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "bcbd6ac54e2a752aca9ae349f6591bb985f0eaf15635", async() => {
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
            WriteLiteral("; DRAFT\r\n                    </div>\r\n                    <div class = \"card-body\">\r\n                        <h5 class = \"card-title\">");
#nullable restore
#line 22 "E:\Aleksa\ProjekatIEP\ProjectIepAuction\Views\User\EditAuctionList.cshtml"
                                            Write(auction.name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\r\n                        <br>\r\n                        Create date : ");
#nullable restore
#line 24 "E:\Aleksa\ProjekatIEP\ProjectIepAuction\Views\User\EditAuctionList.cshtml"
                                 Write(auction.createDate);

#line default
#line hidden
#nullable disable
            WriteLiteral("<br>\r\n                        Start date : ");
#nullable restore
#line 25 "E:\Aleksa\ProjekatIEP\ProjectIepAuction\Views\User\EditAuctionList.cshtml"
                                Write(auction.openDate);

#line default
#line hidden
#nullable disable
            WriteLiteral("<br>\r\n                        Close date : ");
#nullable restore
#line 26 "E:\Aleksa\ProjekatIEP\ProjectIepAuction\Views\User\EditAuctionList.cshtml"
                                Write(auction.closeDate);

#line default
#line hidden
#nullable disable
            WriteLiteral("<br>\r\n                        Start price : ");
#nullable restore
#line 27 "E:\Aleksa\ProjekatIEP\ProjectIepAuction\Views\User\EditAuctionList.cshtml"
                                 Write(auction.startPrice);

#line default
#line hidden
#nullable disable
            WriteLiteral(";\r\n                    </div>\r\n                    <div class = \"card-footer\">\r\n                        <a");
            BeginWriteAttribute("href", " href=\"", 1285, "\"", 1321, 2);
            WriteAttributeValue("", 1292, "/User/EditAuction/", 1292, 18, true);
#nullable restore
#line 30 "E:\Aleksa\ProjekatIEP\ProjectIepAuction\Views\User\EditAuctionList.cshtml"
WriteAttributeValue("", 1310, auction.Id, 1310, 11, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" type=\"button\" class=\"btn btn-success\">Edit</a>\r\n                        <a");
            BeginWriteAttribute("href", " href=\"", 1397, "\"", 1436, 2);
            WriteAttributeValue("", 1404, "/Home/GetInfoAuction/", 1404, 21, true);
#nullable restore
#line 31 "E:\Aleksa\ProjekatIEP\ProjectIepAuction\Views\User\EditAuctionList.cshtml"
WriteAttributeValue("", 1425, auction.Id, 1425, 11, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" type=\"button\" class=\"btn btn-info\">Info</a>\r\n                    </div>\r\n                </div>\r\n            </div>\r\n");
#nullable restore
#line 35 "E:\Aleksa\ProjekatIEP\ProjectIepAuction\Views\User\EditAuctionList.cshtml"
        }else if(auction.state == "OPEN"){
            string base64 = Convert.ToBase64String(auction.image);

#line default
#line hidden
#nullable disable
            WriteLiteral("            <div");
            BeginWriteAttribute("id", " id=\"", 1683, "\"", 1699, 1);
#nullable restore
#line 37 "E:\Aleksa\ProjekatIEP\ProjectIepAuction\Views\User\EditAuctionList.cshtml"
WriteAttributeValue("", 1688, auction.Id, 1688, 11, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                <div class = \"card bg-success\">\r\n                    <img class=\"card-img-top\"");
            BeginWriteAttribute("src", " src=\"", 1797, "\"", 1833, 2);
            WriteAttributeValue("", 1803, "data:image/png;base64,", 1803, 22, true);
#nullable restore
#line 39 "E:\Aleksa\ProjekatIEP\ProjectIepAuction\Views\User\EditAuctionList.cshtml"
WriteAttributeValue(" ", 1825, base64, 1826, 7, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" alt=\"Card image cap\" />\r\n                    <div class = \"card-header\">\r\n                        Auction Id : ");
#nullable restore
#line 41 "E:\Aleksa\ProjekatIEP\ProjectIepAuction\Views\User\EditAuctionList.cshtml"
                                Write(auction.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("; OPEN\r\n                    </div>\r\n                    <div class = \"card-body\">\r\n                        <h5 class = \"card-title\">");
#nullable restore
#line 44 "E:\Aleksa\ProjekatIEP\ProjectIepAuction\Views\User\EditAuctionList.cshtml"
                                            Write(auction.name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\r\n                        <br>\r\n                        Create date : ");
#nullable restore
#line 46 "E:\Aleksa\ProjekatIEP\ProjectIepAuction\Views\User\EditAuctionList.cshtml"
                                 Write(auction.createDate);

#line default
#line hidden
#nullable disable
            WriteLiteral("<br>\r\n                        Start date : ");
#nullable restore
#line 47 "E:\Aleksa\ProjekatIEP\ProjectIepAuction\Views\User\EditAuctionList.cshtml"
                                Write(auction.openDate);

#line default
#line hidden
#nullable disable
            WriteLiteral("<br>\r\n                        Close date : ");
#nullable restore
#line 48 "E:\Aleksa\ProjekatIEP\ProjectIepAuction\Views\User\EditAuctionList.cshtml"
                                Write(auction.closeDate);

#line default
#line hidden
#nullable disable
            WriteLiteral("<br>\r\n                        Start price : ");
#nullable restore
#line 49 "E:\Aleksa\ProjekatIEP\ProjectIepAuction\Views\User\EditAuctionList.cshtml"
                                 Write(auction.startPrice);

#line default
#line hidden
#nullable disable
            WriteLiteral(";\r\n                    </div>\r\n                    <div class = \"card-footer\">\r\n                        <a");
            BeginWriteAttribute("href", " href=\"", 2486, "\"", 2525, 2);
            WriteAttributeValue("", 2493, "/Home/GetInfoAuction/", 2493, 21, true);
#nullable restore
#line 52 "E:\Aleksa\ProjekatIEP\ProjectIepAuction\Views\User\EditAuctionList.cshtml"
WriteAttributeValue("", 2514, auction.Id, 2514, 11, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" type=\"button\" class=\"btn btn-info\">Info</a>\r\n                    </div>\r\n                </div>\r\n            </div>\r\n");
#nullable restore
#line 56 "E:\Aleksa\ProjekatIEP\ProjectIepAuction\Views\User\EditAuctionList.cshtml"
        }else if(auction.state == "DELETED"){
            string base64 = Convert.ToBase64String(auction.image);

#line default
#line hidden
#nullable disable
            WriteLiteral("            <div");
            BeginWriteAttribute("id", " id=\"", 2775, "\"", 2791, 1);
#nullable restore
#line 58 "E:\Aleksa\ProjekatIEP\ProjectIepAuction\Views\User\EditAuctionList.cshtml"
WriteAttributeValue("", 2780, auction.Id, 2780, 11, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                <div class = \"card bg-danger\">\r\n                    <img class=\"card-img-top\"");
            BeginWriteAttribute("src", " src=\"", 2888, "\"", 2924, 2);
            WriteAttributeValue("", 2894, "data:image/png;base64,", 2894, 22, true);
#nullable restore
#line 60 "E:\Aleksa\ProjekatIEP\ProjectIepAuction\Views\User\EditAuctionList.cshtml"
WriteAttributeValue(" ", 2916, base64, 2917, 7, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" alt=\"Card image cap\" />\r\n                    <div class = \"card-header\">\r\n                        Auction Id : ");
#nullable restore
#line 62 "E:\Aleksa\ProjekatIEP\ProjectIepAuction\Views\User\EditAuctionList.cshtml"
                                Write(auction.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("; DELETED\r\n                    </div>\r\n                    <div class = \"card-body\">\r\n                        <h5 class = \"card-title\">");
#nullable restore
#line 65 "E:\Aleksa\ProjekatIEP\ProjectIepAuction\Views\User\EditAuctionList.cshtml"
                                            Write(auction.name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\r\n                        <br>\r\n                        Create date : ");
#nullable restore
#line 67 "E:\Aleksa\ProjekatIEP\ProjectIepAuction\Views\User\EditAuctionList.cshtml"
                                 Write(auction.createDate);

#line default
#line hidden
#nullable disable
            WriteLiteral("<br>\r\n                        Start date : ");
#nullable restore
#line 68 "E:\Aleksa\ProjekatIEP\ProjectIepAuction\Views\User\EditAuctionList.cshtml"
                                Write(auction.openDate);

#line default
#line hidden
#nullable disable
            WriteLiteral("<br>\r\n                        Close date : ");
#nullable restore
#line 69 "E:\Aleksa\ProjekatIEP\ProjectIepAuction\Views\User\EditAuctionList.cshtml"
                                Write(auction.closeDate);

#line default
#line hidden
#nullable disable
            WriteLiteral("<br>\r\n                        Start price : ");
#nullable restore
#line 70 "E:\Aleksa\ProjekatIEP\ProjectIepAuction\Views\User\EditAuctionList.cshtml"
                                 Write(auction.startPrice);

#line default
#line hidden
#nullable disable
            WriteLiteral(";\r\n                    </div>\r\n                    <div class = \"card-footer\">\r\n                        <a");
            BeginWriteAttribute("href", " href=\"", 3580, "\"", 3619, 2);
            WriteAttributeValue("", 3587, "/Home/GetInfoAuction/", 3587, 21, true);
#nullable restore
#line 73 "E:\Aleksa\ProjekatIEP\ProjectIepAuction\Views\User\EditAuctionList.cshtml"
WriteAttributeValue("", 3608, auction.Id, 3608, 11, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" type=\"button\" class=\"btn btn-info\">Info</a>\r\n                    </div>\r\n                </div>\r\n            </div>\r\n");
#nullable restore
#line 77 "E:\Aleksa\ProjekatIEP\ProjectIepAuction\Views\User\EditAuctionList.cshtml"
        }else if(auction.state == "READY"){
            string base64 = Convert.ToBase64String(auction.image);

#line default
#line hidden
#nullable disable
            WriteLiteral("            <div");
            BeginWriteAttribute("id", " id=\"", 3867, "\"", 3883, 1);
#nullable restore
#line 79 "E:\Aleksa\ProjekatIEP\ProjectIepAuction\Views\User\EditAuctionList.cshtml"
WriteAttributeValue("", 3872, auction.Id, 3872, 11, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                <div class = \"card bg-info\">\r\n                    <img class=\"card-img-top\"");
            BeginWriteAttribute("src", " src=\"", 3978, "\"", 4014, 2);
            WriteAttributeValue("", 3984, "data:image/png;base64,", 3984, 22, true);
#nullable restore
#line 81 "E:\Aleksa\ProjekatIEP\ProjectIepAuction\Views\User\EditAuctionList.cshtml"
WriteAttributeValue(" ", 4006, base64, 4007, 7, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" alt=\"Card image cap\" />\r\n                    <div class = \"card-header\">\r\n                        Auction Id : ");
#nullable restore
#line 83 "E:\Aleksa\ProjekatIEP\ProjectIepAuction\Views\User\EditAuctionList.cshtml"
                                Write(auction.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("; READY\r\n                    </div>\r\n                    <div class = \"card-body\">\r\n                        <h5 class = \"card-title\">");
#nullable restore
#line 86 "E:\Aleksa\ProjekatIEP\ProjectIepAuction\Views\User\EditAuctionList.cshtml"
                                            Write(auction.name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\r\n                        <br>\r\n                        Create date : ");
#nullable restore
#line 88 "E:\Aleksa\ProjekatIEP\ProjectIepAuction\Views\User\EditAuctionList.cshtml"
                                 Write(auction.createDate);

#line default
#line hidden
#nullable disable
            WriteLiteral("<br>\r\n                        Start date : ");
#nullable restore
#line 89 "E:\Aleksa\ProjekatIEP\ProjectIepAuction\Views\User\EditAuctionList.cshtml"
                                Write(auction.openDate);

#line default
#line hidden
#nullable disable
            WriteLiteral("<br>\r\n                        Close date : ");
#nullable restore
#line 90 "E:\Aleksa\ProjekatIEP\ProjectIepAuction\Views\User\EditAuctionList.cshtml"
                                Write(auction.closeDate);

#line default
#line hidden
#nullable disable
            WriteLiteral("<br>\r\n                        Start price : ");
#nullable restore
#line 91 "E:\Aleksa\ProjekatIEP\ProjectIepAuction\Views\User\EditAuctionList.cshtml"
                                 Write(auction.startPrice);

#line default
#line hidden
#nullable disable
            WriteLiteral(";\r\n                    </div>\r\n                    <div class = \"card-footer\">\r\n                        <a");
            BeginWriteAttribute("href", " href=\"", 4668, "\"", 4707, 2);
            WriteAttributeValue("", 4675, "/Home/GetInfoAuction/", 4675, 21, true);
#nullable restore
#line 94 "E:\Aleksa\ProjekatIEP\ProjectIepAuction\Views\User\EditAuctionList.cshtml"
WriteAttributeValue("", 4696, auction.Id, 4696, 11, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" type=\"button\" class=\"btn btn-info\">Info</a>\r\n                    </div>\r\n                </div>\r\n            </div>\r\n");
#nullable restore
#line 98 "E:\Aleksa\ProjekatIEP\ProjectIepAuction\Views\User\EditAuctionList.cshtml"
        }else{
            string base64 = Convert.ToBase64String(auction.image);

#line default
#line hidden
#nullable disable
            WriteLiteral("            <div");
            BeginWriteAttribute("id", " id=\"", 4926, "\"", 4942, 1);
#nullable restore
#line 100 "E:\Aleksa\ProjekatIEP\ProjectIepAuction\Views\User\EditAuctionList.cshtml"
WriteAttributeValue("", 4931, auction.Id, 4931, 11, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                <div class = \"card bg-secondary\">\r\n                    <img class=\"card-img-top\"");
            BeginWriteAttribute("src", " src=\"", 5042, "\"", 5078, 2);
            WriteAttributeValue("", 5048, "data:image/png;base64,", 5048, 22, true);
#nullable restore
#line 102 "E:\Aleksa\ProjekatIEP\ProjectIepAuction\Views\User\EditAuctionList.cshtml"
WriteAttributeValue(" ", 5070, base64, 5071, 7, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" alt=\"Card image cap\" />\r\n                    <div class = \"card-header\">\r\n                        Auction Id : ");
#nullable restore
#line 104 "E:\Aleksa\ProjekatIEP\ProjectIepAuction\Views\User\EditAuctionList.cshtml"
                                Write(auction.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("; EXPIRED/SOLD\r\n                    </div>\r\n                    <div class = \"card-body\">\r\n                        <h5 class = \"card-title\">");
#nullable restore
#line 107 "E:\Aleksa\ProjekatIEP\ProjectIepAuction\Views\User\EditAuctionList.cshtml"
                                            Write(auction.name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\r\n                        <br>\r\n                        Create date : ");
#nullable restore
#line 109 "E:\Aleksa\ProjekatIEP\ProjectIepAuction\Views\User\EditAuctionList.cshtml"
                                 Write(auction.createDate);

#line default
#line hidden
#nullable disable
            WriteLiteral("<br>\r\n                        Start date : ");
#nullable restore
#line 110 "E:\Aleksa\ProjekatIEP\ProjectIepAuction\Views\User\EditAuctionList.cshtml"
                                Write(auction.openDate);

#line default
#line hidden
#nullable disable
            WriteLiteral("<br>\r\n                        Close date : ");
#nullable restore
#line 111 "E:\Aleksa\ProjekatIEP\ProjectIepAuction\Views\User\EditAuctionList.cshtml"
                                Write(auction.closeDate);

#line default
#line hidden
#nullable disable
            WriteLiteral("<br>\r\n                        Start price : ");
#nullable restore
#line 112 "E:\Aleksa\ProjekatIEP\ProjectIepAuction\Views\User\EditAuctionList.cshtml"
                                 Write(auction.startPrice);

#line default
#line hidden
#nullable disable
            WriteLiteral(";\r\n                    </div>\r\n                    <div class = \"card-footer\">\r\n                        <a");
            BeginWriteAttribute("href", " href=\"", 5739, "\"", 5778, 2);
            WriteAttributeValue("", 5746, "/Home/GetInfoAuction/", 5746, 21, true);
#nullable restore
#line 115 "E:\Aleksa\ProjekatIEP\ProjectIepAuction\Views\User\EditAuctionList.cshtml"
WriteAttributeValue("", 5767, auction.Id, 5767, 11, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" type=\"button\" class=\"btn btn-info\">Info</a>\r\n                    </div>\r\n                </div>\r\n            </div>\r\n");
#nullable restore
#line 119 "E:\Aleksa\ProjekatIEP\ProjectIepAuction\Views\User\EditAuctionList.cshtml"
        }

#line default
#line hidden
#nullable disable
#nullable restore
#line 119 "E:\Aleksa\ProjekatIEP\ProjectIepAuction\Views\User\EditAuctionList.cshtml"
         
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </div>\r\n");
#nullable restore
#line 122 "E:\Aleksa\ProjekatIEP\ProjectIepAuction\Views\User\EditAuctionList.cshtml"
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
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "bcbd6ac54e2a752aca9ae349f6591bb985f0eaf127992", async() => {
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
#line 137 "E:\Aleksa\ProjekatIEP\ProjectIepAuction\Views\User\EditAuctionList.cshtml"
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
