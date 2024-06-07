using Microsoft.EntityFrameworkCore;

namespace React_Asp_Crud.Models
{
    public class StudentDbContext : DbContext
    {
        public StudentDbContext(DbContextOptions options) : base(options) 
        {

        }

        public DbSet<Student> Students { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=DESKTOP-2BEGN3R; Database=ReactAspCrudTrain;Trusted_Connection=True;TrustServerCertificate=True;");
        }

    }
}
