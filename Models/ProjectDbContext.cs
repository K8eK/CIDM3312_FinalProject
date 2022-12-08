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
            modelBuilder.Entity<FacilityCollection>().HasKey(f => new {f.FacilityId, f.CollectionLayerId});
        }
        
        public DbSet<Facility> Facilities {get; set;} = default!;
        public DbSet<CollectionLayer> CollectionLayers {get; set;} = default!;
        public DbSet<FacilityCollection> FacilityCollections {get; set;} = default!;
    }
}
