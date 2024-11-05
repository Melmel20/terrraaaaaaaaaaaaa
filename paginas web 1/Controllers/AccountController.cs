namespace PaginasWeb.Controllers
{
    using Microsoft.AspNetCore.Mvc;
    using PaginasWeb.Models;

    public class AccountController : Controller
    {
        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Login(User user)
        {
            if (ModelState.IsValid)
            {
                // Lógica de autenticação aqui
                return RedirectToAction("Index", "Home");
            }
            return View(user);
        }

        public IActionResult Register()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Register(User user)
        {
            if (ModelState.IsValid)
            {
                // Lógica de registro aqui
                return RedirectToAction("Login");
            }
            return View(user);
        }
    }
}
