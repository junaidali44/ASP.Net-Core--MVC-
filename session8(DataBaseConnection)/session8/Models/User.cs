using System.ComponentModel.DataAnnotations;

namespace session8.Models
{
    public class User
    {
        [Key]
        public int Id { get; set; }
        [Required(ErrorMessage = "Name is required")]
        public string name { get; set; }
        [Required(ErrorMessage = "Email is required")]

        public string email { get; set; }
        //[Required(ErrorMessage = "Age is required")]

        //public int age { get; set; }

        //[Required]
        //public int PhoneNumber { get; set; }

        //[Required]
        //public string Password { get; set; }


    }
}
