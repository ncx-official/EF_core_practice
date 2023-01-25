using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_core_practice.Models
{
    public class UserAccountRole
    {
        public int UserAccountId { get; set; }
        public int RoleId { get; set; }
    }
}
