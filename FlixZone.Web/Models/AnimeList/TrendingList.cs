using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FlixZone.Web.Models
{
    public class TrendingList
    {
        public List<AnimeProduct> list;

        public TrendingList()
        {
            list = new List<AnimeProduct>();
        }
    }
}