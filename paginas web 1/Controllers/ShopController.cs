namespace PaginasWeb.Controllers
{
    using Microsoft.AspNetCore.Mvc;
    using PaginasWeb.Models;
    using System.Collections.Generic;
    using System.Linq;

    public class ShopController : Controller
    {
        private static List<Product> Cart = new List<Product>();

        private List<Product> GetProducts()
        {
            return new List<Product>
            {
                new Product { Id = "1", Name = "Alface", Price = 5, ImageUrl = "/images/alface.jpg" },
                new Product { Id = "2", Name = "Cebola", Price = 3, ImageUrl = "/images/cebola.jpg" },
                new Product { Id = "3", Name = "Tomate", Price = 4, ImageUrl = "/images/tomate.jpg" },
                new Product { Id = "4", Name = "Salsa", Price = 2, ImageUrl = "/images/salsa.jpg" }
            };
        }

        public IActionResult Index()
        {
            var products = GetProducts();
            return View(products);
        }

        [HttpPost]
        public IActionResult AddToCart(string productId)
        {
            var products = GetProducts();
            var product = products.FirstOrDefault(p => p.Id == productId);
            if (product != null)
            {
                Cart.Add(product);
            }
            return RedirectToAction("Index");
        }

        public IActionResult ViewCart()
        {
            return View(Cart);
        }

        [HttpPost]
        public IActionResult RemoveFromCart(string productId)
        {
            var product = Cart.FirstOrDefault(p => p.Id == productId);
            if (product != null)
            {
                Cart.Remove(product);
            }
            return RedirectToAction("ViewCart");
        }
    }
}
