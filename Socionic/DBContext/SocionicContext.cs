using Microsoft.EntityFrameworkCore;
using Socionic.Models;

namespace Socionic.DBContext;

public sealed class SocionicContext : DbContext
{
    private DbSet<Question> Questions { get; set; }
    private DbSet<AnswerOption> AnswerOptions { get; set; }
    private DbSet<PsychosophyTypes> PsychosophyTypes { get; set; }
    private DbSet<SocionicTypes> SocionicTypes { get; set; }
    public SocionicContext(DbContextOptions<SocionicContext> options) : base(options)
    {
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfigurationsFromAssembly(GetType().Assembly);
        base.OnModelCreating(modelBuilder);
    }
}