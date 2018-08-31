using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TrialsSurveys.Models;

namespace TrialsSurveys.Controllers
{
    public class ClinicController : Controller
    {
        // GET: PatientList
        public ActionResult Index()
        {
            // Get a list of patients
            return View(Data.Clinic.GetClinics());
        }

        // GET: PatientList/Details/5
        public ActionResult Details(string clinicId)
        {
            var cm = Data.Clinic.GetClinic(clinicId);
            return View(cm);
        }

        // GET: PatientList/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: PatientList/Create
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

        // GET: PatientList/Edit/5
        public ActionResult Edit(string clinicId)
        {
            var clinic = Data.Clinic.GetClinic(clinicId);
            return View(clinic);
        }

    }
}
