using System;
using System.Collections.Generic;
using Umbraco.Core.Models;
using Umbraco.Web.Models;

namespace Loja.Models
{
    public class ProductModels
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Value { get; set; }
        public string Image { get; set; }
        public int UrlProduct{ get; set; }
        public string UrlCategories { get; set; }
        public ModelItensProduct Itens{ get; set; }
    }

    public class Category
    {
        public int ID { get; set; }
        public string  Name { get; set; }
    }
    public class ModelItensProduct
    {
        public List<string> Categories { get; set; }
        public List<string> LinksCategories { get; set; }
        public string Amount { get; set; }
        public string Store { get; set; }
        public  string Value { get; set; }


    }
  
}