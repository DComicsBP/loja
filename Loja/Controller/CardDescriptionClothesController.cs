using System.Web.Mvc;
using Umbraco.Web.Mvc;
using Loja.Models; 

namespace Loja.Controller
{
    public class CardDescriptionClothesController : SurfaceController
    {
        // GET: CardDescriptionClothes

        public const string PARTIAL_CARD = "~/Views/Partials/Products/CardDescriptionClothes.cshtml";
        [HttpGet]
        public ActionResult Index(CardModel model)
        {
            return PartialView(PARTIAL_CARD);
        }
    }
}