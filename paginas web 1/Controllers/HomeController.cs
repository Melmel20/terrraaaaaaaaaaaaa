namespace PaginasWeb.Controllers
{
    using Microsoft.AspNetCore.Mvc;
    using PaginasWeb.Models;

    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            var model = new HomeViewModel
            {
                FeaturedProducts = new List<Product>
                {
                    new Product { Name = "Produto 1", Price = 10, ImageUrl = "/images/product1.jpg" },
                    new Product { Name = "Produto 2", Price = 20, ImageUrl = "/images/product2.jpg" },
                    new Product { Name = "Produto 3", Price = 30, ImageUrl = "/images/product3.jpg" }
                }
            };
            return View(model);
        }

        public IActionResult About()
        {
            var model = new AboutViewModel
            {
                ObjectiveTitle = "Nosso objetivo",
                ObjectiveText = "Nosso objetivo estratégico é conquistar e reter clientes...",
                ObjectiveImageUrl = "/images/indoor_agriculture.jpg",
                FoodSafetyTitle = "Sobre a segurança alimentar",
                FoodSafetyText = "A segurança alimentar é um pilar fundamental...",
                FoodSafetyImageUrl = "/images/food_safety.jpg"
            };
            return View(model);
        }
    }
}
