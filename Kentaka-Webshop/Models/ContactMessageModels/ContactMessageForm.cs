using System.ComponentModel.DataAnnotations;

namespace Kentaka_Webshop.Models.ContactMessageModels
{
    public class ContactMessageForm
    {
        [Display(Name = "Category")]
        [Required(ErrorMessage = "You need to choose a {0}")]
        public string CategoryName { get; set; }

        [Display(Name = "Subject")]
        [Required(ErrorMessage = "You need to enter a {0}")]
        [StringLength(50, ErrorMessage = "{0} must be atleast {2} characters", MinimumLength = 2)]
        public string Subject { get; set; }

        [Display(Name = "Name")]
        [Required(ErrorMessage = "You need to enter your {0}")]
        [StringLength(50, ErrorMessage = "{0} must be atleast {2} characters", MinimumLength = 2)]
        public string UserName { get; set; }

        [Display(Name = "Email")]
        [Required(ErrorMessage = "You need to enter a {0}")]
        [RegularExpression("^[a-zA-Z0-9_\\.-]+@([a-zA-Z0-9-]+\\.)+[a-zA-Z]{2,6}$", ErrorMessage = "{0} is not valid")]
        public string UserEmail { get; set; }


        [Display(Name = "Message")]
        [Required(ErrorMessage = "You need to enter a {0}")]
        [StringLength(500, ErrorMessage = "{0} must be atleast {2} characters", MinimumLength = 2)]
        public string UserMessage { get; set; }

    }
}
