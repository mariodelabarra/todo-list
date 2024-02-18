using Microsoft.EntityFrameworkCore;

namespace TodoList.Platform.Item.Repositories
{
    public class ItemDbContext : DbContext
    {
        public DbSet<Domain.Task> Tasks { get; set; }

        public ItemDbContext(DbContextOptions<ItemDbContext> options) : base(options)
        {
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
        }
    }
}
