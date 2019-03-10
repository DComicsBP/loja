using System;
using System.Collections.Generic;
using Umbraco.Core.Models;
using Umbraco.Web.Models;

namespace Loja.Models
{
    public class CardModel
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Value { get; set; }
        public string Image { get; set; }
        public ModelItensProduct Itens{ get; set; }
    }

    public class Category
    {
        public int ID { get; set; }
        public string  Name { get; set; }
    }
    public class ModelItensProduct
    {
        public string  Key { get; set; }
        public string NcContentTypeAlias { get; set; }
        public List<string> Categories { get; set; }
        public string Amount { get; set; }
        public string Store { get; set; }
        public  string Value { get; set; }



    }
  
}