using AcunMedyaPortfolioProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AcunMedyaPortfolioProject.Controllers
{
    public class SocialMediaController : Controller
    {
        // GET: SocialMedia
        PortfolioDBEntities2 db = new PortfolioDBEntities2();
        public ActionResult SocialMediaList()
        {
            var socialMedia = db.SocialMedias.ToList();
            return View(socialMedia);
        }
        [HttpGet]
        public ActionResult CreateSocialMedia()
        {
            return View();
        }
        [HttpPost]
        public ActionResult CreateSocialMedia(SocialMedia socialMedia)
        {
            db.SocialMedias.Add(socialMedia);
            db.SaveChanges();
            return RedirectToAction("SocialMediaList");
        }
        public ActionResult DeleteSocialMedia(int id)
        {
            var socialMedia = db.SocialMedias.Find(id);
            db.SocialMedias.Remove(socialMedia);
            db.SaveChanges();
            return RedirectToAction("SocialMediaList");
        }
        [HttpGet]
        public ActionResult UpdateSocialMedia(int id)
        {
            var socialMedia = db.SocialMedias.Find(id);
            return View(socialMedia);
        }
        [HttpPost]
        public ActionResult UpdateSocialMedia(SocialMedia socialMedia)
        {
            var updatedSocial = db.SocialMedias.Find(socialMedia.SocialMediaId);
            updatedSocial.Platform = socialMedia.Platform;
            updatedSocial.Link = socialMedia.Link;
            db.SaveChanges();
            return RedirectToAction("SocialMediaList");
        }
    }
}