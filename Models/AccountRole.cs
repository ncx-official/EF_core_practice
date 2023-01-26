using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_core_practice.Models
{
    public class AccountRole
    {
        public long Id { get; set; }
        public string Value { get; set; } = null!;

        //
        public ICollection<CorpAccount> CorpAccounts { get; set; } = null!;
    }
}
