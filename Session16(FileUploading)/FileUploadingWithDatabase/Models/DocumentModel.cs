using System.ComponentModel.DataAnnotations;

namespace FileUploadingWithDatabase.Models
{
    public class DocumentModel
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Description { get; set; }

        [Required]
        public string Tittle { get; set; }

        [Required]
        public string FileName { get; set; }
        [Required]
        public string FilePath{ get; set; }

        }
}
