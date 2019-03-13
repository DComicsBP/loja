using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Loja.Models
{
    public class CardStore
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public string Image { get; set; }
    }

    public class CardFisicalStore : CardStore
    {
        public string XPoint { get; set; }
        public string YPoint { get; set; }
    }


   
}