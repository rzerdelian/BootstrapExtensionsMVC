using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace BootstrapExtensionsMVC.Helpers
{
    public class RazorBasePage<T> : WebViewPage<T>
    {

        public  BootstrapHelper Bootstrap { get; set; }

        public override void InitHelpers()
        {
            base.InitHelpers();
            Bootstrap = new BootstrapHelper(this.ViewContext);
        }

        //public Bootstrap<TModel> Bootstrap { get; set; }

        //public override void InitHelpers()
        //{
        //    base.InitHelpers();
        //    Bootstrap = HtmlBootstrapHelper.Bootstrap<T>(this.Html);
        //}


        public override void Execute()
        {
            //base.ex
        }
    }

    //public class RazorBasePage : WebViewPage
    //{
    //    public htmlbo
    //}
}