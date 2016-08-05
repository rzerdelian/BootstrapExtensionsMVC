using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Linq.Expressions;
using System.Web.Mvc;

namespace BootstrapExtensionsMVC.Models
{
    public class InputGroup<TModel, TValue>: BootstrapComponent
    {

        internal InputGroup(ViewContext viewContext, Expression<Func<TModel, TValue>> expr)
            : base(Tags.Div, BootstrapElements.InputGroup)
        {

            
            //ModelMetadata meta = ModelMetadata.FromLambdaExpression<TModel, TValue>(expr, viewContext.ViewData);
        }

    }
}