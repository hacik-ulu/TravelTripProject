﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
namespace TravelTripProject.Models.Classes
{
    public class TravelTripContext : DbContext
    {
        public DbSet<Admin> Admins { get; set; }
        public DbSet<AdressBlog> AdressBlogs { get; set; }
        public DbSet<Blog> Blogs { get; set; }
        public DbSet<About> Abouts { get; set; }
        public DbSet<Comment> Comments { get; set; }
        public DbSet<Contact> Contacts { get; set; }
        public DbSet<Hotel> Hotels { get; set; }
        public DbSet<CommentHotel> CommentHotels { get; set; }
        



    }
}