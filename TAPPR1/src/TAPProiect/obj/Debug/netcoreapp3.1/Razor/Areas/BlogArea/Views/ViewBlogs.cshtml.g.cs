#pragma checksum "C:\Users\sns_4\OneDrive\Рабочий стол\math\an3\TAP\TAPPr\src\TAPProiect\Areas\BlogArea\Views\ViewBlogs.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b728f70b9af6bce3d99a3d5eb49be5cb8048aef4"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_BlogArea_Views_ViewBlogs), @"mvc.1.0.view", @"/Areas/BlogArea/Views/ViewBlogs.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b728f70b9af6bce3d99a3d5eb49be5cb8048aef4", @"/Areas/BlogArea/Views/ViewBlogs.cshtml")]
    public class Areas_BlogArea_Views_ViewBlogs : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<TAP.Web.Areas.BlogArea.Models.UserBlogsViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\sns_4\OneDrive\Рабочий стол\math\an3\TAP\TAPPr\src\TAPProiect\Areas\BlogArea\Views\ViewBlogs.cshtml"
  
    ViewData["Title"] = "View Blogs";

#line default
#line hidden
#nullable disable
            WriteLiteral("\n<div class=\"container\">\n");
#nullable restore
#line 7 "C:\Users\sns_4\OneDrive\Рабочий стол\math\an3\TAP\TAPPr\src\TAPProiect\Areas\BlogArea\Views\ViewBlogs.cshtml"
     if (Model.Blogs.Count() > 0)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <table class=\"table\">\n            \n            <tbody>\n");
#nullable restore
#line 12 "C:\Users\sns_4\OneDrive\Рабочий стол\math\an3\TAP\TAPPr\src\TAPProiect\Areas\BlogArea\Views\ViewBlogs.cshtml"
                 foreach (var item in Model.Blogs)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <tr>\n                        \n                        <td>\n                            ");
#nullable restore
#line 17 "C:\Users\sns_4\OneDrive\Рабочий стол\math\an3\TAP\TAPPr\src\TAPProiect\Areas\BlogArea\Views\ViewBlogs.cshtml"
                       Write(item.Author);

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                        </td>\n                        <td>\n                            ");
#nullable restore
#line 20 "C:\Users\sns_4\OneDrive\Рабочий стол\math\an3\TAP\TAPPr\src\TAPProiect\Areas\BlogArea\Views\ViewBlogs.cshtml"
                       Write(item.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                        </td>\n                        <td>\n                            ");
#nullable restore
#line 23 "C:\Users\sns_4\OneDrive\Рабочий стол\math\an3\TAP\TAPPr\src\TAPProiect\Areas\BlogArea\Views\ViewBlogs.cshtml"
                       Write(item.Content);

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                        </td>\n                        \n\n                        <td>\n                            ");
#nullable restore
#line 28 "C:\Users\sns_4\OneDrive\Рабочий стол\math\an3\TAP\TAPPr\src\TAPProiect\Areas\BlogArea\Views\ViewBlogs.cshtml"
                       Write(Html.ActionLink("Delete", "Delete", "Blogs", new { id = item.Id, name = item.Title }, new { @class = "btn btn-danger", role = "button" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n\n                        </td>\n                    </tr>\n");
#nullable restore
#line 32 "C:\Users\sns_4\OneDrive\Рабочий стол\math\an3\TAP\TAPPr\src\TAPProiect\Areas\BlogArea\Views\ViewBlogs.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </tbody>\n        </table>\n");
#nullable restore
#line 35 "C:\Users\sns_4\OneDrive\Рабочий стол\math\an3\TAP\TAPPr\src\TAPProiect\Areas\BlogArea\Views\ViewBlogs.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("    \n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<TAP.Web.Areas.BlogArea.Models.UserBlogsViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
