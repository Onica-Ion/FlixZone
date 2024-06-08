using FlixZone.Domain.Entities.Anime;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlixZone.BusinessLogic.Interface
{
    public interface IAnime
    {
        List<AnimeList> GetAnimeLists();
        AnimeList GetAnimeById(int userId);
    }
}
