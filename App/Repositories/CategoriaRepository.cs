using App.Data;
using App.Models;
using Microsoft.EntityFrameworkCore;

namespace App.Repositories
{
    public class CategoriaRepository : ICategoriaRepository
    {
        private readonly ProductManagementContext _context;

        public CategoriaRepository(ProductManagementContext context)
        {
            _context = context;
        }


        public void AddCategoria(Categoria categoria)
        {
            _context.Categorias.Add(categoria);
            _context.SaveChanges(); 
        }

        public IEnumerable<Categoria> GetAllCategorias()
        {
            return _context.Categorias.Include(c=>c.Productos).ToList();
        }
    }
}
