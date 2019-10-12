using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace FinalProject.Models
{
    public class Genre
    {
        [Key]
        public int Id { get; set; }

        [RegularExpression(@"^[a-zA-Z]+$", ErrorMessage = "Must be a string")]
        [Display(Name = "Genre Type")]
        public string Type { get; set; }
        
        [Required(ErrorMessage = "Please provide a name")]
       //[CustomValidation(typeof(Genre), "NameValidation")]
        [Display(Name = "Genre Name")]
        public string Name { get; set; }
        
        
        public ICollection<Book> Books { get; set; }
    }
}
