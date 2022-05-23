using System.ComponentModel.DataAnnotations;

namespace Kentaka_Webshop.Models.CategoryModels
{
    public class CategoryUpdateModel
    {
        public CategoryUpdateModel()
        {
        }

        public int Id { get; set; }


        [Required(ErrorMessage = "You have to enter the old {0}")]
        public string OldCategoryName { get; set; }


        [Display(Name ="category name")]
        [Required(ErrorMessage = "You have to enter the new {0}")]
        [StringLength(50, ErrorMessage = "{0} must be atleast {2} characters long", MinimumLength = 2)]
        public string NewCategoryName { get; set; }
    }
}
