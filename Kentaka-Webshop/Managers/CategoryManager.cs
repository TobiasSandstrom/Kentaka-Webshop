using Kentaka_Webshop.Data;
using Kentaka_Webshop.Entity;
using Kentaka_Webshop.Models.CategoryModels;
using Microsoft.EntityFrameworkCore;

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




        public async Task<CategoryResult> CreateAsync(CategoryCreateModel model)
        {
            var oldCategory = await _context.Categories.Where(x => x.CategoryName == model.CategoryName).FirstOrDefaultAsync();

            if (oldCategory != null)
            {
                CategoryResult res = new CategoryResult
                {
                    Result = false,
                    Message = "Category with that name already exists"
                };

                return res;
            }

            CategoryEntity newCategory = new CategoryEntity
            {
                CategoryName = model.CategoryName
            };

            await _context.Categories.AddAsync(newCategory);
            _context.SaveChanges();
            CategoryResult result = new CategoryResult
            {
                Result = true,
                Message = "Category created succesfully"
            };

            return result;
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
