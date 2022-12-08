
using Microsoft.EntityFrameworkCore;

namespace CIDM3312_FinalProject.Models
{
    public static class SeedPrimary
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var PrimaryContext = new ProjectDbContext(serviceProvider.GetRequiredService<DbContextOptions<ProjectDbContext>>()))
            {
  
                //Look for existing Facility object
                if (PrimaryContext.Facility.Any())
                {
                    return;  // DB has been seeded
                }

                //Seeding the Facility table
                PrimaryContext.Facility.AddRange
                (
                    new Facility {FacilityCode="BA", FacilityName="Swedish Ballard", GwtgFacilityId = 96580},
                    new Facility {FacilityCode="CH", FacilityName="Swedish Cherry Hill", GwtgFacilityId = 16002},
                    new Facility {FacilityCode="EDM", FacilityName="Swedish Edmonds", GwtgFacilityId = 16802},
                    new Facility {FacilityCode="FH", FacilityName="Swedish First Hill", GwtgFacilityId = 75246},
                    new Facility {FacilityCode="IQ", FacilityName="Swedish Issaquah", GwtgFacilityId = 75247},
                    new Facility {FacilityCode="MC", FacilityName="Swedish Mill Creek", GwtgFacilityId = 96581},
                    new Facility {FacilityCode="RD", FacilityName="Swedish Redmond", GwtgFacilityId = 96582}
                );
                PrimaryContext.SaveChanges();

                //Seeding the CollectionLayers table
                PrimaryContext.CollectionLayer.AddRange
                (
                    new CollectionLayer {CollectionCode = "FRM_AR", CollectionLabel = "Arkansas"},
                    new CollectionLayer {CollectionCode = "FRM_ASR", CollectionLabel = "TJC ASR"},
                    new CollectionLayer {CollectionCode = "FRM_AZ", CollectionLabel = "AZ EMS"},
                    new CollectionLayer {CollectionCode = "FRM_CAREC", CollectionLabel = "Care Coordination"},
                    new CollectionLayer {CollectionCode = "FRM_Coverdell", CollectionLabel = "Coverdell"},
                    new CollectionLayer {CollectionCode = "FRM_CSTK", CollectionLabel = "TJC CSTK"},
                    new CollectionLayer {CollectionCode = "FRM_Diabetes_Stroke", CollectionLabel = "Diabetes"},
                    new CollectionLayer {CollectionCode = "FRM_EMS_Stroke", CollectionLabel = "EMS Pre-Hospital Care"},
                    new CollectionLayer {CollectionCode = "FRM_EVT", CollectionLabel = "Endovascular Therapy"},
                    new CollectionLayer {CollectionCode = "FRM_FLPR", CollectionLabel = "Florida Stroke Registry"},
                    new CollectionLayer {CollectionCode = "FRM_GA", CollectionLabel = "GA Coverdell"},
                    new CollectionLayer {CollectionCode = "FRM_ICH", CollectionLabel = "ICH"},
                    new CollectionLayer {CollectionCode = "FRM_LA", CollectionLabel = "LA EMS"},
                    new CollectionLayer {CollectionCode = "FRM_MDCHIA_Stroke", CollectionLabel = "MD CHIA"},
                    new CollectionLayer {CollectionCode = "FRM_ME_Stroke", CollectionLabel = "Middle East Stroke"},
                    new CollectionLayer {CollectionCode = "FRM_MI", CollectionLabel = "Michigan"},
                    new CollectionLayer {CollectionCode = "FRM_MSN", CollectionLabel = "MSN"},
                    new CollectionLayer {CollectionCode = "FRM_NJ", CollectionLabel = "NJASR"},
                    new CollectionLayer {CollectionCode = "FRM_NYSDOH", CollectionLabel = "NYSDOH"},
                    new CollectionLayer {CollectionCode = "FRM_OH", CollectionLabel = "Ohio"},
                    new CollectionLayer {CollectionCode = "FRM_OPSTK", CollectionLabel = "CMS OP-23"},
                    new CollectionLayer {CollectionCode = "FRM_PHI_Stroke", CollectionLabel = "PHI"},
                    new CollectionLayer {CollectionCode = "FRM_PSC", CollectionLabel = "PSC"},
                    new CollectionLayer {CollectionCode = "FRM_PSS", CollectionLabel = "PSS"},
                    new CollectionLayer {CollectionCode = "FRM_PTSN", CollectionLabel = "PTSN"},
                    new CollectionLayer {CollectionCode = "FRM_STK", CollectionLabel = "TJC STK"},
                    new CollectionLayer {CollectionCode = "FRM_Stroke", CollectionLabel = "Stroke"},
                    new CollectionLayer {CollectionCode = "FRM_Stroke_ASCVD", CollectionLabel = "ASCVD Stroke"},
                    new CollectionLayer {CollectionCode = "FRM_Stroke_BPCI", CollectionLabel = "BPCI"},
                    new CollectionLayer {CollectionCode = "FRM_STROKE_CANADA", CollectionLabel = "Canada Fields"},
                    new CollectionLayer {CollectionCode = "FRM_Stroke_ePCR", CollectionLabel = "EMS Importer"},
                    new CollectionLayer {CollectionCode = "FRM_Stroke_IFT", CollectionLabel = "Interfacility Transfer"},
                    new CollectionLayer {CollectionCode = "FRM_Stroke_Limited", CollectionLabel = "Stroke Limited"},
                    new CollectionLayer {CollectionCode = "FRM_STROKE_MEXICO", CollectionLabel = "Mexico Fields"},
                    new CollectionLayer {CollectionCode = "FRM_STROKE_MRN", CollectionLabel = "MRN"},
                    new CollectionLayer {CollectionCode = "FRM_Stroke_Rural", CollectionLabel = "Stroke Rurual"},
                    new CollectionLayer {CollectionCode = "FRM_Telestroke", CollectionLabel = "Telestroke"},
                    new CollectionLayer {CollectionCode = "FRM_TSC", CollectionLabel = "TSC"},
                    new CollectionLayer {CollectionCode = "FRM_WestRegion", CollectionLabel = "West Region Stroke"},
                    new CollectionLayer {CollectionCode = "FRM_WestRegionRural", CollectionLabel = "West Region Rural"},
                    new CollectionLayer {CollectionCode = "FRM_FUP", CollectionLabel = "Stroke Follow-up: Post Discharge Follow-up"},
                    new CollectionLayer {CollectionCode = "FRM_FUP_CSTK", CollectionLabel = "Stroke Follow-up: CSTK"},
                    new CollectionLayer {CollectionCode = "FRM_FUP_MarissHist", CollectionLabel = "Stroke Follow-up: Mariss"},
                    new CollectionLayer {CollectionCode = "FRM_FUP_FLPR", CollectionLabel = "Stroke Follow-up:  Florida Stroke Registry"},
                    new CollectionLayer {CollectionCode = "FRM_FUP_EVT", CollectionLabel = "Stroke Follow-up: Endovascular Therapy"},
                    new CollectionLayer {CollectionCode = "FRM_FUP_WestRegion", CollectionLabel = "Stroke Follow-up: West Region"},
                    new CollectionLayer {CollectionCode = "FRM_FUP_Historic", CollectionLabel = "Stroke Follow-up: Historic"},
                    new CollectionLayer {CollectionCode = "FRM_FUP_Outcome", CollectionLabel = "Stroke Follow-up: Short Form"},
                    new CollectionLayer {CollectionCode = "FRM_FUP_TSC", CollectionLabel = "Stroke Follow-up: TSC"}
                );
                PrimaryContext.SaveChanges();
            }
        }
    }
}