using BasicEcommerce.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BasicEcommerce.Infrastructure.FluentConfigurations;

public class OrderConfiguration : IEntityTypeConfiguration<Order>
{
    public void Configure(EntityTypeBuilder<Order> builder)
    {
        builder.Property(x => x.Address).HasMaxLength(50);
        builder.Property(x => x.PostalCode).HasMaxLength(10);
    }
}