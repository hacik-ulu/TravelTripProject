using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;
using TravelTripProject.Models.Classes;

namespace TravelTripProject.Controllers
{
    public class LoginController : Controller
    {
        // GET: Login
        TravelTripContext context = new TravelTripContext();
        public ActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Login(Admin admin)
        {
            var informations = context.Admins.FirstOrDefault(x => x.User == admin.User && x.Password == admin.Password);
            if (informations != null) 
            {
                FormsAuthentication.SetAuthCookie(informations.User, false);
                Session["User"] = informations.User.ToString();
                return RedirectToAction("Index","Admin");
            }
            else
            {
                return View();
            }
        }
    }
}