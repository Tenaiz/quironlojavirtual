using System;

namespace Quiron.LojaVirtual.Web.Models
{
    public class Paginacao
    {
        // Quantos itens tenho no banco
        public int ItensTotal { get; set; }

        // Quantos itens quero por página
        public int ItensPorPagina { get; set; }

        // Qual a página que está sendo exibida no momento
        public int PaginaAtual { get; set; }

        // Quantas páginas eu tenho
        public int TotalPagina 
        { 
            get
            {
                // Divide o total de itens por itens por página 
                // O Ceiling arredonda para cima caso tenha alguma divisão que não seja exata
                return (int)Math.Ceiling((decimal)ItensTotal / ItensPorPagina);
            } 
        }
    }
}


