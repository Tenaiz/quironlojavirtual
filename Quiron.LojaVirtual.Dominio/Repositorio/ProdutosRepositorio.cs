using Quiron.LojaVirtual.Dominio.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quiron.LojaVirtual.Dominio.Repositorio
{
    public class ProdutosRepositorio
    {
        //Variável utilizada para referenciar o Entity
        public readonly EfDbContext _context = new EfDbContext();

        // Propriedade do tipo enumerable que retorna Produto
        public IEnumerable<Produto> Produtos
        {
            get { return _context.Produtos; }
        }
    }
}
