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
            var a = DBLocator.DbContext.Articles.OrderByDescending(b => b.DateCreation).FirstOrDefault();
            return View(a);
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
        ////[HttpGet]
        ////public ActionResult Test()
        ////{
        ////    ViewBag.notif = "";
        ////    return View();
        ////}

        ////[HttpPost]
        ////public ActionResult Test(Article model)
        ////{
        ////    ViewBag.notif = $"{model.Theme}";
        ////    model.DateCreation = DateTime.Now;
        ////    DBLocator.DbContext.Articles.Add(model);
        ////    DBLocator.DbContext.SaveChanges();
        ////    model = new Article();
        ////    return View();
        ////}

        //[HttpGet]
        //public ActionResult AjoutArticle()
        //{
        //    return View();
        //}

        //[HttpPost]
        //public ActionResult AjoutArticle(Article a)
        //{
        //    a.DateCreation = DateTime.Now;
        //    DBLocator.DbContext.Articles.Add(a);
        //    DBLocator.DbContext.SaveChanges();
        //    return View();
        //}


        //public ActionResult ListeArticles()
        //{

        //    var model = DBLocator.DbContext.Articles.ToList();
        //    return View(model);
        //}

        //[HttpGet]
        //public ActionResult DetailArticle(int id)
        //{
        //    Article model = DBLocator.DbContext.Articles.Find(id);
        //    return View(model);
        //}
        //[HttpGet]
        //public ActionResult EditArticle(int id)
        //{
        //    Article model = DBLocator.DbContext.Articles.Find(id);
        //    return View(model);
        //}

        //[HttpPost]
        //public ActionResult EditArticle(Article model)
        //{
        //    Article model1 = DBLocator.DbContext.Articles.Find(model.Id_Article);
        //    model1.Contenu = model.Contenu;
        //    model1.Theme = model.Theme;
        //    model1.Auteur = model.Auteur;
        //    model1.DateCreation = model.DateCreation;
        //    DBLocator.DbContext.SaveChanges();
        //    return RedirectToAction("Index");
        //}

        //[HttpPost]
        //public ActionResult AddCom(Commentaire com)
        //{
        //    com.DateComentaire = DateTime.Now;
        //    DBLocator.DbContext.Commentaires.Add(com);
        //    DBLocator.DbContext.SaveChanges();
        //    return RedirectToAction("DetailArticle", new { id = com.Com_Id_Article });
        //}








        //[HttpGet]
        //public ActionResult EditCom(int id)
        //{
        //    var com = DBLocator.DbContext.Commentaires.Find(id);
        //    return View(com);
        //}
        //[HttpPost]
        //public ActionResult EditCom(Commentaire com)
        //{
        //    var com1 = DBLocator.DbContext.Commentaires.Find(com.Id_Commentaire);
        //    com1.Auteur = com.Auteur;
        //    com1.Contenu = com.Contenu;
        //    DBLocator.DbContext.SaveChanges();
        //    return RedirectToAction("DetailArticle", new { id = com.Com_Id_Article });
        //}

        //public ActionResult DeleteCom(int id)
        //{
        //    var com = DBLocator.DbContext.Commentaires.Find(id);
        //    DBLocator.DbContext.Commentaires.Remove(com);
        //    DBLocator.DbContext.SaveChanges();
        //    return RedirectToAction("DetailArticle", new { id = com.Com_Id_Article });
        //}
        //public ActionResult DeleteArticle(int id)
        //{
        //    var article = DBLocator.DbContext.Articles.Find(id);
        //    DBLocator.DbContext.Articles.Remove(article);
        //    DBLocator.DbContext.SaveChanges();
        //    return RedirectToAction("ListeArticles");

        //}


    }
}