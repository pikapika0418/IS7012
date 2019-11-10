using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace RealEstateListing.Models
{
    public class RealEstate
    {

        [Key]
        public int Id { get; set; }

        public string Type { get; set; }
        public int Sqft { get; set; }
        public double Cost { get; set; }
        public DateTime? BuyDate { get; set; }
        public bool IsHouseSold
        {
            get
            {
                return BuyDate != null;
            }
        }
    }
}
