using App.Models;
using Microsoft.EntityFrameworkCore;

namespace App.Data
{
    public class ProductManagementContext : DbContext
    {

        public DbSet<Producto> Productos { get; set; }

        public DbSet<Categoria> Categorias { get; set; }


        public ProductManagementContext(DbContextOptions<ProductManagementContext> options) : base(options) { }
    }
}
