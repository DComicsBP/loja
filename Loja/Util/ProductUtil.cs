using Loja.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Umbraco.Core.Models;
using Umbraco.Web;

namespace Loja.Util
{
    public class ProductUtil
    {
        public List<ProductModels> ListProduct(List<IPublishedContent> Contents)
        {
            List<ProductModels> list = new List<ProductModels>();
            foreach (var item in Contents)
            {
                list.Add(Card(item));
            }
            return list;
        }

        private static ProductModels Card(IPublishedContent cont)
        {
            // faz a listagem das categorias 
            List<string> categoriesString = new List<string>();
            // faz a listagem do link das categorias 
            List<string> linkCategories = new List<string>();

            // instancia o Umbraco Helper
            var umbracoHelper = new Umbraco.Web.UmbracoHelper(UmbracoContext.Current);
            // instancia novo objeto de card Model para fazer o molde das informações
            ProductModels cardModel = new ProductModels();
            // pega todas as categorias e os seus produtos
            var details = cont.ContentSet;
            // itera o array de detalhes. 
            foreach (var item in details)
            {
                // como os produtos estão dispostos por categorias, primeiro se intera as categorias
                // um produto pode ter mais de uma categoria por isso da lista de categorias.
                var products = item.Children;

                foreach (var prod in products)
                {
                    ModelItensProduct itensProduct = new ModelItensProduct()
                    {
                        Amount = item.GetPropertyValue<string>("amount"),
                        Value = item.GetPropertyValue<string>("prodValue"),
                        Store = item.GetPropertyValue<string>("store"),
                        Categories = categoriesString,
                        LinksCategories = linkCategories
                    };
                }


              //   cardModel.Itens = itensProduct;
            }

            string numberOne = "", numberTwo = "";

            if (details.First().GetPropertyValue<string>("prodValue") != null) numberOne = details.First().GetPropertyValue<string>("prodValue");

            if (details.Count() > 1)
            {
                if (details.Last().GetPropertyValue<string>("prodValue") != null) numberTwo = details.Last().GetPropertyValue<string>("prodValue");
            }
            else
            {
                cardModel.Value = "Valor de mercado: R$" + numberOne;
            }
            cardModel.Value = "Valor variando entre R$" + numberOne + " e R$" + numberTwo;

            if (cardModel.Name != null) cardModel.Name = cont.GetPropertyValue<string>("productsName");

            if (cont.GetPropertyValue<string>("description") != null) cardModel.Description = cont.GetPropertyValue<string>("description");

            //if (cont.GetPropertyValue<int>("image") != 0) cardModel.Image = umbracoHelper.TypedMedia(cont.GetPropertyValue<int>("image")).Url;

            //if (cont.Url != null) cardModel.UrlProduct = cont.Id;

            // if(numberOne!= null && numberTwo != null) { valores}

            return cardModel;
        }

        public string ListToCardProducts(List<ProductModels> list)
        {
            return "null";
        }

        public static List<Category> GetCategoriesName(IEnumerable<IPublishedContent> content)
        {
            List<Category> categoryList = new List<Category>();

            foreach (var cat in content)
            {
                Category c = new Category();
                c.ID = cat.Id;
                c.Name = cat.Name;
                categoryList.Add(c);

            }
            return categoryList;
        }

    }
}