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


        public async Task<List<CategoryViewModel>> GetAllAsync()
        {
            var entitiyList = await _context.Categories.ToListAsync();
            var categoryList = new List<CategoryViewModel>();
            foreach (var e in entitiyList)
            {
                CategoryViewModel category = new CategoryViewModel()
                {
                    CategoryName = e.CategoryName
                };

                category.CategoryName = e.CategoryName;
                categoryList.Add(category);
            }

            return categoryList;
        }

        public async Task<CategoryViewModel> GetOne(int id)
        {
            var entity = await _context.Categories.Where(x => x.Id == id).FirstOrDefaultAsync();
            var category = new CategoryViewModel();
            if (entity == null)
            {
                category.CategoryName = "";
                return category;
            }

            category.CategoryName = entity.CategoryName;
            return category;
        }

        public async Task<CategoryResult> UpdateAsync(CategoryUpdateModel model)
        {
            var entity = await _context.Categories.Where(x => x.Id == model.Id).FirstOrDefaultAsync();
            CategoryResult res = new CategoryResult();
            if (entity == null)
            {
                res.Result = false;
                res.Message = "Cant find category with that id";
                return res;
            }

            entity.CategoryName = model.NewCategoryName;
            _context.Categories.Update(entity);
            await _context.SaveChangesAsync();

            res.Result = true;
            res.Message = "Category updated succesfully";
            return res;
        }
    }
}
