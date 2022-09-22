using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCEğitim.Controllers
{
    public class HomeController : Controller
    {
        // Index verileri listeleme işleminde kullanılmaktadır
        public ActionResult Index()
        {
            return View();
        }
        // Hakkında
        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }
        // İletişim
        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult Test()
        {
            //return view - Bana geriye bir sayfa döndüreceksin 
            return View();
        } 
    }
}