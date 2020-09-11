#pragma checksum "D:\GitHub\Project_IEP_Auction\Views\User\AuctionWinnerList.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "42023350c30f8ce7c554caa6668246a4cbdc3793"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_User_AuctionWinnerList), @"mvc.1.0.view", @"/Views/User/AuctionWinnerList.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"42023350c30f8ce7c554caa6668246a4cbdc3793", @"/Views/User/AuctionWinnerList.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a87ad9899cfc81274681ba05f70a6aab2ec5ecf2", @"/Views/_ViewImports.cshtml")]
    public class Views_User_AuctionWinnerList : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ProjectIepAuction.Models.View.AuctionWinnerList>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "D:\GitHub\Project_IEP_Auction\Views\User\AuctionWinnerList.cshtml"
  
    ViewData["Title"] = "Auction list";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 7 "D:\GitHub\Project_IEP_Auction\Views\User\AuctionWinnerList.cshtml"
 if(Model.auctionList.Any()){


#line default
#line hidden
#nullable disable
            WriteLiteral("<div class=\"album\">\r\n  <div class=\"container\">\r\n    <div class=\"row\">\r\n\r\n    <h1>Winner auction list</h1><hr>\r\n\r\n");
#nullable restore
#line 15 "D:\GitHub\Project_IEP_Auction\Views\User\AuctionWinnerList.cshtml"
     foreach(var auction in Model.auctionList){       
        string base64 = Convert.ToBase64String(auction.image);

#line default
#line hidden
#nullable disable
            WriteLiteral("        <div");
            BeginWriteAttribute("id", " id=\"", 386, "\"", 402, 1);
#nullable restore
#line 17 "D:\GitHub\Project_IEP_Auction\Views\User\AuctionWinnerList.cshtml"
WriteAttributeValue("", 391, auction.Id, 391, 11, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"col-md-3\">\r\n        <div class=\"card mb-2 box-shadow\">\r\n                <img class=\"card-img-top\"");
            BeginWriteAttribute("src", " src=\"", 508, "\"", 544, 2);
            WriteAttributeValue("", 514, "data:image/png;base64,", 514, 22, true);
#nullable restore
#line 19 "D:\GitHub\Project_IEP_Auction\Views\User\AuctionWinnerList.cshtml"
WriteAttributeValue(" ", 536, base64, 537, 7, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" alt=\"Card image cap\" />\r\n                <div class = \"card-header\">\r\n                    User Id : ");
#nullable restore
#line 21 "D:\GitHub\Project_IEP_Auction\Views\User\AuctionWinnerList.cshtml"
                         Write(auction.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral(";\r\n                </div>\r\n                <div class = \"card-body\">\r\n                    <h5 class = \"card-title\">");
#nullable restore
#line 24 "D:\GitHub\Project_IEP_Auction\Views\User\AuctionWinnerList.cshtml"
                                        Write(auction.name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\r\n                    <br>\r\n                    ");
#nullable restore
#line 26 "D:\GitHub\Project_IEP_Auction\Views\User\AuctionWinnerList.cshtml"
               Write(auction.description);

#line default
#line hidden
#nullable disable
            WriteLiteral("; (Create date : ");
#nullable restore
#line 26 "D:\GitHub\Project_IEP_Auction\Views\User\AuctionWinnerList.cshtml"
                                                    Write(auction.createDate);

#line default
#line hidden
#nullable disable
            WriteLiteral(",<br> Start date : ");
#nullable restore
#line 26 "D:\GitHub\Project_IEP_Auction\Views\User\AuctionWinnerList.cshtml"
                                                                                          Write(auction.openDate);

#line default
#line hidden
#nullable disable
            WriteLiteral(",<br> Close date: ");
#nullable restore
#line 26 "D:\GitHub\Project_IEP_Auction\Views\User\AuctionWinnerList.cshtml"
                                                                                                                             Write(auction.closeDate);

#line default
#line hidden
#nullable disable
            WriteLiteral(")<br>\r\n                    Price : ");
#nullable restore
#line 27 "D:\GitHub\Project_IEP_Auction\Views\User\AuctionWinnerList.cshtml"
                       Write(auction.currentPrice);

#line default
#line hidden
#nullable disable
            WriteLiteral(";\r\n                </div>\r\n                <div class=\"card-footer\">\r\n                    <a");
            BeginWriteAttribute("href", " href=\"", 1114, "\"", 1153, 2);
            WriteAttributeValue("", 1121, "/Home/GetInfoAuction/", 1121, 21, true);
#nullable restore
#line 30 "D:\GitHub\Project_IEP_Auction\Views\User\AuctionWinnerList.cshtml"
WriteAttributeValue("", 1142, auction.Id, 1142, 11, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" type=\"button\" class=\"btn btn-info\">Info</a>\r\n                </div>\r\n            </div>\r\n        </div>\r\n");
#nullable restore
#line 34 "D:\GitHub\Project_IEP_Auction\Views\User\AuctionWinnerList.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("   </div>\r\n  </div>\r\n</div>\r\n");
#nullable restore
#line 38 "D:\GitHub\Project_IEP_Auction\Views\User\AuctionWinnerList.cshtml"
}
else{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <h1>You havent won any auctions.</h1>\r\n");
#nullable restore
#line 41 "D:\GitHub\Project_IEP_Auction\Views\User\AuctionWinnerList.cshtml"
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ProjectIepAuction.Models.View.AuctionWinnerList> Html { get; private set; }
    }
}
#pragma warning restore 1591
