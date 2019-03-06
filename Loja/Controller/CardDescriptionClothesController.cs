using System.Web.Mvc;
using Umbraco.Web.Mvc;
using Umbraco.Core.Models;
using System.Collections.Generic;
using Umbraco.Web;

namespace Loja.Controller
{
    public class CardDescriptionClothesController : SurfaceController
    {
        public ActionResult FilterProducts(int[] CategoriesID, int ProductID)
        {
            var ProductComponent = Umbraco.TypedContent(ProductID);

            var Products = new List<IPublishedContent>(); 

            foreach (var Node in ProductComponent.GetPropertyValue<List<IPublishedContent>>("card"))
            {
                if (Node.DocumentTypeAlias == "card")
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
            return Json(Products);
        }
    }
}
    
