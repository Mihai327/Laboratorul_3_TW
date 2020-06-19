using System.Web;
using System.Web.Optimization;

namespace Top_Infinity
{
    public class BundleConfig
    {
        // For more information on bundling, visit https://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        "~/Scripts/jquery-{version}.js",
                        "~/Scripts/lightbox-plus-jquery.min.js"));

            bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
                        "~/Scripts/jquery.validate*"));

            // Use the development version of Modernizr to develop with and learn from. Then, when you're
            // ready for production, use the build tool at https://modernizr.com to pick only the tests you need.
            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/Scripts/modernizr-*"));

            bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
                      "~/Scripts/bootstrap.js"));

            bundles.Add(new StyleBundle("~/Content/css").Include(
                      "~/Content/bootstrap-spacelab.css",
                      "~/Content/site.css",
                      "~/Content/lightbox.min.css"));
            // Font Awesome icons style
            bundles.Add(new StyleBundle("~/bundles/font-awesome/css").Include("~/Content/font-awesome.min.css", new CssRewriteUrlTransform()));

            // Own css-style
            bundles.Add(new StyleBundle("~/bundles/Assets/css-style/own_css_style").Include("~/Assets/css-style/own_css_style.css", new CssRewriteUrlTransform()));

            // Admin Layout css-style
            bundles.Add(new StyleBundle("~/bundles/Assets/css-style/AdminLayout").Include("~/Assets/css-style/AdminLayout.css", new CssRewriteUrlTransform()));

            // Admin Layout js-style
            bundles.Add(new StyleBundle("~/bundles/Assets/js-style/AdminLayout_JS").Include("~/Assets/js-style/AdminLayout_JS.js", new CssRewriteUrlTransform()));

            // About css 
            bundles.Add(new StyleBundle("~/bundles/Assets/css-style/About").Include("~/Assets/css-style/About.css", new CssRewriteUrlTransform()));

            // Products css
            bundles.Add(new StyleBundle("~/bundles/Assets/css-style/Products").Include("~/Assets/css-style/Products.css", new CssRewriteUrlTransform()));
            // Products js
            bundles.Add(new StyleBundle("~/bundles/Assets/js-style/Products").Include("~/Assets/js-style/Products.js", new CssRewriteUrlTransform()));

            // Contacts css
            bundles.Add(new StyleBundle("~/bundles/Assets/css-style/Contacts").Include("~/Assets/css-style/Contacts.css", new CssRewriteUrlTransform()));
        }
    }
}
