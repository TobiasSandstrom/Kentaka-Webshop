using System.ComponentModel.DataAnnotations;

namespace Kentaka_Webshop.Entity
{
    public class TestProductEntity
    {
        [Key]
        public string Id { get; set; }
        public string Name { get; set; }
        public decimal price { get; set; }

    }
}
