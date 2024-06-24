using App.Models;

namespace App.Repositories
{
    public interface ICategoriaRepository
    {

        void AddCategoria(Categoria categoria);
        IEnumerable<Categoria> GetAllCategorias();
    }
}
