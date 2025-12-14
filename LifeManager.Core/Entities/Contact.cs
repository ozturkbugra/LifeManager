using System.Collections.Generic;

namespace LifeManager.Core.Entities
{
    public class Contact : BaseEntity
    {
        public string FullName { get; set; }
        public string PhoneNumber { get; set; }

        public ICollection<Debt> Debts { get; set; }
    }
}