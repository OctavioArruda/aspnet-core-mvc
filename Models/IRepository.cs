using System.Linq;

namespace aspnetcore.Models
{
    public class IRepository
    {
        IQueryable<Produto> Produtos { get; set; }
    }
}