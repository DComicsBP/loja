using System;
using System.Data.SqlClient;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Umbraco.Core;
using Umbraco.Core.Models;
using Umbraco.Web.Models;
using Loja.Models;
using umbraco;
using Umbraco.Web;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json;

namespace Loja.Util
{
    public static class Util
    {
        public static IPublishedContent FindHome(IPublishedContent node)
        {
            if (node.Level == 1) return node;

            else return FindHome(node.Parent);
        }

        public static ProductModels Card(IPublishedContent cont)
        {
            // faz a listagem das categorias 
            List<string> categoriesString = new List<string>();
            // faz a listagem do link das categorias 
            List<string> linkCategories = new List<string>();

            // instancia o Umbraco Helper
            UmbracoHelper umbracoHelper = new UmbracoHelper(Umbraco.Web.UmbracoContext.Current);
            // instancia novo objeto de card Model para fazer o molde das informações
            ProductModels cardModel = new ProductModels();
            // pega a lista de detalhes que cada produto poderá ter no admin do umbraco.             
            IEnumerable<IPublishedContent> details = cont.GetPropertyValue<IEnumerable<IPublishedContent>>("details");
            // itera o array de detalhes. 
            foreach (var item in details)
            {
                // como os produtos estão dispostos por categorias, primeiro se intera as categorias
                // um produto pode ter mais de uma categoria por isso da lista de categorias.
                var categories = item.GetPropertyValue<List<IPublishedContent>>("categories");

                foreach (var cat in categories)
                {
                    string nome = cat.Name;
                    string link = cat.Url;
                    categoriesString.Add(nome);
                    linkCategories.Add(link);
                }

                ModelItensProduct itensProduct = new ModelItensProduct()
                {
                    Amount = item.GetPropertyValue<string>("amount"),
                    Value = item.GetPropertyValue<string>("prodValue"),
                    Store = item.GetPropertyValue<string>("store"),
                    Categories = categoriesString,
                    LinksCategories = linkCategories
                };
                cardModel.Itens = itensProduct;
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

            if (cont.GetPropertyValue<int>("image") != 0) cardModel.Image = umbracoHelper.TypedMedia(cont.GetPropertyValue<int>("image")).Url;

            if (cont.Url != null) cardModel.UrlProduct = cont.Id;

            // if(numberOne!= null && numberTwo != null) { valores}

            return cardModel;
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
        public static List<string> GetLinkNameByType(IEnumerable<IPublishedContent> content)
        {
            List<string> nameStoreList = new List<string>();

            foreach (var cat in content)
            {
                var c = cat.ToString();

                nameStoreList.Add(c);
            }
            return nameStoreList;
        }

        public static Category GetCategoryName(int id)
        {
            var umbracoHelper = new Umbraco.Web.UmbracoHelper(Umbraco.Web.UmbracoContext.Current);

            Category categoria = new Category
            {
                ID = id,
                Name = umbracoHelper.TypedContent(id).Name
            };

            return categoria;
        }

        public static IPublishedContent FindParent(IPublishedContent Node)
        {
            if (Node == null)
            {
                return null;
            }

            if (PagesContentTypes.Contains(Node.DocumentTypeAlias))
                return Node;
            else
                return FindParent(Node.Parent);
        }

        public static IEnumerable<string> PagesContentTypes
        {
            get
            {
                return new[] { "home", "produto", "lojas", "trabalheConosco" };
            }
        }
    }
}