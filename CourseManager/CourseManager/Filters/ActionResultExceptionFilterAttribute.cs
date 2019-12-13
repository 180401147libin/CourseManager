using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CourseManager.Filters
{
    public class ActionResultExceptionFilterAttribute : ActionFilterAttribute,IExceptionFilter
    {
        public void OnException(ExceptionContext filterContext)
        {
            filterContext.ExceptionHandled = true;
            if (filterContext.Exception is UnauthorizedException)
            {
                //filerContext.Result = new RedirectResult("/Account/Index");
               
            }
        }
    }
}