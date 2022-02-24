#pragma checksum "C:\Users\igors\Desktop\Curso\Projetos\EstoqueWeb\Views\Pedido\Entregar.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "634d66494fb49f881d9a720515f66b97a0bcf65f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(EstoqueWeb.Models.Pedido.Views_Pedido_Entregar), @"mvc.1.0.view", @"/Views/Pedido/Entregar.cshtml")]
namespace EstoqueWeb.Models.Pedido
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"634d66494fb49f881d9a720515f66b97a0bcf65f", @"/Views/Pedido/Entregar.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b649f5b9ff7f3e7b71aa36f24da6ee2387e4b1e6", @"/Views/_ViewImports.cshtml")]
    public class Views_Pedido_Entregar : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<PedidoModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", "hidden", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-secondary"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Entregar", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#nullable restore
#line 2 "C:\Users\igors\Desktop\Curso\Projetos\EstoqueWeb\Views\Pedido\Entregar.cshtml"
  
    ViewBag.Subtitulo = $"Registro de Entrega do Pedido <b>{Model.IdPedido:D4}</b>";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1 class=\"text-primary\">");
#nullable restore
#line 6 "C:\Users\igors\Desktop\Curso\Projetos\EstoqueWeb\Views\Pedido\Entregar.cshtml"
                    Write(Html.Raw(ViewBag.Subtitulo));

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\r\n<hr>\r\n<h6>Cliente: <b class=\"text-dark\">");
#nullable restore
#line 8 "C:\Users\igors\Desktop\Curso\Projetos\EstoqueWeb\Views\Pedido\Entregar.cshtml"
                             Write(Model.Cliente.Nome);

#line default
#line hidden
#nullable disable
            WriteLiteral("</b></h6>\r\n<hr>\r\n");
#nullable restore
#line 10 "C:\Users\igors\Desktop\Curso\Projetos\EstoqueWeb\Views\Pedido\Entregar.cshtml"
 if (Model.ItensPedido.Count > 0)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <h6><b>Itens do pedido:</b></h6>\r\n    <hr>\r\n");
#nullable restore
#line 14 "C:\Users\igors\Desktop\Curso\Projetos\EstoqueWeb\Views\Pedido\Entregar.cshtml"
     foreach (var item in Model.ItensPedido)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <h6>");
#nullable restore
#line 16 "C:\Users\igors\Desktop\Curso\Projetos\EstoqueWeb\Views\Pedido\Entregar.cshtml"
       Write(item.Produto.Nome);

#line default
#line hidden
#nullable disable
            WriteLiteral(" (");
#nullable restore
#line 16 "C:\Users\igors\Desktop\Curso\Projetos\EstoqueWeb\Views\Pedido\Entregar.cshtml"
                           Write(item.Quantidade);

#line default
#line hidden
#nullable disable
            WriteLiteral(" x ");
#nullable restore
#line 16 "C:\Users\igors\Desktop\Curso\Projetos\EstoqueWeb\Views\Pedido\Entregar.cshtml"
                                              Write(item.ValorUnitario.ToString("C"));

#line default
#line hidden
#nullable disable
            WriteLiteral(" = ");
#nullable restore
#line 16 "C:\Users\igors\Desktop\Curso\Projetos\EstoqueWeb\Views\Pedido\Entregar.cshtml"
                                                                                  Write(item.ValorItem.ToString("C"));

#line default
#line hidden
#nullable disable
            WriteLiteral(")</h6>\r\n");
#nullable restore
#line 17 "C:\Users\igors\Desktop\Curso\Projetos\EstoqueWeb\Views\Pedido\Entregar.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("    <hr>\r\n    <h6><b>Valor Total do Pedido: ");
#nullable restore
#line 19 "C:\Users\igors\Desktop\Curso\Projetos\EstoqueWeb\Views\Pedido\Entregar.cshtml"
                             Write(Model.ValorTotal.Value.ToString("C"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</b></h6>\r\n");
#nullable restore
#line 20 "C:\Users\igors\Desktop\Curso\Projetos\EstoqueWeb\Views\Pedido\Entregar.cshtml"
}
else
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <h6><b>Não há itens no pedido.</b></h6>\r\n");
#nullable restore
#line 24 "C:\Users\igors\Desktop\Curso\Projetos\EstoqueWeb\Views\Pedido\Entregar.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 26 "C:\Users\igors\Desktop\Curso\Projetos\EstoqueWeb\Views\Pedido\Entregar.cshtml"
 if (Model.Cliente.Enderecos.Count() > 0)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <h3>Escolha o endereço de entrega:</h3>\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "634d66494fb49f881d9a720515f66b97a0bcf65f8117", async() => {
                WriteLiteral("\r\n        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "634d66494fb49f881d9a720515f66b97a0bcf65f8383", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
#nullable restore
#line 30 "C:\Users\igors\Desktop\Curso\Projetos\EstoqueWeb\Views\Pedido\Entregar.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => Model.IdPedido);

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n        <div class=\"mt-3\">\r\n");
#nullable restore
#line 32 "C:\Users\igors\Desktop\Curso\Projetos\EstoqueWeb\Views\Pedido\Entregar.cshtml"
             foreach (var endereco in Model.Cliente.Enderecos)
            {

#line default
#line hidden
#nullable disable
                WriteLiteral("                <div class=\"form-check\"> \r\n                    <input class=\"form-check-input\" type=\"radio\" name=\"IdEndereco\"");
                BeginWriteAttribute("value", " value=\"", 1089, "\"", 1117, 1);
#nullable restore
#line 35 "C:\Users\igors\Desktop\Curso\Projetos\EstoqueWeb\Views\Pedido\Entregar.cshtml"
WriteAttributeValue("", 1097, endereco.IdEndereco, 1097, 20, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                BeginWriteAttribute("checked", " \r\n                        checked=\"", 1118, "\"", 1175, 1);
#nullable restore
#line 36 "C:\Users\igors\Desktop\Curso\Projetos\EstoqueWeb\Views\Pedido\Entregar.cshtml"
WriteAttributeValue("", 1154, endereco.Selecionado, 1154, 21, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                BeginWriteAttribute("id", " id=\'", 1176, "\'", 1213, 1);
#nullable restore
#line 36 "C:\Users\igors\Desktop\Curso\Projetos\EstoqueWeb\Views\Pedido\Entregar.cshtml"
WriteAttributeValue("", 1181, $"opcao{endereco.IdEndereco}", 1181, 32, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">\r\n                        <label class=\"form-check-label\"");
                BeginWriteAttribute("for", " for=\'", 1272, "\'", 1310, 1);
#nullable restore
#line 37 "C:\Users\igors\Desktop\Curso\Projetos\EstoqueWeb\Views\Pedido\Entregar.cshtml"
WriteAttributeValue("", 1278, $"opcao{endereco.IdEndereco}", 1278, 32, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">\r\n                            ");
#nullable restore
#line 38 "C:\Users\igors\Desktop\Curso\Projetos\EstoqueWeb\Views\Pedido\Entregar.cshtml"
                       Write(endereco.EnderecoCompleto);

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                        </label>\r\n                </div>\r\n");
#nullable restore
#line 41 "C:\Users\igors\Desktop\Curso\Projetos\EstoqueWeb\Views\Pedido\Entregar.cshtml"
            }

#line default
#line hidden
#nullable disable
                WriteLiteral("            <hr>\r\n            <button class=\"btn btn-success\" type=\"submit\">Registrar Entrega</button>\r\n            ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "634d66494fb49f881d9a720515f66b97a0bcf65f12774", async() => {
                    WriteLiteral("Cancelar");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
                {
                    throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-cid", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
                }
                BeginWriteTagHelperAttribute();
#nullable restore
#line 44 "C:\Users\igors\Desktop\Curso\Projetos\EstoqueWeb\Views\Pedido\Entregar.cshtml"
                                     WriteLiteral(Model.IdCliente);

#line default
#line hidden
#nullable disable
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["cid"] = __tagHelperStringValueBuffer;
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-cid", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["cid"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("   \r\n        </div>\r\n    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
#nullable restore
#line 47 "C:\Users\igors\Desktop\Curso\Projetos\EstoqueWeb\Views\Pedido\Entregar.cshtml"
}
else 
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <h6>Este cliente ainda não possui endereço cadastrado.</h6>\r\n");
#nullable restore
#line 51 "C:\Users\igors\Desktop\Curso\Projetos\EstoqueWeb\Views\Pedido\Entregar.cshtml"
}

#line default
#line hidden
#nullable disable
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<PedidoModel> Html { get; private set; }
    }
}
#pragma warning restore 1591