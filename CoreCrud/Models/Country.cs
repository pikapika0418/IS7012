using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreCrud.Models
{
    public class Country
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Population { get; set; }
        public ICollection<Athlete> Athletes { get; set; }
    }
}
