using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TrialsSurveys.Models;

namespace TrialsSurveys.Controllers
{
    public class SurveysController : Controller
    {
        // GET: Survey
        public ActionResult Index(string patientId = null)
        {
            var sms = new List<SurveysModel>();
            sms.Add(
            new SurveysModel
            {
                SurveyId = "AABB01",
                SurveyName = "The AA BB Survey",
                Completed = true
            });
            sms.Add(
            new SurveysModel
            {
                SurveyId = "CCDD02",
                SurveyName = "The CC DD Survey",
                Completed = false
            });
            ViewBag.PatientId = patientId;
            // When Index is called without parameters
            return View(sms);
        }

        // GET: Survey/Details/5
        public ActionResult Survey(string patientId, string surveyId)
        {
            SurveyBase survey;
            // Retrieve the model for the survey and display the correct survey
            switch (surveyId)
            {
                case "AABB01":
                    survey = new AQLQ_s_12();
                    break;
                case "CCDD02":
                    survey = new AQLQ_s_12();
                    break;
                default:
                    survey = new AQLQ_s_12();
                    break;
            }
            
            return View("AQLQ_s_12", survey);
        }

        // GET: Survey/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Survey/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Survey/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Survey/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Survey/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Survey/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
