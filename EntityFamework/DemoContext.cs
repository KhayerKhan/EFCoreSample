using Microsoft.EntityFrameworkCore;

namespace EntityFamework
{
    public class DemoContext :DbContext
    {
        public DemoContext(DbContextOptions options)
            : base(options)
        {

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }

        public DbSet<Student> Student { get; set; }
    }
}