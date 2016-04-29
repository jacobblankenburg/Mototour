using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace MotoTour.Models
{
    public class MessageBoardContext : DbContext
    {
        public MessageBoardContext() : base("DefaultConnection")
        {

        }
        public DbSet<Post> Posts { get; set; }
        public DbSet<Comment> Comments { get; set; }
    }
}