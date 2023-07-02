using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TravelTripProject.Models.Classes;

namespace TravelTripProject.Controllers
{
    public class BlogController : Controller
    {
        // GET: Blog
        TravelTripContext context = new TravelTripContext();
        BlogComment comment = new BlogComment();
        public ActionResult Index()
        {
            //var result = context.Blogs.ToList();
            comment.Value1 = context.Blogs.ToList();
            comment.Value3 = context.Blogs.OrderByDescending(x => x.Id).Take(3).ToList();  // son bloglar gösterilecek.

            comment.Value2 = context.Comments.OrderByDescending(c => c.Id).Take(5).ToList();
            return View(comment);
        }
        public ActionResult BlogDetail(int? id)
        {
            //var findBlog = context.Blogs.Where(x => x.Id == id).ToList();
            var blogCommentDetail = new BlogComment();
            comment.Value1 = context.Blogs.Where(x => x.Id == id).ToList(); // Blogları filtreliyoruz.
            comment.Value2 = context.Comments.Where(x => x.BlogId == id).ToList(); //Yorumları filtreliyoruz.

            blogCommentDetail.Value3 = context.Blogs.OrderByDescending(x => x.Id).Take(3).ToList();
            return View(comment); // Yorum ve BlogIdye göre her blogun altına ilgili yorumlar geliyor.
        }

        [HttpGet]
        public PartialViewResult DoComment(int? id)
        {
            ViewBag.result = id;
            return PartialView();
        }

        [HttpPost]
        public PartialViewResult DoComment(Comment y)
        {
            context.Comments.Add(y);
            context.SaveChanges();
            return PartialView();
        }

    }

}
