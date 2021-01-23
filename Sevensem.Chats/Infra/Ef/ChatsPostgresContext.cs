using Microsoft.EntityFrameworkCore;

namespace Sevensem.Chats.Infra.Ef
{
    internal class ChatsPostgresContext : DbContext
    {
        private readonly string _connString;

        public ChatsPostgresContext(string connString)
        {
            _connString = connString;
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseNpgsql(_connString);
        }
        
        public DbSet<ChatMessageDao> ChatMessages { get; set; }
    }
}