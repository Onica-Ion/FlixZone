using FlixZone.Web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FlixZone.Web.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
               AnimeList list1 = new AnimeList();
               TrendingList list2 = new TrendingList();
               PopularList list3 = new PopularList();
               RecentList list4 = new RecentList();
               LiveList list5 = new LiveList();
                AnimeProduct firstAnim = new AnimeProduct
                {
                    ImageUrl= "Content/img/hero/the_unwanted_undead_aventurer.jpg",
                    Description= "Is a Japanese light novel series written by Yū Okano and illustrated by Jaian",
                    Name= "The Unwanted Undead Adventurer",
                    Genre= "Dark fantasy",
               };
               list1.list1.Add(firstAnim);

                AnimeProduct secondAnim = new AnimeProduct
                {
                    ImageUrl = "Content/img/hero/SoloLeveling.jpg",
                    Description = "Is a South Korean web novel written by Chugong",
                    Name= "Solo Leveling",
                    Genre= "Action, fantasy"
               };
               list1.list1.Add(secondAnim);

                AnimeProduct thirdAnim = new AnimeProduct
                {
                    ImageUrl = "Content/img/hero/villainess-level-99.jpg",
                    Description = "Is a Japanese light novel series written by Satori Tanabata with illustrations by Tea",
                    Name= "Villainess Level 99",
                    Genre= "Fantasy, isekai"
               };
               list1.list1.Add(thirdAnim);

               AnimeProduct firstTrending = new AnimeProduct
               {
                    Class_Col= "col-lg-4 col-md-6 col-sm-6",
                    ImageUrl = "Content/img/hero/villainess-level-99.jpg",
                    Name= "Villainess Level 99",
                    Genre= "Fantasy, isekai",
                    Comment_counter= 90,
                    View_counter= 1000,
                    Ep="19 / 19"
               };
               list2.list2.Add(firstTrending);

               AnimeProduct firstPopular = new AnimeProduct
               {
                    Class_Col= "col-lg-4 col-md-6 col-sm-6",
                    ImageUrl = "Content/img/hero/villainess-level-99.jpg",
                    Name= "Villainess Level 99",
                    Genre= "Fantasy, isekai",
                    Comment_counter= 90,
                    View_counter= 1000,
                    Ep="19 / 19"
               };
               list3.list3.Add(firstPopular);

               AnimeProduct firstRecent = new AnimeProduct
               {
                    Class_Col= "col-lg-4 col-md-6 col-sm-6",
                    ImageUrl = "Content/img/hero/villainess-level-99.jpg",
                    Name= "Villainess Level 99",
                    Genre= "Fantasy, isekai",
                    Comment_counter= 90,
                    View_counter= 1000,
                    Ep="19 / 19"
               };
               list4.list4.Add(firstRecent);

               AnimeProduct firstLive = new AnimeProduct
               {
                    Class_Col= "col-lg-4 col-md-6 col-sm-6",
                    ImageUrl = "Content/img/hero/villainess-level-99.jpg",
                    Name= "Villainess Level 99",
                    Genre= "Fantasy, isekai",
                    Comment_counter= 90,
                    View_counter= 1000,
                    Ep="19 / 19"
               };
               list5.list5.Add(firstLive);

               CombinedModel combinedModel = new CombinedModel
               {
                AnimeList = list1,
                TrendingList = list2,
                PopularList = list3,
                RecentList = list4,
                LiveList = list5
               };   

            return View(combinedModel);
        }
    }
}