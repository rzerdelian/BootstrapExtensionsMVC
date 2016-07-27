using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;

namespace BootstrapExtensionsMVC.Models
{
    public class Row : BootstrapContainer
    {
        internal Row(ViewContext viewContext, object htmlAttributes = null, IEnumerable<IHtmlString> columns = null)
            : base(viewContext, Tags.Div, BootstrapElements.Row, htmlAttributes, columns)
        {
            if (columns == null)
                StartTag();

        }
    }
}
