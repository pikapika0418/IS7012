using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CoreCrud.Models
{
    public class Athlete
    {
        public int Id { get; set; }
        public string Name { get; set; }
        [DataType(DataType.Date)]
        public DateTime DOB { get; set; }
        [Display(Name = "Won GrandSlam")]
        public bool HasWonTitles { get; set; }
        [Display(Name = "Win Percentage")]
        public decimal GamesWonPercentage { get; set; }
        public int? Rank { get; set; }
        [Display(Name = "Country ID")]
        public int CountryId { get; set; }
        public Country Country { get; set; }
    }
}
