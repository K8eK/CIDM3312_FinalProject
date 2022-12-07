using System;

namespace CIDM3312_FinalProject.Models
{
    public class CollectionByFacility
    {
        public int FbcRowId {get; set;}  //Facility Primary Key
        public DateOnly ParticipationStartDate {get; set;}
        public DateOnly ParticipationEndDate {get; set;}
        

    }
}