using BasicEcommerce.Domain.Contracts;

namespace BasicEcommerce.Domain.Entities;

public class ProductImage : AuditableEntity<Guid>
{
    public Guid ProductId { get; set; }
    public string? ImagePath { get; set; }
    public string? Caption { get; set; }
    
    public virtual Product Product { get; set; }
}