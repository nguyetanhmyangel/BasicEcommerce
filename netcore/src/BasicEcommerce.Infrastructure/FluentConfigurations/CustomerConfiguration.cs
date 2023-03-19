using BasicEcommerce.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BasicEcommerce.Infrastructure.FluentConfigurations;

public class CustomerConfiguration : IEntityTypeConfiguration<Customer>
{
    public void Configure(EntityTypeBuilder<Customer> builder)
    {
        builder.Property(x => x.Name).HasMaxLength(250);
        builder.Property(x => x.Mobile).HasMaxLength(50);
        builder.Property(x => x.Fax).HasMaxLength(50);
        builder.Property(x => x.Phone).HasMaxLength(50);
        builder.Property(x => x.Address).HasMaxLength(250);
        builder.Property(x => x.PostalCode).HasMaxLength(10);
    }
}