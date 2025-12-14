using System.Collections.Generic;
using System.Transactions;

namespace LifeManager.Core.Entities
{
    public class Account : BaseEntity
    {
        public string Name { get; set; } // "Ziraat Bankası", "Nakit Cüzdan"
        public string Currency { get; set; } // "TL", "USD"
        public decimal Balance { get; set; } // Şu anki bakiye

        public ICollection<Transaction> Transactions { get; set; }
    }
}