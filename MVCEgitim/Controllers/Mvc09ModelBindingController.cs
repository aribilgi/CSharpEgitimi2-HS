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
            var sayfaModeli = new AnasayfaViewModel // Anasayfada kullanılacak modeli oluşturduk
            {
                Adres = new Adres { Id = 25, Sehir = "Erzurum", Ilce = "Ilıca", AcikAdres = "Cami sk. no:18" },
                Kullanici = new Kullanici { Id = 34, Ad = "Murat", Soyad = "Yılmaz", Email = "nusr@doner.co", KullaniciAdi = "admin", Sifre = "123456" }
            };
            return View(sayfaModeli); // yukarda oluşturup içini doldurduğumuz sayfa modelini view içinde sayfaya yolluyoruz
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
            ViewBag.Mesaj = "Kullanıcı Adı : " + kullanici.Ad;
            ViewData["Vdata"] = "Kullanıcı Soyadı : " + kullanici.Soyad;
            TempData["Tdata"] = "Kullanıcı Email : " + kullanici.Email;
            return View(kullanici); // View a kullanici modelini gönder
        }

        public ActionResult Adres() // Get 
        {
            return View();
        }
        [HttpPost]
        public ActionResult Adres(Adres adres) // Get 
        {
            ViewBag.Mesaj = "Şehir : " + adres.Sehir; // ön yüze şehir verisi gönderiyoruz
            ViewData["Vdata"] = "İlçe : " + adres.Ilce;// View a ilçe verisi gönderiyoruz
            TempData["Tdata"] = "Açık Adres : " + adres.AcikAdres; // tempdata 2 kez kullanılabilir diğerleri 1 kez
            return View(adres); // sayfaya (view a) adres nesnesini gönderiyoruz
        }
    }
}