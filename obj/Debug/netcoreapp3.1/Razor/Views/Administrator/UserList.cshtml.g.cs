#pragma checksum "D:\GitHub\Project_IEP_Auction\Views\Administrator\UserList.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5fb469bcf8f42d361a363219c6fa58e08d5275c5"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Administrator_UserList), @"mvc.1.0.view", @"/Views/Administrator/UserList.cshtml")]
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
#line 1 "D:\GitHub\Project_IEP_Auction\Views\Administrator\UserList.cshtml"
using X.PagedList.Mvc.Core;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\GitHub\Project_IEP_Auction\Views\Administrator\UserList.cshtml"
using X.PagedList;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5fb469bcf8f42d361a363219c6fa58e08d5275c5", @"/Views/Administrator/UserList.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a87ad9899cfc81274681ba05f70a6aab2ec5ecf2", @"/Views/_ViewImports.cshtml")]
    public class Views_Administrator_UserList : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ProjectIepAuction.Models.View.UserListModel>
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
#nullable restore
#line 4 "D:\GitHub\Project_IEP_Auction\Views\Administrator\UserList.cshtml"
  
    ViewData["Title"] = "User list";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>User list</h1><hr>\r\n\r\n");
#nullable restore
#line 10 "D:\GitHub\Project_IEP_Auction\Views\Administrator\UserList.cshtml"
 if(Model.userList.Any()){

#line default
#line hidden
#nullable disable
            WriteLiteral("    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5fb469bcf8f42d361a363219c6fa58e08d5275c55896", async() => {
                WriteLiteral("Add new user");
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
#line 12 "D:\GitHub\Project_IEP_Auction\Views\Administrator\UserList.cshtml"

    foreach(var user in Model.userList){
        

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "D:\GitHub\Project_IEP_Auction\Views\Administrator\UserList.cshtml"
         if(user.UserName == Model.loggedInUser.UserName){

#line default
#line hidden
#nullable disable
            WriteLiteral("            <div");
            BeginWriteAttribute("id", " id=\"", 443, "\"", 462, 1);
#nullable restore
#line 15 "D:\GitHub\Project_IEP_Auction\Views\Administrator\UserList.cshtml"
WriteAttributeValue("", 448, user.UserName, 448, 14, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                <div class = \"card text-white bg-primary mb-3\">\r\n                    <div class = \"card-header\">\r\n                        User Id : ");
#nullable restore
#line 18 "D:\GitHub\Project_IEP_Auction\Views\Administrator\UserList.cshtml"
                             Write(user.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </div>\r\n                    <div class = \"card-body\">\r\n                        <h5 class = \"card-title\">");
#nullable restore
#line 21 "D:\GitHub\Project_IEP_Auction\Views\Administrator\UserList.cshtml"
                                            Write(user.UserName);

#line default
#line hidden
#nullable disable
            WriteLiteral(" (");
#nullable restore
#line 21 "D:\GitHub\Project_IEP_Auction\Views\Administrator\UserList.cshtml"
                                                            Write(user.firstName);

#line default
#line hidden
#nullable disable
            WriteLiteral(", ");
#nullable restore
#line 21 "D:\GitHub\Project_IEP_Auction\Views\Administrator\UserList.cshtml"
                                                                             Write(user.lastName);

#line default
#line hidden
#nullable disable
            WriteLiteral(", ");
#nullable restore
#line 21 "D:\GitHub\Project_IEP_Auction\Views\Administrator\UserList.cshtml"
                                                                                             Write(user.Email);

#line default
#line hidden
#nullable disable
            WriteLiteral(")</h5>\r\n                    </div>\r\n                    <div class = \"card-footer\">\r\n                       \r\n                   </div>\r\n                </div>\r\n            </div>\r\n");
#nullable restore
#line 28 "D:\GitHub\Project_IEP_Auction\Views\Administrator\UserList.cshtml"
        }else if(user.state != "Banned"){

#line default
#line hidden
#nullable disable
            WriteLiteral("            <div");
            BeginWriteAttribute("id", " id=\"", 1048, "\"", 1067, 1);
#nullable restore
#line 29 "D:\GitHub\Project_IEP_Auction\Views\Administrator\UserList.cshtml"
WriteAttributeValue("", 1053, user.UserName, 1053, 14, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                <div class = \"card mb-3\">\r\n                    <div class = \"card-header\">\r\n                        User Id : ");
#nullable restore
#line 32 "D:\GitHub\Project_IEP_Auction\Views\Administrator\UserList.cshtml"
                             Write(user.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </div>\r\n                    <div class = \"card-body\">\r\n                        <h5 class = \"card-title\">");
#nullable restore
#line 35 "D:\GitHub\Project_IEP_Auction\Views\Administrator\UserList.cshtml"
                                            Write(user.UserName);

#line default
#line hidden
#nullable disable
            WriteLiteral(" (");
#nullable restore
#line 35 "D:\GitHub\Project_IEP_Auction\Views\Administrator\UserList.cshtml"
                                                            Write(user.firstName);

#line default
#line hidden
#nullable disable
            WriteLiteral(", ");
#nullable restore
#line 35 "D:\GitHub\Project_IEP_Auction\Views\Administrator\UserList.cshtml"
                                                                             Write(user.lastName);

#line default
#line hidden
#nullable disable
            WriteLiteral(", ");
#nullable restore
#line 35 "D:\GitHub\Project_IEP_Auction\Views\Administrator\UserList.cshtml"
                                                                                             Write(user.Email);

#line default
#line hidden
#nullable disable
            WriteLiteral(")</h5>\r\n                    </div>\r\n                    <div class = \"card-footer\">\r\n                       <button type=\"button\" class=\"btn btn-danger\"");
            BeginWriteAttribute("onclick", " onclick=\"", 1543, "\"", 1578, 3);
            WriteAttributeValue("", 1553, "banUser(\'", 1553, 9, true);
#nullable restore
#line 38 "D:\GitHub\Project_IEP_Auction\Views\Administrator\UserList.cshtml"
WriteAttributeValue("", 1562, user.UserName, 1562, 14, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1576, "\')", 1576, 2, true);
            EndWriteAttribute();
            WriteLiteral(">Ban</button>\r\n                   </div>\r\n                </div>\r\n            </div>\r\n");
#nullable restore
#line 42 "D:\GitHub\Project_IEP_Auction\Views\Administrator\UserList.cshtml"
        }else if(user.state == "Banned"){

#line default
#line hidden
#nullable disable
            WriteLiteral("            <div");
            BeginWriteAttribute("id", " id=\"", 1724, "\"", 1743, 1);
#nullable restore
#line 43 "D:\GitHub\Project_IEP_Auction\Views\Administrator\UserList.cshtml"
WriteAttributeValue("", 1729, user.UserName, 1729, 14, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                <div class = \"card text-white bg-danger mb-3\">\r\n                    <div class = \"card-header\">\r\n                        User Id : ");
#nullable restore
#line 46 "D:\GitHub\Project_IEP_Auction\Views\Administrator\UserList.cshtml"
                             Write(user.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </div>\r\n                    <div class = \"card-body\">\r\n                        <h5 class = \"card-title\">");
#nullable restore
#line 49 "D:\GitHub\Project_IEP_Auction\Views\Administrator\UserList.cshtml"
                                            Write(user.UserName);

#line default
#line hidden
#nullable disable
            WriteLiteral(" (");
#nullable restore
#line 49 "D:\GitHub\Project_IEP_Auction\Views\Administrator\UserList.cshtml"
                                                            Write(user.firstName);

#line default
#line hidden
#nullable disable
            WriteLiteral(", ");
#nullable restore
#line 49 "D:\GitHub\Project_IEP_Auction\Views\Administrator\UserList.cshtml"
                                                                             Write(user.lastName);

#line default
#line hidden
#nullable disable
            WriteLiteral(", ");
#nullable restore
#line 49 "D:\GitHub\Project_IEP_Auction\Views\Administrator\UserList.cshtml"
                                                                                             Write(user.Email);

#line default
#line hidden
#nullable disable
            WriteLiteral(")</h5>\r\n                    </div>\r\n                    <div class = \"card-footer\">\r\n                        <button type=\"button\" class=\"btn btn-success\"");
            BeginWriteAttribute("onclick", " onclick=\"", 2242, "\"", 2279, 3);
            WriteAttributeValue("", 2252, "unbanUser(\'", 2252, 11, true);
#nullable restore
#line 52 "D:\GitHub\Project_IEP_Auction\Views\Administrator\UserList.cshtml"
WriteAttributeValue("", 2263, user.UserName, 2263, 14, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2277, "\')", 2277, 2, true);
            EndWriteAttribute();
            WriteLiteral(">Unban</button>\r\n                    </div>\r\n                </div>\r\n            </div>\r\n");
#nullable restore
#line 56 "D:\GitHub\Project_IEP_Auction\Views\Administrator\UserList.cshtml"
        }

#line default
#line hidden
#nullable disable
#nullable restore
#line 56 "D:\GitHub\Project_IEP_Auction\Views\Administrator\UserList.cshtml"
         
    }
}else{

#line default
#line hidden
#nullable disable
            WriteLiteral(@"    <div class = ""card"">
        <div class = ""card-header"">
            No users created yet
        </div>
        <div class = ""card-body"">
            <h5 class = ""card-title"">
                Use the button below to create a user
            </h5>
            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5fb469bcf8f42d361a363219c6fa58e08d5275c516538", async() => {
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
            WriteLiteral("\r\n        </div>\r\n    </div>\r\n");
#nullable restore
#line 72 "D:\GitHub\Project_IEP_Auction\Views\Administrator\UserList.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"row justify-content-center\">\r\n");
#nullable restore
#line 75 "D:\GitHub\Project_IEP_Auction\Views\Administrator\UserList.cshtml"
Write(Html.PagedListPager(Model.userList, page => Url.Action("UserList", new { page = page }),
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
            WriteLiteral("\r\n</div>");
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
