using FlixZone.Web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FlixZone.Web.Controllers
{
    public class Anime_DetailsController : Controller
    {
        // GET: Anime_Details
        public ActionResult Index()
        {
            TopViewList topViewList = new TopViewList();

            //TopViewList
            AnimeProduct firstTopView = new AnimeProduct
            {
                ImageUrl = "Content/img/hero/villainess-level-99.jpg",
                Name = "Villainess Level 99",
                View_counter = 1000,
                Class_Col = "product__sidebar__view__item set-bg",//day,years top view
                Ep = "1 / 19"
            };
            topViewList.list.Add(firstTopView);

            AnimeProduct secondTopView = new AnimeProduct
            {
                ImageUrl = "Content/img/hero/villainess-level-99.jpg",
                Name = "Villainess Level 99",
                View_counter = 1000,
                Class_Col = "product__sidebar__view__item set-bg",//month,week top view
                Ep = "2 / 19"
            };
            topViewList.list.Add(secondTopView);

            AnimeProduct thridTopView = new AnimeProduct
            {
                ImageUrl = "Content/img/hero/villainess-level-99.jpg",
                Name = "Villainess Level 99",
                View_counter = 1000,
                Class_Col = "product__sidebar__view__item set-bg",//week,years top view
                Ep = "3 / 19"
            };
            topViewList.list.Add(thridTopView);

            AnimeProduct fourthTopView = new AnimeProduct
            {
                ImageUrl = "Content/img/hero/villainess-level-99.jpg",
                Name = "Villainess Level 99",
                View_counter = 1000,
                Class_Col = "product__sidebar__view__item set-bg",//years,month top view
                Ep = "4 / 19"
            };
            topViewList.list.Add(fourthTopView);

            CombinedModel combinedModel = new CombinedModel
            {
                TopViewList = topViewList
            };

            return View(combinedModel);
        }
    }
}