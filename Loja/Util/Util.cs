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

        public static CardModel Card(IPublishedContent cont)
        {
            UmbracoHelper umbracoHelper = new UmbracoHelper();
            
            CardModel cardModel = new CardModel();

            string description = cont.GetPropertyValue<string>("description"); 
            string name = cont.GetPropertyValue<string>("prodName");
            //   string urlImage = cont.GetPropertyValue<string>("image").FormatUrl();
             List<IPublishedContent> objectJson = cont.GetPropertyValue<List<IPublishedContent>>("details");
            foreach(var item in objectJson)
            {
                var categories = item.GetPropertyValue<IEnumerable<IPublishedContent>>("categories");
                List<string> categoriesString = new List<string>(); 
                 foreach(var cat in categories)
                {
                    string nome = cat.Name;
                    categoriesString.Add(nome);
                }

                ModelItensProduct itensProduct = new ModelItensProduct()
                {
                    Amount = item.GetPropertyValue<string>("amount"),
                    Value = item.GetPropertyValue<string>("prodValue"), 
                    Store = item.GetPropertyValue<string>("store"), 
                    Categories = categoriesString
                };

            cardModel.Itens = itensProduct;

            }

            //var teste = objectJson.TryConvertTo(c); 
            cardModel.Name = cont.GetPropertyValue<string>("productsName");


            if (cont.GetPropertyValue<int>("imageProduct") != 0)
            {
                cardModel.Image = umbracoHelper.TypedMedia(cont.GetPropertyValue<int>("imageProduct")).Url;
            }


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