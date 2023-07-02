using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace TravelTripProject.Models.Classes
{
    public class Contact
    {
        [Key]
        public int Id { get; set; }
        public string UserName { get; set; }
        public string Mail { get; set; }
        public string Message { get; set; }
    }
}