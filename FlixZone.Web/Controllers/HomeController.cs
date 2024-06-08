using FlixZone.BusinessLogic;
using FlixZone.BusinessLogic.Interface;
using FlixZone.Domain.Entities.User;
using FlixZone.Domain.Entities.User.DBModel;
using FlixZone.Web.Extension;
using FlixZone.Web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;


namespace FlixZone.Web.Controllers
{
    public class HomeController : BaseController
    {

        private readonly IAnime _anime;

        public HomeController()
        {
            var bl = new BussinesLogic();
            _anime = bl.GetAnimeBL();
        }

        // GET: Home
        public ActionResult Index()
        {
            SessionStatus();
            if ((string)System.Web.HttpContext.Current.Session["LoginStatus"] != "login")
            {
                return RedirectToAction("Index", "Login");
            }

            var user = System.Web.HttpContext.Current.GetMySessionObject();
            UserData u = new UserData
            {
                Username = user.Username,
            };
            
            var animeList = _anime.GetAnimeLists();

            var animeListView = animeList.Select(a => new AnimeData
            {
                Anime_Id = a.Anime_Id,
                Anime_Name = a.Anime_Name,
                Anime_Author = a.Anime_Author,
                Anime_Description = a.Anime_Description,
                Anime_Type = a.Anime_Type,
                Anime_Studios = a.Anime_Studios,
                Anime_Date = a.Anime_Date,
                Anime_Status = a.Anime_Status,
                Anime_Genre = a.Anime_Genre,
                Anime_Views = a.Anime_Views,
                Anime_Comment = a.Anime_Comment,
                Anime_Image = a.Anime_Image,
                Anime_Video = a.Anime_Video
            }).ToList();

            return View(animeListView);

            /*[UserMode(URole.User)]*/

            /*return View(u);*/

            {
                AnimeLists list = new AnimeLists();
                TrendingList trendingList = new TrendingList();
                PopularList popularList = new PopularList();
                RecentList recentList = new RecentList();
                LiveList liveList = new LiveList();
                TopViewList topViewList = new TopViewList();
                NewCommentList newCommentList = new NewCommentList();

                //SlideBar
                AnimeProduct firstAnim = new AnimeProduct
                {
                    ImageUrl = "Content/img/hero/the_unwanted_undead_aventurer.jpg",
                    Description = "Is a Japanese light novel series written by Yū Okano and illustrated by Jaian",
                    Name = "The Unwanted Undead Adventurer",
                    Genre = "Dark fantasy",
                };
                list.list.Add(firstAnim);

                AnimeProduct secondAnim = new AnimeProduct
                {
                    ImageUrl = "Content/img/hero/SoloLeveling.jpg",
                    Description = "Is a South Korean web novel written by Chugong",
                    Name = "Solo Leveling",
                    Genre = "Action, fantasy"
                };
                list.list.Add(secondAnim);

                AnimeProduct thirdAnim = new AnimeProduct
                {
                    ImageUrl = "Content/img/hero/villainess-level-99.jpg",
                    Description = "Is a Japanese light novel series written by Satori Tanabata with illustrations by Tea",
                    Name = "Villainess Level 99",
                    Genre = "Fantasy, isekai"
                };
                list.list.Add(thirdAnim);

                //TrendingList
                AnimeProduct firstTrending = new AnimeProduct
                {
                    ImageUrl = "Content/img/hero/villainess-level-99.jpg",
                    Name = "Villainess Level 99",
                    Genre = "Fantasy, isekai",
                    Comment_counter = 90,
                    View_counter = 1000,
                    Ep = "19 / 19"
                };
                trendingList.list.Add(firstTrending);

                //PopularList
                AnimeProduct firstPopular = new AnimeProduct
                {
                    ImageUrl = "Content/img/hero/villainess-level-99.jpg",
                    Name = "Villainess Level 99",
                    Genre = "Fantasy, isekai",
                    Comment_counter = 90,
                    View_counter = 1000,
                    Ep = "19 / 19"
                };
                popularList.list.Add(firstPopular);

                //RecentList
                AnimeProduct firstRecent = new AnimeProduct
                {
                    ImageUrl = "Content/img/hero/villainess-level-99.jpg",
                    Name = "Villainess Level 99",
                    Genre = "Fantasy, isekai",
                    Comment_counter = 90,
                    View_counter = 1000,
                    Ep = "19 / 19"
                };
                recentList.list.Add(firstRecent);

                //LiveList
                AnimeProduct firstLive = new AnimeProduct
                {
                    ImageUrl = "Content/img/hero/villainess-level-99.jpg",
                    Name = "Villainess Level 99",
                    Genre = "Fantasy, isekai",
                    Comment_counter = 90,
                    View_counter = 1000,
                    Ep = "19 / 19"
                };
                liveList.list.Add(firstLive);

                //TopViewList
                AnimeProduct firstTopView = new AnimeProduct
                {
                    ImageUrl = "Content/img/hero/villainess-level-99.jpg",
                    Name = "Villainess Level 99",
                    View_counter = 1000,
                    Class_Col = "product__sidebar__view__item set-bg mix day years",//day,years top view
                    Ep = "1 / 19"
                };
                topViewList.list.Add(firstTopView);

                AnimeProduct secondTopView = new AnimeProduct
                {
                    ImageUrl = "Content/img/hero/villainess-level-99.jpg",
                    Name = "Villainess Level 99",
                    View_counter = 1000,
                    Class_Col = "product__sidebar__view__item set-bg mix month week",//month,week top view
                    Ep = "2 / 19"
                };
                topViewList.list.Add(secondTopView);

                AnimeProduct thridTopView = new AnimeProduct
                {
                    ImageUrl = "Content/img/hero/villainess-level-99.jpg",
                    Name = "Villainess Level 99",
                    View_counter = 1000,
                    Class_Col = "product__sidebar__view__item set-bg mix week years",//week,years top view
                    Ep = "3 / 19"
                };
                topViewList.list.Add(thridTopView);

                AnimeProduct fourthTopView = new AnimeProduct
                {
                    ImageUrl = "Content/img/hero/villainess-level-99.jpg",
                    Name = "Villainess Level 99",
                    View_counter = 1000,
                    Class_Col = "product__sidebar__view__item set-bg mix years month",//years,month top view
                    Ep = "4 / 19"
                };
                topViewList.list.Add(fourthTopView);

                //NewCommentList
                AnimeProduct firstNewComm = new AnimeProduct
                {
                    ImageUrl = "Content/img/sidebar/comment-2.jpg",
                    Name = "Shirogane Tamashii hen Kouhan sen",
                    View_counter = 1000,
                };
                newCommentList.list.Add(firstNewComm);

                CombinedModel combinedModel = new CombinedModel
                {
                    AnimeList = list,
                    TrendingList = trendingList,
                    PopularList = popularList,
                    RecentList = recentList,
                    LiveList = liveList,
                    TopViewList = topViewList,
                    NewCommentList = newCommentList,
                    UserData = u
                };

                return View(combinedModel);
            }
        }
    }
}