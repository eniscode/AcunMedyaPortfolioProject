using AcunMedyaPortfolioProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AcunMedyaPortfolioProject.Controllers
{
    public class EducationsController : Controller
    {
        PortfolioDBEntities2 db = new PortfolioDBEntities2();
        // GET: Educations
        public ActionResult EducationList()
        {
            var educationsList = db.Educations.ToList();
            
            return View(educationsList);
        }
        [HttpGet]
        public ActionResult CreateEducation()
        {
            return View();
        }
            [HttpPost]
        public ActionResult CreateEducation(Education educations)
        {
            db.Educations.Add(educations);
            db.SaveChanges();
            return RedirectToAction("EducationList");
        }
        public ActionResult DeleteEducation(int id)
        {
            var education = db.Educations.Find(id);
            db.Educations.Remove(education);
            db.SaveChanges();
            return RedirectToAction("EducationList");
        }
        [HttpGet]
        public ActionResult UpdateEducation(int id)
        {
            var education = db.Educations.Find(id);
            return View(education);
        }
        [HttpPost]
        public ActionResult UpdateEducation(Education educations)
        {
            var education = db.Educations.Find(educations.Id);
            education.Title = educations.Title;
            education.StartDate = educations.StartDate;
            education.EndDate = educations.EndDate;
            education.Description = educations.Description;
            education.InstutionName = educations.InstutionName;
            db.SaveChanges();
            return RedirectToAction("EducationList");
        }


    }
}