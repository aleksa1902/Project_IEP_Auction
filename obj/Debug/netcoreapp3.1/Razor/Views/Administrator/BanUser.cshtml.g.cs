#pragma checksum "D:\GitHub\Project_IEP_Auction\Views\Administrator\BanUser.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "98db9aabad90793c5deb4ed14fdc9a9aa0e70db0"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Administrator_BanUser), @"mvc.1.0.view", @"/Views/Administrator/BanUser.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"98db9aabad90793c5deb4ed14fdc9a9aa0e70db0", @"/Views/Administrator/BanUser.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a87ad9899cfc81274681ba05f70a6aab2ec5ecf2", @"/Views/_ViewImports.cshtml")]
    public class Views_Administrator_BanUser : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ProjectIepAuction.Models.Database.User>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n    <div class = \"card mb-3\">\r\n        <div class = \"card-header\">\r\n            User Id : ");
#nullable restore
#line 5 "D:\GitHub\Project_IEP_Auction\Views\Administrator\BanUser.cshtml"
                 Write(Model.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </div>\r\n        <div class = \"card-body\">\r\n            <h5 class = \"card-title\">");
#nullable restore
#line 8 "D:\GitHub\Project_IEP_Auction\Views\Administrator\BanUser.cshtml"
                                Write(Model.UserName);

#line default
#line hidden
#nullable disable
            WriteLiteral(" (");
#nullable restore
#line 8 "D:\GitHub\Project_IEP_Auction\Views\Administrator\BanUser.cshtml"
                                                 Write(Model.firstName);

#line default
#line hidden
#nullable disable
            WriteLiteral(", ");
#nullable restore
#line 8 "D:\GitHub\Project_IEP_Auction\Views\Administrator\BanUser.cshtml"
                                                                   Write(Model.lastName);

#line default
#line hidden
#nullable disable
            WriteLiteral(", ");
#nullable restore
#line 8 "D:\GitHub\Project_IEP_Auction\Views\Administrator\BanUser.cshtml"
                                                                                    Write(Model.Email);

#line default
#line hidden
#nullable disable
            WriteLiteral(")</h5>\r\n        </div>\r\n        <div class = \"card-footer\">\r\n           <button type=\"button\" class=\"btn btn-danger\"");
            BeginWriteAttribute("onclick", " onclick=\"", 418, "\"", 454, 3);
            WriteAttributeValue("", 428, "banUser(\'", 428, 9, true);
#nullable restore
#line 11 "D:\GitHub\Project_IEP_Auction\Views\Administrator\BanUser.cshtml"
WriteAttributeValue("", 437, Model.UserName, 437, 15, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 452, "\')", 452, 2, true);
            EndWriteAttribute();
            WriteLiteral(">Ban</button>\r\n    </div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ProjectIepAuction.Models.Database.User> Html { get; private set; }
    }
}
#pragma warning restore 1591
