using System.ComponentModel.DataAnnotations;

namespace Authenttication.Models
{
    public class Products
    {
        [Key]
        public Guid ProductsId { get; set; }
        [Required]
        public string ProductName { get; set; }
        [Required]
        public string Price { get; set; }
        [Required]
        public string Description { get; set; }
        [Required]
        public string Category { get; set; }
        [Required]
        public DateTime CreatedAt {  get; set; }= DateTime.Now;
        [Required]
        public DateTime UpdatedAt{  get; set; }= DateTime.Now;
    }
}
