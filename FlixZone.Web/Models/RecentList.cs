using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FlixZone.Web.Models
{
    public class RecentList
    {
        public List<AnimeProduct> list4;

        public RecentList()
        {
            list4 = new List<AnimeProduct>();
        }
    }
}