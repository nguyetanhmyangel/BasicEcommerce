using BasicEcommerce.Domain.Contracts;

namespace BasicEcommerce.Domain.Entities;

public class Customer : AuditableEntity<Guid>
{
    public required string Name { get; set; }
    public string? Mobile { get; set; }
    public string? Address { get; set; }
    public string? Phone { get; set; }
    public string? Fax { get; set; }
    public Guid CityId { get; set; }
    public string? PostalCode { get; set; }

    public virtual City City { get; set; }
}