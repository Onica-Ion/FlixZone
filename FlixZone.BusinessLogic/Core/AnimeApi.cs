using FlixZone.BusinessLogic.DBContext;
using FlixZone.Domain.Entities.Anime;
using FlixZone.Domain.Entities.Responce;
using FlixZone.Domain.Entities.User;
using FlixZone.Helpers;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace FlixZone.BusinessLogic.Core
{
    public class AnimeApi
    {
        internal List<Reviews> GetReviewListFromDb()
        {
            var reviewEntities = new List<Reviews>();
            using (var db = new UserContext())
            {
                reviewEntities = db.Reviews
                                   .ToList();
            }

            return reviewEntities;
        }
        internal List<AnimeList> GetAllAnimeFromDb()
        {
            var animeEntities = new List<AnimeList>();
            using (var db = new UserContext())
            {
                animeEntities = db.AnimeList
                                  .OrderBy(a => a.Anime_Views)
                                  .ToList();
            }

            return animeEntities;
        }
        internal AnimeList GetAnimeByIdFromDb(int Anime_Id)
        {
            if(Anime_Id <= 0) return null;

            var animeEntities = new AnimeList();
            using (var db = new UserContext())
            {
                animeEntities = db.AnimeList
                                  .FirstOrDefault(ua => ua.Anime_Id == Anime_Id);

            }
            return animeEntities;
        }
        internal List<Comment> GetAnimeCommentFromDb()
        {
            var commentEntities = new List<Comment>();
            using (var db = new UserContext())
            {
                commentEntities = db.Comments
                                    .OrderBy(a => a.Comment_Id)
                                    .ToList();
            }
            return commentEntities;
        }
        internal Comment AddCommentToDb(int animeId, string content, int userId)
        {

            using (var db = new UserContext())
            {
                var comment = new Comment
                {
                    Anime_Id = animeId,
                    Content = content,
                    Comment_Date = DateTime.Now.ToString("yyyy-MM-dd"),
                    User_id = userId
                };

                db.Comments.Add(comment);
                db.SaveChanges();

                AnimeList status;
                using (var _userContext = new UserContext())
                {
                    status = _userContext.AnimeList.Where(u => u.Anime_Id == animeId).FirstOrDefault();
                }

                using (var todo = new UserContext())
                {
                    status.Anime_Comment = status.Anime_Comment + 1;
                    todo.Entry(status).State = EntityState.Modified;
                    todo.SaveChanges();
                }

                return comment;
            }
        }
        internal bool Increments(int id)
        {
            AnimeList status;
            using (var _userContext = new UserContext())
            {
                status = _userContext.AnimeList.Where(u => u.Anime_Id == id).FirstOrDefault();
            }

            using (var todo = new UserContext())
            {
                status.Anime_Views = status.Anime_Views + 1;
                todo.Entry(status).State = EntityState.Modified;
                todo.SaveChanges();
            }

            return true;
        }
    }
}
