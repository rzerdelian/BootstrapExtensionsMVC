using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Routing;
using System.Web.Mvc;

namespace BootstrapExtensionsMVC.Models
{
    public class ActionLink : BootstrapComponent
    {

        public ActionLink(string linkText, string url, object htmlAttributes = null)
            : base(Tags.Anchor,  BootstrapElements.Link)
            //: this(null, linkText, url, null)
        {
            if (htmlAttributes != null)
                Attributes = (IDictionary<string, object>)HtmlHelper.AnonymousObjectToHtmlAttributes(htmlAttributes);

            Attributes["href"] = url;
            InnerHtml = linkText;
        }

        internal ActionLink(ViewContext viewContext, string linkText, string url, object htmlAttributes = null) 
            : this(linkText, url, null)
            //: base(Tags.Anchor,  BootstrapElements.Link)
        {

            //if (htmlAttributes != null)
            //    Attributes = (IDictionary<string, object>)HtmlHelper.AnonymousObjectToHtmlAttributes(htmlAttributes);

            //Attributes["href"] = url;
            //InnerHtml = linkText;
        }

        internal ActionLink(ViewContext viewContext, string linkText, string actionName = null, string controllerName = null, RouteValueDictionary routeValues = null, object htmlAttributes = null) 
            : base(Tags.Anchor,  BootstrapElements.Link)
        {
            if (string.IsNullOrEmpty(actionName))
                actionName = viewContext.RouteData.GetRequiredString("action");

            if (string.IsNullOrEmpty(controllerName))
                controllerName = viewContext.RouteData.GetRequiredString("controller");

            InnerHtml = linkText;
            Attributes = (IDictionary<string, object>)HtmlHelper.AnonymousObjectToHtmlAttributes(htmlAttributes);
            Attributes["href"] = UrlHelper.GenerateUrl(null, actionName, controllerName, routeValues, RouteTable.Routes, viewContext.RequestContext, false);
        }
    }
}
