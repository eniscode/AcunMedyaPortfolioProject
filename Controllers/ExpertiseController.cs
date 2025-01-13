using AcunMedyaPortfolioProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AcunMedyaPortfolioProject.Controllers
{
    public class ExpertiseController : Controller
    {
        PortfolioDBEntities2 db = new PortfolioDBEntities2();
        // GET: Expertise
        public ActionResult ExpertiseList()
        {
            var expertiseList = db.Expertises.ToList();
            return View(expertiseList);
        }
        [HttpGet]
        public ActionResult CreateExpertise()
        {
            return View();
        }
        [HttpPost]
        public ActionResult CreateExpertise(Expertise expertise)
        {
            db.Expertises.Add(expertise);
            db.SaveChanges();
            return RedirectToAction("ExpertiseList");
        }
        public ActionResult DeleteExpertise(int id)
        {
            var expertise = db.Expertises.Find(id);
            db.Expertises.Remove(expertise);
            db.SaveChanges();
            return RedirectToAction("ExpertiseList");
        }
        [HttpGet]
        public ActionResult UpdateExpertise(int id)
        {
            var expertise = db.Expertises.Find(id);
            return View(expertise);
        }
        [HttpPost]
        public ActionResult UpdateExpertise(Expertise expertise)
        {
            var updatedExpertise = db.Expertises.Find(expertise.ExpertiseId);
            updatedExpertise.Title = expertise.Title;
            db.SaveChanges();
            return RedirectToAction("ExpertiseList");
        }
    }
}