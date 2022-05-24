using Kentaka_Webshop.Models.CategoryModels;
using Kentaka_Webshop.Models.ContactMessageModels;

namespace Kentaka_Webshop.Models
{
    public class ContactDataModel
    {
        public ContactDataModel()
        {
        }

        public ContactMessageForm Form { get; set; } = null!;
        public List<CategoryViewModel> Categories { get; set; } = null!;
        public ContactMessageResult Result { get; set; } = null!;
    }
}
