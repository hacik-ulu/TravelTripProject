using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace TravelTripProject.Models.Classes
{
    public class Hotel
    {
        [Key]
        public int Id { get; set; }
        public string PhotoUrl { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal AveragePrice { get; set; }
        public ICollection<CommentHotel> CommentsHotel { get; set; }
    }
}