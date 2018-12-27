using MicroserviceTask.MessagingMicroservice.DataAccess.Entities;
using Microsoft.EntityFrameworkCore;

namespace MicroserviceTask.MessagingMicroservice.DataAccess
{
    public class MessengerContext : DbContext
    {
        public MessengerContext(DbContextOptions<MessengerContext> dbContextOptions) : base(dbContextOptions)
        {
            Database.EnsureDeleted();
            Database.EnsureCreated();
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            var adminUser = new Message
            {
                Id = 1,
                Recipients = new string[] { "Max","Anrii","Eugen" },
                Subject = "Test",
                Body = "This is test message",
                IsSent = true
            };
            modelBuilder.Entity<Message>().HasData(adminUser);
        }

        public DbSet<Message> Messages { get; set; }
    }
}
