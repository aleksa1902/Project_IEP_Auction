#pragma checksum "E:\Aleksa\ProjekatIEP\ProjectIepAuction\Views\Administrator\AuctionList.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d0065eba128b351a0be38fdf5b6e054d55f2ff05"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Administrator_AuctionList), @"mvc.1.0.view", @"/Views/Administrator/AuctionList.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d0065eba128b351a0be38fdf5b6e054d55f2ff05", @"/Views/Administrator/AuctionList.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a87ad9899cfc81274681ba05f70a6aab2ec5ecf2", @"/Views/_ViewImports.cshtml")]
    public class Views_Administrator_AuctionList : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ProjectIepAuction.Models.View.UserListModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "User", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Register", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 3 "E:\Aleksa\ProjekatIEP\ProjectIepAuction\Views\Administrator\AuctionList.cshtml"
  
    ViewData["Title"] = "Auction list";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Auction List</h1>\r\n\r\n");
#nullable restore
#line 9 "E:\Aleksa\ProjekatIEP\ProjectIepAuction\Views\Administrator\AuctionList.cshtml"
 if(Model.auctionList.Any()){

#line default
#line hidden
#nullable disable
            WriteLiteral("    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d0065eba128b351a0be38fdf5b6e054d55f2ff055665", async() => {
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
            WriteLiteral("\r\n");
#nullable restore
#line 11 "E:\Aleksa\ProjekatIEP\ProjectIepAuction\Views\Administrator\AuctionList.cshtml"

    foreach(var auction in Model.auctionList){
        

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "E:\Aleksa\ProjekatIEP\ProjectIepAuction\Views\Administrator\AuctionList.cshtml"
         if(auction.state == "DRAFT"){
            string base64 = Convert.ToBase64String(auction.image);

#line default
#line hidden
#nullable disable
            WriteLiteral("            <div class = \"card mb-3\">\r\n                <div class = \"card-header\">\r\n                    User Id : ");
#nullable restore
#line 17 "E:\Aleksa\ProjekatIEP\ProjectIepAuction\Views\Administrator\AuctionList.cshtml"
                         Write(auction.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral(";\r\n                </div>\r\n                <div class = \"card-body\">\r\n                    <h5 class = \"card-title\">");
#nullable restore
#line 20 "E:\Aleksa\ProjekatIEP\ProjectIepAuction\Views\Administrator\AuctionList.cshtml"
                                        Write(auction.name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\r\n                    <br>\r\n                    ");
#nullable restore
#line 22 "E:\Aleksa\ProjekatIEP\ProjectIepAuction\Views\Administrator\AuctionList.cshtml"
               Write(auction.description);

#line default
#line hidden
#nullable disable
            WriteLiteral("; (Create date : ");
#nullable restore
#line 22 "E:\Aleksa\ProjekatIEP\ProjectIepAuction\Views\Administrator\AuctionList.cshtml"
                                                    Write(auction.createDate);

#line default
#line hidden
#nullable disable
            WriteLiteral(", Start date : ");
#nullable restore
#line 22 "E:\Aleksa\ProjekatIEP\ProjectIepAuction\Views\Administrator\AuctionList.cshtml"
                                                                                      Write(auction.openDate);

#line default
#line hidden
#nullable disable
            WriteLiteral(")<br>\r\n                    Start price : ");
#nullable restore
#line 23 "E:\Aleksa\ProjekatIEP\ProjectIepAuction\Views\Administrator\AuctionList.cshtml"
                             Write(auction.startPrice);

#line default
#line hidden
#nullable disable
            WriteLiteral(";\r\n                    <br>\r\n                    <img");
            BeginWriteAttribute("src", " src=\"", 947, "\"", 983, 2);
            WriteAttributeValue("", 953, "data:image/png;base64,", 953, 22, true);
#nullable restore
#line 25 "E:\Aleksa\ProjekatIEP\ProjectIepAuction\Views\Administrator\AuctionList.cshtml"
WriteAttributeValue(" ", 975, base64, 976, 7, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" />
                </div>
                <div class = ""card-footer"">
                    <a href=""#"" class = ""btn btn-success"">Accept</a>
                    <a href=""#"" class = ""btn btn-danger"">Decline</a>
                </div>
            </div>
");
#nullable restore
#line 32 "E:\Aleksa\ProjekatIEP\ProjectIepAuction\Views\Administrator\AuctionList.cshtml"
        }

#line default
#line hidden
#nullable disable
#nullable restore
#line 32 "E:\Aleksa\ProjekatIEP\ProjectIepAuction\Views\Administrator\AuctionList.cshtml"
         
    }
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
                Use the button below to create a user
            </h5>
            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d0065eba128b351a0be38fdf5b6e054d55f2ff0511081", async() => {
                WriteLiteral("\r\n                Add new user\r\n            ");
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
#line 49 "E:\Aleksa\ProjekatIEP\ProjectIepAuction\Views\Administrator\AuctionList.cshtml"
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
