using BasicEcommerce.Domain.Contracts;

namespace BasicEcommerce.Domain.Entities;

public class Country : AuditableEntity<Guid>
{
    public required string Name { get; set; }
    public Guid ContinentId { get; set; }
    public int? SortOrder { get; set; }

    public virtual Continent Continent { get; set; }
    public virtual ICollection<City> Cities { set; get; } = null!;
}