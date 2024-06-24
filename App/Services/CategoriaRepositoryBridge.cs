using App.Models;
using App.Repositories;

namespace App.Services
{
    public class CategoriaRepositoryBridge
    {

        private readonly ICategoriaRepository _categoriaRepository;

        public CategoriaRepositoryBridge(ICategoriaRepository categoriaRepository)
        {
            _categoriaRepository = categoriaRepository;
        }

        public void AddCategoria(Categoria categoria)
        {
            _categoriaRepository.AddCategoria(categoria);
        }

        public IEnumerable<Categoria> GetAllCategorias()
        {
            return _categoriaRepository.GetAllCategorias();
        }
    }
}
