using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ABCDMallWebsite.Models
{
    [Table("Movies")]
    public class Movie
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [StringLength(150)]
        [Display(Name = "Movie Name")]
        public string Name { get; set; } = string.Empty;

        [StringLength(1000)]
        [Display(Name = "Description")]
        public string Description { get; set; } = string.Empty;

        [Required]
        [StringLength(50)]
        [Display(Name = "Language")]
        public string Language { get; set; } = string.Empty;

        [StringLength(50)]
        [Display(Name = "Genre")]
        public string Genre { get; set; } = string.Empty;

        [Display(Name = "Duration (Minutes)")]
        [Range(60, 300)]
        public int Duration { get; set; }

        [Display(Name = "Poster Image")]
        public string? PosterUrl { get; set; }

        [Display(Name = "Trailer URL")]
        public string? TrailerUrl { get; set; }

        [StringLength(500)]
        [Display(Name = "Cast")]
        public string? Cast { get; set; }

        [StringLength(200)]
        [Display(Name = "Director")]
        public string? Director { get; set; }

        [Display(Name = "Total Seats")]
        [Range(50, 300)]
        public int TotalSeats { get; set; } = 100;

        [Display(Name = "Available Seats")]
        public int AvailableSeats { get; set; } = 100;

        [Required]
        [Display(Name = "Show Date & Time")]
        public DateTime ShowDateTime { get; set; }

        [Display(Name = "Ticket Price (₹)")]
        [DataType(DataType.Currency)]
        [Range(100, 1000)]
        public decimal TicketPrice { get; set; } = 250;

        [Display(Name = "Is Now Showing")]
        public bool IsNowShowing { get; set; } = true;

        [Display(Name = "Is Featured")]
        public bool IsFeatured { get; set; } = false;

        [Display(Name = "Rating")]
        [Range(0, 10)]
        public decimal Rating { get; set; } = 0;

        [Display(Name = "Created At")]
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;

        [Display(Name = "Age Rating")]
        [StringLength(10)]
        public string? AgeRating { get; set; } = "UA";

        [Display(Name = "Screen Number")]
        [Range(1, 10)]
        public int ScreenNumber { get; set; } = 1;
    }
}