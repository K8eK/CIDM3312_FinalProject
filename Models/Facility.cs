using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace CIDM3312_FinalProject.Models
{
    public class Facility
    {
        public int FacilityId {get; set;}  //Facility Primary Key
        
        [Display(Name = "Facility Code")]
        [Required]
        [MinLength(2)]
        [MaxLength(7)]
        public string FacilityCode {get; set;} = string.Empty;

        [Display(Name = "Facility Name")]
        [Required]
        [MinLength(5)]
        [MaxLength(75)]
        public string FacilityName {get; set;} = string.Empty;

        [Required]
        public int GwtgFacilityId {get; set;}

        public List<FacilityCollection>? FacilityCollections {get; set;} = default!; //Navigation to Collections by Facility
    }
}