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
         
            return new CardModel
            {
                ID = cont.Id,
                Name = cont.GetPropertyValue<string>("prodName"),
                Description = cont.GetPropertyValue<string>("prodDescription"),
                Value = cont.GetPropertyValue<string>("prodValue"),
                Image = cont.GetPropertyValue<string>("imageProduct")
            };
        }

      

    }
}