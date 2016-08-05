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

            SetLabelAndFieldClass(labelWidth);
        }

        public EditorTemplateHelper(dynamic viewBag)
        {
            if (viewBag.htmlAttributes != null)
                InputHtmlAttributes = HtmlHelper.AnonymousObjectToHtmlAttributes(viewBag.htmlAttributes);

            if (viewBag.inputHtmlAttributes != null)
                InputHtmlAttributes = HtmlHelper.AnonymousObjectToHtmlAttributes(viewBag.inputHtmlAttributes);

            if (InputHtmlAttributes == null)
                InputHtmlAttributes = new RouteValueDictionary();

            if (viewBag.labelHtmlAttributes != null)
                LabelHtmlAttributes = HtmlHelper.AnonymousObjectToHtmlAttributes(viewBag.labelHtmlAttributes);
            else
                LabelHtmlAttributes = new RouteValueDictionary();

            if (viewBag.formGroupSize != null)
                FormGroupCssClass = ((FormGroupSizes)viewBag.formGroupSize).DisplayName();

            SetLabelAndFieldClass(viewBag.labelWidth);

            //InputHtmlAttributes.Add("class", "form-control");
            //LabelHtmlAttributes.Add("class", "control-label");
            //LabelHtmlAttributes.Add("class", this.LabelCssClass);

            InputHtmlAttributes["class"] += " form-control";
            LabelHtmlAttributes["class"] += " control-label";
            LabelHtmlAttributes["class"] += " " + this.LabelCssClass;
        }

        public void SetLabelAndFieldClass(int? labelWidth)
        {
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

        public string FormGroupCssClass { get; set; }
        public string LabelCssClass { get; set; }
        public string FieldCssClass { get; set; }

        //********

        public RouteValueDictionary LabelHtmlAttributes { get; set; }
        public RouteValueDictionary InputHtmlAttributes { get; set; }
    }
}