using App.Models;

namespace App.Factories
{
    public class ConcreteCategoriaFactory : ICategoriaFactory

    {
        public Categoria CrearCategoria(string nombre)
        {
            return new Categoria
            {
                Nombre = nombre,
                Productos = new List<Producto>()
            };
        }
    }
}
