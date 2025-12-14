using LifeManager.Core.Entities;
using Microsoft.EntityFrameworkCore;

namespace LifeManager.DataAccess.Contexts
{
    public class LifeManagerDbContext : DbContext
    {
        // Constructor: Dışarıdan ayar alabilmek için (Bağlantı adresi vs.)
        public LifeManagerDbContext(DbContextOptions<LifeManagerDbContext> options) : base(options)
        {
        }

        // Tablolarımızı (DbSet) Tanımlıyoruz
        public DbSet<User> Users { get; set; }
        public DbSet<Account> Accounts { get; set; }
        public DbSet<Transaction> Transactions { get; set; }

        public DbSet<Ingredient> Ingredients { get; set; }
        public DbSet<Contact> Contacts { get; set; }
        public DbSet<Debt> Debts { get; set; }

        public DbSet<PasswordRecord> PasswordRecords { get; set; }

        public DbSet<Diary> Diaries { get; set; }
        public DbSet<Location> Locations { get; set; }
        public DbSet<TodoItem> TodoItems { get; set; }

        // Veritabanı kurallarını ve ayarlarını burada yapıyoruz
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Örnek: Para alanlarını (Decimal) hassas ayarlayalım (SQL hatası almamak için)
            modelBuilder.Entity<Transaction>().Property(x => x.Amount).HasColumnType("decimal(18,2)");
            modelBuilder.Entity<Account>().Property(x => x.Balance).HasColumnType("decimal(18,2)");
            modelBuilder.Entity<Debt>().Property(x => x.Amount).HasColumnType("decimal(18,2)");

            // İlişkileri netleştirelim (Opsiyonel ama sağlamlık için iyidir)
            // Transaction silinirse User silinmesin (Restrict)
            modelBuilder.Entity<Transaction>()
                .HasOne(t => t.User)
                .WithMany(u => u.Transactions)
                .HasForeignKey(t => t.UserId)
                .OnDelete(DeleteBehavior.Restrict);

            base.OnModelCreating(modelBuilder);
        }
    }
}