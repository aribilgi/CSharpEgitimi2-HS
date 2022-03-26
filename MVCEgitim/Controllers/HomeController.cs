using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCEgitim.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index() // HomeController daki Index actionu
        {
            return View(); // Burada Index action una gelen /home/Index isteği sonucunda views klasöründeki index.cshtml sayfasını çalıştırır.
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}