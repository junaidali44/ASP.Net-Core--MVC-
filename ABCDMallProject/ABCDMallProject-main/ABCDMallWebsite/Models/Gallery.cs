using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ABCDMallWebsite.Models
{
    [Table("Galleries")]
    public class Gallery
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [Display(Name = "Image")]
        public string ImageUrl { get; set; } = string.Empty;

        [StringLength(200)]
        [Display(Name = "Caption")]
        public string Caption { get; set; } = string.Empty;

        [Required]
        [StringLength(50)]
        [Display(Name = "Category")]
        public string Category { get; set; } = string.Empty; // Mall, Shop, Food, Event

        [Display(Name = "Display Order")]
        public int DisplayOrder { get; set; } = 0;

        [Display(Name = "Uploaded At")]
        public DateTime UploadedAt { get; set; } = DateTime.UtcNow;

        [StringLength(100)]
        [Display(Name = "Uploaded By")]
        public string? UploadedBy { get; set; }

        [Display(Name = "Is Active")]
        public bool IsActive { get; set; } = true;

        [Display(Name = "Alt Text")]
        [StringLength(200)]
        public string? AltText { get; set; }
    }
}