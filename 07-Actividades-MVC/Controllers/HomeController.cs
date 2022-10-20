using _07_Actividades_MVC.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace _07_Actividades_MVC.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            String saludo;

            if (DateTime.Now.Hour > 20 && DateTime.Now.Hour < 6)
            {
                saludo = "Buenas nochese";
            }
            else if (DateTime.Now.Hour >= 6 && DateTime.Now.Hour < 12)
            {
                saludo = "Buenos días";
            }
            else
            {
                saludo = "Buenas tardes";
            }

            ViewData["Saludo"] = saludo;


            String fecha;
            fecha = DateTime.Now.ToString();
            ViewBag.Fecha = fecha;


            return View();
        }
        
    }
}