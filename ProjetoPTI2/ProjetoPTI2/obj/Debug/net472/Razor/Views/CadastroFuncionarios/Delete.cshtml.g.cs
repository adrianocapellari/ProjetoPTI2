#pragma checksum "C:\Users\mathe\Desktop\ProjetoPTI2\ProjetoPTI2\ProjetoPTI2\Views\CadastroFuncionarios\Delete.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b3435ad5214c487ad038b484847064c7143624d6"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_CadastroFuncionarios_Delete), @"mvc.1.0.view", @"/Views/CadastroFuncionarios/Delete.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/CadastroFuncionarios/Delete.cshtml", typeof(AspNetCore.Views_CadastroFuncionarios_Delete))]
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
#line 1 "C:\Users\mathe\Desktop\ProjetoPTI2\ProjetoPTI2\ProjetoPTI2\Views\_ViewImports.cshtml"
using ProjetoPTI2;

#line default
#line hidden
#line 2 "C:\Users\mathe\Desktop\ProjetoPTI2\ProjetoPTI2\ProjetoPTI2\Views\_ViewImports.cshtml"
using ProjetoPTI2.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b3435ad5214c487ad038b484847064c7143624d6", @"/Views/CadastroFuncionarios/Delete.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9b6cf2c9110cddeeb69c0f00b6e2c39640cc5543", @"/Views/_ViewImports.cshtml")]
    public class Views_CadastroFuncionarios_Delete : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ProjetoPTI2.Models.CadastroFuncionario>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", "hidden", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(47, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\mathe\Desktop\ProjetoPTI2\ProjetoPTI2\ProjetoPTI2\Views\CadastroFuncionarios\Delete.cshtml"
  
    ViewData["Title"] = "Delete";

#line default
#line hidden
            BeginContext(91, 162, true);
            WriteLiteral("\r\n<h2>Deletar um funcionário</h2>\r\n\r\n<h3>Você tem certeza que deseja <span>deletar</span> o funcionário selecionado? </h3>\r\n\r\n<div>\r\n    <h4>Informações de <span>");
            EndContext();
            BeginContext(254, 36, false);
#line 12 "C:\Users\mathe\Desktop\ProjetoPTI2\ProjetoPTI2\ProjetoPTI2\Views\CadastroFuncionarios\Delete.cshtml"
                        Write(Html.DisplayFor(model => model.Nome));

#line default
#line hidden
            EndContext();
            BeginContext(290, 85, true);
            WriteLiteral("</span> </h4>\r\n    <hr />\r\n    <dl class=\"dl-horizontal\">\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(376, 40, false);
#line 16 "C:\Users\mathe\Desktop\ProjetoPTI2\ProjetoPTI2\ProjetoPTI2\Views\CadastroFuncionarios\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Nome));

#line default
#line hidden
            EndContext();
            BeginContext(416, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(460, 36, false);
#line 19 "C:\Users\mathe\Desktop\ProjetoPTI2\ProjetoPTI2\ProjetoPTI2\Views\CadastroFuncionarios\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Nome));

#line default
#line hidden
            EndContext();
            BeginContext(496, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(540, 39, false);
#line 22 "C:\Users\mathe\Desktop\ProjetoPTI2\ProjetoPTI2\ProjetoPTI2\Views\CadastroFuncionarios\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Cpf));

#line default
#line hidden
            EndContext();
            BeginContext(579, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(623, 35, false);
#line 25 "C:\Users\mathe\Desktop\ProjetoPTI2\ProjetoPTI2\ProjetoPTI2\Views\CadastroFuncionarios\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Cpf));

#line default
#line hidden
            EndContext();
            BeginContext(658, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(702, 45, false);
#line 28 "C:\Users\mathe\Desktop\ProjetoPTI2\ProjetoPTI2\ProjetoPTI2\Views\CadastroFuncionarios\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Matricula));

#line default
#line hidden
            EndContext();
            BeginContext(747, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(791, 41, false);
#line 31 "C:\Users\mathe\Desktop\ProjetoPTI2\ProjetoPTI2\ProjetoPTI2\Views\CadastroFuncionarios\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Matricula));

#line default
#line hidden
            EndContext();
            BeginContext(832, 45, true);
            WriteLiteral("\r\n        </dd>\r\n\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(878, 50, false);
#line 35 "C:\Users\mathe\Desktop\ProjetoPTI2\ProjetoPTI2\ProjetoPTI2\Views\CadastroFuncionarios\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Dt_Contratacao));

#line default
#line hidden
            EndContext();
            BeginContext(928, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(972, 46, false);
#line 38 "C:\Users\mathe\Desktop\ProjetoPTI2\ProjetoPTI2\ProjetoPTI2\Views\CadastroFuncionarios\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Dt_Contratacao));

#line default
#line hidden
            EndContext();
            BeginContext(1018, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(1062, 41, false);
#line 41 "C:\Users\mathe\Desktop\ProjetoPTI2\ProjetoPTI2\ProjetoPTI2\Views\CadastroFuncionarios\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Email));

#line default
#line hidden
            EndContext();
            BeginContext(1103, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1147, 37, false);
#line 44 "C:\Users\mathe\Desktop\ProjetoPTI2\ProjetoPTI2\ProjetoPTI2\Views\CadastroFuncionarios\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Email));

#line default
#line hidden
            EndContext();
            BeginContext(1184, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(1228, 45, false);
#line 47 "C:\Users\mathe\Desktop\ProjetoPTI2\ProjetoPTI2\ProjetoPTI2\Views\CadastroFuncionarios\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.TipoLogin));

#line default
#line hidden
            EndContext();
            BeginContext(1273, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1317, 41, false);
#line 50 "C:\Users\mathe\Desktop\ProjetoPTI2\ProjetoPTI2\ProjetoPTI2\Views\CadastroFuncionarios\Delete.cshtml"
       Write(Html.DisplayFor(model => model.TipoLogin));

#line default
#line hidden
            EndContext();
            BeginContext(1358, 38, true);
            WriteLiteral("\r\n        </dd>\r\n    </dl>\r\n    \r\n    ");
            EndContext();
            BeginContext(1396, 215, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b3435ad5214c487ad038b484847064c7143624d610707", async() => {
                BeginContext(1422, 10, true);
                WriteLiteral("\r\n        ");
                EndContext();
                BeginContext(1432, 36, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "b3435ad5214c487ad038b484847064c7143624d611100", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
#line 55 "C:\Users\mathe\Desktop\ProjetoPTI2\ProjetoPTI2\ProjetoPTI2\Views\CadastroFuncionarios\Delete.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.Id);

#line default
#line hidden
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(1468, 85, true);
                WriteLiteral("\r\n        <input type=\"submit\" value=\"Deletar\" class=\"btn btn-default\" /> |\r\n        ");
                EndContext();
                BeginContext(1553, 45, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b3435ad5214c487ad038b484847064c7143624d613028", async() => {
                    BeginContext(1575, 19, true);
                    WriteLiteral("Voltar para a lista");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(1598, 6, true);
                WriteLiteral("\r\n    ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1611, 10, true);
            WriteLiteral("\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ProjetoPTI2.Models.CadastroFuncionario> Html { get; private set; }
    }
}
#pragma warning restore 1591
