using BasicEcommerce.Domain.Contracts;

namespace BasicEcommerce.Domain.Entities;

public class Continent : AuditableEntity<Guid>
{
    public required string Name { get; set; }

    public virtual ICollection<Country> Countries { set; get; } = null!;
}