using System.Collections.Generic;

namespace LifeManager.Core.Entities
{
    public class Ingredient : BaseEntity
    {
        public string Name { get; set; } // "Çeyrek Altın", "Amerikan Doları"
        public string Symbol { get; set; } // "adet", "$", "gr"

        public ICollection<Debt> Debts { get; set; }
    }
}