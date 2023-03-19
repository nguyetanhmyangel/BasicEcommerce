using BasicEcommerce.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BasicEcommerce.Infrastructure.FluentConfigurations;

public class AdvertisementPageConfiguration : IEntityTypeConfiguration<AdvertisementPage>
{
    public void Configure(EntityTypeBuilder<AdvertisementPage> builder)
    {
        //builder.HasKey(x => x.Id);
        builder.Property(x => x.Name).HasMaxLength(250);
    }
}