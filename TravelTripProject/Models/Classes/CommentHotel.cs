using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace TravelTripProject.Models.Classes
{
    public class CommentHotel
    {
        [Key]
        public int Id { get; set; }
        public string UserName { get; set; }
        public string Mail { get; set; }
        public string Comment { get; set; }
        public int HotelId { get; set; }
        public virtual Hotel Hotel { get; set; }
        //Bir yorum sadece bir otel için geçerli olacak.(Id'den dolayı.)
    }
}