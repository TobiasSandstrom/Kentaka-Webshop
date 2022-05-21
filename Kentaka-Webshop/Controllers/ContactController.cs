using Microsoft.AspNetCore.Mvc;

namespace Kentaka_Webshop.Controllers
{
    public class ContactController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
