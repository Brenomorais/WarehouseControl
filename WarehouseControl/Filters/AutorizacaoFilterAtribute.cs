using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace CaelumEstoque.Filters
{
    public class AutorizacaoFilterAtribute : ActionFilterAttribute
    {
        public override void OnActionExecuting(ActionExecutingContext filterContext)
        {
            if (filterContext.Controller.GetType().Name != "LoginController")
            {
                object usuarioLogado = filterContext.HttpContext.Session["usuarioLogado"];
                if (usuarioLogado == null)
                {
                    filterContext.Result = new RedirectToRouteResult(
                        new RouteValueDictionary(
                            new { action = "Index", controller = "Login" }));
                }
            }
        }

    }
}