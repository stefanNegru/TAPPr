#pragma checksum "C:\Users\sns_4\OneDrive\Рабочий стол\math\an3\TAP\TAPPr\src\TAPProiect\Areas\exemplu\Views\Customers\Create.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8e23d0dd6ce7280a3b5c1b7916036c818c6ececc"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_exemplu_Views_Customers_Create), @"mvc.1.0.view", @"/Areas/exemplu/Views/Customers/Create.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8e23d0dd6ce7280a3b5c1b7916036c818c6ececc", @"/Areas/exemplu/Views/Customers/Create.cshtml")]
    public class Areas_exemplu_Views_Customers_Create : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<TAP.Web.Models.CreateCustomerModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"
<h4>CreateCustomerModel</h4>
<hr />
<div class=""row"">
    <div class=""col-md-4"">
        <form asp-action=""Create"">
            <div asp-validation-summary=""ModelOnly"" class=""text-danger""></div>
            <div class=""form-group"">
                <label asp-for=""FirstName"" class=""control-label""></label>
                <input asp-for=""FirstName"" class=""form-control"" />
                <span asp-validation-for=""FirstName"" class=""text-danger""></span>
            </div>
            <div class=""form-group"">
                <label asp-for=""LastName"" class=""control-label""></label>
                <input asp-for=""LastName"" class=""form-control"" />
                <span asp-validation-for=""LastName"" class=""text-danger""></span>
            </div>
            <div class=""form-group"">
                <label asp-for=""IdNc"" class=""control-label""></label>
                <input asp-for=""IdNc"" class=""form-control"" />
                <span asp-validation-for=""IdNc"" class=""text-danger""></span>
          ");
            WriteLiteral("  </div>\r\n            <div class=\"form-group\">\r\n                <input type=\"submit\" value=\"Create\" class=\"btn btn-primary\" />\r\n            </div>\r\n        </form>\r\n    </div>\r\n</div>\r\n\r\n<div>\r\n    <a asp-action=\"Index\">Back to List</a>\r\n</div>\r\n\r\n");
            DefineSection("Scripts", async() => {
                WriteLiteral("\r\n");
#nullable restore
#line 36 "C:\Users\sns_4\OneDrive\Рабочий стол\math\an3\TAP\TAPPr\src\TAPProiect\Areas\exemplu\Views\Customers\Create.cshtml"
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<TAP.Web.Models.CreateCustomerModel> Html { get; private set; }
    }
}
#pragma warning restore 1591