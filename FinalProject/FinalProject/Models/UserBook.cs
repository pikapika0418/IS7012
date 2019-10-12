 using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace FinalProject.Models
{
    public class UserBook
    {
        public int Id { get; set; }
        public int BookId { get; set; }
        [Display(Name = "Book")]
        public Book Book { get; set; }
        [Display(Name = "User")]
        public User User { get; set; }
        public int UserId { get; set; }
        public int? Rating { get; set; }
        [Display(Name = "Due Amount")]
        public double? FeeAmount { get; set; }
        [DataType(DataType.Date)]
        [Display(Name = "Issued Date")]
        public DateTime? CheckoutDate { get; set; }
        [DataType(DataType.Date)]
        [Display(Name = "Due Date")]
        public DateTime? CheckInDate { get; set; }

    }
}
