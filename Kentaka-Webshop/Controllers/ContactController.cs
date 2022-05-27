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
            ViewBag.Controller = "Contact";
            ViewBag.Action = "Index";
            ViewBag.Title = "Contact";
            var result = new ContactDataModel();
            var categories = await _categoryManager.GetAllAsync();

            result.Categories = categories;

            return View(result);
        }

        [HttpPost]
        public async Task<IActionResult> Index(ContactMessageForm form)
        {
            ViewBag.Controller = "Contact";
            ViewBag.Action = "Index";
            ViewBag.Title = "Contact";
            var result = new ContactDataModel();
            var categories = await _categoryManager.GetAllAsync();
            result.Categories = categories;
            var _res = new ContactMessageResult();
            if (ModelState.IsValid)
            {
                result.Result = await _messageManager.CreateAsync(form);
                ModelState.Clear();
                return View(result);
                
            }
            _res.Message = "Modelstate invalid";
            result.Result = _res;
            return View(result);
        }

    }
}
