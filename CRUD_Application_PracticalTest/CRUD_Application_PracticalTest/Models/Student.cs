using System.ComponentModel.DataAnnotations;

namespace CRUD_Application_PracticalTest.Models
{
    public class Student
    {
        [Key]
        public int StudentId { get; set; }
        [Required]
        public string StudentName { get; set; }
        [Required]
        public string StudentEmail { get; set; }
        [Required]
        public DateOnly DateOfBirth {  get; set; }
        
        public DateTime CreatedAt { get; set; } = DateTime.Now;
        public DateTime UpdatedAt { get; set; } = DateTime.Now;
    }
}
