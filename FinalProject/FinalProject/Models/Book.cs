﻿using System;

using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;

using System.Threading.Tasks;

namespace FinalProject.Models
{
    public class Book
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Name is compulsory")]
        [StringLength(100, MinimumLength = 2, ErrorMessage = "Minimum 2-100 characters")]
        //[CustomValidation(typeof(Book), "NameValidation")]
        [Display(Name = "Book")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Author name is mandatory")]
        [StringLength(100, MinimumLength = 2, ErrorMessage = "Minimum 2-100 characters")]
        public string Author { get; set; }

        public int GenreID { get; set; }
        public Genre Genre { get; set; }
        [Required(ErrorMessage = "This field is mandatory")]
        [Display(Name = "Number of Books Available")]
        public int NumberOfBooksAvailable { get; set; }
        public ICollection<UserBook> Userbooks { get; set; }
        public string Replenish
        {
            get
            {
                //RETURN LESS IF NUMBER OF BOOKS AVAILABLE 
                if (NumberOfBooksAvailable < 20)
                {
                    return "Less";
                }
                // RETURN MEDIUM IF NUMBER OF BOOKS AVAILABLE IS LESS THAN 30
                if (NumberOfBooksAvailable < 30)
                {
                    return "Medium";
                }
                // RETURN MORE IF NUMBER OF BOOKS AVAILABLE IS LESS THAN 50
                if (NumberOfBooksAvailable < 50)
                {
                    return "More";
                }
                // OTHERWISE RETURN NO BOOK AVAILABLE 
                return "No Book Available";
            }
        }
    }
}
