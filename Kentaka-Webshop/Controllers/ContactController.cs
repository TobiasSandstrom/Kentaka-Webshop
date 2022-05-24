using Kentaka_Webshop.Managers;
using Kentaka_Webshop.Models;
using Kentaka_Webshop.Models.ContactMessageModels;
using Microsoft.AspNetCore.Mvc;

namespace Kentaka_Webshop.Controllers
{
    public class ContactController : Controller
    {
        public readonly ICategoryManager _categoryManager;
        public readonly IMessageManager _messageManager;

        public ContactController(ICategoryManager categoryManager, IMessageManager messageManager = null)
        {
            _categoryManager = categoryManager;
            _messageManager = messageManager;
        }


        [HttpGet]
        public async Task<IActionResult> Index()
        {
            var categories = await _categoryManager.GetAllAsync();
            var result = new ContactDataModel();

            result.Categories = categories;

            return View(result);
        }

        [HttpPost]
        public async Task<IActionResult> Index(ContactMessageForm form)
        {
            var result = new ContactDataModel();

            if (ModelState.IsValid)
            {
                
                result.Result = await _messageManager.CreateAsync(form);
                return View(result);
                
            }

            result.Result.Message = "Modelstate invalid";
            return View(result);
        }

    }
}
