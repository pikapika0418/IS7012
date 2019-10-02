using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace CoreCrud.Models
{
    public class Athlete
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Athlete name is required")]
        [RegularExpression(@"^[a-zA-Z]{2,25}$+", ErrorMessage = "Athlete Name must be of 2 to 25 characters")]
        public string Name { get; set; }
        [Display(Name="Date of birth")]
        [DataType(DataType.Date)]
        [Required(ErrorMessage ="Date Of Birth is required")]
        [CustomValidation(typeof(Athlete), "AthletesWithinFourteenYearsOfAge")]
        public DateTime DOB { get; set; }
        [Display(Name = "Won GrandSlam")]
        public bool HasWonTitles { get; set; }
        [Display(Name = "Win Percentage")]
        [CustomValidation(typeof(Athlete), "PercentageCheck")]
        //[Range(0.00,100.00)]
        [Required(ErrorMessage ="Percentage of matches won is a required field")]
        public decimal GamesWonPercentage { get; set; }
        [Range(1,1000)]
        public int? Rank { get; set; }
        [Display(Name = "Country")]
        public int CountryId { get; set; }
        public Country Country { get; set; }

        public string AthleteAgeBar
        {
            get
            {
                if (HasWonTitles == true)
                {
                    return "Yes";
                }
                return "No";
            }
        }

        public static ValidationResult AthletesWithinFourteenYearsOfAge(DateTime dob, ValidationContext context)
        {
            System.DateTime date1 = new System.DateTime(2005, 1, 1, 1, 1, 1);
            if(dob > date1)
            {
                return new ValidationResult("Athletes must be of Fourteen years of age");
            }
            return ValidationResult.Success;   
        }

        public static ValidationResult PercentageCheck(double percentage, ValidationContext Context)
        {
            if(percentage.Equals(null))
            {
                return ValidationResult.Success;
            }

            if(percentage<100.00)
            {
                return ValidationResult.Success;
            }
            return new ValidationResult("Percentage should be less than 100");
        }
    }
}
