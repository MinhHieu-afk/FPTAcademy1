#pragma checksum "C:\Users\MuwnHius\source\repos\NWEB.Practice.HieuCM3\NWEB.Practice.HieuCM3\Areas\Admin\Views\Shared\_NavMenu.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f8b4e36e65fc633265c8ab29064a7cc0281665e6"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_Shared__NavMenu), @"mvc.1.0.view", @"/Areas/Admin/Views/Shared/_NavMenu.cshtml")]
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
#line 1 "C:\Users\MuwnHius\source\repos\NWEB.Practice.HieuCM3\NWEB.Practice.HieuCM3\Areas\Admin\Views\_ViewImports.cshtml"
using NWEB.Practice.HieuCM3;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\MuwnHius\source\repos\NWEB.Practice.HieuCM3\NWEB.Practice.HieuCM3\Areas\Admin\Views\_ViewImports.cshtml"
using NWEB.Practice.HieuCM3.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\MuwnHius\source\repos\NWEB.Practice.HieuCM3\NWEB.Practice.HieuCM3\Areas\Admin\Views\Shared\_NavMenu.cshtml"
using Microsoft.AspNetCore.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\MuwnHius\source\repos\NWEB.Practice.HieuCM3\NWEB.Practice.HieuCM3\Areas\Admin\Views\Shared\_NavMenu.cshtml"
using Common.Constants;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\MuwnHius\source\repos\NWEB.Practice.HieuCM3\NWEB.Practice.HieuCM3\Areas\Admin\Views\Shared\_NavMenu.cshtml"
using Common;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f8b4e36e65fc633265c8ab29064a7cc0281665e6", @"/Areas/Admin/Views/Shared/_NavMenu.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"edca715cf5669a1bb8a117c83798de6f384a643b", @"/Areas/Admin/Views/_ViewImports.cshtml")]
    public class Areas_Admin_Views_Shared__NavMenu : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\n");
            WriteLiteral("\n");
            WriteLiteral("<!-- Divider -->\n<hr class=\"sidebar-divider my-0\">\n\n\n<!-- Nav Item - Dashboard -->\n<li class=\"nav-item active\" id=\"check-dashboard\">\n    <a class=\"nav-link\"");
            BeginWriteAttribute("href", " href=\"", 278, "\"", 317, 1);
#nullable restore
#line 13 "C:\Users\MuwnHius\source\repos\NWEB.Practice.HieuCM3\NWEB.Practice.HieuCM3\Areas\Admin\Views\Shared\_NavMenu.cshtml"
WriteAttributeValue("", 285, Url.Action("Dashboard", "Home"), 285, 32, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@">
        <i class=""fas fa-fw fa-tachometer-alt""></i>
        <span>Bảng điều khiển</span>
    </a>
</li>

<!-- Người dùng -->
<hr class=""sidebar-divider"" id=""check-line-users"">
<li class=""nav-item"" id=""check-users"">
    <a class=""nav-link collapsed"" href=""#"" data-toggle=""collapse"" data-target=""#collapseOne""
       aria-expanded=""true"" aria-controls=""collapseOne"">
        <i class=""fas fa-fw fa-cog""></i>
        <span>Manage</span>
    </a>
    <div id=""collapseOne"" class=""collapse"" aria-labelledby=""headingTwo"" data-parent=""#accordionSidebar"">
        <div class=""bg-white py-2 collapse-inner rounded"">
            <a class=""collapse-item""");
            BeginWriteAttribute("href", " href=\"", 963, "\"", 1002, 1);
#nullable restore
#line 29 "C:\Users\MuwnHius\source\repos\NWEB.Practice.HieuCM3\NWEB.Practice.HieuCM3\Areas\Admin\Views\Shared\_NavMenu.cshtml"
WriteAttributeValue("", 970, Url.Action("Index", "Category"), 970, 32, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Category</a>\n            <a class=\"collapse-item\"");
            BeginWriteAttribute("href", " href=\"", 1053, "\"", 1090, 1);
#nullable restore
#line 30 "C:\Users\MuwnHius\source\repos\NWEB.Practice.HieuCM3\NWEB.Practice.HieuCM3\Areas\Admin\Views\Shared\_NavMenu.cshtml"
WriteAttributeValue("", 1060, Url.Action("Index", "Flower"), 1060, 30, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Flower</a>\n        </div>\n    </div>\n</li>\n<li class=\"nav-item\">\n    <a class=\"nav-link collapsed\"");
            BeginWriteAttribute("href", " href=\"", 1190, "\"", 1229, 1);
#nullable restore
#line 35 "C:\Users\MuwnHius\source\repos\NWEB.Practice.HieuCM3\NWEB.Practice.HieuCM3\Areas\Admin\Views\Shared\_NavMenu.cshtml"
WriteAttributeValue("", 1197, Url.Action("Index", "Category"), 1197, 32, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\n        <i class=\"fas fa-fw fa-cog\"></i>\n        <span>Sale Off</span>\n    </a>\n</li>\n");
            WriteLiteral("\n<!-- Divider -->\n<hr class=\"sidebar-divider d-none d-md-block\">\n");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public IHttpContextAccessor HttpContextAccessor { get; private set; }
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
