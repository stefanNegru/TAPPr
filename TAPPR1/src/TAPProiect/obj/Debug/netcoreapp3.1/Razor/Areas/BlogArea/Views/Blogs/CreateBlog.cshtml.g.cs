#pragma checksum "C:\Users\sns_4\OneDrive\Рабочий стол\math\an3\TAP\TAPPr\src\TAPProiect\Areas\BlogArea\Views\Blogs\CreateBlog.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "422f2ecfea5969592eaa7f312bbe3044c74f70d3"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_BlogArea_Views_Blogs_CreateBlog), @"mvc.1.0.view", @"/Areas/BlogArea/Views/Blogs/CreateBlog.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"422f2ecfea5969592eaa7f312bbe3044c74f70d3", @"/Areas/BlogArea/Views/Blogs/CreateBlog.cshtml")]
    public class Areas_BlogArea_Views_Blogs_CreateBlog : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<TAP.Web.Areas.BlogArea.Models.BlogCreateViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\sns_4\OneDrive\Рабочий стол\math\an3\TAP\TAPPr\src\TAPProiect\Areas\BlogArea\Views\Blogs\CreateBlog.cshtml"
  
    ViewData["Title"] = "Create New Blog"; 

#line default
#line hidden
#nullable disable
            WriteLiteral("<div class=\"row\">\n    <div class=\"col-md-4\">\n");
#nullable restore
#line 7 "C:\Users\sns_4\OneDrive\Рабочий стол\math\an3\TAP\TAPPr\src\TAPProiect\Areas\BlogArea\Views\Blogs\CreateBlog.cshtml"
         using (Html.BeginForm("CreateBlog", "Blogs", FormMethod.Post))
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <div class=\"text-danger\">\n                <ul>\n");
#nullable restore
#line 11 "C:\Users\sns_4\OneDrive\Рабочий стол\math\an3\TAP\TAPPr\src\TAPProiect\Areas\BlogArea\Views\Blogs\CreateBlog.cshtml"
                     foreach (var error in ViewData.ModelState.SelectMany(_ => _.Value.Errors))
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <li>\n                            ");
#nullable restore
#line 14 "C:\Users\sns_4\OneDrive\Рабочий стол\math\an3\TAP\TAPPr\src\TAPProiect\Areas\BlogArea\Views\Blogs\CreateBlog.cshtml"
                       Write(error.ErrorMessage);

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                        </li>\n");
#nullable restore
#line 16 "C:\Users\sns_4\OneDrive\Рабочий стол\math\an3\TAP\TAPPr\src\TAPProiect\Areas\BlogArea\Views\Blogs\CreateBlog.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                </ul>\n            </div>\n            <div class=\"form-group\">\n                ");
#nullable restore
#line 20 "C:\Users\sns_4\OneDrive\Рабочий стол\math\an3\TAP\TAPPr\src\TAPProiect\Areas\BlogArea\Views\Blogs\CreateBlog.cshtml"
           Write(Html.Label("BlogTitle", "Blog Title"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                ");
#nullable restore
#line 21 "C:\Users\sns_4\OneDrive\Рабочий стол\math\an3\TAP\TAPPr\src\TAPProiect\Areas\BlogArea\Views\Blogs\CreateBlog.cshtml"
           Write(Html.TextBoxFor(_ => _.BlogTitle, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                ");
#nullable restore
#line 22 "C:\Users\sns_4\OneDrive\Рабочий стол\math\an3\TAP\TAPPr\src\TAPProiect\Areas\BlogArea\Views\Blogs\CreateBlog.cshtml"
           Write(Html.ValidationMessageFor(_ => _.BlogTitle, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n\n                ");
#nullable restore
#line 24 "C:\Users\sns_4\OneDrive\Рабочий стол\math\an3\TAP\TAPPr\src\TAPProiect\Areas\BlogArea\Views\Blogs\CreateBlog.cshtml"
           Write(Html.Label("BlogContent", "Blog Content"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                ");
#nullable restore
#line 25 "C:\Users\sns_4\OneDrive\Рабочий стол\math\an3\TAP\TAPPr\src\TAPProiect\Areas\BlogArea\Views\Blogs\CreateBlog.cshtml"
           Write(Html.TextAreaFor(_ => _.BlogContent, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                ");
#nullable restore
#line 26 "C:\Users\sns_4\OneDrive\Рабочий стол\math\an3\TAP\TAPPr\src\TAPProiect\Areas\BlogArea\Views\Blogs\CreateBlog.cshtml"
           Write(Html.ValidationMessageFor(_ => _.BlogTitle, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n\n\n            </div>\n            <div class=\"form-group\">\n                ");
#nullable restore
#line 31 "C:\Users\sns_4\OneDrive\Рабочий стол\math\an3\TAP\TAPPr\src\TAPProiect\Areas\BlogArea\Views\Blogs\CreateBlog.cshtml"
           Write(Html.AntiForgeryToken());

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                <input type=\"submit\" value=\"Create\" class=\"btn btn-primary\" />\n            </div>\n");
#nullable restore
#line 34 "C:\Users\sns_4\OneDrive\Рабочий стол\math\an3\TAP\TAPPr\src\TAPProiect\Areas\BlogArea\Views\Blogs\CreateBlog.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </div>\n</div>\n\n");
            DefineSection("Scripts", async() => {
                WriteLiteral("\n");
#nullable restore
#line 39 "C:\Users\sns_4\OneDrive\Рабочий стол\math\an3\TAP\TAPPr\src\TAPProiect\Areas\BlogArea\Views\Blogs\CreateBlog.cshtml"
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<TAP.Web.Areas.BlogArea.Models.BlogCreateViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
