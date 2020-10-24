using System.Linq;

namespace aspnetcore.Models
{
    public interface IRepository
    {
        IQueryable<Produto> Produtos { get; }
    }
}