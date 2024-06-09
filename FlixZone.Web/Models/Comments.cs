using FlixZone.Domain.Entities.Anime;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace FlixZone.Web.Models
{
    public class Comments
    {
        public int Comment_Id { get; set; }
        public string Content { get; set; }

        public string Comment_Date { get; set; }

        public int Anime_Id { get; set; }

        public int User_id { get; set; }
    }
}