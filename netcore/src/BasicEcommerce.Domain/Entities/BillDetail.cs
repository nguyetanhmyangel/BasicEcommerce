using BasicEcommerce.Domain.Contracts;

namespace BasicEcommerce.Domain.Entities;
public class BillDetail : AuditableEntity<Guid>
{
    public decimal Quantity { get; set; }
    public decimal Price { get; set; }
    public Guid BillId { get; set; }
    public Guid ProductId { get; set; }
    public Guid ColorId { get; set; }
    public Guid SizeId { get; set; }
    
    public virtual Bill Bill { set; get; }
    public virtual Product Product { set; get; }
    public virtual ProductColor ProductColor { set; get; }
    public virtual ProductSize ProductSize { set; get; }
}