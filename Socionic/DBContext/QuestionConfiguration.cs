using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Socionic.Models;

namespace Socionic.DBContext;

public class QuestionConfiguration : IEntityTypeConfiguration<Question>
{
    public void Configure(EntityTypeBuilder<Question> builder)
    {
       
        builder.HasKey(q => q.Id);
        builder.Property(q => q.Value);
    }
}