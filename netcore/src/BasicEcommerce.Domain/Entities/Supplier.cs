using BasicEcommerce.Domain.Contracts;

namespace BasicEcommerce.Domain.Entities;

public class Supplier : AuditableEntity<Guid>
{
    public required string Name { get; set; }
    public Guid CityId { get; set; }
    public Guid RegionId { get; set; }
    public string? Address { get; set; }
    public string? PostalCode { get; set; }
    public string? Phone { get; set; }
    public string? Email { get; set; }
    public string? Fax { get; set; }
    public string? HomePage { get; set; }
    
    public virtual City City { get; set; }
}