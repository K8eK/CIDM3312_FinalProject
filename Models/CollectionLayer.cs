using System;
using System.ComponentModel.DataAnnotations;


namespace CIDM3312_FinalProject.Models
{
    public class CollectionLayer
    {
        public int CollectionLayerId {get; set;}  //Facility Primary Key
        [Required]
        [MinLength(2)]
        [MaxLength(25)]
        public string CollectionCode {get; set;} = string.Empty;
        public string CollectionLabel {get; set;} = string.Empty;
        public List<FacilityCollection> FacilityCollections {get; set;} = default!; //Navigation to Collections by Facility
    }

    public class FacilityCollection
    {
        [Key]
        public int FcRowId {get; set;}  //Primary Key
        public int CollectionLayerId {get; set;} //PK,FK1 Composite
        public int FacilityId {get; set;} //PK, FK2 Composite
        public DateOnly ParticipationStartDate {get; set;}
        public DateOnly ParticipationEndDate {get; set;}
        public CollectionLayer CollectionLayer {get; set;} = default!; //Navigation to CollectionLayer
        public Facility Facility {get; set;} = default!; //Navigation to Facility
    }
}