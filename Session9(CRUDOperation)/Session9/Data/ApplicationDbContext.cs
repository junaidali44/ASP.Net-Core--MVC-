using Microsoft.EntityFrameworkCore;
using Session9.Models;

namespace Session9.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions option ):base(option) { }
        public DbSet<UserModel> Users { get; set; }

    }
}
