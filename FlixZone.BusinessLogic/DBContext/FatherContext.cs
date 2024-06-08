using FlixZone.Domain.Entities.Anime;
using FlixZone.Domain.Entities.User;
using FlixZone.Domain.Entities.User.DBModel;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlixZone.BusinessLogic.DBContext
{
    public class FatherContext : DbContext
    {
        public FatherContext() : base("name=flixZone")
        {
        }

        public virtual DbSet<Session> Sessions { get; set; }



        public virtual DbSet<UserLogin> Users { get; set; }



        public virtual DbSet<AnimeList> AnimeList { get; set; }
    }
}
