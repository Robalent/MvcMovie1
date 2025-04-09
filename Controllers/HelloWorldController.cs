using System.Text.Encodings.Web;
using Microsoft.AspNetCore.Mvc;

namespace MvcMovie3.Controllers
{
    public class HelloWorldController : Controller
    {
        // 
        // GET: /HelloWorld/ Reemplazar el método index:

        public IActionResult Index()
        {
            ViewData["Titulo"] = "Este es mi titulo desde el controlador";
            return View();
        }

        // 
        // GET: /HelloWorld/Welcome/ Agregar este método:
        // Requires using System.Text.Encodings.Web;
        public IActionResult Welcome(string name, int numTimes = 1)
        {
            ViewData["Message"] = "Hello " + name;
            ViewData["NumTimes"] = numTimes;

            return View();
        }

    }
}
