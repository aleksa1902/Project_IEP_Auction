#pragma checksum "E:\Aleksa\ProjekatIEP\ProjectIepAuction\Views\Home\GetInfoAuction.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e056289337541b7ba587771b7b8098c3f64b76d1"
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e056289337541b7ba587771b7b8098c3f64b76d1", @"/Views/Home/GetInfoAuction.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a87ad9899cfc81274681ba05f70a6aab2ec5ecf2", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_GetInfoAuction : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ProjectIepAuction.Models.View.IndexModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "E:\Aleksa\ProjekatIEP\ProjectIepAuction\Views\Home\GetInfoAuction.cshtml"
  
    Layout = "_Layout";

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "E:\Aleksa\ProjekatIEP\ProjectIepAuction\Views\Home\GetInfoAuction.cshtml"
  
string base64 = Convert.ToBase64String(@Model.auction.image);

if(@Model.auction.owner.UserName != null){

#line default
#line hidden
#nullable disable
            WriteLiteral("    <h1>");
#nullable restore
#line 10 "E:\Aleksa\ProjekatIEP\ProjectIepAuction\Views\Home\GetInfoAuction.cshtml"
   Write(Model.auction.owner.UserName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\r\n");
#nullable restore
#line 11 "E:\Aleksa\ProjekatIEP\ProjectIepAuction\Views\Home\GetInfoAuction.cshtml"
}


#line default
#line hidden
#nullable disable
            WriteLiteral("<div class=\"card mb-3\">\r\n  <img class=\"card-img-top\"");
            BeginWriteAttribute("src", " src=\"", 297, "\"", 333, 2);
            WriteAttributeValue("", 303, "data:image/png;base64,", 303, 22, true);
#nullable restore
#line 14 "E:\Aleksa\ProjekatIEP\ProjectIepAuction\Views\Home\GetInfoAuction.cshtml"
WriteAttributeValue(" ", 325, base64, 326, 7, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" alt=\"Card image cap\" />\r\n  <div class=\"card-body\">\r\n    <h5 class=\"card-title\">");
#nullable restore
#line 16 "E:\Aleksa\ProjekatIEP\ProjectIepAuction\Views\Home\GetInfoAuction.cshtml"
                      Write(Model.auction.name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\r\n    <p class=\"card-text\">");
#nullable restore
#line 17 "E:\Aleksa\ProjekatIEP\ProjectIepAuction\Views\Home\GetInfoAuction.cshtml"
                    Write(Model.auction.description);

#line default
#line hidden
#nullable disable
            WriteLiteral(" <br><h3>(Current price : ");
#nullable restore
#line 17 "E:\Aleksa\ProjekatIEP\ProjectIepAuction\Views\Home\GetInfoAuction.cshtml"
                                                                        Write(Model.auction.currentPrice);

#line default
#line hidden
#nullable disable
            WriteLiteral(" )</h3></p>\r\n    <p class=\"card-text\"><small class=\"text-muted\"></small></p>\r\n  </div>\r\n</div>\r\n");
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
