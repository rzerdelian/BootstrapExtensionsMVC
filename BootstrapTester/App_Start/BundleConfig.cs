using System.Web;
using System.Web.Optimization;

namespace BootstrapTester
{
    public class BundleConfig
    {
        public static void RegisterBundles(BundleCollection bundles)
        {

            bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
                "~/assets/dist/js/bootstrap.min.js" 
                , "~/assets/dist/js/bootstrap-datetimepicker.all.min.js"
               ));

            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                "~/assets/dist/js/jquery.min.js"));

            bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
                "~/assets/dist/js/jquery.validate.all.min.js"));

            //****************************
            //bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
            //            "~/Scripts/jquery-{version}.js"));

            //bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
            //            "~/Scripts/jquery.validate*", 
            //            "~/Scripts/_extensions.js"));

            //// Use the development version of Modernizr to develop with and learn from. Then, when you're
            //// ready for production, use the build tool at http://modernizr.com to pick only the tests you need.
            ////bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
            ////            "~/Scripts/modernizr-*"));

            //bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
            //          "~/Scripts/bootstrap.js",
            //          "~/Scripts/moment.js",
            //          "~/Scripts/bootstrap-datetimepicker.js"
            //          ));

            ////bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
            ////          "~/Scripts/bootstrap.js"));

            bundles.Add(new StyleBundle("~/Content/css").Include(
                //"~/Content/bootstrap.css",
                      "~/Content/bs-default.css",
                      "~/Content/font-awesome.css",
                      "~/Content/site.css"));
        }
    }
}