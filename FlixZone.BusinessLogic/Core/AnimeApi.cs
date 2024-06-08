using FlixZone.BusinessLogic.DBContext;
using FlixZone.Domain.Entities.Anime;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlixZone.BusinessLogic.Core
{
    public class AnimeApi
    {
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
        internal AnimeList GetAnimeByIdFromDb(int User_Id)
        {
            if(User_Id <= 0) return null;

            var animeEntities = new AnimeList();
            using (var db = new UserContext())
            {

                animeEntities = db.AnimeList
                                  .FirstOrDefault(ua => ua.Anime_Id == User_Id);

            }
            return animeEntities;
        }
    }
}
