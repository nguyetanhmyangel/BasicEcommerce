
using BasicEcommerce.Domain.Contracts;

namespace BasicEcommerce.Domain.Entities;

public class OrderDetail : AuditableEntity<Guid>
{
    public Guid OrderId { get; set; }
    public Guid ProductId { get; set; }
    public decimal? UnitPrice { get; set; }
    public short? Quantity { get; set; }
    public float? Discount { get; set; }
        
    public virtual Order Order { get; set; }
    public virtual Product Product { get; set; }
}