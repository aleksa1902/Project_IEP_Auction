#pragma checksum "D:\GitHub\Project_IEP_Auction\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "57cd04f54ff39785158bde88850fe3a3ca49f130"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"57cd04f54ff39785158bde88850fe3a3ca49f130", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a87ad9899cfc81274681ba05f70a6aab2ec5ecf2", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ProjectIepAuction.Models.View.IndexModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "OPEN", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "READY", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "SOLD", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "EXPIRED", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "DRAFT", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "DELETED", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/signalr/dist/browser/signalr.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/signalr/dist/browser/signalr.min.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_8 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/bid.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "D:\GitHub\Project_IEP_Auction\Views\Home\Index.cshtml"
  
  ViewData["Title"] = "Home Page";
  int i = 0;

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "57cd04f54ff39785158bde88850fe3a3ca49f1306572", async() => {
                WriteLiteral(@"
<p>
  <a class=""btn btn-primary"" data-toggle=""collapse"" href=""#multiCollapseExample1"" role=""button"" aria-expanded=""false"" aria-controls=""multiCollapseExample1"">Search</a>
  <button class=""btn btn-primary"" type=""button"" data-toggle=""collapse"" data-target=""#multiCollapseExample2"" aria-expanded=""false"" aria-controls=""multiCollapseExample2"">Price range</button>
  <a class=""btn btn-primary"" data-toggle=""collapse"" href=""#multiCollapseExample3"" role=""button"" aria-expanded=""false"" aria-controls=""multiCollapseExample1"">Auction state</a>
  <input class=""btn btn-danger"" type=""reset"" value=""Reset"" onclick=""clickHandler('1')"">
</p>

<div class=""row"">
  <div class=""col"">
    <div class=""collapse multi-collapse"" id=""multiCollapseExample1"">
      <div class=""card card-body bg-warning"">
            <div class=""form-group"">
                <label class=""control-label"">Search:</label>
                <input class=""form-control"" type=""text"" id=""search""><br>
              <button type=""button"" class=""btn btn-succe");
                WriteLiteral(@"ss"" onclick=""nextPage('1')"">Search</button>
            </div>
        </div>
    </div>
  </div>

  <div class=""col"">
    <div class=""collapse multi-collapse"" id=""multiCollapseExample2"">
      <div class=""card card-body bg-warning"">
        <div class=""form-group"">
                <label class=""control-label"">Minimum price:</label>
                <input class=""form-control"" type=""text"" id=""minPrice""><br>
            </div>
            <div class=""form-group"">
                <label class=""control-label"">Maximum price:</label>
                <input class=""form-control"" type=""text"" id=""maxPrice""><br>
              <button type=""button"" class=""btn btn-success"" onclick=""nextPage('1')"">Search</button>
            </div>
          </div>
      </div>
    </div>

    <div class=""col"">
    <div class=""collapse multi-collapse"" id=""multiCollapseExample3"">
      <div class=""card card-body bg-warning"">
        <div class=""form-group"">
          <label class=""control-label"">State:</label>
   ");
                WriteLiteral("            <select class=\"form-control\" id = \"state\">\r\n                ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "57cd04f54ff39785158bde88850fe3a3ca49f1309140", async() => {
                    WriteLiteral("Open");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "57cd04f54ff39785158bde88850fe3a3ca49f13010377", async() => {
                    WriteLiteral("Ready");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "57cd04f54ff39785158bde88850fe3a3ca49f13011616", async() => {
                    WriteLiteral("Sold");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_2.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "57cd04f54ff39785158bde88850fe3a3ca49f13012854", async() => {
                    WriteLiteral("Expired");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_3.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "57cd04f54ff39785158bde88850fe3a3ca49f13014095", async() => {
                    WriteLiteral("Draft");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_4.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "57cd04f54ff39785158bde88850fe3a3ca49f13015334", async() => {
                    WriteLiteral("Deleted");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_5.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n              </select><br>\r\n          <button type=\"button\" class=\"btn btn-success\" onclick=\"nextPage(\'1\')\">Search</button>\r\n        </div>\r\n      </div>\r\n    </div>\r\n    </div>  \r\n</div>\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n<hr>\r\n\r\n<div id=\"auction\">\r\n  <div class=\"album\">\r\n    <div class=\"container\">\r\n      <div class=\"row\">\r\n\r\n");
#nullable restore
#line 73 "D:\GitHub\Project_IEP_Auction\Views\Home\Index.cshtml"
       foreach (var auction in @Model.auctionsList){
        string base64 = Convert.ToBase64String(auction.image);


#line default
#line hidden
#nullable disable
            WriteLiteral("        <div class=\"col-md-3\">\r\n          <div class=\"card mb-2 box-shadow\">\r\n            <img class=\"card-img-top\"");
            BeginWriteAttribute("src", " src=\"", 3093, "\"", 3129, 2);
            WriteAttributeValue("", 3099, "data:image/png;base64,", 3099, 22, true);
#nullable restore
#line 78 "D:\GitHub\Project_IEP_Auction\Views\Home\Index.cshtml"
WriteAttributeValue(" ", 3121, base64, 3122, 7, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" alt=\"Card image cap\" />\r\n          <div class=\"card-body\">\r\n            <h5 class=\"card-title\">Name : ");
#nullable restore
#line 80 "D:\GitHub\Project_IEP_Auction\Views\Home\Index.cshtml"
                                     Write(auction.name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\r\n            <p class=\"card-text\">\r\n              Current price:<span");
            BeginWriteAttribute("id", " id=\"", 3321, "\"", 3356, 1);
#nullable restore
#line 82 "D:\GitHub\Project_IEP_Auction\Views\Home\Index.cshtml"
WriteAttributeValue("", 3326, Html.Raw("price"+@auction.Id), 3326, 30, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("> ");
#nullable restore
#line 82 "D:\GitHub\Project_IEP_Auction\Views\Home\Index.cshtml"
                                                                  Write(auction.currentPrice);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </span><br>\r\n              Last bid user : \r\n              <span");
            BeginWriteAttribute("id", " id=\"", 3445, "\"", 3481, 1);
#nullable restore
#line 84 "D:\GitHub\Project_IEP_Auction\Views\Home\Index.cshtml"
WriteAttributeValue("", 3450, Html.Raw("winner"+@auction.Id), 3450, 31, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("> \r\n                  ");
#nullable restore
#line 85 "D:\GitHub\Project_IEP_Auction\Views\Home\Index.cshtml"
             Write(Model.winners.Where(u => u.Key == auction.Id).FirstOrDefault().Value);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </span><hr>\r\n            </p>\r\n            <p class=\"card-text\">\r\n              Time :\r\n");
#nullable restore
#line 90 "D:\GitHub\Project_IEP_Auction\Views\Home\Index.cshtml"
               if(auction.state == "OPEN"){
              i = i + 1;

#line default
#line hidden
#nullable disable
            WriteLiteral("              <div");
            BeginWriteAttribute("id", " id=\"", 3768, "\"", 3809, 1);
#nullable restore
#line 92 "D:\GitHub\Project_IEP_Auction\Views\Home\Index.cshtml"
WriteAttributeValue("", 3773, Html.Raw("changeColor"+@auction.Id), 3773, 36, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                <input type=\"hidden\"");
            BeginWriteAttribute("id", " id=\"", 3849, "\"", 3879, 1);
#nullable restore
#line 93 "D:\GitHub\Project_IEP_Auction\Views\Home\Index.cshtml"
WriteAttributeValue("", 3854, Html.Raw("closeTime"+@i), 3854, 25, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("class", " class=\"", 3880, "\"", 3922, 1);
#nullable restore
#line 93 "D:\GitHub\Project_IEP_Auction\Views\Home\Index.cshtml"
WriteAttributeValue("", 3888, Html.Raw("closeTime"+@auction.Id), 3888, 34, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("value", " value=\"", 3923, "\"", 3977, 1);
#nullable restore
#line 93 "D:\GitHub\Project_IEP_Auction\Views\Home\Index.cshtml"
WriteAttributeValue("", 3931, auction.closeDate.ToString("yyyy,MM,d,H,m,s"), 3931, 46, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("/>\r\n                <div class=\"list-group-item bg-success text-white\" style=\"text-align: center;\"><i class=\"fa fa-clock-o\" aria-hidden=\"true\"></i> <span");
            BeginWriteAttribute("class", " class=\"", 4131, "\"", 4168, 1);
#nullable restore
#line 94 "D:\GitHub\Project_IEP_Auction\Views\Home\Index.cshtml"
WriteAttributeValue("", 4139, Html.Raw("time"+@auction.Id), 4139, 29, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("id", " id=\"", 4169, "\"", 4194, 1);
#nullable restore
#line 94 "D:\GitHub\Project_IEP_Auction\Views\Home\Index.cshtml"
WriteAttributeValue("", 4174, Html.Raw("time"+@i), 4174, 20, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">--:--:--:--</span></div>\r\n                <input type=\"hidden\"");
            BeginWriteAttribute("id", " id=\"", 4258, "\"", 4288, 1);
#nullable restore
#line 95 "D:\GitHub\Project_IEP_Auction\Views\Home\Index.cshtml"
WriteAttributeValue("", 4263, Html.Raw("auctionId"+@i), 4263, 25, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("value", " value=\"", 4289, "\"", 4308, 1);
#nullable restore
#line 95 "D:\GitHub\Project_IEP_Auction\Views\Home\Index.cshtml"
WriteAttributeValue("", 4297, auction.Id, 4297, 11, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n              </div>\r\n");
#nullable restore
#line 97 "D:\GitHub\Project_IEP_Auction\Views\Home\Index.cshtml"
              }else{

#line default
#line hidden
#nullable disable
            WriteLiteral("                <div class=\"list-group-item bg-danger text-white\" style=\"text-align: center;\">CLOSED</div>\r\n");
#nullable restore
#line 99 "D:\GitHub\Project_IEP_Auction\Views\Home\Index.cshtml"
              }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </p>\r\n          </div>\r\n          <div class=\"card-footer\">\r\n            <div class=\"row\"> \r\n              <div class=\"col\"");
            BeginWriteAttribute("id", " id = \"", 4616, "\"", 4654, 1);
#nullable restore
#line 104 "D:\GitHub\Project_IEP_Auction\Views\Home\Index.cshtml"
WriteAttributeValue("", 4623, Html.Raw("divBid"+@auction.Id), 4623, 31, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("class", " class=\"", 4655, "\"", 4694, 1);
#nullable restore
#line 104 "D:\GitHub\Project_IEP_Auction\Views\Home\Index.cshtml"
WriteAttributeValue("", 4663, Html.Raw("divBid"+@auction.Id), 4663, 31, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n");
#nullable restore
#line 105 "D:\GitHub\Project_IEP_Auction\Views\Home\Index.cshtml"
               if(auction.state == "OPEN"){

#line default
#line hidden
#nullable disable
            WriteLiteral("              <input type=\"button\" class=\"btn btn-success\"");
            BeginWriteAttribute("onclick", " onclick=\"", 4801, "\"", 4829, 3);
            WriteAttributeValue("", 4811, "Bid(\'", 4811, 5, true);
#nullable restore
#line 106 "D:\GitHub\Project_IEP_Auction\Views\Home\Index.cshtml"
WriteAttributeValue("", 4816, auction.Id, 4816, 11, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 4827, "\')", 4827, 2, true);
            EndWriteAttribute();
            WriteLiteral(" value=\"Bid\"  />\r\n");
#nullable restore
#line 107 "D:\GitHub\Project_IEP_Auction\Views\Home\Index.cshtml"
              }

#line default
#line hidden
#nullable disable
            WriteLiteral("              </div>\r\n              <div class=\"col\">\r\n              &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<a");
            BeginWriteAttribute("href", " href=\"", 4966, "\"", 5005, 2);
            WriteAttributeValue("", 4973, "/Home/GetInfoAuction/", 4973, 21, true);
#nullable restore
#line 110 "D:\GitHub\Project_IEP_Auction\Views\Home\Index.cshtml"
WriteAttributeValue("", 4994, auction.Id, 4994, 11, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" type=\"button\" class=\"btn btn-info\">Info</a>\r\n              </div>\r\n            \r\n            </div>\r\n          </div>\r\n          </div>\r\n        </div>\r\n");
#nullable restore
#line 117 "D:\GitHub\Project_IEP_Auction\Views\Home\Index.cshtml"

      }

#line default
#line hidden
#nullable disable
            WriteLiteral("      </div>\r\n    </div>\r\n  </div>\r\n\r\n\r\n\r\n<div class=\"row justify-content-center pt-5\">\r\n        <nav aria-label=\"Page navigation example\">\r\n            <ul class=\"pagination\">\r\n");
#nullable restore
#line 128 "D:\GitHub\Project_IEP_Auction\Views\Home\Index.cshtml"
                 if (Model.currentPage > 1){
                    int previousPage = @Model.currentPage-1;
                    

#line default
#line hidden
#nullable disable
            WriteLiteral("<li class=\"page-item\">\r\n                        <button class=\"page-link\" aria-label=\"Previous\"");
            BeginWriteAttribute("onclick", " onclick=\"", 5572, "\"", 5614, 4);
            WriteAttributeValue("", 5582, "nextPage(", 5582, 9, true);
#nullable restore
#line 131 "D:\GitHub\Project_IEP_Auction\Views\Home\Index.cshtml"
WriteAttributeValue("", 5591, Model.currentPage, 5591, 18, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue(" ", 5609, "-", 5610, 2, true);
            WriteAttributeValue(" ", 5611, "1)", 5612, 3, true);
            EndWriteAttribute();
            WriteLiteral(">\r\n                            <span aria-hidden=\"true\"> ");
#nullable restore
#line 132 "D:\GitHub\Project_IEP_Auction\Views\Home\Index.cshtml"
                                                 Write(Html.Raw("<"));

#line default
#line hidden
#nullable disable
            WriteLiteral(" </span>\r\n                            <span class=\"sr-only\">Previous</span>\r\n                        </button>\r\n                    </li>   \r\n");
#nullable restore
#line 136 "D:\GitHub\Project_IEP_Auction\Views\Home\Index.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 138 "D:\GitHub\Project_IEP_Auction\Views\Home\Index.cshtml"
                 for(i = 1; i<=Model.pageNumbers;i++)
                {
                    if(i==Model.currentPage)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <li class=\"page-item active\">\r\n                            <button class=\"page-link\">");
#nullable restore
#line 143 "D:\GitHub\Project_IEP_Auction\Views\Home\Index.cshtml"
                                                 Write(i);

#line default
#line hidden
#nullable disable
            WriteLiteral("</button>\r\n                        </li>\r\n");
#nullable restore
#line 145 "D:\GitHub\Project_IEP_Auction\Views\Home\Index.cshtml"
                    }
                    else
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <li class=\"page-item\">\r\n                            <button class=\"page-link\"");
            BeginWriteAttribute("onclick", " onclick=\"", 6318, "\"", 6342, 3);
            WriteAttributeValue("", 6328, "nextPage(\'", 6328, 10, true);
#nullable restore
#line 149 "D:\GitHub\Project_IEP_Auction\Views\Home\Index.cshtml"
WriteAttributeValue("", 6338, i, 6338, 2, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 6340, "\')", 6340, 2, true);
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 149 "D:\GitHub\Project_IEP_Auction\Views\Home\Index.cshtml"
                                                                          Write(i);

#line default
#line hidden
#nullable disable
            WriteLiteral("</button>\r\n                        </li>\r\n");
#nullable restore
#line 151 "D:\GitHub\Project_IEP_Auction\Views\Home\Index.cshtml"

                    }

                }

#line default
#line hidden
#nullable disable
            WriteLiteral("                \r\n");
#nullable restore
#line 156 "D:\GitHub\Project_IEP_Auction\Views\Home\Index.cshtml"
                 if(Model.currentPage < Model.pageNumbers)
                {
                    int nextPage = @Model.currentPage+1;
                    

#line default
#line hidden
#nullable disable
            WriteLiteral("<li class=\"page-item\">\r\n                        <button class=\"page-link\" aria-label=\"Next\"");
            BeginWriteAttribute("onclick", " onclick=\"", 6700, "\"", 6731, 3);
            WriteAttributeValue("", 6710, "nextPage(\'", 6710, 10, true);
#nullable restore
#line 160 "D:\GitHub\Project_IEP_Auction\Views\Home\Index.cshtml"
WriteAttributeValue("", 6720, nextPage, 6720, 9, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 6729, "\')", 6729, 2, true);
            EndWriteAttribute();
            WriteLiteral(">\r\n                            <span aria-hidden=\"true\"> ");
#nullable restore
#line 161 "D:\GitHub\Project_IEP_Auction\Views\Home\Index.cshtml"
                                                 Write(Html.Raw(">"));

#line default
#line hidden
#nullable disable
            WriteLiteral(" </span>\r\n                            <span class=\"sr-only\">Next</span>\r\n                        </button>\r\n                    </li>\r\n");
#nullable restore
#line 165 "D:\GitHub\Project_IEP_Auction\Views\Home\Index.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </ul>\r\n        </nav>\r\n    </div>\r\n\r\n</div>\r\n");
            DefineSection("Scripts", async() => {
                WriteLiteral("\r\n    <script");
                BeginWriteAttribute("src", " src=\"", 7046, "\"", 7080, 1);
#nullable restore
#line 173 "D:\GitHub\Project_IEP_Auction\Views\Home\Index.cshtml"
WriteAttributeValue("", 7052, Url.Content("~/js/site.js"), 7052, 28, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral("></script>\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "57cd04f54ff39785158bde88850fe3a3ca49f13032910", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "57cd04f54ff39785158bde88850fe3a3ca49f13034010", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_7);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "57cd04f54ff39785158bde88850fe3a3ca49f13035110", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_8);
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
