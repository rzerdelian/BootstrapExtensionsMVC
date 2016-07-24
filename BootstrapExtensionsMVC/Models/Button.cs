using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace BootstrapExtensionsMVC.Models
{
    public class Button : BootstrapComponent
    {
        internal Button(string text, ButtonStyles style = ButtonStyles.Default, ButtonSizes size = ButtonSizes.Default, ButtonTypes type = ButtonTypes.Button, object htmlAttributes = null) 
            : base(Tags.Button, BootstrapElements.Button)
        {
            InnerHtml = text;
            AddCssClass(style.DisplayName());
            AddCssClass(size.DisplayName());
            Attributes = (IDictionary<string, object>)HtmlHelper.AnonymousObjectToHtmlAttributes(htmlAttributes);
            Attributes["type"] = type.DisplayName();
        }
    }
}
