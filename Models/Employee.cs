using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_core_practice.Models
{
    public class Employee
    {

        public int Id { get; set; }
        public int PositionId { get; set; }
        public int PersonId { get; set; }
        public int UserAccountId { get; set; }
    }
}
