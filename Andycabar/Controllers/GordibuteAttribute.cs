using System;
using System.Web.Mvc;

namespace Andycabar.Controllers
{
    internal class GordibuteAttribute : ActionFilterAttribute, IActionFilter
    {

        //public override void OnActionExecuting(HttpActionContext actionContext)
        public override void OnActionExecuting(ActionExecutingContext actionContext)
        {
            bool CanAccess = false;
            try
            {
                if (actionContext.HttpContext.Session["Username"] != null)
                    CanAccess = true;
            }
            catch
            {
                CanAccess = false;
            }
            if (!CanAccess)
                actionContext.Result = new HttpUnauthorizedResult();
        }
    }
}