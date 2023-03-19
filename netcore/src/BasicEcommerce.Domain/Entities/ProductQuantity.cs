using BasicEcommerce.Domain.Contracts;

namespace BasicEcommerce.Domain.Entities;

public class ProductQuantity : AuditableEntity<Guid>
{
    public Guid ProductId { get; set; }
    public Guid SizeId { get; set; }
    public Guid ColorId { get; set; }
    public Guid Quantity { get; set; }

    public virtual Product Product { get; set; }
    public virtual ProductSize ProductSize { get; set; }
    public virtual ProductColor Color { get; set; }
}