﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace BootstrapExtensionsMVC.Views.Shared.EditorTemplates
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;
    using System.Net;
    using System.Text;
    using System.Web;
    using System.Web.Helpers;
    using System.Web.Mvc;
    using System.Web.Mvc.Ajax;
    using System.Web.Mvc.Html;
    using System.Web.Routing;
    using System.Web.Security;
    using System.Web.UI;
    using System.Web.WebPages;
    using BootstrapExtensionsMVC;
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("RazorGenerator", "2.0.0.0")]
    [System.Web.WebPages.PageVirtualPathAttribute("~/Views/Shared/EditorTemplates/Time.cshtml")]
    public partial class Time_ : System.Web.Mvc.WebViewPage<DateTime?>
    {
        public Time_()
        {
        }
        public override void Execute()
        {
WriteLiteral("<div");

WriteAttribute("class", Tuple.Create(" class=\"", 24), Tuple.Create("\"", 91)
, Tuple.Create(Tuple.Create("", 32), Tuple.Create("form-group", 32), true)
            
            #line 3 "C:\Users\rich\My Dev Space\trunk\MvcMicroSite2\BootstrapExtensionsMVC\Views\Shared\EditorTemplates\Time.cshtml"
, Tuple.Create(Tuple.Create(" ", 42), Tuple.Create<System.Object, System.Int32>(Html.ValidationErrorFor(m => m, " has-error")
            
            #line default
            #line hidden
, 43), false)
);

WriteLiteral(">\r\n");

WriteLiteral("    ");

            
            #line 4 "C:\Users\rich\My Dev Space\trunk\MvcMicroSite2\BootstrapExtensionsMVC\Views\Shared\EditorTemplates\Time.cshtml"
Write(Html.LabelFor(m => m, new { @class = "control-label col-md-3" }));

            
            #line default
            #line hidden
WriteLiteral("\r\n    <div");

WriteLiteral(" class=\"col-md-9\"");

WriteLiteral(">\r\n");

WriteLiteral("        ");

            
            #line 6 "C:\Users\rich\My Dev Space\trunk\MvcMicroSite2\BootstrapExtensionsMVC\Views\Shared\EditorTemplates\Time.cshtml"
   Write(Html.TextBoxFor(m => m, new { @class = "form-control timepicker" }));

            
            #line default
            #line hidden
WriteLiteral("\r\n");

WriteLiteral("        ");

            
            #line 7 "C:\Users\rich\My Dev Space\trunk\MvcMicroSite2\BootstrapExtensionsMVC\Views\Shared\EditorTemplates\Time.cshtml"
   Write(Html.ValidationMessageFor(m => m, null, new { @class = "text-danger" }));

            
            #line default
            #line hidden
WriteLiteral("\r\n    </div>\r\n</div>\r\n");

        }
    }
}
#pragma warning restore 1591