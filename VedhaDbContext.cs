using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace VedhaSadhana;

public class VedhaDbContext(DbContextOptions<VedhaDbContext> options) : DbContext(options)
{
    public DbSet<Guru> Guru { get; set; }
    public DbSet<Sishyulu> Sishya { get; set; }
    public DbSet<Expense> Expense { get; set; }
    public DbSet<LearningMaterial> LearningMaterial { get; set; }
    public DbSet<ExpenseCategory> ExpenseCategory { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<LearningMaterial>()
            .Property(lm => lm.MaterialType)
            .HasConversion(new EnumToStringConverter<MaterialType>());

        modelBuilder.Entity<LearningMaterial>()
            .Property(lm => lm.Subject)
            .HasConversion(new EnumToStringConverter<Subject>());

        modelBuilder.Entity<LearningMaterial>()
            .Property(lm => lm.SubjectType)
            .HasConversion(new EnumToStringConverter<SubjectType>());

        modelBuilder.Entity<Expense>()
            .Property(e => e.Amount)
            .HasColumnType("decimal(18, 2)");
    }
}
