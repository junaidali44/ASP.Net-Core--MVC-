using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ABCDMallWebsite.Models
{
    [Table("Feedbacks")]
    public class Feedback
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [StringLength(100)]
        [Display(Name = "Your Name")]
        public string CustomerName { get; set; } = string.Empty;

        [Required]
        [EmailAddress]
        [StringLength(100)]
        [Display(Name = "Email")]
        public string Email { get; set; } = string.Empty;

        [ForeignKey("User")]
        public string? UserId { get; set; }
        public virtual ApplicationUser? User { get; set; }

        [Required]
        [Range(1, 5)]
        [Display(Name = "Rating")]
        public int Rating { get; set; }

        [Required]
        [StringLength(1000)]
        [Display(Name = "Your Feedback")]
        public string Message { get; set; } = string.Empty;

        [StringLength(200)]
        [Display(Name = "Subject")]
        public string? Subject { get; set; }

        [Display(Name = "Category")]
        [StringLength(50)]
        public string? Category { get; set; } // Shopping, Movies, Food, Parking, Overall

        [Display(Name = "Submitted At")]
        public DateTime SubmittedAt { get; set; } = DateTime.UtcNow;

        [Display(Name = "Is Read")]
        public bool IsRead { get; set; } = false;

        [Display(Name = "Admin Reply")]
        [StringLength(1000)]
        public string? AdminReply { get; set; }

        [Display(Name = "Replied At")]
        public DateTime? RepliedAt { get; set; }

        [Display(Name = "Is Public")]
        public bool IsPublic { get; set; } = true;
    }
}