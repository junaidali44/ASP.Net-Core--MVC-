using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ABCDMallWebsite.Models
{
    [Table("FoodCourts")]
    public class FoodCourt
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [StringLength(100)]
        [Display(Name = "Counter Name")]
        public string CounterName { get; set; } = string.Empty;

        [Required]
        [StringLength(50)]
        [Display(Name = "Cuisine Type")]
        public string CuisineType { get; set; } = string.Empty;

        [Display(Name = "Menu Items")]
        [Column(TypeName = "nvarchar(max)")]
        public string? MenuItems { get; set; } // Store as JSON string

        [Display(Name = "Counter Image")]
        public string? ImageUrl { get; set; }

        [Display(Name = "Floor Location")]
        [Range(1, 4)]
        public int FloorLocation { get; set; }

        [Display(Name = "Counter Number")]
        [StringLength(20)]
        public string CounterNumber { get; set; } = string.Empty;

        [Display(Name = "Opening Time")]
        public string OpeningTime { get; set; } = "11:00 AM";

        [Display(Name = "Closing Time")]
        public string ClosingTime { get; set; } = "11:00 PM";

        [Display(Name = "Contact Number")]
        [Phone]
        [StringLength(15)]
        public string? ContactNumber { get; set; }

        [Display(Name = "Rating")]
        [Range(0, 5)]
        public decimal Rating { get; set; } = 0;

        [Display(Name = "Is Active")]
        public bool IsActive { get; set; } = true;

        [Display(Name = "Has Veg Only")]
        public bool IsVegOnly { get; set; } = false;

        [Display(Name = "Average Price for Two")]
        [Range(100, 5000)]
        public decimal AveragePriceForTwo { get; set; } = 500;
    }
}