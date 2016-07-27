using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace BootstrapExtensionsMVC.Models
{
    public class Modal : BootstrapContainer, IDisposable
    {
        
        TagBuilder footerTag = new TagBuilder("div");

        internal Modal(ViewContext viewContext, string id, string headerText = null, Colors color = Colors.Default)
            : base(viewContext, Tags.Div, BootstrapElements.Modal)
        {

            AddCssClass("fade");
            Attributes["role"] = "dialog";
            Attributes["id"] = id;

            var sb = new StringBuilder();
            sb.AppendLine("<div class=\"modal-dialog\">");
            sb.AppendLine("<div class=\"modal-content\">");

            if (!string.IsNullOrEmpty(headerText))
            {
                TagBuilder headerTag = new TagBuilder("div");
                headerTag.AddCssClass("modal-header");
                string style = (color == Colors.Default ? "" : "bg-" + color.DisplayName());
                headerTag.AddCssClass(style);
                headerTag.InnerHtml = string.Format("<button type=\"button\" class=\"close\" data-dismiss=\"modal\">&times;</button><span class=\"h2\">{0}</span>", headerText);

                sb.AppendLine(headerTag.ToString());
            }

            sb.AppendLine("<div class=\"modal-body\">");

            InnerHtml = sb.ToString();

            StartTag();
        }


        void IDisposable.Dispose()
        {
            viewContext.Writer.Write("</div>"); //closes body tag

            //if (hideFooter == false)
            //{
                //Button b = new Button("Close", htmlAttributes: new { data_dismiss = "modal" });
                //helper.ViewContext.Writer.Write("<div class=\"{0}-footer\">{1}</div>", elementType.DisplayName(), b.ToHtmlString());
            //}

            viewContext.Writer.Write("</div>"); //closes content tag
            viewContext.Writer.Write("</div>"); //closes dialog tag

            base.Dispose();
        }
    }
}
