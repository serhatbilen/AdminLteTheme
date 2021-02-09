using System.Web;
using System.Web.Optimization;

namespace AdminLteProject
{
    public class BundleConfig
    {
        // For more information on bundling, visit https://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        "~/Content/plugins/jquery/jquery.min.js"
                        ));

            bundles.Add(new ScriptBundle("~/bundles/jquery-ui").Include(
                "~/Content/plugins/jquery-ui/jquery-ui.min.js"
                ));

            bundles.Add(new ScriptBundle("~/bundles/widget-page").Include(
                ));

            bundles.Add(new ScriptBundle("~/bundles/layout-page").Include(
               ));

            bundles.Add(new ScriptBundle("~/bundles/charts-page").Include(
               "~/Content/plugins/chart.js/Chart.min.js",
               "~/Content/plugins/flot/jquery.flot.js",
               "~/Content/plugins/flot/plugins/jquery.flot.resize.js",
               "~/Content/plugins/flot/plugins/jquery.flot.pie.js",
               "~/Content/plugins/sparklines/sparkline.js",
               "~/Content/plugins/jquery-knob/jquery.knob.min.js",
               "~/Content/plugins/uplot/uPlot.iife.min.js"));

            bundles.Add(new ScriptBundle("~/bundles/elements-page").Include(
               "~/Content/plugins/ion-rangeslider/js/ion.rangeSlider.min.js",
               "~/Content/plugins/bootstrap-slider/bootstrap-slider.min.js",
               "~/Content/plugins/sweetalert2/sweetalert2.min.js",
               "~/Content/plugins/toastr/toastr.min.js"
               ));

            bundles.Add(new ScriptBundle("~/bundles/form-page").Include(
               "~/Content/plugins/bs-custom-file-input/bs-custom-file-input.min.js",
               "~/Content/plugins/bootstrap4-duallistbox/jquery.bootstrap-duallistbox.min.js",
               "~/Content/plugins/moment/moment.min.js",
               "~/Content/plugins/inputmask/jquery.inputmask.min.js",
               "~/Content/plugins/daterangepicker/daterangepicker.js",
               //"~/Content/plugins/bootstrap-colorpicker/js/bootstrap-colorpicker.min.js",
               "~/Content/plugins/tempusdominus-bootstrap-4/js/tempusdominus-bootstrap-4.min.js",
               "~/Content/plugins/bootstrap-switch/js/bootstrap-switch.min.js",
               "~/Content/plugins/bs-stepper/js/bs-stepper.min.js",
               "~/Content/plugins/dropzone/min/dropzone.min.js",
               "~/Content/plugins/select2/js/select2.full.min.js",
               "~/Content/plugins/codemirror/codemirror.js",
               "~/Content/plugins/codemirror/mode/css/css.js",
               "~/Content/plugins/codemirror/codemirror.js",
               "~/Content/plugins/codemirror/mode/xml/xml.js",
               "~/Content/plugins/codemirror/mode/htmlmixed/htmlmixed.js",
               "~/Content/plugins/jquery-validation/jquery.validate.min.js",
               "~/Content/plugins/jquery-validation/additional-methods.min.js"
               ));

            bundles.Add(new ScriptBundle("~/bundles/tables-page").Include(
                "~/Content/plugins/datatables/jquery.dataTables.min.js",
                "~/Content/plugins/datatables-bs4/js/dataTables.bootstrap4.min.js",
                "~/Content/plugins/datatables-responsive/js/dataTables.responsive.min.js",
                "~/Content/plugins/datatables-responsive/js/responsive.bootstrap4.min.js",
                "~/Content/plugins/datatables-buttons/js/dataTables.buttons.min.js",
                "~/Content/plugins/datatables-buttons/js/buttons.bootstrap4.min.js",
                "~/Content/plugins/jszip/jszip.min.js",
                "~/Content/plugins/pdfmake/pdfmake.min.js",
                "~/Content/plugins/pdfmake/vfs_fonts.js",
                "~/Content/plugins/datatables-buttons/js/buttons.html5.min.js",
                "~/Content/plugins/datatables-buttons/js/buttons.print.min.js",
                "~/Content/plugins/datatables-buttons/js/buttons.colVis.min.js",
                "~/Content/plugins/jsgrid/demos/db.js",
                "~/Content/plugins/jsgrid/jsgrid.min.js"
                ));

            bundles.Add(new ScriptBundle("~/bundles/calendar-page").Include(
                "~/Content/plugins/moment/moment.min.js",
                "~/Content/plugins/fullcalendar/main.js"
                ));

            bundles.Add(new ScriptBundle("~/bundles/gallery-page").Include(
                "~/Content/plugins/ekko-lightbox/ekko-lightbox.min.js",
                "~/Content/plugins/filterizr/jquery.filterizr.min.js"
                ));

            bundles.Add(new ScriptBundle("~/bundles/mailbox-pages").Include(
                "~/Content/plugins/jquery/jquery.min.js",
                "~/Content/plugins/bootstrap/js/bootstrap.bundle.min.js",
                "~/Content/dist/js/adminlte.min.js",
                "~/Content/plugins/summernote/summernote-bs4.min.js"
                ));

            bundles.Add(new ScriptBundle("~/bundles/sayfa-pages").Include(
                ));

            bundles.Add(new ScriptBundle("~/bundles/search-pages").Include(
                "~/Content/plugins/select2/js/select2.full.min.js"
                ));

            bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
                        "~/Scripts/jquery.validate*"));

            // Use the development version of Modernizr to develop with and learn from. Then, when you're
            // ready for production, use the build tool at https://modernizr.com to pick only the tests you need.
            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/Scripts/modernizr-*"));

            bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
                      "~/Content/plugins/bootstrap/js/bootstrap.bundle.min.js"));

            bundles.Add(new StyleBundle("~/Content/css").Include(
                      "~/Content/bootstrap.css",
                      "~/Content/site.css"));
        }
    }
}
