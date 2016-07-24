using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace BootstrapExtensionsMVC
{

    internal static class HelperExtensions
    {
        private static Dictionary<string, string> dic = new Dictionary<string, string>();

        public static string DisplayName(this Enum @enum)
        {
            string key = @enum.GetType().ToString() + "_" + @enum.ToString();
            string value;
            if (dic.TryGetValue(key, out value))
            {
                return value;
            }
            else
            {
                var description = string.Empty;
                var fields = @enum.GetType().GetFields();
                foreach (var field in fields)
                {
                    var displayAttribute = Attribute.GetCustomAttribute(field, typeof(DisplayAttribute)) as DisplayAttribute;
                    if (displayAttribute != null && field.Name.Equals(@enum.ToString(), StringComparison.InvariantCultureIgnoreCase))
                    {
                        description = displayAttribute.Name;
                        break;
                    }
                }

                dic.Add(key, description);
                return description;
            }
        }
    }

}
