using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ProyectoIntegrador.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Impresion()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Latente()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult Historial()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}