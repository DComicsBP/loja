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
            CardModel cardModel = new CardModel(); 
            var umbracoHelper = new Umbraco.Web.UmbracoHelper(Umbraco.Web.UmbracoContext.Current);
          
         

                cardModel.ID = cont.Id;
                cardModel.Name = cont.GetPropertyValue<string>("prodName");
                cardModel.Description = cont.GetPropertyValue<string>("prodDescription");
                cardModel.Value = cont.GetPropertyValue<string>("prodValue");
                if(cont.GetPropertyValue<int>("imageProduct") !=  0)
                {
                    cardModel.Image = umbracoHelper.TypedMedia(cont.GetPropertyValue<int>("imageProduct")).Url;
                }
                if(cont.GetPropertyValue<IEnumerable<IPublishedContent>>("categories") != null)
                {
                     cardModel.CategoryList = GetCategoriesName(cont.GetPropertyValue<IEnumerable<IPublishedContent>>("categories")).ToList();

                }




            return cardModel;
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