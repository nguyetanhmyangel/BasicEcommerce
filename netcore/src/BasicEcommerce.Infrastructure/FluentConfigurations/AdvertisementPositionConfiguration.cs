using BasicEcommerce.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BasicEcommerce.Infrastructure.FluentConfigurations;

public class AdvertisementPositionConfiguration : IEntityTypeConfiguration<AdvertisementPosition>
{
    public void Configure(EntityTypeBuilder<AdvertisementPosition> builder)
    {
        //builder.HasKey(x => x.Id);
        builder.Property(x => x.Name).HasMaxLength(250);
    }
}