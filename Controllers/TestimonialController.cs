using AcunMedyaPortfolioProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AcunMedyaPortfolioProject.Controllers
{
    public class TestimonialController : Controller
    {
        // GET: Testimonial
        PortfolioDBEntities2 db = new PortfolioDBEntities2();
        public ActionResult Index()
        {
            var testimonials = db.Testimonials.ToList();
            return View(testimonials);
            
        }
        [HttpGet]
        public ActionResult CreateTestimonial()
        {
           
            return View();
        }
        [HttpPost]
        public ActionResult CreateTestimonial(Testimonial testimonial)
        {
            db.Testimonials.Add(testimonial);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
        public ActionResult DeleteTestimonial(int id)
        {
            var testimonial = db.Testimonials.Find(id);
            db.Testimonials.Remove(testimonial);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
        [HttpGet]
        public ActionResult UpdateTestimonial(int id)
        {
            var testimonial = db.Testimonials.Find(id);
            return View(testimonial);
        }
        [HttpPost]
        public ActionResult UpdateTestimonial(Testimonial testimonial)
        {
            db.Entry(testimonial).State = System.Data.Entity.EntityState.Modified;
            db.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}