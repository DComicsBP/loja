﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Umbraco.Web.Mvc;

namespace Loja.Controller
{
    public class HomeController : SurfaceController
    {
        
        public ActionResult Index()
        {
            return View();
        }
    }
}