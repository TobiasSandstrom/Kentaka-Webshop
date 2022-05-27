using Kentaka_Webshop.Models.CategoryModels;
using Kentaka_Webshop.Models.ContactMessageModels;

namespace Kentaka_Webshop.Models
{
    public class ContactDataModel
    {
        public ContactDataModel()
        {
        }

        public ContactMessageForm Form { get; set; } = new ContactMessageForm();
        public List<CategoryViewModel> Categories { get; set; } = new List<CategoryViewModel>();
        public ContactMessageResult Result { get; set; } = new ContactMessageResult();
    }
}
