using BasicEcommerce.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BasicEcommerce.Infrastructure.FluentConfigurations;

public class SlideConfiguration : IEntityTypeConfiguration<Slide>
{
    public void Configure(EntityTypeBuilder<Slide> builder)
    {
        builder.Property(x => x.Name).HasMaxLength(250);
        builder.Property(x => x.ImagePath).HasMaxLength(250);
        builder.Property(x => x.Url).HasMaxLength(250);
        builder.Property(x => x.GroupAlias).HasMaxLength(25);
    }
}