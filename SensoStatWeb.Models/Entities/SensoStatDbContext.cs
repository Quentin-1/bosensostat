using Microsoft.EntityFrameworkCore;

namespace SensoStatWeb.Models.Entities
{
    public class SensoStatDbContext: DbContext
    {
        public DbSet<Administrator>? Administrators { get; set; }
        public DbSet<Answer>? Answers { get; set; }
        public DbSet<Instruction>? Instructions { get; set; }
        public DbSet<Product>? Products { get; set; }
        public DbSet<Question>? Questions { get; set; }
        public DbSet<Survey>? Surveys { get; set; }
        public DbSet<SurveyState>? SurveyStates { get; set; }
        public DbSet<User>? Users { get; set; }
        public DbSet<UserProduct>? UserProducts { get; set; }


        public SensoStatDbContext(DbContextOptions<SensoStatDbContext> options):base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Answer>(entity =>
            {
                entity.HasKey(a => new { a.UserId, a.QuestionId });
                entity.HasOne(a => a.User)
                .WithMany(u => u.Answers)
                .HasForeignKey(a => a.UserId)
                .OnDelete(DeleteBehavior.NoAction);

                entity.HasOne(a => a.Question)
                .WithMany(u => u.Answers)
                .HasForeignKey(a => a.QuestionId);
            });

            modelBuilder.Entity<UserProduct>(entity =>
            {
                entity.HasKey(us => new { us.UserId, us.ProductId });

                entity.HasOne(a => a.User)
                .WithMany(u => u.UserProducts)
                .HasForeignKey(a => a.UserId)
                .OnDelete(DeleteBehavior.NoAction);

                entity.HasOne(a => a.Product)
                .WithMany(u => u.UserProducts)
                .HasForeignKey(a => a.ProductId);
            });
        }

    }
}
