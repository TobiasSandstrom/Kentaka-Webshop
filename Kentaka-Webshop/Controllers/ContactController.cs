using Kentaka_Webshop.Managers;
using Microsoft.AspNetCore.Mvc;

namespace Kentaka_Webshop.Controllers
{
    public class ContactController : Controller
    {
        public readonly CategoryManager _categorymManager;

        public ContactController(CategoryManager categorymManager)
        {
            _categorymManager = categorymManager;
        }
        [HttpGet]
        public IActionResult Index()
        {
            var categories = _categorymManager.GetAllAsync();
            return View(categories);
        }
        
    }
}
