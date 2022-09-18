using Microsoft.AspNetCore.Mvc;

namespace AreaExample.Areas.fatura_paneli.Controllers
{
    [Area("fatura_paneli")]
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            TempData["data"] = "deneme";
            return RedirectToAction("Index","Home",new {area= "yonetim_paneli" });//arealar arası veri taşıma
        }
    }
}
