﻿using System.Web.Mvc;

namespace Projeto.API
{
    public class FilterConfig
    {
        protected FilterConfig()
        { }

        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
