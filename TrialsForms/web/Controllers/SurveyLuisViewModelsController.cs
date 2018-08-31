using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using TrialsSurveys.Models;

namespace TrialsSurveys.Controllers
{
    public class SurveyLuisViewModelsController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: /SurveyLuisViewModels/
        public ActionResult Index()
        {
            return View(db.SurveyLuisViewModels.ToList());
            //return View();
        }

        // GET: /SurveyLuisViewModels/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            SurveyLuisViewModel surveyLuisViewModel = db.SurveyLuisViewModels.Find(id);
            if (surveyLuisViewModel == null)
            {
                return HttpNotFound();
            }
            return View(surveyLuisViewModel);
        }

        // GET: /SurveyLuisViewModels/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: /SurveyLuisViewModels/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include="Id,Question01,Question02,Question03,Question04")] SurveyLuisViewModel surveyLuisViewModel)
        {
            if (ModelState.IsValid)
            {
                db.SurveyLuisViewModels.Add(surveyLuisViewModel);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(surveyLuisViewModel);
        }

        // GET: /SurveyLuisViewModels/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            SurveyLuisViewModel surveyLuisViewModel = db.SurveyLuisViewModels.Find(id);
            if (surveyLuisViewModel == null)
            {
                return HttpNotFound();
            }
            return View(surveyLuisViewModel);
        }

        // POST: /SurveyLuisViewModels/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include="Id,Question01,Question02,Question03,Question04")] SurveyLuisViewModel surveyLuisViewModel)
        {
            if (ModelState.IsValid)
            {
                db.Entry(surveyLuisViewModel).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(surveyLuisViewModel);
        }

        // GET: /SurveyLuisViewModels/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            SurveyLuisViewModel surveyLuisViewModel = db.SurveyLuisViewModels.Find(id);
            if (surveyLuisViewModel == null)
            {
                return HttpNotFound();
            }
            return View(surveyLuisViewModel);
        }

        // POST: /SurveyLuisViewModels/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            SurveyLuisViewModel surveyLuisViewModel = db.SurveyLuisViewModels.Find(id);
            db.SurveyLuisViewModels.Remove(surveyLuisViewModel);
            db.SaveChanges();
            return RedirectToAction("Index");
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
