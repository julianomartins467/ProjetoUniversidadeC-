#pragma checksum "C:\Users\Openk\Desktop\juliano\Projetos Falhados\treinamento-painel-universidade-Juliano\Universidade\Views\Disciplinas\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6f72ff18dbf2d30b0e0a64d75bc854a90a2a7d04"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Disciplinas_Index), @"mvc.1.0.view", @"/Views/Disciplinas/Index.cshtml")]
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
#line 1 "C:\Users\Openk\Desktop\juliano\Projetos Falhados\treinamento-painel-universidade-Juliano\Universidade\Views\_ViewImports.cshtml"
using Universidade;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Openk\Desktop\juliano\Projetos Falhados\treinamento-painel-universidade-Juliano\Universidade\Views\_ViewImports.cshtml"
using Universidade.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6f72ff18dbf2d30b0e0a64d75bc854a90a2a7d04", @"/Views/Disciplinas/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9d44bdceea62c20bcd4a93b42ab77acc060d0b03", @"/Views/_ViewImports.cshtml")]
    public class Views_Disciplinas_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Universidade.Models.DisciplinaModel>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Disciplinas", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Inserir", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-primary"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Atualizar_get", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", new global::Microsoft.AspNetCore.Html.HtmlString("button"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Deletar", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-danger btn_deletar"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\Openk\Desktop\juliano\Projetos Falhados\treinamento-painel-universidade-Juliano\Universidade\Views\Disciplinas\Index.cshtml"
  
    ViewData["Title"] = "Disciplinas";

#line default
#line hidden
#nullable disable
            WriteLiteral("\n\n\n<div class=\"text-center\">\n    <h1 class=\"display-4\"><strong>Disciplina Cadastradas</strong></h1>\n</div>\n<p><p></p></p><p></p><br/>\n<div class=\"btn-inicio-main\">\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6f72ff18dbf2d30b0e0a64d75bc854a90a2a7d045995", async() => {
                WriteLiteral("Nova Disciplina");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n</div>\n<p><p></p></p><p></p><br/>\n\n<div>\n  <table class=\"table\" id=\"tabela\">\n    <thead>\n      <tr>\n        <th scope=\"col\">Nome</th>\n        <th scope=\"col\">Carga Horaria</th>\n      </tr>\n    </thead>\n      <tbody>\n");
#nullable restore
#line 26 "C:\Users\Openk\Desktop\juliano\Projetos Falhados\treinamento-painel-universidade-Juliano\Universidade\Views\Disciplinas\Index.cshtml"
         foreach(var item in Model)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("          <tr>\n              <td>");
#nullable restore
#line 29 "C:\Users\Openk\Desktop\juliano\Projetos Falhados\treinamento-painel-universidade-Juliano\Universidade\Views\Disciplinas\Index.cshtml"
             Write(item.nome);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n              <td>");
#nullable restore
#line 30 "C:\Users\Openk\Desktop\juliano\Projetos Falhados\treinamento-painel-universidade-Juliano\Universidade\Views\Disciplinas\Index.cshtml"
             Write(item.carga_horaria);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n              <td>\n                  <div class=\"btn-group\" role=\"group\">  \n                      ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6f72ff18dbf2d30b0e0a64d75bc854a90a2a7d048706", async() => {
                WriteLiteral("Editar");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 33 "C:\Users\Openk\Desktop\juliano\Projetos Falhados\treinamento-painel-universidade-Juliano\Universidade\Views\Disciplinas\Index.cshtml"
                                                                                   WriteLiteral(item.id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n                      ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6f72ff18dbf2d30b0e0a64d75bc854a90a2a7d0411261", async() => {
                WriteLiteral("Apagar");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            BeginWriteTagHelperAttribute();
#nullable restore
#line 34 "C:\Users\Openk\Desktop\juliano\Projetos Falhados\treinamento-painel-universidade-Juliano\Universidade\Views\Disciplinas\Index.cshtml"
                                Write(item.id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __tagHelperExecutionContext.AddHtmlAttribute("data-value", Html.Raw(__tagHelperStringValueBuffer), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 34 "C:\Users\Openk\Desktop\juliano\Projetos Falhados\treinamento-painel-universidade-Juliano\Universidade\Views\Disciplinas\Index.cshtml"
                                                                                                                 WriteLiteral(item.id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n                  </div>  \n              </td>\n            </tr>\n");
#nullable restore
#line 38 "C:\Users\Openk\Desktop\juliano\Projetos Falhados\treinamento-painel-universidade-Juliano\Universidade\Views\Disciplinas\Index.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("      </tbody>\n  </table>\n</div>\n\n<script>\n  $(document).ready(function () {\n    \n    var url = \"");
#nullable restore
#line 46 "C:\Users\Openk\Desktop\juliano\Projetos Falhados\treinamento-painel-universidade-Juliano\Universidade\Views\Disciplinas\Index.cshtml"
          Write(Url.Action("ValidaExclusao", "Disciplinas"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@""";
    $(document).on('click', '.btn_deletar', ExecutaProximoPasso);
    
    function ExecutaProximoPasso() {
      event.preventDefault();
      var id_disciplina = $(this).attr(""data-value"");
      
      $.ajax(url, {
        method: 'Get',
        data: {id:id_disciplina},
      }).done(function (response) {
        if(!response.validar_aluno){
          alert('Existem alunos vinculadao a disciplina e não será possível excluir');
        
        }else{//se aluno for valido ainda tenho que verificar se tem algum curso
          
          if(!response.validar_curso){
            if(confirm('Disciplina vinculada a um curso deseja excluir mesmo assim?')){
              deletar(id_disciplina);  
            }else{
              //escolhido cancelar na confirmação
            }
          }else{
            deletar(id_disciplina);
          }
        }
      }).fail(function () {
          console.log(""Erro"")
      });
    }   
  });

  function deletar(id_disciplina){

    var del = """);
#nullable restore
#line 80 "C:\Users\Openk\Desktop\juliano\Projetos Falhados\treinamento-painel-universidade-Juliano\Universidade\Views\Disciplinas\Index.cshtml"
          Write(Url.Action("Deletar", "Disciplinas"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"""
    $.ajax(del, {
    method: 'Get',
    data: {id:id_disciplina},
    }).done(function(valido){
      if(valido.valido){
        alert('Disciplina deletada com sucesso')
        location.reload()
      }else{
        alert('Não foi possivel deletar a Disciplina')
      }
    }).fail(function(){
      console.log(""Erro"")
    });
    
  }
  
</script>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Universidade.Models.DisciplinaModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591