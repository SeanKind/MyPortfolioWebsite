using Portfolio.Models;
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
        [HttpPost]
        public ActionResult Contact(string name, string email, string message)
        {
            using (var db = new Submissions())
            {
                var entry = new Entry();
                entry.Name = name;
                entry.Email = email;
                entry.Message = message;
                entry.Date = DateTime.Now;
                if (ModelState.IsValid && entry.Name != null && entry.Email != null && entry.Message != null)
                {
                    db.Entries.Add(entry);
                    db.SaveChanges();
                    return RedirectToAction("Index");
                }
                else
                {
                    return View("Contact");
                }
            }
        }


        public ActionResult Projects()
        {
            ViewBag.Title = title;
            return View();
        }
    }
}