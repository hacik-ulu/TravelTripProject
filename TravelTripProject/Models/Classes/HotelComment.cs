using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TravelTripProject.Models.Classes
{
    // Birden fazla tablodan veri çekme işlemi.
    public class HotelComment
    {
        public IEnumerable<Hotel> Value1 { get; set; }
        public IEnumerable<CommentHotel> Value2 { get; set; }
        public IEnumerable<Hotel> Value3 { get; set; }
    }
}