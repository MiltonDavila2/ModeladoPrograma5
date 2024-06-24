using App.Models;

namespace App.Repositories
{
    public interface IProductoRepository
    {
        void AddProducto(Producto producto);
        
        IEnumerable<Producto> GetAllProductos();
    }
}
