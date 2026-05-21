
using System.ComponentModel.DataAnnotations;

namespace CRUDApplication.ViewModel
{
    public class StudentViewModel
    {
        public int StudentId { get; set; }
        [Required]
        public string StudentName { get; set; }
        [Required]
        public string StudentEmail { get; set; }
        [Required]
        public DateOnly DateOfBirth { get; set; }

    }
}
