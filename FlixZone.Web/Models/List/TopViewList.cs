using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FlixZone.Web.Models
{
    public class TopViewList
    {
        public List<AnimeProduct> list;

        public TopViewList()
        {
            list = new List<AnimeProduct>();
        }
    }
}