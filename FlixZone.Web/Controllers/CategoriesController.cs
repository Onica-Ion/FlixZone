using FlixZone.Web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FlixZone.Web.Controllers
{
    public class CategoriesController : Controller
    {
        // GET: Categories
        public ActionResult Index()
        {
            TopViewList topViewList = new TopViewList();
            NewCommentList newCommentList = new NewCommentList();

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
                TopViewList = topViewList,
                NewCommentList = newCommentList
            };

            return View(combinedModel);
        }
    }
}