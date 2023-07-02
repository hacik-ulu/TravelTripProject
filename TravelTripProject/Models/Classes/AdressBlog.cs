using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace TravelTripProject.Models.Classes
{
    public class AdressBlog
    {
        [Key]
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string ExplicitAdress { get; set; }
        public string Mail { get; set; }
        public string ContactNumber { get; set; }
        public string Location { get; set; }
    }
}