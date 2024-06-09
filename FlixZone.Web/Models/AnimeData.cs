using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace FlixZone.Web.Models
{
    public class AnimeData
    {
        public int Anime_Id { get; set; }
        public string Anime_Name { get; set; }
        public string Anime_Author { get; set; }
        public string Anime_Description { get; set; }
        public string Anime_Type { get; set; }
        public string Anime_Studios { get; set; }
        public string Anime_Date { get; set; }
        public string Anime_Status { get; set; }
        public string Anime_Genre { get; set; }
        public int Anime_Views { get; set; }
        public int Anime_Comment { get; set; }
        public string Anime_Image { get; set; }
        public string Anime_Poster { get; set; }
        public string Anime_Video { get; set; }

        /*"product__sidebar__view__item set-bg mix day years",//day,years top view
        "product__sidebar__view__item set-bg mix month week",//month,week top view
        "product__sidebar__view__item set-bg mix week years",//week,years top view
        "product__sidebar__view__item set-bg mix years month",//years,month top view*/
    }
}