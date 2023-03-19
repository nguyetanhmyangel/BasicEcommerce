using BasicEcommerce.Domain.Contracts;

namespace BasicEcommerce.Domain.Entities;

public class Brand : AuditableEntity<Guid>
{
    public required string Name { get; set; }
    public string? Description { get; set; }
    public decimal Tax { get; set; } = default;
    
    public virtual ICollection<Product> Products { set; get; }
}