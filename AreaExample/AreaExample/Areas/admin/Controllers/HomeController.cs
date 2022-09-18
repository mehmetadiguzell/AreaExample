using Microsoft.AspNetCore.Mvc;

namespace AreaExample.Areas.admin.Controllers
{
    [Area("yonetim_paneli")] //program.cs'de kendise ait oluşturulan rota da areaName ile aynı isimde olmalıdır
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            var data = TempData["data"];
            return View();
        }
    }
}
