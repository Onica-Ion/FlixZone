using FlixZone.Domain.Entities.Anime;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace FlixZone.Web.Models
{
    public class Review
    {
        public int Review_Id { get; set; }
        public float Rating { get; set; }
        public string Review_Date { get; set; }
        public int Anime_Id { get; set; }
        public int User_id { get; set; }
    }
}