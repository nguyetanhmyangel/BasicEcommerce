using BasicEcommerce.Domain.Contracts;

namespace BasicEcommerce.Domain.Entities;

public class WholePrice : AuditableEntity<Guid>
{
    public Guid ProductId { get; set; }
    public int FromQuantity { get; set; }
    public int ToQuantity { get; set; }
    public decimal Price { get; set; }
    
    public virtual Product Product { get; set; }
}