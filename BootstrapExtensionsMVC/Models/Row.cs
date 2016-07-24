using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;

namespace BootstrapExtensionsMVC.Models
{
    public class Row<TModel> : BootstrapContainer<TModel>
    {
        internal Row(HtmlHelper<TModel> helper, object htmlAttributes = null, IEnumerable<IHtmlString> columns = null) 
            : base(helper, Tags.Div, BootstrapElements.Row, htmlAttributes, columns)
        {
            if (columns == null)
                StartTag();

        }
    }
}
