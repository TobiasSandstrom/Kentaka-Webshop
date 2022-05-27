using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Kentaka_Webshop.Entity
{
    public class CategoryEntity
    {
        [Key]
        public int Id { get; set; }
        
        [Required]
        [Column(TypeName = "Nvarchar(50)")]
        public string CategoryName { get; set; }

    }
}
