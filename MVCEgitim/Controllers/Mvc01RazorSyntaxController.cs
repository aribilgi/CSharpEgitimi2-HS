using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCEgitim.Controllers
{
    public class Mvc01RazorSyntaxController : Controller
    {
        // GET: Mvc01RazorSyntax
        public ActionResult Index() // View oluşturmak için Action adına sağ tık add view deyip açılan pencereden mvc5 view ı seçip ileri diyoruz, gelen pencerede add deyip oluşturuyoruz.
        {
            return View();
        }
    }
}