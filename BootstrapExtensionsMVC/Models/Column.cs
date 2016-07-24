using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;

namespace BootstrapExtensionsMVC.Models
{
    public class Column<TModel> : BootstrapContainer<TModel>
    {
        internal Column(HtmlHelper<TModel> helper, ColumnSizes size, ColumnLengths columnLength, object htmlAttributes = null, IEnumerable<IHtmlString> children = null)
            : base(helper, Tags.Div, BootstrapElements.None, htmlAttributes, children)
        {

            string cssClass = string.Format("{0}-{1}-{2}",
                BootstrapElements.Column.DisplayName(),
                size.DisplayName(),
                columnLength.DisplayName());

            AddCssClass(cssClass);

            if (children == null)
                StartTag();

        }
    }

    public class Column : BootstrapComponent
    {

        public Column(IHtmlString innerHtml, ColumnLengths length = ColumnLengths.Full, ColumnSizes size = ColumnSizes.Medium, object htmlAttributes = null)
            : base(Tags.Div, BootstrapElements.None)
        {
            AddChild(innerHtml);
            Create(size, length);
        }

        public Column(IEnumerable<IHtmlString> children, ColumnLengths length = ColumnLengths.Full, ColumnSizes size = ColumnSizes.Medium, object htmlAttributes = null)
            : base(Tags.Div, BootstrapElements.None)
        {
            Create(size, length);

            if (children != null)
                childItems.AddRange(children);
        }

        private void Create(ColumnSizes size, ColumnLengths length)
        {
            string cssClass = string.Format("{0}-{1}-{2}",
                BootstrapElements.Column.DisplayName(),
                size.DisplayName(),
                length.DisplayName());

            AddCssClass(cssClass);
        }
    }
}

