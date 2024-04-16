using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FlixZone.Web.Models
{
    public class AnimeProduct
    {
        public string Name { get; set; }
        public string Genre { get; set; }
        public string ImageUrl { get; set; }
        public string Class_Col {  get; set; }
        public int Comment_counter {  get; set; }
        public int View_counter { get; set; }
        public string Ep {  get; set; }
        public string Description { get; set; }
    }
}