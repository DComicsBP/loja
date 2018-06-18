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
            var umbracoHelper = new Umbraco.Web.UmbracoHelper(Umbraco.Web.UmbracoContext.Current);

            return new CardModel
            {
                ID = cont.Id,
                Name = cont.GetPropertyValue<string>("prodName"),
                Description = cont.GetPropertyValue<string>("prodDescription"),
                Value = cont.GetPropertyValue<string>("prodValue"),
                Image = umbracoHelper.TypedMedia(cont.GetPropertyValue<int>("imageProduct")).Url,
                CategoryList = GetCategoriesName(cont.GetPropertyValue<IEnumerable<IPublishedContent>>("categories")).ToList()
            };
        }


        public static List<Category> GetCategoriesName(IEnumerable<IPublishedContent> content)
        {
            List<Category> categoryList = new List<Category>(); 

            foreach(var cat in content)
            {
                Category c = new Category();
                c.ID = cat.Id;
                c.Name = cat.Name;
                categoryList.Add(c);
                
            }
            return categoryList;
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