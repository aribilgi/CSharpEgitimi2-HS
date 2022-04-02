using MVCEgitim.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCEgitim.Controllers
{
    public class Mvc09ModelBindingController : Controller
    {
        // GET: Mvc09ModelBinding
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Kullanici()
        {
            Kullanici kullanici = new Kullanici
            {
                Ad = "Rumeysa",
                KullaniciAdi = "rumi",
                Sifre = "rmys123"
            };
            return View(kullanici); // View sayfasına bu şekilde veri gönderilir
        }
        [HttpPost]
        public ActionResult Kullanici(Kullanici kullanici) // Model classımızı bu şekilde parametre olarak kullanabiliyoruz
        {
            return View();
        }
    }
}