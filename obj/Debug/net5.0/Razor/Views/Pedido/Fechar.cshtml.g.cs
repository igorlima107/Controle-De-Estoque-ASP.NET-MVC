#pragma checksum "C:\Users\igors\Desktop\Curso\Projetos\EstoqueWeb\Views\Pedido\Fechar.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3c8129a18234745fa34079684a784e913f95f83c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(EstoqueWeb.Models.Pedido.Views_Pedido_Fechar), @"mvc.1.0.view", @"/Views/Pedido/Fechar.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3c8129a18234745fa34079684a784e913f95f83c", @"/Views/Pedido/Fechar.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b649f5b9ff7f3e7b71aa36f24da6ee2387e4b1e6", @"/Views/_ViewImports.cshtml")]
    public class Views_Pedido_Fechar : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<PedidoModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", "hidden", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "id", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-success"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-outline-success"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Fechar", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("w-25"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 2 "C:\Users\igors\Desktop\Curso\Projetos\EstoqueWeb\Views\Pedido\Fechar.cshtml"
  
    ViewBag.Subtitulo = $"Fechamento Do Pedido <b>{Model.IdPedido:D4}</b>";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1 class=\"text-primary\">");
#nullable restore
#line 6 "C:\Users\igors\Desktop\Curso\Projetos\EstoqueWeb\Views\Pedido\Fechar.cshtml"
                    Write(Html.Raw(ViewBag.Subtitulo));

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\r\n<hr>\r\n<h6>Cliente: <b class=\"text-dark\">");
#nullable restore
#line 8 "C:\Users\igors\Desktop\Curso\Projetos\EstoqueWeb\Views\Pedido\Fechar.cshtml"
                             Write(Model.Cliente.Nome);

#line default
#line hidden
#nullable disable
            WriteLiteral("</b></h6>\r\n");
#nullable restore
#line 9 "C:\Users\igors\Desktop\Curso\Projetos\EstoqueWeb\Views\Pedido\Fechar.cshtml"
 if (Model.DataEntrega.HasValue)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <h6>Endereço de entrega: ");
#nullable restore
#line 11 "C:\Users\igors\Desktop\Curso\Projetos\EstoqueWeb\Views\Pedido\Fechar.cshtml"
                        Write(Model.EnderecoEntrega.EnderecoCompleto);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h6>\r\n");
#nullable restore
#line 12 "C:\Users\igors\Desktop\Curso\Projetos\EstoqueWeb\Views\Pedido\Fechar.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("<hr>\r\n");
#nullable restore
#line 14 "C:\Users\igors\Desktop\Curso\Projetos\EstoqueWeb\Views\Pedido\Fechar.cshtml"
 if (Model.ItensPedido.Count > 0)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <h6><b>Itens do pedido:</b></h6>\r\n    <hr>\r\n");
#nullable restore
#line 18 "C:\Users\igors\Desktop\Curso\Projetos\EstoqueWeb\Views\Pedido\Fechar.cshtml"
     foreach (var item in Model.ItensPedido)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <h6>");
#nullable restore
#line 20 "C:\Users\igors\Desktop\Curso\Projetos\EstoqueWeb\Views\Pedido\Fechar.cshtml"
       Write(item.Produto.Nome);

#line default
#line hidden
#nullable disable
            WriteLiteral(" (");
#nullable restore
#line 20 "C:\Users\igors\Desktop\Curso\Projetos\EstoqueWeb\Views\Pedido\Fechar.cshtml"
                           Write(item.Quantidade);

#line default
#line hidden
#nullable disable
            WriteLiteral(" x ");
#nullable restore
#line 20 "C:\Users\igors\Desktop\Curso\Projetos\EstoqueWeb\Views\Pedido\Fechar.cshtml"
                                              Write(item.ValorUnitario.ToString("C"));

#line default
#line hidden
#nullable disable
            WriteLiteral(" = ");
#nullable restore
#line 20 "C:\Users\igors\Desktop\Curso\Projetos\EstoqueWeb\Views\Pedido\Fechar.cshtml"
                                                                                  Write(item.ValorItem.ToString("C"));

#line default
#line hidden
#nullable disable
            WriteLiteral(")</h6>\r\n");
#nullable restore
#line 21 "C:\Users\igors\Desktop\Curso\Projetos\EstoqueWeb\Views\Pedido\Fechar.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("    <hr>\r\n    <h6><b>Valor Total do Pedido: ");
#nullable restore
#line 23 "C:\Users\igors\Desktop\Curso\Projetos\EstoqueWeb\Views\Pedido\Fechar.cshtml"
                             Write(Model.ValorTotal.Value.ToString("C"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</b></h6>\r\n");
#nullable restore
#line 24 "C:\Users\igors\Desktop\Curso\Projetos\EstoqueWeb\Views\Pedido\Fechar.cshtml"
}
else
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <h6><b>Não há itens no pedido.</b></h6>\r\n");
#nullable restore
#line 28 "C:\Users\igors\Desktop\Curso\Projetos\EstoqueWeb\Views\Pedido\Fechar.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("<h4>Deseja realmente fechar esse pedido?</h4>\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3c8129a18234745fa34079684a784e913f95f83c9541", async() => {
                WriteLiteral("\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "3c8129a18234745fa34079684a784e913f95f83c9803", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
#nullable restore
#line 32 "C:\Users\igors\Desktop\Curso\Projetos\EstoqueWeb\Views\Pedido\Fechar.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => Model.IdPedido);

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.Name = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n    <div class=\"mt-3\">\r\n");
#nullable restore
#line 34 "C:\Users\igors\Desktop\Curso\Projetos\EstoqueWeb\Views\Pedido\Fechar.cshtml"
         if (!Model.DataPedido.HasValue && Model.ItensPedido.Count() > 0)
        {

#line default
#line hidden
#nullable disable
                WriteLiteral("            <button class=\"btn btn-danger\" type=\"submit\">Sim</button>\r\n            ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3c8129a18234745fa34079684a784e913f95f83c12103", async() => {
                    WriteLiteral("Não");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
                if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
                {
                    throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-cid", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
                }
                BeginWriteTagHelperAttribute();
#nullable restore
#line 37 "C:\Users\igors\Desktop\Curso\Projetos\EstoqueWeb\Views\Pedido\Fechar.cshtml"
                                     WriteLiteral(Model.IdCliente);

#line default
#line hidden
#nullable disable
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["cid"] = __tagHelperStringValueBuffer;
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-cid", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["cid"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("   \r\n");
#nullable restore
#line 38 "C:\Users\igors\Desktop\Curso\Projetos\EstoqueWeb\Views\Pedido\Fechar.cshtml"
        }
        else 
        {

#line default
#line hidden
#nullable disable
                WriteLiteral("            ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3c8129a18234745fa34079684a784e913f95f83c14683", async() => {
                    WriteLiteral("Voltar");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
                if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
                {
                    throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-cid", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
                }
                BeginWriteTagHelperAttribute();
#nullable restore
#line 41 "C:\Users\igors\Desktop\Curso\Projetos\EstoqueWeb\Views\Pedido\Fechar.cshtml"
                                     WriteLiteral(Model.IdCliente);

#line default
#line hidden
#nullable disable
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["cid"] = __tagHelperStringValueBuffer;
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-cid", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["cid"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("  \r\n");
#nullable restore
#line 42 "C:\Users\igors\Desktop\Curso\Projetos\EstoqueWeb\Views\Pedido\Fechar.cshtml"
        }

#line default
#line hidden
#nullable disable
                WriteLiteral("    </div>\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
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
