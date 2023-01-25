using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_core_practice.Models
{
    // [Table("Person")]
    public class Person
    {
        // [Column("id_person", TypeName="ntext")]
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string? LastName { get; set; }
        public DateTime BirthDate { get; set; }

        // Foreign keys
        public int SexId { get; set; }
    }
}
