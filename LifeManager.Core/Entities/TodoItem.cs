using System;

namespace LifeManager.Core.Entities
{
    public class TodoItem : BaseEntity
    {
        public string Content { get; set; } // Yapılacak iş
        public bool IsPlanned { get; set; } // True: Planlı, False: Plansız
        public DateTime? TargetDate { get; set; } // Planlıysa tarihi buraya yazarız
        public bool IsDone { get; set; } // Yapıldı mı?
    }
}