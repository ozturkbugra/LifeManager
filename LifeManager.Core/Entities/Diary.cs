using System;

namespace LifeManager.Core.Entities
{
    public class Diary : BaseEntity
    {
        public string Title { get; set; }
        public string Content { get; set; }
        public string Mood { get; set; } // "Mutlu", "Yorgun"
        public DateTime DiaryDate { get; set; }
    }
}