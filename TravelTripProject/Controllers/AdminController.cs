using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Xml.Linq;
using TravelTripProject.Models.Classes;

namespace TravelTripProject.Controllers
{
    public class AdminController : Controller
    {
        TravelTripContext context = new TravelTripContext();
        [Authorize]
        public ActionResult Index()
        {
            var result = context.Blogs.ToList();
            return View(result);
        }

        [HttpGet]
        public ActionResult NewBlog()
        {
            return View();
        }

        [HttpPost]
        public ActionResult NewBlog(Blog blog)
        {
            context.Blogs.Add(blog);
            context.SaveChanges();
            return RedirectToAction("Index");
        }

        public ActionResult DeleteBlog(int id)
        {
            var deletedBlog = context.Blogs.Find(id);
            context.Blogs.Remove(deletedBlog);
            context.SaveChanges();
            return RedirectToAction("Index");
        }

        public ActionResult TakeBlog(int? id)
        {
            var findToBlog = context.Blogs.Find(id);
            return View("TakeBlog", findToBlog);
        }

        public ActionResult UpdateBlog(Blog blog)
        {
            var updatedBlog = context.Blogs.Find(blog.Id);
            updatedBlog.Title = blog.Title;
            updatedBlog.Description = blog.Description;
            updatedBlog.Date = blog.Date;
            updatedBlog.BlogImage = blog.BlogImage;
            context.SaveChanges();
            return RedirectToAction("Index");
        }

        public ActionResult CommentList()
        {
            var comments = context.Comments.ToList();
            return View(comments);
        }

        public ActionResult DeleteComment(int id)
        {
            var deletedComment = context.Comments.Find(id);
            context.Comments.Remove(deletedComment);
            context.SaveChanges();
            return RedirectToAction("Index");
        }

        public ActionResult TakeComment(int? id)
        {
            var comment = context.Comments.Find(id);
            return View("TakeComment", comment);
        }

        public ActionResult UpdateComment(Comment comment)
        {
            var updatedBlog = context.Comments.Find(comment.Id);
            updatedBlog.UserName = comment.UserName;
            updatedBlog.Mail = comment.Mail;
            updatedBlog.UserComment = comment.UserComment;
            context.SaveChanges();
            return RedirectToAction("CommentList");
        }

        //---------- Otel Metodları ------------------

        public ActionResult HotelIndex()
        {
            var result = context.Hotels.ToList();
            return View(result);
        }

        [HttpGet]
        public ActionResult NewHotel()
        {
            return View();
        }

        [HttpPost]
        public ActionResult NewHotel(Hotel hotel)
        {
            context.Hotels.Add(hotel);
            context.SaveChanges();
            return RedirectToAction("HotelIndex");
        }

        public ActionResult DeleteHotel(int? id)
        {
            var deletedHotel = context.Hotels.Find(id);
            context.Hotels.Remove(deletedHotel);
            context.SaveChanges();
            return RedirectToAction("HotelIndex");
        }

        public ActionResult TakeHotel(int? id)
        {
            var findToHotel = context.Hotels.Find(id);
            return View("TakeHotel", findToHotel);
        }

        public ActionResult UpdateHotel(Hotel hotel)
        {
            var updatedHotel = context.Hotels.Find(hotel.Id);
            updatedHotel.Name = hotel.Name;
            updatedHotel.Description = hotel.Description;
            updatedHotel.AveragePrice = hotel.AveragePrice;
            updatedHotel.PhotoUrl = hotel.PhotoUrl;
            context.SaveChanges();
            return RedirectToAction("HotelIndex");
        }

        public ActionResult HotelCommentList()
        {
            var hotelComments = context.CommentHotels.ToList();
            return View(hotelComments);
        }

        public ActionResult DeleteHotelComment(int? id)
        {
            var deletedHotelComment = context.CommentHotels.Find(id);
            context.CommentHotels.Remove(deletedHotelComment);
            context.SaveChanges();
            return RedirectToAction("HotelCommentList");
        }

        public ActionResult TakeHotelComment(int? id)
        {
            var commentHotel = context.CommentHotels.Find(id);
            return View("TakeHotelComment", commentHotel);
        }

        public ActionResult UpdateHotelComment(CommentHotel commentHotel)
        {
            var updatedHotel = context.CommentHotels.Find(commentHotel.Id);
            updatedHotel.UserName = commentHotel.UserName;
            updatedHotel.Mail = commentHotel.Mail;
            updatedHotel.Comment = commentHotel.Comment;
            context.SaveChanges();
            return RedirectToAction("HotelCommentList");
        }

        //-------------- İletişim Kısmı ------------
        public ActionResult ContactIndex()
        {
            var results = context.Contacts.ToList();
            return View(results);
        }

        public ActionResult DeleteWebsiteComment(int? id)
        {
            var deletedWebsiteComment = context.Contacts.Find(id);
            context.Contacts.Remove(deletedWebsiteComment);
            context.SaveChanges();
            return RedirectToAction("ContactIndex");
        }

        







    }
}

