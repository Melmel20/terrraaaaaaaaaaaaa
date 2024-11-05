namespace PaginasWeb.Controllers
{
    using Microsoft.AspNetCore.Mvc;
    using PaginasWeb.Models;

    public class CheckoutController : Controller
    {
        public IActionResult Index()
        {
            var model = new CheckoutViewModel
            {
                Items = new List<CartItem>
                {
                    new CartItem { Name = "Cebola", Quantity = 4, Price = 10.00m },
                    new CartItem { Name = "Salsa", Quantity = 4, Price = 8.00m },
                    new CartItem { Name = "Tomate", Quantity = 4, Price = 12.00m }
                },
                PaymentMethod = "CARTÃO",
                DeliveryAddress = "AVENIDA DOS GIRASSOIS, 321"
            };
            return View(model);
        }

        [HttpPost]
        public IActionResult Finalizar(CheckoutViewModel model)
        {
            if (ModelState.IsValid)
            {
                // Lógica para finalizar a compra
                return RedirectToAction("Success");
            }
            return View(model);
        }

        public IActionResult Success()
        {
            return View();
        }
    }
}
