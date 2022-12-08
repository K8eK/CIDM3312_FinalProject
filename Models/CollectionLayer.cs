using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;


namespace CIDM3312_FinalProject.Models
{
    public class CollectionLayer
    {
        public int CollectionLayerId {get; set;}  //Facility Primary Key
        public string CollectionCode {get; set;} = string.Empty;
        public string CollectionLabel {get; set;} = string.Empty;
        public List<FacilityCollection> FacilityCollections {get; set;} = default!; //Navigation to Collections by Facility
    }

    public class FacilityCollection
    {
        public int CollectionLayerId {get; set;} //PK,FK1 Composite
        public int FacilityId {get; set;} //PK, FK2 Composite
        public CollectionLayer CollectionLayer {get; set;} = default!; //Navigation to CollectionLayer
        public Facility Facility {get; set;} = default!; //Navigation to Facility
    }
}