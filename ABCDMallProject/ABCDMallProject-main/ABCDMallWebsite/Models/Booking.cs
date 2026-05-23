using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ABCDMallWebsite.Models
{
    [Table("Bookings")]
    public class Booking
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [ForeignKey("Movie")]
        public int MovieId { get; set; }
        public virtual Movie? Movie { get; set; }

        [ForeignKey("User")]
        public string? UserId { get; set; }
        public virtual ApplicationUser? User { get; set; }

        [Required]
        [StringLength(100)]
        [Display(Name = "Full Name")]
        public string CustomerName { get; set; } = string.Empty;

        [Required]
        [EmailAddress]
        [StringLength(100)]
        [Display(Name = "Email Address")]
        public string CustomerEmail { get; set; } = string.Empty;

        [Required]
        [Phone]
        [StringLength(15)]
        [Display(Name = "Phone Number")]
        public string CustomerPhone { get; set; } = string.Empty;

        [Required]
        [Display(Name = "Number of Seats")]
        [Range(1, 10)]
        public int NumberOfSeats { get; set; }

        [Display(Name = "Selected Seats")]
        public string? SeatNumbers { get; set; }

        [Display(Name = "Total Amount (₹)")]
        [DataType(DataType.Currency)]
        public decimal TotalAmount { get; set; }

        [Display(Name = "Payment Method")]
        public string PaymentMethod { get; set; } = "Card";

        [Display(Name = "Card Last 4 Digits")]
        [StringLength(4)]
        public string? CardLastFour { get; set; }

        [Display(Name = "Transaction ID")]
        [StringLength(100)]
        public string? TransactionId { get; set; }

        [Display(Name = "Booking Status")]
        public string BookingStatus { get; set; } = "Confirmed";

        [Display(Name = "Booking Reference")]
        [StringLength(50)]
        public string? BookingReference { get; set; }

        [Display(Name = "Booking Date")]
        public DateTime BookingDate { get; set; } = DateTime.UtcNow;

        [Display(Name = "Cancellation Date")]
        public DateTime? CancelledAt { get; set; }

        [Display(Name = "Cancellation Reason")]
        [StringLength(500)]
        public string? CancellationReason { get; set; }

        [Display(Name = "Special Requests")]
        [StringLength(500)]
        public string? SpecialRequests { get; set; }
    }
}