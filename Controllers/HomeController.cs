using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace NewThreeDApp.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Title = "Home Page";

            return View();
        }
        [HttpGet]
        public ActionResult GetRandom()
        {
            return Json(new { random = new Random().Next(20) }, JsonRequestBehavior.AllowGet);
        }
    }
}
