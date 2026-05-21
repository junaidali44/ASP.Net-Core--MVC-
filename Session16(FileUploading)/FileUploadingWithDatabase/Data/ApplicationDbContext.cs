using FileUploadingWithDatabase.Models;
using Microsoft.EntityFrameworkCore;

namespace FileUploadingWithDatabase.Data
{
    public class ApplicationDbContext:DbContext
    {
        public ApplicationDbContext(DbContextOptions options) : base(options) { }
        public DbSet<DocumentModel> Documents { get; set; }
    }
}
