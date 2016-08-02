using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;
using BootstrapExtensionsMVC;
using BootstrapExtensionsMVC.Models;

namespace BootstrapExtensionsMVC.Helpers
{
    public class EditorTemplateHelper
    {
        public EditorTemplateHelper(FormGroupSizes? formGroupSize, int? labelWidth )
        {
            if (formGroupSize.HasValue)
                FormGroupCssClass = formGroupSize.DisplayName();
            else
                FormGroupCssClass = "";

            if (labelWidth.HasValue)
            {
                if (labelWidth.Value == 0)
                {
                    LabelCssClass = "";
                    FieldCssClass = "";
                }
                else
                {
                    LabelCssClass = "col-md-" + labelWidth.Value;
                    FieldCssClass = "col-md-" + (12 - labelWidth.Value);
                }
            }
            else
            {
                LabelCssClass = "col-md-3";
                FieldCssClass = "col-md-9";
            }
        }

        //public FormGroupSizes FormGroupSize { get; set; }
        public string FormGroupCssClass { get; set; }
        public string LabelCssClass { get; set; }
        public string FieldCssClass { get; set; }
    }
}