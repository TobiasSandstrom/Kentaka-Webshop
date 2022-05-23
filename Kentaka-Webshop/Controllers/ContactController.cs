using Kentaka_Webshop.Managers;
using Microsoft.AspNetCore.Mvc;

namespace Kentaka_Webshop.Controllers
{
    public class ContactController : Controller
    {
        public readonly ICategoryManager _categoryManager;

        public ContactController(ICategoryManager categoryManager)
        {
            _categoryManager = categoryManager;
        }


        [HttpGet]
        public async Task<IActionResult> Index()
        {
            var categories = await _categoryManager.GetAllAsync();
            return View(categories);
        }
        
    }
}
