using App.Data;
using App.Models;
using Microsoft.EntityFrameworkCore;

namespace App.Repositories
{
    public class ProductoRepository : IProductoRepository
    {
        private readonly ProductManagementContext _context;

        public ProductoRepository(ProductManagementContext context)
        {
            _context = context;
        }

        public void AddProducto(Producto producto) 
        { 
            _context.Productos.Add(producto);
            _context.SaveChanges();
       
        }

        public IEnumerable<Producto> GetAllProductos()
        {
            return _context.Productos.Include(p=>p.Categoria).ToList();
        }
    }
}
