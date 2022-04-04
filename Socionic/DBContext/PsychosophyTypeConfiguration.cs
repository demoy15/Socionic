using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Socionic.Models;

namespace Socionic.DBContext;

public class PsychosophyTypeConfiguration : IEntityTypeConfiguration<PsychosophyTypes>
{
    public void Configure(EntityTypeBuilder<PsychosophyTypes> builder)
    {
        builder.HasKey(x => x.PsyTypeId);
        builder.Property(x => x.PsyName);
        builder.Property(x => x.Description);
    }
}