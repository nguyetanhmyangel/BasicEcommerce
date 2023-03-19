using BasicEcommerce.Domain.Contracts;
using BasicEcommerce.Domain.Enums;

namespace BasicEcommerce.Domain.Entities;

public class Bill : AuditableEntity<Guid>
{
    public Guid UserId { set; get; }
    public string? Address { get; set; }
    public string? Message { get; set; }
    public PaymentMethod PaymentMethod { set; get; }
    
    public virtual ICollection<BillDetail> BillsDetails { set; get; }
}