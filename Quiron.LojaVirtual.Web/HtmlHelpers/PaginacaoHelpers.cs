using Quiron.LojaVirtual.Web.Models;
using System;
using System.Text;
using System.Web.Mvc;

namespace Quiron.LojaVirtual.Web.HtmlHelpers
{
    /// <summary>
    /// Gerador de Html de paginação
    /// </summary>
    public static class PaginacaoHelpers
    {
        // Total de páginas = 3

        /// <summary>
        /// Método de Page Links que retorna um MVC html String, neste caso o método tem que ser estático
        /// </summary>
        /// <param name="?"></param>
        /// <returns></returns>
        public static MvcHtmlString PageLinks(this HtmlHelper html, Paginacao paginacao, Func<int, string> paginaUrl) // O Function é um delegate que monta a sequencia com a numeração das páginas
        {
            StringBuilder resultado = new StringBuilder();

            for (int i = 1; i < paginacao.TotalPagina; i++)
            {
                // Classe TagBuilder utilizada para criar as tags, neste caso quero que primeiramente crie a tag "a"
                TagBuilder tag = new TagBuilder("a");

                // Em seguida adiciono o atributo através do MERGE que irei utilizar depois do "a".
                tag.MergeAttribute("href", paginaUrl(i));

                // Pega a numeração de cada página
                tag.InnerHtml = i.ToString();

                // Através do Bootstrap é possível mudar a cor do botão utilizando o "btn-primary", então para poder destacar a página preciso apenas saber qual é a página atual.

                if (i == paginacao.PaginaAtual)
                {
                    // Adiciono as classes do bootstrap
                    tag.AddCssClass("btn btn-default");
                    
                    // Ai o resutado disso eu jogo a tag
                    resultado.Append(tag);
                }
            }
            return MvcHtmlString.Create(resultado.ToString());
        }
    }
}