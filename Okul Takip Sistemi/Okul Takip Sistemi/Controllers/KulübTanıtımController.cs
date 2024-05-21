using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Okul_Takip_Sistemi.Controllers
{
    public class KulübTanıtımController : Controller
    {
        // GET: KulübTanıtım
        public ActionResult Index()
        {
            //Satranç
            return View();
        }
        public ActionResult Erasmus()
        {
            return View();
        }
        public ActionResult Kizilay()
        {
            return View();
        }
        public ActionResult afad()
        {
            return View();
        }
        public ActionResult Espor()
        {
            return View();
        }
        public ActionResult Gezi()
        {
            return View();
        }
    }
}