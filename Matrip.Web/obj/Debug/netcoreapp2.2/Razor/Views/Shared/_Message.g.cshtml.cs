#pragma checksum "C:\Users\Cliente\OneDrive\Área de Trabalho\Projetos\Projeto Matrip\Matrip\Matrip.Web\Views\Shared\_Message.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3871c1d876c3caf2d20786776608ffd3eaecc82c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__Message), @"mvc.1.0.view", @"/Views/Shared/_Message.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Shared/_Message.cshtml", typeof(AspNetCore.Views_Shared__Message))]
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
#line 3 "C:\Users\Cliente\OneDrive\Área de Trabalho\Projetos\Projeto Matrip\Matrip\Matrip.Web\Views\_ViewImports.cshtml"
using X.PagedList.Mvc.Core;

#line default
#line hidden
#line 4 "C:\Users\Cliente\OneDrive\Área de Trabalho\Projetos\Projeto Matrip\Matrip\Matrip.Web\Views\_ViewImports.cshtml"
using X.PagedList;

#line default
#line hidden
#line 6 "C:\Users\Cliente\OneDrive\Área de Trabalho\Projetos\Projeto Matrip\Matrip\Matrip.Web\Views\_ViewImports.cshtml"
using Matrip;

#line default
#line hidden
#line 7 "C:\Users\Cliente\OneDrive\Área de Trabalho\Projetos\Projeto Matrip\Matrip\Matrip.Web\Views\_ViewImports.cshtml"
using Matrip.Domain.Models;

#line default
#line hidden
#line 8 "C:\Users\Cliente\OneDrive\Área de Trabalho\Projetos\Projeto Matrip\Matrip\Matrip.Web\Views\_ViewImports.cshtml"
using Matrip.Domain.Models.Entities;

#line default
#line hidden
#line 9 "C:\Users\Cliente\OneDrive\Área de Trabalho\Projetos\Projeto Matrip\Matrip\Matrip.Web\Views\_ViewImports.cshtml"
using Matrip.Domain.Models.AccountModels;

#line default
#line hidden
#line 10 "C:\Users\Cliente\OneDrive\Área de Trabalho\Projetos\Projeto Matrip\Matrip\Matrip.Web\Views\_ViewImports.cshtml"
using Matrip.Domain.Models.HomeModels;

#line default
#line hidden
#line 11 "C:\Users\Cliente\OneDrive\Área de Trabalho\Projetos\Projeto Matrip\Matrip\Matrip.Web\Views\_ViewImports.cshtml"
using Matrip.Domain.Models.Payment;

#line default
#line hidden
#line 12 "C:\Users\Cliente\OneDrive\Área de Trabalho\Projetos\Projeto Matrip\Matrip\Matrip.Web\Views\_ViewImports.cshtml"
using Matrip.Domain.Models.TripModel;

#line default
#line hidden
#line 13 "C:\Users\Cliente\OneDrive\Área de Trabalho\Projetos\Projeto Matrip\Matrip\Matrip.Web\Views\_ViewImports.cshtml"
using Matrip.Domain.Models.TripPurchase;

#line default
#line hidden
#line 14 "C:\Users\Cliente\OneDrive\Área de Trabalho\Projetos\Projeto Matrip\Matrip\Matrip.Web\Views\_ViewImports.cshtml"
using Matrip.Domain.Libraries.Text;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3871c1d876c3caf2d20786776608ffd3eaecc82c", @"/Views/Shared/_Message.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3828e859f41a5dde7e402272627dd108be10bd34", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared__Message : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "C:\Users\Cliente\OneDrive\Área de Trabalho\Projetos\Projeto Matrip\Matrip\Matrip.Web\Views\Shared\_Message.cshtml"
 if (ViewData["MSG_E"] != null)
{

#line default
#line hidden
            BeginContext(36, 34, true);
            WriteLiteral("    <p class=\"alert alert-danger\">");
            EndContext();
            BeginContext(71, 27, false);
#line 3 "C:\Users\Cliente\OneDrive\Área de Trabalho\Projetos\Projeto Matrip\Matrip\Matrip.Web\Views\Shared\_Message.cshtml"
                             Write(Html.Raw(ViewData["MSG_E"]));

#line default
#line hidden
            EndContext();
            BeginContext(98, 6, true);
            WriteLiteral("</p>\r\n");
            EndContext();
#line 4 "C:\Users\Cliente\OneDrive\Área de Trabalho\Projetos\Projeto Matrip\Matrip\Matrip.Web\Views\Shared\_Message.cshtml"
}

#line default
#line hidden
#line 5 "C:\Users\Cliente\OneDrive\Área de Trabalho\Projetos\Projeto Matrip\Matrip\Matrip.Web\Views\Shared\_Message.cshtml"
 if (TempData["MSG_E"] != null)
{

#line default
#line hidden
            BeginContext(143, 34, true);
            WriteLiteral("    <p class=\"alert alert-danger\">");
            EndContext();
            BeginContext(178, 27, false);
#line 7 "C:\Users\Cliente\OneDrive\Área de Trabalho\Projetos\Projeto Matrip\Matrip\Matrip.Web\Views\Shared\_Message.cshtml"
                             Write(Html.Raw(TempData["MSG_E"]));

#line default
#line hidden
            EndContext();
            BeginContext(205, 6, true);
            WriteLiteral("</p>\r\n");
            EndContext();
#line 8 "C:\Users\Cliente\OneDrive\Área de Trabalho\Projetos\Projeto Matrip\Matrip\Matrip.Web\Views\Shared\_Message.cshtml"
}

#line default
#line hidden
            BeginContext(214, 4, true);
            WriteLiteral("\r\n\r\n");
            EndContext();
#line 11 "C:\Users\Cliente\OneDrive\Área de Trabalho\Projetos\Projeto Matrip\Matrip\Matrip.Web\Views\Shared\_Message.cshtml"
 if (ViewData["MSG_S"] != null)
{

#line default
#line hidden
            BeginContext(254, 35, true);
            WriteLiteral("    <p class=\"alert alert-success\">");
            EndContext();
            BeginContext(290, 27, false);
#line 13 "C:\Users\Cliente\OneDrive\Área de Trabalho\Projetos\Projeto Matrip\Matrip\Matrip.Web\Views\Shared\_Message.cshtml"
                              Write(Html.Raw(ViewData["MSG_S"]));

#line default
#line hidden
            EndContext();
            BeginContext(317, 6, true);
            WriteLiteral("</p>\r\n");
            EndContext();
#line 14 "C:\Users\Cliente\OneDrive\Área de Trabalho\Projetos\Projeto Matrip\Matrip\Matrip.Web\Views\Shared\_Message.cshtml"
}

#line default
#line hidden
#line 15 "C:\Users\Cliente\OneDrive\Área de Trabalho\Projetos\Projeto Matrip\Matrip\Matrip.Web\Views\Shared\_Message.cshtml"
 if (TempData["MSG_S"] != null)
{

#line default
#line hidden
            BeginContext(362, 35, true);
            WriteLiteral("    <p class=\"alert alert-success\">");
            EndContext();
            BeginContext(398, 27, false);
#line 17 "C:\Users\Cliente\OneDrive\Área de Trabalho\Projetos\Projeto Matrip\Matrip\Matrip.Web\Views\Shared\_Message.cshtml"
                              Write(Html.Raw(TempData["MSG_S"]));

#line default
#line hidden
            EndContext();
            BeginContext(425, 6, true);
            WriteLiteral("</p>\r\n");
            EndContext();
#line 18 "C:\Users\Cliente\OneDrive\Área de Trabalho\Projetos\Projeto Matrip\Matrip\Matrip.Web\Views\Shared\_Message.cshtml"
}

#line default
#line hidden
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
