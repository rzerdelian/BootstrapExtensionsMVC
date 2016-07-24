using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BootstrapExtensionsMVC.Models
{
    public class Label : BootstrapComponent
    {
        internal Label(string text, Colors color = Colors.Default, string labelFor = null) 
            : base(Tags.Span, BootstrapElements.Label)
        {
            AddCssClass(string.Format("{0}-{1}", elementType.DisplayName(), color.DisplayName()));
            InnerHtml = text;

            if (!string.IsNullOrEmpty(labelFor))
            {
                this.tag = Tags.Label;
                Attributes["for"] = labelFor;
            }
                
        }
    }
}
