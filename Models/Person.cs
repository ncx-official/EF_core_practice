using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_core_practice.Models
{
    public class Person
    {
        public long Id { get; set; }
        public string FirstName { get; set; } = null!;
        public string? LastName { get; set; }
        public DateTime BirthDate { get; set; }
        public string? PhoneNumber { get; set; }
        public string? Email { get; set; }
        
        // Foreign keys 
        public long GenderId { get; set; }
        public Gender Gender { get; set; } = null!;
        public long CityId { get; set; }
        public City? City { get; set; }

        //
        public Employee Employee { get; set; } = null!;
    }
}
