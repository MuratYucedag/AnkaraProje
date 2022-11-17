using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AnkaraProje.Models;

namespace AnkaraProje.Controllers
{
    public class DashboardController : Controller
    {
        // GET: Dashboard
        DbAnkaraPortfolioEntities db = new DbAnkaraPortfolioEntities();
        public ActionResult Index()
        {
            ViewBag.v = db.TblTestimonial.Count();
            ViewBag.v2 = db.TblSkill.Count();
            ViewBag.v3 = db.TblSkill.Where(x => x.Value >= 80).Count();
            ViewBag.v4 = db.TblSkill.Average(x => x.Value);
            return View();
        }

        public PartialViewResult PartialChart()
        {
            return PartialView();
        }
    }
}