using System;

namespace LifeManager.Core.Entities
{
    public class Transaction : BaseEntity
    {
        // 1. BU İŞLEM KİME AİT?
        public int UserId { get; set; }
        public User User { get; set; }

        // 2. PARA HANGİ HESAPTAN ÇIKTI/GİRDİ?
        public int AccountId { get; set; }
        public Account Account { get; set; }

        public string Description { get; set; }
        public decimal Amount { get; set; } // Tutar
        public bool IsIncome { get; set; } // True: Gelir, False: Gider
        public string Category { get; set; } // "Market", "Fatura" vb.
        public DateTime TransactionDate { get; set; }
    }
}