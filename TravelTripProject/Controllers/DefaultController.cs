using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TravelTripProject.Models.Classes;

namespace TravelTripProject.Controllers
{
    public class DefaultController : Controller
    {
        // GET: Default
        TravelTripContext context = new TravelTripContext();
        public ActionResult Index()
        {
            var result = context.Blogs.ToList();
            return View(result);
        }

        public ActionResult About()
        {
            return View();
        }

        public PartialViewResult Partial1()
        {
            var result = context.Blogs.OrderByDescending(x => x.Id).Take(2).ToList();
            return PartialView(result);
        }
        public PartialViewResult Partial2()
        {
            var result = context.Blogs.Where(x => x.Id == 1).ToList();
            return PartialView(result);
        }
        public PartialViewResult Partial3()
        {
            var result = context.Blogs.Take(10).ToList();
            return PartialView(result);
        }
        public PartialViewResult Partial4()
        {
            var result = context.Blogs.Take(3).ToList();
            return PartialView(result);
        }
        public PartialViewResult Partial5()
        {
            var result = context.Blogs.Take(3).OrderByDescending(x => x.Id).ToList();
            return PartialView(result);
        }
    }
}