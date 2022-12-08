using Microsoft.EntityFrameworkCore;

namespace CIDM3312_FinalProject.Models
{
    public class ProjectDbContext : DbContext
    {
        public ProjectDbContext(DbContextOptions<ProjectDbContext> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<FacilityCollection>().HasKey(s => new {s.FacilityId, s.CollectionLayerId});
        }
        
        public DbSet<Facility> Facility {get; set;} = default!;
        public DbSet<CollectionLayer> CollectionLayer {get; set;} = default!;
        public DbSet<FacilityCollection> FacilityCollection {get; set;} = default!;
    }
}
