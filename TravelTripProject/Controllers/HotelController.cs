using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace TravelTripProject.Models.Classes
{
    public class HotelController : Controller
    {
        // GET: Hotel
        TravelTripContext context = new TravelTripContext();
        HotelComment hotelComment = new HotelComment();
        public ActionResult Index()
        {
            //var hotels = context.Hotels.ToList();
            hotelComment.Value1 = context.Hotels.ToList();
            hotelComment.Value3 = context.Hotels.OrderByDescending(x=>x.Id).Take(3).ToList();

            hotelComment.Value2 = context.CommentHotels.OrderByDescending(c => c.Id).Take(5).ToList();
            return View(hotelComment);
        }

        public ActionResult HotelDetail(int? id)
        {
            var hotelCommentDetail = new HotelComment();
            hotelCommentDetail.Value1 = context.Hotels.Where(x => x.Id == id).ToList();
            hotelCommentDetail.Value2 = context.CommentHotels.Where(c => c.HotelId == id).OrderByDescending(c => c.Id).Take(5).ToList();

            hotelCommentDetail.Value3 = context.Hotels.OrderByDescending(x => x.Id).Take(3).ToList();
            return View(hotelCommentDetail);
        }


        [HttpGet]
        public PartialViewResult DoCommentHotel(int? id)
        {
            ViewBag.result = id;
            return PartialView();
        }

        [HttpPost]
        public PartialViewResult DoCommentHotel(CommentHotel htl)
        {
            context.CommentHotels.Add(htl);
            context.SaveChanges();
            return PartialView();
        }
    }
}