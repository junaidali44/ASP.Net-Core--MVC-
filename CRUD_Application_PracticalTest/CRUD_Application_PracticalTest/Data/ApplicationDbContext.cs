
using CRUD_Application_PracticalTest.Models;
using Microsoft.EntityFrameworkCore;
using System.Data;

namespace CRUD_Application_PracticalTest.Data
{
    public class ApplicationDbContext :DbContext
    {
        public ApplicationDbContext(DbContextOptions options) : base(options) 
        { 
        }
        public DbSet<Student> Student { get; set; }
    }
}
