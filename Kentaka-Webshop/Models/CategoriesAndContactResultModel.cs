using Kentaka_Webshop.Models.CategoryModels;
using Kentaka_Webshop.Models.ContactMessageModels;

namespace Kentaka_Webshop.Models
{
    public class CategoriesAndContactResultModel
    {
        public List<CategoryViewModel>? Categories { get; set; }
        public ContactMessageResult? Result { get; set; }
    }
}
