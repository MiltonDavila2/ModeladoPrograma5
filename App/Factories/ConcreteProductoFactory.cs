using App.Models;

namespace App.Factories
{
    public class ConcreteProductoFactory : IProductoFactory
    {
        public Producto CrearProducto(string nombre, decimal precio, int categoriaId)
        {

            return new Producto
            {
                Nombre = nombre,
                Precio = precio,
                CategoriaId = categoriaId
            };
        }
    }
}
