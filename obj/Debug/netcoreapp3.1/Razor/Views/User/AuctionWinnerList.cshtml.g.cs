#pragma checksum "E:\Aleksa\ProjekatIEP\ProjectIepAuction\Views\User\AuctionWinnerList.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "bba250708f52ca8ed22d5797d0f829d6f9792086"
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"bba250708f52ca8ed22d5797d0f829d6f9792086", @"/Views/User/AuctionWinnerList.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a87ad9899cfc81274681ba05f70a6aab2ec5ecf2", @"/Views/_ViewImports.cshtml")]
    public class Views_User_AuctionWinnerList : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ProjectIepAuction.Models.View.AuctionWinnerList>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "E:\Aleksa\ProjekatIEP\ProjectIepAuction\Views\User\AuctionWinnerList.cshtml"
  
    ViewData["Title"] = "Auction list";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 7 "E:\Aleksa\ProjekatIEP\ProjectIepAuction\Views\User\AuctionWinnerList.cshtml"
 if(Model.auctionList.Any()){
    

#line default
#line hidden
#nullable disable
            WriteLiteral("    <h1>Winner auction list</h1><hr>\r\n    <div class=\"card-columns\">\r\n");
#nullable restore
#line 11 "E:\Aleksa\ProjekatIEP\ProjectIepAuction\Views\User\AuctionWinnerList.cshtml"
     foreach(var auction in Model.auctionList){       
        string base64 = Convert.ToBase64String(auction.image);

#line default
#line hidden
#nullable disable
            WriteLiteral("        <div");
            BeginWriteAttribute("id", " id=\"", 347, "\"", 363, 1);
#nullable restore
#line 13 "E:\Aleksa\ProjekatIEP\ProjectIepAuction\Views\User\AuctionWinnerList.cshtml"
WriteAttributeValue("", 352, auction.Id, 352, 11, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n            <div class = \"card\">\r\n                <img class=\"card-img-top\"");
            BeginWriteAttribute("src", " src=\"", 442, "\"", 478, 2);
            WriteAttributeValue("", 448, "data:image/png;base64,", 448, 22, true);
#nullable restore
#line 15 "E:\Aleksa\ProjekatIEP\ProjectIepAuction\Views\User\AuctionWinnerList.cshtml"
WriteAttributeValue(" ", 470, base64, 471, 7, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" alt=\"Card image cap\" />\r\n                <div class = \"card-header\">\r\n                    User Id : ");
#nullable restore
#line 17 "E:\Aleksa\ProjekatIEP\ProjectIepAuction\Views\User\AuctionWinnerList.cshtml"
                         Write(auction.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral(";\r\n                </div>\r\n                <div class = \"card-body\">\r\n                    <h5 class = \"card-title\">");
#nullable restore
#line 20 "E:\Aleksa\ProjekatIEP\ProjectIepAuction\Views\User\AuctionWinnerList.cshtml"
                                        Write(auction.name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\r\n                    <br>\r\n                    ");
#nullable restore
#line 22 "E:\Aleksa\ProjekatIEP\ProjectIepAuction\Views\User\AuctionWinnerList.cshtml"
               Write(auction.description);

#line default
#line hidden
#nullable disable
            WriteLiteral("; (Create date : ");
#nullable restore
#line 22 "E:\Aleksa\ProjekatIEP\ProjectIepAuction\Views\User\AuctionWinnerList.cshtml"
                                                    Write(auction.createDate);

#line default
#line hidden
#nullable disable
            WriteLiteral(", Start date : ");
#nullable restore
#line 22 "E:\Aleksa\ProjekatIEP\ProjectIepAuction\Views\User\AuctionWinnerList.cshtml"
                                                                                      Write(auction.openDate);

#line default
#line hidden
#nullable disable
            WriteLiteral(")<br>\r\n                    Start price : ");
#nullable restore
#line 23 "E:\Aleksa\ProjekatIEP\ProjectIepAuction\Views\User\AuctionWinnerList.cshtml"
                             Write(auction.startPrice);

#line default
#line hidden
#nullable disable
            WriteLiteral(";\r\n                </div>\r\n                <div class=\"card-footer\">\r\n                    <a");
            BeginWriteAttribute("href", " href=\"", 1012, "\"", 1051, 2);
            WriteAttributeValue("", 1019, "/Home/GetInfoAuction/", 1019, 21, true);
#nullable restore
#line 26 "E:\Aleksa\ProjekatIEP\ProjectIepAuction\Views\User\AuctionWinnerList.cshtml"
WriteAttributeValue("", 1040, auction.Id, 1040, 11, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" type=\"button\" class=\"btn btn-info\">Info</a>\r\n                </div>\r\n            </div>\r\n        </div>\r\n");
#nullable restore
#line 30 "E:\Aleksa\ProjekatIEP\ProjectIepAuction\Views\User\AuctionWinnerList.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </div>\r\n");
#nullable restore
#line 32 "E:\Aleksa\ProjekatIEP\ProjectIepAuction\Views\User\AuctionWinnerList.cshtml"
}
else{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <h1>You havent won any auctions.</h1>\r\n");
#nullable restore
#line 35 "E:\Aleksa\ProjekatIEP\ProjectIepAuction\Views\User\AuctionWinnerList.cshtml"
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
