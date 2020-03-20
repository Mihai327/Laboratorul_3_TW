using System.Web.Optimization;

namespace eUseControl.Web 
{
    public static class BundleConfig
    {
        private static object bundle;

        public static void RegisterBundles(BundleCollection bundles)
        {
            // Bootstrap style
            bundles.Add(new StyleBundle("~/bundles/bootstrap/css").Include("~/Content/bootstrap.min.css", new CssRewriteUrlTransform()));

            // main Style css
            bundles.Add(new StyleBundle("~/bundles/Assets/css-style/style").Include("~/Assets/css-style/style.css", new CssRewriteUrlTransform()));

            // Bootstrap
            bundles.Add(new ScriptBundle("~/bundles/bootstrap/js").Include("~/Scripts/bootstrap.min.js"));

            bundles.Add(new ScriptBundle("~/bundles/jquery/js").Include("~/Scripts/jquery-3.4.1.min.js"));

            // Font Awesome icons style
            bundles.Add(new StyleBundle("~/bundles/font-awesome/css").Include("~/Content/font-awesome.min.css", new CssRewriteUrlTransform()));

            // Toaster
            bundles.Add(new StyleBundle("~/bundles/toaster/css").Include("~/Vendors/toastr/toastr.min.css", new CssRewriteUrlTransform()));

            // DataTables
            bundles.Add(new StyleBundle("~/bundles/datatables/css").Include("~/Vendors/datatables/datatables.min.css", new CssRewriteUrlTransform()));

         
        }
    }
}