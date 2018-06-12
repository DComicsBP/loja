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

namespace Loja.Controller
{
    public class ProductController : SurfaceController
    {
        public class ProductsController : SurfaceController
        {
            public ActionResult Index(int[] CategoriesID, int ProductID)
            {
                var ProductComponent = Umbraco.TypedContent(ProductID);

                var Products = new List<IPublishedContent>(); //ProductComponent.GetPropertyValue<IEnumerable<IPublishedContent>>("productComponentProducts");

                foreach (var Node in ProductComponent.GetPropertyValue<List<IPublishedContent>>("cards"))
                {
                    if (Node.DocumentTypeAlias == "categories")
                    {
                        foreach (var Product in Node.Children)
                        {
                            Products.Add(Product);
                        }
                    }
                    else
                    {
                        Products.Add(Node);
                    }
                }

                IEnumerable<IPublishedContent> FilteredProducts = null;

                if (CategoriesID != null)
                {
                    FilteredProducts = Products.Where(x => x.HasValue("categories") && CategoriesID.Intersect(GetCategoriesID(x.GetProperty("categories"))).Count() == CategoriesID.Length);
                }
                else
                {
                    FilteredProducts = Products;
                }

                List<CardModel> cardList = new List<CardModel>();

                foreach (var Content in FilteredProducts)
                {
                    CardModel card = Util.Util.Card(Content);

                    cardList.Add(card);
                }

                return Json(cardList);
            }


            private int[] GetCategoriesID(IPublishedProperty Property)
            {
                return Property.GetValue<List<IPublishedContent>>().Select(x => x.Id).ToArray();
            }

            private string[] GetCategoriesName(IPublishedProperty Property)
            {
                return Property.GetValue<List<IPublishedContent>>().Select(x => x.Name).ToArray();
            }
        }
    }
}