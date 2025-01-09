using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AcunMedyaAkademiPortfolyo.Models;

namespace AcunMedyaAkademiPortfolyo.Controllers
{
    public class DefaultController : Controller
    {
        
        DbAcunmedyaAkademi1Entities db = new DbAcunmedyaAkademi1Entities();


        public PartialViewResult PartialTestionial()
        {
            var values = db.TblTestimonial.ToList();
            return PartialView(values);
        }
        
        public PartialViewResult PartialServices()
        {
            var values = db.TblProject.ToList();
            return PartialView(values);
        }

        public PartialViewResult PartialResumeInExperiance()
        {
            var values= db.TblExperience.ToList();
            return PartialView(values);
        }

        public PartialViewResult PartialResume()
        {
            var values= db.TblEducation.ToList();
            return PartialView(values);
        }

        public PartialViewResult PartialSkill()
        {
            var values = db.TblSkill.ToList();
            return PartialView(values);
            int totalCategory= db.TblCategory.Count();
            int halfcount = totalCategory/2;
        }

        public PartialViewResult PartialStats()
        {
            var values = db.TblStats.ToList();
            return PartialView(values);
        }

        public PartialViewResult PartialAbout()
        {
            var values =db.TblAbout.ToList();
            return PartialView(values);
        }

        public ActionResult Index()
        {
            return View();
        }

        public PartialViewResult PartialHead()
        {
            return PartialView();
        }

        public PartialViewResult PartialScripts()
        {
            return PartialView();
        }

        public PartialViewResult PartialSidebar()
        {
            return PartialView();
        }

        public PartialViewResult PartialHeroSection()
        {
            return PartialView();
        }

        public PartialViewResult PartialContacts()
        {
            var values = db.TblContacts.ToList();
            return PartialView(values);
        }

        public PartialViewResult PartialPortfolio()
        {
            var values = db.TblCategory.ToList();
            return PartialView(values);
        }
    }
}