 using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace RepositoryPattern.MODEL
{
    public class DeveloperEntityTypeConfiguration:IEntityTypeConfiguration<Developer>
    {
        public void Configure(EntityTypeBuilder<Developer> builder)
        {
            builder.HasKey(c=>c.Id);
            builder.Property(c=>c.Name).IsRequired().HasMaxLength(128);
            builder.Property(c => c.Followers).IsRequired();
        }

    }
}
