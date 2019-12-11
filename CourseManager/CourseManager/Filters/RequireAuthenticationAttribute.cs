using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http.Filters;
using System.Web.Mvc;

namespace CourseManager.Filters
{
    public class RequireAuthenticationAttribute : System.Web.Http.Filters.FilterAttribute, IauthotizationFilter
    {
        public void OnAuthorization(AuthorizationContext filterContext)
        { }
    }
}