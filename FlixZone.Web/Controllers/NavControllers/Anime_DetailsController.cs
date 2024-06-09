using FlixZone.BusinessLogic.Interface;
using FlixZone.BusinessLogic;
using FlixZone.Web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using FlixZone.Domain.Entities.Anime;
using FlixZone.BusinessLogic.Core;
using FlixZone.Web.Extension;
using FlixZone.Domain.Entities.User;
using System.Security.Cryptography;
using FlixZone.BusinessLogic.DBContext;
using System.Data.Entity;

namespace FlixZone.Web.Controllers.NavControllers
{
    public class Anime_DetailsController : BaseController
    {
        private readonly IAnime _anime;
        private readonly ISession _session;

        public Anime_DetailsController()
        {
            var bl = new BussinesLogic();
            _anime = bl.GetAnimeBL();
            _session = bl.GetSessionBL();
        }

        // GET: Anime_Details
        public ActionResult Index(int id)
        {
            SessionStatus();
            if ((string)System.Web.HttpContext.Current.Session["LoginStatus"] != "login")
            {
                return RedirectToAction("Index", "Login");
            }

            _anime.Increment(id);

            var user = System.Web.HttpContext.Current.GetMySessionObject();
            UserData u = new UserData
            {
                Username = user.Username,
                User_Id = user.Id,
            };

            var users = _session.GetUsers();

            var usersList = users.Select(a => new UserLogin
            {
                Id = a.Id,
                Username = a.Username,

            }).ToList();

            var animeById = _anime.GetAnimeById(id);

            var animeByIdView = new AnimeData
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
                Anime_Poster = animeById.Anime_Poster,
                Anime_Video = animeById.Anime_Video,
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
                Anime_Poster = a.Anime_Poster,
                Anime_Video = a.Anime_Video,
            }).ToList();

            var commentList = _anime.GetAnimeComments();

            var animeCommentList = commentList.Select(a => new Comments
            {
                Comment_Id = a.Comment_Id,
                Content = a.Content,
                Comment_Date = a.Comment_Date,
                Anime_Id = a.Anime_Id,
                User_id = a.User_id
            }).ToList();

            var review = _anime.GetReviewList();

            var reviewList = review.Select(a => new Review
            {
                Review_Id = a.Review_Id,
                Rating = a.Rating,
                Review_Date = a.Review_Date,
                Anime_Id = a.Anime_Id,
                User_id = a.User_id
            }).ToList();

            var model = new CombinedModel
            {
                AnimeDetail = animeByIdView,
                AnimeList = animeListView,
                User = u,
                Users = usersList,
                Comment = animeCommentList,
                Review = reviewList
            };

            return View(model);
        }
        [HttpPost]
        public ActionResult AddComment(int animeId, string content, int userId)
        {
            _anime.AddComment(animeId, content, userId);
            return RedirectToAction("Index", new { id = animeId });
        }
    }
}