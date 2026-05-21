using System.ComponentModel.DataAnnotations;

namespace session8.Models
{
    public class AddProducts
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string name {  get; set; }
        [Required]
        public string description { get; set; }
        [Required]
        public int stock { get; set; }
        [Required]
        public string category { get; set; }
        [Required]
        public DateTime CreatedAt { get; set; }=DateTime.Now; 
        [Required]
        public DateTime UpdatedAt { get; set; } = DateTime.Now;
    }
}
