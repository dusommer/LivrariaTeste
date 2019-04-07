using System.Web;
using System.Web.Optimization;

namespace TesteHBSIS.WebApp
{
    public class BundleConfig
    {
        // For more information on bundling, visit https://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                      "~/Content/Scripts/jquery.min.js"));

            bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
                        "~/Content/Scripts/jquery.validate*",
                        "~/Content/Scripts/jquery.unobtrusive*",
                        "~/Content/Scripts/methods_pt.js"));

            // Use the development version of Modernizr to develop with and learn from. Then, when you're
            // ready for production, use the build tool at https://modernizr.com to pick only the tests you need.
            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/Content/Scripts/modernizr-*"));

            bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
                      "~/Content/vendor/bootstrap/js/bootstrap.bundle.min.js",
                      "~/Content/vendor/jquery-easing/jquery.easing.min.js",
                      "~/Content/vendor/datatables/jquery.dataTables.min.js",
                      "~/Content/vendor/datatables/dataTables.bootstrap4.min.js",
                      "~/Content/Scripts/demo/datatables-demo.js",
                      "~/Content/Scripts/bootstrap-datepicker.min.js",
                      "~/Content/Scripts/bootstrap-datepicker.pt-BR.min.js",
                      "~/Content/Scripts/sistema/sistema.js",
                      "~/Content/Scripts/sb-admin-2.min.js"));


            bundles.Add(new StyleBundle("~/Content/css").Include(
                   "~/Content/vendor/datatables/dataTables.bootstrap4.min.css",
                   "~/Content/vendor/fontawesome-free/css/all.min.css",
                   "~/Content/css/sb-admin-2.min.css",
                   "~/Content/css/bootstrap-datepicker3.min.css"));

            bundles.Add(new ScriptBundle("~/bundles/inputmask").Include(
                    "~/Content/Scripts/inputmask/inputmask.js",
                    "~/Content/Scripts/inputmask/jquery.inputmask.js",
                    "~/Content/Scripts/inputmask/inputmask.extensions.js",
                    "~/Content/Scripts/inputmask/inputmask.date.extensions.js",
                    "~/Content/Scripts/inputmask/inputmask.numeric.extensions.js"));
        }
    }
}
