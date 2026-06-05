using FinanceBillingAnalytics.Models.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace FinanceBillingAnalytics.Controllers
{
    public class AccountController : Controller
    {
        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Login(LoginViewModel model)
        {
            if (model.Email == "admin@finance.com"
                && model.Password == "Admin123")
            {
                return RedirectToAction(
                    "Index",
                    "Dashboard");
            }

            ViewBag.Error =
                "Invalid Credentials";

            return View(model);
        }

        public IActionResult Logout()
        {
            return RedirectToAction(
                "Login");
        }
    }
}