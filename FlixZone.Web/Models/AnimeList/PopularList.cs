using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FlixZone.Web.Models
{
    public class PopularList
    {
        public List<AnimeProduct> list;

        public PopularList()
        {
            list = new List<AnimeProduct>();
        }
    }
}