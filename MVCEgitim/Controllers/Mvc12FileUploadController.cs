using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCEgitim.Controllers
{
    public class Mvc12FileUploadController : Controller
    {
        // GET: Mvc12FileUpload
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Index(HttpPostedFileBase dosya)// Mvc de resim yükleme işlemi HttpPostedFileBase sınıfı kullanılarak yapılıyor. Dikkat !! dosya yazan isim ön yüzdeki file upload ın name alanı ile eşleşmeli yoksa resim yüklenmez!
        {
            if (dosya != null && dosya.ContentLength > 0)
            {
                var extensition = Path.GetExtension(dosya.FileName); // dosya uzantsını al
                // dosya işlemleri için System.IO kütüphanesini yukarıya using ile eklemeliyiz!
                if (extensition == ".jpg" || extensition == ".png") // uzantıyı kontrol et
                {
                }
            }
            return View();
        }
    }
}