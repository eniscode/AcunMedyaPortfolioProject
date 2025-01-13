using AcunMedyaPortfolioProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AcunMedyaPortfolioProject.Controllers
{
    public class İntroductionController : Controller
    {
        PortfolioDBEntities2 db = new PortfolioDBEntities2();
        // GET: İntroduction
        public ActionResult İntroductionList()
        {
            var introduction  = db.İntroduction.ToList();

            return View(introduction);
        }
        [HttpGet]
        public ActionResult Createİntroduction()
        {

            return View();
        }
        [HttpPost]
        public ActionResult Createİntroduction(İntroduction introduction)
        {
            db.İntroduction.Add(introduction);
            db.SaveChanges();
            return RedirectToAction("İntroductionList");
        }
        public ActionResult Deleteİntroduction(int id)
        {
            var introduction = db.İntroduction.Find(id);
            db.İntroduction.Remove(introduction);
            db.SaveChanges();
            return RedirectToAction("İntroductionList");
        }
        [HttpGet]
        public ActionResult Updateİntroduction(int id)
        {
            var introduction = db.İntroduction.Find(id);
            return View(introduction);
        }
        [HttpPost]
        public ActionResult Updateİntroduction(İntroduction introduction)
        {
            var updatedİntroduction = db.İntroduction.Find(introduction.Id);
            updatedİntroduction.Title = introduction.Title;
            updatedİntroduction.Description = introduction.Description;
            db.SaveChanges();
            return RedirectToAction("İntroductionList");
        }

    }
}