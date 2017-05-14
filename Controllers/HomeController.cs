using Microsoft.AspNetCore.Mvc;

namespace HealthcareAPI.Controllers
{
    public class HomeController : Controller {
        
        public IActionResult Index()
        {
            return View();
        }
    }
}