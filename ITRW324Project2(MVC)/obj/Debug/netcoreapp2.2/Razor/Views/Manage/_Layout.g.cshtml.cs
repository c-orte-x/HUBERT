#pragma checksum "C:\Users\wwwar\Documents\ITRW324Project2-MVC-\ITRW324Project2(MVC)\Views\Manage\_Layout.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7119cda26232a5cc4976c4453945c7f32dd08763"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Manage__Layout), @"mvc.1.0.view", @"/Views/Manage/_Layout.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Manage/_Layout.cshtml", typeof(AspNetCore.Views_Manage__Layout))]
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
#line 1 "C:\Users\wwwar\Documents\ITRW324Project2-MVC-\ITRW324Project2(MVC)\Views\_ViewImports.cshtml"
using Final;

#line default
#line hidden
#line 2 "C:\Users\wwwar\Documents\ITRW324Project2-MVC-\ITRW324Project2(MVC)\Views\_ViewImports.cshtml"
using Final.Models;

#line default
#line hidden
#line 3 "C:\Users\wwwar\Documents\ITRW324Project2-MVC-\ITRW324Project2(MVC)\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#line 4 "C:\Users\wwwar\Documents\ITRW324Project2-MVC-\ITRW324Project2(MVC)\Views\_ViewImports.cshtml"
using Final.Models.AccountViewModels;

#line default
#line hidden
#line 5 "C:\Users\wwwar\Documents\ITRW324Project2-MVC-\ITRW324Project2(MVC)\Views\_ViewImports.cshtml"
using Final.Models.ManageViewModels;

#line default
#line hidden
#line 1 "C:\Users\wwwar\Documents\ITRW324Project2-MVC-\ITRW324Project2(MVC)\Views\Manage\_ViewImports.cshtml"
using Final.Views.Manage;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7119cda26232a5cc4976c4453945c7f32dd08763", @"/Views/Manage/_Layout.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fcdfd7574ee31cfe7db5033634b33589daf9de52", @"/Views/_ViewImports.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5b406912f8b37c4dca40b33b7ba44f88cf5a6276", @"/Views/Manage/_ViewImports.cshtml")]
    public class Views_Manage__Layout : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "C:\Users\wwwar\Documents\ITRW324Project2-MVC-\ITRW324Project2(MVC)\Views\Manage\_Layout.cshtml"
  
    Layout = "/Views/Shared/_Layout.cshtml";

#line default
#line hidden
            BeginContext(50, 155, true);
            WriteLiteral("\n<h2>Manage your account</h2>\n\n<div>\n    <h4>Change your account settings</h4>\n    <hr />\n    <div class=\"row\">\n        <div class=\"col-md-3\">\n            ");
            EndContext();
            BeginContext(206, 37, false);
#line 12 "C:\Users\wwwar\Documents\ITRW324Project2-MVC-\ITRW324Project2(MVC)\Views\Manage\_Layout.cshtml"
       Write(await Html.PartialAsync("_ManageNav"));

#line default
#line hidden
            EndContext();
            BeginContext(243, 59, true);
            WriteLiteral("\n        </div>\n        <div class=\"col-md-9\">\n            ");
            EndContext();
            BeginContext(303, 12, false);
#line 15 "C:\Users\wwwar\Documents\ITRW324Project2-MVC-\ITRW324Project2(MVC)\Views\Manage\_Layout.cshtml"
       Write(RenderBody());

#line default
#line hidden
            EndContext();
            BeginContext(315, 35, true);
            WriteLiteral("\n        </div>\n    </div>\n</div>\n\n");
            EndContext();
            DefineSection("Scripts", async() => {
                BeginContext(368, 5, true);
                WriteLiteral("\n    ");
                EndContext();
                BeginContext(374, 41, false);
#line 21 "C:\Users\wwwar\Documents\ITRW324Project2-MVC-\ITRW324Project2(MVC)\Views\Manage\_Layout.cshtml"
Write(RenderSection("Scripts", required: false));

#line default
#line hidden
                EndContext();
                BeginContext(415, 1, true);
                WriteLiteral("\n");
                EndContext();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591