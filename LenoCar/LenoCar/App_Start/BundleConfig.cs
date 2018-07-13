using System.Web.Optimization;

namespace LenoCar
{
    public class BundleConfig
    {
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        "~/Scripts/jquery-{version}.js"));

            bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
                        "~/Scripts/jquery.validate*"));

            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/Scripts/modernizr-*"));

            bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
                      "~/Scripts/vendor/bootstrap/js/bootstrap.js"
                ));

            bundles.Add(new StyleBundle("~/Content/css").Include(
                      //"~/Content/bootstrap.css",
                      "~/Scripts/vendor/bootstrap/css/bootstrap.css",

                      "~/Content/one-page-wonder.css",
                      "~/Scripts/vendor/bootstrap/bootstrap-grid.css",
                      "~/Scripts/vendor/bootstrap/bootstrap-reboot.css",
                      "~/Content/site.css"));
        }
    }
}
