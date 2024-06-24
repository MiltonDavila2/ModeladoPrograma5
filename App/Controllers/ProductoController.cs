using Microsoft.AspNetCore.Mvc;
using App.Factories;
using App.Services;
using App.Models;
using App.Repositories;
using App.ViewModels;



namespace App.Controllers
{
    public class ProductoController : Controller
    {
        private readonly ProductoRepositoryBridge _productBridge;

        private readonly IProductoFactory _productoFactory;


        public ProductoController(ProductoRepositoryBridge productBridge, IProductoFactory productoFactory)
        {
            _productBridge = productBridge;
            _productoFactory = productoFactory;
        }

        public IActionResult Index()
        {
            var productos = _productBridge.GetAllProducts();
            return View(productos);
        }

        [HttpGet]

        public IActionResult Create()
        {
            return View();
        }


        [HttpPost]

        public IActionResult Create(ProductoViewModel model)
        {
            if (ModelState.IsValid)
            {
                var product = _productoFactory.CrearProducto(model.Nombre, model.Precio, model.CategoriaId);
                _productBridge.AddProducto(product);
                return RedirectToAction("Index");
            }
            return View(model);
        }
    }
}
