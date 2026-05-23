using System.ComponentModel.DataAnnotations;

namespace ABCDMallWebsite.ViewModels
{
    public class BookingViewModel
    {
        public int MovieId { get; set; }
        public string MovieName { get; set; } = string.Empty;
        public string MoviePoster { get; set; } = string.Empty;
        public DateTime ShowDateTime { get; set; }
        public decimal TicketPrice { get; set; }

        [Required]
        [StringLength(100)]
        [Display(Name = "Full Name")]
        public string CustomerName { get; set; } = string.Empty;

        [Required]
        [EmailAddress]
        [Display(Name = "Email")]
        public string CustomerEmail { get; set; } = string.Empty;

        [Required]
        [Phone]
        [Display(Name = "Phone Number")]
        public string CustomerPhone { get; set; } = string.Empty;

        [Required]
        [Range(1, 10)]
        [Display(Name = "Number of Seats")]
        public int NumberOfSeats { get; set; }

        public List<string> SelectedSeats { get; set; } = new List<string>();

        [Required]
        [CreditCard]
        [Display(Name = "Card Number")]
        public string CardNumber { get; set; } = string.Empty;

        [Required]
        [StringLength(5)]
        [Display(Name = "Expiry Date (MM/YY)")]
        public string ExpiryDate { get; set; } = string.Empty;

        [Required]
        [StringLength(4)]
        [Display(Name = "CVV")]
        public string CVV { get; set; } = string.Empty;

        [Required]
        [StringLength(100)]
        [Display(Name = "Card Holder Name")]
        public string CardHolderName { get; set; } = string.Empty;
    }
}