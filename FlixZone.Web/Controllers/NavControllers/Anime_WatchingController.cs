using FlixZone.BusinessLogic;
using FlixZone.BusinessLogic.Interface;
using FlixZone.Domain.Entities.Anime;
using FlixZone.Web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FlixZone.Web.Controllers.NavControllers
{
    public class Anime_WatchingController : BaseController
    {
        private readonly IAnime _anime;

        public Anime_WatchingController()
        {
            var bl = new BussinesLogic();
            _anime = bl.GetAnimeBL();
        }

        // GET: Anime_Watchig
        public ActionResult Index(int id)
        {
            SessionStatus();
            if ((string)System.Web.HttpContext.Current.Session["LoginStatus"] != "login")
            {
                return RedirectToAction("Index", "Login");
            }
            var animeById = _anime.GetAnimeById(id);

            var animeListView = new AnimeData
            {
                Anime_Id = animeById.Anime_Id,
                Anime_Name = animeById.Anime_Name,
                Anime_Author = animeById.Anime_Author,
                Anime_Description = animeById.Anime_Description,
                Anime_Type = animeById.Anime_Type,
                Anime_Studios = animeById.Anime_Studios,
                Anime_Date = animeById.Anime_Date,
                Anime_Status = animeById.Anime_Status,
                Anime_Genre = animeById.Anime_Genre,
                Anime_Views = animeById.Anime_Views,
                Anime_Comment = animeById.Anime_Comment,
                Anime_Image = animeById.Anime_Image,
                Anime_Video = animeById.Anime_Video
            };

            return View(animeListView);
        }
    }
}