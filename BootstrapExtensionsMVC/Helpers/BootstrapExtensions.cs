using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;
using BootstrapExtensionsMVC.Models;
using System.Web;
using System.Web.Routing;

namespace BootstrapExtensionsMVC
{
    public class Bootstrap<TModel>
    {
        #region internal

        private readonly HtmlHelper<TModel> helper;

        internal Bootstrap(HtmlHelper<TModel> helper)
        {
            this.helper = helper;
        }

        #endregion

        #region Components

        public ActionLink ActionLink(string linkText, string url = null, object htmlAttributes = null)
        {
            return new ActionLink(this.helper, linkText, url, htmlAttributes);
        }

        public ActionLink ActionLink(string linkText, string actionName, string controllerName, object routeValues = null, object htmlAttributes = null)
        {
            return new ActionLink(this.helper, linkText, actionName, controllerName, new RouteValueDictionary(routeValues), htmlAttributes);
        }

        public Button Button(string text, ButtonStyles style= ButtonStyles.Default, ButtonSizes size = ButtonSizes.Default, ButtonTypes type = ButtonTypes.Button, object htmlAttributes = null)
        {
            return new Button(text, style, size, type, htmlAttributes);
        }

        public Badge Badge(string text)
        {
            return new Badge(text);
        }

        public Badge Badge(int value)
        {
            return new Badge(value);
        }

        public Label Label(string text, Colors color = Colors.Default, string labelFor = null)
        {
            return new Label(text, color, labelFor);
        }

        public ListItem ListItem(string text, string link = null, bool isHeading = false, bool isDisabled = false)
        {
            return new ListItem(text, link, isHeading, isDisabled);
        }

        public Dropdown2<TModel> Dropdown(string text, IEnumerable<ListItem> items, ButtonStyles style = ButtonStyles.Default)
        {
            return new Dropdown2<TModel>(helper, text, items, style);
        }

        #endregion

        #region IHtmlString Elements

        public IHtmlString Nav(IEnumerable<NavItem> links, NavTypes navType = NavTypes.Pills, bool isFixed = false)
        {
            return new Nav(links, navType, isFixed);
        }

        public IHtmlString Alert(string text, AlertStyles style = AlertStyles.Danger, bool dismissable = true)
        {
            return new Alert<TModel>(this.helper, style, text, dismissable);
        }

        public IHtmlString Row(object htmlAttributes = null, IEnumerable<IHtmlString> children = null)
        {
            return new Row<TModel>(helper, htmlAttributes, children);
        }

        public IHtmlString Column(IEnumerable<IHtmlString> children, ColumnLengths length = ColumnLengths.Full, ColumnSizes size = ColumnSizes.Medium, object htmlAttributes = null)
        {
            return new Column<TModel>(helper, size, length, htmlAttributes, children);
        }

        public IHtmlString Column(IHtmlString child, ColumnLengths length = ColumnLengths.Full, ColumnSizes size = ColumnSizes.Medium, object htmlAttributes = null)
        {
            return new Column<TModel>(helper, size, length, htmlAttributes, new IHtmlString[] { child });
        }

        public IHtmlString Blockquote(string quote, string source, bool reverse = false)
        {
            return new Blockquote(quote, source, reverse);
        }

        #endregion

        #region IDisposable Elements

        public IDisposable BeginDropdown(string text, ButtonStyles style = ButtonStyles.Default)
        {
            return new Dropdown2<TModel>(helper, text, style);
        }

        public IDisposable BeginAlert(AlertStyles style = AlertStyles.Warning, bool dismissable = false, object htmlAttributes = null)
        {
            return new Alert<TModel>(this.helper, style, null, dismissable, htmlAttributes);
        }

        public IDisposable BeginModal(string id, string headerText = null, Colors color = Colors.Default)
        {
            return new Modal<TModel>(helper, id, headerText, color);
        }

        public IDisposable BeginRow(object htmlAttributes = null)
        {
            return new Row<TModel>(helper, htmlAttributes);
        }

        public IDisposable BeginColumn(ColumnLengths length = ColumnLengths.Full, ColumnSizes size = ColumnSizes.Medium, object htmlAttributes = null)
        {
            return new Column<TModel>(helper, size, length, htmlAttributes);
        }

        public IDisposable BeginPanel(IHtmlString headerHtml = null, bool showHeader = false, Colors color = Colors.Default, IHtmlString footerHtml = null, bool showFooter = false)
        {
            return new Panel<TModel>(helper, headerHtml, showHeader, color, footerHtml, showFooter);
        }

        #endregion
    }
}
