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
    [System.Web.WebPages.PageVirtualPathAttribute("~/Views/Shared/EditorTemplates/Boolean.cshtml")]
    public partial class Boolean_ : System.Web.Mvc.WebViewPage<Boolean>
    {
        public Boolean_()
        {
        }
        public override void Execute()
        {
            
            #line 3 "C:\Users\rich\My Dev Space\trunk\MvcMicroSite2\BootstrapExtensionsMVC\Views\Shared\EditorTemplates\Boolean.cshtml"
  
    
    var checkboxStyle = ViewBag.checkboxStyle;
    
    

            
            #line default
            #line hidden
WriteLiteral("\r\n\r\n<div");

WriteAttribute("class", Tuple.Create(" class=\"", 97), Tuple.Create("\"", 164)
, Tuple.Create(Tuple.Create("", 105), Tuple.Create("form-group", 105), true)
            
            #line 10 "C:\Users\rich\My Dev Space\trunk\MvcMicroSite2\BootstrapExtensionsMVC\Views\Shared\EditorTemplates\Boolean.cshtml"
, Tuple.Create(Tuple.Create(" ", 115), Tuple.Create<System.Object, System.Int32>(Html.ValidationErrorFor(m => m, " has-error")
            
            #line default
            #line hidden
, 116), false)
);

WriteLiteral(">\r\n");

WriteLiteral("    ");

            
            #line 11 "C:\Users\rich\My Dev Space\trunk\MvcMicroSite2\BootstrapExtensionsMVC\Views\Shared\EditorTemplates\Boolean.cshtml"
Write(Html.LabelFor(m => m, new { @class = "control-label col-md-3" }));

            
            #line default
            #line hidden
WriteLiteral("\r\n    <div");

WriteAttribute("class", Tuple.Create(" class=\"", 247), Tuple.Create("\"", 287)
, Tuple.Create(Tuple.Create("", 255), Tuple.Create("col-md-9", 255), true)
, Tuple.Create(Tuple.Create(" ", 263), Tuple.Create("checkbox", 264), true)
            
            #line 12 "C:\Users\rich\My Dev Space\trunk\MvcMicroSite2\BootstrapExtensionsMVC\Views\Shared\EditorTemplates\Boolean.cshtml"
, Tuple.Create(Tuple.Create(" ", 272), Tuple.Create<System.Object, System.Int32>(checkboxStyle
            
            #line default
            #line hidden
, 273), false)
);

WriteLiteral(">\r\n        &nbsp;&nbsp;\r\n");

WriteLiteral("        ");

            
            #line 14 "C:\Users\rich\My Dev Space\trunk\MvcMicroSite2\BootstrapExtensionsMVC\Views\Shared\EditorTemplates\Boolean.cshtml"
   Write(Html.CheckBoxFor(m=> m));

            
            #line default
            #line hidden
WriteLiteral("\r\n        <label></label>\r\n");

WriteLiteral("        ");

            
            #line 16 "C:\Users\rich\My Dev Space\trunk\MvcMicroSite2\BootstrapExtensionsMVC\Views\Shared\EditorTemplates\Boolean.cshtml"
   Write(Html.ValidationMessageFor(m => m, null, new { @class = "text-danger" }));

            
            #line default
            #line hidden
WriteLiteral("\r\n    </div>\r\n</div>\r\n");

        }
    }
}
#pragma warning restore 1591