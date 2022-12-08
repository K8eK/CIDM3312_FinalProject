
using Microsoft.EntityFrameworkCore;

namespace CIDM3312_FinalProject.Models
{
    public static class SeedBridge
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var BridgeContext = new ProjectDbContext(serviceProvider.GetRequiredService<DbContextOptions<ProjectDbContext>>()))
            {
                
               List<FacilityCollection> SeedParticipation = new List<FacilityCollection>
                {
                    new FacilityCollection {FacilityId = 0, CollectionLayerId = 0},
                    new FacilityCollection {FacilityId = 1, CollectionLayerId = 2},
                    new FacilityCollection {FacilityId = 1, CollectionLayerId = 4},
                    new FacilityCollection {FacilityId = 1, CollectionLayerId = 7},
                    new FacilityCollection {FacilityId = 1, CollectionLayerId = 8},
                    new FacilityCollection {FacilityId = 1, CollectionLayerId = 21},
                    new FacilityCollection {FacilityId = 1, CollectionLayerId = 26},
                    new FacilityCollection {FacilityId = 1, CollectionLayerId = 27},
                    new FacilityCollection {FacilityId = 1, CollectionLayerId = 28},
                    new FacilityCollection {FacilityId = 1, CollectionLayerId = 32},
                    new FacilityCollection {FacilityId = 1, CollectionLayerId = 37},
                    new FacilityCollection {FacilityId = 2, CollectionLayerId = 4},
                    new FacilityCollection {FacilityId = 2, CollectionLayerId = 6},
                    new FacilityCollection {FacilityId = 2, CollectionLayerId = 7},
                    new FacilityCollection {FacilityId = 2, CollectionLayerId = 8},
                    new FacilityCollection {FacilityId = 2, CollectionLayerId = 9},
                    new FacilityCollection {FacilityId = 2, CollectionLayerId = 12},
                    new FacilityCollection {FacilityId = 2, CollectionLayerId = 21},
                    new FacilityCollection {FacilityId = 2, CollectionLayerId = 26},
                    new FacilityCollection {FacilityId = 2, CollectionLayerId = 27},
                    new FacilityCollection {FacilityId = 2, CollectionLayerId = 29},
                    new FacilityCollection {FacilityId = 2, CollectionLayerId = 32},
                    new FacilityCollection {FacilityId = 3, CollectionLayerId = 4},
                    new FacilityCollection {FacilityId = 3, CollectionLayerId = 7},
                    new FacilityCollection {FacilityId = 3, CollectionLayerId = 8},
                    new FacilityCollection {FacilityId = 3, CollectionLayerId = 12},
                    new FacilityCollection {FacilityId = 3, CollectionLayerId = 21},
                    new FacilityCollection {FacilityId = 3, CollectionLayerId = 23},
                    new FacilityCollection {FacilityId = 3, CollectionLayerId = 26},
                    new FacilityCollection {FacilityId = 3, CollectionLayerId = 27},
                    new FacilityCollection {FacilityId = 3, CollectionLayerId = 29},
                    new FacilityCollection {FacilityId = 3, CollectionLayerId = 32},
                    new FacilityCollection {FacilityId = 3, CollectionLayerId = 37},
                    new FacilityCollection {FacilityId = 4, CollectionLayerId = 4},
                    new FacilityCollection {FacilityId = 4, CollectionLayerId = 7},
                    new FacilityCollection {FacilityId = 4, CollectionLayerId = 8},
                    new FacilityCollection {FacilityId = 4, CollectionLayerId = 12},
                    new FacilityCollection {FacilityId = 4, CollectionLayerId = 21},
                    new FacilityCollection {FacilityId = 4, CollectionLayerId = 23},
                    new FacilityCollection {FacilityId = 4, CollectionLayerId = 26},
                    new FacilityCollection {FacilityId = 4, CollectionLayerId = 27},
                    new FacilityCollection {FacilityId = 4, CollectionLayerId = 32},
                    new FacilityCollection {FacilityId = 4, CollectionLayerId = 37},
                    new FacilityCollection {FacilityId = 5, CollectionLayerId = 4},
                    new FacilityCollection {FacilityId = 5, CollectionLayerId = 7},
                    new FacilityCollection {FacilityId = 5, CollectionLayerId = 8},
                    new FacilityCollection {FacilityId = 5, CollectionLayerId = 12},
                    new FacilityCollection {FacilityId = 5, CollectionLayerId = 21},
                    new FacilityCollection {FacilityId = 5, CollectionLayerId = 23},
                    new FacilityCollection {FacilityId = 5, CollectionLayerId = 26},
                    new FacilityCollection {FacilityId = 5, CollectionLayerId = 27},
                    new FacilityCollection {FacilityId = 5, CollectionLayerId = 32},
                    new FacilityCollection {FacilityId = 5, CollectionLayerId = 37},
                    new FacilityCollection {FacilityId = 6, CollectionLayerId = 2},
                    new FacilityCollection {FacilityId = 6, CollectionLayerId = 4},
                    new FacilityCollection {FacilityId = 6, CollectionLayerId = 7},
                    new FacilityCollection {FacilityId = 6, CollectionLayerId = 8},
                    new FacilityCollection {FacilityId = 6, CollectionLayerId = 21},
                    new FacilityCollection {FacilityId = 6, CollectionLayerId = 26},
                    new FacilityCollection {FacilityId = 6, CollectionLayerId = 27},
                    new FacilityCollection {FacilityId = 6, CollectionLayerId = 28},
                    new FacilityCollection {FacilityId = 6, CollectionLayerId = 32},
                    new FacilityCollection {FacilityId = 6, CollectionLayerId = 37},
                    new FacilityCollection {FacilityId = 7, CollectionLayerId = 2},
                    new FacilityCollection {FacilityId = 7, CollectionLayerId = 4},
                    new FacilityCollection {FacilityId = 7, CollectionLayerId = 7},
                    new FacilityCollection {FacilityId = 7, CollectionLayerId = 8},
                    new FacilityCollection {FacilityId = 7, CollectionLayerId = 21},
                    new FacilityCollection {FacilityId = 7, CollectionLayerId = 26},
                    new FacilityCollection {FacilityId = 7, CollectionLayerId = 27},
                    new FacilityCollection {FacilityId = 7, CollectionLayerId = 28},
                    new FacilityCollection {FacilityId = 7, CollectionLayerId = 32},
                    new FacilityCollection {FacilityId = 7, CollectionLayerId = 37}
                };
                BridgeContext.AddRange(SeedParticipation);

                BridgeContext.SaveChanges();
            }
        }
    }
}