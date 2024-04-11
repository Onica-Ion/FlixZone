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
               AnimePack firstAnim = new AnimePack
               {
                    Description="Cel mai bun anime vreodată.",
                    Name="Naruto",
                    Genre="Hentai",
               };
               list1.list.Add(firstAnim);
               
               AnimePack secondAnim = new AnimePack
               {
                    Description="Cel mai rău anime vreodată.",
                    Name="Boruto",
                    Genre="Loli"
               };
               list1.list.Add(secondAnim);


            return View(list1);
        }
    }
}