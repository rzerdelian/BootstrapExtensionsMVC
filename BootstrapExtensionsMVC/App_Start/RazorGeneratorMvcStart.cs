using System.Web;
using System.Web.Mvc;
using System.Web.WebPages;
using RazorGenerator.Mvc;

[assembly: WebActivatorEx.PostApplicationStartMethod(typeof(BootstrapExtensionsMVC.RazorGeneratorMvcStart), "Start")]

namespace BootstrapExtensionsMVC {
    public static class RazorGeneratorMvcStart {
        public static void Start() {
            //var engine = new PrecompiledMvcEngine(typeof(RazorGeneratorMvcStart).Assembly) {
            //    UsePhysicalViewsIfNewer = HttpContext.Current.Request.IsLocal
            //};

            //ViewEngines.Engines.Insert(0, engine);

            var engine = new PrecompiledMvcEngine(typeof(RazorGeneratorMvcStart).Assembly)
            {
                UsePhysicalViewsIfNewer = false, PreemptPhysicalFiles = false
            };

            ViewEngines.Engines.Add(engine);

            // StartPage lookups are done by WebPages. 
            VirtualPathFactoryManager.RegisterVirtualPathFactory(engine);
        }
    }
}
