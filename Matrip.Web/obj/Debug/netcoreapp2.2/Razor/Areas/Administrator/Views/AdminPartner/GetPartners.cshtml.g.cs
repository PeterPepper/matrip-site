#pragma checksum "C:\Users\Cliente\OneDrive\Área de Trabalho\Projetos\Projeto Matrip\Matrip\Matrip.Web\Areas\Administrator\Views\AdminPartner\GetPartners.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2c1f33eb70964f6af4a83a7b6adbd0563ab8b405"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Administrator_Views_AdminPartner_GetPartners), @"mvc.1.0.view", @"/Areas/Administrator/Views/AdminPartner/GetPartners.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Areas/Administrator/Views/AdminPartner/GetPartners.cshtml", typeof(AspNetCore.Areas_Administrator_Views_AdminPartner_GetPartners))]
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
#line 3 "C:\Users\Cliente\OneDrive\Área de Trabalho\Projetos\Projeto Matrip\Matrip\Matrip.Web\Areas\Administrator\Views\_ViewImports.cshtml"
using X.PagedList.Mvc.Core;

#line default
#line hidden
#line 4 "C:\Users\Cliente\OneDrive\Área de Trabalho\Projetos\Projeto Matrip\Matrip\Matrip.Web\Areas\Administrator\Views\_ViewImports.cshtml"
using X.PagedList;

#line default
#line hidden
#line 6 "C:\Users\Cliente\OneDrive\Área de Trabalho\Projetos\Projeto Matrip\Matrip\Matrip.Web\Areas\Administrator\Views\_ViewImports.cshtml"
using Matrip;

#line default
#line hidden
#line 7 "C:\Users\Cliente\OneDrive\Área de Trabalho\Projetos\Projeto Matrip\Matrip\Matrip.Web\Areas\Administrator\Views\_ViewImports.cshtml"
using Matrip.Domain.Models;

#line default
#line hidden
#line 8 "C:\Users\Cliente\OneDrive\Área de Trabalho\Projetos\Projeto Matrip\Matrip\Matrip.Web\Areas\Administrator\Views\_ViewImports.cshtml"
using Matrip.Domain.Models.Entities;

#line default
#line hidden
#line 9 "C:\Users\Cliente\OneDrive\Área de Trabalho\Projetos\Projeto Matrip\Matrip\Matrip.Web\Areas\Administrator\Views\_ViewImports.cshtml"
using Matrip.Domain.Models.AccountModels;

#line default
#line hidden
#line 10 "C:\Users\Cliente\OneDrive\Área de Trabalho\Projetos\Projeto Matrip\Matrip\Matrip.Web\Areas\Administrator\Views\_ViewImports.cshtml"
using Matrip.Domain.Models.HomeModels;

#line default
#line hidden
#line 11 "C:\Users\Cliente\OneDrive\Área de Trabalho\Projetos\Projeto Matrip\Matrip\Matrip.Web\Areas\Administrator\Views\_ViewImports.cshtml"
using Matrip.Domain.Models.Payment;

#line default
#line hidden
#line 12 "C:\Users\Cliente\OneDrive\Área de Trabalho\Projetos\Projeto Matrip\Matrip\Matrip.Web\Areas\Administrator\Views\_ViewImports.cshtml"
using Matrip.Domain.Models.TripModel;

#line default
#line hidden
#line 13 "C:\Users\Cliente\OneDrive\Área de Trabalho\Projetos\Projeto Matrip\Matrip\Matrip.Web\Areas\Administrator\Views\_ViewImports.cshtml"
using Matrip.Domain.Models.TripPurchase;

#line default
#line hidden
#line 14 "C:\Users\Cliente\OneDrive\Área de Trabalho\Projetos\Projeto Matrip\Matrip\Matrip.Web\Areas\Administrator\Views\_ViewImports.cshtml"
using Matrip.Domain.Libraries.Text;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2c1f33eb70964f6af4a83a7b6adbd0563ab8b405", @"/Areas/Administrator/Views/AdminPartner/GetPartners.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1e473379225778e9bbc498bb3b5e73f55afe885e", @"/Areas/Administrator/Views/_ViewImports.cshtml")]
    public class Areas_Administrator_Views_AdminPartner_GetPartners : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-area", "Administrator", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "AdminPartner", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "UpdatePartner", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "AddPartner", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn-success btn-lg"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "C:\Users\Cliente\OneDrive\Área de Trabalho\Projetos\Projeto Matrip\Matrip\Matrip.Web\Areas\Administrator\Views\AdminPartner\GetPartners.cshtml"
  
    ViewData["Title"] = "Partners";
    Layout = "~/Areas/Administrator/Views/Shared/_Layout.cshtml";
    List<ma25partner> partnerList = ViewBag.Partners;

#line default
#line hidden
            BeginContext(166, 22, true);
            WriteLiteral("\r\n<div class=\"mt-5\">\r\n");
            EndContext();
#line 8 "C:\Users\Cliente\OneDrive\Área de Trabalho\Projetos\Projeto Matrip\Matrip\Matrip.Web\Areas\Administrator\Views\AdminPartner\GetPartners.cshtml"
       await Html.RenderPartialAsync("~/Views/Shared/_Message.cshtml"); 

#line default
#line hidden
            BeginContext(263, 215, true);
            WriteLiteral("\r\n    <table class=\"table table-bordered\">\r\n        <tr>\r\n            <td>Empresa</td>\r\n            <td>CNPJ</td>\r\n            <td>Email</td>\r\n            <td>Status</td>\r\n            <td>Ações</td>\r\n        </tr>\r\n");
            EndContext();
#line 18 "C:\Users\Cliente\OneDrive\Área de Trabalho\Projetos\Projeto Matrip\Matrip\Matrip.Web\Areas\Administrator\Views\AdminPartner\GetPartners.cshtml"
         if (partnerList != null)
        {
            

#line default
#line hidden
#line 20 "C:\Users\Cliente\OneDrive\Área de Trabalho\Projetos\Projeto Matrip\Matrip\Matrip.Web\Areas\Administrator\Views\AdminPartner\GetPartners.cshtml"
             for (int i = 0; i < partnerList.Count; i++)
            {

#line default
#line hidden
            BeginContext(597, 46, true);
            WriteLiteral("                <tr>\r\n                    <td>");
            EndContext();
            BeginContext(644, 23, false);
#line 23 "C:\Users\Cliente\OneDrive\Área de Trabalho\Projetos\Projeto Matrip\Matrip\Matrip.Web\Areas\Administrator\Views\AdminPartner\GetPartners.cshtml"
                   Write(partnerList[i].ma25name);

#line default
#line hidden
            EndContext();
            BeginContext(667, 31, true);
            WriteLiteral("</td>\r\n                    <td>");
            EndContext();
            BeginContext(699, 23, false);
#line 24 "C:\Users\Cliente\OneDrive\Área de Trabalho\Projetos\Projeto Matrip\Matrip\Matrip.Web\Areas\Administrator\Views\AdminPartner\GetPartners.cshtml"
                   Write(partnerList[i].ma25CNPJ);

#line default
#line hidden
            EndContext();
            BeginContext(722, 31, true);
            WriteLiteral("</td>\r\n                    <td>");
            EndContext();
            BeginContext(754, 24, false);
#line 25 "C:\Users\Cliente\OneDrive\Área de Trabalho\Projetos\Projeto Matrip\Matrip\Matrip.Web\Areas\Administrator\Views\AdminPartner\GetPartners.cshtml"
                   Write(partnerList[i].ma25email);

#line default
#line hidden
            EndContext();
            BeginContext(778, 33, true);
            WriteLiteral("</td>\r\n                    <td>\r\n");
            EndContext();
#line 27 "C:\Users\Cliente\OneDrive\Área de Trabalho\Projetos\Projeto Matrip\Matrip\Matrip.Web\Areas\Administrator\Views\AdminPartner\GetPartners.cshtml"
                         if(partnerList[i].ma25status == "1")
                        {
                            Html.Raw("Ativo");
                        }
                        else if(partnerList[i].ma25status == "0")
                        {
                            Html.Raw("Inativo");
                        }

#line default
#line hidden
            BeginContext(1147, 52, true);
            WriteLiteral("                    </td>\r\n                    <td> ");
            EndContext();
            BeginContext(1199, 147, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2c1f33eb70964f6af4a83a7b6adbd0563ab8b40510661", async() => {
                BeginContext(1336, 6, true);
                WriteLiteral("Editar");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Area = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-PartnerID", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 36 "C:\Users\Cliente\OneDrive\Área de Trabalho\Projetos\Projeto Matrip\Matrip\Matrip.Web\Areas\Administrator\Views\AdminPartner\GetPartners.cshtml"
                                                                                                                       WriteLiteral(partnerList[i].ma25idpartner);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["PartnerID"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-PartnerID", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["PartnerID"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1346, 30, true);
            WriteLiteral("</td>\r\n                </tr>\r\n");
            EndContext();
#line 38 "C:\Users\Cliente\OneDrive\Área de Trabalho\Projetos\Projeto Matrip\Matrip\Matrip.Web\Areas\Administrator\Views\AdminPartner\GetPartners.cshtml"
            }

#line default
#line hidden
#line 38 "C:\Users\Cliente\OneDrive\Área de Trabalho\Projetos\Projeto Matrip\Matrip\Matrip.Web\Areas\Administrator\Views\AdminPartner\GetPartners.cshtml"
             
        }

#line default
#line hidden
            BeginContext(1402, 52, true);
            WriteLiteral("\r\n\r\n    </table>\r\n\r\n</div>\r\n<div class=\"mt-5\">\r\n    ");
            EndContext();
            BeginContext(1454, 131, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2c1f33eb70964f6af4a83a7b6adbd0563ab8b40514200", async() => {
                BeginContext(1563, 18, true);
                WriteLiteral("Adicionar Parceiro");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Area = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1585, 8, true);
            WriteLiteral("\r\n</div>");
            EndContext();
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
