using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_core_practice.Models
{
    public class Country
    {
        public long Id { get; set; }
        public string Name { get; set; } = null!;
        public ICollection<City> Cities { get; set;} = null!;
    }
}
