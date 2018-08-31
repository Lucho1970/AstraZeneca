using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TrialsSurveys.Models;

namespace TrialsSurveys.Controllers
{
    public class PatientController : Controller
    {
        // GET: PatientList
        public ActionResult Index()
        {
            // Get a list of patients
            return View(Data.Patient.GetPatients());
        }

        // GET: PatientList/Details/5
        public ActionResult Details(string patientId)
        {
            
            return View(Data.Patient.GetPatient(patientId));
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


    }
}
