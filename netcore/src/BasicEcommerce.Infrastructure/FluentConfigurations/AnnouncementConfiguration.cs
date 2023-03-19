using BasicEcommerce.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BasicEcommerce.Infrastructure.FluentConfigurations;

class AnnouncementConfiguration : IEntityTypeConfiguration<Announcement>
{
    public void Configure(EntityTypeBuilder<Announcement> builder)
    {
        //builder.HasKey(x => x.Id);
        builder.Property(x => x.Title).HasMaxLength(250);
        builder.Property(x => x.Content).HasMaxLength(250);
    }
}