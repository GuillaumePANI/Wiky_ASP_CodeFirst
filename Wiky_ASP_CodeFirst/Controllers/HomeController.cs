using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Wiky_ASP_CodeFirst.BDD_CF;
using Wiky_ASP_CodeFirst.Models;

namespace Wiky_ASP_CodeFirst.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet]
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Index(Article a)
        {
            a.DateCreation = DateTime.Now;
            DBLocator.DbContext.Articles.Add(a);
            DBLocator.DbContext.SaveChanges();
            return View();
        }
        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
        [HttpGet]
        public ActionResult Test()
        {
            ViewBag.notif = "";
            return View();
        }

        [HttpPost]
        public ActionResult Test(Article model)
        {
            ViewBag.notif = $"{model.Theme}";
            model.DateCreation = DateTime.Now;
            DBLocator.DbContext.Articles.Add(model);
            DBLocator.DbContext.SaveChanges();
            model = new Article();
            return View();
        }
    }
}