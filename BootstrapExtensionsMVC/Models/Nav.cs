using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BootstrapExtensionsMVC.Models
{
    public class Nav : BootstrapComponent
    {

        public Nav(IEnumerable<NavItem> links, NavTypes navType, bool isFixed = false)
            : base(Tags.Div, BootstrapElements.None)
        {
            Attributes.Add("role", "navigation");

            var nav = new _bootstrapComponent(Tags.List, BootstrapElements.Nav);
            nav.AddCssClass(navType.DisplayName());

            foreach (var item in links)
                nav.AddChild(item);

            if (isFixed)
                AddCssClass("affix");

            AddChild(nav);
        }
    }

    public class NavItem : BootstrapComponent
    {
        public NavItem(string text, string link)
            : base(Tags.ListItem, BootstrapElements.None)
        {
            Attributes["role"] = "presentation";
            ActionLink = new ActionLink(text, link);
        }

        public ActionLink ActionLink { get; set; }

        public override string ToHtmlString()
        {
            InnerHtml = ActionLink.ToHtmlString();
            return base.ToHtmlString();
        }
    }
}