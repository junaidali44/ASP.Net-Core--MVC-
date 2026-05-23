using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ABCDMallWebsite.Models
{
    [Table("Shops")]
    public class Shop
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [StringLength(100)]
        [Display(Name = "Shop Name")]
        public string Name { get; set; } = string.Empty;

        [Required]
        [StringLength(50)]
        [Display(Name = "Category")]
        public string Category { get; set; } = string.Empty;

        [StringLength(500)]
        [Display(Name = "Description")]
        public string Description { get; set; } = string.Empty;

        [Display(Name = "Shop Image")]
        public string? ImageUrl { get; set; }

        [Display(Name = "Floor Number")]
        [Range(1, 4)]
        public int FloorNumber { get; set; }

        [Display(Name = "Shop Number")]
        [StringLength(20)]
        public string ShopNumber { get; set; } = string.Empty;

        [Display(Name = "Contact Number")]
        [Phone]
        [StringLength(15)]
        public string ContactNumber { get; set; } = string.Empty;

        [Display(Name = "Opening Time")]
        public string OpeningTime { get; set; } = "10:00 AM";

        [Display(Name = "Closing Time")]
        public string ClosingTime { get; set; } = "10:00 PM";

        [Display(Name = "Rating")]
        [Range(0, 5)]
        public decimal Rating { get; set; } = 0;

        [Display(Name = "Number of Reviews")]
        public int ReviewCount { get; set; } = 0;

        [Display(Name = "Is Active")]
        public bool IsActive { get; set; } = true;

        [Display(Name = "Created At")]
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;

        [Display(Name = "Updated At")]
        public DateTime? UpdatedAt { get; set; }

        // Additional fields
        [StringLength(200)]
        public string? Website { get; set; }

        [StringLength(200)]
        public string? Instagram { get; set; }

        [StringLength(200)]
        public string? Facebook { get; set; }
    }
}