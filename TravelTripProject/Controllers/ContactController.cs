using Microsoft.Ajax.Utilities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TravelTripProject.Models.Classes;

namespace TravelTripProject.Controllers
{
    public class ContactController : Controller
    {
        TravelTripContext c = new TravelTripContext();
        // GET: Contact
        public ActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public ActionResult Create()
        {
            return View(new Contact());
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Contact contact)
        {
            if (ModelState.IsValid)
            {
                c.Contacts.Add(contact);
                c.SaveChanges();
                TempData["AlertMessage"] = "Mesajınız Başarıyla Gönderildi!";
                return RedirectToAction("Index");
            }
            return View(contact);
        }
    }
}

// Contact/Index tasarımına bak.
// haritaya bişey yap abi.
// Admin Paneline Contacti ekle.