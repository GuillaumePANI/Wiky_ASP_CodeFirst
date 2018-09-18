using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Wiky_ASP_CodeFirst.BDD_CF;
using Wiky_ASP_CodeFirst.Models;

namespace Wiky_ASP_CodeFirst.Controllers
{
    public class CommentairesController : Controller
    {
        private Wiky_CF db = new Wiky_CF();

        // GET: Commentaires
        public ActionResult Index()
        {
            var commentaires = db.Commentaires.Include(c => c.Article);
            return View(commentaires.ToList());
        }

        // GET: Commentaires/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Commentaire commentaire = db.Commentaires.Find(id);
            if (commentaire == null)
            {
                return HttpNotFound();
            }
            return View(commentaire);
        }

        // GET: Commentaires/Create
        public ActionResult Create()
        {
            ViewBag.Com_Id_Article = new SelectList(db.Articles, "Id_Article", "Theme");
            return View();
        }

        // POST: Commentaires/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id_Commentaire,Auteur,DateComentaire,Contenu,Com_Id_Article")] Commentaire commentaire)
        {
            var listeCom = db.Commentaires.Where(a => a.Com_Id_Article == commentaire.Com_Id_Article);
            if (ModelState.IsValid)
            {
                commentaire.DateComentaire = DateTime.Now;
                db.Commentaires.Add(commentaire);
                db.SaveChanges();
                return PartialView("_Commentaires", listeCom);
            }
            ViewBag.Com_Id_Article = new SelectList(db.Articles, "Id_Article", "Theme", commentaire.Com_Id_Article);
            return PartialView("_Commentaires", listeCom );
        }

        // GET: Commentaires/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Commentaire commentaire = db.Commentaires.Find(id);
            if (commentaire == null)
            {
                return HttpNotFound();
            }
            ViewBag.Com_Id_Article = new SelectList(db.Articles, "Id_Article", "Theme", commentaire.Com_Id_Article);
            return View(commentaire);
        }

        // POST: Commentaires/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id_Commentaire,Auteur,DateComentaire,Contenu,Com_Id_Article")] Commentaire commentaire)
        {
            if (ModelState.IsValid)
            {
                db.Entry(commentaire).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.Com_Id_Article = new SelectList(db.Articles, "Id_Article", "Theme", commentaire.Com_Id_Article);
            return RedirectToAction("Details", "Articles", new {id = commentaire.Com_Id_Article });
        }

        // GET: Commentaires/Delete/5
        public ActionResult Delete(int? id)
        {

            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Commentaire commentaire = db.Commentaires.Find(id);
            if (commentaire == null)
            {
                return HttpNotFound();
            }
            return View(commentaire);
        }

        // POST: Commentaires/Delete/5
       
       
        public ActionResult DeleteConfirmed(int id)
        {
            Commentaire commentaire = db.Commentaires.Find(id);
            db.Commentaires.Remove(commentaire);
            db.SaveChanges();
            var listeCom = db.Commentaires.Where(a => a.Com_Id_Article == commentaire.Com_Id_Article);
            return PartialView("_Commentaires", listeCom );
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
