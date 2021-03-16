using System.Web;
using System.Web.Optimization;

namespace Capa_Presentacion
{
    public class BundleConfig
    {
        // Para obtener más información sobre las uniones, visite https://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        "~/Scripts/jquery-{version}.js"));

            bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
                        "~/Scripts/jquery.validate*"));

            // Utilice la versión de desarrollo de Modernizr para desarrollar y obtener información. De este modo, estará
            // para la producción, use la herramienta de compilación disponible en https://modernizr.com para seleccionar solo las pruebas que necesite.
            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/Scripts/modernizr-*"));

            bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
                      "~/Scripts/bootstrap.js"));

            bundles.Add(new StyleBundle("~/Content/css").Include(
                      "~/Content/assets/extra-libs/c3/c3.min.css",
                      "~/Content/assets/libs/chartist/dist/chartist.min.css",
                      "~/Content/assets/extra-libs/jvector/jquery-jvectormap-2.0.2.css",
                      "~/Content/dist/css/style.min.css"));

            bundles.Add(new StyleBundle("~/bundles/js").Include(
                        "~/Content/assets/libs/popper.js/dist/umd/popper.min.js",
                        "~/Content/dist/js/app-style-switcher.js",
                        "~/Content/dist/js/feather.min.js",
                        "~/Content/assets/libs/perfect-scrollbar/dist/perfect-scrollbar.jquery.min.js",
                        "~/Content/dist/js/sidebarmenu.min.js",
                        "~/Content/dist/js/custom.min.js",
                        "~/Content/assets/extra-libs/c3/d3.min.js",
                        "~/Content/assets/extra-libs/c3/c3.min.js",
                        "~/Content/assets/libs/chartist/dist/chartist.min.js",
                        "~/Content/assets/libs/chartist-plugin-tooltips/dist/chartist-plugin-tooltip.min.js",
                        "~/Content/assets/extra-libs/jvector/jquery-jvectormap-2.0.2.min.js",
                        "~/Content/assets/extra-libs/jvector/jquery-jvectormap-world-mill-en.js",
                        "~/Content/dist/js/pages/dashboards/dashboard1.min.js"));
        }
    }
}
