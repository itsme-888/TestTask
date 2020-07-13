using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using System.Web.Mvc;
using System.Web.Routing;

namespace TryPassFirstTask.Controllers
{
    public class MyController: IController
    {
        public void Execute(RequestContext requestContext)
        {
            string ip =requestContext.HttpContext.Request.UserHostAddress;
            string browser = requestContext.HttpContext.Request.Browser.Type;
            var response = requestContext.HttpContext.Response;
            response.Write("<h2> IP: " + ip + " Browser: " + browser + "</h2>");
        }
    }
}