using Microsoft.AspNetCore.Mvc;

namespace MvcMovie1.Views.Movies
{
    public class MvcMovie : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
