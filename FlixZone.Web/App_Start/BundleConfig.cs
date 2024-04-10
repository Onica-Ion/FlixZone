using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Optimization;

namespace FlixZone.Web
{
     public class BundleConfig
     {
          public static void RegisterBundles(BundleCollection bundles)
          {
               //Bootstrap style
               bundles.Add(new StyleBundle("~/bundles/boostrap/css").Include(
                    "~/Content/css/bootstrap.min.css",
                    "~/Content/css/font-awesome.min.css",
                    "~/Content/css/elegant-icons.css",
                    "~/Content/css/plyr.css",
                    "~/Content/css/nice-select.css",
                    "~/Content/css/owl.carousel.min.css",
                    "~/Content/css/slicknav.min.css",
                    "~/Content/css/style.css"));
               //Bootstrap 
               bundles.Add(new ScriptBundle("~/bundles/boostrap/js").Include(
                    "~/Scripts/js/jquery-3.3.1.min.js",
                    "~/Scripts/js/bootstrap.min.js",
                    "~/Scripts/js/player.js",
                    "~/Scripts/js/jquery.nice-select.min.js",
                    "~/Scripts/js/mixitup.min.js",
                    "~/Scripts/js/jquery.slicknav.js",
                    "~/Scripts/js/owl.carousel.min.js",
                    "~/Scripts/js/main.js"));
          }
     }
}