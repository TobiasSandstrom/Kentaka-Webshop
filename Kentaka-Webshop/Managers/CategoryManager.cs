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
            Task<CategoryResult> DeleteAsync(int id);
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
            CategoryResult res = new CategoryResult();
            if (oldCategory != null)
            {
                res.Result = false;
                res.Message = "Category with that name already exists";
                return res;
            }

            CategoryEntity newCategory = new CategoryEntity
            {
                CategoryName = model.CategoryName
            };

            await _context.Categories.AddAsync(newCategory);
            await _context.SaveChangesAsync();

            res.Result = true;
            res.Message = "Category created succesfully";


            return res;
        }


        public async Task<CategoryResult> DeleteAsync(int id)
        {
            CategoryEntity entity = await _context.Categories.FindAsync(id);
            CategoryResult res = new CategoryResult();
            if (entity == null)
            {
                res.Result = false;
                res.Message = "Cant find category with that id";
                return res;
            }

            _context.Categories.Remove(entity);
            await _context.SaveChangesAsync();
            res.Result = true;
            res.Message = "Category removed succesfully";
            return res;
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
