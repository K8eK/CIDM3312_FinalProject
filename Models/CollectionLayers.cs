using System;

namespace CIDM3312_FinalProject.Models
{
    public class CollectionLayer
    {
        public int CollectionLayerId {get; set;}  //Facility Primary Key
        public string CollectionCode {get; set;} = string.Empty;
        public string CollectionLabel {get; set;} = string.Empty;
        

    }
}