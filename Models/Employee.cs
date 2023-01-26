using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_core_practice.Models
{
    public class Employee
    {
        public long Id { get; set; }
        public DateTime HireDate { get; set; }
        public decimal Salary { get; set; }
        public double WorkTimePerWeek { get; set; }
        public bool IsWorkingNow { get; set; }

        // Foreign keys
        // one to many with Position table
        public long PositionId { get; set; }
        public Position Position { get; set; } = null!;

        // one to many with WorkPlace table
        public long WorkPlaceId { get; set; }
        public WorkPlace? WorkPlace { get; set; }

        // one to one with CorpAccount table
        public long CorpAccountId { get; set; }
        public CorpAccount? CorpAccount { get; set; }

        // one to one with Person table
        public long PersonId { get; set; }
        public Person? Person { get; set; }
    }
}
