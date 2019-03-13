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