using AcunMedyaPortfolioProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AcunMedyaPortfolioProject.Views.Statistic
{
    public class StatisticController : Controller
    {
        // GET: Statistic
        PortfolioDBEntities2 db = new PortfolioDBEntities2();
        public ActionResult Statistic()

        {
            var totalProjects = db.Projects.Count();
            var totalCategories = db.Categories.Count();
            var totalExperiences = db.Experiences.Count();

            ViewBag.Totalprojects = totalProjects;
            ViewBag.TotalCategories = totalProjects;
            ViewBag.TotalExperiences = totalExperiences;

            return View();
        }
    }
}