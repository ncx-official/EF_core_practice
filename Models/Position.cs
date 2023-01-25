using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_core_practice.Models
{
    public class Position
    {
        public int Id { get; set; }
        public string Name { get; set; }

        // Foreign key
        public int CompanyId { get; set; }
    }
}
