using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authentication;
using MvcMovie3.BasedeDatosFicticia;
using System.Security.Claims;   

namespace MvcMovie3.Controllers
{
    public class LoginController : Controller
    {
        public ActionResult Login() //devuelve la vista que corresponde al index(login)
        {
            return View();
        }
         
        [HttpPost]
        public ActionResult Login(string username, string password)
        {
            var user = FakeUserDB.Users.FirstOrDefault(u => u.User == username && u.Password == password);//dentro del FoD podemos escribir consultas
           
            if (user != null)
            {

                var claims = new List<Claim>
                {
                    new Claim(ClaimTypes.Name, username)
                };

                HttpContext.Session.SetString("User", user.User); //se guarda la sesión del usuario
                var identity = new ClaimsIdentity(claims, "Cookies");
                var principal = new ClaimsPrincipal(identity);

                HttpContext.SignInAsync("Cookies", principal);

                //return RedirectToAction("Index", "Home");
                return RedirectToAction ("IndexHome2", "HomeController2");

            }
            else 
            {
                ViewBag.Error = "Credenciales Invalidas"; //obj dinámico que le podemos asignar valores específicos y devolverselos a la vista 
            
            }
                return View();
        }
        public ActionResult Logout() 
        {
            HttpContext.SignOutAsync("Cookies");
            return RedirectToAction("Login");
        
        }
    }
}
