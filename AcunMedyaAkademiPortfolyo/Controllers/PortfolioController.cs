using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AcunMedyaAkademiPortfolyo.Models;

namespace AcunMedyaAkademiPortfolyo.Controllers
{
    public class PortfolioController : Controller
    {
        DbAcunmedyaAkademi1Entities db = new DbAcunmedyaAkademi1Entities();
        public ActionResult PortfolioList()
        {
            var values = db.TblCategory.ToList();
            return View(values);
        }


        [HttpGet]

        public ActionResult CreatePortfolio()
        {
            return View();
        }

        [HttpPost]
        public ActionResult CreatePortfolio(TblCategory category)
        {
            db.TblCategory.Add(category);
            db.SaveChanges();
            return RedirectToAction("PortfolioList");
        }

        public ActionResult DeletePortfolio(int id)
        {
            var value = db.TblCategory.Find(id);
            db.TblCategory.Remove(value);
            db.SaveChanges();
            return RedirectToAction("PortfolioList");
        }


        [HttpGet]

        public ActionResult UpdatePortfolio(int id)
        {
            var value = db.TblCategory.Find(id);
            return View(value);
        }

        [HttpPost]

        public ActionResult UpdatePortfolio(TblCategory p)
        {
            var value = db.TblCategory.Find(p.CategoryId);
            value.Title = p.Title;
            value.ShortDescription = p.ShortDescription;
            db.SaveChanges();
            return RedirectToAction("PortfolioList");
        }

    }
}