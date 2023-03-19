
using BasicEcommerce.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BasicEcommerce.Infrastructure.FluentConfigurations;

public class AdvertisementConfiguration : IEntityTypeConfiguration<Advertisement>
{
    public void Configure(EntityTypeBuilder<Advertisement> builder)
    {
        builder.Property(x => x.Name).HasMaxLength(250);
        builder.Property(x => x.Description).HasMaxLength(250);
        builder.Property(x => x.ImagePath).HasMaxLength(250);
        builder.Property(x => x.Url).HasMaxLength(250);
        builder.Property(x => x.AdvertisementPositionId).HasMaxLength(20);

        //builder.Property(x => x.FirstName).IsRequired().HasMaxLength(200);
        //builder.Property(x => x.LastName).IsRequired().HasMaxLength(200);
        //builder.Property(x => x.Dob).IsRequired();
        //builder.HasOne(x => x.AdvertisementPosition).WithMany(x => x.AdvertisementPage).HasForeignKey(x => x.PositionId);
    }
}