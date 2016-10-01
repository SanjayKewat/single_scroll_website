using System.Web;
using System.Web.Optimization;

namespace RSOFTWARESOLUTIONS
{
    public class BundleConfig
    {
        // For more information on Bundling, visit http://go.microsoft.com/fwlink/?LinkId=254725
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        "~/Scripts/jquery-{version}.js"));

            bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
                        "~/Scripts/jquery.validate*"));


            bundles.Add(new ScriptBundle("~/bundles/jquerybxslider").Include(
               "~/Scripts/jquery.bxslider.js"
               ));

            bundles.Add(new ScriptBundle("~/bundles/angularjs").Include(
           "~/Scripts/angular.min.js"
           ));

            //  ekko-lightbox js for image viewer
            bundles.Add(new ScriptBundle("~/bundles/ekko-lightbox").Include(
                "~/Scripts/ekko-lightbox.js"));


            // Use the development version of Modernizr to develop with and learn from. Then, when you're
            // ready for production, use the build tool at http://modernizr.com to pick only the tests you need.
            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/Scripts/modernizr-*"));

            bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
                      "~/Scripts/bootstrap.js",
                      "~/Scripts/respond.js"
                      ));




            bundles.Add(new StyleBundle("~/Content/css").Include(
                      "~/Content/bootstrap.css",
                      "~/Content/site.css",
                      "~/Content/bootstrap-social.css",
                      "~/Content/font-awesome.min.css",
                      "~/Content/footer.css"));

            //bxslider css
            bundles.Add(new StyleBundle("~/Content/bxslidercss").Include(
                    "~/Content/jquery.bxslider.css"
                    ));

            //ekko-lightbox css for image viewer
            bundles.Add(new StyleBundle("~/Content/ekko-lightbox").Include(
                   "~/Content/ekko-lightbox.css"
                   ));
        }
    }
}