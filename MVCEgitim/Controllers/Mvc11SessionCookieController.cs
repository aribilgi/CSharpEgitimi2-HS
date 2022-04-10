using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCEgitim.Controllers
{
    public class Mvc11SessionCookieController : Controller
    {
        // GET: Mvc11SessionCookie : Web uygulamalarında oturum işlemleri için session ve cookie den yararlanırız
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Index(string text)
        {
            // Session oluşturup değer atama..
            Session["deger"] = text;
            return View();
        }
        public ActionResult Sessions()
        {
            return View();
        }
    }
}