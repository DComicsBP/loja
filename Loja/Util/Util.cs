using System;
using System.Data.SqlClient;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Umbraco.Core;
using Umbraco.Core.Models;
using Umbraco.Web.Models;

namespace Loja.Util
{
    public static class Util
    {

        public static IPublishedContent FindHome(IPublishedContent node)
        {
            if (node.Level == 1) return node;
            else return FindHome(node.Parent);
        }

    }
}