using Quiron.LojaVirtual.Dominio.Repositorio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Quiron.LojaVirtual.Web.Controllers
{
    public class VitrineController : Controller
    {
        private ProdutosRepositorio _repositorio;
        public int ProdutosPorPagina = 3;

        //
        // GET: /Vitrine/
        public ActionResult ListaProdutos(int pagina = 1)
        {
            _repositorio = new ProdutosRepositorio();

            var produtos = _repositorio.Produtos
                .OrderBy(p => p.Descricao) // Ordenando os produtos por ID
                .Skip((pagina - 1) * ProdutosPorPagina) // Pego a Pagina - 1 e multiplico pelos produtos por página. (Ex.: Pagina 3 = 3 - 1 = 2 * 6 (das outras duas páginas), então retira pra mim os 6 primeiros.
                .Take(ProdutosPorPagina); // Da lista de Produtos quero pegar somente 3

            return View(produtos);
        }
	}
}