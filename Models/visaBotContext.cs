using Microsoft.EntityFrameworkCore;

namespace visaBot.Models{
    public class visaBotContext: DbContext
    {
        public visaBotContext(DbContextOptions<visaBotContext> options) : base(options) { }

        public DbSet<User> users {get; set;}
    }
}