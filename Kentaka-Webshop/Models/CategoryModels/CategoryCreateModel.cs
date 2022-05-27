using System.ComponentModel.DataAnnotations;

namespace Kentaka_Webshop.Models.CategoryModels
{
    public class CategoryCreateModel
    {
        public CategoryCreateModel()
        {
        }


        [Display(Name = "Category name")]
        [Required(ErrorMessage = "You must enter a {0}")]
        [StringLength(50, ErrorMessage = "{0} must be atleast {2} characters long", MinimumLength = 2)]

        public string CategoryName { get; set; } = string.Empty;
    }
}
