#pragma checksum "C:\Users\sns_4\OneDrive\Рабочий стол\math\an3\TAP\TAPPr\src\TAPProiect\Areas\Account\Views\Authentication\EditUser.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2f29608fd966e974e2189c8b8084f392d856c8cd"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Account_Views_Authentication_EditUser), @"mvc.1.0.view", @"/Areas/Account/Views/Authentication/EditUser.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2f29608fd966e974e2189c8b8084f392d856c8cd", @"/Areas/Account/Views/Authentication/EditUser.cshtml")]
    public class Areas_Account_Views_Authentication_EditUser : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<TAP.Web.Areas.Account.Models.EditUserViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\sns_4\OneDrive\Рабочий стол\math\an3\TAP\TAPPr\src\TAPProiect\Areas\Account\Views\Authentication\EditUser.cshtml"
  
    ViewData["Title"] = "Edit User";

#line default
#line hidden
#nullable disable
            WriteLiteral("<h4>Edit User Info</h4>\n<hr />\n<div class=\"row\">\n    <div class=\"col-md-4\">\n");
#nullable restore
#line 9 "C:\Users\sns_4\OneDrive\Рабочий стол\math\an3\TAP\TAPPr\src\TAPProiect\Areas\Account\Views\Authentication\EditUser.cshtml"
         using (Html.BeginForm("EditUser", "Authentication", FormMethod.Post))
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <div class=\"text-danger\">\n                <ul>\n");
#nullable restore
#line 13 "C:\Users\sns_4\OneDrive\Рабочий стол\math\an3\TAP\TAPPr\src\TAPProiect\Areas\Account\Views\Authentication\EditUser.cshtml"
                     foreach (var error in ViewData.ModelState.SelectMany(_ => _.Value.Errors))
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <li>\n                            ");
#nullable restore
#line 16 "C:\Users\sns_4\OneDrive\Рабочий стол\math\an3\TAP\TAPPr\src\TAPProiect\Areas\Account\Views\Authentication\EditUser.cshtml"
                       Write(error.ErrorMessage);

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                        </li>\n");
#nullable restore
#line 18 "C:\Users\sns_4\OneDrive\Рабочий стол\math\an3\TAP\TAPPr\src\TAPProiect\Areas\Account\Views\Authentication\EditUser.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                </ul>\n            </div>\n            <div class=\"form-group\">\n                ");
#nullable restore
#line 22 "C:\Users\sns_4\OneDrive\Рабочий стол\math\an3\TAP\TAPPr\src\TAPProiect\Areas\Account\Views\Authentication\EditUser.cshtml"
           Write(Html.Label("Username", "Username"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                ");
#nullable restore
#line 23 "C:\Users\sns_4\OneDrive\Рабочий стол\math\an3\TAP\TAPPr\src\TAPProiect\Areas\Account\Views\Authentication\EditUser.cshtml"
           Write(Html.TextBoxFor(_ => _.User.Name, new { @disabled = "disabled", @class = "form-control",Value=Model.User.Name }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </div>\n            <div class=\"form-group\">\n                ");
#nullable restore
#line 26 "C:\Users\sns_4\OneDrive\Рабочий стол\math\an3\TAP\TAPPr\src\TAPProiect\Areas\Account\Views\Authentication\EditUser.cshtml"
           Write(Html.Label("CurrentPassword", "Current Password"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                ");
#nullable restore
#line 27 "C:\Users\sns_4\OneDrive\Рабочий стол\math\an3\TAP\TAPPr\src\TAPProiect\Areas\Account\Views\Authentication\EditUser.cshtml"
           Write(Html.TextBoxFor(_ => _.CurrentPassword, new { type = "password", @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                ");
#nullable restore
#line 28 "C:\Users\sns_4\OneDrive\Рабочий стол\math\an3\TAP\TAPPr\src\TAPProiect\Areas\Account\Views\Authentication\EditUser.cshtml"
           Write(Html.ValidationMessageFor(_ => _.CurrentPassword, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </div>\n            <div class=\"form-group\">\n                ");
#nullable restore
#line 31 "C:\Users\sns_4\OneDrive\Рабочий стол\math\an3\TAP\TAPPr\src\TAPProiect\Areas\Account\Views\Authentication\EditUser.cshtml"
           Write(Html.Label("NewPassword", "New Password"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                ");
#nullable restore
#line 32 "C:\Users\sns_4\OneDrive\Рабочий стол\math\an3\TAP\TAPPr\src\TAPProiect\Areas\Account\Views\Authentication\EditUser.cshtml"
           Write(Html.TextBoxFor(_ => _.NewPassword, new { type = "password", @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                ");
#nullable restore
#line 33 "C:\Users\sns_4\OneDrive\Рабочий стол\math\an3\TAP\TAPPr\src\TAPProiect\Areas\Account\Views\Authentication\EditUser.cshtml"
           Write(Html.ValidationMessageFor(_ => _.NewPassword, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </div>\n            <div class=\"form-group\">\n                ");
#nullable restore
#line 36 "C:\Users\sns_4\OneDrive\Рабочий стол\math\an3\TAP\TAPPr\src\TAPProiect\Areas\Account\Views\Authentication\EditUser.cshtml"
           Write(Html.AntiForgeryToken());

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                <input type=\"submit\" value=\"Update\" class=\"btn btn-primary\" />\n            </div>\n");
#nullable restore
#line 39 "C:\Users\sns_4\OneDrive\Рабочий стол\math\an3\TAP\TAPPr\src\TAPProiect\Areas\Account\Views\Authentication\EditUser.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </div>\n</div>\n\n");
            DefineSection("Scripts", async() => {
                WriteLiteral("\n");
#nullable restore
#line 44 "C:\Users\sns_4\OneDrive\Рабочий стол\math\an3\TAP\TAPPr\src\TAPProiect\Areas\Account\Views\Authentication\EditUser.cshtml"
      await Html.RenderPartialAsync("_ValidationScriptsPartial");

#line default
#line hidden
#nullable disable
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<TAP.Web.Areas.Account.Models.EditUserViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
