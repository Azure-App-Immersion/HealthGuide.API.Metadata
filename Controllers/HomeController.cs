using Microsoft.AspNetCore.Mvc;

namespace HealthGuide.API.Metadata.Controllers
{
    public class HomeController : Controller 
    {        
        public IActionResult Index()
        {
            return View();
        }
    }
}