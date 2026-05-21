using System.ComponentModel.DataAnnotations;

namespace session8.ViewModel
{
    public class AddProductsViewModel
    {
        [Required]
        public string name { get; set; }
        [Required]
        public int price { get; set; }
        [Required]
        public string description { get; set; }
        [Required]
        public int stock { get; set; }
        [Required]
        public string category { get; set; }
        
    }
}
