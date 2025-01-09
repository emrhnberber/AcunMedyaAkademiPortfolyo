using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AcunMedyaAkademiPortfolyo.Models;

namespace AcunMedyaAkademiPortfolyo.Controllers
{
    public class ExperianceController : Controller
    {
        DbAcunmedyaAkademi1Entities db = new DbAcunmedyaAkademi1Entities();
        public ActionResult ExperianceList()
        {
            var values = db.TblExperience.ToList();
            return View(values);
        }

        [HttpGet]

        public ActionResult CreateExperiance()
        {
            return View();
        }

        [HttpPost]
        public ActionResult CreateExperiance(TblExperience experience)
        {
            db.TblExperience.Add(experience);
            db.SaveChanges();
            return RedirectToAction("ExperianceList");
        }

        public ActionResult DeleteExperiance(int id)
        {
            var value = db.TblExperience.Find(id);
            db.TblExperience.Remove(value);
            db.SaveChanges();
            return RedirectToAction("ExperianceList");
        }


        [HttpGet]

        public ActionResult UpdateExperiance(int id)
        {
            var value = db.TblExperience.Find(id);
            return View(value);
        }

        [HttpPost]

        public ActionResult UpdateExperiance(TblExperience p)
        {
            var value = db.TblExperience.Find(p.ExperienceId);
            value.Title = p.Title;
            value.Period = p.Period;
            value.Description = p.Description;
            value.Location= p.Location;
            db.SaveChanges();
            return RedirectToAction("ExperianceList");
        }

    }
}