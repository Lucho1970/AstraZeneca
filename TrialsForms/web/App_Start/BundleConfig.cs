using System.Web.Optimization;

namespace TrialsSurveys
{
    public class BundleConfig
    {

        public static void RegisterBundles(BundleCollection bundles)
        {



            // Vendor scripts
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        "~/Scripts/jquery-3.3.1.min.js"));

            // jQueryUI CSS
            bundles.Add(new StyleBundle("~/Content/plugins/jQueryUI/jqueryuiStyles").Include(
                        "~/Content/plugins/jQueryUI/jquery-ui.css"));

            // jQueryUI 
            bundles.Add(new ScriptBundle("~/bundles/jqueryui").Include(
                        "~/Scripts/plugins/jquery-ui/jquery-ui.min.js"));
            // jQuery Validation
            bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
                    "~/Scripts/jquery.validate.min.js",
                    "~/Scripts/jquery.validate.unobtrusive.min.js",
                    "~/Client Scripts/MvcFoolproofJQueryValidation.min.js",
                    "~/Client Scripts/mvcfoolproof.unobtrusive.min.js",
                    "~/Scripts/moment-with-locales.min.js",
                    "~/Scripts/app/Georgian.International.CustomValidators.js"
                ));

            bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
                      "~/Scripts/bootstrap.min.js"));
            // jQuery Form Plugin
            bundles.Add(new ScriptBundle("~/plugins/jqueryform").Include(
                "~/Scripts/plugins/form/jquery.form.min.js"));

            // Inspinia script
            bundles.Add(new ScriptBundle("~/bundles/inspinia").Include(
                      "~/Scripts/app/inspinia.js"));

            // SlimScroll
            bundles.Add(new ScriptBundle("~/plugins/slimScroll").Include(
                      "~/Scripts/plugins/slimScroll/jquery.slimscroll.min.js"));

            // jQuery plugins
            bundles.Add(new ScriptBundle("~/plugins/metsiMenu").Include(
                      "~/Scripts/plugins/metisMenu/metisMenu.min.js"));

            bundles.Add(new ScriptBundle("~/plugins/pace").Include(
                      "~/Scripts/plugins/pace/pace.min.js"));

            // CSS style (bootstrap/inspinia)
            bundles.Add(new StyleBundle("~/Content/css").Include(
                      "~/Content/bootstrap.min.css",
                      "~/Content/animate.css",
                      "~/Content/style.css",
                      "~/Content/surveys.css"));

            // dataTables css styles
            bundles.Add(new StyleBundle("~/Content/plugins/dataTables/dataTablesStyles").Include(
                "~/Content/plugins/dataTables/dataTables.bootstrap.min.css",
                "~/Content/plugins/dataTables/fixedHeader.bootstrap.min.css",
                "~/Content/plugins/dataTables/responsive.bootstrap.min.css",
                "~/Content/plugins/dataTables/select.dataTables.min.css"));

            // dataTables 
            bundles.Add(new ScriptBundle("~/plugins/dataTables").Include(
                "~/Scripts/plugins/dataTables/jquery.dataTables.min.js",
                "~/Scripts/plugins/dataTables/dataTables.bootstrap.min.js",
                "~/Scripts/plugins/dataTables/dataTables.fixedHeader.min.js",
                "~/Scripts/plugins/dataTables/dataTables.responsive.min.js",
                "~/Scripts/plugins/dataTables/responsive.bootstrap.min.js",
                "~/Scripts/plugins/dataTables/dataTables.select.min.js",
                "~/Scripts/plugins/dataTables/dataTables.buttons.min.js"));
            // Font Awesome icons
            bundles.Add(new StyleBundle("~/font-awesome/css").Include(
                      "~/fonts/font-awesome/css/font-awesome.min.css", new CssRewriteUrlTransform()));

            // dropZone styles
            bundles.Add(new StyleBundle("~/Content/plugins/dropzone/dropZoneStyles").Include(
                      "~/Content/plugins/dropzone/basic.css",
                      "~/Content/plugins/dropzone/dropzone.css"));
            // dropZone 
            bundles.Add(new ScriptBundle("~/plugins/dropZone").Include(
                      "~/Scripts/plugins/dropzone/dropzone.js"));
            // toastr Styles
            bundles.Add(new StyleBundle("~/plugins/toastrStyles").Include(
                      "~/Content/plugins/toastr/toastr.min.css"));

            // toastr Scripts
            bundles.Add(new ScriptBundle("~/plugins/toastr").Include(
                      "~/Scripts/plugins/toastr/toastr.min.js"));
        }
    }
}
