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
        public AnimeList GetAnimeById(int userId)
        {
            return GetAnimeByIdFromDb(userId);
        }
        public List<AnimeList> GetAnimeLists()
        {
            return GetAllAnimeFromDb();
        }
    }
}
