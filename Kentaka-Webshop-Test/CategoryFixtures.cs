using Kentaka_Webshop.Entity;
using Kentaka_Webshop.Models.CategoryModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kentaka_Webshop_Test
{
    public static class CategoryFixtures
    {
        private static List<CategoryViewModel> categoryEntities = new List<CategoryViewModel>
        {
            new CategoryViewModel { CategoryName = "Skor"},
            new CategoryViewModel { CategoryName = "Byxor"},
            new CategoryViewModel { CategoryName = "Mössor och Kepsar"}
        };
        public static async Task<List<CategoryViewModel>> GetCategoriesAsync()
        {
            return categoryEntities;
        }
    }
}
