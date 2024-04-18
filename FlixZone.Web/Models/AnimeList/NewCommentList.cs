using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FlixZone.Web.Models
{
    public class NewCommentList
    {
        public List<AnimeProduct> list;

        public NewCommentList()
        {
            list = new List<AnimeProduct>();
        }
    }
}