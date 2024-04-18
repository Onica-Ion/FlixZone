using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FlixZone.Web.Models
{
     public class AnimeList
     {
          public List<AnimeProduct> list;

        public AnimeList()
        {
            list = new List<AnimeProduct>();
        }
    }
}