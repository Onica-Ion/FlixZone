using FlixZone.BusinessLogic;
using FlixZone.BusinessLogic.Interface;
using FlixZone.Web.Extension;
using FlixZone.Web.Models;
using System;
using System.Collections.Generic;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FlixZone.Web.Controllers.NavControllers
{
    public class CategoriesController : BaseController
    {
        private readonly IAnime _anime;

        public CategoriesController()
        {
            var bl = new BussinesLogic();
            _anime = bl.GetAnimeBL();
        }
        // GET: Categories
        public ActionResult Index()
        {
            SessionStatus();
            if ((string)System.Web.HttpContext.Current.Session["LoginStatus"] != "login")
            {
                return RedirectToAction("Index", "Login");
            }

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
                Anime_Poster = a.Anime_Poster,
                Anime_Video = a.Anime_Video,
            }).ToList();

            return View(animeListView);

        }
    }
}