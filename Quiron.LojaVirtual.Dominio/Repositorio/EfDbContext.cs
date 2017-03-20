using Quiron.LojaVirtual.Dominio.Entidades;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quiron.LojaVirtual.Dominio.Repositorio
{
    // EntityFramework Db Contexto
    public class EfDbContext : DbContext
    {
        // Mapeando a classe de Produtos
        public DbSet<Produto> Produtos { get; set; } // Representa uma coleção das entidades no contexto, ex. De qual classe quero fazer a referência do Produto?

        //public IDbSet<Produto> Produtos { get; set; }

        // Trabalha com "Puralização", ou seja, Produtos... Faz computadores, cria pessoas...
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            // Neste caso a Pluralização não será realizada
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();

            // Para pluralizar tenho que falar que a minha tabela de Produto, minha classe Produto, quero chamar de produtos
            modelBuilder.Entity<Produto>().ToTable("Produtos");

            //base.OnModelCreating(modelBuilder);

            // Porque fazer isso? Eu não chamei a tabela do banco de Produtos? Se eu estou falando para remover a Pluralização ele vai pegar Esse Podutos referenciado como DbSet e vai procurar lá no banco como Produto, então já estou falando que Produto para mim é ProdutoS.
        }

        //public System.Data.Entity.DbSet<Quiron.LojaVirtual.Dominio.Entidades.Produto> Produtoes { get; set; }
    }
}
