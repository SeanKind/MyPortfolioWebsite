using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Portfolio.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Title = "Sean's Portfolio";
            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Title = "Sean's Portfolio";
            return View();
        }
    }
}