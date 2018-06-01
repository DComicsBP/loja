using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Umbraco.Web.Mvc;
using System.Web.Mvc; 
namespace Loja.Controller
{
    public class MainController : SurfaceController
    {
        public ActionResult RenderContactUs()
        {
            return PartialView("~/Views/Patials/ContactUs.cshtml");
        }
    }
}