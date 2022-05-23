using Kentaka_Webshop.Data;
using Kentaka_Webshop.Entity;
using Kentaka_Webshop.Models.CategoryModels;

namespace Kentaka_Webshop.Managers
{
        public interface ICategoryManager
        {
            Task<CategoryResult> CreateAsync(CategoryCreateModel model);
            Task<CategoryResult> UpdateAsync(CategoryUpdateModel model);
            Task<CategoryViewModel> GetOne(int id);
            Task<List<CategoryViewModel>> GetAllAsync();
            Task DeleteAsync(int id);
        }

    public class CategoryManager : ICategoryManager
    {

        private readonly SqlDbContext _context;

        public CategoryManager(SqlDbContext context)
        {
            _context = context;
        }


        public Task<CategoryResult> CreateAsync(CategoryCreateModel model)
        {
            throw new NotImplementedException();
        }

        public Task DeleteAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<List<CategoryViewModel>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public Task<CategoryViewModel> GetOne(int id)
        {
            throw new NotImplementedException();
        }

        public Task<CategoryResult> UpdateAsync(CategoryUpdateModel model)
        {
            throw new NotImplementedException();
        }
    }
}
