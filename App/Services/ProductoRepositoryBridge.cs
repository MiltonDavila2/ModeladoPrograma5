using App.Models;
using App.Repositories;

namespace App.Services
{
    public class ProductoRepositoryBridge
    {
        private readonly IProductoRepository _productorRepository;

        public ProductoRepositoryBridge(IProductoRepository productorRepository)
        {
            _productorRepository = productorRepository;
        }

        public void AddProducto(Producto producto)
        {
            _productorRepository.AddProducto(producto);
        }


        public IEnumerable<Producto> GetAllProducts()
        {
            return _productorRepository.GetAllProductos();
        }
        


    }
}
