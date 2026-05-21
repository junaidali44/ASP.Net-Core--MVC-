using Microsoft.AspNetCore.Http;
using System.ComponentModel.DataAnnotations;

namespace FileUploadingWithDatabase.ViewModel
{
    public class FileViewModel
    {
        [Required]
        public string Tittle { get; set; }

        [Required]
        public string Description { get; set; }

        [Required(ErrorMessage = "Please select a file")]
        public IFormFile File { get; set; }
    }
}
