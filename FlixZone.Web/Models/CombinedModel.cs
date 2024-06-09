using FlixZone.Domain.Entities.Anime;
using FlixZone.Domain.Entities.User;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FlixZone.Web.Models
{
    public class CombinedModel
    {
        public AnimeData AnimeDetail { get; set; }
        public List<AnimeData> AnimeList { get; set; }
        public AnimeList Anime { get; set; }
        public IEnumerable<Comment> Comments { get; set; }
        public IEnumerable<Review> Reviews { get; set; }
        public UserData User { get; set; }
        public List<UserLogin> Users { get; set; }
        public List<Comments> Comment { get; set; }
        public List<Review> Review { get; set; }
    }
}