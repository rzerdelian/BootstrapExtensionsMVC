using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace BootstrapExtensionsMVC.Models
{
    public class Dropdown : BootstrapContainer, IDisposable
    {
        internal Dropdown(ViewContext viewContext, string text, ButtonStyles style = ButtonStyles.Default)
            :base(viewContext, Tags.Div, BootstrapElements.Dropdown)
        {
            Button btn = new Button(text, style,
                ButtonSizes.Default, ButtonTypes.Button, new { @class = "dropdown-toggle", data_toggle = "dropdown" })
                .AddIcon(Mvc.RazorTools.FontAwesome.FontAwesomeIconSet.CaretDown, Positions.Right);

            AddChild(btn);
            AddChild(new MvcHtmlString("<ul class=\"dropdown-menu\">"));

            StartTag();
        }

        internal Dropdown(ViewContext viewContext, string text, IEnumerable<ListItem> items, ButtonStyles style = ButtonStyles.Default) 
            : base(viewContext, Tags.Div, BootstrapElements.Dropdown)
        {
            Button btn = new Button(text, style,
                ButtonSizes.Default, ButtonTypes.Button, new { @class = "dropdown-toggle", data_toggle = "dropdown" })
                .AddIcon(Mvc.RazorTools.FontAwesome.FontAwesomeIconSet.CaretDown, Positions.Right);

            AddChild(btn);

            var listContainer = new _bootstrapComponent(Tags.List, BootstrapElements.None);
            listContainer.AddCssClass("dropdown-menu");
            foreach (ListItem li in items)
                listContainer.AddChild(li);

            AddChild(listContainer);
        }

        void IDisposable.Dispose()
        {
            viewContext.Writer.Write("</ul>");   //close dropdown menu
            base.Dispose();
        }
    }

    //public class Dropdown<TModel> : BootstrapContainer<TModel>, IDisposable
    //{

    //    private TagBuilder childTB = new TagBuilder("ul");

    //    internal Dropdown(HtmlHelper<TModel> helper, string text, ButtonStyles style = ButtonStyles.Default)
    //        : base(helper, Tags.Span, BootstrapElements.Dropdown)
    //    {
    //        childTB.AddCssClass("dropdown-menu");

    //        InnerHtml = BeginTag(text, style);
    //        StartTag();
    //    }

    //    internal Dropdown(HtmlHelper<TModel> helper, string text, IEnumerable<ListItem> items, ButtonStyles style = ButtonStyles.Default) 
    //        : base(helper, Tags.Span, BootstrapElements.Dropdown)
    //    {
    //        childTB.AddCssClass("dropdown-menu");

    //        StringBuilder sb = new StringBuilder(BeginTag(text, style));
            

    //        foreach (ListItem li in items)
    //            sb.AppendLine(li.ToHtmlString());

    //        //sb.AppendLine("</ul>");

    //        InnerHtml = sb.ToString();
    //    }

    //    private string BeginTag(string text, ButtonStyles style)
    //    {
            
    //        Button btn = new Button(text, style,
    //            ButtonSizes.Default, ButtonTypes.Button, new { @class = "dropdown-toggle", data_toggle = "dropdown" })
    //            .AddIcon(Mvc.RazorTools.FontAwesome.FontAwesomeIconSet.CaretDown, Positions.Right);


    //        //sb.AppendLine(btn.ToHtmlString());
    //        //sb.AppendLine("<ul class=\"dropdown-menu\">");

    //        return btn.ToHtmlString() + childTB.ToString(TagRenderMode.StartTag); // +"<ul class=\"dropdown-menu\">";

    //        //StartTagDone = true;
    //    }

    //    void IDisposable.Dispose()
    //    {
    //        //helper.ViewContext.Writer.Write("</ul>");
    //        helper.ViewContext.Writer.Write(childTB.ToString(TagRenderMode.EndTag));
    //        base.Dispose();
    //    }
    //}

    public class ListItem : BootstrapComponent
    {
        internal ListItem(string text, string link = null, bool isHeading = false, bool isDisabled = false)
            : base(Tags.ListItem, BootstrapElements.ListItem)
        {
            if (!string.IsNullOrEmpty(link))
                InnerHtml = string.Format("<a href=\"{0}\">{1}</a>", link, text);
            else
                InnerHtml = text;

            if (isHeading)
                AddCssClass("dropdown-header");
            else if (isDisabled)
                this.AsDisabled();
        }
    }
}
