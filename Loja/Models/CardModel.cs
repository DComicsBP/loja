using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Loja.Models
{
    public class CardModel
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Value { get; set; }
        public string Image { get; set; }
    }
}