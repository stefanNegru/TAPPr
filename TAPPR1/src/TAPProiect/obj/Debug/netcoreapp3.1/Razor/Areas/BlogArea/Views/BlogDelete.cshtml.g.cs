#pragma checksum "C:\Users\sns_4\OneDrive\Рабочий стол\math\an3\TAP\TAPPr\src\TAPProiect\Areas\BlogArea\Views\BlogDelete.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d3f6148dbcdb7d346c08fa51ef56e47f08c93cdb"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_BlogArea_Views_BlogDelete), @"mvc.1.0.view", @"/Areas/BlogArea/Views/BlogDelete.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d3f6148dbcdb7d346c08fa51ef56e47f08c93cdb", @"/Areas/BlogArea/Views/BlogDelete.cshtml")]
    public class Areas_BlogArea_Views_BlogDelete : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<TAP.Web.Areas.BlogArea.Models.BlogDeleteViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\n");
#nullable restore
#line 3 "C:\Users\sns_4\OneDrive\Рабочий стол\math\an3\TAP\TAPPr\src\TAPProiect\Areas\BlogArea\Views\BlogDelete.cshtml"
  
    ViewData["Title"] = "Delete Blog";

#line default
#line hidden
#nullable disable
            WriteLiteral("<h3>Are you sure you want to delete this?</h3>\n<div class=\"container\">\n    <dl class=\"row\">\n        <dt class=\"col-sm-2\">\n            ");
#nullable restore
#line 10 "C:\Users\sns_4\OneDrive\Рабочий стол\math\an3\TAP\TAPPr\src\TAPProiect\Areas\BlogArea\Views\BlogDelete.cshtml"
       Write(Html.DisplayNameFor(_ => _.BlogTitle));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </dt>\n        <dd class=\"col-sm-10\">\n            ");
#nullable restore
#line 13 "C:\Users\sns_4\OneDrive\Рабочий стол\math\an3\TAP\TAPPr\src\TAPProiect\Areas\BlogArea\Views\BlogDelete.cshtml"
       Write(Html.DisplayFor(_ => _.BlogTitle));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </dd>\n    </dl>\n");
#nullable restore
#line 16 "C:\Users\sns_4\OneDrive\Рабочий стол\math\an3\TAP\TAPPr\src\TAPProiect\Areas\BlogArea\Views\BlogDelete.cshtml"
     using (Html.BeginForm("Delete", "Songs", FormMethod.Post))
    {
        

#line default
#line hidden
#nullable disable
#nullable restore
#line 18 "C:\Users\sns_4\OneDrive\Рабочий стол\math\an3\TAP\TAPPr\src\TAPProiect\Areas\BlogArea\Views\BlogDelete.cshtml"
   Write(Html.HiddenFor(_ => _.BlogId));

#line default
#line hidden
#nullable disable
#nullable restore
#line 19 "C:\Users\sns_4\OneDrive\Рабочий стол\math\an3\TAP\TAPPr\src\TAPProiect\Areas\BlogArea\Views\BlogDelete.cshtml"
   Write(Html.HiddenFor(_ => _.UserId));

#line default
#line hidden
#nullable disable
#nullable restore
#line 20 "C:\Users\sns_4\OneDrive\Рабочий стол\math\an3\TAP\TAPPr\src\TAPProiect\Areas\BlogArea\Views\BlogDelete.cshtml"
   Write(Html.AntiForgeryToken());

#line default
#line hidden
#nullable disable
            WriteLiteral("        <input type=\"submit\" value=\"Delete\" class=\"btn btn-danger\"/>\n");
#nullable restore
#line 22 "C:\Users\sns_4\OneDrive\Рабочий стол\math\an3\TAP\TAPPr\src\TAPProiect\Areas\BlogArea\Views\BlogDelete.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<TAP.Web.Areas.BlogArea.Models.BlogDeleteViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
