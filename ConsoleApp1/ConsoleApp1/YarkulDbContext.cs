using Microsoft.EntityFrameworkCore;

namespace ConsoleApp1
{
    public class YarkulDbContext : DbContext
    {
        public YarkulDbContext(DbContextOptions<YarkulDbContext> options)
                : base(options) { }
        public DbSet<Person> Persons { get; set; }
    }
}