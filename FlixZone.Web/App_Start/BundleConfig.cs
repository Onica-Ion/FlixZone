using System;
using System.Collections.Generic;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Reflection.Emit;
using System.Web;
using System.Web.Optimization;
using System.Web.UI.WebControls;

namespace FlixZone.Web
{
     public class BundleConfig
     {
          public static void RegisterBundles(BundleCollection bundles)
          {
               bundles.IgnoreList.Clear();

               //Bootstrap style
               bundles.Add(new StyleBundle("~/bundles/boostrap.min/css").Include(
                    "~/Content/css/bootstrap.min.css", new CssRewriteUrlTransform()));

               bundles.Add(new StyleBundle("~/bundles/font-awesome/css").Include(
                    "~/Content/css/font-awesome.min.css", new CssRewriteUrlTransform()));

               bundles.Add(new StyleBundle("~/bundles/elegant-icons/css").Include(
                    "~/Content/css/elegant-icons.css", new CssRewriteUrlTransform()));

               bundles.Add(new StyleBundle("~/bundles/plyr/css").Include(
                    "~/Content/css/plyr.css", new CssRewriteUrlTransform()));

               bundles.Add(new StyleBundle("~/bundles/nice-select/css").Include(
                    "~/Content/css/nice-select.css", new CssRewriteUrlTransform()));

               bundles.Add(new StyleBundle("~/bundles/owl.carousel.min/css").Include(
                    "~/Content/css/owl.carousel.min.css", new CssRewriteUrlTransform()));

               bundles.Add(new StyleBundle("~/bundles/slicknav.min/css").Include(
                    "~/Content/css/slicknav.min.css", new CssRewriteUrlTransform()));

               bundles.Add(new StyleBundle("~/bundles/style/css").Include(
                    "~/Content/css/style.css", new CssRewriteUrlTransform()));

               //Bootstrap 
               bundles.Add(new ScriptBundle("~/bundles/jquery/js").Include(
                    "~/Scripts/js/jquery-3.3.1.min.js"));

               bundles.Add(new ScriptBundle("~/bundles/bootstrap/js").Include(
                    "~/Scripts/js/bootstrap.min.js"));

               bundles.Add(new ScriptBundle("~/bundles/player/js").Include(
                    "~/Scripts/js/player.js"));

               bundles.Add(new ScriptBundle("~/bundles/jquery.nice/js").Include(
                    "~/Scripts/js/jquery.nice-select.min.js"));

               bundles.Add(new ScriptBundle("~/bundles/mixitup/js").Include(
                    "~/Scripts/js/mixitup.min.js"));

               bundles.Add(new ScriptBundle("~/bundles/jquery.slicknav/js").Include(
                    "~/Scripts/js/jquery.slicknav.js"));

               bundles.Add(new ScriptBundle("~/bundles/owl.carousel/js").Include(
                    "~/Scripts/js/owl.carousel.min.js"));

               bundles.Add(new ScriptBundle("~/bundles/main/js").Include(
                    "~/Scripts/js/main.js"));
          }
     }
}