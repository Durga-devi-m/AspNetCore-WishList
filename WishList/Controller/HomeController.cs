using Microsoft.AspNetCore.Mvc;

namespace WishList
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View("/Home/Index");
        }

        public IActionResult Error()
        {
            return View("/Shared/Error");
        }
    }
}
