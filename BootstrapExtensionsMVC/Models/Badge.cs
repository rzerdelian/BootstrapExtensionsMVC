using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BootstrapExtensionsMVC.Models
{
    public class Badge : BootstrapComponent
    {
        internal Badge(string item) 
            : base(Tags.Span, BootstrapElements.Badge)
        {
            InnerHtml = item;
        }

        internal Badge(int item)
            : base(Tags.Span, BootstrapElements.Badge)
        {
            InnerHtml = item.ToString();
        }
    }
}
