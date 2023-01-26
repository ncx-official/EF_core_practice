using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_core_practice.Models
{
    public class Department
    {
        public long Id { get; set; }
        public string Title { get; set; } = null!;
        public ICollection<Position>? Positions { get; set; } 
    }
}
