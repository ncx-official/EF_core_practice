using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_core_practice.Models
{
    public class City
    {
        public long Id { get; set; }
        public string Name { get; set; } = null!;

        // Foreign keys
        public long CountryId { get; set; }
        public Country Country { get; set; } = null!;

        //
        public ICollection<Person>? People { get; set;}
    }
}
