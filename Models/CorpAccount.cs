using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_core_practice.Models
{
    public class CorpAccount
    {
        public long Id { get; set; }
        public string Login { get; set; } = null!;
        public string Password { get; set; } = null!;

        // Foreign keys
        public long AccountRoleId { get; set; }
        public AccountRole? AccountRole { get; set; }
        
        //
        public Employee? Employee { get; set; }
    }
}
