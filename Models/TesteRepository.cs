using System.Linq;

namespace aspnetcore.Models
{
    public class TesteRepository : IRepository
    {
        public static Produto[] Dados = new Produto[] 
        {
            new Produto { ProdutoId = 10, Nome = "Caneta", Categoria = "Escolar", Preco = 100 },
            new Produto { ProdutoId = 20, Nome = "Borracha", Categoria = "Escolar", Preco = 200 },
            new Produto { ProdutoId = 30, Nome = "Caderno", Categoria = "Escolar", Preco = 300 },
            new Produto { ProdutoId = 40, Nome = "Tablet", Categoria = "Eletrônicos", Preco = 400 },
            new Produto { ProdutoId = 50, Nome = "IPhone", Categoria = "Eletrônicos", Preco = 500 },            
        };

        public IQueryable<Produto> Produtos => Dados.AsQueryable();
    }
}