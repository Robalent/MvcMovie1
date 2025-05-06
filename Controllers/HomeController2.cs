using Microsoft.AspNetCore.Mvc;

namespace MvcMovie3.Controllers
{
    public class HomeController2 : Controller
    {
        public IActionResult IndexHome2()
        {
            ViewBag.Mensaje = "Pudiste Logearte!!";
            return View();
        }
    }
}
