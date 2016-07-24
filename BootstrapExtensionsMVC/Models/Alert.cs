using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace BootstrapExtensionsMVC.Models
{

    //public class Alert : BootstrapComponent
    //{
    //    internal Alert(AlertStyles style, string text, bool dismissable = false, object htmlAttributes = null)
    //        : base(Tags.Div, BootstrapElements.Alert)
    //    {
    //        AddCssClass(style.DisplayName());

    //        if (dismissable == true)
    //        {
    //            AddCssClass(elementType.DisplayName() + "-dismissible ");
    //            var btn = new Button("x", type: ButtonTypes.Button);
    //            InnerHtml = btn.AsClose(elementType.DisplayName()).ToHtmlString();

    //            //AddChild(btn.AsClose(elementType.DisplayName()));
    //        }

    //        if (!string.IsNullOrEmpty(text))
    //            InnerHtml += text;
    //    }
    //}

    public class Alert<TModel> : BootstrapContainer<TModel>
    {
        internal Alert(HtmlHelper<TModel> helper, AlertStyles style, string text = null, bool dismissable = false, object htmlAttributes = null) 
            : base(helper, Tags.Div, BootstrapElements.Alert, htmlAttributes)
        {
            AddCssClass(style.DisplayName());

            if (dismissable == true)
            {
                AddCssClass(elementType.DisplayName() + "-dismissible ");
                var btn = new Button("x", type: ButtonTypes.Button);
                InnerHtml = btn.AsClose(elementType.DisplayName()).ToHtmlString();
            }

            if (!string.IsNullOrEmpty(text))
                InnerHtml += text;
            else
                StartTag();
        }
    }
}
