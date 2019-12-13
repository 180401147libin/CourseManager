using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http.Filters;
using System.Web.Mvc;

namespace CourseManager.Filters
{
    public class RequireAuthenticationAttribute : System.Web.Http.Filters.FilterAttribute, System.Web.Http.Filters.IAuthorizationFilter
    {
        public void OnAuthorization(AuthorizationContext filterContext)
        {
            if (filterContext.HttpContext.Session != null)
            {
                var user = filterContext.HttpContext.Session["user"].ToString();
                if (!string.IsNullOrWhiteSpace(user))
                {
                    return;
                }

                var cookie = filterContext.HttpContext.Request.Cookies["user"];
                if(!string.IsNullOrEmpty(cookie.Value))
                {
                    return;
                }
                else
                {
                    throw new UnauthorizedException();
                }

            }
        }
    
public System.Threading.Tasks.Task<System.Net.Http.HttpResponseMessage> ExecuteAuthorizationFilterAsync(System.Web.Http.Controllers.HttpActionContext actionContext, System.Threading.CancellationToken cancellationToken, Func<System.Threading.Tasks.Task<System.Net.Http.HttpResponseMessage>> continuation)
{
 	throw new NotImplementedException();
}
}

}