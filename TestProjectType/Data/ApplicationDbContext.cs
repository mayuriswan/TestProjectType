using Microsoft.EntityFrameworkCore;
using TestProjectType.Models;

namespace TestProjectType.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<ProjectType> ProjectTypes { get; set; }
    }
}
