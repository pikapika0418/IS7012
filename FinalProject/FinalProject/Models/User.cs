using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace FinalProject.Models
{
    public class User
    {
        public int ID { get; set; }

        [Required(ErrorMessage = "Name is compulsory")]
        [StringLength(100, MinimumLength = 2, ErrorMessage = "Minimum 2-100 characters")]
        //[CustomValidation(typeof(User), "NameValidation")]
        [Display(Name = "User Name")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Age is compulsory")]
        public int Age { get; set; }
        public bool Membership { get; set; }

        public ICollection<UserBook> UserBooks { get; set; }
        /*
         public static ValidationResult NameValidation(string name, ValidationContext context)
        {
            User user = new User();
            if (string.IsNullOrWhiteSpace(name))
            {
                return ValidationResult.Success;
            }
            var instance = context.ObjectInstance as User;
            if (instance == null)
            {
                return ValidationResult.Success;
            }
            var dbContext = context.GetService(typeof(Project_dhwaniContext)) as Project_dhwaniContext;
            int duplicateCount = dbContext.User
            .Count(x => x.ID != instance.ID && x.Name == name);
            if (duplicateCount > 0)
            {
                return new ValidationResult($"Name {name} already exists");
            }
            return ValidationResult.Success;
        }
         */
    }
}
