using BasicEcommerce.Domain.Contracts;

namespace BasicEcommerce.Domain.Entities;

public class ProductTag : AuditableEntity<Guid>
{
    public Guid ProductId { get; set; }
    public Guid TagId { get; set; }
        
    public virtual Product Product { get; set; }
    public virtual Tag Tag { get; set; }
}