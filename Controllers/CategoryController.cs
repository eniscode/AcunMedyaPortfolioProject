using AcunMedyaPortfolioProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AcunMedyaPortfolioProject.Controllers
{
    public class CategoryController : Controller
    {
        // GET: Category
        PortfolioDBEntities2 db = new PortfolioDBEntities2();
        public ActionResult CategoryList()
        {
            var categoryList = db.Categories.ToList();
            return View(categoryList);
        }
        [HttpGet]
        public ActionResult CreateCategory()
        {
            return View();
        }
        [HttpPost]
        public ActionResult CreateCategory(Category category)
        {
            db.Categories.Add(category);
            db.SaveChanges();
            return RedirectToAction("CategoryList");
        }
        public ActionResult DeleteCategory(int id)
        {
            var category = db.Categories.Find(id);
            db.Categories.Remove(category);
            db.SaveChanges();
            return RedirectToAction("CategoryList");
        }
        [HttpGet]
        public ActionResult UpdateCategory(int id)
        {
            var category = db.Categories.Find(id);
            return View(category);
        }
        [HttpPost]
        public ActionResult UpdateCategory(Category category)
        {
            var updatedCategory = db.Categories.Find(category.Id);
            updatedCategory.Name = category.Name;
            db.SaveChanges();
            return RedirectToAction("CategoryList");
        }
    }

}
