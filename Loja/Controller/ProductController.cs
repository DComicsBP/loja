using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Umbraco.Web.Mvc;
using Umbraco.Core.Models;
using Umbraco.Web;
using Umbraco.Web.Mvc;
using Loja.Models;
using Examine;
using Umbraco.Web.Models;
using System.Globalization;

namespace Loja.Controller
{
    public class ProductController : SurfaceController
    {
            public ProductController()
            : this(UmbracoContext.Current)
            {
            }

            public ProductController(UmbracoContext umbracoContext)
                : base(umbracoContext)
            {
            }

            public ActionResult Index(string id)
            {
            var criteria = ExamineManager.Instance.DefaultSearchProvider.CreateSearchCriteria("content");
            var filter = criteria.NodeTypeAlias("card").And().NodeName(id.Replace("-", " "));

            var result = Umbraco.TypedSearch(filter.Compile()).ToArray();


            if (!result.Any())
            {
                throw new HttpException(404, "No product");
            }

            return View("PageProduct", CreateRenderModel(result.First()));
        }

        private RenderModel CreateRenderModel(IPublishedContent content)
        {
            var model = new RenderModel(content, CultureInfo.CurrentUICulture);

            //add an umbraco data token so the umbraco view engine executes
            RouteData.DataTokens["umbraco"] = model;

            return model;
        }
    }



    }
