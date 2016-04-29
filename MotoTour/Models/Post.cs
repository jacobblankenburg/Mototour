using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MotoTour.Models
{
    public class Post
    {
        [Key]
        public int Id { get; set; }

        public string Message { get; set; }
        public string Username { get; set; }

        [Display(Name = "Start")]
        public string StartLocation { get; set; }

        [Display(Name = "End")]
        public string EndLocation { get; set; }

        public DateTime DatePosted { get; set; }
        public virtual ICollection<Comment> Comments { get; set; }
    }
}