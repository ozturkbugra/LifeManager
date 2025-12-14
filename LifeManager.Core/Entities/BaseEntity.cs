using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LifeManager.Core.Entities
{
    // abstract yapıyoruz ki kimse direkt 'BaseEntity' diye bir kayıt oluşturamasın.
    // Sadece diğer sınıflar miras alabilsin.
    public abstract class BaseEntity
    {
        public int Id { get; set; }
        public DateTime CreatedAt { get; set; } = DateTime.Now;
        public bool IsDeleted { get; set; } = false; // Silinenleri veritabanından uçurmuyoruz, sadece gizliyoruz.
    }
    
}
