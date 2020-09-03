using MrJuerga.Entity;
using System.Collections.Generic;

namespace MrJuerga.Repository
{
    public interface IProductoRepository: IRepository<Producto>
    {
        IEnumerable<Producto> FetchProductobyName (string name);
    }
}