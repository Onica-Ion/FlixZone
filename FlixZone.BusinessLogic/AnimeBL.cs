using FlixZone.BusinessLogic.Core;
using FlixZone.BusinessLogic.Interface;
using FlixZone.Domain.Entities.Anime;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlixZone.BusinessLogic
{
    internal class AnimeBL : AnimeApi , IAnime
    {
        public Comment AddComment(int animeId, string content, int userId)
        {
            return AddCommentToDb(animeId, content, userId);
        }

        public AnimeList GetAnimeById(int userId)
        {
            return GetAnimeByIdFromDb(userId);
        }

        public List<Comment> GetAnimeComments()
        {
            return GetAnimeCommentFromDb();
        }

        public List<AnimeList> GetAnimeLists()
        {
            return GetAllAnimeFromDb();
        }

        public List<Reviews> GetReviewList()
        {
            return GetReviewListFromDb();
        }

        public bool Increment(int id)
        {
            return Increments(id);
        }
    }
}
