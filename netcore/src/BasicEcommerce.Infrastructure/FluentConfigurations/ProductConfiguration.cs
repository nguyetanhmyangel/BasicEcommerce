using BasicEcommerce.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BasicEcommerce.Infrastructure.FluentConfigurations;

public class ProductConfiguration : IEntityTypeConfiguration<Product>
{
    public void Configure(EntityTypeBuilder<Product> builder)
    {
        builder.Property(x => x.Name).HasMaxLength(250);
        builder.Property(x => x.Description).HasColumnType("nvarchar(max)");
        builder.Property(x => x.ImagePath).HasMaxLength(205);
        builder.Property(x => x.SeoAlias).HasMaxLength(250);
        builder.Property(x => x.SeoDescription).HasMaxLength(250);
        builder.Property(x => x.SeoKeywords).HasMaxLength(250);
        builder.Property(x => x.SeoPageTitle).HasMaxLength(250);
    }
}