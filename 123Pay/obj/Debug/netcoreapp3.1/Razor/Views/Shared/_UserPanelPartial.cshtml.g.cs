#pragma checksum "C:\Users\Migs\source\repos\123Pay\123Pay\Views\Shared\_UserPanelPartial.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a294c8e64070b79492897bc073b917fc12c94126"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__UserPanelPartial), @"mvc.1.0.view", @"/Views/Shared/_UserPanelPartial.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a294c8e64070b79492897bc073b917fc12c94126", @"/Views/Shared/_UserPanelPartial.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"867171f04d8dc5a3786a45b2d694ed6ec0ee5e2c", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared__UserPanelPartial : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "get", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "account", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "changepassword", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "logout", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("ChangePasswordForm"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\Migs\source\repos\123Pay\123Pay\Views\Shared\_UserPanelPartial.cshtml"
  
    Layout = null;

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<a class=""nav-link pr-0"" href=""#"" role=""button"" data-toggle=""dropdown"" aria-haspopup=""true""
   aria-expanded=""false"">
    <div class=""media align-items-center"">
        <span class=""avatar-initials avatar avatar-sm rounded-circle"" width=""70"" height=""70"" data-name=""");
#nullable restore
#line 9 "C:\Users\Migs\source\repos\123Pay\123Pay\Views\Shared\_UserPanelPartial.cshtml"
                                                                                                   Write(userManager.GetUserAsync(User).Result.FirstName);

#line default
#line hidden
#nullable disable
            WriteLiteral("\"></span>\r\n        <div class=\"media-body  ml-2  d-none d-lg-block\">\r\n            <span class=\"mb-0 text-sm  font-weight-bold\">");
#nullable restore
#line 11 "C:\Users\Migs\source\repos\123Pay\123Pay\Views\Shared\_UserPanelPartial.cshtml"
                                                    Write(userManager.GetUserAsync(User).Result.FirstName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n        </div>\r\n    </div>\r\n</a>\r\n<div class=\"dropdown-menu  dropdown-menu-right \">\r\n    <div class=\"dropdown-header noti-title\">\r\n        <h6 class=\"text-overflow m-0\">Welcome!</h6>\r\n    </div>\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a294c8e64070b79492897bc073b917fc12c941268355", async() => {
                WriteLiteral("\r\n        <button class=\"dropdown-item\">\r\n            <i class=\"fa fa-user\"></i>\r\n            <span>Change Password</span>\r\n        </button>\r\n    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n    <div class=\"dropdown-divider\"></div>\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a294c8e64070b79492897bc073b917fc12c9412610401", async() => {
                WriteLiteral("\r\n        <button type=\"submit\" class=\"dropdown-item\">\r\n            <i class=\"fa fa-sign-out-alt\"></i>\r\n            <span>Logout</span>\r\n        </button>\r\n    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"

</div>

<div class=""modal fade"" id=""changePassModal"" data-backdrop=""static"" data-keyboard=""false"" tabindex=""-1"" aria-labelledby=""staticBackdropLabel"" aria-hidden=""true"">
    <div class=""modal-dialog modal-md modal-dialog-scrollable"">
        <div class=""modal-content"">
            <!-- Modal Header -->
            <div class=""modal-header"">
                <h3 class=""modal-title"">Change Password</h3>
                <button type=""button"" class=""close"" data-dismiss=""modal"">&times;</button>
            </div>

            <!-- Modal body -->
            <div class=""modal-body"">
                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a294c8e64070b79492897bc073b917fc12c9412613052", async() => {
                WriteLiteral("\r\n");
                WriteLiteral("                ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
            </div>
            <!-- Modal footer -->
            <div class=""modal-footer text-right"">
                <button type=""button"" class=""btn btn-primary"" data-dismiss=""modal"">Close</button>
                <button form=""ChangePasswordForm"" type=""submit"" class=""btn btn-primary"">Sumbit</button>
            </div>

        </div>
    </div>
</div>

");
            DefineSection("Styles", async() => {
                WriteLiteral("\r\n    <link rel=\"stylesheet\" href=\"https://maxcdn.bootstrapcdn.com/bootstrap/4.5.2/css/bootstrap.min.css\">\r\n");
            }
            );
            WriteLiteral("\r\n");
            DefineSection("Scripts", async() => {
                WriteLiteral(@"
    <script src=""https://ajax.googleapis.com/ajax/libs/jquery/3.5.1/jquery.min.js""></script>
    <script src=""https://cdnjs.cloudflare.com/ajax/libs/popper.js/1.16.0/umd/popper.min.js""></script>
    <script src=""https://maxcdn.bootstrapcdn.com/bootstrap/4.5.2/js/bootstrap.min.js""></script>
    <script type=""text/javascript"">

         $('#ChangePassModal').on('show.bs.modal', function (event) {
            var form = $('#ChangePasswordForm');
            var button = $(event.relatedTarget);
            var url = button.data('url');
            var type = button.data('type');
            form.attr('action', url);
            $.get(url, function (data) {
                form.html(data);
            }).then(function () {
                form.removeData('validator');
                form.removeData('unobtrusiveValidation');
                $.validator.unobtrusive.parse(form);
            });
         });

        $('#ChangePasswordForm').on('submit', function (e) {
            e.preventDefa");
                WriteLiteral(@"ult();
            var form = $('#ChangePasswordForm');
            var button = $(event.relatedTarget);
            var type = button.data('type');
            console.log('submit change pass');
            $.ajax({
                type: $('#ChangePasswordForm').attr('method'),
                url: ");
#nullable restore
#line 95 "C:\Users\Migs\source\repos\123Pay\123Pay\Views\Shared\_UserPanelPartial.cshtml"
                Write(Url.Action("ChangePasswordPartial", "Account"));

#line default
#line hidden
#nullable disable
                WriteLiteral(@",
                data: $('#ChangePasswordForm').serialize(),
                success: function (data) {
                        Toast(""Success"", ""Password updated!"");
                    $('#ChangePassModal').modal('toggle');
                },
                error: function (xhr, status, error) {
                    Toast(status, error);
                }
            });
        });

        $('#ChangePassModal').on('hidden.bs.modal', function (event) {
            $('#ChangePasswordForm').html('');
        });

        function Toast(title, message) {
            var element = '<div class=""toast"" role=""alert"" aria-live=""assertive"" aria-atomic=""true"" style=""min-width: 200px; min-height: 100px;"">' +
                    '<div class=""toast-header"">' +
                    '        <strong class=""mr-auto"">'+title+'</strong>' +
                    '        <small class=""text-muted"">just now</small>' +
                    '        <button type=""button"" class=""ml-2 mb-1 close"" data-dismiss=""to");
                WriteLiteral(@"ast"" aria-label=""Close"">' +
                    '            <span aria-hidden=""true"">&times;</span>' +
                    '        </button>' +
                    '</div>' +
                    '    <div class=""toast-body"">'+message+'</div>' +
                    '</div>';
            $('#toast-area').append(element);
            $('.toast').toast({ delay: 5000 });
            $('.toast').toast('show');
            $('.toast').on('hidden.bs.toast', function () {
                $(this).toast('dispose');
                $(this).remove();
            });
        }
    </script>
");
            }
            );
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public UserManager<AppUser> userManager { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591