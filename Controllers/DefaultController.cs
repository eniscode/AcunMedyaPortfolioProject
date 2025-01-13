using AcunMedyaPortfolioProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AcunMedyaPortfolioProject.Controllers
{
    public class DefaultController : Controller
    {
        // GET: Default
        PortfolioDBEntities2 db = new PortfolioDBEntities2();
        public ActionResult Index()
        {
            return View();
        }
        public PartialViewResult PartialHead()
        {
            return PartialView();
        }
        public PartialViewResult PartialSiteHeader()
        {
            return PartialView();
        }
        public PartialViewResult PartialIntro()
        {
            var intro = db.İntroduction.FirstOrDefault();
            return PartialView(intro);
        }
        public PartialViewResult PartialAbout()
        {
            var about = db.Abouts.FirstOrDefault();
            return PartialView(about);
        }
        public PartialViewResult PartialExperience()
        {
            var experience = db.Experiences.ToList();
            return PartialView(experience);
        }
        public PartialViewResult PartialEducation()
        {
            var education = db.Educations.ToList();
            return PartialView(education);
        }
        public PartialViewResult PartialProject()
        {
            var project = db.Projects.ToList();
            return PartialView(project);
        }
        public PartialViewResult PartialTestimonial()
        {
            var testimonial = db.Testimonials.ToList();
            return PartialView(testimonial);
        }
        public PartialViewResult PartialContact()
        {
            var contacts = new List<Contact>
    {
        new Contact { /* özellikleri başlat */ }
    };
            return PartialView(contacts);
        }
        public PartialViewResult SocialMedia()
        {
            var socialMedia = db.SocialMedias.ToList();
            return PartialView(socialMedia);
        }
        public PartialViewResult LowerSocialMedia()
        {
            var lowerSocialMedia = db.SocialMedias.ToList();
            return PartialView(lowerSocialMedia);
        }
        public PartialViewResult PartialFooter()
        {
            var categories = db.Categories.ToList();
            ViewBag.Categories = categories;
            return PartialView();
        }
        public PartialViewResult PartialScripts()
        {
            return PartialView();
        }
        public PartialViewResult PartialExpertise()
        {
            
            var expertise = db.Expertises.FirstOrDefault();
            return PartialView(expertise);
        }

    }
}