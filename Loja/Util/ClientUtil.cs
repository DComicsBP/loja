using Loja.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Umbraco.Core.Models;

namespace Loja.Util
{
    public class ClientUtil
    {
        public List<CardFisicalStore> MainCardsFisical(IPublishedContent Content)
        {
            List<CardFisicalStore> list = new List<CardFisicalStore>();

            foreach (dynamic item in Content.Children)
            {
                var teste = item.XPoint; 
                CardFisicalStore card = new CardFisicalStore()
                {
                    Description = item.Description, 
                    Image = "", 
                    Title = item.Title,
                    XPoint = item.XPoint, 
                    YPoint = item.YPoint
                };

                list.Add(card); 
            }

            return list;
        }

        public string RenderCardsFisicalList(List<CardFisicalStore> list)
        {
            string content = ""; 

            foreach(var item in list)
            {
                content += "<p>" + item.Title + "<p/>"; 
                content += "<p>" + item.Description + "<p/>";
                content += "<p>" + item.Image + "<p/>";
                content += "<p>" + item.XPoint + "<p/>";
                content += "<p>" + item.YPoint + "<p/>";

            }

            return @""+content; 
        }

    }
}