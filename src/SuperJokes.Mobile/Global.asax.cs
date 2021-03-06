﻿using Joke.BusinessLogic;
using Joke.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace SuperJokes.Mobile
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);

            LogHelper.LogConfig(Server.MapPath(@"~\App_Data\log4net.config"));
            DtoMapper.AutoMapper();
        }
    }
}
