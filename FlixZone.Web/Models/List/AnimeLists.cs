using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FlixZone.Web.Models
{
     public class AnimeLists
     {
          public List<AnimeProduct> list;

        public AnimeLists()
        {
            list = new List<AnimeProduct>();
        }
    }
}