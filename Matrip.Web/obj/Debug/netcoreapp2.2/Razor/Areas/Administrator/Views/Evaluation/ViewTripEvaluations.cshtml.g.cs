#pragma checksum "C:\Users\Cliente\OneDrive\Área de Trabalho\Projetos\Projeto Matrip\Matrip\Matrip.Web\Areas\Administrator\Views\Evaluation\ViewTripEvaluations.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2fcb0b5b33d7dc41bdcf0b8286bb2e3e8a5eff1c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Administrator_Views_Evaluation_ViewTripEvaluations), @"mvc.1.0.view", @"/Areas/Administrator/Views/Evaluation/ViewTripEvaluations.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Areas/Administrator/Views/Evaluation/ViewTripEvaluations.cshtml", typeof(AspNetCore.Areas_Administrator_Views_Evaluation_ViewTripEvaluations))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2fcb0b5b33d7dc41bdcf0b8286bb2e3e8a5eff1c", @"/Areas/Administrator/Views/Evaluation/ViewTripEvaluations.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1e473379225778e9bbc498bb3b5e73f55afe885e", @"/Areas/Administrator/Views/_ViewImports.cshtml")]
    public class Areas_Administrator_Views_Evaluation_ViewTripEvaluations : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ma05trip>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "C:\Users\Cliente\OneDrive\Área de Trabalho\Projetos\Projeto Matrip\Matrip\Matrip.Web\Areas\Administrator\Views\Evaluation\ViewTripEvaluations.cshtml"
  
    ViewData["Title"] = "ViewTripEvaluations";
    Layout = "~/Areas/Administrator/Views/Shared/_Layout.cshtml";

#line default
#line hidden
            BeginContext(139, 26, true);
            WriteLiteral("\r\n    <div class=\"mt-5\">\r\n");
            EndContext();
#line 8 "C:\Users\Cliente\OneDrive\Área de Trabalho\Projetos\Projeto Matrip\Matrip\Matrip.Web\Areas\Administrator\Views\Evaluation\ViewTripEvaluations.cshtml"
           await Html.RenderPartialAsync("~/Views/Shared/_Message.cshtml"); 

#line default
#line hidden
            BeginContext(244, 116, true);
            WriteLiteral("        \r\n        <div class=\"row\">\r\n            <div class=\"col-md-12\">\r\n                <h1>Avaliações do Passeio ");
            EndContext();
            BeginContext(361, 14, false);
#line 12 "C:\Users\Cliente\OneDrive\Área de Trabalho\Projetos\Projeto Matrip\Matrip\Matrip.Web\Areas\Administrator\Views\Evaluation\ViewTripEvaluations.cshtml"
                                     Write(Model.ma05name);

#line default
#line hidden
            EndContext();
            BeginContext(375, 369, true);
            WriteLiteral(@"</h1>
                <table class=""table table-bordered"">
                    <tr>
                        <td><strong>Nome do Turista</strong></td>
                        <td><strong>Avaliação do Turista</strong></td>
                        <td><strong>Status</strong></td>
                        <td><strong>Foto</strong></td>

                    </tr>
");
            EndContext();
#line 21 "C:\Users\Cliente\OneDrive\Área de Trabalho\Projetos\Projeto Matrip\Matrip\Matrip.Web\Areas\Administrator\Views\Evaluation\ViewTripEvaluations.cshtml"
                     for (int i = 0; i < Model.ma39tripEvaluation.ToList().Count(); i++)
                    {

#line default
#line hidden
            BeginContext(857, 62, true);
            WriteLiteral("                        <tr>\r\n                            <td>");
            EndContext();
            BeginContext(920, 49, false);
#line 24 "C:\Users\Cliente\OneDrive\Área de Trabalho\Projetos\Projeto Matrip\Matrip\Matrip.Web\Areas\Administrator\Views\Evaluation\ViewTripEvaluations.cshtml"
                           Write(Model.ma39tripEvaluation.ToList()[i].ma39UserName);

#line default
#line hidden
            EndContext();
            BeginContext(969, 39, true);
            WriteLiteral("</td>\r\n                            <td>");
            EndContext();
            BeginContext(1009, 49, false);
#line 25 "C:\Users\Cliente\OneDrive\Área de Trabalho\Projetos\Projeto Matrip\Matrip\Matrip.Web\Areas\Administrator\Views\Evaluation\ViewTripEvaluations.cshtml"
                           Write(Model.ma39tripEvaluation.ToList()[i].ma39Feedback);

#line default
#line hidden
            EndContext();
            BeginContext(1058, 41, true);
            WriteLiteral("</td>\r\n                            <td>\r\n");
            EndContext();
#line 27 "C:\Users\Cliente\OneDrive\Área de Trabalho\Projetos\Projeto Matrip\Matrip\Matrip.Web\Areas\Administrator\Views\Evaluation\ViewTripEvaluations.cshtml"
                                 if (Model.ma39tripEvaluation.ToList()[i].ma39FeedbackAproved == "0")
                                {

#line default
#line hidden
            BeginContext(1237, 38, true);
            WriteLiteral("                                    <a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 1275, "\"", 1656, 1);
#line 29 "C:\Users\Cliente\OneDrive\Área de Trabalho\Projetos\Projeto Matrip\Matrip\Matrip.Web\Areas\Administrator\Views\Evaluation\ViewTripEvaluations.cshtml"
WriteAttributeValue("", 1282, Url.Action("ApproveEvaluation","Evaluation",
                                                new { Area = "Administrator",
                                                TripName = Model.ma05name,
                                                EvaluationID = Model.ma39tripEvaluation.ToList()[i].ma39idTripEvaluation
                                                }), 1282, 374, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1657, 14, true);
            WriteLiteral(">Aprovar</a>\r\n");
            EndContext();
#line 34 "C:\Users\Cliente\OneDrive\Área de Trabalho\Projetos\Projeto Matrip\Matrip\Matrip.Web\Areas\Administrator\Views\Evaluation\ViewTripEvaluations.cshtml"
                                }
                                else
                                {

#line default
#line hidden
            BeginContext(1779, 91, true);
            WriteLiteral("                                    <p>Aprovado</p>\r\n                                    <a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 1870, "\"", 2254, 1);
#line 38 "C:\Users\Cliente\OneDrive\Área de Trabalho\Projetos\Projeto Matrip\Matrip\Matrip.Web\Areas\Administrator\Views\Evaluation\ViewTripEvaluations.cshtml"
WriteAttributeValue("", 1877, Url.Action("DisapproveEvaluation","Evaluation",
                                                new { Area = "Administrator",
                                                TripName = Model.ma05name,
                                                EvaluationID = Model.ma39tripEvaluation.ToList()[i].ma39idTripEvaluation
                                                }), 1877, 377, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(2255, 25, true);
            WriteLiteral(">Cancelar Aprovação</a>\r\n");
            EndContext();
#line 43 "C:\Users\Cliente\OneDrive\Área de Trabalho\Projetos\Projeto Matrip\Matrip\Matrip.Web\Areas\Administrator\Views\Evaluation\ViewTripEvaluations.cshtml"
                                }

#line default
#line hidden
            BeginContext(2315, 99, true);
            WriteLiteral("                            </td>\r\n                            \r\n                            <td>\r\n");
            EndContext();
#line 47 "C:\Users\Cliente\OneDrive\Área de Trabalho\Projetos\Projeto Matrip\Matrip\Matrip.Web\Areas\Administrator\Views\Evaluation\ViewTripEvaluations.cshtml"
                                 if (Model.ma39tripEvaluation.ToList()[i].ma39photoQuantity > 0)
                                {

#line default
#line hidden
            BeginContext(2547, 52, true);
            WriteLiteral("                                    <img width=\"400\"");
            EndContext();
            BeginWriteAttribute("src", " src=\"", 2599, "\"", 2707, 1);
#line 49 "C:\Users\Cliente\OneDrive\Área de Trabalho\Projetos\Projeto Matrip\Matrip\Matrip.Web\Areas\Administrator\Views\Evaluation\ViewTripEvaluations.cshtml"
WriteAttributeValue("", 2605, Url.Content("~/images/evaluationPhotos/"+ Model.ma39tripEvaluation.ToList()[i].ma39photoPath +".jpg"), 2605, 102, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(2708, 5, true);
            WriteLiteral(" />\r\n");
            EndContext();
#line 50 "C:\Users\Cliente\OneDrive\Área de Trabalho\Projetos\Projeto Matrip\Matrip\Matrip.Web\Areas\Administrator\Views\Evaluation\ViewTripEvaluations.cshtml"
                                }

#line default
#line hidden
            BeginContext(2748, 68, true);
            WriteLiteral("\r\n                            </td>\r\n                        </tr>\r\n");
            EndContext();
#line 54 "C:\Users\Cliente\OneDrive\Área de Trabalho\Projetos\Projeto Matrip\Matrip\Matrip.Web\Areas\Administrator\Views\Evaluation\ViewTripEvaluations.cshtml"
                    }

#line default
#line hidden
            BeginContext(2839, 102, true);
            WriteLiteral("\r\n\r\n\r\n                </table>\r\n\r\n\r\n\r\n            </div>\r\n\r\n        </div>\r\n        \r\n\r\n\r\n\r\n    </div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ma05trip> Html { get; private set; }
    }
}
#pragma warning restore 1591
