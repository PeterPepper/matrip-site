#pragma checksum "C:\Users\Cliente\OneDrive\Área de Trabalho\Projetos\Projeto Matrip\Matrip\Matrip.Web\Areas\Administrator\Views\AdminSalesReport\AdminSearchPartner.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "bd24b409901b1e0e78ebfa7a64ba505686b4e98a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Administrator_Views_AdminSalesReport_AdminSearchPartner), @"mvc.1.0.view", @"/Areas/Administrator/Views/AdminSalesReport/AdminSearchPartner.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Areas/Administrator/Views/AdminSalesReport/AdminSearchPartner.cshtml", typeof(AspNetCore.Areas_Administrator_Views_AdminSalesReport_AdminSearchPartner))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"bd24b409901b1e0e78ebfa7a64ba505686b4e98a", @"/Areas/Administrator/Views/AdminSalesReport/AdminSearchPartner.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1e473379225778e9bbc498bb3b5e73f55afe885e", @"/Areas/Administrator/Views/_ViewImports.cshtml")]
    public class Areas_Administrator_Views_AdminSalesReport_AdminSearchPartner : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/Requests/AjaxRequest.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", new global::Microsoft.AspNetCore.Html.HtmlString("text/javascript"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("selected", new global::Microsoft.AspNetCore.Html.HtmlString("selected"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("disabled", new global::Microsoft.AspNetCore.Html.HtmlString("disabled"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "1", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "2", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_8 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "AdminSalesReport", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_9 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-area", "Administrator", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_10 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "get", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 2 "C:\Users\Cliente\OneDrive\Área de Trabalho\Projetos\Projeto Matrip\Matrip\Matrip.Web\Areas\Administrator\Views\AdminSalesReport\AdminSearchPartner.cshtml"
  
    ViewData["Title"] = "SearchPartner";
    Layout = "~/Areas/Administrator/Views/Shared/_Layout.cshtml";

#line default
#line hidden
            DefineSection("script", async() => {
                BeginContext(134, 6, true);
                WriteLiteral("\r\n    ");
                EndContext();
                BeginContext(140, 75, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "bd24b409901b1e0e78ebfa7a64ba505686b4e98a9956", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(215, 223, true);
                WriteLiteral("\r\n    <script type=\"text/javascript\">\r\n        function AutoComplete() {\r\n            var PartnerName = document.getElementById(\"PartnerName\").value;\r\n\r\n            if (PartnerName.length > 2) {\r\n                var url = \"");
                EndContext();
                BeginContext(439, 89, false);
#line 13 "C:\Users\Cliente\OneDrive\Área de Trabalho\Projetos\Projeto Matrip\Matrip\Matrip.Web\Areas\Administrator\Views\AdminSalesReport\AdminSearchPartner.cshtml"
                      Write(Html.Raw(Url.Action("SearchPartners", "Search", new { PartnerText = "__PartnerText__" })));

#line default
#line hidden
                EndContext();
                BeginContext(528, 174, true);
                WriteLiteral("\";\r\n                url = url.replace(\"__PartnerText__\", PartnerName);\r\n                RequestAutocomplete(url, \"#PartnerName\");\r\n            }\r\n\r\n        }\r\n    </script>\r\n");
                EndContext();
            }
            );
            BeginContext(705, 20, true);
            WriteLiteral("<div class=\"mt-5\">\r\n");
            EndContext();
#line 22 "C:\Users\Cliente\OneDrive\Área de Trabalho\Projetos\Projeto Matrip\Matrip\Matrip.Web\Areas\Administrator\Views\AdminSalesReport\AdminSearchPartner.cshtml"
       await Html.RenderPartialAsync("~/Views/Shared/_Message.cshtml"); 

#line default
#line hidden
            BeginContext(800, 97, true);
            WriteLiteral("    <h6>Busque o Relatório de Vendas de Uma Empresa</h6>\r\n    <div style=\"width:400px\">\r\n        ");
            EndContext();
            BeginContext(897, 1396, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "bd24b409901b1e0e78ebfa7a64ba505686b4e98a12855", async() => {
                BeginContext(994, 358, true);
                WriteLiteral(@"
            <input id=""PartnerName"" class=""form-control"" name=""PartnerName"" type=""text"" placeholder=""Nome da empresa (Opcional)"" onkeydown=""AutoComplete();"" />
            
            <div class=""mt-3"">
                <label>Filtrar por tipo de data</label>
                <select name=""DateType"" class=""form-control"" required>
                    ");
                EndContext();
                BeginContext(1352, 78, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "bd24b409901b1e0e78ebfa7a64ba505686b4e98a13613", async() => {
                    BeginContext(1409, 12, true);
                    WriteLiteral("Tipo de Data");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
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
                BeginContext(1430, 22, true);
                WriteLiteral("\r\n                    ");
                EndContext();
                BeginContext(1452, 45, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "bd24b409901b1e0e78ebfa7a64ba505686b4e98a15280", async() => {
                    BeginContext(1470, 18, true);
                    WriteLiteral("Por data da compra");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_5.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(1497, 22, true);
                WriteLiteral("\r\n                    ");
                EndContext();
                BeginContext(1519, 46, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "bd24b409901b1e0e78ebfa7a64ba505686b4e98a16779", async() => {
                    BeginContext(1537, 19, true);
                    WriteLiteral("Por data do passeio");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_6.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(1565, 721, true);
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
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_7.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_7);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_8.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_8);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Area = (string)__tagHelperAttribute_9.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_9);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_10.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_10);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2293, 26, true);
            WriteLiteral("\r\n    </div>\r\n    \r\n</div>");
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