#pragma checksum "C:\Users\Migs\source\repos\123Pay\123Pay\Views\Home\ApplicationList.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "adad42be2da850b6472af903a9bd1a6c53a00db1"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_ApplicationList), @"mvc.1.0.view", @"/Views/Home/ApplicationList.cshtml")]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "C:\Users\Migs\source\repos\123Pay\123Pay\Views\_ViewImports.cshtml"
using _123Pay;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Migs\source\repos\123Pay\123Pay\Views\_ViewImports.cshtml"
using _123Pay.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Migs\source\repos\123Pay\123Pay\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Migs\source\repos\123Pay\123Pay\Views\_ViewImports.cshtml"
using _123Pay.DB.Entities;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Migs\source\repos\123Pay\123Pay\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\Migs\source\repos\123Pay\123Pay\Views\_ViewImports.cshtml"
using _123Pay.DB;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\Migs\source\repos\123Pay\123Pay\Views\_ViewImports.cshtml"
using Microsoft.Extensions.Configuration;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\Migs\source\repos\123Pay\123Pay\Views\_ViewImports.cshtml"
using cloudscribe.Pagination.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\Migs\source\repos\123Pay\123Pay\Views\_ViewImports.cshtml"
using Microsoft.EntityFrameworkCore;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\Migs\source\repos\123Pay\123Pay\Views\_ViewImports.cshtml"
using System.Linq;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\Migs\source\repos\123Pay\123Pay\Views\_ViewImports.cshtml"
using System.Text.RegularExpressions;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Users\Migs\source\repos\123Pay\123Pay\Views\_ViewImports.cshtml"
using System.Globalization;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"adad42be2da850b6472af903a9bd1a6c53a00db1", @"/Views/Home/ApplicationList.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"867171f04d8dc5a3786a45b2d694ed6ec0ee5e2c", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_ApplicationList : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<PagedResult<ApplicationListModel>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-link sort-link"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("cs-pagenumber-param", "pagenumber", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Home", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("cs-pager-li-current-class", "page-item active", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("cs-pager-li-other-class", "page-item", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("cs-pager-li-non-active-class", "page-item disabled", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("cs-pager-link-current-class", "page-link", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_8 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("cs-pager-link-other-class", "page-link", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::cloudscribe.Web.Pagination.PagerTagHelper __cloudscribe_Web_Pagination_PagerTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\Migs\source\repos\123Pay\123Pay\Views\Home\ApplicationList.cshtml"
  
    Layout = null;

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<div class=""container-fluid"" id=""TableRecord"">
    <div class=""table-responsive"">
        <table class=""table align-items-center table-hover"">
            <thead class=""thead-light"">
                <tr>
                    <th scope=""col"">
                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "adad42be2da850b6472af903a9bd1a6c53a00db18331", async() => {
                WriteLiteral("Date");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-pageSize", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 13 "C:\Users\Migs\source\repos\123Pay\123Pay\Views\Home\ApplicationList.cshtml"
                                   WriteLiteral(Model.PageSize);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["pageSize"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-pageSize", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["pageSize"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            BeginWriteTagHelperAttribute();
#nullable restore
#line 14 "C:\Users\Migs\source\repos\123Pay\123Pay\Views\Home\ApplicationList.cshtml"
                                     WriteLiteral(Model.PageNumber);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["pageNumber"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-pageNumber", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["pageNumber"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            BeginWriteTagHelperAttribute();
#nullable restore
#line 15 "C:\Users\Migs\source\repos\123Pay\123Pay\Views\Home\ApplicationList.cshtml"
                                    WriteLiteral(ViewBag.DateSortParm);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["sortOrder"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-sortOrder", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["sortOrder"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                    </th>\r\n                    <th scope=\"col\">\r\n                        Client\r\n                    </th>\r\n                    <th scope=\"col\">\r\n                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "adad42be2da850b6472af903a9bd1a6c53a00db112229", async() => {
                WriteLiteral("Customer");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-pageSize", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 23 "C:\Users\Migs\source\repos\123Pay\123Pay\Views\Home\ApplicationList.cshtml"
                                   WriteLiteral(Model.PageSize);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["pageSize"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-pageSize", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["pageSize"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            BeginWriteTagHelperAttribute();
#nullable restore
#line 24 "C:\Users\Migs\source\repos\123Pay\123Pay\Views\Home\ApplicationList.cshtml"
                                     WriteLiteral(Model.PageNumber);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["pageNumber"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-pageNumber", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["pageNumber"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            BeginWriteTagHelperAttribute();
#nullable restore
#line 25 "C:\Users\Migs\source\repos\123Pay\123Pay\Views\Home\ApplicationList.cshtml"
                                    WriteLiteral(ViewBag.CustomerSortParm);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["sortOrder"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-sortOrder", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["sortOrder"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                    </th>\r\n                    <th scope=\"col\">Merchant</th>\r\n                    <th scope=\"col\">\r\n                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "adad42be2da850b6472af903a9bd1a6c53a00db116086", async() => {
                WriteLiteral("Account Number");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-pageSize", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 31 "C:\Users\Migs\source\repos\123Pay\123Pay\Views\Home\ApplicationList.cshtml"
                                   WriteLiteral(Model.PageSize);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["pageSize"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-pageSize", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["pageSize"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            BeginWriteTagHelperAttribute();
#nullable restore
#line 32 "C:\Users\Migs\source\repos\123Pay\123Pay\Views\Home\ApplicationList.cshtml"
                                     WriteLiteral(Model.PageNumber);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["pageNumber"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-pageNumber", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["pageNumber"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            BeginWriteTagHelperAttribute();
#nullable restore
#line 33 "C:\Users\Migs\source\repos\123Pay\123Pay\Views\Home\ApplicationList.cshtml"
                                    WriteLiteral(ViewBag.AccountNoSortParm);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["sortOrder"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-sortOrder", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["sortOrder"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                    </th>
                    <th scope=""col"">Account Name</th>
                    <th scope=""col"">Other Details</th>
                    <th scope=""col"">Amount</th>
                    <th scope=""col"">Status</th>
                    <th scope=""col"">
                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "adad42be2da850b6472af903a9bd1a6c53a00db120107", async() => {
                WriteLiteral("Processed By");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-pageSize", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 42 "C:\Users\Migs\source\repos\123Pay\123Pay\Views\Home\ApplicationList.cshtml"
                                   WriteLiteral(Model.PageSize);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["pageSize"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-pageSize", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["pageSize"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            BeginWriteTagHelperAttribute();
#nullable restore
#line 43 "C:\Users\Migs\source\repos\123Pay\123Pay\Views\Home\ApplicationList.cshtml"
                                     WriteLiteral(Model.PageNumber);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["pageNumber"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-pageNumber", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["pageNumber"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            BeginWriteTagHelperAttribute();
#nullable restore
#line 44 "C:\Users\Migs\source\repos\123Pay\123Pay\Views\Home\ApplicationList.cshtml"
                                    WriteLiteral(ViewBag.ProcessedBySortParm);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["sortOrder"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-sortOrder", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["sortOrder"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                    </th>\r\n                    <th scope=\"col\">Service Fee</th>\r\n                    <th scope=\"col\">Remarks</th>\r\n                    <th scope=\"col\"></th>\r\n                </tr>\r\n            </thead>\r\n            <tbody>\r\n");
#nullable restore
#line 52 "C:\Users\Migs\source\repos\123Pay\123Pay\Views\Home\ApplicationList.cshtml"
                 if (Model.Data.Any())
                {
                    

#line default
#line hidden
#nullable disable
#nullable restore
#line 54 "C:\Users\Migs\source\repos\123Pay\123Pay\Views\Home\ApplicationList.cshtml"
                     foreach (var client in Model.Data)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <tr>\r\n                    <td>");
#nullable restore
#line 57 "C:\Users\Migs\source\repos\123Pay\123Pay\Views\Home\ApplicationList.cshtml"
                   Write(client.ProcessedDate);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 58 "C:\Users\Migs\source\repos\123Pay\123Pay\Views\Home\ApplicationList.cshtml"
                   Write(client.Client);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 59 "C:\Users\Migs\source\repos\123Pay\123Pay\Views\Home\ApplicationList.cshtml"
                   Write(client.CustomerName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 60 "C:\Users\Migs\source\repos\123Pay\123Pay\Views\Home\ApplicationList.cshtml"
                   Write(client.Merchant);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 61 "C:\Users\Migs\source\repos\123Pay\123Pay\Views\Home\ApplicationList.cshtml"
                   Write(client.AccountNumber);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 62 "C:\Users\Migs\source\repos\123Pay\123Pay\Views\Home\ApplicationList.cshtml"
                   Write(client.AccountName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 63 "C:\Users\Migs\source\repos\123Pay\123Pay\Views\Home\ApplicationList.cshtml"
                   Write(client.OtherDetails);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 64 "C:\Users\Migs\source\repos\123Pay\123Pay\Views\Home\ApplicationList.cshtml"
                   Write(client.Amount);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 65 "C:\Users\Migs\source\repos\123Pay\123Pay\Views\Home\ApplicationList.cshtml"
                   Write(client.Status);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 66 "C:\Users\Migs\source\repos\123Pay\123Pay\Views\Home\ApplicationList.cshtml"
                   Write(client.ProcessedBy);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 67 "C:\Users\Migs\source\repos\123Pay\123Pay\Views\Home\ApplicationList.cshtml"
                   Write(client.ServiceFee);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 68 "C:\Users\Migs\source\repos\123Pay\123Pay\Views\Home\ApplicationList.cshtml"
                   Write(client.Remarks);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n");
#nullable restore
#line 69 "C:\Users\Migs\source\repos\123Pay\123Pay\Views\Home\ApplicationList.cshtml"
                     if (client.Status == "Pending")
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <td scope=\"row\">\r\n                            <button class=\"btn btn-link btn-sm mr-1\"");
            BeginWriteAttribute("onclick", "\r\n                                    onclick=\"", 3361, "\"", 3438, 3);
            WriteAttributeValue("", 3408, "processingStatus(\'", 3408, 18, true);
#nullable restore
#line 73 "C:\Users\Migs\source\repos\123Pay\123Pay\Views\Home\ApplicationList.cshtml"
WriteAttributeValue("", 3426, client.Id, 3426, 10, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 3436, "\')", 3436, 2, true);
            EndWriteAttribute();
            WriteLiteral(">\r\n                                <span class=\"text-middle\">Process</span>\r\n                            </button>\r\n\r\n                        </td>\r\n");
#nullable restore
#line 78 "C:\Users\Migs\source\repos\123Pay\123Pay\Views\Home\ApplicationList.cshtml"
                    }
                    else if (client.Status == "Processing")
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <td scope=\"row\">\r\n                            <div class=\"row\">\r\n                                <div class=\"col-lg-6\">\r\n                                    <button class=\"btn btn-link btn-sm mr-1\"");
            BeginWriteAttribute("onclick", "\r\n                                            onclick=\"", 3916, "\"", 3997, 3);
            WriteAttributeValue("", 3971, "getId(\'", 3971, 7, true);
#nullable restore
#line 85 "C:\Users\Migs\source\repos\123Pay\123Pay\Views\Home\ApplicationList.cshtml"
WriteAttributeValue("", 3978, client.Id, 3978, 10, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 3988, "\',\'Done\')", 3988, 9, true);
            EndWriteAttribute();
            WriteLiteral(@">
                                        <span class=""text-middle"">Done</span>
                                    </button>

                                </div>
                                <div class=""col-lg-6"">
                                    <button class=""btn btn-link btn-sm mr-1""");
            BeginWriteAttribute("onclick", "\r\n                                            onclick=\"", 4301, "\"", 4384, 3);
            WriteAttributeValue("", 4356, "getId(\'", 4356, 7, true);
#nullable restore
#line 92 "C:\Users\Migs\source\repos\123Pay\123Pay\Views\Home\ApplicationList.cshtml"
WriteAttributeValue("", 4363, client.Id, 4363, 10, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 4373, "\',\'Failed\')", 4373, 11, true);
            EndWriteAttribute();
            WriteLiteral(">\r\n                                        <span class=\"text-middle\">Failed</span>\r\n                                    </button>\r\n\r\n                                </div>\r\n                            </div>\r\n                        </td>\r\n");
#nullable restore
#line 99 "C:\Users\Migs\source\repos\123Pay\123Pay\Views\Home\ApplicationList.cshtml"
                    }
                    else
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <td scope=\"row\">\r\n                            <a class=\"btn btn-link btn-sm mr-1\"");
            BeginWriteAttribute("href", "\r\n                               href=\"", 4802, "\"", 4893, 1);
#nullable restore
#line 104 "C:\Users\Migs\source\repos\123Pay\123Pay\Views\Home\ApplicationList.cshtml"
WriteAttributeValue("", 4841, "../uploads/PaymentReceipts/" + client.Attachment, 4841, 52, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" target=\"_blank\">\r\n                                <span class=\"text-middle\"><i class=\"fa fa-paperclip\" aria-hidden=\"true\"></i></span>\r\n                            </a>\r\n\r\n                        </td>\r\n");
#nullable restore
#line 109 "C:\Users\Migs\source\repos\123Pay\123Pay\Views\Home\ApplicationList.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </tr>\r\n");
#nullable restore
#line 112 "C:\Users\Migs\source\repos\123Pay\123Pay\Views\Home\ApplicationList.cshtml"
                    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 112 "C:\Users\Migs\source\repos\123Pay\123Pay\Views\Home\ApplicationList.cshtml"
                     
                }
                else
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <tr>\r\n                        <th scope=\"row\">No records found!</th>\r\n                    </tr>\r\n");
#nullable restore
#line 119 "C:\Users\Migs\source\repos\123Pay\123Pay\Views\Home\ApplicationList.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </tbody>\r\n        </table>\r\n    </div>\r\n\r\n    <div class=\"d-flex align-content-center justify-content-center pt-3\">\r\n        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("cs-pager", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "adad42be2da850b6472af903a9bd1a6c53a00db133289", async() => {
            }
            );
            __cloudscribe_Web_Pagination_PagerTagHelper = CreateTagHelper<global::cloudscribe.Web.Pagination.PagerTagHelper>();
            __tagHelperExecutionContext.Add(__cloudscribe_Web_Pagination_PagerTagHelper);
#nullable restore
#line 125 "C:\Users\Migs\source\repos\123Pay\123Pay\Views\Home\ApplicationList.cshtml"
__cloudscribe_Web_Pagination_PagerTagHelper.PageNumber = (int)Model.PageNumber;

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext.AddTagHelperAttribute("cs-paging-pagenumber", __cloudscribe_Web_Pagination_PagerTagHelper.PageNumber, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#nullable restore
#line 126 "C:\Users\Migs\source\repos\123Pay\123Pay\Views\Home\ApplicationList.cshtml"
__cloudscribe_Web_Pagination_PagerTagHelper.TotalItems = (int)Model.TotalItems;

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext.AddTagHelperAttribute("cs-paging-totalitems", __cloudscribe_Web_Pagination_PagerTagHelper.TotalItems, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#nullable restore
#line 127 "C:\Users\Migs\source\repos\123Pay\123Pay\Views\Home\ApplicationList.cshtml"
__cloudscribe_Web_Pagination_PagerTagHelper.PageSize = (int)Model.PageSize;

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext.AddTagHelperAttribute("cs-paging-pagesize", __cloudscribe_Web_Pagination_PagerTagHelper.PageSize, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __cloudscribe_Web_Pagination_PagerTagHelper.PageNumberParam = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            if (__cloudscribe_Web_Pagination_PagerTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-filter", "cloudscribe.Web.Pagination.PagerTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 129 "C:\Users\Migs\source\repos\123Pay\123Pay\Views\Home\ApplicationList.cshtml"
                        WriteLiteral(ViewBag.Filter);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __cloudscribe_Web_Pagination_PagerTagHelper.RouteValues["filter"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-filter", __cloudscribe_Web_Pagination_PagerTagHelper.RouteValues["filter"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            BeginWriteTagHelperAttribute();
#nullable restore
#line 130 "C:\Users\Migs\source\repos\123Pay\123Pay\Views\Home\ApplicationList.cshtml"
                      WriteLiteral(ViewBag.Team);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __cloudscribe_Web_Pagination_PagerTagHelper.RouteValues["team"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-team", __cloudscribe_Web_Pagination_PagerTagHelper.RouteValues["team"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __cloudscribe_Web_Pagination_PagerTagHelper.Controller = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            __cloudscribe_Web_Pagination_PagerTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            BeginWriteTagHelperAttribute();
#nullable restore
#line 133 "C:\Users\Migs\source\repos\123Pay\123Pay\Views\Home\ApplicationList.cshtml"
                          WriteLiteral(Model.PageSize);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __cloudscribe_Web_Pagination_PagerTagHelper.RouteValues["pagesize"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-pagesize", __cloudscribe_Web_Pagination_PagerTagHelper.RouteValues["pagesize"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __cloudscribe_Web_Pagination_PagerTagHelper.LiCurrentCssClass = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            __cloudscribe_Web_Pagination_PagerTagHelper.LiOtherCssClass = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            __cloudscribe_Web_Pagination_PagerTagHelper.LiNonActiveCssClass = (string)__tagHelperAttribute_6.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
            __cloudscribe_Web_Pagination_PagerTagHelper.LinkCurrentCssClass = (string)__tagHelperAttribute_7.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_7);
            __cloudscribe_Web_Pagination_PagerTagHelper.LinkOtherCssClass = (string)__tagHelperAttribute_8.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_8);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n    </div>\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<PagedResult<ApplicationListModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591