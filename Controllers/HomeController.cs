using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcApplication2.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Message = "Benvenuto al test di prova di Francesco Jonus!";

            return View();
        }

        public ActionResult About()
        {
            return View();
        }
    }
}
