using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;
//using System.Web.Mvc.Html;

namespace BootstrapExtensionsMVC.Models
{
    public abstract class BootstrapComponent : IHtmlString
    {
        protected TagBuilder tb;
        internal Tags tag;
        internal BootstrapElements elementType;
        private List<string> cssClasses = new List<string>();
        private bool tbPrepared = false;

        internal BootstrapComponent(Tags tag, BootstrapElements type)
        {
            this.Attributes = new Dictionary<string, object>();
            this.tag = tag;
            elementType = type;
        }

        protected List<IHtmlString> childItems = new List<IHtmlString>(); 

        internal IDictionary<string, object> Attributes { get; set; }
        internal string InnerHtml { get; set; }
        
        internal void AddCssClass(string cssClass)
        {
            if (!string.IsNullOrEmpty(cssClass.Trim()))
            {
                if (!cssClasses.Contains(cssClass))
                    cssClasses.Add(cssClass);
            }
        }

        internal void AddChild(IHtmlString item)
        {
            childItems.Add(item);
        }

        public virtual string ToHtmlString()
        {
            if (tbPrepared == false)
            {
                PrepareTagBuilder();
                return tb.ToString() + Environment.NewLine;
            }
            else
            {
                return tb.ToString(TagRenderMode.EndTag) + Environment.NewLine;
            }
            
        }

        internal class _bootstrapComponent : BootstrapComponent
        {
            internal _bootstrapComponent(Tags tag, BootstrapElements type)
                :base(tag, type)
            {
            
            }
        }

        protected void PrepareTagBuilder()
        {
            tb = new TagBuilder(tag.DisplayName());

            string el = elementType.DisplayName();
            if (!string.IsNullOrEmpty(el))
                AddCssClass(el);

            if (Attributes.ContainsKey("class"))
                AddCssClass(Attributes["class"].ToString());

            foreach (string css in cssClasses)
                tb.AddCssClass(css);

            tb.MergeAttributes(Attributes);

            if (childItems.Count > 0)
            {
                var sb = new StringBuilder();

                if (!string.IsNullOrEmpty(this.InnerHtml))
                    sb.AppendLine(this.InnerHtml);

                foreach (var child in childItems)
                    sb.AppendLine(child.ToHtmlString());

                tb.InnerHtml = sb.ToString();
                this.InnerHtml = sb.ToString();
            }
            else if (!string.IsNullOrEmpty(this.InnerHtml))
            {
                tb.InnerHtml = this.InnerHtml;
            }

            tbPrepared = true;
        }
    }

    public abstract class BootstrapContainer<TModel> : BootstrapComponent, IDisposable
    {
        protected HtmlHelper<TModel> helper;

        //internal BootstrapContainer(HtmlHelper<TModel> helper, Tags tag, BootstrapElements type, object htmlAttributes = null) : base(tag, type)
        //{
        //    this.helper = helper;
        //    if (htmlAttributes != null)
        //        Attributes = (IDictionary<string, object>)HtmlHelper.AnonymousObjectToHtmlAttributes(htmlAttributes);
        //}

        internal BootstrapContainer(HtmlHelper<TModel> helper, Tags tag, BootstrapElements type, object htmlAttributes = null, IEnumerable<IHtmlString> children = null)
            : base(tag, type)
        {
            this.helper = helper;
            if (htmlAttributes != null)
                Attributes = (IDictionary<string, object>)HtmlHelper.AnonymousObjectToHtmlAttributes(htmlAttributes);

            if (children != null)
                childItems.AddRange(children);
        }

        protected internal void StartTag()
        {
            PrepareTagBuilder();
            helper.ViewContext.Writer.Write(base.tb.ToString(TagRenderMode.StartTag));
            if (!string.IsNullOrEmpty(this.InnerHtml))
                helper.ViewContext.Writer.Write(this.InnerHtml);
        }

        

        public void Dispose()
        {
            helper.ViewContext.Writer.Write(tb.ToString(TagRenderMode.EndTag));
        }
    }
}
