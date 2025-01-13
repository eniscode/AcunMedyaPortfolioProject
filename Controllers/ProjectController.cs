using AcunMedyaPortfolioProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AcunMedyaPortfolioProject.Controllers
{
    public class ProjectController : Controller
    {
        // GET: Project
        PortfolioDBEntities2 db = new PortfolioDBEntities2();
        public ActionResult Index()
        {
            var project = db.Projects.ToList();
            return View(project); 
        }
        [HttpGet]
        public ActionResult CreateProject()
        {
            var categories = db.Categories.ToList();
            var List = new SelectList(categories, "Id", "Name");
            ViewBag.Categories = List;
            return View();

        }
        [HttpPost]
        public ActionResult CreateProject(Project project)
        {
            db.Projects.Add(project);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
        public ActionResult DeleteProject(int id)
        {
            var project = db.Projects.Find(id);
            db.Projects.Remove(project);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
        public ActionResult UpdateProject(int id)
        {
            var project = db.Projects.Find(id);
            var categories = db.Categories.ToList();
            var List = new SelectList(categories, "Id", "Name",project.CategoryId);
            ViewBag.Categories = List;
            return View(project);
        }
        [HttpPost]
        public ActionResult UpdateProject(Project project)
        {
            var updatedProject = db.Projects.Find(project.Id);
            updatedProject.Name = project.Name;
            updatedProject.CategoryId = project.CategoryId;
            updatedProject.ConvertİmageUrl = project.ConvertİmageUrl;
            updatedProject.Description = project.Description;
            updatedProject.ProjectLink = project.ProjectLink;
            db.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}