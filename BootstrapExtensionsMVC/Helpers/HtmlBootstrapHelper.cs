using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;
using BootstrapExtensionsMVC.Models;
using System.Web.Routing;
using Mvc.RazorTools.FontAwesome;

namespace BootstrapExtensionsMVC
{
    public static class HtmlBootstrapHelper
    {
        public static Bootstrap<TModel> Bootstrap<TModel>(this HtmlHelper<TModel> helper)
        {
            return new Bootstrap<TModel>(helper);
        }

        public static T AsButton<T>(this T element, ButtonStyles buttonStyle, ButtonSizes size = ButtonSizes.Default) where T : ActionLink
        {
            element.elementType = BootstrapElements.Button;
            element.AddCssClass(buttonStyle.DisplayName());
            element.AddCssClass(size.DisplayName());
            return element;
        }

        //public static NavItem AsButton(this NavItem navItem, ButtonStyles style, ButtonSizes size)
        //{
        //    navItem.ActionLink.AsButton(style, size);
        //    return navItem;
        //}

        public static T AsClose<T>(this T element, string closeSelector) where T : Button
        {
            element.Attributes.Add("data-dismiss", closeSelector);
            element.AddCssClass("close");
            return element;
        }

        public static BootstrapComponent AsDisabled(this BootstrapComponent element)
        {

            element.AddCssClass("disabled");
            return element;
        }

        public static NavItem AsActive(this NavItem element)
        {
            element.AddCssClass("active");
            return element;
        }

        public static BootstrapComponent AsActive(this BootstrapComponent element)
        {
            element.AddCssClass("active");
            return element;
        }

        //public static T AsActive<T>(this T element) where T : BootstrapComponent
        //{
        //    element.AddCssClass("active");
        //    return element;
        //}

        public static T AddIcon<T>(this T element, FontAwesomeIcon icon, Positions position = Positions.Left) where T : BootstrapComponent
        {
            string current = element.InnerHtml;

            switch (position)
            {
                case Positions.Bottom:
                    {
                        element.InnerHtml = current + "<br />" + icon.ToString();
                        break;
                    }
                case Positions.Top:
                    {
                        element.InnerHtml = icon.ToString() + "<br />" + current;
                        break;
                    }
                case Positions.Left:
                    {
                        element.InnerHtml = icon.ToString() + " " + current;
                        break;
                    }
                case Positions.Right:
                    {
                        element.InnerHtml = current + " " + icon.ToString();
                        break;
                    }
            }

            return element;
        }

        /// <summary>
        /// Add tooltip attributes to element, ensure $('[data-toggle="tooltip"]').tooltip(); is called in js to enable
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="element"></param>
        /// <param name="text"></param>
        /// <param name="position"></param>
        /// <returns></returns>
        public static T AddTooltip<T>(this T element, string text, Positions position = Positions.Auto) where T : BootstrapComponent
        {
            element.Attributes.Add("data-toggle", "tooltip");
            element.Attributes.Add("title", text);
            element.Attributes.Add("data-placement", position.ToString().ToLower());
            return element;
        }

        public static T AddBadge<T>(this T element, int item) where T : BootstrapComponent
        {
            Badge badge = new Badge(item);
            //element.InnerHtml += " " + badge.ToHtmlString();
            element.AddChild(badge);
            return element;
        }

        public static T AddBadge<T>(this T element, string item) where T : BootstrapComponent
        {
            Badge badge = new Badge(item);
            //element.InnerHtml += " " + badge.ToHtmlString();
            element.AddChild(badge);
            return element;
        }

        public static T AddPopover<T>(this T element, string title, string content, Positions position = Positions.Auto, Triggers trigger = Triggers.Focus) where T : BootstrapComponent
        {
            element.Attributes.Add("title", title);
            element.Attributes.Add("data-content", content);
            element.Attributes.Add("data-placement", position.DisplayName());
            element.Attributes.Add("data-trigger", trigger.DisplayName());
            element.Attributes.Add("data-toggle", "popover");
            return element;
        }

        public static T OpenModal<T>(this T element, string selector) where T : BootstrapComponent
        {
            element.Attributes.Add("data-toggle", "modal");
            element.Attributes.Add("data-target", selector);
            return element;
        }

    }
}
