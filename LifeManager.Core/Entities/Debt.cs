using System;

namespace LifeManager.Core.Entities
{
    public class Debt : BaseEntity
    {
        public int ContactId { get; set; }
        public Contact Contact { get; set; }

        public int IngredientId { get; set; }
        public Ingredient Ingredient { get; set; }

        public decimal Amount { get; set; } // Örn: 2 (Adet çeyrek altın)
        public bool IsDebt { get; set; } // True: Borçluyum, False: Alacaklıyım
        public bool IsSettled { get; set; } // Borç kapandı mı?
        public DateTime? DueDate { get; set; } // Son ödeme tarihi
        public string Note { get; set; }
    }
}