#pragma checksum "C:\Users\Cliente\OneDrive\Área de Trabalho\Projetos\Projeto Matrip\Matrip\Matrip.Web\Areas\Guide\Views\SalesReport\SearchPartner.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f7484337fbce31d425d4298b138d7c89874de899"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Guide_Views_SalesReport_SearchPartner), @"mvc.1.0.view", @"/Areas/Guide/Views/SalesReport/SearchPartner.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Areas/Guide/Views/SalesReport/SearchPartner.cshtml", typeof(AspNetCore.Areas_Guide_Views_SalesReport_SearchPartner))]
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
#line 3 "C:\Users\Cliente\OneDrive\Área de Trabalho\Projetos\Projeto Matrip\Matrip\Matrip.Web\Areas\Guide\Views\_ViewImports.cshtml"
using X.PagedList.Mvc.Core;

#line default
#line hidden
#line 4 "C:\Users\Cliente\OneDrive\Área de Trabalho\Projetos\Projeto Matrip\Matrip\Matrip.Web\Areas\Guide\Views\_ViewImports.cshtml"
using X.PagedList;

#line default
#line hidden
#line 6 "C:\Users\Cliente\OneDrive\Área de Trabalho\Projetos\Projeto Matrip\Matrip\Matrip.Web\Areas\Guide\Views\_ViewImports.cshtml"
using Matrip;

#line default
#line hidden
#line 7 "C:\Users\Cliente\OneDrive\Área de Trabalho\Projetos\Projeto Matrip\Matrip\Matrip.Web\Areas\Guide\Views\_ViewImports.cshtml"
using Matrip.Domain.Models;

#line default
#line hidden
#line 8 "C:\Users\Cliente\OneDrive\Área de Trabalho\Projetos\Projeto Matrip\Matrip\Matrip.Web\Areas\Guide\Views\_ViewImports.cshtml"
using Matrip.Domain.Models.Entities;

#line default
#line hidden
#line 9 "C:\Users\Cliente\OneDrive\Área de Trabalho\Projetos\Projeto Matrip\Matrip\Matrip.Web\Areas\Guide\Views\_ViewImports.cshtml"
using Matrip.Domain.Models.AccountModels;

#line default
#line hidden
#line 10 "C:\Users\Cliente\OneDrive\Área de Trabalho\Projetos\Projeto Matrip\Matrip\Matrip.Web\Areas\Guide\Views\_ViewImports.cshtml"
using Matrip.Domain.Models.HomeModels;

#line default
#line hidden
#line 11 "C:\Users\Cliente\OneDrive\Área de Trabalho\Projetos\Projeto Matrip\Matrip\Matrip.Web\Areas\Guide\Views\_ViewImports.cshtml"
using Matrip.Domain.Models.Payment;

#line default
#line hidden
#line 12 "C:\Users\Cliente\OneDrive\Área de Trabalho\Projetos\Projeto Matrip\Matrip\Matrip.Web\Areas\Guide\Views\_ViewImports.cshtml"
using Matrip.Domain.Models.TripModel;

#line default
#line hidden
#line 13 "C:\Users\Cliente\OneDrive\Área de Trabalho\Projetos\Projeto Matrip\Matrip\Matrip.Web\Areas\Guide\Views\_ViewImports.cshtml"
using Matrip.Domain.Models.TripPurchase;

#line default
#line hidden
#line 14 "C:\Users\Cliente\OneDrive\Área de Trabalho\Projetos\Projeto Matrip\Matrip\Matrip.Web\Areas\Guide\Views\_ViewImports.cshtml"
using Matrip.Domain.Libraries.Text;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f7484337fbce31d425d4298b138d7c89874de899", @"/Areas/Guide/Views/SalesReport/SearchPartner.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1e473379225778e9bbc498bb3b5e73f55afe885e", @"/Areas/Guide/Views/_ViewImports.cshtml")]
    public class Areas_Guide_Views_SalesReport_SearchPartner : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Matrip.Domain.Models.Entities.ma04guide>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("selected", new global::Microsoft.AspNetCore.Html.HtmlString("selected"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("disabled", new global::Microsoft.AspNetCore.Html.HtmlString("disabled"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "1", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "2", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "SalesReport", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-area", "Guide", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_8 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "get", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "C:\Users\Cliente\OneDrive\Área de Trabalho\Projetos\Projeto Matrip\Matrip\Matrip.Web\Areas\Guide\Views\SalesReport\SearchPartner.cshtml"
  
    ViewData["Title"] = "SalesReport";
    Layout = "~/Areas/Administrator/Views/Shared/_Layout.cshtml";

#line default
#line hidden
            BeginContext(162, 30, true);
            WriteLiteral("\r\n\r\n\r\n    <div class=\"mt-5\">\r\n");
            EndContext();
#line 10 "C:\Users\Cliente\OneDrive\Área de Trabalho\Projetos\Projeto Matrip\Matrip\Matrip.Web\Areas\Guide\Views\SalesReport\SearchPartner.cshtml"
           await Html.RenderPartialAsync("~/Views/Shared/_Message.cshtml"); 

#line default
#line hidden
            BeginContext(271, 109, true);
            WriteLiteral("        <h6>Busque o Relatório de Vendas de Sua Empresa</h6>\r\n        <div style=\"width:400px\">\r\n            ");
            EndContext();
            BeginContext(380, 1710, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f7484337fbce31d425d4298b138d7c89874de8999191", async() => {
                BeginContext(464, 95, true);
                WriteLiteral("\r\n                <select name=\"partnerID\" class=\"form-control\" required>\r\n                    ");
                EndContext();
                BeginContext(559, 83, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f7484337fbce31d425d4298b138d7c89874de8999672", async() => {
                    BeginContext(616, 17, true);
                    WriteLiteral("Escolha a Empresa");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_2.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(642, 2, true);
                WriteLiteral("\r\n");
                EndContext();
#line 16 "C:\Users\Cliente\OneDrive\Área de Trabalho\Projetos\Projeto Matrip\Matrip\Matrip.Web\Areas\Guide\Views\SalesReport\SearchPartner.cshtml"
                     foreach (ma26PartnerGuide ma26PartnerGuide in Model.ma26PartnerGuide)
                    {

#line default
#line hidden
                BeginContext(759, 24, true);
                WriteLiteral("                        ");
                EndContext();
                BeginContext(783, 97, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f7484337fbce31d425d4298b138d7c89874de89911749", async() => {
                    BeginContext(834, 37, false);
#line 18 "C:\Users\Cliente\OneDrive\Área de Trabalho\Projetos\Projeto Matrip\Matrip\Matrip.Web\Areas\Guide\Views\SalesReport\SearchPartner.cshtml"
                                                                     Write(ma26PartnerGuide.ma25partner.ma25name);

#line default
#line hidden
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                BeginWriteTagHelperAttribute();
#line 18 "C:\Users\Cliente\OneDrive\Área de Trabalho\Projetos\Projeto Matrip\Matrip\Matrip.Web\Areas\Guide\Views\SalesReport\SearchPartner.cshtml"
                           WriteLiteral(ma26PartnerGuide.FK2625idPartner);

#line default
#line hidden
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = __tagHelperStringValueBuffer;
                __tagHelperExecutionContext.AddTagHelperAttribute("value", __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(880, 2, true);
                WriteLiteral("\r\n");
                EndContext();
#line 19 "C:\Users\Cliente\OneDrive\Área de Trabalho\Projetos\Projeto Matrip\Matrip\Matrip.Web\Areas\Guide\Views\SalesReport\SearchPartner.cshtml"
                    }

#line default
#line hidden
                BeginContext(905, 226, true);
                WriteLiteral("                </select>\r\n\r\n                <div class=\"mt-3\">\r\n                    <label>Filtrar por tipo de data</label>\r\n                    <select name=\"DateType\" class=\"form-control\" required>\r\n                        ");
                EndContext();
                BeginContext(1131, 78, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f7484337fbce31d425d4298b138d7c89874de89914525", async() => {
                    BeginContext(1188, 12, true);
                    WriteLiteral("Tipo de Data");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_2.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(1209, 26, true);
                WriteLiteral("\r\n                        ");
                EndContext();
                BeginContext(1235, 45, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f7484337fbce31d425d4298b138d7c89874de89916196", async() => {
                    BeginContext(1253, 18, true);
                    WriteLiteral("Por data da compra");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_3.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(1280, 26, true);
                WriteLiteral("\r\n                        ");
                EndContext();
                BeginContext(1306, 46, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f7484337fbce31d425d4298b138d7c89874de89917699", async() => {
                    BeginContext(1324, 19, true);
                    WriteLiteral("Por data do passeio");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_4.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(1352, 731, true);
                WriteLiteral(@"
                    </select>
                </div>

                <div class=""row mt-3"">
                    <div class=""col-6"">
                        <label>Data de início</label>
                        <input type=""date"" name=""initialDate"" class=""form-control"" required />
                    </div>
                    <div class=""col-6"">
                        <label>Até a data:</label>
                        <input type=""date"" name=""finalDate"" class=""form-control"" required />
                    </div>
                </div>
                <div class=""mt-3"">
                    <button class=""btn btn-outline-primary btn-lg"" type=""submit"">Pesquisar</button>
                </div>
            ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_6.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Area = (string)__tagHelperAttribute_7.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_7);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_8.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_8);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2090, 42, true);
            WriteLiteral("\r\n        </div>\r\n        \r\n    </div>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Matrip.Domain.Models.Entities.ma04guide> Html { get; private set; }
    }
}
#pragma warning restore 1591
