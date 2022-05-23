using Kentaka_Webshop.Entity;

namespace Kentaka_Webshop.Managers
{
    public class CategoryManager
    {
        public interface ICategoryManager
        {
            Task<CategoryResult> CreateAsync(CategoryCreateModel model);
            Task<CategoryResult> UpdateAsync(CategoryUpdateModel model);
            Task<CategoryViewModel> GetOne(int id);
            Task<List<CategoryViewModel>> GetAllAsync();
            Task DeleteAsync(int id);
        }
    }
}
