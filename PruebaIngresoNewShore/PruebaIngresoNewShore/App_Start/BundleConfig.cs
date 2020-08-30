using System.Web;
using System.Web.Optimization;

namespace PruebaIngresoNewShore
{
    public class BundleConfig
    {
        // Para obtener más información sobre las uniones, visite https://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
     
            bundles.Add(new ScriptBundle("~/bundles/matejs").Include(
                      "~/Scripts/materialize.min.js"));

            bundles.Add(new ScriptBundle("~/bundles/javaScript").Include(
                      "~/Scripts/Script.js"));

            bundles.Add(new StyleBundle("~/Content/framework").Include(
             "~/Content/materialize.min.css"));

            bundles.Add(new StyleBundle("~/Content/Estilos").Include(
            "~/Content/Style.css"));
        
        }
    }
}

