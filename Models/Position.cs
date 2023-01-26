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
        public string Title { get; set; } = null!;

        // Foreign keys
        public long DepartmentId { get; set; }
        public Department? Department { get; set; }

        //
        public ICollection<Employee> Employees { get; set; } = null!;
    }
}
