using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace LifeManager.Core.Entities
{
    public class User : BaseEntity
    {
        public string Name { get; set; } // "Ben", "Aile", "Şirket"

        // Bu kullanıcının yaptığı işlemler listesi
        public ICollection<Transaction> Transactions { get; set; }
    }
    
}
