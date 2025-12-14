namespace LifeManager.Core.Entities
{
    public class PasswordRecord : BaseEntity
    {
        public string WebsiteName { get; set; } // Instagram, E-Devlet
        public string WebsiteUrl { get; set; }
        public string Username { get; set; }
        public string EncryptedPassword { get; set; } // Şifrelenmiş metin
        public string Note { get; set; }
    }
}