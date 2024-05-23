using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FlixZone.Web.Models
{
    public class CombinedModel
    {
        public AnimeList AnimeList { get; set; }
        public TrendingList TrendingList { get; set; }
        public PopularList PopularList { get; set; }
        public RecentList RecentList { get; set; }
        public LiveList LiveList { get; set; }
        public TopViewList TopViewList { get; set; }
        public NewCommentList NewCommentList { get; set; }
        public UserData UserData { get; set; }
    }
}