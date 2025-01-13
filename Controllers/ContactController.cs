using AcunMedyaPortfolioProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AcunMedyaPortfolioProject.Controllers
{
    public class ContactController : Controller
    {
        PortfolioDBEntities2 db = new PortfolioDBEntities2();

        public ActionResult ContactList()
        {
            var concactList = db.Contacts.ToList();
            return View(concactList);
        }
        [HttpGet]
        public ActionResult CreateContact()
        {
            return View();
        }
        [HttpPost]
        public ActionResult CreateContact(Contact contact)
        {
            db.Contacts.Add(contact);
            db.SaveChanges();
            return RedirectToAction("ContactList");
        }
        public ActionResult DeleteContact(int id)
        {
            var contact = db.Contacts.Find(id);
            db.Contacts.Remove(contact);
            db.SaveChanges();
            return RedirectToAction("ContactList");
        }
        [HttpGet]
        public ActionResult UpdateContact(int id)
        {
            var contact = db.Contacts.Find(id);
            return View(contact);
        }
        [HttpPost]
        public ActionResult UpdateContact(Contact contact)
        {
            var updatedContact = db.Contacts.Find(contact.Id);
            updatedContact.Phone = contact.Phone;
            updatedContact.MailAdress = contact.MailAdress;
            updatedContact.Adress = contact.Adress;
            db.SaveChanges();
            return RedirectToAction("ContactList");
        }

    }
}