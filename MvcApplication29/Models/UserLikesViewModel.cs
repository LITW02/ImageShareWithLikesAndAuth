using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ImageShare.Data;

namespace MvcApplication29.Models
{
    public class UserLikesViewModel
    {
        public User User { get; set; }
        public IEnumerable<ImageWithLikes> LikedImages { get; set; } 
    }
}