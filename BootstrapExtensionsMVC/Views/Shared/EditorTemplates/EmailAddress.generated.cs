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
    using BootstrapExtensionsMVC.Models;
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("RazorGenerator", "2.0.0.0")]
    [System.Web.WebPages.PageVirtualPathAttribute("~/Views/Shared/EditorTemplates/EmailAddress.cshtml")]
    public partial class EmailAddress_ : System.Web.Mvc.WebViewPage<object>
    {
        public EmailAddress_()
        {
        }
        public override void Execute()
        {
            
            #line 3 "C:\Users\rich\My Dev Space\trunk\BootstrapExtensionsMVC\BootstrapExtensionsMVC\Views\Shared\EditorTemplates\EmailAddress.cshtml"
  
    var templateHelper = new BootstrapExtensionsMVC.Helpers.EditorTemplateHelper(ViewBag);

    templateHelper.InputHtmlAttributes["type"] = "email";

            
            #line default
            #line hidden
WriteLiteral("\r\n\r\n<div");

WriteAttribute("class", Tuple.Create(" class=\"", 183), Tuple.Create("\"", 284)
, Tuple.Create(Tuple.Create("", 191), Tuple.Create("form-group", 191), true)
            
            #line 9 "C:\Users\rich\My Dev Space\trunk\BootstrapExtensionsMVC\BootstrapExtensionsMVC\Views\Shared\EditorTemplates\EmailAddress.cshtml"
, Tuple.Create(Tuple.Create(" ", 201), Tuple.Create<System.Object, System.Int32>(templateHelper.FormGroupCssClass
            
            #line default
            #line hidden
, 202), false)
            
            #line 9 "C:\Users\rich\My Dev Space\trunk\BootstrapExtensionsMVC\BootstrapExtensionsMVC\Views\Shared\EditorTemplates\EmailAddress.cshtml"
, Tuple.Create(Tuple.Create(" ", 235), Tuple.Create<System.Object, System.Int32>(Html.ValidationErrorFor(m => m, " has-error")
            
            #line default
            #line hidden
, 236), false)
);

WriteLiteral(">\r\n\r\n");

            
            #line 11 "C:\Users\rich\My Dev Space\trunk\BootstrapExtensionsMVC\BootstrapExtensionsMVC\Views\Shared\EditorTemplates\EmailAddress.cshtml"
    
            
            #line default
            #line hidden
            
            #line 11 "C:\Users\rich\My Dev Space\trunk\BootstrapExtensionsMVC\BootstrapExtensionsMVC\Views\Shared\EditorTemplates\EmailAddress.cshtml"
      
        if (string.IsNullOrEmpty(templateHelper.LabelCssClass))
        {
            
            
            #line default
            #line hidden
            
            #line 14 "C:\Users\rich\My Dev Space\trunk\BootstrapExtensionsMVC\BootstrapExtensionsMVC\Views\Shared\EditorTemplates\EmailAddress.cshtml"
       Write(Html.Raw("<div class=\"col-md-12\">"));

            
            #line default
            #line hidden
            
            #line 14 "C:\Users\rich\My Dev Space\trunk\BootstrapExtensionsMVC\BootstrapExtensionsMVC\Views\Shared\EditorTemplates\EmailAddress.cshtml"
                                                  ;
        
            
            #line default
            #line hidden
            
            #line 15 "C:\Users\rich\My Dev Space\trunk\BootstrapExtensionsMVC\BootstrapExtensionsMVC\Views\Shared\EditorTemplates\EmailAddress.cshtml"
   Write(Html.LabelFor(m => m, templateHelper.LabelHtmlAttributes));

            
            #line default
            #line hidden
            
            #line 15 "C:\Users\rich\My Dev Space\trunk\BootstrapExtensionsMVC\BootstrapExtensionsMVC\Views\Shared\EditorTemplates\EmailAddress.cshtml"
                                                                  ;
        }
        else
        {
            
            
            #line default
            #line hidden
            
            #line 19 "C:\Users\rich\My Dev Space\trunk\BootstrapExtensionsMVC\BootstrapExtensionsMVC\Views\Shared\EditorTemplates\EmailAddress.cshtml"
       Write(Html.LabelFor(m => m, templateHelper.LabelHtmlAttributes));

            
            #line default
            #line hidden
            
            #line 19 "C:\Users\rich\My Dev Space\trunk\BootstrapExtensionsMVC\BootstrapExtensionsMVC\Views\Shared\EditorTemplates\EmailAddress.cshtml"
                                                                      ;
        
            
            #line default
            #line hidden
            
            #line 20 "C:\Users\rich\My Dev Space\trunk\BootstrapExtensionsMVC\BootstrapExtensionsMVC\Views\Shared\EditorTemplates\EmailAddress.cshtml"
   Write(Html.Raw("<div class=\"" + @templateHelper.FieldCssClass + "\">"));

            
            #line default
            #line hidden
            
            #line 20 "C:\Users\rich\My Dev Space\trunk\BootstrapExtensionsMVC\BootstrapExtensionsMVC\Views\Shared\EditorTemplates\EmailAddress.cshtml"
                                                                          ;
        }

        
            
            #line default
            #line hidden
            
            #line 23 "C:\Users\rich\My Dev Space\trunk\BootstrapExtensionsMVC\BootstrapExtensionsMVC\Views\Shared\EditorTemplates\EmailAddress.cshtml"
   Write(Html.TextBoxFor(m => m, templateHelper.InputHtmlAttributes));

            
            #line default
            #line hidden
            
            #line 23 "C:\Users\rich\My Dev Space\trunk\BootstrapExtensionsMVC\BootstrapExtensionsMVC\Views\Shared\EditorTemplates\EmailAddress.cshtml"
                                                                    ;
        
            
            #line default
            #line hidden
            
            #line 24 "C:\Users\rich\My Dev Space\trunk\BootstrapExtensionsMVC\BootstrapExtensionsMVC\Views\Shared\EditorTemplates\EmailAddress.cshtml"
   Write(Html.ValidationMessageFor(m => m, null, new { @class = "text-danger" }));

            
            #line default
            #line hidden
            
            #line 24 "C:\Users\rich\My Dev Space\trunk\BootstrapExtensionsMVC\BootstrapExtensionsMVC\Views\Shared\EditorTemplates\EmailAddress.cshtml"
                                                                                ;

        
            
            #line default
            #line hidden
            
            #line 26 "C:\Users\rich\My Dev Space\trunk\BootstrapExtensionsMVC\BootstrapExtensionsMVC\Views\Shared\EditorTemplates\EmailAddress.cshtml"
   Write(Html.Raw("</div>"));

            
            #line default
            #line hidden
            
            #line 26 "C:\Users\rich\My Dev Space\trunk\BootstrapExtensionsMVC\BootstrapExtensionsMVC\Views\Shared\EditorTemplates\EmailAddress.cshtml"
                           ;
    
            
            #line default
            #line hidden
WriteLiteral("\r\n</div>");

        }
    }
}
#pragma warning restore 1591
