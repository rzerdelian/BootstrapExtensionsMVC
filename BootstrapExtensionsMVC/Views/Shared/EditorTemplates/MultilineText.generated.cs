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
    [System.Web.WebPages.PageVirtualPathAttribute("~/Views/Shared/EditorTemplates/MultilineText.cshtml")]
    public partial class MultilineText_ : System.Web.Mvc.WebViewPage<object>
    {
        public MultilineText_()
        {
        }
        public override void Execute()
        {
WriteLiteral("\r\n");

WriteLiteral("<div");

WriteAttribute("class", Tuple.Create(" class=\"", 23), Tuple.Create("\"", 90)
, Tuple.Create(Tuple.Create("", 31), Tuple.Create("form-group", 31), true)
            
            #line 4 "C:\Users\rich\My Dev Space\trunk\MvcMicroSite2\BootstrapExtensionsMVC\Views\Shared\EditorTemplates\MultilineText.cshtml"
, Tuple.Create(Tuple.Create(" ", 41), Tuple.Create<System.Object, System.Int32>(Html.ValidationErrorFor(m => m, " has-error")
            
            #line default
            #line hidden
, 42), false)
);

WriteLiteral(">\r\n");

WriteLiteral("    ");

            
            #line 5 "C:\Users\rich\My Dev Space\trunk\MvcMicroSite2\BootstrapExtensionsMVC\Views\Shared\EditorTemplates\MultilineText.cshtml"
Write(Html.LabelFor(m => m, new { @class = "control-label col-md-3" }));

            
            #line default
            #line hidden
WriteLiteral("\r\n    <div");

WriteLiteral(" class=\"col-md-9\"");

WriteLiteral(">\r\n");

WriteLiteral("        ");

            
            #line 7 "C:\Users\rich\My Dev Space\trunk\MvcMicroSite2\BootstrapExtensionsMVC\Views\Shared\EditorTemplates\MultilineText.cshtml"
   Write(Html.TextAreaFor(m => m, new { @class = "form-control" }));

            
            #line default
            #line hidden
WriteLiteral("\r\n");

WriteLiteral("        ");

            
            #line 8 "C:\Users\rich\My Dev Space\trunk\MvcMicroSite2\BootstrapExtensionsMVC\Views\Shared\EditorTemplates\MultilineText.cshtml"
   Write(Html.ValidationMessageFor(m => m, null, new { @class = "text-danger" }));

            
            #line default
            #line hidden
WriteLiteral("\r\n    </div>\r\n</div>\r\n");

        }
    }
}
#pragma warning restore 1591
