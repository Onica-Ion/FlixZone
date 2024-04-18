using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FlixZone.Web.Models
{
    public class LiveList
    {
        public List<AnimeProduct> list;

        public LiveList()
        {
            list = new List<AnimeProduct>();
        }
    }
}