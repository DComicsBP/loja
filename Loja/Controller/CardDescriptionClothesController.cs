using System.Web.Mvc;
using Umbraco.Web.Mvc;
using Loja.Models; 

namespace Loja.Controller
{
    public class CardDescriptionClothesController : SurfaceController
    {
       [HttpGet]
        public ActionResult Index(CardModel model)
        {
         

            return Json(model);
        }
    }
}
    
