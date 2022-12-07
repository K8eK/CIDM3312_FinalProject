using System;

namespace CIDM3312_FinalProject.Models
{
    public class Facility
    {
        public int FacilityId {get; set;}  //Facility Primary Key
        public string FacilityCode {get; set;}
        public string FacilityName {get; set;}
        public int GwtgFacilityId {get; set;}
        
    }
}