using App.Models;

namespace App.Factories
{
    public interface IProductoFactory
    {
        Producto CrearProducto(string nombre, decimal precio, int categoriaId);
    }
}
