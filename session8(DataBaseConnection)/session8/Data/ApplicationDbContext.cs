using Microsoft.EntityFrameworkCore;
using session8.Models;

namespace session8.Data
{
    public class ApplicationDbContext :DbContext
    {
        public ApplicationDbContext(DbContextOptions options): base(options)
        {

        }
        DbSet <User> User { get; set; }
        DbSet <AddProducts> addproducts { get; set; }

    }
}
