using Microsoft.AspNetCore.Mvc;

namespace GuitarShop.Controllers
{
    public class CartController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Add(string id)
        {
            TempData["message"] = $"Product '{id}' has been added to the cart.";
            return RedirectToAction("List", "Product");
        }
    }
}