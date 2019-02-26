using System.Web;
using System.Web.Optimization;

namespace Aula05
{
    public class BundleConfig
    {
        // For more information on bundling, visit http://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            BundleTable.EnableOptimizations = true;


            //bundles.IgnoreList.Ignore("*.;dbg.js");

            //bundles.Add(new ScriptBundle("~/comum")
            //    .IncludeDirectory("~/Scripts/comum", "*.js", true));

            //var ordem = new BundleFileSetOrdering(("meuNome"));
            //ordem.Files.Add("Setup.js");
            //ordem.Files.Add("display.js");
            //bundles.FileSetOrderList.Insert(0, ordem);

            bundles.Add(new ScriptBundle("~/bundles/comum")
                .Include("~/scripts/comum/*.js"));

            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        "~/Scripts/jquery-{version}.js"));

            bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
                        "~/Scripts/jquery.validate*"));

            // Use the development version of Modernizr to develop with and learn from. Then, when you're
            // ready for production, use the build tool at http://modernizr.com to pick only the tests you need.
            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/Scripts/modernizr-*"));

            bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
                      "~/Scripts/bootstrap.js",
                      "~/Scripts/respond.js"));

            bundles.Add(new StyleBundle("~/Content/css").Include(
                      "~/Content/bootstrap.css",
                      "~/Content/site.css"));
        }
    }
}
