using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Kentaka_Webshop.Entity
{
    public class ContactUsMessageEntity
    {
        [Key]
        public int Id { get; set; }

        [Required,Column(TypeName ="Nvarchar(50)")]
        public string CategoryName { get; set; }

        [Required,Column(TypeName ="Nvarchar(50)")]
        public string Subject { get; set; }
        
        [Required, Column(TypeName = "Nvarchar(50)")]
        public string UserName { get; set; }

        [Required, Column(TypeName = "Nvarchar(100)")]
        public string UserEmail { get; set; }

        [Required, Column(TypeName = "Nvarchar(500)")]
        public string UserMessage { get; set; }

    }
}
