using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;

namespace BootstrapExtensionsMVC.Models
{
    public class Panel : BootstrapContainer, IDisposable
    {
        private KeyValuePair<string, bool> footer;
        private TagBuilder bodyTB = new TagBuilder("div");

        internal Panel(ViewContext viewContext, IHtmlString headerHtml = null, bool showHeader = false, Colors color = Colors.Default, IHtmlString footerHtml = null, bool showFooter = false)
            : base(viewContext, Tags.Div, BootstrapElements.Panel)
        {
            AddCssClass("panel-" + color.DisplayName());

            if (showHeader == true)
            {
                var headerTb = new TagBuilder("div");
                headerTb.AddCssClass("panel-heading");

                var header = headerHtml.ToHtmlString();
                if (!string.IsNullOrEmpty(header))
                    headerTb.InnerHtml = header;

                InnerHtml = headerTb.ToString();
            }

            bodyTB.AddCssClass("panel-body");
            InnerHtml += bodyTB.ToString(TagRenderMode.StartTag);

            StartTag();
        }

        void IDisposable.Dispose()
        {
            viewContext.Writer.Write(bodyTB.ToString(TagRenderMode.EndTag));

            if (footer.Value == true)
                viewContext.Writer.Write("<div class=\"{0}-footer\">{1}</div>", BootstrapElements.Panel.DisplayName(), footer.Key);

            base.Dispose();
        }
    }

    public class PanelTitle : IHtmlString
    {
        string title;
        HeadingTypes headingType;

        public PanelTitle(string title, HeadingTypes headingType = HeadingTypes.H3)
        {
            this.title = title;
            this.headingType = headingType;
        }
    
        public string ToHtmlString()
        {
            return string.Format("<{0} class=\"panel-title\">{1}</{0}>", headingType, title);
        }
}
}
