using FlixZone.Domain.Entities.Anime;
using FlixZone.Domain.Entities.User;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlixZone.BusinessLogic.DBContext
{
    public class UserContext : DbContext
    {
        public UserContext() :
            base("name=flixZone")
        {
            Database.SetInitializer<UserContext>(null);
        }

        public virtual DbSet<UserLogin> Users { get; set; }



        public virtual DbSet<AnimeList> AnimeList { get; set; }
        public virtual DbSet<Reviews> Reviews { get; set; }
        public virtual DbSet<Comment> Comments { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            // Configurarea relației many-to-one între AnimeList și Comment
            modelBuilder.Entity<Comment>()
                .HasRequired(c => c.Anime)
                .WithMany(a => a.Comments)
                .HasForeignKey(c => c.Anime_Id);

            // Configurarea relației many-to-one între AnimeList și Review
            modelBuilder.Entity<Reviews>()
                .HasRequired(r => r.Anime)
                .WithMany(a => a.Reviews)
                .HasForeignKey(r => r.Anime_Id);

            base.OnModelCreating(modelBuilder);
        }
    }
}
