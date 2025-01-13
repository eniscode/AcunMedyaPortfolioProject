using AcunMedyaPortfolioProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AcunMedyaPortfolioProject.Controllers
{
    public class AboutController : Controller
    {
        // GET: About
        PortfolioDBEntities2 db = new PortfolioDBEntities2();

        public ActionResult Index()
        {
            var about = db.Abouts.ToList();
            return View(about);
        }
    }
}