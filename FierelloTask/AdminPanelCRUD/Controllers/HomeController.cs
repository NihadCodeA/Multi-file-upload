using AdminPanelCRUD.Models;
using Microsoft.AspNetCore.Mvc;

namespace AdminPanelCRUD.Controllers
{
    public class HomeController : Controller
    {
        private readonly Database _pustokContext;
        public HomeController(Database pustokContext)
        {
            _pustokContext = pustokContext;
        }
        public IActionResult Index()
        {
            List<Slider> Sliders = _pustokContext.Sliders.ToList();
            
            return View(Sliders);
        }
    }
}
