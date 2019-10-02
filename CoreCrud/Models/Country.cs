using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CoreCrud.Models
{
    public class Country
    {
        public int Id { get; set; }
        [Required]
        [Display(Name = "Country Name")]
        [StringLength(25, MinimumLength =4)]
        //[RegularExpression(@"^[a-zA-Z]{4,25}", ErrorMessage = "Country Name must be of 4 to 25 characters")]
        public string Name { get; set; }
        [Required]
        [Display(Name="Population(in Millions)")]
        [Range(1,400)]
        public int Population { get; set; }
        public ICollection<Athlete> Athletes { get; set; }

    }
}
