#pragma checksum "C:\Users\sns_4\OneDrive\Рабочий стол\math\an3\TAP\TAPPr\src\TAPProiect\Areas\Account\Views\Authentication\Register.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e4dacf2afa27fb90431d84921ce7a3bbe0cc3da0"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Account_Views_Authentication_Register), @"mvc.1.0.view", @"/Areas/Account/Views/Authentication/Register.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e4dacf2afa27fb90431d84921ce7a3bbe0cc3da0", @"/Areas/Account/Views/Authentication/Register.cshtml")]
    public class Areas_Account_Views_Authentication_Register : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<TAP.Web.Areas.Account.Models.RegisterViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\n");
#nullable restore
#line 3 "C:\Users\sns_4\OneDrive\Рабочий стол\math\an3\TAP\TAPPr\src\TAPProiect\Areas\Account\Views\Authentication\Register.cshtml"
  
    ViewData["Title"] = "Register";

#line default
#line hidden
#nullable disable
            WriteLiteral("<h4>Register</h4>\n<hr />\n<div class=\"row\">\n    <div class=\"col-md-4\">\n");
#nullable restore
#line 10 "C:\Users\sns_4\OneDrive\Рабочий стол\math\an3\TAP\TAPPr\src\TAPProiect\Areas\Account\Views\Authentication\Register.cshtml"
         using (Html.BeginForm("Register", "Authentication", FormMethod.Post))
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <div class=\"text-danger\">\n                <ul>\n");
#nullable restore
#line 14 "C:\Users\sns_4\OneDrive\Рабочий стол\math\an3\TAP\TAPPr\src\TAPProiect\Areas\Account\Views\Authentication\Register.cshtml"
                     foreach (var error in ViewData.ModelState.SelectMany(_ => _.Value.Errors))
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <li>\n                            ");
#nullable restore
#line 17 "C:\Users\sns_4\OneDrive\Рабочий стол\math\an3\TAP\TAPPr\src\TAPProiect\Areas\Account\Views\Authentication\Register.cshtml"
                       Write(error.ErrorMessage);

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                        </li>\n");
#nullable restore
#line 19 "C:\Users\sns_4\OneDrive\Рабочий стол\math\an3\TAP\TAPPr\src\TAPProiect\Areas\Account\Views\Authentication\Register.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                </ul>\n            </div>\n            <div class=\"form-group\">\n                ");
#nullable restore
#line 23 "C:\Users\sns_4\OneDrive\Рабочий стол\math\an3\TAP\TAPPr\src\TAPProiect\Areas\Account\Views\Authentication\Register.cshtml"
           Write(Html.Label("Username", "Username"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                ");
#nullable restore
#line 24 "C:\Users\sns_4\OneDrive\Рабочий стол\math\an3\TAP\TAPPr\src\TAPProiect\Areas\Account\Views\Authentication\Register.cshtml"
           Write(Html.TextBoxFor(_ => _.Username, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                ");
#nullable restore
#line 25 "C:\Users\sns_4\OneDrive\Рабочий стол\math\an3\TAP\TAPPr\src\TAPProiect\Areas\Account\Views\Authentication\Register.cshtml"
           Write(Html.ValidationMessageFor(_ => _.Username, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                <span asp-validation-for=\"title\"></span>\n            </div>\n            <div class=\"form-group\">\n                ");
#nullable restore
#line 29 "C:\Users\sns_4\OneDrive\Рабочий стол\math\an3\TAP\TAPPr\src\TAPProiect\Areas\Account\Views\Authentication\Register.cshtml"
           Write(Html.Label("Email", "Email"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                ");
#nullable restore
#line 30 "C:\Users\sns_4\OneDrive\Рабочий стол\math\an3\TAP\TAPPr\src\TAPProiect\Areas\Account\Views\Authentication\Register.cshtml"
           Write(Html.TextBoxFor(_ => _.Email, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                ");
#nullable restore
#line 31 "C:\Users\sns_4\OneDrive\Рабочий стол\math\an3\TAP\TAPPr\src\TAPProiect\Areas\Account\Views\Authentication\Register.cshtml"
           Write(Html.ValidationMessageFor(_ => _.Email, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                <span asp-validation-for=\"title\"></span>\n            </div>\n            <div class=\"form-group\">\n                ");
#nullable restore
#line 35 "C:\Users\sns_4\OneDrive\Рабочий стол\math\an3\TAP\TAPPr\src\TAPProiect\Areas\Account\Views\Authentication\Register.cshtml"
           Write(Html.Label("Password", "Password"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                ");
#nullable restore
#line 36 "C:\Users\sns_4\OneDrive\Рабочий стол\math\an3\TAP\TAPPr\src\TAPProiect\Areas\Account\Views\Authentication\Register.cshtml"
           Write(Html.TextBoxFor(_ => _.Password, new { @class = "form-control", type = "Password" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                ");
#nullable restore
#line 37 "C:\Users\sns_4\OneDrive\Рабочий стол\math\an3\TAP\TAPPr\src\TAPProiect\Areas\Account\Views\Authentication\Register.cshtml"
           Write(Html.ValidationMessageFor(_ => _.Password, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </div>\n            <div class=\"form-group\">\n                ");
#nullable restore
#line 40 "C:\Users\sns_4\OneDrive\Рабочий стол\math\an3\TAP\TAPPr\src\TAPProiect\Areas\Account\Views\Authentication\Register.cshtml"
           Write(Html.AntiForgeryToken());

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                <input type=\"submit\" value=\"Register\" class=\"btn btn-primary\" />\n            </div>\n");
#nullable restore
#line 43 "C:\Users\sns_4\OneDrive\Рабочий стол\math\an3\TAP\TAPPr\src\TAPProiect\Areas\Account\Views\Authentication\Register.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </div>\n</div>\n\n");
            DefineSection("Scripts", async() => {
                WriteLiteral("\n");
#nullable restore
#line 48 "C:\Users\sns_4\OneDrive\Рабочий стол\math\an3\TAP\TAPPr\src\TAPProiect\Areas\Account\Views\Authentication\Register.cshtml"
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<TAP.Web.Areas.Account.Models.RegisterViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
