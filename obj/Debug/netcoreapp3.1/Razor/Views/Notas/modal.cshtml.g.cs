#pragma checksum "/home/openk/Documentos/Universidade/Views/Notas/modal.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1a153e3f6a27fca85d6dc37c2d961d4d9c11e7ee"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Notas_modal), @"mvc.1.0.view", @"/Views/Notas/modal.cshtml")]
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
#line 1 "/home/openk/Documentos/Universidade/Views/_ViewImports.cshtml"
using Universidade;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/home/openk/Documentos/Universidade/Views/_ViewImports.cshtml"
using Universidade.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1a153e3f6a27fca85d6dc37c2d961d4d9c11e7ee", @"/Views/Notas/modal.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9d44bdceea62c20bcd4a93b42ab77acc060d0b03", @"/Views/_ViewImports.cshtml")]
    public class Views_Notas_modal : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Universidade.Models.LancarNota>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\n<!-- Modal -->\n\n<table class=\"table\">   \n    <thead>\n    <tr>\n        <th scope=\"col\">Nome Aluno</th>\n        <th scope=\"col\">Nota</th>\n    </tr>\n    </thead>\n    <tbody>\n");
#nullable restore
#line 13 "/home/openk/Documentos/Universidade/Views/Notas/modal.cshtml"
     foreach(var item in Model)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr class = \"linhamodal\">\n        \n        <td>");
#nullable restore
#line 17 "/home/openk/Documentos/Universidade/Views/Notas/modal.cshtml"
       Write(item.nome_aluno);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n        <td>\n            <input class=\"inputnota\" data-matricula_id=\"");
#nullable restore
#line 19 "/home/openk/Documentos/Universidade/Views/Notas/modal.cshtml"
                                                   Write(item.matricula_id);

#line default
#line hidden
#nullable disable
            WriteLiteral("\" data-aluno_id=\"");
#nullable restore
#line 19 "/home/openk/Documentos/Universidade/Views/Notas/modal.cshtml"
                                                                                      Write(item.aluno_id);

#line default
#line hidden
#nullable disable
            WriteLiteral("\"");
            BeginWriteAttribute("value", " value=\"", 450, "\"", 468, 1);
#nullable restore
#line 19 "/home/openk/Documentos/Universidade/Views/Notas/modal.cshtml"
WriteAttributeValue("", 458, item.nota, 458, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\n        </td>\n        \n        </tr>\n");
#nullable restore
#line 23 "/home/openk/Documentos/Universidade/Views/Notas/modal.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("    <br>\n    \n    <br>\n    </tbody>\n</table>\n<button id=\"_salvar\" class=\"btn btn-outline-success\">Salvar</button>\n        \n<script>\n  $(document).on(\'click\', \'#_salvar\', salvar)\n\n  function salvar(){\n    var url = \"");
#nullable restore
#line 35 "/home/openk/Documentos/Universidade/Views/Notas/modal.cshtml"
          Write(Url.Action("Salvar", "Notas"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\";      \n  \n    var id_disciplina = ");
#nullable restore
#line 37 "/home/openk/Documentos/Universidade/Views/Notas/modal.cshtml"
                   Write(Model.First().disciplina_id);

#line default
#line hidden
#nullable disable
            WriteLiteral(";  \n    var id_curso = ");
#nullable restore
#line 38 "/home/openk/Documentos/Universidade/Views/Notas/modal.cshtml"
              Write(Model.First().curso_id);

#line default
#line hidden
#nullable disable
            WriteLiteral(@";
        
    notas = new Array();  
    $("".inputnota"").each(function(index, obj){
      if($(this).val()!='' && $(this).not(""[value]"")){
      notalist = {} 
      notalist['aluno_id'] =  parseFloat($(this).attr('data-aluno_id'));
      notalist['matricula_id'] =  parseFloat($(this).attr('data-matricula_id'));
      notalist['nota'] =  parseFloat($(this).val());
      
      notas.push(notalist);
      }    
    });       
   
    $.ajax(url, {
      method: 'POST',
      contentType: 'application/json',
      data: JSON.stringify({
          ""curso_id"":id_curso,
          ""disciplina_id"":id_disciplina,          
          ""notas"":notas
      }),
    }).done(function (response) {
      if(response){
        alert(""Notas salvas com sucesso!"")
        location.reload()
      }else{
        alert(""Não foi possivel salvar!"")
      }
    }).fail(function () {
        swal('Atenção', 'Ocorreu um erro!', 'error');
    });

  }


  $("".inputnota"").keypress(function (evt){
    var theEvent = evt || window.event;
  ");
            WriteLiteral(@"  var key = theEvent.keyCode || theEvent.which;
    key = String.fromCharCode( key );
    var regex = /[-\d\.\,]/; // dowolna liczba (+- ,.) :)
    var objRegex = /^-?\d*[\.\,]?\d*$/;
    var val = $(evt.target).val();
    if(!regex.test(key) || !objRegex.test(val+key) || 
            !theEvent.keyCode == 46 || !theEvent.keyCode == 8) {
        theEvent.returnValue = false;
        if(theEvent.preventDefault) theEvent.preventDefault();
    };
}); 
</script>
");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Universidade.Models.LancarNota>> Html { get; private set; }
    }
}
#pragma warning restore 1591
