using BasicEcommerce.Domain.Contracts;

namespace BasicEcommerce.Domain.Entities;

public class ProductColor : AuditableEntity<Guid>
{
    public required string Name { get; set; }
    public required string Code { get; set; }

    public virtual ICollection<BillDetail> BillDetails { set; get; } = null!;
}