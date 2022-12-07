using System;
using System.ComponentModel.DataAnnotations;


namespace CIDM3312_FinalProject.Models
{
    public class Facility
    {
        public int FacilityId {get; set;}  //Facility Primary Key
        
        [Display(Name = "Facility Code")]
        [Required]
        public string FacilityCode {get; set;} = string.Empty;

        [Display(Name = "Facility Name")]
        [Required]
        public string FacilityName {get; set;} = string.Empty;

        [Required]
        public int GwtgFacilityId {get; set;}

        public List<FacilityCollection>? FacilityCollections {get; set;} = default!; //Navigation to Collections by Facility
    }
}