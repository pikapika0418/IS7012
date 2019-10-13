using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace FinalProject.Models
{
    public class CheckoutForm
    {
        [Display(Name ="Book")]
        [Required(ErrorMessage ="Please select a book")]
        public int BookId { get; set; }
        [Display(Name ="Username")]
        [Required(ErrorMessage ="Please select a username")]
        public int UserID { get; set; }
        public string BookName { get; set; }
    }
}
