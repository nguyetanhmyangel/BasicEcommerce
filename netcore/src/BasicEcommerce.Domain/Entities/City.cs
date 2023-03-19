using BasicEcommerce.Domain.Contracts;

namespace BasicEcommerce.Domain.Entities;

public class City : AuditableEntity<Guid>
{
    public Guid CountryId { get; set; }
    public required string Name { get; set; }
    
    public virtual Country Country { get; set; }
    public virtual ICollection<Customer> Customers { set; get; } = null!;
}