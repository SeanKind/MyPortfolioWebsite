using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Portfolio.Controllers
{
    public class HomeController : Controller
    {
        string title = "Sean's Portfolio";
        public ActionResult Index()
        {
            ViewBag.Title = title;
            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Title = title;
            return View();
        }

        public ActionResult Projects()
        {
            ViewBag.Title = title;
            return View();
        }
    }
}