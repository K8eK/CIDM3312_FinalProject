using Microsoft.EntityFrameworkCore;

namespace CIDM3312_FinalProject.Models
{
    public class ProjectDbContext : DbContext
    {
        public ProjectDbContext(DbContextOptions<ProjectDbContext> options)
            : base(options)
        {
        }

        public DbSet<Facility> Facilities {get; set;} = default!;       
    }
}
