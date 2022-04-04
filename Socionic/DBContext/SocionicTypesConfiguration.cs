using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Socionic.Models;

namespace Socionic.DBContext;

public class SocionicTypesConfiguration : IEntityTypeConfiguration<SocionicTypes>
{
    public void Configure(EntityTypeBuilder<SocionicTypes> builder)
    {
        builder.HasKey(x => x.SocTypeId);
        builder.Property(x => x.SocName);
        builder.Property(x => x.Description);
    }
}