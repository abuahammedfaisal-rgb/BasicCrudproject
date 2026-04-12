using Asp.netCoreCrudDemo.Models;
using Microsoft.EntityFrameworkCore;

namespace Asp.netCoreCrudDemo.Data
{
    public class ApplicationDbContext :DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext>options):base(options)
        {
            
        }
        public DbSet<Student> Students { get; set; }
    }
}
