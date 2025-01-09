using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AcunMedyaAkademiPortfolyo.Models;

namespace AcunMedyaAkademiPortfolyo.Controllers
{
    public class AboutController : Controller
    {
        DbAcunmedyaAkademi1Entities db = new DbAcunmedyaAkademi1Entities();
        public ActionResult AboutList()
        {
            var values = db.TblAbout.ToList();
            return View(values);
        }

        [HttpGet]
        public ActionResult EditAbout(int id)
        {
            var value = db.TblAbout.Find(id);
            return View(value);
        }

        [HttpPost]

        public ActionResult EditAbout(TblAbout p)
        {
            var value = db.TblAbout.Find(p.AboutId);
            value.AboutTitle = p.AboutTitle;
            value.AboutDescription = p.AboutDescription;
            db.SaveChanges();
            return RedirectToAction("AboutList");
        }
    }
}