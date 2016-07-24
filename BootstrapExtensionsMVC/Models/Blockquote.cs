using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;

namespace BootstrapExtensionsMVC.Models
{
    public class Blockquote : BootstrapComponent
    {
        internal Blockquote(string quote, string source, bool reverse =false) 
            : base(Tags.Blockquote, BootstrapElements.Blockquote)
        {
            if (reverse == true)
                AddCssClass("pull-right");

            AddChild(new MvcHtmlString(string.Format("<p>{0}</p><small>{1}</small>", quote, source)));
        }
    }
}
