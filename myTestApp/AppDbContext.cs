using Microsoft.EntityFrameworkCore;

namespace myTestApp
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<ExpenseEntity> Expenses { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<ExpenseEntity>()
                .HasKey(e => e.Id);
        }
    }
}
