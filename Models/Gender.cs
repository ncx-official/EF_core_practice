using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_core_practice.Models
{
    public class Gender
    {
        public long Id { get; set; }
        public string Type { get; set; } = null!;
        public ICollection<Person> People { get; set; } = null!;
    }
}
